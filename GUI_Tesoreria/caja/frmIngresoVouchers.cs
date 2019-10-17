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
            dtResu = cn.TraerDataset("usp_obtiene_ingreso_por_tipo_pago_programa", cboPrograma.SelectedValue
                ,dtpFechaCobro.Value.ToString("yyyyMMdd"),11).Tables[0];
            //En la base de datos aparece en vez de 11 pongo 3 -> Depositos

            if (dtResu.Rows[0][0].ToString() != "0")
            {
                txtCantidadDocumentos.Text = dtResu.Rows[0][0].ToString();
                txtImporteEfectivo.Text = Convert.ToDecimal(dtResu.Rows[0][1]).ToString("##,##0.00");
                txtImportePago.Text = Convert.ToDecimal(dtResu.Rows[0][1]).ToString("##,##0.00");
                HabilitaControlBusqueda(false);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay ingresos para la fecha seleccionada", VariablesMetodosEstaticos.encabezado
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void HabilitaControlBusqueda(bool activa)
        {
            dtpFechaCobro.Enabled = activa;
            txtCantidadDocumentos.Enabled = activa;
            txtImporteEfectivo.Enabled = activa;
            if (VariablesMetodosEstaticos.intPerfilID != 5)
            {
                cboPrograma.Enabled = false;
            }
            else
            {
                cboPrograma.Enabled = true;
            }
            btnVerIngresos.Enabled = activa;
        }

        private void frmIngresoVouchers_Load(object sender, EventArgs e)
        {   
            cargarModalidadPago();
            cboModalidadPago.SelectedValue = 3;
            cargarConcepto();
            cargarProgramas();
            cargarEntidadFinanciera();
            cargarCuentaBancaria();
            cargarDepositos(dtpFechaDepoFiltroDesde.Value.ToString("yyyyMMdd"), dtpFechaDepoFiltroHasta.Value.ToString("yyyyMMdd"), 
            idCajeroIngresoVouchers);
            habilitaBotones(habilita);
            SeleccionaPrograma();
        }
        private void SeleccionaPrograma()
        {
            cboPrograma.SelectedValue = VariablesMetodosEstaticos.id_programa;

            if (VariablesMetodosEstaticos.intPerfilID!=5 && VariablesMetodosEstaticos.intPerfilID!=8)
            {
                cboPrograma.Enabled = false;
            }
            else
            {
                cboPrograma.Enabled = true;
            }
        }

        private void cargarProgramas()
        {
            cboPrograma.DataSource = cn.TraerDataset("usp_ListaProgramas").Tables[0];
            cboPrograma.ValueMember = "intProId";
            cboPrograma.DisplayMember = "varProDescripcion";
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
                dt = cn.TraerDataset("usp_select_modalidad_pago_VOUCHERS").Tables[0];
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

        private void txtImportePago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalCambio.Text = (Convert.ToDecimal(txtImportePago.Text) * Convert.ToDecimal(txtTipoCambio.Text)).ToString("###,###,##0.00");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cboConcepto.SelectedValue)==4 && Convert.ToInt16(cboPrograma.SelectedValue)!=1)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Los INTERESES solo pueden ser registrados en ALTA DIRECCION.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!Validar())
            {
                return;
            }
            if (verificaDuplicidad())                                                                                                                                         
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error de duplicidad. El voucher/Cheque ya fue registrado. Verifique.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            //if (verificaModalidadPago())
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Ya se llego al limite de depositos - cheque por ingreso de efectivo - cheque, verifique.", VariablesMetodosEstaticos.encabezado,
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            //    return;
            //}
            try
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea continuar con el registro del voucher?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {

                    if (cn.EjecutarSP("usp_ingresar_depositos_efectivo", Convert.ToInt32(cboModalidadPago.SelectedValue)
                        , Convert.ToInt32(cboConcepto.SelectedValue), Convert.ToDateTime(dtpFechaDeposito.Value.ToShortDateString())
                        , Convert.ToInt32(cboEntidadFinanciera.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue)
                        , lblTipoMoneda.Text, Convert.ToDecimal(txtImportePago.Text), Convert.ToDecimal(txtTipoCambio.Text)
                        , Convert.ToDecimal(txtTotalCambio.Text), txtNumDocumento.Text.Trim(), txtObservacionesPago.Text
                        , Convert.ToDateTime(dtpFechaCobro.Value.ToShortDateString()), Convert.ToInt32(txtCantidadDocumentos.Text == string.Empty ? "0": txtCantidadDocumentos.Text)
                        , Convert.ToDecimal(txtImporteEfectivo.Text), VariablesMetodosEstaticos.idcajausuario,
                        VariablesMetodosEstaticos.varNombreUser,cboPrograma.SelectedValue) > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        Limpiar();
                        cargarDepositos(dtpFechaDepoFiltroDesde.Value.ToString("yyyyMMdd"), dtpFechaDepoFiltroHasta.Value.ToString("yyyyMMdd"), 
                            idCajeroIngresoVouchers);
                        btnVerIngresos_Click(sender, e);
                        SumaTotalDeposito();
                    }
                }
                if (Convert.ToInt32(cboPrograma.SelectedValue) != 7)
                {
                    btnBuscar_Click(sender, e);
                }
            }
            catch (Exception)
            {
            }
        }
        private bool verificaModalidadPago()
        {
            //DataTable dtResu = new DataTable();
            //dtResu = cn.TraerDataset("usp_verificaModalidadPago",dtpFechaCobro.Value.ToString("yyyyMMdd"),
            //    cboPrograma.SelectedValue,cboModalidadPago.SelectedValue).Tables[0];
            dtResu = new DataTable();
            dtResu = cn.TraerDataset("usp_obtiene_ingreso_por_tipo_pago_programa", cboPrograma.SelectedValue
                , dtpFechaCobro.Value.ToString("yyyyMMdd"), 11).Tables[0];

            if (Convert.ToDecimal(dtResu.Rows[0][1].ToString()==String.Empty? "0.00": dtResu.Rows[0][1].ToString()) <= 0)
            {
                return true;
            }
            else
            {
                return false;
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
            resuNum = decimal.TryParse(s,out i);

            if (!resuNum)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe de pago válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtImportePago.Focus();
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtTotalCambio.Text) == 0.00M)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe mayor a 0.00", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtTotalCambio.Focus();
                    return false;
                }
            }

            s = txtTotalCambio.Text;
            resuNum = decimal.TryParse(s, out i);

            if (!resuNum)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe de pago válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (Convert.ToDecimal(txtTotalCambio.Text) == 0.00M)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe mayor a 0.00", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtTotalCambio.Focus();
                    return false;
                }
            }

            if (txtNumDocumento.Text.Trim()==string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese número de voucher", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtNumDocumento.Focus();
                return false;
            }
            if (txtCantidadDocumentos.Text.Trim() == string.Empty && Convert.ToInt32(cboPrograma.SelectedValue)!=7 && Convert.ToInt16(cboConcepto.SelectedValue)!=4)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se ha seleccionado la fecha de ingreso a la que se va a relacionar el voucher.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                dtpFechaCobro.Focus();
                return false;
            }
            if (txtImporteEfectivo.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se ha seleccionado la fecha de ingreso a la que se va a relacionar el voucher.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                dtpFechaCobro.Focus();
                return false;
            }
            if (lblTipoMoneda.Text!="S/.")
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

        bool verificaDuplicidad()
        {
            DataTable dtTotalRepetido = new DataTable();
            dtTotalRepetido = cn.TraerDataset("usp_verifica_duplicidad_voucher",
                dtpFechaDeposito.Value.ToString("yyyyMMdd")
                , txtNumDocumento.Text.Trim().ToUpper(), cboEntidadFinanciera.SelectedValue).Tables[0];

            return (dtTotalRepetido.Rows.Count > 0);
        }

        void cargarDepositos(string fechaFiltroDesde, string fechaFiltroHasta, int idCajeroIngresoVouchers_)
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
            cargarDepositos(dtpFechaDepoFiltroDesde.Value.ToString("yyyyMMdd"),dtpFechaDepoFiltroHasta.Value.ToString("yyyyMMdd"), Convert.ToInt32(cboPrograma.SelectedValue));
            AlternarGrillaRow(dgvDepositos);
            SumaTotalDeposito();
        }

        private void SumaTotalDeposito()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow item in dgvDepositos.Rows)
            {
                total = total + Convert.ToDecimal(item.Cells[8].Value);
            }
            txtTotalVoucher.Text = total.ToString("###,###,##0.00");
        }

        private void AlternarGrillaRow(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        void Limpiar()
        {
            cboModalidadPago.SelectedValue = 3;
            cboConcepto.SelectedIndex = 1;
            dtpFechaDeposito.Value = DateTime.Now;
            cboEntidadFinanciera.SelectedIndex = 0;
            cboCuenta.SelectedIndex = 0;
            txtImportePago.Text = "0.00";
            txtTipoCambio.Text = "1.000";
            txtTotalCambio.Text = "0.00";
            txtNumDocumento.Clear();
            txtObservacionesPago.Clear();
            //dtpFechaCobro.Value = DateTime.Now;
            txtCantidadDocumentos.Clear();
            txtImporteEfectivo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepositos.RowCount > 0)
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de eliminar el deposito seleccionado.?", VariablesMetodosEstaticos.encabezado,
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
                            DevComponents.DotNetBar.MessageBoxEx.Show("Eliminado correctamente.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                            cargarDepositos(dtpFechaDepoFiltroDesde.Value.ToString("yyyyMMdd"), 
                                dtpFechaDepoFiltroHasta.Value.ToString("yyyyMMdd"), idCajeroIngresoVouchers);
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("No se pudo eliminar, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmComparaVouchersPagoEfectivo win = new frmComparaVouchersPagoEfectivo();
            win.desde = dtpDesde.Value.ToString("yyyyMMdd");
            win.hasta = dtpHasta.Value.ToString("yyyyMMdd");
            win.idPrograma = Convert.ToInt32(cboPrograma.SelectedValue);
            win.modPago = 11;
            win.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvDepositos.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para la asignacion de vouchers.", VariablesMetodosEstaticos.encabezado,
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

                //foreach (DataGridViewRow row in dgvDepositos.Rows)
                //{
                //    if (row.Cells["asignado"].Value.ToString() == "0")
                //    {
                //        row.DefaultCellStyle.BackColor = Color.Tomato;
                //        row.DefaultCellStyle.ForeColor = Color.White;

                //    }
                //    else if (row.Cells["asignado"].Value.ToString() == "1")
                //    {
                //        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                //    }
                //    else if (row.Cells["asignado"].Value.ToString() == "2")
                //    {
                //        row.DefaultCellStyle.BackColor = Color.NavajoWhite;
                //    }
                //}
            }
        }

        private void dgvDepositos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
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
                txtTotalCambio.Text = "0.00";
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HabilitaControlBusqueda(true);
            Limpiar();
            dtpFechaCobro.Value = DateTime.Now;
        }

        private void cboPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(cboPrograma.SelectedValue) == 7)
                {
                    button2.Enabled = false;
                    btnVerIngresos.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    btnVerIngresos.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
            
            
        }
    }
}
