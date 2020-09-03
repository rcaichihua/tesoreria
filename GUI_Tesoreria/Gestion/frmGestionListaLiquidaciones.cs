using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Gestion
{
    public partial class frmGestionListaLiquidaciones : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmGestionListaLiquidaciones()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        DataTable dtDatosReporte;

        public int _ProgramaId { get; set; }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionListaLiquidaciones_Load(object sender, EventArgs e)
        {
            if (_ProgramaId == 3)
            {
                LblTitulo.Text = ":::   LIQUIDACIONES EMITIDAS INMOBILIARIA   :::";
                btnLiquidaciónCementerio.Visible = false;
            }
            else if (_ProgramaId == 1)
            {
                LblTitulo.Text = ":::   LIQUIDACIONES EMITIDAS ALTA DIRECCION   :::";
                btnLiquidaciónCementerio.Visible = false;
            }
            else if (_ProgramaId == 4)
            {
                LblTitulo.Text = ":::   LIQUIDACIONES EMITIDAS CEMENTERIO   :::";
                btnLiquidaciónCementerio.Visible = true;
            }
            else if (_ProgramaId == 2)
            {
                LblTitulo.Text = ":::   LIQUIDACIONES EMITIDAS ALBERGUES   :::";
                btnLiquidaciónCementerio.Visible = false;
            }

            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
        }

        private void btnReciboIngreso_Click(object sender, EventArgs e)
        {
            if (this.dgvListadoLiquidaciones.CurrentRow == null) return;

            DataSet dtsRecibo = new DataSet();
            frmReporte winReport = new frmReporte();
            int index = 0;
            index = this.dgvListadoLiquidaciones.CurrentRow.Index;

            if (_ProgramaId == 3 || _ProgramaId == 4)
            {
                if (Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[4].Value.ToString()).Year > 2019)
                {                 //dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", _ProgramaId,dtpFechaDesde.Value.ToString("yyyyMMdd"));
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso_cuenta_empresarial_", _ProgramaId,
                        Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[4].Value.ToString()).ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", _ProgramaId,
                    Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[4].Value.ToString()).ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (chkcuentas.Checked)
                    {
                        DataTable dtCuenta;

                        foreach (DataRow item in dtsRecibo.Tables[0].Rows)
                        {
                            dtCuenta = new DataTable();

                            dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[6] + "'").Tables[0];

                            if (dtCuenta.Rows.Count <= 0)
                            {
                                item[6] = "S/CTA";
                                item[7] = "S/NOMBRE";
                            }
                            else
                            {
                                item[6] = dtCuenta.Rows[0][0];
                                item[7] = dtCuenta.Rows[0][1];
                            }
                        }
                    }
                }
            }
            else
            {
                if (Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[4].Value.ToString()).Year > 2019)
                {
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso_cuenta_empresarial_", _ProgramaId,
                    Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[4].Value.ToString()).ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", _ProgramaId,
                    Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[4].Value.ToString()).ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (chkcuentas.Checked)
                    {
                        DataTable dtCuenta;

                        foreach (DataRow item in dtsRecibo.Tables[0].Rows)
                        {
                            dtCuenta = new DataTable();

                            dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[6] + "'").Tables[0];

                            if (dtCuenta.Rows.Count <= 0)
                            {
                                item[6] = "S/CTA";
                                item[7] = "S/NOMBRE";
                            }
                            else
                            {
                                item[6] = dtCuenta.Rows[0][0];
                                item[7] = dtCuenta.Rows[0][1];
                            }
                        }
                    }
                }
            }

            caja.Reportes.rptRecibosIngreso rptRecibo = new caja.Reportes.rptRecibosIngreso();
            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
            winReport.crvReportes.ReportSource = rptRecibo;

            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = cn.TraerDataset("USP_BUSCA_LIQUIDACION", null,
                (_ProgramaId ==3 ? "INMOBILIARIA" : (_ProgramaId == 1 ? "DIRECCI" : (_ProgramaId == 4 ? "CEMENTERIO" : (_ProgramaId == 2 ? "ALBERGUE" : (null))))),
                dtpFechaDesde.Value.ToString("yyyyMMdd"), dtpFechaHasta.Value.ToString("yyyyMMdd"),
                RBActivos.Checked ? "1" : (RBAnulados.Checked ? "0" : null)).Tables[0];

            if (dtResultado.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListadoLiquidaciones.DataSource = dtResultado;
            }
            else
            {
                dgvListadoLiquidaciones.DataSource = dtResultado;

                if (dgvListadoLiquidaciones.RowCount > 0)
                {
                    decimal TotalCaja = 0.00m;
                    decimal TotalDeposito = 0.00m;

                    foreach (DataGridViewRow row in dgvListadoLiquidaciones.Rows)
                    {
                        TotalCaja = TotalCaja + Convert.ToDecimal(row.Cells["totalIngresoCaja"].Value);
                        TotalDeposito = TotalDeposito + Convert.ToDecimal(row.Cells["diferenciaDeposito"].Value);
                    }
                    txtTotalIngresoCaja.Text = TotalCaja.ToString("###,###,##0.00");
                    txtTotalDeposito.Text = TotalDeposito.ToString("###,###,##0.00");
                    lblNroLiquidaciones.Text = dgvListadoLiquidaciones.Rows.Count.ToString();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            menus.frmMenuGestion menu = new menus.frmMenuGestion();
            menu.Show();
        }

        private void frmGestionListaLiquidaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (varGlobales.verificaCierre == false)
            {
                string message = "Esta seguro que desea salir del Sistema?";
                string caption = "...:::Salir del Sistema:::...";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    Application.Exit();
                }
                else if (varGlobales.verificaCierre == false)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnLiquidaciónCementerio_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvListadoLiquidaciones.CurrentRow == null) return;

                int index = 0;
                index = this.dgvListadoLiquidaciones.CurrentRow.Index;

                frmReporteIngresoDiario _frmReporteProceso = new frmReporteIngresoDiario();
                _frmReporteProceso.tipo_reporte = "M";
                _frmReporteProceso._Desde = Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[5].Value);
                _frmReporteProceso._Hasta = Convert.ToDateTime(this.dgvListadoLiquidaciones.Rows[index].Cells[5].Value);
                _frmReporteProceso.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void btnListadoContable_Click(object sender, EventArgs e)
        {
                DataSet dtsListadoContable = new DataSet();
                DataSet dtsListadoContableNegativo = new DataSet();
                frmReporte winReport = new frmReporte();

                if (dtpFechaDesde.Value.Year < 2020)
                {
                    dtsListadoContable = cn.TraerDataset("usp_ListaLiquidaciones_contable_new",
                        dtpFechaDesde.Value.ToString("yyyyMMdd"), dtpFechaHasta.Value.ToString("yyyyMMdd"), _ProgramaId);

                    if (dtsListadoContable.Tables[0].Rows.Count > 0)
                    {
                        if (chkcuentas.Checked)
                        {
                            DataTable dtCuenta;

                            foreach (DataRow item in dtsListadoContable.Tables[0].Rows)
                            {
                                dtCuenta = new DataTable();

                                dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[2] + "'").Tables[0];

                                if (dtCuenta.Rows.Count <= 0)
                                {
                                    item[2] = "S/CTA";
                                    item[3] = "S/NOMBRE";
                                }
                                else
                                {
                                    item[2] = dtCuenta.Rows[0][0];
                                    item[3] = dtCuenta.Rows[0][1];
                                }
                            }
                        }
                    }

                    dtsListadoContableNegativo = cn.TraerDataset("usp_ListaLiquidaciones_contable_negativo_new",
                        dtpFechaDesde.Value.ToString("yyyyMMdd"), dtpFechaHasta.Value.ToString("yyyyMMdd"), _ProgramaId);

                    if (dtsListadoContableNegativo.Tables[0].Rows.Count > 0)
                    {
                        if (chkcuentas.Checked)
                        {
                            DataTable dtCuenta;

                            foreach (DataRow item in dtsListadoContableNegativo.Tables[0].Rows)
                            {
                                dtCuenta = new DataTable();

                                dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[2] + "'").Tables[0];

                                if (dtCuenta.Rows.Count <= 0)
                                {
                                    item[2] = "S/CTA";
                                    item[3] = "S/NOMBRE";
                                }
                                else
                                {
                                    item[2] = dtCuenta.Rows[0][0];
                                    item[3] = dtCuenta.Rows[0][1];
                                }
                            }
                        }
                    }

                    if (dtsListadoContable.Tables[0].Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    dtsListadoContable = cn.TraerDataset("usp_listado_contable_cuenta_empresarial_rango"
                        , _ProgramaId, dtpFechaDesde.Value.ToString("yyyyMMdd"), dtpFechaHasta.Value.ToString("yyyyMMdd"));

                    dtsListadoContableNegativo = cn.TraerDataset("usp_ListaLiquidaciones_contable_negativo_new",
                        dtpFechaDesde.Value.ToString("yyyyMMdd"), dtpFechaHasta.Value.ToString("yyyyMMdd"), _ProgramaId);


                    dtsListadoContableNegativo.AcceptChanges();

                    foreach (DataRow row in dtsListadoContableNegativo.Tables[0].Rows)
                    {
                        // If this row is offensive then
                        row.Delete();
                    }
                }

                caja.Reportes.rptListadoContable rptRecibo = new caja.Reportes.rptListadoContable();

                rptRecibo.Subreports[0].Database.Tables[0].SetDataSource(dtsListadoContableNegativo.Tables[0]);

                rptRecibo.SetDataSource(dtsListadoContable.Tables[0]);
                rptRecibo.SetParameterValue("@desde", dtpFechaDesde.Value.ToString("dd/MM/yyyy"));
                rptRecibo.SetParameterValue("@hasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy"));
                winReport.crvReportes.ReportSource = rptRecibo;

                winReport.WindowState = FormWindowState.Maximized;
                winReport.ShowDialog();
        }
    }
}
