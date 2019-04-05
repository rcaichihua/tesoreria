using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using GUI_Tesoreria.cementerio;

namespace GUI_Tesoreria.cementerio.inventario
{
    public partial class frmListadoTituloNicho : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        int indice = 0;
        public frmListadoTituloNicho()
        {
            InitializeComponent();
        }

        private void frmListadoTituloNicho_Load(object sender, EventArgs e)
        {
            cargarTitulos();
        }

        private void cargarTitulos()
        {
            CNegocio cn = new CNegocio();

            dgvTitulos.DataSource = 
                cn.TraerDataset("USP_SELECT_TITULONICHO").Tables[0];
            if(txtColumna.Text=="0")
            {
                txtColumna.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerTitulo_Click(object sender, EventArgs e)
        {
            CNegocio cn = new CNegocio();
            frmReporte winReport = new frmReporte();
            DataSet dtsTitulo = new DataSet();

            if (dgvTitulos.Rows.Count > 0)
            {
                indice = dgvTitulos.CurrentRow.Index;

                dtsTitulo = cn.TraerDataset("usp_listar_titulos", dgvTitulos.Rows[indice].Cells["CODCUARTEL"].Value,
               dgvTitulos.Rows[indice].Cells["LETRAFILANICHO"].Value, Convert.ToInt32(dgvTitulos.Rows[indice].Cells["NUMEROCOLNICHO"].Value));

                dtsTitulo.Tables[0].TableName = "DETALLETITULO";
                dtsTitulo.Tables[1].TableName = "CABECERATITULO";
                reportes.rptTituloNicho rptRecibo = new reportes.rptTituloNicho();
                rptRecibo.SetDataSource(dtsTitulo);
                winReport.crvReportes.ReportSource = rptRecibo;

                winReport.WindowState = FormWindowState.Maximized;
                winReport.ShowDialog();
            }
            else
            {
                indice = 0;
            }          
        }

        private void txtColumna_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            CNegocio cn = new CNegocio();
            if (txtNombreCuartel.Text.Trim() == string.Empty)
            {
                cargarTitulos();
                return;
            }

            dgvTitulos.DataSource =
                cn.TraerDataset("USP_SELECT_TITULONICHO_FILTRO",
                txtCodigoCuartel.Text,txtFila.Text.Trim(),Convert.ToInt32(txtColumna.Text.Trim())).Tables[0];
            if (txtColumna.Text=="0")
            {
                txtColumna.Clear();
            }
        }

        private Boolean Validar()
        {
            Boolean valor=true;

            //if (txtCodigoCuartel.Text==string.Empty)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Cuartel");
            //    valor = false;
            //    return valor;
            //}
            //if(txtNombreCuartel.Text == string.Empty)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Cuartel");
            //    valor = false;
            //    return valor;
            //}
            //if (txtFila.Text == string.Empty)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una fila");
            //    valor = false;
            //    return valor;
            //}
            if (txtColumna.Text == string.Empty)
            {
                txtColumna.Text = "0";
                valor = true;
                return valor;
            }
            return valor;
        }

        private void txtNombreCuartel_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (e.KeyChar==13)
            {
                BuscarCuartel();
            }
        }
        private void BuscarCuartel()
        {
            CNegocio cn = new CNegocio();
            try
            {
                if (txtNombreCuartel.Text.ToString().Length > 0)
                {
                    DataSet ds = new DataSet();
                    ds = cn.TraerDataset("usp_select_cuartel_like", txtNombreCuartel.Text.Trim(), "N");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultado.DataSource = ds.Tables[0];
                        dgvResultado.Visible = true;
                        dgvResultado.BringToFront();
                    }
                    else
                    {
                        dgvResultado.Visible = false;
                    }
                }
                else
                {
                    txtCodigoCuartel.Clear();
                    dgvResultado.Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OcultarGrilla();
        }

        private void OcultarGrilla()
        {
            try
            {
                txtCodigoCuartel.Text = dgvResultado.CurrentRow.Cells[0].Value.ToString();
                txtNombreCuartel.Text = dgvResultado.CurrentRow.Cells[3].Value.ToString();

                dgvResultado.Visible = false;
            }
            catch (Exception)
            {

            }
        }
    }
}

