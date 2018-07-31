using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.DGAI
{
    public partial class frmAgregarRubrosDGAI : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        bool save = false;

        public frmAgregarRubrosDGAI()
        {
            InitializeComponent();
        }

        private void frmAgregarRubrosDGAI_Load(object sender, EventArgs e)
        {
            cargarTarifario();
        }

        private void cargarTarifario()
        {
            try
            {
                dgvTarifario.DataSource = cn.TraerDataset("usp_filtra_tarifa_rubros", txtBusqueda.Text.Trim(), txtRubro.Text.Trim()
                    , 3).Tables[0];
                dgvTarifario.Refresh();
            }
            catch (Exception)
            {

            }
        }
        public DataSet traerFormulario()
        {
            this.ShowDialog();

            DataSet detalleProd = new DataSet("detalleProd");
            DataTable tablaDetalle = detalleProd.Tables.Add("datos");

            tablaDetalle.Columns.Add("intRuId", typeof(Int32));
            tablaDetalle.Columns.Add("CodRubro", typeof(string));
            tablaDetalle.Columns.Add("descripcion", typeof(string));
            tablaDetalle.Columns.Add("Precio", typeof(decimal));
            tablaDetalle.Columns.Add("cantidad", typeof(Int32));

            if (save)
            {
                tablaDetalle.Rows.Add(1);
                tablaDetalle.Rows[0][0] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["intRuId"].Value.ToString() == "" ? 0 : dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["intRuId"].Value;
                tablaDetalle.Rows[0][1] = Convert.ToInt32(dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["CodRubro"].Value);
                tablaDetalle.Rows[0][2] = dgvTarifario.Rows[dgvTarifario.CurrentRow.Index].Cells["descripcion"].Value;


                tablaDetalle.Rows[0][3] = Convert.ToDecimal(txtPrecio.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtPrecio.Text));
                tablaDetalle.Rows[0][4] = Convert.ToDecimal(txtPrecio.Text.Trim() == string.Empty ? 0.00m : Convert.ToDecimal(txtCantidad.Text));
            }
            return detalleProd;
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

        private void txtRubro_TextChanged(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            cargarTarifario();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtRubro.Clear();
            cargarTarifario();
        }
    }
}
