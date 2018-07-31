using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmReporteResidentes : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmReporteResidentes frmInstance = null;
        CNegocio cn = new CNegocio();
        DataTable dtDatosReporte;

        public frmReporteResidentes()
        {
            InitializeComponent();
        }
        public static frmReporteResidentes Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmReporteResidentes();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmReporteResidentes_Load(object sender, EventArgs e)
        {
            dtDatosReporte = new DataTable();
            dtDatosReporte = cn.TraerDataset("usp_select_tb_residente_por_direccion").Tables[0];
            if (dtDatosReporte.Rows.Count > 0)
            {
                canevaro.Reportes.rptResidentes rptDeuda = new canevaro.Reportes.rptResidentes();

                rptDeuda.SetDataSource(dtDatosReporte);

                crystalReportViewer1.ReportSource = rptDeuda;
            }
            else
            {
                MessageBox.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
               , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
