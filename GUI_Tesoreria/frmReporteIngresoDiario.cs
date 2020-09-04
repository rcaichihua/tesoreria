using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using DescripcionMonto;

namespace GUI_Tesoreria
{
    public partial class frmReporteIngresoDiario : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public string tipo_reporte = "";
        private DataTable dtDatosReporte;
        private DataTable dtDatosReporte2;
        private static frmReporteIngresoDiario frmInstance = null;
        private CNegocio cn = new CNegocio();
        public DateTime _Desde { get; set; }
        public DateTime _Hasta { get; set; }
        public int programaId = 0;

        NumLetra Letras = new NumLetra();

        public frmReporteIngresoDiario()
        {
            InitializeComponent();
        }
        public static frmReporteIngresoDiario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmReporteIngresoDiario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmReporteProceso_Load(object sender, EventArgs e)
        {
            if (programaId == 0)
            {
                dtpDesde.Value = _Desde;
                dtpHasta.Value = _Hasta;

                if (tipo_reporte == "R")
                {
                    programaId = VariablesMetodosEstaticos.idcajausuario;
                }
                else
                {
                    if (tipo_reporte == "D")
                    {
                        programaId = 3;
                    }
                    else
                    {
                        programaId = 4;
                    }
                    btnImprimir_Click(sender, e);
                }
            }
        }

        private void buscarIngresosDiarios()
        {
            try
            {
                if (dtpDesde.Value > dtpDesde.Value)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El ingreso del rango de fechas no es valida", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (tipo_reporte == "R")
                {
                    dtDatosReporte = new DataTable();
                    dtDatosReporte2 = new DataTable();

                    if (VariablesMetodosEstaticos.id_programa == 1)
                    {
                        dtDatosReporte = cn.TraerDataset("usp_r_tb_recibocabecera", 1, 0, dtpDesde.Value.ToShortDateString()
                                                        , dtpHasta.Value.ToShortDateString(), programaId, 1).Tables[0];

                        dtDatosReporte2 = cn.TraerDataset("usp_reporte_ingresos_rubro_general_", null, dtpDesde.Value.ToString("yyyyMMdd")
                                                        , dtpHasta.Value.ToString("yyyyMMdd"), VariablesMetodosEstaticos.id_programa,VariablesMetodosEstaticos.id_user).Tables[0];


                        if (dtDatosReporte.Rows.Count > 0)
                        {
                            caja.Reportes.rptReporteDiarioAltaDireccion rptReporteDiario = new caja.Reportes.rptReporteDiarioAltaDireccion();

                            rptReporteDiario.Subreports[0].Database.Tables[0].SetDataSource(dtDatosReporte2);
                            rptReporteDiario.SetDataSource(dtDatosReporte);
                            rptReporteDiario.SetParameterValue("@Desde", dtpDesde.Value.ToShortDateString());
                            rptReporteDiario.SetParameterValue("@Hasta", dtpHasta.Value.ToShortDateString());
                            crvReportes.ReportSource = rptReporteDiario;
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    else
                    {
                        dtDatosReporte = cn.TraerDataset("usp_r_tb_recibocabecera", 1, 0, dtpDesde.Value.ToShortDateString()
                                                        , dtpHasta.Value.ToShortDateString(), programaId, 1).Tables[0];

                        if (dtDatosReporte.Rows.Count > 0)
                        {
                            caja.Reportes.rptReporteDiario rptReporteDiario = new caja.Reportes.rptReporteDiario();

                            rptReporteDiario.SetDataSource(dtDatosReporte);
                            rptReporteDiario.SetParameterValue("@Desde", dtpDesde.Value.ToShortDateString());
                            rptReporteDiario.SetParameterValue("@Hasta", dtpHasta.Value.ToShortDateString());
                            crvReportes.ReportSource = rptReporteDiario;
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                else if (tipo_reporte == "D" /*&& VariablesMetodosEstaticos.id_programa == 2*/)
                {
                    dtDatosReporte = new DataTable();
                    dtDatosReporte = cn.TraerDataset("usp_ingreso_diario_canevaro", dtpDesde.Value.ToShortDateString()
                        ,dtpHasta.Value.ToShortDateString(), programaId).Tables[0];

                    if (dtDatosReporte.Rows.Count > 0)
                    {
                        decimal suma = 0;
                        foreach (DataRow dr in dtDatosReporte.Rows)
                        {
                            suma += Convert.ToDecimal(dr["INGRESOS"]);
                        }

                        caja.Reportes.rptReporteDiarioDetalladoCanevaro rptDetDiario = new caja.Reportes.rptReporteDiarioDetalladoCanevaro();

                        rptDetDiario.SetDataSource(dtDatosReporte);

                        dtDatosReporte = new DataTable();
                        dtDatosReporte = cn.TraerDataset("usp_reporte_resumen_ingresos_x_direccion", dtpDesde.Value.ToShortDateString()
                            ,dtpHasta.Value.ToShortDateString(), programaId).Tables[0];

                        rptDetDiario.Subreports[0].Database.Tables[0].SetDataSource(dtDatosReporte);
                        rptDetDiario.SetParameterValue("@fechaingresoDesde", dtpDesde.Value.ToShortDateString());
                        rptDetDiario.SetParameterValue("@fechaingresoHasta", dtpHasta.Value.ToShortDateString());
                        rptDetDiario.SetParameterValue("@totalLetras",
                            Letras.Convertir(suma.ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());

                        crvReportes.ReportSource = rptDetDiario;


                    }                    
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else if (tipo_reporte == "M"/* && VariablesMetodosEstaticos.id_programa == 4*/)
                {
                    dtDatosReporte = new DataTable();
                    dtDatosReporte = cn.TraerDataset("usp_ingresos_cementerio_x_grupo", dtpDesde.Value.ToShortDateString(),dtpHasta.Value.ToShortDateString(),
                        programaId).Tables[0];
                    if (dtDatosReporte.Rows.Count > 0)
                    {
                        caja.Reportes.rptLiquidacionxDiaCementerio rptLiq = new caja.Reportes.rptLiquidacionxDiaCementerio();
                        rptLiq.SetDataSource(dtDatosReporte);
                        crvReportes.ReportSource = rptLiq;
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else if (tipo_reporte == "ResumenComedor" || tipo_reporte == "RepSR" || tipo_reporte == "RepST")
                {
                    dtDatosReporte = new DataTable();
                    dtDatosReporte = cn.TraerDataset("usp_ingreso_detallado_comedores", dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString(),
                        programaId).Tables[0];
                    if (dtDatosReporte.Rows.Count > 0)
                    {
                        caja.Reportes.rptIngresoComedor rptLiq = new caja.Reportes.rptIngresoComedor();
                        rptLiq.SetDataSource(dtDatosReporte);
                        rptLiq.SetParameterValue("@desde", dtpDesde.Value.ToShortDateString());
                        rptLiq.SetParameterValue("@hasta", dtpHasta.Value.ToShortDateString());
                        crvReportes.ReportSource = rptLiq;
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else if (tipo_reporte=="reporte_altadireccion")
                {

                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado
                   , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            buscarIngresosDiarios();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde.Value = dtpHasta.Value;
        }
    }
}
