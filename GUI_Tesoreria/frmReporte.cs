﻿using BL_Tesoreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria
{
    public partial class frmReporte : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public string TipoReporteLiquidacion { get; set; }
        public int Fecha_desde { get; set; }
        public string Fecha_hasta { get; set; }

        public string Fecha { get; set; }
        public DataTable dtR { get; set; }
        public DataSet dsDiario { get; set; }
        private CNegocio cn = new CNegocio();

        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            if (TipoReporteLiquidacion == "ID")
            {
                caja.Reportes.rptIngresoDiario rptrptRecibosIngreso = new caja.Reportes.rptIngresoDiario();
                rptrptRecibosIngreso.SetDataSource(dtR);
                //rptrptRecibosIngreso.SetDataSource()
                //rptrptRecibosIngreso.SetParameterValue("@fecha", Fecha);
                crvReportes.ReportSource = rptrptRecibosIngreso;
            }
            else if (TipoReporteLiquidacion == "RE")
            {
                caja.Reportes.rptReciboEmitido rptrptReciboEmitido = new caja.Reportes.rptReciboEmitido();
                rptrptReciboEmitido.SetDataSource(dtR);
                crvReportes.ReportSource = rptrptReciboEmitido;
            }
            else if (TipoReporteLiquidacion == "VO")
            {
                caja.Reportes.rptReporteDepositos rpt = new caja.Reportes.rptReporteDepositos();
                rpt.SetDataSource(dtR);
                crvReportes.ReportSource = rpt;
            }
            else if (TipoReporteLiquidacion == "DEPOABANCO")
            {
                Deposito.Reportes.rptListadoDiario rpt = new Deposito.Reportes.rptListadoDiario();
                rpt.SetDataSource(dsDiario);
                crvReportes.ReportSource = rpt;
            }
            else if (TipoReporteLiquidacion == "REPINGRESOS")
            {
                caja.Reportes.rptReporteIngresos rpt = new caja.Reportes.rptReporteIngresos();
                rpt.SetDataSource(dtR);
                crvReportes.ReportSource = rpt;
            }
            else if (TipoReporteLiquidacion == "DEPSINPR")//
            {
                Deposito.Reportes.rptRegularizacion  rpt = new Deposito.Reportes.rptRegularizacion();
                rpt.SetDataSource(dtR);
                crvReportes.ReportSource = rpt;
            }
            else if (TipoReporteLiquidacion == "MESSIG")//
            {
                Deposito.Reportes.rptRegularizacion rpt = new Deposito.Reportes.rptRegularizacion();
                rpt.SetDataSource(dtR);
                crvReportes.ReportSource = rpt;
            }
            else if (TipoReporteLiquidacion == "MESANT")//
            {
                Deposito.Reportes.rptRegularizacion rpt = new Deposito.Reportes.rptRegularizacion();
                rpt.SetDataSource(dtR);
                crvReportes.ReportSource = rpt;
            }
        }
    }
}
