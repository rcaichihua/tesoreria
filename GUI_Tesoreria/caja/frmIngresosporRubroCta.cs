using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmIngresosporRubroCta : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmIngresosporRubroCta frmInstance = null;

        public frmIngresosporRubroCta()
        {
            InitializeComponent();
        }

        public static frmIngresosporRubroCta Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresosporRubroCta();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        CNegocio cn = new CNegocio();

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReciboIngreso_Click(object sender, EventArgs e)
        {
            DataTable dtResu = new DataTable();
            dtResu = cn.TraerDataset("usp_reporte_ingresos_rubro2", 
                dtpDesde.Value.ToString("yyyyMMdd"), dtpHasta.Value.ToString("yyyyMMdd"), txtRubro.Text.Trim() == "" ? null : txtRubro.Text, 
                cboPrograma.SelectedValue).Tables[0];
            if (dtResu.Rows.Count==0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                return;
            }
            frmReporte win = new frmReporte();
            win.TipoReporteLiquidacion = "REPINGRESOS";
            win.dtR = dtResu;
            win.ShowDialog();
        }

        private void frmIngresosporRubroCta_Load(object sender, EventArgs e)
        {
            ListarProgramas();
        }

        private void ListarProgramas()
        {
            DataTable dtb = new DataTable();

            DataRow row;

            dtb = cn.TraerDataset("usp_ListaProgramas").Tables[0];
            row = dtb.NewRow();
            row["intProId"] = 0;
            row["varProDescripcion"] = "[-- SELECCIONE --]";

            dtb.Rows.InsertAt(row, 0);

            cboPrograma.DisplayMember = "varProDescripcion";
            cboPrograma.ValueMember = "intProId";
            cboPrograma.DataSource = dtb;
        }
    }
}
