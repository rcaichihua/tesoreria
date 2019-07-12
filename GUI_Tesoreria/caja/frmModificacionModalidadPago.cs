using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmModificacionModalidadPago : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public DateTime _FechaEmision { get; set; }
        public DateTime _FechaCancelacion { get; set; }
        public decimal Vventa_doc { get; set; }
        public decimal Igv_doc { get; set; }
        public decimal Total_doc { get; set; }
        public string Serie_doc { get; set; }
        public string Numero_doc { get; set; }
        public int ReciboId { get; set; }

        public DataTable ModPago { get; set; }
        public DataTable ModPago2 { get; set; }
        public int Modalidad_doc { get; set; }
        public int Concepto_doc { get; set; }
        public DateTime FechaDepo_doc { get; set; }
        public string EntidadFinanciera_doc { get; set; }
        public int CuentaBancaria_doc { get; set; }
        public decimal Importe_doc { get; set; }
        public decimal Tc_doc { get; set; }
        public decimal ImporteCambio_doc { get; set; }
        public string NroVoucherDoc_doc { get; set; }
        public string Obser_doc { get; set; }

        public int cod_mod_pago { get; set; }
        public string desc_mod_Pago { get; set; }
        public int concep_cod { get; set; }
        public DateTime FechaDeposito { get; set; }
        public string cod_entidad_financ { get; set; }
        public string nombre_entidad { get; set; }
        public string cuenta_bancaria_id { get; set; }
        public string numero_cuenta { get; set; }
        public decimal importe_voucher_pago { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal importe_cambio { get; set; }
        public string NumeroDocumento_Voucher_cheque_pago { get; set; }
        public string ObservacionPago { get; set; }

        public frmModificacionModalidadPago()
        {
            InitializeComponent();
        }
        DataTable modalidadesPago;
        CNegocio cn = new CNegocio();

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(true))
            {
                return;
            }
            else { errorProvider1.Clear(); }

            frmAgregarModalidadPago win = new frmAgregarModalidadPago();
            win.dtModalidadPago = modalidadesPago;
            win.ImportePago = Convert.ToDecimal(txtImportePago.Text);
            win.ImporteDocumento = Convert.ToDecimal(txtPrecioVentaC.Text);
            modalidadesPago = win.dtModalidadPago;
            win.ShowDialog();
        }
        private void crearTablaTemporal()
        {
            modalidadesPago = new DataTable();

            //modalidadesPago.Clear();

            modalidadesPago.Columns.Add("cod_mod_pago", typeof(string));
            modalidadesPago.Columns.Add("desc_mod_Pago", typeof(string));
            modalidadesPago.Columns.Add("concep_cod", typeof(string));
            modalidadesPago.Columns.Add("FechaDeposito", typeof(DateTime));
            modalidadesPago.Columns.Add("cod_entidad_financ", typeof(string));
            modalidadesPago.Columns.Add("nombre_entidad", typeof(string));
            modalidadesPago.Columns.Add("cuenta_bancaria_id", typeof(string));
            modalidadesPago.Columns.Add("numero_cuenta", typeof(string));
            modalidadesPago.Columns.Add("importe_voucher_pago", typeof(decimal));
            modalidadesPago.Columns.Add("TipoCambio", typeof(decimal));
            modalidadesPago.Columns.Add("importe_cambio", typeof(decimal));
            modalidadesPago.Columns.Add("NumeroDocumento_Voucher_cheque_pago", typeof(string));
            modalidadesPago.Columns.Add("ObservacionPago", typeof(string));
        }
        private bool ValidarCampos(bool agrega)
        {
            bool flag = true;

           if (cboModalidadPago.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboModalidadPago, "Seleccione modalidad de pago");
                flag = false;
            }
            else if (cboConcepto.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboConcepto, "Seleccione el tipo de concepto");
                flag = false;
            }
            else if (cboModalidadPago.SelectedIndex != 0)
            {
                DataTable dtGenerico = new DataTable();
                dtGenerico = cn.EjecutarSqlDTS("select descripcionTipo from tb_tipo_modalidad_pago where idTipo in (select idTipo from ta_modalidad_pago where cod_mod_Pago=" + cboModalidadPago.SelectedValue + ")").Tables[0];
                if (dtGenerico.Rows[0][0].ToString() == "EFECTIVO")
                {
                    if ((int)cboEntidadFinanciera.SelectedValue != 0)
                    {
                        if ((int)cboEntidadFinanciera.SelectedValue != 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ha seleccionado EFECTIVO y no puede seleccionar una entidad bancaria", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            cboCuenta.Focus();
                            flag = false;

                        }
                        else
                        {
                            if ((int)cboCuenta.SelectedValue != 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Ha seleccionado EFECTIVO y no puede seleccionar una cuenta bancaria.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                cboCuenta.Focus();
                                flag = false;
                            }
                            else
                            {
                                if (Convert.ToDecimal(txtImportePago.Text) != 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Este importe de pago es para solo DEPOSITOS u otras modalidades de pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                                else
                                {
                                    if (Convert.ToDecimal(txtTipoCambio.Text) != 1)
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                        txtImportePago.Focus();
                                        flag = false;
                                    }
                                    else
                                    {
                                        if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                            txtTotalCambioDolar.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            if (txtNumDocumento.Text.Trim() != "")
                                            {
                                                DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                                txtNumDocumento.Focus();
                                                flag = false;
                                            }
                                            else
                                            {
                                                DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                                txtObservacionesPago.Focus();
                                                flag = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (lblTipoMoneda.Text != "S/.")
                        {
                            if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                txtTipoCambio.Focus();
                                flag = false;
                            }
                            else
                            {
                                if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe correcto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                                else
                                {
                                }
                            }
                        }
                        else
                        {
                            if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                            {
                                if (modalidadesPago.Rows.Count == 0)
                                {
                                    txtImportePago.Text = txtPrecioVentaC.Text;
                                }

                            }
                            else
                            {
                                if (txtNumDocumento.Text.Trim() != "")
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("El numero de documento de pago no debe contener valores.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                    txtNumDocumento.Focus();
                                    flag = false;
                                }
                            }
                        }
                    }
                }
                else if (dtGenerico.Rows[0][0].ToString() == "DEPOSITO" || dtGenerico.Rows[0][0].ToString() == "ABONO EN CUENTA" || dtGenerico.Rows[0][0].ToString() == "TRANSFERENCIA" || dtGenerico.Rows[0][0].ToString() == "CHEQUE")
                {
                    if ((int)cboEntidadFinanciera.SelectedValue != 0)
                    {
                        if ((int)cboEntidadFinanciera.SelectedValue != 0)
                        {
                            if ((int)cboCuenta.SelectedValue != 0)
                            {
                                if (Convert.ToDecimal(txtImportePago.Text) != 0)
                                {
                                    if (lblTipoMoneda.Text != "S/.")
                                    {
                                        if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                            txtTipoCambio.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                            {
                                                if (txtNumDocumento.Text.Trim() != "")
                                                {

                                                }
                                                else
                                                {
                                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Número de documento.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                    txtNumDocumento.Focus();
                                                    flag = false;
                                                }
                                            }
                                            else
                                            {
                                                DevComponents.DotNetBar.MessageBoxEx.Show("El importe total de cambio es incorrecto, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                txtTotalCambioDolar.SelectAll();
                                                flag = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDecimal(txtTipoCambio.Text) != 1)
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                            txtTipoCambio.Focus();
                                            flag = false;
                                        }
                                        else
                                        {
                                            if (Convert.ToDecimal(txtTotalCambioDolar.Text) != 0)
                                            {
                                                if (txtNumDocumento.Text.Trim() != "")
                                                {
                                                }
                                                else
                                                {
                                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Número de documento.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                    txtNumDocumento.Focus();
                                                    flag = false;
                                                }
                                            }
                                            else
                                            {
                                                DevComponents.DotNetBar.MessageBoxEx.Show("El importe total de cambio es incorrecto, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                                txtTotalCambioDolar.Focus();
                                                flag = false;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el importe de pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione el Nro de cuenta.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                                cboCuenta.Focus();
                                flag = false;
                            }

                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago no es coherente con los datos del pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                            cboEntidadFinanciera.Focus();
                            flag = false;
                        }
                    }
                    else
                    {
                        if (dtGenerico.Rows[0][0].ToString() == "CHEQUE")
                        {
                            if (lblTipoMoneda.Text != "S/.")
                            {
                                if (Convert.ToDecimal(txtTipoCambio.Text) <= 1)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el tipo de cambio de dolar correcto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                                    txtTipoCambio.Focus();
                                    flag = false;
                                }
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una entidad bancaria.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                            cboEntidadFinanciera.Focus();
                            flag = false;
                        }
                    }
                }
            }
            else errorProvider1.Clear();

            if (Convert.ToDecimal(txtImportePago.Text) <= 0)
            {
                if (modalidadesPago.Rows.Count == 0)
                {
                    txtImportePago.Text = txtPrecioVentaC.Text;
                }
            }

            if (cboModalidadPago.SelectedIndex == 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cboModalidadPago, "Seleccione modalidad de pago");
                flag = false;
            }

            return flag;
        }

        private void frmModificacionModalidadPago_Load(object sender, EventArgs e)
        {
            dtpFechaCancelacion.Value = _FechaCancelacion;
            dtpFechaEmision.Value = _FechaEmision;
            cargarModalidadPago();
            cargarConcepto();
            cargarEntidadFinanciera();
            cargarCuentaBancaria();
            crearTablaTemporal();

            lblSerieFactura.Text = Serie_doc;
            lblCorrelativoFactura.Text = Numero_doc;
            //cboModalidadPago.SelectedValue = ModPago.Rows[0][0].ToString();
            //cboConcepto.SelectedValue = ModPago.Rows[0][1].ToString();
            //dtpFechaPago.Value = Convert.ToDateTime(ModPago.Rows[0][2].ToString()==""? DateTime.Now: Convert.ToDateTime(ModPago.Rows[0][2].ToString()));
            //cboEntidadFinanciera.SelectedValue= ModPago.Rows[0][3].ToString()=="" ? 0 : Convert.ToInt32(ModPago.Rows[0][3].ToString());
            //cboCuenta.SelectedValue= ModPago.Rows[0][4].ToString() == "" ? 0 : Convert.ToInt32(ModPago.Rows[0][4].ToString());
            //txtImportePago.Text= ModPago.Rows[0][5].ToString() == "" ? "0.00" : Convert.ToDecimal(ModPago.Rows[0][5].ToString()).ToString("###,###,##0.00");
            //txtTipoCambio.Text = ModPago.Rows[0][6].ToString() == "" ? "1.000" : Convert.ToDecimal(ModPago.Rows[0][6].ToString()).ToString("###,###,##0.000");
            //txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("###,###,##0.00");
            //txtNumDocumento.Text = ModPago.Rows[0][7].ToString();
            //txtObservacionesPago.Text = ModPago.Rows[0][8].ToString();
            //dtpFechaEmision.Value = Convert.ToDateTime(ModPago.Rows[0][9]);
            //dtpFechaCancelacion.Value = Convert.ToDateTime(ModPago.Rows[0][10]);

            txtValorVentaC.Text= Vventa_doc.ToString("###,###,##0.00");
            txtIGVC.Text=Igv_doc.ToString("###,###,##0.00");
            txtPrecioVentaC.Text=Total_doc.ToString("###,###,##0.00");

            //modalidadesPago = ModPago2;
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
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void cboCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dsetMoneda = new DataSet();
                int idCuenta = Convert.ToInt32(cboCuenta.SelectedValue);
                dsetMoneda = cn.TraerDataset("usp_obtiene_abreviatura_moneda", idCuenta);

                if (Convert.ToInt32(dsetMoneda.Tables[0].Rows[0][1]) == 2)
                {
                    DataSet dtsValorDolar = new DataSet();

                    dtsValorDolar = cn.TraerDataset("usp_s_tb_tipoCambioDolar_valor");
                    if (dtsValorDolar.Tables[0].Rows.Count > 0)
                    {
                        txtTipoCambio.Text = Convert.ToDecimal(dtsValorDolar.Tables[0].Rows[0][0]).ToString("##0.000");
                        lblTipoMoneda.Text = dsetMoneda.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        txtTipoCambio.Text = "1.000";
                        lblTipoMoneda.Text = dsetMoneda.Tables[0].Rows[0][0].ToString();
                    }
                }
                else
                {
                    if (lblTipoMoneda.Text == "???")
                    {
                        lblTipoMoneda.Text = dsetMoneda.Tables[0].Rows[0][0].ToString();
                        txtTipoCambio.Text = "1.000";
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void txtImportePago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("##,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtTipoCambio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambioDolar.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("##,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGrabarC_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 1 || Convert.ToInt32(cboModalidadPago.SelectedValue) == 11 ||
                Convert.ToInt32(cboModalidadPago.SelectedValue) == 19 || Convert.ToInt32(cboModalidadPago.SelectedValue) == 20)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago ingresa no esta permitida.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos(true))
            {
                return;
            }
            else { errorProvider1.Clear(); }

            if (cboModalidadPago.SelectedIndex==0)
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de modificar la fecha de CANCELACION.", VariablesMetodosEstaticos.encabezado,
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    cn.EjecutarUD("update tb_ReciboCabecera set fechaCancelacion='" +
                    dtpFechaCancelacion.Value.ToString("dd/MM/yyyy") + "' where ReciboID =" + ReciboId + "");

                    DevComponents.DotNetBar.MessageBoxEx.Show("Se modifico la fecha de cancelación correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    return;
                }
            }
            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de guardar? Una vez guardado no podra modificarlo.", VariablesMetodosEstaticos.encabezado,
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                if (!ValidarTotales())
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El total del documento no coincide con la suma total de modalidades de pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
                decimal tot = 0.00m;

                for (int i = 0; i < modalidadesPago.Rows.Count; i++)
                {
                    tot = tot + Convert.ToDecimal(modalidadesPago.Rows[i][10]);
                }

                if (tot + Convert.ToDecimal(txtTotalCambioDolar.Text) < Convert.ToDecimal(txtPrecioVentaC.Text))
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("La suma total de modalidades de pago es menor al total del documento." +
                        Environment.NewLine + Environment.NewLine + "No se puede continuar.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = modalidadesPago.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = modalidadesPago.Rows[i];
                    if (dr["cod_mod_pago"].ToString() == (cboModalidadPago.SelectedValue).ToString() && 
                        dr["concep_cod"].ToString() == (cboConcepto.SelectedValue).ToString() &&
                        Convert.ToDecimal(dr["importe_voucher_pago"]) == Convert.ToDecimal(txtImportePago.Text) &&
                        Convert.ToDateTime(dr["FechaDeposito"]).ToShortDateString() == dtpFechaPago.Value.ToShortDateString())
                        dr.Delete();
                }
                modalidadesPago.AcceptChanges();

                cod_mod_pago = Convert.ToInt16(cboModalidadPago.SelectedValue);
                desc_mod_Pago = cboModalidadPago.Text;
                concep_cod = Convert.ToInt16(cboConcepto.SelectedValue);
                FechaDeposito = dtpFechaPago.Value;
                cod_entidad_financ = cboEntidadFinanciera.SelectedValue.ToString() == "0" ? null : cboEntidadFinanciera.SelectedValue.ToString();
                nombre_entidad = cboEntidadFinanciera.Text == "[seleccione]" ? null : cboEntidadFinanciera.Text;
                cuenta_bancaria_id = Convert.ToInt32(cboCuenta.SelectedValue) == 0 ? null : cboCuenta.SelectedValue.ToString();
                numero_cuenta = cboCuenta.Text == "[seleccione]" ? null : cboCuenta.Text;
                importe_voucher_pago = Convert.ToDecimal(txtImportePago.Text);
                TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);
                importe_cambio = Convert.ToDecimal(txtTotalCambioDolar.Text);
                NumeroDocumento_Voucher_cheque_pago = txtNumDocumento.Text;
                ObservacionPago = txtObservacionesPago.Text.Trim();

                DataRow _filaAddNewModalidad = modalidadesPago.NewRow();

                _filaAddNewModalidad["cod_mod_pago"] = cod_mod_pago;
                _filaAddNewModalidad["desc_mod_Pago"] = desc_mod_Pago;
                _filaAddNewModalidad["concep_cod"] = concep_cod;
                _filaAddNewModalidad["FechaDeposito"] = FechaDeposito;
                _filaAddNewModalidad["cod_entidad_financ"] = cod_entidad_financ;
                _filaAddNewModalidad["nombre_entidad"] = nombre_entidad;
                _filaAddNewModalidad["cuenta_bancaria_id"] = cuenta_bancaria_id;
                _filaAddNewModalidad["numero_cuenta"] = numero_cuenta;
                _filaAddNewModalidad["importe_voucher_pago"] = importe_voucher_pago;
                _filaAddNewModalidad["TipoCambio"] = TipoCambio;
                _filaAddNewModalidad["importe_cambio"] = importe_cambio;
                _filaAddNewModalidad["NumeroDocumento_Voucher_cheque_pago"] = NumeroDocumento_Voucher_cheque_pago;
                _filaAddNewModalidad["ObservacionPago"] = ObservacionPago;

                modalidadesPago.Rows.Add(_filaAddNewModalidad);

                if (cn.ActualizaModalidadPago("usp_actualiza_modalidad_pago", ReciboId, cod_mod_pago, concep_cod, FechaDeposito.ToString("yyyyMMdd"), 
                    cod_entidad_financ,cuenta_bancaria_id, importe_voucher_pago, TipoCambio, importe_cambio, NumeroDocumento_Voucher_cheque_pago,
                    ObservacionPago, dtpFechaCancelacion.Value.ToString("yyyyMMdd"), modalidadesPago).Tables[0].Rows[0][0].ToString() == "1")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Se actualizo la modalidad de pago correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarTotales()
        {
            decimal total = 0.00m;

            foreach (DataRow item in modalidadesPago.Rows)
            {
                total = total + Convert.ToDecimal(item["importe_cambio"].ToString() == "" ? "0" : item["importe_cambio"].ToString());
            }

            total = total + Convert.ToDecimal(txtTotalCambioDolar.Text);

            return (total == Convert.ToDecimal(txtPrecioVentaC.Text));
        }
    }
}
