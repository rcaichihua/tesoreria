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
    public partial class frmInformeDeudasPorAnio : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        DataTable dtDatosReporte;
        private static frmInformeDeudasPorAnio frmInstance = null;

        public frmInformeDeudasPorAnio()
        {
            InitializeComponent();
        }

        public static frmInformeDeudasPorAnio Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmInformeDeudasPorAnio();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmInformeDeudasPorAnio_Load(object sender, EventArgs e)
        {
            CalcularDeuda();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CalcularDeuda();
        }

        private void CalcularDeuda()
        {
            dtDatosReporte = new DataTable();
            dtDatosReporte = cn.TraerDataset("usp_calculo_morosos", "2006", "2019"/*,dtpFechaCalculo.Value.ToShortDateString()*/).Tables[0];

            if (dtDatosReporte.Rows.Count > 0)
            {
                canevaro.Reportes.rptDeudasCruzadasPorAnio rptDeuda = new canevaro.Reportes.rptDeudasCruzadasPorAnio();

                rptDeuda.SetDataSource(dtDatosReporte);

                rptDeuda.SetParameterValue("@fechaingreso", DateTime.Now.ToShortDateString());

                crystalReportViewer1.ReportSource = rptDeuda;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
               , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
