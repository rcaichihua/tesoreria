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

            DataTable dtResu = new DataTable();
            dtResu = cn.TraerDataset("USP_DEPOSITO_CONSULTAS_2", chkMismoMes.Checked ? 2 : 0, dtpFecha.Value.ToString("yyyyMMdd"), "1").Tables[0];

            if (dtResu.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmReporte winReport = new frmReporte();
            Reportes.rptDepositos1 rptRecibo = new Reportes.rptDepositos1();
            rptRecibo.SetDataSource(dtResu);
            winReport.crvReportes.ReportSource = rptRecibo;
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }
    }
}
