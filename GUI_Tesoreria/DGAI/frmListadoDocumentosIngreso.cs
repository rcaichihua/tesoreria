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
    public partial class frmListadoDocumentosIngreso : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public int nroliqui { get; set; }

        public frmListadoDocumentosIngreso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoDocumentosIngreso_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            try
            {
                dgvCabecera.DataSource = cn.TraerDataset("usp_listar_liquidacion", nroliqui).Tables[0];
               

                if (dgvCabecera.Rows.Count == 0)
                {
                    DataTable dt, dt2;
                    dt = (DataTable)dgvDetalle.DataSource;
                    if (dt != null)
                    {
                        dt2 = dt.Clone();
                        dgvDetalle.DataSource = dt2;
                    }
                }
                sumarColumnas();
            }
            catch (Exception)
            {
            }
        }

        private void sumarColumnas()
        {
            try
            {
                decimal importe = 0.00m;

                for (int i = 0; i < dgvCabecera.RowCount; i++)
                {
                    importe = importe + Convert.ToDecimal(dgvCabecera.Rows[i].Cells[7].Value);
                }
                txtTotalIngreso.Text = importe.ToString("##,##0.00");
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        private void dgvCabecera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalle();
        }

        private void llenarDetalle()
        {
            int indice = 0;

            if (dgvCabecera.Rows.Count > 0)
            {
                indice = dgvCabecera.CurrentRow.Index;

                dgvDetalle.DataSource = cn.TraerDataset("usp_listar_detalle_liquidacion", dgvCabecera.Rows[indice].Cells[0].Value).Tables[0];
            }
        }

        private void dgvCabecera_Click(object sender, EventArgs e)
        {
            llenarDetalle();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int indice = 0;

            if (dgvCabecera.Rows.Count == 0)
            {
                return;
            }

            indice = dgvCabecera.CurrentRow.Index;

            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de anular el documento de ingreso Nº " + dgvCabecera.Rows[dgvCabecera.CurrentRow.Index].Cells[1].Value + "?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                cn.EjecutarSP("usp_anular_documento_ingreso", dgvCabecera.Rows[indice].Cells[0].Value);

                DevComponents.DotNetBar.MessageBoxEx.Show("Anulado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);

                buscar();
            }
        }

        private void dgvCabecera_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalle();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporte winReport = new frmReporte();
            reporte.rptListadoDocIngreso rptRecibo = new reporte.rptListadoDocIngreso();
            rptRecibo.SetDataSource(cn.TraerDataset("usp_listar_cabecera_detalle_docs_ingreso", nroliqui).Tables[0]);         
            winReport.crvReportes.ReportSource = rptRecibo;
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }
    }
}