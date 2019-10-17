using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Deposito
{
    public partial class frmReporteRegularizacion : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmReporteRegularizacion()
        {
            InitializeComponent();
        }

        CNegocio cn = new CNegocio();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbDepoSinProgRegu.Checked)
            {
                frmReporte win = new frmReporte();
                DataSet dsDatos = new DataSet();

                dsDatos = cn.TraerDataset("USP_DEPOSITO_CONSULTAS_2",8, dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "1");

                if (dsDatos.Tables[0].Rows.Count<=0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                win.TipoReporteLiquidacion = "DEPSINPR";
                win.dtR = dsDatos.Tables[0];
                win.ShowDialog();
            }
            else if (rbLiqEnElMesDepoMesSigu.Checked)
            {
                frmReporte win = new frmReporte();
                DataSet dsDatos = new DataSet();

                dsDatos = cn.TraerDataset("USP_DEPOSITO_CONSULTAS_2", 9,dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "1");

                if (dsDatos.Tables[0].Rows.Count <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                win.TipoReporteLiquidacion = "MESSIG";
                win.dtR = dsDatos.Tables[0];
                win.ShowDialog();
            }
            else if (rbLiqEnElMesDepoMesAnt.Checked)
            {
                frmReporte win = new frmReporte();
                DataSet dsDatos = new DataSet();

                dsDatos = cn.TraerDataset("USP_DEPOSITO_CONSULTAS_2", 10,dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "1");

                if (dsDatos.Tables[0].Rows.Count <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                win.TipoReporteLiquidacion = "MESANT";
                win.dtR = dsDatos.Tables[0];
                win.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
