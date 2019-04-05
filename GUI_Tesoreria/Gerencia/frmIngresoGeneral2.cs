using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
namespace GUI_Tesoreria.Gerencia
{
    public partial class frmIngresoGeneral2 : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmIngresoGeneral2 frmInstance = null;
        CNegocio cn = new CNegocio();
        public string TipoReporte;
        public string Tipo_Reporte_y;

        public static frmIngresoGeneral2 Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoGeneral2();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmIngresoGeneral2()
        {
            InitializeComponent();
        }

        private void frmIngresoGeneral2_Load(object sender, EventArgs e)
        {
            cboCajero.DataSource = cn.TraerDataset("usp_select_usuarios_caja_reporte").Tables[0];
            cboCajero.ValueMember = "Id_Caja_Usuario";
            cboCajero.DisplayMember = "cajero";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TipoReporte != "PagxResCan" && TipoReporte != "consulta" && TipoReporte != "RegVouchers" && TipoReporte != "RepSR" && TipoReporte != "RepST")
            {
                frmReporteIngresoDiario win = new frmReporteIngresoDiario();
                win.programaId = Convert.ToInt16(cboCajero.SelectedValue.ToString());
                win.tipo_reporte = Tipo_Reporte_y;
                win.ShowDialog();
            }
            if (TipoReporte == "consulta")
            {
                caja.frmConsultaRecibos win = new caja.frmConsultaRecibos();
                win.cajeroIngreso = Convert.ToInt16(cboCajero.SelectedValue.ToString());
                win.ShowDialog();
            }
            if (TipoReporte == "RegVouchers")
            {
                caja.frmIngresoVouchers _frmIngresoVouchers = new caja.frmIngresoVouchers();
                _frmIngresoVouchers.idCajeroIngresoVouchers = Convert.ToInt32(cboCajero.SelectedValue);
                _frmIngresoVouchers.habilita = 0;
                _frmIngresoVouchers.ShowDialog();
            }
            if (TipoReporte == "RepSR")
            {
                frmReporteIngresoDiario _frmReporteProceso = new frmReporteIngresoDiario();
                _frmReporteProceso.tipo_reporte = "RepSR";
                _frmReporteProceso.programaId = Convert.ToInt32(cboCajero.SelectedValue);
                _frmReporteProceso.ShowDialog();
            }
            if (TipoReporte == "RepST")
            {
                frmReporteIngresoDiario _frmReporteProceso = new frmReporteIngresoDiario();
                _frmReporteProceso.tipo_reporte = "RepST";
                _frmReporteProceso.programaId = Convert.ToInt32(cboCajero.SelectedValue);
                _frmReporteProceso.ShowDialog();
            }
            else
            {
                canevaro.frmReportePagosResidente win = new canevaro.frmReportePagosResidente();

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
