using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmFiltroFechaIngresos : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmFiltroFechaIngresos frmInstance = null;
        public static frmFiltroFechaIngresos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmFiltroFechaIngresos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        CNegocio cn = new CNegocio();
        DataTable dtResu = new DataTable();
        String Tipo="";
        public frmFiltroFechaIngresos()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DateTime dateValue;
            frmReporte winR = new frmReporte();
            winR.MdiParent = this.MdiParent;
            if (DateTime.TryParse(mtbFechaLiquidacion.Text, out dateValue))
            {
                if (chkIngresoDiario.Checked)
                {
                    dtResu = cn.TraerDataset("usp_Reporte_Ingresos", Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd")).Tables[0];
                    Tipo = "ID";
                    if (dtResu.Rows.Count<=0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else if (chkReciboIngresos.Checked)
                {
                    dtResu = cn.TraerDataset("usp_Reporte_recibosEmitidos", Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd")).Tables[0];
                    Tipo = "RE";
                    if (dtResu.Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                winR.TipoReporteLiquidacion = Tipo;
                winR.dtR = dtResu;
                winR.Show();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese una fecha de liquidación válida", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbFechaLiquidacion.Focus();
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFiltroFechaIngresos_Load(object sender, EventArgs e)
        {
            mtbFechaLiquidacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
