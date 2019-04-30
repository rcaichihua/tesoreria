﻿using System;
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

        public frmEdicionVouchers()
        {
            InitializeComponent();
        }

        private void frmEdicionVouchers_Load(object sender, EventArgs e)
        {
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
            txtTipoCambio.Text = TipoCambio.ToString("###,###,##0.00");
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
            if (Tabla.Length < 5)
            {
                
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
                VariablesMetodosEstaticos.ip_user + '/' + VariablesMetodosEstaticos.host_user, caja, dtpFechaPago.Value.ToString("yyyyMMdd")).Tables[0];

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
                dtresu = cn.TraerDataset("usp_ActualizaVoucherPago", Tabla, IdDocumento, cboModalidadPago.SelectedValue, cboConcepto.SelectedValue,
                cboEntidadFinanciera.SelectedValue, cboCuenta.SelectedValue, Convert.ToDecimal(txtImportePago.Text),
                Convert.ToDecimal(txtTipoCambio.Text), txtNumDocumento.Text.Trim(),
                txtObservacionesPago.Text, VariablesMetodosEstaticos.varNombreUser,
                VariablesMetodosEstaticos.ip_user + '/' + VariablesMetodosEstaticos.host_user, caja, dtpFechaPago.Value.ToString("yyyyMMdd")).Tables[0];

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
    }
}
