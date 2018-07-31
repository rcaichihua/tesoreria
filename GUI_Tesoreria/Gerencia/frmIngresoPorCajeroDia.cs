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
    public partial class frmIngresoPorCajeroDia : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmIngresoPorCajeroDia frmInstance = null;
        private CNegocio cn = new CNegocio();
        DataTable dtIngCajeros;
        DataTable dtIngCajerosSGI;
        DataTable dtUnion;


        public static frmIngresoPorCajeroDia Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoPorCajeroDia();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmIngresoPorCajeroDia()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
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
                    importe = importe + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[3].Value);
                    mora = mora + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[4].Value);
                    descuento = descuento + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[5].Value);
                    igv = igv + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[6].Value);
                    total = total + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[7].Value);
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

        private void Buscar()
        {
            dtIngCajeros = new DataTable();
            dtIngCajerosSGI = new DataTable();
            dtUnion = new DataTable();

            if (cboPrograma.Text != "DGAI")
            {
                dtIngCajeros = cn.TraerDataset("usp_select_ingreso_x_cajero", dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString(), true ? "S" : "N", cboPrograma.SelectedValue).Tables[0];
            }
            if (cboPrograma.SelectedIndex == 0 || cboPrograma.Text == "DGAI")
            {
                dtIngCajerosSGI = cn.TraerDataset("USP_INMOBILIARIA_INGRESO_POR_CAJERO_POR_DIA",dtpDesde.Value.ToShortDateString(),dtpHasta.Value.ToShortDateString()).Tables[0];
            }
            if (dtIngCajeros.Rows.Count == 0)
            {
                if (dtIngCajerosSGI.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Union(dtIngCajerosSGI, dtIngCajeros).Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dtUnion = Union(dtIngCajerosSGI, dtIngCajeros);
                DataRow[] foundRows = dtUnion.Select("","FECHA DESC, NOMBRES ASC");
                DataTable dt = foundRows.CopyToDataTable();
                dgvIngresosxCajero.DataSource = dtUnion;
            }
            else
            {
                if (Union(dtIngCajeros, dtIngCajerosSGI).Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                dtUnion=Union(dtIngCajeros, dtIngCajerosSGI);
                DataRow[] foundRows = dtUnion.Select("", "FECHA DESC, NOMBRES ASC");
                DataTable dt = foundRows.CopyToDataTable();
                dgvIngresosxCajero.DataSource = dt;
            }
        }

        private void frmIngresoPorCajeroDia_Load(object sender, EventArgs e)
        {
            cargarPrograma();
        }

        private void cargarPrograma()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_programa").Tables[0];
                cboPrograma.DataSource = dt;
                cboPrograma.DisplayMember = "varProDescripcion";
                cboPrograma.ValueMember = "intProId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public static DataTable Union(DataTable First, DataTable Second)
        {

            DataTable table = new DataTable("Union");

            DataColumn[] newcolumns = new DataColumn[First.Columns.Count];

            for (int i = 0; i < First.Columns.Count; i++)
            {
                newcolumns[i] = new DataColumn(
                First.Columns[i].ColumnName, First.Columns[i].DataType);
            }

            table.Columns.AddRange(newcolumns);
            table.BeginLoadData();

            foreach (DataRow row in First.Rows)
            {
                table.LoadDataRow(row.ItemArray, true);
            }

            foreach (DataRow row in Second.Rows)
            {
                table.LoadDataRow(row.ItemArray, true);
            }

            table.EndLoadData();
            return table;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            frmReporte win = new frmReporte();
            Gerencia.Reportes.rptIngresoCajeroAcumuladoDiario rptIngresos = new Gerencia.Reportes.rptIngresoCajeroAcumuladoDiario();

            //dtDatosReporte = new DataTable();
            //dtDatosReporte = cn.TraerDataset("usp_select_cantidad_pagos_por_tipo", Convert.ToDateTime(txtFechaSistemaDesdeC.Text)
            //    , Convert.ToDateTime(txtFechaSistemaHastaC.Text)).Tables[0];
            //rptIngresos.Subreports[0].Database.Tables[0].SetDataSource(dtDatosReporte);

            rptIngresos.SetDataSource(dgvIngresosxCajero.DataSource);
            rptIngresos.SetParameterValue("@Desde", dtpDesde.Value.ToShortDateString());
            rptIngresos.SetParameterValue("@Hasta", dtpHasta.Value.ToShortDateString());
            win.crvReportes.ReportSource = rptIngresos;

            win.WindowState = FormWindowState.Maximized;
            win.ShowDialog();
        }
    }
}
