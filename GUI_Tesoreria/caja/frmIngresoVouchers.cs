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
    public partial class frmIngresoVouchers : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        DataTable dtResu;
        private static frmIngresoVouchers frmInstance = null;
        public int idCajeroIngresoVouchers { get; set; }
        public int habilita { get; set; }

        public frmIngresoVouchers()
        {
            InitializeComponent();
        }

        public static frmIngresoVouchers Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoVouchers();
            }
            frmInstance.BringToFront();
            return frmInstance;
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
            cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()), idCajeroIngresoVouchers);
            habilitaBotones(habilita);
        }

        void habilitaBotones(int hab)
        {
            if (hab == 0)
            {
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnAsignar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
                btnAsignar.Enabled = true;
            }
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

                    if (cn.EjecutarSP("usp_ingresar_depositos_efectivo", Convert.ToInt32(cboModalidadPago.SelectedValue)
                        , Convert.ToInt32(cboConcepto.SelectedValue), Convert.ToDateTime(dtpFechaDeposito.Value.ToShortDateString())
                        , Convert.ToInt32(cboEntidadFinanciera.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue)
                        , lblTipoMoneda.Text, Convert.ToDecimal(txtImportePago.Text), Convert.ToDecimal(txtTipoCambio.Text)
                        , Convert.ToDecimal(txtTotalCambio.Text), txtNumDocumento.Text.Trim(), txtObservacionesPago.Text
                        , Convert.ToDateTime(dtpFechaCobro.Value.ToShortDateString()), Convert.ToInt32(txtCantidadDocumentos.Text)
                        , Convert.ToDecimal(txtImporteEfectivo.Text), VariablesMetodosEstaticos.idcajausuario,
                        VariablesMetodosEstaticos.varNombreUser) > 0)
                    {
                        MessageBox.Show("Ingresado correctamente.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        Limpiar();
                        cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()), idCajeroIngresoVouchers);
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
                MessageBox.Show("Seleccione Modalidad de pago");
                cboModalidadPago.Focus();
                return false;
            }
            if (cboConcepto.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Concepto");
                cboConcepto.Focus();
                return false;
            }
            if (cboEntidadFinanciera.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione Entidad financiera");
                cboEntidadFinanciera.Focus();
                return false;
            }
            if (cboCuenta.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione cuenta");
                cboCuenta.Focus();
                return false;
            }
            decimal i = 0M;
            bool resuNum;
            string s = "";
            s = txtImportePago.Text;
            resuNum = decimal.TryParse(s,out i);

            if (!resuNum)
            {
                MessageBox.Show("Ingrese un importe de pago válido");
                txtImportePago.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtImportePago.Text) == 0.00M)
                {
                    MessageBox.Show("Ingrese un importe mayor a 0.00");
                    txtImportePago.Focus();
                    return false;
                }
            }

            s = txtTotalCambio.Text;
            resuNum = decimal.TryParse(s, out i);

            if (!resuNum)
            {
                MessageBox.Show("Ingrese un importe de pago válido");
                txtTotalCambio.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtTotalCambio.Text) == 0.00M)
                {
                    MessageBox.Show("Ingrese un importe mayor a 0.00");
                    txtTotalCambio.Focus();
                    return false;
                }
            }

            if (txtNumDocumento.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Ingrese número de voucher");
                txtNumDocumento.Focus();
                return false;
            }
            if (txtCantidadDocumentos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado la fecha de ingreso a la que se va a relacionar el voucher.");
                dtpFechaCobro.Focus();
                return false;
            }
            if (txtImporteEfectivo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado la fecha de ingreso a la que se va a relacionar el voucher.");
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

        void cargarDepositos(DateTime fechaFiltroDesde, DateTime fechaFiltroHasta, int idCajeroIngresoVouchers_)
        {
            try
            {
                dgvDepositos.DataSource = cn.TraerDataset("usp_selectAllingresosEfectivoDeposito", fechaFiltroDesde,fechaFiltroHasta, idCajeroIngresoVouchers_).Tables[0];
            }
            catch (Exception)
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()),Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()), idCajeroIngresoVouchers);
        }

        void Limpiar()
        {
            cboModalidadPago.SelectedIndex = 0;
            cboConcepto.SelectedIndex = 0;
            dtpFechaDeposito.Value = DateTime.Now;
            cboEntidadFinanciera.SelectedIndex = 0;
            cboCuenta.SelectedIndex = 0;
            txtImportePago.Text = "0.00";
            txtTipoCambio.Text = "1.000";
            txtTotalCambio.Text = "0.00";
            txtNumDocumento.Clear();
            txtObservacionesPago.Clear();
            dtpFechaCobro.Value = DateTime.Now;
            txtCantidadDocumentos.Clear();
            txtImporteEfectivo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepositos.RowCount > 0)
                {
                    if ((MessageBox.Show("¿Esta seguro de eliminar el deposito seleccionado.?", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        if (cn.EjecutarTransaccionDoble("usp_eliminar_depositos_efectivo", "usp_eliminar_ingreso_voucher_x_caja"
                            , Convert.ToInt32(dgvDepositos.CurrentRow.Cells[0].Value), Convert.ToDateTime(dgvDepositos.CurrentRow.Cells[1].Value)
                            , Convert.ToString(dgvDepositos.CurrentRow.Cells[2].Value), Convert.ToString(dgvDepositos.CurrentRow.Cells[3].Value)
                            , Convert.ToString(dgvDepositos.CurrentRow.Cells[4].Value), Convert.ToString(dgvDepositos.CurrentRow.Cells[5].Value)
                            , Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[6].Value), Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[7].Value)
                            , Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[8].Value), Convert.ToString(dgvDepositos.CurrentRow.Cells[9].Value)
                            , Convert.ToDateTime(dgvDepositos.CurrentRow.Cells[10].Value), Convert.ToInt32(dgvDepositos.CurrentRow.Cells[11].Value)
                            , Convert.ToDecimal(dgvDepositos.CurrentRow.Cells[12].Value),VariablesMetodosEstaticos.varUsuario,
                            VariablesMetodosEstaticos.host_user+ " / " + VariablesMetodosEstaticos.ip_user) == 1)
                        {
                            MessageBox.Show("Eliminado correctamente.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                            cargarDepositos(Convert.ToDateTime(dtpFechaDepoFiltroDesde.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaDepoFiltroHasta.Value.ToShortDateString()), idCajeroIngresoVouchers);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmComparaVouchersPagoEfectivo win = new frmComparaVouchersPagoEfectivo();
            win.desde = dtpDesde.Value;
            win.hasta = dtpHasta.Value;
            win.idCajero = idCajeroIngresoVouchers;
            win.modPago = 11;
            win.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvDepositos.Rows.Count <= 0)
            {
                MessageBox.Show("No hay datos para la asignacion de vouchers.", VariablesMetodosEstaticos.encabezado,
                                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            frmAsignarVouchers win = new frmAsignarVouchers();
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
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                        row.DefaultCellStyle.ForeColor = Color.White;

                    }
                    else if (row.Cells["asignado"].Value.ToString() == "1")
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                    else if (row.Cells["asignado"].Value.ToString() == "2")
                    {
                        row.DefaultCellStyle.BackColor = Color.NavajoWhite;
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
