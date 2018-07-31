using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Depositos
{
    public partial class frmReporteBancoPorPrograma : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmReporteBancoPorPrograma()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            CNegocio cn = new CNegocio();

            frmReporte winReport = new frmReporte();
            Reportes.rptDepositos1 rptRecibo = new Reportes.rptDepositos1();
            rptRecibo.SetDataSource(cn.TraerDataset("USP_DEPOSITO_CONSULTAS_2",chkMismoMes.Checked ? 0 : 2,dtpFecha.Value.ToShortDateString(),"1").Tables[0]);
            winReport.crvReportes.ReportSource = rptRecibo;
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }
    }
}
