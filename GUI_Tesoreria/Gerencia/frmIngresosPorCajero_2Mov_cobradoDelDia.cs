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
    public partial class frmIngresosPorCajero_2Mov_cobradoDelDia : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public string FechaReporteDesde { get; set; }
        public string FechaReporteHasta { get; set; }
        public bool porDia { get; set; }
        DataTable dtIngCajeros;
        DataTable dtIngCajerosSGI;
        DataTable dtUnion;

        public frmIngresosPorCajero_2Mov_cobradoDelDia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngresosPorCajero_2Mov_cobradoDelDia_Load(object sender, EventArgs e)
        {
            cargarPrograma();
            txtFechaSistemaDesdeC.Text = FechaReporteDesde;
            txtFechaSistemaHastaC.Text = FechaReporteHasta;
            BtnBuscar_Click(sender, e);
            sumarColumnas();
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

        private bool Buscar()
        {
            dtIngCajeros = new DataTable();
            dtIngCajerosSGI = new DataTable();
            
            if (cboPrograma.Text != "DGAI")
            {
                dtIngCajeros = cn.TraerDataset("usp_select_ingreso_x_cajero", Convert.ToDateTime(txtFechaSistemaDesdeC.Text), Convert.ToDateTime(txtFechaSistemaHastaC.Text), porDia ? "S" : "N", cboPrograma.SelectedValue).Tables[0];
            }
            if (cboPrograma.SelectedIndex == 0 || cboPrograma.Text == "DGAI")
            {
                dtIngCajerosSGI = cn.TraerDataset("USP_INMOBILIARIA_INGRESO_POR_CAJERO_REPORTE",Convert.ToDateTime(txtFechaSistemaDesdeC.Text),Convert.ToDateTime(txtFechaSistemaHastaC.Text)).Tables[0];
            }
            if (dtIngCajeros.Rows.Count == 0)
            {
                if (Union(dtIngCajerosSGI,dtIngCajeros).Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return false;
                }
                dgvIngresosxCajero.DataSource = Union(dtIngCajerosSGI,dtIngCajeros);
                return true;
            }
            else
            {
                if (Union(dtIngCajeros, dtIngCajerosSGI).Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return false;
                }
                dgvIngresosxCajero.DataSource = Union(dtIngCajeros, dtIngCajerosSGI);
                return true;
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
            dtIngCajeros = new DataTable();
            dtIngCajerosSGI = new DataTable();
            dtUnion = new DataTable();

            frmReporte win = new frmReporte();
            Gerencia.Reportes.rptIngresosPorCajero rptIngresos = new Gerencia.Reportes.rptIngresosPorCajero();

            //dtIngCajeros = cn.TraerDataset("usp_select_cantidad_pagos_por_tipo", Convert.ToDateTime(txtFechaSistemaDesdeC.Text),Convert.ToDateTime(txtFechaSistemaHastaC.Text)).Tables[0];

            //
            if (cboPrograma.Text != "DGAI")
            {
                dtIngCajeros = cn.TraerDataset("usp_select_cantidad_pagos_por_tipo", Convert.ToDateTime(txtFechaSistemaDesdeC.Text), Convert.ToDateTime(txtFechaSistemaHastaC.Text),cboPrograma.SelectedValue).Tables[0];
            }
            if (cboPrograma.SelectedIndex == 0 || cboPrograma.Text == "DGAI")
            {
                dtIngCajerosSGI = cn.EjecutarSqlDTSSGI("select comprobant0_.IDTIPOPAGO as cod_mod_pago,tipopago10_.TIP_PAGO as desc_mod_pago,COUNT(DISTINCT(comprobant0_.NROCOMPROBANTE)) AS cantidad, " +
                                                        " SUM(comprobant0_.SUBTOTALSOLES+0.00+comprobant0_.IGVSOLES) AS TotalIngreso_Documento ,0.00 as total_dep_vau_che " +
                                                        " from sisinmueble.dbo.COMPROBANTEPAGO comprobant0_  LEFT " +
                                                        " join sisinmueble.dbo.DETALLECARTERA detallecar1_ on comprobant0_.IDDETALLECARTERA=detallecar1_.IDDETALLECARTERA  " +
                                                        "LEFT join sisinmueble.dbo.CARTERA cartera2_ on detallecar1_.IDCARTERA=cartera2_.IDCARTERA  " +
                                                        "LEFT join sisinmueble.dbo.CONTRATO contrato3_ on detallecar1_.IDCONTRATO=contrato3_.IDCONTRATO " +
                                                        "LEFT join sisinmueble.dbo.UPA upa4_ on contrato3_.IDUPA=upa4_.IDUPA  " +
                                                        "LEFT join sisinmueble.dbo.INMUEBLE inmueble5_ on upa4_.IDINMUEBLE=inmueble5_.IDINMUEBLE  " +
                                                        "LEFT join sisinmueble.dbo.INQUILINO inquilino6_ on contrato3_.IDINQUILINO=inquilino6_.IDINQUILINO  " +
                                                        "LEFT join sisinmueble.dbo.TIPOPERSONA tipoperson7_ on inquilino6_.IDTIPOPERSONA=tipoperson7_.IDTIPOPERSONA  " +
                                                        "INNER join sisinmueble.dbo.TIPODOCU tipodocu8_ on comprobant0_.IDTIPODOCU=tipodocu8_.IDTIPODOCU  " + 
                                                        "INNER join sisinmueble.dbo.TIPOMOVIMIENTO tipomovimi9_ on comprobant0_.IDTIPOMOVIMIENTO=tipomovimi9_.IDTIPOMOVIMIENTO  " +
                                                        "INNER join sisinmueble.dbo.TIPOPAGO tipopago10_ on comprobant0_.IDTIPOPAGO=tipopago10_.IDTIPOPAGO " +  
                                                        "INNER join sisinmueble.dbo.USUARIO usuario11_ on comprobant0_.IDUSUARIO=usuario11_.IDUSUARIO  " +
                                                        "left outer join sisinmueble.dbo.COMPROBANTEPAGO comprobant12_ on comprobant0_.IDNOTADEBITO=comprobant12_.IDCOMPROBANTE  " +
                                                        "where 1=1 and " +
                                                        " CONVERT(DATETIME,CONVERT(VARCHAR(10),comprobant0_.FECHACANCELACION,103)) >='" + txtFechaSistemaDesdeC.Text +
                                                        "' and CONVERT(DATETIME,CONVERT(VARCHAR(10),comprobant0_.FECHACANCELACION,103)) <= '" + txtFechaSistemaHastaC.Text + "'  " +
                                                        "and tipodocu8_.IDTIPODOCU<>'00' and 1=1 AND comprobant0_.SIANULADO=0 " +
                                                        "group by comprobant0_.IDTIPOPAGO,tipopago10_.TIP_PAGO").Tables[0];
            }
            if (dtIngCajeros.Rows.Count == 0)
            {
                if (Union(dtIngCajerosSGI, dtIngCajeros).Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtUnion = Union(dtIngCajerosSGI, dtIngCajeros);
            }
            else
            {
                if (Union(dtIngCajeros, dtIngCajerosSGI).Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dtUnion = Union(dtIngCajeros, dtIngCajerosSGI);
            }
            //
            rptIngresos.Subreports[0].Database.Tables[0].SetDataSource(dtUnion);

            rptIngresos.SetDataSource(dgvIngresosxCajero.DataSource);
            rptIngresos.SetParameterValue("@FechaDesde", txtFechaSistemaDesdeC.Text.ToString());
            rptIngresos.SetParameterValue("@FechaHasta", txtFechaSistemaHastaC.Text.ToString());
            win.crvReportes.ReportSource = rptIngresos;

            win.WindowState = FormWindowState.Maximized;
            win.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
            sumarColumnas();
        }
    }
}
