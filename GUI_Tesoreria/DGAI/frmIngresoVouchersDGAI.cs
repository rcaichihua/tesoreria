using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.DGAI
{
    public partial class frmIngresoVouchersDGAI : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        DataTable dtResu;
        public int idCajeroIngresoVouchers { get; set; }
        public int idCobradorDGAI { get; set; }
        public DateTime fechaLiquidacionDGAI { get; set; } //aqui se maneja dos fecha -> fecha liqDGAI(cuanod lo ingresaron en DGAI) y fecha liq(AD) cuanod lo registraron en Alta Direccion
        public decimal importe { get; set; }
        public int cantDoc { get; set; }
        public int idLiquidacion { get; set; }
        public bool habilita { get; set; }
        string resultadoVoucher = "";

        public frmIngresoVouchersDGAI()
        {
            InitializeComponent();
        }

        private void btnVerIngresos_Click(object sender, EventArgs e)
        {
            dtResu = new DataTable();
            dtResu = cn.TraerDataset("usp_obtiene_ingreso_por_tipo_pago", idCajeroIngresoVouchers
                ,dtpFechaCobro.Value.ToShortDateString(),11).Tables[0];
            //En la base de datos aparece en vez de 11 pongo 3 -> Depositos

            if (dtResu.Rows[0][0].ToString() != "0")
            {
                txtCantidadDocumentos.Text = dtResu.Rows[0][0].ToString();
                txtImporteEfectivo.Text = Convert.ToDecimal(dtResu.Rows[0][1]).ToString("##,##0.00");

            }
            else
            {
                MessageBox.Show("No hay ingresos para la fecha seleccionada", VariablesMetodosEstaticos.encabezado
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmIngresoVouchers_Load(object sender, EventArgs e)
        {
            cargarModalidadPago();
            cboModalidadPago.SelectedValue = 3;
            cargarConcepto();
            cargarEntidadFinanciera();
            cargarCuentaBancaria();
            cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()),idCobradorDGAI, idCajeroIngresoVouchers);
            habilitaBotones(habilita);
            AsignarVariables();
            txtImporteEfectivo.ReadOnly = true;
            txtCantidadDocumentos.ReadOnly = true;
            dtpFechaCobro.Enabled = false;
        }

        private void AsignarVariables()
        {
            txtImporteEfectivo.Text = importe.ToString("##,##0.00");
            txtImportePago.Text = importe.ToString("##,##0.00");
            txtCantidadDocumentos.Text = cantDoc.ToString();
            dtpFechaCobro.Value = fechaLiquidacionDGAI;
        }

        void habilitaBotones(bool hab)
        {
            btnEliminar.Enabled = hab;
            btnGuardar.Enabled = hab;
            btnAsignar.Enabled = hab;
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
                //MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
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
                //MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
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
                //MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
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
                var dt = new DataTable();
                try
                {
                    dt = cn.TraerDataset("usp_select_cuenta_bancaria", cboEntidadFinanciera.SelectedValue).Tables[0];
                    cboCuenta.Refresh();
                    cboCuenta.DataSource = dt;
                    cboCuenta.DisplayMember = "numero_cuenta";
                    cboCuenta.ValueMember = "cuenta_bancaria_id";
                }
                catch (Exception)
                {
                    //MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                txtTotalCambio.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("##,##0.00");
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
                txtTotalCambio.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("##,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtTotalCambioDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
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
                    lblTipoMoneda.Text = dsetMoneda.Tables[0].Rows[0][0].ToString();
                    txtTipoCambio.Text = "1.000";
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            if (verificaDuplicidad() > 0)                                                                                                                                         
            {
                MessageBox.Show("Error de duplicidad. El voucher/Cheque ya fue registrado. Verifique.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            try
            {
                if ((MessageBox.Show("¿Desea continuar con el registro del voucher?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    resultadoVoucher = cn.TraerDataset("usp_ingresar_depositos_efectivo_dgai",idLiquidacion, Convert.ToInt32(cboModalidadPago.SelectedValue)
                        , Convert.ToInt32(cboConcepto.SelectedValue), Convert.ToDateTime(dtpFechaDeposito.Value.ToShortDateString())
                        , Convert.ToInt32(cboEntidadFinanciera.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue)
                        , lblTipoMoneda.Text, Convert.ToDecimal(txtImportePago.Text), Convert.ToDecimal(txtTipoCambio.Text)
                        , Convert.ToDecimal(txtTotalCambio.Text), txtNumDocumento.Text.Trim(), txtObservacionesPago.Text
                        , Convert.ToDateTime(dtpFechaCobro.Value.ToShortDateString()), Convert.ToInt32(txtCantidadDocumentos.Text)
                        , Convert.ToDecimal(txtImporteEfectivo.Text), idCobradorDGAI, idCajeroIngresoVouchers,
                        VariablesMetodosEstaticos.varNombreUser).Tables[0].Rows[0][0].ToString();

                    if ( resultadoVoucher== "1")
                    {
                        MessageBox.Show("Ingresado correctamente.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Actualizar();
                        Limpiar();                        
                        cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()),idCobradorDGAI, idCajeroIngresoVouchers);
                    }
                    else if (resultadoVoucher == "0")
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        bool Validar()
        {
            if (cboModalidadPago.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Modalidad de pago", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cboModalidadPago.Focus();
                return false;
            }
            if (cboConcepto.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Concepto", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cboConcepto.Focus();
                return false;
            }
            if (cboEntidadFinanciera.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Entidad financiera", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cboEntidadFinanciera.Focus();
                return false;
            }
            if (cboCuenta.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione cuenta", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                cboCuenta.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtImporteEfectivo.Text) <= 0.00M)
            {
                MessageBox.Show("Ya excedio el monto permitido de asignación de vouchers por cobrador.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtImporteEfectivo.Focus();
                return false;
            }
            if (idLiquidacion == 0)
            {
                MessageBox.Show("No se asigno un número de liquidacion válido. Intente de nuevo, si el problema persiste contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }

            decimal i = 0M;
            bool resuNum;
            string s = "";
            s = txtImportePago.Text;
            resuNum = decimal.TryParse(s,out i);

            if (!resuNum)
            {
                MessageBox.Show("Ingrese un importe de pago válido", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtImportePago.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtImportePago.Text) == 0.00M)
                {
                    MessageBox.Show("Ingrese un importe mayor a 0.00", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtImportePago.Focus();
                    return false;
                }
            }

            s = txtTotalCambio.Text;
            resuNum = decimal.TryParse(s, out i);

            if (!resuNum)
            {
                MessageBox.Show("Ingrese un importe de pago válido", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtTotalCambio.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtTotalCambio.Text) == 0.00M)
                {
                    MessageBox.Show("Ingrese un importe mayor a 0.00", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtTotalCambio.Focus();
                    return false;
                }
            }

            if (txtNumDocumento.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Ingrese número de voucher.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtNumDocumento.Focus();
                return false;
            }
            if (txtCantidadDocumentos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado la fecha de ingreso a la que se va a relacionar el voucher.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                dtpFechaCobro.Focus();
                return false;
            }
            if (txtImporteEfectivo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado la fecha de ingreso a la que se va a relacionar el voucher.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                dtpFechaCobro.Focus();
                return false;
            }
            return true;
        }
                                        
        int verificaDuplicidad()
        {
            return Convert.ToInt32(cn.TraerDataset("usp_verifica_duplicidad_voucher", dtpFechaDeposito.Value.ToShortDateString()
                , txtImportePago.Text, txtNumDocumento.Text).Tables[0].Rows[0][0]);
        }

        void cargarDepositos(DateTime fechaFiltroDesde, DateTime fechaFiltroHasta,int idCobradorDGAI_, int idCajeroIngresoVouchers_)
        {
            try
            {
                dgvDepositos.DataSource = cn.TraerDataset("usp_selectAllingresosEfectivoDepositoDGAI", fechaFiltroDesde, fechaFiltroHasta, idCobradorDGAI_, idCajeroIngresoVouchers_).Tables[0];
            }
            catch (Exception)
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()),Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()),idCobradorDGAI, idCajeroIngresoVouchers);
        }

        void Limpiar()
        {
            cboModalidadPago.SelectedValue = 3;
            cboConcepto.SelectedIndex = 0;
            dtpFechaDeposito.Value = DateTime.Now;
            cboEntidadFinanciera.SelectedIndex = 0;
            cboCuenta.SelectedIndex = 0;          
            txtImportePago.Text = "0.00";
            txtTipoCambio.Text = "1.000";
            txtTotalCambio.Text = "0.00";
            txtNumDocumento.Clear();
            txtObservacionesPago.Clear();
            //dtpFechaCobro.Value = DateTime.Now;
            //txtCantidadDocumentos.Clear();
            //txtImporteEfectivo.Clear();
        }
        void Actualizar()
        {
            importe = importe - Convert.ToDecimal(txtTotalCambio.Text);
            txtImporteEfectivo.Text = importe.ToString("##,##0.00");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepositos.RowCount > 0)
                {
                    if (Convert.ToInt32(cn.TraerDataset("usp_verifica_existencia_ingreso_dgai", idLiquidacion).Tables[0].Rows[0][0]) > 0)
                    {
                        MessageBox.Show("No se puede eliminar el voucher porque ya se generaron Docs de ingreso.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    if ((MessageBox.Show("¿Esta seguro de eliminar el deposito seleccionado.?", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        if (cn.EjecutarTransaccionDoble("usp_eliminar_depositos_efectivo_dgai", "usp_eliminar_ingreso_voucher_x_caja_dgai"
                            , Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value), Convert.ToDateTime(dgvDepositos.CurrentRow.Cells[1].Value)
                            , Convert.ToString(dgvDepositos.CurrentRow.Cells[2].Value), Convert.ToString(dgvDepositos.CurrentRow.Cells[3].Value)
                            , Convert.ToString(dgvDepositos.CurrentRow.Cells[4].Value), Convert.ToString(dgvDepositos.CurrentRow.Cells[5].Value)
                            , Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[6].Value), Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[7].Value)
                            , Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[8].Value), Convert.ToString(dgvDepositos.CurrentRow.Cells[9].Value)
                            , Convert.ToDateTime(dgvDepositos.CurrentRow.Cells[10].Value), Convert.ToInt32(dgvDepositos.CurrentRow.Cells[11].Value)
                            , Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[12].Value),VariablesMetodosEstaticos.varUsuario,
                            VariablesMetodosEstaticos.host_user + " / " + VariablesMetodosEstaticos.ip_user, idCobradorDGAI) == 1)
                        {
                            MessageBox.Show("Eliminado correctamente.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                            cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()), idCobradorDGAI,idCajeroIngresoVouchers);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    caja.frmComparaVouchersPagoEfectivo win = new caja.frmComparaVouchersPagoEfectivo();
        //    win.desde = dtpDesde.Value;
        //    win.hasta = dtpHasta.Value;
        //    win.idCajero = idCajeroIngresoVouchers;
        //    win.modPago = 11;
        //    win.ShowDialog();
        //}

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvDepositos.Rows.Count <= 0)
            {
                MessageBox.Show("No hay datos para la asignacion de vouchers.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            caja.frmAsignarVouchers win = new caja.frmAsignarVouchers();
            win.FechaCaja =  Convert.ToDateTime(dgvDepositos.CurrentRow.Cells[10].Value);
            win.idCajero = idCajeroIngresoVouchers;
            win.IdIngEfecDepo = Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value);
            win.importe = Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[8].Value);
            win.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        private void marcarGrilla()
        {
            if (dgvDepositos.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvDepositos.Rows)
                {
                    if (row.Cells["asignado"].Value.ToString() == "0")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        //row.DefaultCellStyle.BackColor = Color.Red;
                        //row.DefaultCellStyle.ForeColor = Color.White;

                    }
                    else if (row.Cells["asignado"].Value.ToString() == "1")
                    {
                        row.DefaultCellStyle.BackColor = Color.SkyBlue;
                    }
                    else if (row.Cells["asignado"].Value.ToString() == "2")
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkSalmon;
                    }
                }
            }
        }

        private void dgvDepositos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
        }
    }
}
