﻿using BL_Tesoreria;
using DescripcionMonto;
using GUI_Tesoreria.caja;
using GUI_Tesoreria.caja.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.Gerencia
{
    public partial class frmListadoRecibosPrograma : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private DataSet dsDatos;
        private int idCliente;
        private CNegocio cn = new CNegocio();
        private varGlobales varglo = new varGlobales();
        private static frmListadoRecibosPrograma frmInstance = null;
        public Boolean autoziza = false;
        public int cajeroIngreso = 0;

        public frmListadoRecibosPrograma()
        {
            InitializeComponent();
        }
        public static frmListadoRecibosPrograma Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListadoRecibosPrograma();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmListadoRecibosPrograma_Load(object sender, EventArgs e)
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
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (cajeroIngreso == 0)
            {
                cajeroIngreso = VariablesMetodosEstaticos.idcajausuario;
            }

            CargarGrilla();

        }

        private void CargarGrilla()
        {
            if (cboPrograma.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un programa.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPrograma.Focus();
                return;
            }

            try
            {
                dsDatos = new DataSet();
                int estado = 0;

                if (RBTodos.Checked) estado = 2;
                if (RBActivos.Checked) estado = 1;
                if (RBAnulados.Checked) estado = 0;
                if (ChTodos.Checked) idCliente = 0;

                dsDatos = cn.TraerDataset("usp_s_tb_recibocabecera", 3, 0, 0, 0
                    , txtNrorecibo.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtNrorecibo.Text.Trim())
                    , 0, 0, idCliente, TxtNombre.Text.Trim(), "", "",
                    Convert.ToDateTime(dtpFechaDesde.Value.ToShortDateString()), 0, 0, 0, ""
                    , cboPrograma.SelectedValue, estado, Convert.ToDateTime(dtpFechaHasta.Value.ToShortDateString()));

                dgvRecibos.DataSource = dsDatos.Tables[0];

                decimal subTotal = 0.00m;
                decimal igv = 0.00m;
                decimal total = 0.00m;

                foreach (DataGridViewRow row in dgvRecibos.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "ACTIVO")
                    {
                        subTotal = subTotal + Convert.ToDecimal(row.Cells["subTotal"].Value);
                        igv = igv + Convert.ToDecimal(row.Cells["Igv"].Value);
                        total = total + Convert.ToDecimal(row.Cells["Total"].Value);
                    }
                }

                txtSubTotal.Text = subTotal.ToString("##,##0.00");
                txtIgv.Text = igv.ToString("##,##0.00");
                txtTotal.Text = total.ToString("##,##0.00");

                lblNroRecibos.Text = dsDatos.Tables[0].Rows.Count.ToString();

            }
            catch (Exception)
            {

            }
        }
        private void marcarGrilla()
        {
            if (dgvRecibos.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvRecibos.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "EXTORNADO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void RBTodos_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void LimpiarGrilla()
        {
            try
            {
                if (dgvRecibos.RowCount > 0)
                {
                    for (int i = 0; i < dgvRecibos.RowCount - 1; i++)
                    {
                        dgvRecibos.Rows.RemoveAt(dgvRecibos.CurrentRow.Index);
                    }
                }
                txtNrorecibo.Clear();
                TxtCodigoContribuyente.Clear();
                TxtNombre.Clear();
                idCliente = 0;
            }
            catch (Exception)
            {
            }
        }

        private void RBActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void RBAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void ChTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarGrilla();
                if (ChTodos.Checked)
                {
                    ChTodos.Text = "DesMarcar Todos";
                    CargarGrilla();
                }
                else
                {
                    ChTodos.Text = "Mostrar Todos";
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            int tipoDocumento;
            DataSet dtsRecibo = new DataSet();
            DataSet dtsTipoDoc = new DataSet();
            frmImpresionRecibos winReport = new frmImpresionRecibos();
            int programaRecibo = 0;

            if (dgvRecibos.RowCount <= 0)
            {
                return;
            }

            dtsRecibo = cn.TraerDataset("usp_r_tb_recibocabecera", 2, dgvRecibos.Rows[dgvRecibos.CurrentRow.Index].Cells[1].Value, DateTime.Now, DateTime.Now, 0, 1);

            dtsTipoDoc = cn.TraerDataset("usp_obtener_tipo_documento", Convert.ToInt32(dtsRecibo.Tables[0].Rows[0][0]));

            tipoDocumento = Convert.ToInt32(dtsTipoDoc.Tables[0].Rows[0][0]);
            programaRecibo = Convert.ToInt32(cn.TraerDataset("obtener_programa_x_sucursal", Convert.ToInt32(dtsRecibo.Tables[0].Rows[0][10])).Tables[0].Rows[0][0]);


            NumLetra Letras = new NumLetra();

            if (dtsRecibo.Tables[0].Rows.Count > 0)
            {
                switch (tipoDocumento)
                {
                    case 1:
                        if (programaRecibo == 2)
                        {
                            rptReciboCajaCanevaro rptRecibo = new rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            caja.DocsElectronicos.rptBoletaCajaCementerio rptRecibo = new caja.DocsElectronicos.rptBoletaCajaCementerio();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                    case 2:
                        if (programaRecibo == 2)
                        {
                            rptReciboCajaCanevaro rptRecibo = new rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            rptFacturaCajaCementerio rptRecibo = new rptFacturaCajaCementerio();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                    case 3:
                        if (programaRecibo == 2)
                        {
                            rptReciboCajaCanevaro rptRecibo = new rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            rptReciboCajaCementerio rptRecibo = new rptReciboCajaCementerio();

                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                            //Reportes.rptPruebaImpreFactura rptRecibo = new Reportes.rptPruebaImpreFactura();
                            //rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            //winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 1 || programaRecibo == 5 || programaRecibo == 6)
                        {
                            rptReciboCajaCentral rptRecibo = new rptReciboCajaCentral();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@Total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                }
            }
            else
            {
                winReport.crvReportes.ReportSource = new RP();
            }
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void dgvRecibos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtExport = new DataTable();

                dtExport = CargarGrilla2().Tables[0];

                //String strcolname = "";
                //int i = 0;
                //for (i = dtExport.Columns.Count - 1; i >= 0; i--)
                //{
                //    strcolname = dtExport.Columns[i].ColumnName.ToString();

                //    if (strcolname == "CodigoBarra")
                //    {
                //        dtExport.Columns.RemoveAt(i);
                //        i--;
                //    }

                //    if (i <= 15 || i >= 71)
                //    {
                //        dtExport.Columns.RemoveAt(i);
                //    }
                //}

                ExportHelper.CreateXlsFromDataTable(dtExport, @"C:\tmp\ingresocementerio.xls");

                DevComponents.DotNetBar.MessageBoxEx.Show("Documento exportado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataSet CargarGrilla2()
        {
            dsDatos = new DataSet();

            if (cboPrograma.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un programa.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPrograma.Focus();
                return dsDatos;
            }

            try
            {              
                int estado = 0;

                if (RBTodos.Checked) estado = 2;
                if (RBActivos.Checked) estado = 1;
                if (RBAnulados.Checked) estado = 0;
                if (ChTodos.Checked) idCliente = 0;

                dsDatos = cn.TraerDataset("usp_s_tb_recibocabecera", 3, 0, 0, 0
                    , txtNrorecibo.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtNrorecibo.Text.Trim())
                    , 0, 0, idCliente, TxtNombre.Text.Trim(), "", "",
                    Convert.ToDateTime(dtpFechaDesde.Value.ToShortDateString()), 0, 0, 0, ""
                    , cboPrograma.SelectedValue, estado, Convert.ToDateTime(dtpFechaHasta.Value.ToShortDateString()));

                return dsDatos;

            }
            catch (Exception)
            {
                return dsDatos;
            }
        }
    }
}
