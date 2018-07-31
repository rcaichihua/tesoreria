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
    public partial class frmIngresosPorPrograma_2Mov_cobradoDelDia : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public DataTable datosIngCajero;
        public string FechaReporteDesde { get; set; }
        public string FechaReporteHasta { get; set; }

        public frmIngresosPorPrograma_2Mov_cobradoDelDia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngresosPorCajero_2Mov_cobradoDelDia_Load(object sender, EventArgs e)
        {
            dgvIngresosxCajero.DataSource = datosIngCajero;
            txtFechaSistemaDesdeC.Text = FechaReporteDesde;
            txtFechaSistemaHastaC.Text = FechaReporteHasta;
            sumarColumnas();
        }
        private void sumarColumnas()
        {
            try
            {
                decimal importe = 0.00m;
                decimal mora = 0.00m;
                decimal descuento = 0.00m;
                decimal igv = 0.00m;
                decimal total = 0.00m;

                for (int i = 0; i < dgvIngresosxCajero.RowCount; i++)
                {
                    importe = importe + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[2].Value);
                    mora = mora + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[3].Value);
                    descuento = descuento + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[4].Value);
                    igv = igv + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[5].Value);
                    total = total + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[6].Value);
                }
                txtImporte.Text = importe.ToString("##,##0.00");
                txtMora.Text = mora.ToString("##,##0.00");
                txtDscto.Text = descuento.ToString("##,##0.00");
                txtIgv.Text = igv.ToString("##,##0.00");
                txtTotal.Text = total.ToString("##,##0.00");
            }
            catch (Exception)
            {
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dtDatosReporte;
            frmReporte win = new frmReporte();
            Gerencia.Reportes.rptIngresosPorCajero rptIngresos = new Gerencia.Reportes.rptIngresosPorCajero();

            dtDatosReporte = new DataTable();
            dtDatosReporte = cn.TraerDataset("usp_select_cantidad_pagos_por_tipo",Convert.ToDateTime(txtFechaSistemaDesdeC.Text)
                ,Convert.ToDateTime(txtFechaSistemaHastaC.Text),0).Tables[0];
            rptIngresos.Subreports[0].Database.Tables[0].SetDataSource(dtDatosReporte);

            rptIngresos.SetDataSource(datosIngCajero);
            rptIngresos.SetParameterValue("@FechaDesde", txtFechaSistemaDesdeC.Text.ToString());
            rptIngresos.SetParameterValue("@FechaHasta", txtFechaSistemaHastaC.Text.ToString());
            win.crvReportes.ReportSource = rptIngresos;

            win.WindowState = FormWindowState.Maximized;
            win.ShowDialog();
        }
    }
}
