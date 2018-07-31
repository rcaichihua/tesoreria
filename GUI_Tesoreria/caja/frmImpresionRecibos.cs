using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmImpresionRecibos : DevComponents.DotNetBar.Metro.MetroForm
    {
        //reportClass cn = new reportClas();
        CNegocio cn = new CNegocio();
        string recibo = "reciboCentral";
        ReportDocument report = new ReportDocument();
        string nombreImpresora;
        DataTable resuImpr = new DataTable();

        public frmImpresionRecibos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            report = (ReportDocument)crvReportes.ReportSource;
            if (VariablesMetodosEstaticos.id_programa != 1)
            {
                recibo = "reciboCaja";
            }
            var doctoPrint = new System.Drawing.Printing.PrintDocument();

            resuImpr = cn.TraerDataset("usp_obtiene_printer_por_mac", VariablesMetodosEstaticos.mac_id).Tables[0];

            if (resuImpr.Rows.Count <= 0)
            {
                nombreImpresora = "EPSON FX-890 ESC/P";
            }
            else
            {
                nombreImpresora = resuImpr.Rows[0][0].ToString();
            }

            doctoPrint.PrinterSettings.PrinterName = nombreImpresora;//"EPSON FX-890"; //printer es el nombre de la impresora por donde imprimirá

            for (var j = 0; j < doctoPrint.PrinterSettings.PaperSizes.Count; j++)
                if (doctoPrint.PrinterSettings.PaperSizes[j].PaperName == recibo) //tamañoPapel es el nombre del tamaño parametrizado
                {
                    report.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)doctoPrint.PrinterSettings.PaperSizes[j].RawKind;
                    report.PrintOptions.PrinterName = nombreImpresora;
                    break;
                }
            report.PrintToPrinter(1, false, 0, 0);
        }
    }
}
