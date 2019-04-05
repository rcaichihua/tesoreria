using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using GUI_Tesoreria.caja;

namespace GUI_Tesoreria.DGAI
{
    public partial class frmGeneraLiquidacionDGAI : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmGeneraLiquidacionDGAI frmInstance = null;
        private CNegocio cn = new CNegocio();
        private string nro_liquidacion = "0000000";
        private decimal saldoRecibo = 0.00m;
        DataTable dtBusqLiq;
        public static frmGeneraLiquidacionDGAI Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmGeneraLiquidacionDGAI();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmGeneraLiquidacionDGAI()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtIngCajerosSGI = new DataTable();

                if (BuscarLiquidacion())
                {
                    AsignaReteText();

                    dtIngCajerosSGI = cn.TraerDataset("usp_obtiene_liquidacion_por_cajero_generado", dtpHasta.Value.ToString("yyyyMMdd")).Tables[0];

                    if (dtIngCajerosSGI.Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvIngresosxCajero.DataSource = dtIngCajerosSGI;
                        btnAsignar.Enabled = false;
                        txtRetencion.ReadOnly = false;
                        btnGenerarDoscIngreso.Enabled = false;
                        lblNro.Text = "0000000";
                        lblIdLiquidacion.Text = "0";
                        sumarColumnas(true);
                        return;
                    }
                    dgvIngresosxCajero.DataSource = dtIngCajerosSGI;
                    sumarColumnas(true);
                    AsignaReteText();

                    btnAsignar.Enabled = true;
                    txtRetencion.ReadOnly = true;
                    btnGenerarDoscIngreso.Enabled = true;
                }
                else
                {
                    txtRetencion.Text = "0.00";
                    dtIngCajerosSGI = cn.TraerDataset("USP_INMOBILIARIA_INGRESO_POR_CAJERO", dtpFechaDesde.Value.ToString("yyyyMMdd"), 
                        dtpHasta.Value.ToString("yyyyMMdd")).Tables[0];

                    if (dtIngCajerosSGI.Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvIngresosxCajero.DataSource = dtIngCajerosSGI;
                        btnAsignar.Enabled = false;
                        txtRetencion.ReadOnly = false;
                        btnGenerarDoscIngreso.Enabled = false;
                        lblNro.Text = "0000000";
                        lblIdLiquidacion.Text = "0";
                        sumarColumnas(false);
                        return;
                    }
                    dgvIngresosxCajero.DataSource = dtIngCajerosSGI;
                    sumarColumnas(false);

                    btnAsignar.Enabled = false;
                    txtRetencion.ReadOnly = false;
                    btnGenerarDoscIngreso.Enabled = false;
                    lblNro.Text = "0000000";
                    lblIdLiquidacion.Text = "0";
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        private void marcarGrilla()
        {
            if (dgvIngresosxCajero.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvIngresosxCajero.Rows)
                { 
                    //SIN ASIGNAR
                    if (Convert.ToInt32(row.Cells["IDLIQUIDACION"].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                    //ASIGNADO PARCIAL
                    else if (Convert.ToDecimal(row.Cells["TOTALDEPOSITADO"].Value) < Convert.ToDecimal(row.Cells["TOTALING"].Value) && Convert.ToDecimal(row.Cells["TOTALDEPOSITADO"].Value) !=0.00M)
                    {
                        row.DefaultCellStyle.BackColor = Color.NavajoWhite;
                    }
                    //ASIGNADO COMPLETO
                    else if (Convert.ToDecimal(row.Cells["DIFDEPOSITOS"].Value) >= 0.00M)
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        //row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (Convert.ToDecimal(row.Cells["DIFDEPOSITOS"].Value) * -1 == Convert.ToDecimal(row.Cells["TOTALING"].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                    }
                }
            }
        }

        private decimal obtieneRetencion(DateTime fechLiq)
        {
            return Convert.ToDecimal(cn.TraerDataset("usp_obtiene_retencion_dgai",
                         fechLiq).Tables[0].Rows[0][0]);
        }

        private void AsignaReteText()
        {
            txtRetencion.Text = obtieneRetencion(dtpHasta.Value).ToString("###,###,##0.00");
        }

        private void sumarColumnas(bool liqui)
        {
            try
            {
                decimal importe = 0.00m;
                decimal mora = 0.00m;
                decimal descuento = 0.00m;
                decimal igv = 0.00m;
                decimal total = 0.00m;
                decimal difDep = 0.00m;

                for (int i = 0; i < dgvIngresosxCajero.RowCount; i++)
                {
                    importe = importe + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[2].Value);
                    mora = mora + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[3].Value);
                    descuento = descuento + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[4].Value);
                    igv = igv + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[5].Value);
                    total = total + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[6].Value);
                    difDep = difDep + Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[10].Value);
                    if (!liqui)
                    {
                        dgvIngresosxCajero.Rows[i].Cells[10].Value = Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[9].Value) - Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[6].Value);
                    }
                }
                txtImporte.Text = importe.ToString("##,##0.00");
                txtMora.Text = mora.ToString("##,##0.00");
                txtDscto.Text = descuento.ToString("##,##0.00");
                txtIgv.Text = igv.ToString("##,##0.00");
                txtTotal.Text = total.ToString("##,##0.00");
                txtDifDep.Text = difDep.ToString("##,##0.00");
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = dtpHasta.Value;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvIngresosxCajero.Rows.Count > 0)
            {
                DGAI.frmIngresoVouchersDGAI win = new DGAI.frmIngresoVouchersDGAI();
                //frmIngresoVouchers win = new frmIngresoVouchers();
                win.cantDoc = Convert.ToInt32(dgvIngresosxCajero.Rows[dgvIngresosxCajero.CurrentRow.Index].Cells[7].Value);
                win.fechaLiquidacionDGAI = Convert.ToDateTime(dgvIngresosxCajero.Rows[dgvIngresosxCajero.CurrentRow.Index].Cells[8].Value);
                win.importe = Convert.ToDecimal(dgvIngresosxCajero.Rows[dgvIngresosxCajero.CurrentRow.Index].Cells[6].Value) - Convert.ToDecimal(dgvIngresosxCajero.Rows[dgvIngresosxCajero.CurrentRow.Index].Cells[9].Value);
                win.idCobradorDGAI = Convert.ToInt32(dgvIngresosxCajero.Rows[dgvIngresosxCajero.CurrentRow.Index].Cells[0].Value);
                win.idCajeroIngresoVouchers = VariablesMetodosEstaticos.idcajausuario;
                win.idLiquidacion = Convert.ToInt32(lblIdLiquidacion.Text);//Convert.ToInt32(cn.TraerDataset("usp_obtiene_Id_liquidacion_dgai", Convert.ToInt32(lblNro.Text)).Tables[0].Rows[0][0]);
                win.habilita = true;
                win.ShowDialog();
                BtnBuscar_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeneraLiquidacion_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtRetencion.Text) > Convert.ToDecimal(txtTotal.Text))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("La retencion no puede ser mayor al total ingresado.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRetencion.SelectAll();
                return;
            }

            if (BuscarLiquidacion())
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ya se encuentra generado la liquidacion del día " + dtpHasta.Value.ToShortDateString() + ".", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvIngresosxCajero.Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para procesar con fecha " + dtpHasta.Value.ToShortDateString() + ".", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de generar la liquidación de DGAI del dia " + dtpHasta.Value.ToShortDateString() +
                "? . Una vez generado no se podra anular. Si desea anular contacte con Sistemas.", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                decimal i = 0M;
                bool resuNum;
                string s = "";
                s = txtRetencion.Text;
                resuNum = decimal.TryParse(s, out i);

                if (!resuNum)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe de pago válido");
                    txtRetencion.Focus();
                    return;
                }

                try
                {
                    nro_liquidacion = cn.TraerDataset("usp_generar_liquidacion_dgai"
                    , VariablesMetodosEstaticos.idcajausuario
                    , dtpHasta.Value.ToShortDateString()
                    , Convert.ToDecimal(txtTotal.Text)
                    , Convert.ToDecimal(txtRetencion.Text)
                    , VariablesMetodosEstaticos.varUsuario,
                    VariablesMetodosEstaticos.host_user + " / " + VariablesMetodosEstaticos.ip_user).Tables[0].Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
                }


                if (nro_liquidacion == "0000000")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error al generar la liquidación. Intene de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DevComponents.DotNetBar.MessageBoxEx.Show("Se generó el nro de liquidación " + nro_liquidacion.ToString() + " correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblNro.Text = nro_liquidacion;
                AsignaReteText();

                btnAsignar.Enabled = true;
                txtRetencion.ReadOnly = true;
                btnGenerarDoscIngreso.Enabled = true;
                BtnBuscar_Click(sender, e);
            }

        }

        bool BuscarLiquidacion()
        {
            dtBusqLiq = new DataTable();
            dtBusqLiq = cn.TraerDataset("usp_buscar_liquidacion_dgai", dtpHasta.Value.ToString("yyyyMMdd")).Tables[0];
            if (dtBusqLiq.Rows.Count != 0)
            {
                lblNro.Text = Convert.ToInt32(dtBusqLiq.Rows[0][1]).ToString("0000000");
                lblIdLiquidacion.Text = dtBusqLiq.Rows[0][0].ToString();
                return true;
            }
            return false;
        }

        private void dgvIngresosxCajero_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            string filtro_="";

            if (cboTipo.Text == "DETRACCION")
            {
                filtro_ = "DT";
            }
            else if (cboTipo.Text == "JUDICIAL")
            {
                filtro_ = "JU";
            }
            else if (cboTipo.Text == "GARANTIA")
            {
                filtro_ = "GA";
            }

            try
            {
                if (filtro_ != "" && lblNro.Text != "0000000")
                {
                    frmPosibleResumen win = new frmPosibleResumen();
                    win.dtResultado = cn.TraerDataset("usp_obtiene_detraccion_liquidacion", Convert.ToInt32(lblIdLiquidacion.Text)/*Convert.ToInt32(cn.TraerDataset("usp_obtiene_Id_liquidacion_dgai", Convert.ToInt32(lblNro.Text)).Tables[0].Rows[0][0])*/, filtro_).Tables[0];
                    win.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }         
        }

        private void btnIngresosPorRubro_Click(object sender, EventArgs e)
        {
            //if (revisarIngresoDeposito())
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("No se han asignado por completo los voucher o medios de pagos.", VariablesMetodosEstaticos.encabezado,
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (lblNro.Text == "0000000")
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("No se ha asignado un número de liquidación a la fecha seleccionada.", VariablesMetodosEstaticos.encabezado,
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //saldoRecibo = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtRetencion.Text) + Convert.ToDecimal(txtDifDep.Text)) - (Convert.ToDecimal(cn.TraerDataset("usp_obtiene_total_por_liquidacion_dgai", Convert.ToInt32(lblNro.Text)).Tables[0].Rows[0][0]));
            
            //if (saldoRecibo==0.00m)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("No se puede generar documento de ingreso debido a que ya no tiene saldo pendiente por asignar.", VariablesMetodosEstaticos.encabezado,
            //           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //frmIngresoRubrosPorLiquidacion win = new frmIngresoRubrosPorLiquidacion();
            //win.saldoLiquidacion = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtRetencion.Text) + Convert.ToDecimal(txtDifDep.Text)) - (Convert.ToDecimal(cn.TraerDataset("usp_obtiene_total_por_liquidacion_dgai", Convert.ToInt32(lblNro.Text)).Tables[0].Rows[0][0]));
            //win.TotalLiquidacion = Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtRetencion.Text) + Convert.ToDecimal(txtDifDep.Text);
            //win.NroLiquidacion = Convert.ToInt32(lblNro.Text);
            //win.NroReciboLiquidacion = Convert.ToInt32(cn.TraerDataset("usp_obtieneNumeroIngresoDGAI").Tables[0].Rows[0][0]);
            //win.ShowDialog();
        }

        private bool revisarIngresoDeposito()
        {
            bool flagDeposito = false;

                for (int i = 0; i < dgvIngresosxCajero.RowCount; i++)
                {
                    if (Convert.ToDecimal(dgvIngresosxCajero.Rows[i].Cells[10].Value) < 0.00M)
                    {
                        flagDeposito = true;
                        break;
                    }
                }
            return flagDeposito;
        }

        private void btnListLiquidaciones_Click(object sender, EventArgs e)
        {
            DataTable dtLiquidaciones;
            dtLiquidaciones = new DataTable();

            dtLiquidaciones = cn.TraerDataset("usp_obtener_listado_liquidaciones",dtpFechaDesde.Value.ToShortDateString()
                ,dtpHasta.Value.ToShortDateString()).Tables[0];

            if (dtLiquidaciones.Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmListadoLiquidacion win = new frmListadoLiquidacion();
                win.listadoLiquidacion = dtLiquidaciones;
                win.ShowDialog();
                BtnBuscar_Click(sender, e);
            }
        }

        private void btnListDoc_Click(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(lblNro.Text) == 0)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Numero de liquidación válido.", VariablesMetodosEstaticos.encabezado,
            //           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //frmListadoDocumentosIngreso win = new frmListadoDocumentosIngreso();
            //win.nroliqui = Convert.ToInt32(lblNro.Text);
            //win.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
