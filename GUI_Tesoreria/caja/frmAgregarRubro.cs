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
    public partial class frmAgregarRubro : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        bool save = false;

        public frmAgregarRubro()
        {
            InitializeComponent();
        }

        public DataSet traerFormulario()
        {
            this.ShowDialog();

            DataSet detalleProd = new DataSet("detalleProd");
            DataTable tablaDetalle = detalleProd.Tables.Add("datos");

            tablaDetalle.Columns.Add("id_cuenta_contable", typeof(Int32));
            tablaDetalle.Columns.Add("intRuId", typeof(Int32));
            tablaDetalle.Columns.Add("CodRubro", typeof(string));
            tablaDetalle.Columns.Add("descripcion", typeof(string));
            tablaDetalle.Columns.Add("Precio", typeof(decimal));
            tablaDetalle.Columns.Add("cantidad", typeof(Int32));
            tablaDetalle.Columns.Add("descuento", typeof(decimal));
            tablaDetalle.Columns.Add("cementerio", typeof(string));

            if (save)
            {
                tablaDetalle.Rows.Add(1);
                tablaDetalle.Rows[0][0] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["id_cuenta_contable"].Value.ToString() == "" ? 0 : dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["id_cuenta_contable"].Value;
                tablaDetalle.Rows[0][1] = Convert.ToInt32(dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["intRuId"].Value);
                tablaDetalle.Rows[0][2] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["CodRubro"].Value;
                
                if (VariablesMetodosEstaticos.id_programa==5 || VariablesMetodosEstaticos.id_programa==6)
                {
                    if (txtDel.Text == "0" && txtAl.Text == "0")
                    {
                        tablaDetalle.Rows[0][3] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["descripcion"].Value.ToString();
                    }
                    else
                    {
                        tablaDetalle.Rows[0][3] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["descripcion"].Value.ToString() + " / " + txtGlosaPorRubro.Text.Trim().ToString() + " " + txtDel.Text + " al " + txtAl.Text;
                    }
                }
                else
                {
                    tablaDetalle.Rows[0][3] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["descripcion"].Value.ToString();
                }
                tablaDetalle.Rows[0][4] = Convert.ToDecimal(txtPrecio.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtPrecio.Text));
                tablaDetalle.Rows[0][5] = Convert.ToInt32(txtCantidad.Text.Trim() == string.Empty ? 0.00m : Convert.ToInt32(txtCantidad.Text));
                tablaDetalle.Rows[0][6] = Convert.ToDecimal(txtDescuento.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtDescuento.Text));
                tablaDetalle.Rows[0][7] = "";
            }
            return detalleProd;
        }

        private void frmAgregarRubro_Load(object sender, EventArgs e)
        {
            cargarTarifario();

            if (VariablesMetodosEstaticos.idcaja > 15)
            {
                dgvGlosa.Visible = true;
            }
            else
            {
                dgvGlosa.Visible = false;
            }
        }

        private void cargarTarifario()
        {
            try
            {
                dgvTarifario.DataSource = cn.TraerDataset("usp_filtra_tarifa_rubros", txtBusqueda.Text.Trim(), txtRubro.Text.Trim(),VariablesMetodosEstaticos.id_programa).Tables[0];
                dgvTarifario.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtRubro.Clear();
            cargarTarifario();
        }

        private void txtRubro_TextChanged(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            cargarTarifario();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtPrecio.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtPrecio.Text)) == 0.00m)
            {
                if (dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["id_cuenta_contable"].Value.ToString() != "")
                {
                    MessageBox.Show("Ingrese un valor correcto para el precio", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecio.Focus();
                    return;
                }
            }
            if (Convert.ToInt32(txtCantidad.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtCantidad.Text)) == 0)
            {
                MessageBox.Show("Ingrese un valor correcto para la cantidad", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }

            save = true;
            this.Close();
        }

        private void dgvTarifario_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtPrecio.Text = Convert.ToDecimal(dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["Precio"].Value).ToString("##,##0.00");
                if (Convert.ToDecimal(txtPrecio.Text) > 0)
                {
                    txtPrecio.ReadOnly = true;
                }
                else
                {
                    txtPrecio.ReadOnly = false;
                }

                txtCantidad.Text = "1";
            }
            catch (Exception)
            {
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);

            if (e.KeyChar == 13)
            {
                txtCantidad.Text = (Convert.ToInt32(txtAl.Text) - Convert.ToInt32(txtDel.Text) + 1).ToString();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
