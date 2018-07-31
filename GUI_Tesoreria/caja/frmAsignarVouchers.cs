using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
namespace GUI_Tesoreria.caja
{
    public partial class frmAsignarVouchers : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public int idCajero { get; set; }
        public DateTime FechaCaja { get; set; }
        public int IdIngEfecDepo { get; set; }
        public decimal importe { get; set; }

        CNegocio cn = new CNegocio();

        public frmAsignarVouchers()
        {
            InitializeComponent();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (dgvAsigna.RowCount - 1)); i++)
            {
            dgvAsigna.Rows[i].Cells["seleccion"].Value = Convert.ToBoolean(1);
            }
        }

        private void rdbNinguno_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (dgvAsigna.RowCount - 1)); i++)
            {
                dgvAsigna.Rows[i].Cells["seleccion"].Value = 0;
            }
        }

        private void dgvAsigna_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsigna.Columns[e.ColumnIndex].Name == "seleccion")
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dgvAsigna.Rows[e.RowIndex].Cells["seleccion"];

                if (checkCell.Value == DBNull.Value)
                {
                    checkCell.Value = false;

                }
                if (Convert.ToBoolean(checkCell.Value) == true)
                {
                    dgvAsigna.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                    dgvAsigna.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

                    dgvAsigna.Rows[e.RowIndex].Cells[4].Value = 0;
                }
                SumaTotales();
            }
        }

        private void SumaTotales()
        {
            decimal sumaTotal = 0.00m;

            foreach (DataGridViewRow row in dgvAsigna.Rows)
            {
                if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true)
                {
                    sumaTotal = sumaTotal + Convert.ToDecimal(row.Cells["importe"].Value);
                }
            }

            txtTotal.Text = sumaTotal.ToString("##,##0.00");
        }

        private void frmAsignarVouchers_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAsigna.DataSource = cn.TraerDataset("usp_ingreso_por_documento", FechaCaja, idCajero, IdIngEfecDepo).Tables[0];
                lblNroRecibos.Text = dgvAsigna.Rows.Count.ToString();
                foreach (DataGridViewRow row in dgvAsigna.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true)
                    {
                        SumaTotales();
                    }
                }
                if (txtTotal.Text != "0.00")
                {
                    btnGuardar.Enabled = false;
                    grbSeleccionar.Enabled = false;
                    dgvAsigna.ReadOnly = true;
                }
                //foreach (DataGridViewColumn dc in dgvAsigna.Columns)
                //{
                //    if (dc.ValueType == typeof(Boolean))
                //    {
                //        dc.ValueType = typeof(Int32);
                //        ((DataGridViewCheckBoxColumn)dc).DefaultCellStyle.NullValue = 0;
                //        ((DataGridViewCheckBoxColumn)dc).TrueValue = 1;
                //        ((DataGridViewCheckBoxColumn)dc).FalseValue = 0;
                //    }
                //}

            }
            catch (Exception)
            {
            }            
        }

        private void dgvAsigna_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAsigna.IsCurrentCellDirty)
            {
                dgvAsigna.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (importe < Convert.ToDecimal(txtTotal.Text))
            {
                MessageBox.Show("El monto del voucher no coincidi con el total de los recibos seleccionados.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            try
            {
                int contador = 0;

                foreach (DataGridViewRow row in dgvAsigna.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true)
                    {
                        contador = contador + 1;

                        if (cn.EjecutarSP("usp_inserta_asignacion_vouchers_efectivo_cheque", IdIngEfecDepo, Convert.ToInt32(row.Cells["ReciboID"].Value)
                            , row.Cells["Recibo"].Value, row.Cells["Solicitante_ReciboCabecera"].Value, Convert.ToDecimal(row.Cells["Importe"].Value)
                            , VariablesMetodosEstaticos.varUsuario, VariablesMetodosEstaticos.host_user + " / " + VariablesMetodosEstaticos.ip_user) != 1)
                        {
                            MessageBox.Show("Ocurrio un error interno al registrar los vouchers. Contacte con Sistemas.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            //break;
                            return;
                        }
                    }
                }

                if (contador == 0)
                {
                    MessageBox.Show("No ha seleccionado ningun recibo, antes de guardar, seleccione los recibos correspondientes.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Los recibos fueron asignados correctamente al voucher.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
