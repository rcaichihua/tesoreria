﻿using System;
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
    public partial class frmIngresoGeneral : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmIngresoGeneral frmInstance = null;
        CNegocio cn = new CNegocio();
        public string TipoReporte;
        public string Tipo_Reporte_y;

        public static frmIngresoGeneral Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoGeneral();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmIngresoGeneral()
        {
            InitializeComponent();
        }

        private void frmIngresoGeneral_Load(object sender, EventArgs e)
        {
            cboUsuariosCaja.DataSource = cn.TraerDataset("usp_select_usuarios_caja_reporte").Tables[0];
            cboUsuariosCaja.ValueMember = "Id_Caja_Usuario";
            cboUsuariosCaja.DisplayMember = "cajero";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TipoReporte != "PagxResCan" && TipoReporte != "consulta" && TipoReporte != "RegVouchers" && TipoReporte != "RepSR" && TipoReporte != "RepST")
            {
                frmReporteIngresoDiario win = new frmReporteIngresoDiario();
                win.cajeroFiltro = Convert.ToInt16(cboUsuariosCaja.SelectedValue.ToString());
                win.tipo_reporte = Tipo_Reporte_y;
                win.ShowDialog();
            }
            if (TipoReporte == "consulta")
            {
                caja.frmConsultaRecibos win = new caja.frmConsultaRecibos();
                win.cajeroIngreso = Convert.ToInt16(cboUsuariosCaja.SelectedValue.ToString());
                win.ShowDialog();
            }
            if (TipoReporte == "RegVouchers")
            {
                caja.frmIngresoVouchers _frmIngresoVouchers = new caja.frmIngresoVouchers();
                _frmIngresoVouchers.idCajeroIngresoVouchers = Convert.ToInt32(cboUsuariosCaja.SelectedValue);
                _frmIngresoVouchers.habilita = 0;
                _frmIngresoVouchers.ShowDialog();
            }
            if (TipoReporte == "RepSR")
            {
                frmReporteIngresoDiario _frmReporteProceso = new frmReporteIngresoDiario();
                _frmReporteProceso.tipo_reporte = "RepSR";
                _frmReporteProceso.cajeroFiltro = Convert.ToInt32(cboUsuariosCaja.SelectedValue);
                _frmReporteProceso.ShowDialog();
            }
            if (TipoReporte == "RepST")
            {
                frmReporteIngresoDiario _frmReporteProceso = new frmReporteIngresoDiario();
                _frmReporteProceso.tipo_reporte = "RepST";
                _frmReporteProceso.cajeroFiltro = Convert.ToInt32(cboUsuariosCaja.SelectedValue);
                _frmReporteProceso.ShowDialog();
            }
            else
            {
                canevaro.frmReportePagosResidente win = new canevaro.frmReportePagosResidente();

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
