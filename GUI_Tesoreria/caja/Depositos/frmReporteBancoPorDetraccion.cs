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
    public partial class frmReporteBancoPorDetraccion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmReporteBancoPorDetraccion()
        {
            InitializeComponent();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            CNegocio cn = new CNegocio();

            DataTable dtResu = new DataTable();
            dtResu = cn.TraerDataset("USP_DEPOSITO_CONSULTAS_2", 6, dtpFecha.Value.ToString("yyyyMMdd"), "1").Tables[0];

            if (dtResu.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmReporte winReport = new frmReporte();
            Reportes.rptDetraccion rptRecibo = new Reportes.rptDetraccion();
            rptRecibo.SetDataSource(dtResu);
            winReport.crvReportes.ReportSource = rptRecibo;
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
