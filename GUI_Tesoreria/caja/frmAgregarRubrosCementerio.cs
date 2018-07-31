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
    public partial class frmAgregarRubrosCementerio : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        bool save= false;

        public frmAgregarRubrosCementerio()
        {
            InitializeComponent();
        }

        //private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        //{
        //    txtRubro.Clear();
        //    CargaDatosTarifario();
        //}

        private void CargaDatosTarifario()
        {
            if (rdbNicho.Checked)
            {
                cargarTarifario(txtBusqueda.Text,"0000","ni");
            }
            else if (rdbSepultura.Checked)
            {
                cargarTarifario(txtBusqueda.Text, "0000", "se");
            }
            else if (rdbMausoleo.Checked)
            {
                cargarTarifario(txtBusqueda.Text, "0000", "ma");
            }
            else if (rdbServicios.Checked)
            {
                cargarTarifario(txtBusqueda.Text, "0000", "sv");
            }
        }

        public DataSet traerFormulario()
        {
            this.ShowDialog();

            DataSet detalleProd = new DataSet("detalleProd");
            DataTable tablaDetalle = detalleProd.Tables.Add("datos");

            tablaDetalle.Columns.Add("id_cuenta_contable", typeof(Int32));
            tablaDetalle.Columns.Add("intTaId", typeof(Int32));
            tablaDetalle.Columns.Add("CodRubro", typeof(string));
            tablaDetalle.Columns.Add("descripcion", typeof(string));
            tablaDetalle.Columns.Add("Precio", typeof(decimal));
            tablaDetalle.Columns.Add("cantidad", typeof(Int32));
            tablaDetalle.Columns.Add("descuento", typeof(decimal));
            tablaDetalle.Columns.Add("cementerio", typeof(string));


            if (save)
            {
                tablaDetalle.Rows.Add(1);
                tablaDetalle.Rows[0][0] = Convert.ToInt32(dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["id_cuenta_contable"].Value);
                tablaDetalle.Rows[0][1] = Convert.ToInt32(dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["intTaId"].Value);
                tablaDetalle.Rows[0][2] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["CodRubro"].Value;
                if (txtGlosaPorRubro.Text.Trim() == string.Empty)
                {
                    tablaDetalle.Rows[0][3] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["descripcion"].Value;
                }
                else
                {
                    tablaDetalle.Rows[0][3] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["descripcion"].Value.ToString() + " / " + txtGlosaPorRubro.Text.Trim().ToString();
                }               
                tablaDetalle.Rows[0][4] = Convert.ToDecimal(txtPrecio.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtPrecio.Text));
                tablaDetalle.Rows[0][5] = Convert.ToInt32(txtCantidad.Text.Trim() == string.Empty ? 0.00m : Convert.ToInt32(txtCantidad.Text));
                tablaDetalle.Rows[0][6] = 0.00m;
                tablaDetalle.Rows[0][7] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["varCeNombre"].Value;
            }
            return detalleProd;
        }

        private void cargarTarifario(string nombre,string rubro, string tipo)
        {
            try
            {
                dgvTarifario.DataSource = cn.TraerDataset("usp_filtra_tarifa_cementerio", nombre, rubro, tipo).Tables[0];
            }
            catch (Exception)
            {
                
            }
        }

        private void txtRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
            if (e.KeyChar == 13)
            {
                if (txtRubro.Text != string.Empty)
                {
                    if (rdbNicho.Checked)
                    {
                        cargarTarifario("", txtRubro.Text.Trim(), "ni");
                    }
                    else if (rdbSepultura.Checked)
                    {
                        cargarTarifario("", txtRubro.Text.Trim(), "se");
                    }
                    else if (rdbMausoleo.Checked)
                    {
                        cargarTarifario("", txtRubro.Text.Trim(), "ma");
                    }
                    else if (rdbServicios.Checked)
                    {
                        cargarTarifario("", txtRubro.Text.Trim(), "sv");
                    }
                }
            }
        }

        private void frmAgregarRubrosCementerio_Load(object sender, EventArgs e)
        {
            cargarTarifario("","0000","ni");
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(txtPrecio.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtPrecio.Text)) == 0.00m)
            if(txtPrecio.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un valor correcto para el precio", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(txtCantidad.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtCantidad.Text)) == 0)
            {
                MessageBox.Show("Ingrese un valor correcto para la cantidad", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            save = true;
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void rdbNicho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNicho.Checked == true) cargarTarifario("","0000","ni");
        }

        private void rdbSepultura_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSepultura.Checked == true) cargarTarifario("","0000","se");
        }

        private void rdbMausoleo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMausoleo.Checked == true) cargarTarifario("","0000","ma");
        }

        private void rdbServicios_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbServicios.Checked == true) cargarTarifario("","0000","sv");
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

        private void button1_Click(object sender, EventArgs e)
        {
            //txtRubro.Clear();
            CargaDatosTarifario();
        }

        private void BtnSalirC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
