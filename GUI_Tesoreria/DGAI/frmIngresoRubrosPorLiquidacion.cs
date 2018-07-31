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
    public partial class frmIngresoRubrosPorLiquidacion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public decimal TotalLiquidacion { get; set; }
        public int NroLiquidacion { get; set; }
        public int NroReciboLiquidacion { get; set; }
        public decimal saldoLiquidacion { get; set; }
        private DataTable cabeceraRecibo;
        private DataTable detalleRecibo;
        private DataSet dtsRubros;
        CNegocio cn = new CNegocio();

        public frmIngresoRubrosPorLiquidacion()
        {
            InitializeComponent();
        }

        private void cargarFechaActual()
        {
            try
            {
                txtFechaC.Text = cn.EjecutarSqlDTS("SELECT CONVERT(VARCHAR(10),CONVERT(date, SYSDATETIME(),106),103)").Tables[0].Rows[0][0].ToString();
                txtFechaC.Text = txtFechaC.Text;
            }
            catch (Exception)
            {

            }
        }
        private void cargarUsuario()
        {
            txtUsuarioC.Text = VariablesMetodosEstaticos.varUsuario;
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

        private void BtnSalirC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoC_Click(object sender, EventArgs e)
        {
            limpia();
            varGlobales.habilitarCampos(this, true);
            BtnNuevoC.Enabled = false;
            BtnCancelarC.Enabled = true;
            BtnGrabarC.Enabled = true;
            TxtNombreC.Focus();
            txtNumeroRecibo.Text = Convert.ToInt32(cn.TraerDataset("usp_obtieneNumeroIngresoDGAI").Tables[0].Rows[0][0]).ToString("0000000");
        }

        private void limpia()
        {
            varGlobales.resetearCampos(this);
            habilitaCampoMontos(true);
            cargarFechaActual();
            txtImportePago.Text = "0.00";
            txtTipoCambio.Text = "1.000";
            txtTotalCambioDolar.Text = "0.00";
            txtGlosa.Clear();
            //dtpFechaPago.Value = DateTime.Now;

            if (dgvDGAI.RowCount > 0)
            {
                limpiarGrillaRubro();
            }
            acumulado();
        }

        private void habilitaCampoMontos(Boolean flag)
        {
            txtTotalDocumentoC.Enabled = flag;
            txtSaldoC.Enabled = flag;
            txtTotalLiquidacionC.Enabled = flag;
        }
        private void limpiarGrillaCta()
        {
            if (dgvDGAI.RowCount > 0)
            {
                while (dgvDGAI.RowCount > 0)
                {
                    dgvDGAI.Rows.Remove(dgvDGAI.CurrentRow);
                }
            }
        }

        private void limpiarGrillaRubro()
        {
            if (dgvDGAI.RowCount > 0)
            {
                while (dgvDGAI.RowCount > 0)
                {
                    dgvDGAI.Rows.Remove(dgvDGAI.CurrentRow);
                }
            }
        }

        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            varGlobales.habilitarCampos(this, false);
            limpia();
            varGlobales.habilitarCampos(this, false);
            BtnNuevoC.Enabled = true;
            BtnCancelarC.Enabled = false;
            BtnGrabarC.Enabled = false;
        }

        private void cboModalidadPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dsetMonedaModPago = new DataSet();
                int idModPago = Convert.ToInt32(cboModalidadPago.SelectedValue);

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
            }
            catch (Exception)
            {
            }
        }

        private void frmIngresoRubrosPorLiquidacion_Load(object sender, EventArgs e)
        {
            varGlobales.habilitarCampos(this, false);
            cargarModalidadPago();
            txtSaldoC.Text = saldoLiquidacion.ToString("##,##0.00");
            txtTotalLiquidacionC.Text = TotalLiquidacion.ToString("##,##0.00");
            //txtNumeroRecibo.Text = NroReciboLiquidacion.ToString("0000000");
            lblNro.Text = NroLiquidacion.ToString("0000000");
            txtUsuarioC.Text = VariablesMetodosEstaticos.varUsuario;
            txtFechaC.Text = cn.EjecutarSqlDTS("SELECT CONVERT(VARCHAR(10),CONVERT(date, SYSDATETIME(),106),103)").Tables[0].Rows[0][0].ToString();
            BtnCancelarC_Click(sender, e);
        }

        private void BtnGrabarC_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                return;
            }
            if ((MessageBox.Show("¿Esta seguro de registrar el ingreso de DGAI con numero de liquidacion "+" " + lblNro.Text + " y " + "Nº de registro "+ txtNumeroRecibo.Text, VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                ArmarTablasCabeceraDetalle();

                DataSet resultado = new DataSet();
                bool estado = true;

                resultado = cn.IngresaRecibo("usp_generea_ingresos_dgai", estado, cabeceraRecibo, detalleRecibo);

                int idReciboCabecera = 0;

                idReciboCabecera = Convert.ToInt32(resultado.Tables[0].Rows[0][0]);

                if (idReciboCabecera == 0)
                {
                    MessageBox.Show("Ocurrio un error al guardar la información, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    MessageBox.Show("Recibo Ingresado correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    txtNumeroRecibo.Text = Convert.ToInt32(cn.TraerDataset("usp_obtieneNumeroIngresoDGAI").Tables[0].Rows[0][0]).ToString("0000000");
                    calcularSaldo();
                    BtnCancelarC_Click(sender,e);
                    //varGlobales.habilitarCampos(this, false);
                    //BtnNuevoC.Enabled = true;
                    //BtnGrabarC.Enabled = false;
                    //BtnCancelarC.Enabled = false;
                }               
            }
          
        }

        private void calcularSaldo()
        {
            decimal acu=0.00m;

            acu = Convert.ToDecimal(cn.TraerDataset("usp_obtiene_total_por_liquidacion_dgai", Convert.ToInt32(lblNro.Text)).Tables[0].Rows[0][0]);

            txtSaldoC.Text = (Convert.ToDecimal(txtTotalLiquidacionC.Text) - acu).ToString("##,##0.00");
        }

        private bool validacion()
        {
            if (cboModalidadPago.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione modalidad de pago.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboModalidadPago.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtImportePago.Text) <= 0.00M)
            {
                MessageBox.Show("Ingrese un valor mayor a 0.00 en importe cambio.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImportePago.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtTotalCambioDolar.Text) <= 0.00M)
            {
                MessageBox.Show("Seleccione modalidad de pago.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalCambioDolar.Focus();
                return true;
            }
            if (dgvDGAI.Rows.Count <= 0)
            {
                MessageBox.Show("Debe ingresar al menos un item en el detalle de ingreso.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtSaldoC.Text) == 0.00m)
            {
                MessageBox.Show("Ya no queda saldo disponible para generar recibo.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldoC.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtTotalDocumentoC.Text) != Convert.ToDecimal(txtTotalCambioDolar.Text))
            {
                MessageBox.Show("El monto total del documento debe ser igual al monto total cambio.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImportePago.Focus();
                return true;
            }

            return false;
        }

        private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtTotalCambioDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }
        private void ArmarTablasCabeceraDetalle()
        {
            cabeceraRecibo = new DataTable();
            detalleRecibo = new DataTable();

            cabeceraRecibo.Clear();
            detalleRecibo.Clear();

            cabeceraRecibo.Columns.Add("numero_liquidacion", typeof(int));
            cabeceraRecibo.Columns.Add("nro_recibo_liquidacion", typeof(int));
            cabeceraRecibo.Columns.Add("razon", typeof(string));
            cabeceraRecibo.Columns.Add("fechaIngreso", typeof(DateTime));
            cabeceraRecibo.Columns.Add("usuarioIngreso", typeof(string));
            cabeceraRecibo.Columns.Add("cod_mod_pago", typeof(int));
            //cabeceraRecibo.Columns.Add("id_cuenta_contable", typeof(int));
            //cabeceraRecibo.Columns.Add("descripcionCuenta", typeof(string));
            cabeceraRecibo.Columns.Add("moneda", typeof(string));//
            cabeceraRecibo.Columns.Add("importeIngreso", typeof(decimal));
            cabeceraRecibo.Columns.Add("importeCambioIngreso", typeof(decimal));
            cabeceraRecibo.Columns.Add("glosa", typeof(string));
            cabeceraRecibo.Columns.Add("totalDocumento", typeof(decimal));
            cabeceraRecibo.Columns.Add("usuarioRegistro", typeof(string));
            cabeceraRecibo.Columns.Add("pcRegistro", typeof(string));

            //agrega columnas tabla detalle
            detalleRecibo.Columns.Add("intRuId", typeof(int));
            detalleRecibo.Columns.Add("charuCodigo", typeof(string));
            detalleRecibo.Columns.Add("descripcion", typeof(string));
            //detalleRecibo.Columns.Add("id_cuenta_contable", typeof(int));
            //detalleRecibo.Columns.Add("descripcionCuenta", typeof(string));
            detalleRecibo.Columns.Add("precioUnitario", typeof(decimal));
            detalleRecibo.Columns.Add("cantidad", typeof(int));
            detalleRecibo.Columns.Add("importe", typeof(decimal));
            detalleRecibo.Columns.Add("tipoCambio", typeof(decimal));

            DataRow _filaCabecera = cabeceraRecibo.NewRow();

            _filaCabecera["numero_liquidacion"] = Convert.ToInt32(lblNro.Text);
            _filaCabecera["nro_recibo_liquidacion"] = Convert.ToInt32(txtNumeroRecibo.Text);
            _filaCabecera["razon"] = TxtNombreC.Text;
            _filaCabecera["fechaIngreso"] = Convert.ToDateTime(txtFechaC.Text);
            _filaCabecera["usuarioIngreso"] = txtUsuarioC.Text;
            _filaCabecera["cod_mod_pago"] = cboModalidadPago.SelectedValue;
            //_filaCabecera["id_cuenta_contable"] = txtUsuarioC.Text;
            _filaCabecera["moneda"] = lblTipoMoneda.Text;
            _filaCabecera["importeIngreso"] = txtImportePago.Text;
            _filaCabecera["importeCambioIngreso"] = txtTotalCambioDolar.Text;
            _filaCabecera["glosa"] = txtGlosa.Text;
            _filaCabecera["totalDocumento"] = Convert.ToDecimal(txtTotalDocumentoC.Text);
            _filaCabecera["usuarioRegistro"] = VariablesMetodosEstaticos.varUsuario;
            _filaCabecera["pcRegistro"] = VariablesMetodosEstaticos.ip_user + " / " + VariablesMetodosEstaticos.host_user;
            _filaCabecera["tipoCambio"] = Convert.ToDecimal(txtTipoCambio.Text);

            cabeceraRecibo.Rows.Add(_filaCabecera);

            if (dgvDGAI.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDGAI.Rows)
                {
                    DataRow _filaDetalle = detalleRecibo.NewRow();

                    _filaDetalle["intRuId"] = Convert.ToInt32(row.Cells[0].Value);
                    _filaDetalle["descripcion"] = row.Cells[1].Value.ToString();
                    _filaDetalle["precioUnitario"] = Convert.ToDecimal(row.Cells[2].Value);
                    _filaDetalle["cantidad"] = Convert.ToDecimal(row.Cells[3].Value);
                    _filaDetalle["importe"] = Convert.ToDecimal(row.Cells[4].Value);

                    detalleRecibo.Rows.Add(_filaDetalle);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtsRubros = new DataSet();
            frmAgregarRubrosDGAI winAddRub = new frmAgregarRubrosDGAI();
            dtsRubros = winAddRub.traerFormulario();
            llamaDetalle(dtsRubros);
        }
        private void llamaDetalle(DataSet dtsRubros)
        {
            if (dtsRubros.Tables[0].Rows.Count > 0)
            {
                TraerDatosDetalle(Convert.ToInt32(dtsRubros.Tables[0].Rows[0][0]), dtsRubros.Tables[0].Rows[0][2].ToString(), Convert.ToDecimal(dtsRubros.Tables[0].Rows[0][3]),
                              Convert.ToInt32(dtsRubros.Tables[0].Rows[0][4]));
            }
        }
        private void TraerDatosDetalle(int intRuId, string descripcion, decimal precioUnit, int cantidad)
        {

            foreach (DataGridViewRow row in dgvDGAI.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == intRuId)
                {
                    MessageBox.Show("El item que desea ingresar ya ha sido ingresado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;// break;
                }
            }

            dgvDGAI.Rows.Add();

            int fila = dgvDGAI.RowCount - 1;
            decimal subTotal = 0.00m;

            subTotal = decimal.Round((precioUnit * cantidad), 2);

            dgvDGAI.Rows[fila].Cells[0].Value = intRuId;

            dgvDGAI.Rows[fila].Cells[1].Value = descripcion;

            dgvDGAI.Rows[fila].Cells[2].Value = precioUnit;
            dgvDGAI.Rows[fila].Cells[3].Value = cantidad;
            dgvDGAI.Rows[fila].Cells[4].Value = subTotal;
            acumulado();
        }

        private void acumulado()
        {
            try
            {
                decimal tot = 0.00m;

                for (int i = 0; i < dgvDGAI.RowCount; i++)
                {
                    tot = tot + Convert.ToDecimal(dgvDGAI.Rows[i].Cells[4].Value);
                }

                txtTotalDocumentoC.Text = tot.ToString("##,##0.00");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDGAI.RowCount > 0)
                {

                    dgvDGAI.Rows.RemoveAt(dgvDGAI.CurrentRow.Index);
                    acumulado();
                }
                else
                {
                    MessageBox.Show("No existe datos para eliminar", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dgvDGAI.Refresh();
            }
            catch (Exception)
            {
            }
        }
    }
}
