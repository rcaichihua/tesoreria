using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmEdicionVouchers : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public bool Existe_ { get; set; }
        public int IdDocumento { get; set; }
        public string Tabla { get; set; }
        public int ModalidadPagoId { get; set; }
        public int ConceptoId { get; set; }
        public DateTime FechaDeposito { get; set; }
        public int EntidadFinancieraId { get; set; }
        public int CuentaBancariaId { get; set; }
        public decimal Monto { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Total { get; set; }
        public string NroVoucher { get; set; }
        public string Observaciones { get; set; }
        public bool Save_ { get; set; }
        public string caja { get; set; }
        public DateTime _FechaLiq { get; set; }

        public frmEdicionVouchers()
        {
            InitializeComponent();
        }

        private void frmEdicionVouchers_Load(object sender, EventArgs e)
        {
            txtNeto.Visible = false;
            txtImpuesto.Visible = false;
            BtnBuscarDoc.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            cargarModalidadPago();
            cargarConcepto();
            cargarEntidadFinanciera();
            cargarCuentaBancaria();

            cboModalidadPago.SelectedValue = ModalidadPagoId;
            cboConcepto.SelectedValue = ConceptoId;
            dtpFechaPago.Value = FechaDeposito;
            cboEntidadFinanciera.SelectedValue = EntidadFinancieraId;
            cboCuenta.SelectedValue = CuentaBancariaId;
            txtImportePago.Text = Monto.ToString("###,###,##0.00");
            txtTipoCambio.Text = TipoCambio.ToString("###,###,##0.000");
            txtTotalCambioDolar.Text = Total.ToString("###,###,##0.00");
            txtNumDocumento.Text = NroVoucher;
            txtObservacionesPago.Text = Observaciones;
        }

        private void cargarModalidadPago()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_modalidad_pago").Tables[0];
                cboModalidadPago.DataSource = dt;
                cboModalidadPago.DisplayMember = "desc_mod_Pago";
                cboModalidadPago.ValueMember = "cod_mod_pago";
            }
            catch (Exception)
            {
            }
        }
        private void cargarConcepto()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_concepto").Tables[0];
                cboConcepto.DataSource = dt;
                cboConcepto.DisplayMember = "CONCEP_DESC";
                cboConcepto.ValueMember = "CONCEP_COD";
            }
            catch (Exception)
            {
            }
        }
        private void cargarEntidadFinanciera()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_entidad_financiera").Tables[0];
                cboEntidadFinanciera.DataSource = dt;
                cboEntidadFinanciera.DisplayMember = "nombre_entidad";
                cboEntidadFinanciera.ValueMember = "cod_entidad_financ";
            }
            catch (Exception)
            {
            }
        }
        private void cargarCuentaBancaria()
        {
            cboCuenta.SelectedIndex = 0;
        }

        private void cboEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboEntidadFinanciera.SelectedValue) != 0)
                {
                    if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una modalidad de pago antes de continuar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboEntidadFinanciera.SelectedValue = 0;
                        cboModalidadPago.Select();
                        return;
                    }
                }
                else
                {
                    cboModalidadPago_SelectedIndexChanged(sender, e);
                }

                var dt = new DataTable();
                dt = cn.TraerDataset("usp_select_cuenta_bancaria", cboEntidadFinanciera.SelectedValue, cboModalidadPago.SelectedValue).Tables[0];
                cboCuenta.Refresh();
                cboCuenta.DataSource = dt;
                cboCuenta.DisplayMember = "numero_cuenta";
                cboCuenta.ValueMember = "cuenta_bancaria_id";
            }
            catch (Exception)
            {
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dtresu = new DataTable();
            if (!Validar())
            {
                return;
            }
            if (Convert.ToInt16(cboModalidadPago.SelectedValue)==1 || Convert.ToInt16(cboModalidadPago.SelectedValue) == 4 || 
                Convert.ToInt16(cboModalidadPago.SelectedValue) == 11 || Convert.ToInt16(cboModalidadPago.SelectedValue) == 14)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago que intenta ingresar no es válida, seleccione otra." + dtresu.Rows[0][0].ToString(), VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //AQUI NO ES NECESARIO TENER VALOR EN LA VARIABLE Tabla DEBIDO A QUE CON LA FECHA DE LIQUIDACION Y FUENTEORIGEN
            //ES SUFICIENTE SABER A QUE TABLA DE DEPOSITO VA AFECTAR YA SEA A LA TABLA DE INMOBILIARIA O DE TESORERIA
            //PROGRAMAS.
            if (Tabla.Length < 5)
            {
                if (!verificaDuplicidad())
                {
                    MessageBox.Show("Error de duplicidad. El voucher/Cheque ya fue registrado. Verifique.", VariablesGlobales.NombreMensajes,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                //if (Existe_ == true)
                //{
                //    DevComponents.DotNetBar.MessageBoxEx.Show("Este voucher ya se encuentra generado dentro de una liquidación y no se puede modificar.", VariablesMetodosEstaticos.encabezado,
                //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                dtresu = cn.TraerDataset("usp_ActualizaVoucherPago", Tabla, IdDocumento, cboModalidadPago.SelectedValue, cboConcepto.SelectedValue,
                cboEntidadFinanciera.SelectedValue, cboCuenta.SelectedValue, Convert.ToDecimal(txtImportePago.Text),
                Convert.ToDecimal(txtTipoCambio.Text), txtNumDocumento.Text.Trim(),
                txtObservacionesPago.Text, VariablesMetodosEstaticos.varNombreUser,
                VariablesMetodosEstaticos.ip_user + '/' + VariablesMetodosEstaticos.host_user, caja, 
                dtpFechaPago.Value.ToString("yyyyMMdd"), Convert.ToDecimal(txtTotalCambioDolar.Text)).Tables[0];

                if (dtresu.Rows[0][0].ToString().Substring(0, 2) == "VO" || dtresu.Rows[0][0].ToString().Substring(0, 2) == "RE")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(dtresu.Rows[0][0].ToString(), VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Save_ = true;
                    this.Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error: " + dtresu.Rows[0][0].ToString(), VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Save_ = true;
                    //this.Close();
                }
            }
            else
            {
                if (!verificaDuplicidad())
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de registrar el VOUCHER?"+Environment.NewLine + Environment.NewLine+
                        "Al parecer el documento ya existe, si lo esta editando se va a actualizar,"+Environment.NewLine+
                        "si lo esta registrando como NUEVO entonces se va a duplicar.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No))
                    {
                        return;
                    }
                        //MessageBox.Show("Error de duplicidad. El voucher/Cheque ya fue registrado. Verifique.", VariablesGlobales.NombreMensajes,
                        //    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    //return;
                }

                //AQUI ENTRA PORQUE LA VARIABLE TABLA ESTA LLENA Y CON ESA TABLA SE PUEDE SABER A QUE TABLA SE VA A MODIFICAR.
                dtresu = cn.TraerDataset("usp_ActualizaVoucherPago", Tabla, IdDocumento, cboModalidadPago.SelectedValue, 
                    cboConcepto.SelectedValue,
                cboEntidadFinanciera.SelectedValue, cboCuenta.SelectedValue, Math.Round(Convert.ToDecimal(txtImportePago.Text),2,MidpointRounding.AwayFromZero),
                Convert.ToDecimal(txtTipoCambio.Text), txtNumDocumento.Text.Trim(),
                txtObservacionesPago.Text, VariablesMetodosEstaticos.varNombreUser,
                VariablesMetodosEstaticos.ip_user + '/' + VariablesMetodosEstaticos.host_user, caja, 
                dtpFechaPago.Value.ToString("yyyyMMdd"), Convert.ToDecimal(txtTotalCambioDolar.Text)).Tables[0];

                if (dtresu.Rows[0][0].ToString().Substring(0, 2) == "VO" || dtresu.Rows[0][0].ToString().Substring(0, 2) == "RE")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(dtresu.Rows[0][0].ToString(), VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Save_ = true;
                    this.Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error: " + dtresu.Rows[0][0].ToString(), VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Save_ = true;
                    //this.Close();
                }
            }
        }

        bool verificaDuplicidad()
        {
            bool rspta;
            rspta = false;

            DataTable dtTotalRepetido = new DataTable();
            dtTotalRepetido = cn.TraerDataset("usp_verifica_duplicidad_voucher_general",Tabla
                , txtNumDocumento.Text.Trim().ToUpper(), cboEntidadFinanciera.SelectedValue,
                cboConcepto.SelectedValue,dtpFechaPago.Value.ToString("yyyyMMdd"),Convert.ToDecimal(txtTotalCambioDolar.Text)).Tables[0];
            if (dtTotalRepetido.Rows.Count > 0)
            {
                MessageBox.Show("El documento ya se ingreso como " + cboConcepto.Text.ToUpper() +
                    " con el importe de " + dtTotalRepetido.Rows[0][0].ToString() + "." +
                    Environment.NewLine + "ingrese el vocher bajo otro CONCEPTO para que se pueda registrar.",
                    VariablesGlobales.NombreMensajes,
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rspta = false;
            }
            else
            {
                rspta = true;
            }
            return rspta;
        }

        bool Validar()
        {
            if (cboModalidadPago.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione Modalidad de pago", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                cboModalidadPago.Focus();
                return false;
            }
            if (cboConcepto.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Concepto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                cboConcepto.Focus();
                return false;
            }
            if (cboEntidadFinanciera.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una Entidad financiera.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                cboEntidadFinanciera.Focus();
                return false;
            }
            if (cboCuenta.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una cuenta", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                cboCuenta.Focus();
                return false;
            }
            decimal i = 0M;
            bool resuNum;
            string s = "";
            s = txtImportePago.Text;
            resuNum = decimal.TryParse(s, out i);

            if (!resuNum)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe de pago válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtImportePago.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtTotalCambioDolar.Text) == 0.00M)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe mayor a 0.00", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtTotalCambioDolar.Focus();
                    return false;
                }
            }

            s = txtTotalCambioDolar.Text;
            resuNum = decimal.TryParse(s, out i);

            if (!resuNum)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe de pago válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtTotalCambioDolar.Text) == 0.00M)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe mayor a 0.00", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtTotalCambioDolar.Focus();
                    return false;
                }
            }

            if (txtNumDocumento.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese número de voucher", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtNumDocumento.Focus();
                return false;
            }

            if (lblTipoMoneda.Text != "S/.")
            {
                if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un tipo de cambio correcto para el tipo de moneda que ha seleccionado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    txtTipoCambio.Focus();
                    return false;
                }
            }
            if (lblTipoMoneda.Text == "S/.")
            {
                if (Convert.ToDecimal(txtTipoCambio.Text) > 1)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un tipo de cambio correcto para el tipo de moneda que ha seleccionado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    txtTipoCambio.Focus();
                    return false;
                }
            }
            return true;
        }

        private void cboModalidadPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 0)
                {
                    cboEntidadFinanciera.SelectedValue = 0;
                }

                DataSet dsetMonedaModPago = new DataSet();
                int idModPago = Convert.ToInt32(cboModalidadPago.SelectedValue);
                txtImportePago.Text = "0.00";
                txtTipoCambio.Text = "1.00";
                txtTotalCambioDolar.Text = "0.00";
                txtNumDocumento.Clear();
                dsetMonedaModPago = cn.TraerDataset("usp_obtiene_abreviatura_moneda_modPago", idModPago);

                if (Convert.ToInt32(dsetMonedaModPago.Tables[0].Rows[0][0]) == 2)
                {
                    DataSet dtsValorDolar = new DataSet();

                    dtsValorDolar = cn.TraerDataset("usp_s_tb_tipoCambioDolar_valor");
                    if (dtsValorDolar.Tables[0].Rows.Count > 0)
                    {
                        txtTipoCambio.Text = Convert.ToDecimal(dtsValorDolar.Tables[0].Rows[0][0]).ToString("##0.000");
                        lblTipoMoneda.Text = dsetMonedaModPago.Tables[0].Rows[0][1].ToString();
                    }
                    else
                    {
                        lblTipoMoneda.Text = dsetMonedaModPago.Tables[0].Rows[0][1].ToString();
                        txtTipoCambio.Text = "1.000";
                    }
                }
                else
                {
                    lblTipoMoneda.Text = dsetMonedaModPago.Tables[0].Rows[0][1].ToString();
                    txtTipoCambio.Text = "1.000";
                }
                cboEntidadFinanciera.SelectedValue = 0;
            }
            catch (Exception)
            {
            }
        }

        private void txtImportePago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtTipoCambio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string id_liq;
                id_liq = "";
                DataTable dt = new DataTable();
                dt = cn.TraerDataset("USP_LISTA_DOC_LIQUIDACION",
                    Convert.ToInt32(id_liq), null).Tables[0];

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", "Aplicacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmListadoDocumentosLiqInmo win = new frmListadoDocumentosLiqInmo();
                win.Lista = dt;
                win.IdLiq = Convert.ToInt32(id_liq);
                win.ShowDialog();
            }
            catch (Exception)
            {

            }           
        }

        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboConcepto.SelectedValue.ToString() == "2")
                {
                    txtNeto.Visible = true;
                    txtImpuesto.Visible = true;
                    BtnBuscarDoc.Visible = true;
                    label2.Visible = true;
                    label1.Visible = true;
                }
                else
                {
                    txtNeto.Visible = false;
                    txtImpuesto.Visible = false;
                    BtnBuscarDoc.Visible = false;
                    label2.Visible = false;
                    label1.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
