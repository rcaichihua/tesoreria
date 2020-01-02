using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Security.Principal;
using System.Data.OleDb;

namespace GUI_Tesoreria.caja
{
    public partial class frmPagoDiversos : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        WindowsIdentity MyID = WindowsIdentity.GetCurrent();
        varGlobales var = new varGlobales();
        private static frmPagoDiversos frmInstance = null;
        private CNegocio cn = new CNegocio();
        DataTable cabeceraRecibo;
        DataTable detalleRecibo;
        DataTable modalidadesPago;
        public bool GrabaRecibo = false;
        public string nombreClienteOrbegoso = "";
        public string direccionClienteOrbegoso = "";
        private string ReciboCementerio;
        public bool flagFonavi = false;

        public frmPagoDiversos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnAdd, "Agregar Item.");
            this.ttMensaje.SetToolTip(this.btnDelete, "Eliminar Item.");
            this.ttMensaje.SetToolTip(this.btnAgregarPago, "Agregar modalidad de pago adicional.");
            this.ttMensaje.SetToolTip(this.BtnBuscarCliente, "Buscar albergado.");
        }
        public static frmPagoDiversos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmPagoDiversos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagoDiversos_Load(object sender, EventArgs e)
        {
            varGlobales.habilitarCampos(this, false);
            cargarDetraccion();
            cargarDireccion();
            cargarPabellon();
            verificaSucursal();
            cargarComprobante();
            cargarFechaActual();
            cargarUsuario();
            obtenerCementerio();
            cargarModalidadPago();
            cargarConcepto();
            cargarEntidadFinanciera();
            cargarCuentaBancaria();
            asignaNumeroADocumentos();
            NombreCaja();
            obtenerCuartel();
            BtnCancelarC.Enabled = false;
            BtnGrabarC.Enabled = false;
            //canevaro
            HabilitarGroupBox();
            cboConcepto.SelectedValue = 1;
            crearTablaTemporal();
            //if (VariablesMetodosEstaticos.id_programa == 4)
            //{
            //    dtpFechaCancelacion.Location = new Point(122, 57);
            //    label18.Location = new Point(109, 13);

            //    dtpFechaCancelacion.Visible = true;
            //    label18.Visible = true;

            //    //dtpFechaCancelacion.BringToFront();
            //    //label18.BringToFront();

            //    //GBGlosa.SendToBack();
            //    this.Refresh();
            //}
            
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

        private void cargarDetraccion()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODIGO,'COD: '+CODIGO+' TASA DE '+CONVERT(VARCHAR(6),PORCENTAJE)+ '% - '+DESCRIPCION as DESCRIPCION from SUNATFE.dbo.SUNAT_PORCENTAJE_DETRACCION").Tables[0];

                DataRow row = dt.NewRow();
                row["CODIGO"] = "000";
                row["DESCRIPCION"] = "SELECCIONAR";
                dt.Rows.InsertAt(row, 0);

                cboTasaDetraccion.DataSource = dt;
                cboTasaDetraccion.DisplayMember = "DESCRIPCION";
                cboTasaDetraccion.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void obtenerCementerio()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "C").Tables[0];
                cboCementerio.DataSource = dt;
                cboCementerio.DisplayMember = "varCeNombre";
                cboCementerio.ValueMember = "intCeId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        void HabilitarGroupBox()
        {
            //canevaro
            if (VariablesMetodosEstaticos.id_programa == 2)
            {
                DGVRubros.Visible = false;
                dgvCtaCte.Visible = true;
                chkCta.Visible = true;
                gbCanevaro.Visible = true;
                GBCementerio.Visible = false;
            }
            //central
            else if (VariablesMetodosEstaticos.id_programa == 1)
            {
                btnFonavi.Visible = true;
                chkFecha.Visible = false;
                gbCanevaro.Visible = false;
                GBCementerio.Visible = false;
                gbCanevaro.Enabled = false;
                gbDetraccion.Visible = true;
            }
            //cementerio
            else if (VariablesMetodosEstaticos.id_programa == 4)
            {
                gbCanevaro.Visible = false;
                GBCementerio.Visible = true;
                cboCementerio.Visible = true;
                label14.Visible = true;
            }
            //comedores
            else
            {
                DGVRubros.Visible = true;
                dgvCtaCte.Visible = false;
                chkCta.Visible = false;
                gbCanevaro.Visible = false;
                GBCementerio.Enabled = false;
            }
        }

        void inhabilitarFechaCementerio(bool e)
        {
            resetearFechasCementerio();
            dtpFechaDefuncion.Enabled = !e;
            dtpFechaInHumacion.Enabled = !e;
            dtpHoraInhumacion.Enabled = !e;
        }

        private void OcultarControlesCementerio()
        {
            lblCuartel.Visible = false;
            lblDifunto.Visible = false;
            LblDireccion.Visible = false;
            lblFechaDefuncion.Visible = false;
            lblFechaHora.Visible = false;
            //lblSerieBoleta.Visible = false;
            lblNumero.Visible = false;
            lblLetra.Visible = false;
            cboCuartel.Visible = false;
            txtNro.Visible = false;
            txtLetra.Visible = false;
            txtDifunto.Visible = false;
            dtpFechaDefuncion.Visible = false;
            dtpFechaInHumacion.Visible = false;
            dtpHoraInhumacion.Visible = false;
            lblFiltro.Visible = false;
            txtFiltro.Visible = false;
            chkFecha.Visible = false;
        }

        private void OcultarControlesCanevaro()
        {
            lblCanCentrG.Visible = false;
            lblCanDireccion.Visible = false;
            lblCanHabitacion.Visible = false;
            lblPabellon.Visible = false;
            cboDireccion.Visible = false;
            cboCentroGerontologico.Visible = false;
            txtHabitacion.Visible = false;
            cboPabellon.Visible = false;
            cboNroPabellon.Visible = false;
            lblNroPabellon.Visible = false;
        }

        private void verificaSucursal()
        {
            if (VariablesMetodosEstaticos.id_programa == 4 || VariablesMetodosEstaticos.id_programa == 2)
            {
                gbCanevaro.Enabled = true;
            }
            else
            {
                gbCanevaro.Enabled = false;
            }
        }
        private void asignaNumeroADocumentos()
        {
            try
            {
                DataTable CorrelativoRecibos = new DataTable();
                CorrelativoRecibos = cn.TraerDataset("usp_s_ultimo_doc_venta", VariablesMetodosEstaticos.mac_id).Tables[0];

                DataRow[] foundRowFactura = CorrelativoRecibos.Select("Desc_TipoDocVenta like '%Fac%'");
                if (foundRowFactura.Count() > 0)
                {
                    lblSerieFactura.Text = "FN" + foundRowFactura[0][1].ToString().Trim().Substring(1,2);
                    lblCorrelativoFactura.Text = foundRowFactura[0][2].ToString();
                }
                else
                {
                    lblSerieFactura.Text = "FN0";
                    lblCorrelativoFactura.Text = "00000000";
                }

                DataRow[] foundRowBoleta = CorrelativoRecibos.Select("Desc_TipoDocVenta like '%Bol%'");
                if (foundRowBoleta.Count() > 0)
                {
                    lblSerieBoleta.Text ="BN" + foundRowBoleta[0][1].ToString().Trim().Substring(1, 2);
                    lblCorrelativoVenta.Text = foundRowBoleta[0][2].ToString();
                }
                else
                {
                    lblSerieBoleta.Text = "BN0";
                    lblCorrelativoVenta.Text = "00000000";
                }

                DataRow[] foundRowRecibo = CorrelativoRecibos.Select("Desc_TipoDocVenta like '%Rec%'");
                if (foundRowRecibo.Count() > 0)
                {
                    lblSerieRecibo.Text = foundRowRecibo[0][1].ToString();
                    lblCorrelativoRecibo.Text = foundRowRecibo[0][2].ToString();
                }
                else
                {
                    lblSerieRecibo.Text = "000";
                    lblCorrelativoRecibo.Text = "0000000";
                }     

            }
            catch (Exception)
            {
                
            }           
        }

        private void NombreCaja()
        {
            try
            {
                lblNombreCaja.Text = cn.TraerDataset("usp_s_NombreCaja", VariablesMetodosEstaticos.idcaja).Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void cargarDireccion()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_direcciones").Tables[0];
                cboDireccion.DataSource = dt;
                cboDireccion.DisplayMember = "NombreDireccion";
                cboDireccion.ValueMember = "DireccionId";
            }
            catch (Exception)
            {

            }
        }

        private void cargarComprobante()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_TipDocumentos_por_mac", VariablesMetodosEstaticos.id_user, 1, VariablesMetodosEstaticos.mac_id).Tables[0];
                cboComprobante.DataSource = dt;
                cboComprobante.DisplayMember = "Desc_TipoDocVenta";
                cboComprobante.ValueMember = "Cod_TipoDocVenta";
            }
            catch (Exception)
            {
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cargarPabellon()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_pabellon").Tables[0];
                cboPabellon.DataSource = dt;
                cboPabellon.DisplayMember = "nombrePabellon";
                cboPabellon.ValueMember = "pabellonID";
            }
            catch (Exception)
            {

            }
        }

        private void cargarFechaActual()
        {
            try
            {
                txtFecha.Text = cn.EjecutarSqlDTS("SELECT CONVERT(VARCHAR(10),CONVERT(date, SYSDATETIME(),106),103)").Tables[0].Rows[0][0].ToString();
                txtFechaSistemaC.Text = txtFecha.Text;
            }
            catch (Exception)
            {

            }
        }
        private void cargarUsuario()
        {
            txtUsuarioC.Text = VariablesMetodosEstaticos.varUsuario;
        }
        private void obtenerCuartel()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_filtro_tb_cuartel","","N").Tables[0];
                cboCuartel.DataSource = dt;
                cboCuartel.DisplayMember = "nombreCuartel";
                cboCuartel.ValueMember = "cuartelId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de cancelar?", VariablesMetodosEstaticos.encabezado,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                limpia();
                asignaNumeroADocumentos();
                varGlobales.habilitarCampos(this, false);
                BtnNuevoC.Enabled = true;
                BtnCancelarC.Enabled = false;
                BtnGrabarC.Enabled = false;
                chkFecha.Checked = true;
                LimpiarTablaModalidad();
                //modalidadesPago = new DataTable();
            }
        }

        private void LimpiarTablaModalidad()
        {
            if (modalidadesPago.Rows.Count>0)
            {
                for (int i = modalidadesPago.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = modalidadesPago.Rows[i];
                    dr.Delete();
                }
                modalidadesPago.AcceptChanges();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //BtnGrabarC_Click(sender, e);
            limpia();
            asignaNumeroADocumentos();
            varGlobales.habilitarCampos(this, true);
            BtnNuevoC.Enabled = false;
            chkCta.Checked = true;
            BtnCancelarC.Enabled = true;
            BtnGrabarC.Enabled = true;
            TxtNombre.Focus();
            HabilitarGroupBox();
            LimpiarTablaModalidad();
            //if (VariablesMetodosEstaticos.id_programa == 4)
            //{
            //    dtpFechaCancelacion.Location = new Point(122, 57);
            //    label18.Location = new Point(109, 13);
            //    BtnSalirC.Location = new Point(109, 13);

            //    dtpFechaCancelacion.Visible = true;
            //    label18.Visible = true;
            //}
        }

        void resetearFechasCementerio()
        {
            dtpFechaDefuncion.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpFechaInHumacion.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpHoraInhumacion.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        }
        private void limpia()
        {
            varGlobales.resetearCampos(this);
            verificaSucursal();
            habilitaCampoMontos(true);
            cargarFechaActual();
            errorProvider1.Clear();
            txtImportePago.Text = "0.00";
            txtTipoCambio.Text = "1.000";
            txtTotalCambioDolar.Text = "0.00";
            txtMontoDetraccion.Text = "0.00";
            resetearFechasCementerio();
            cboTasaDetraccion.SelectedIndex = 0;
            //dtpFechaDefuncion.Value = DateTime.Now;
            //dtpFechaInHumacion.Value = DateTime.Now;
            //dtpHoraInhumacion.Value = DateTime.Now;
            dtpFechaPago.Value = DateTime.Now;

            if (DGVRubros.RowCount > 0)
            {
                limpiarGrillaRubro();
            }
            if (dgvCtaCte.RowCount > 0)
            {
                limpiarGrillaCta();
            }
            flagFonavi = false;
            acumulado();
            cboConcepto.SelectedValue = 1;
        }

        private void habilitaCampoMontos(Boolean flag)
        {
            txtValorVentaC.Enabled = flag;
            txtIGVC.Enabled = flag;
            txtPrecioVentaC.Enabled = flag;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private bool ValidarTotalesMayor()
        {
            decimal total = 0.00m;

            foreach (DataRow item in modalidadesPago.Rows)
            {
                total = total + Convert.ToDecimal(item["importe_cambio"].ToString() == "" ? "0": item["importe_cambio"].ToString());
            }

            total = total + Convert.ToDecimal(txtTotalCambioDolar.Text);

            return (total > Convert.ToDecimal(txtPrecioVentaC.Text));
        }

        private bool ValidarTotalesMenor()
        {
            decimal total = 0.00m;

            foreach (DataRow item in modalidadesPago.Rows)
            {
                total = total + Convert.ToDecimal(item["importe_cambio"].ToString() == "" ? "0" : item["importe_cambio"].ToString());
            }

            total = total + Convert.ToDecimal(txtTotalCambioDolar.Text);

            return (total < Convert.ToDecimal(txtPrecioVentaC.Text));
        }

        private void BtnGrabarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(false))
                {
                    return;
                }

                if (ValidarTotalesMayor())
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El total del documento es MENOR al total de modalidades de pago, no se puede continuar", 
                        VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                if (VariablesMetodosEstaticos.id_programa == 4)
                {
                    if (ValidarTotalesMenor())
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El total del documento es MAYOR al total de modalidades de pago, no se puede continuar",
                            VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        return;
                    }
                }

                else { errorProvider1.Clear(); }

                decimal tot = 0.00m;

                for (int i = 0; i < modalidadesPago.Rows.Count; i++)
                {
                    tot = tot + Convert.ToDecimal(modalidadesPago.Rows[i][10]);
                }

                if (tot + Convert.ToDecimal(txtTotalCambioDolar.Text) < Convert.ToDecimal(txtPrecioVentaC.Text))
                {
                    //if ((DevComponents.DotNetBar.MessageBoxEx.Show("La suma total de modalidades de pago es menor al total del documento."+
                    //    Environment.NewLine +Environment.NewLine+" ¿Esta seguro de continuar?", VariablesMetodosEstaticos.encabezado,
                    //    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No))
                    //{
                    //    return;
                    //}
                    DevComponents.DotNetBar.MessageBoxEx.Show("La suma total de modalidades de pago es menor al total del documento." +
                        Environment.NewLine + Environment.NewLine + "No se puede continuar.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ArmarTablasCabeceraDetalle();
                EfectuarPago();

                if (GrabaRecibo)
                {
                    DataSet dsNumero = new DataSet();

                    asignaNumeroADocumentos();
                    dsNumero = cn.TraerDataset("usp_obtener_ultimoNumero_documento", VariablesMetodosEstaticos.idcajausuario, cboComprobante.SelectedValue);

                    txtSerieRecibo.Text = dsNumero.Tables[0].Rows[0][0].ToString();
                    txtNumeroRecibo.Text = dsNumero.Tables[0].Rows[0][1].ToString();

                    LimpiarTablaModalidad();

                    varGlobales.habilitarCampos(this, false);
                    BtnNuevoC.Enabled = true;
                    BtnGrabarC.Enabled = false;
                    BtnCancelarC.Enabled = false;

                    GrabaRecibo = false;
                    frmMensaje msg = new frmMensaje();
                    msg.ShowDialog();
                    //modalidadesPago = new DataTable();                   
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }           
        }

        private void ArmarTablasCabeceraDetalle()
        {
            int paginacion = 1;

            cabeceraRecibo = new DataTable();
            detalleRecibo = new DataTable();

            cabeceraRecibo.Clear();
            detalleRecibo.Clear();
            cabeceraRecibo.Columns.Add("IdComprobante", typeof(int));
            cabeceraRecibo.Columns.Add("fechaComprobante", typeof(DateTime));
            cabeceraRecibo.Columns.Add("CodigoCliente", typeof(int));
            cabeceraRecibo.Columns.Add("NombreRazonSocialCliente", typeof(string));
            cabeceraRecibo.Columns.Add("dniRucCliente", typeof(string));
            cabeceraRecibo.Columns.Add("direccionCliente", typeof(string));
            cabeceraRecibo.Columns.Add("idCaja", typeof(int));
            cabeceraRecibo.Columns.Add("idcajausuario", typeof(int));//
            cabeceraRecibo.Columns.Add("idUsuario", typeof(int));
            cabeceraRecibo.Columns.Add("UsuarioIngresaRecibo", typeof(string));
            cabeceraRecibo.Columns.Add("idModalidadPago", typeof(int));
            cabeceraRecibo.Columns.Add("idConceptopago", typeof(int));
            cabeceraRecibo.Columns.Add("fechaPago", typeof(DateTime));
            cabeceraRecibo.Columns.Add("idEntidadFinancieraPago", typeof(int));
            cabeceraRecibo.Columns.Add("idCuentaPago", typeof(int));
            cabeceraRecibo.Columns.Add("importePago", typeof(decimal));
            cabeceraRecibo.Columns.Add("tipoCambioPago", typeof(decimal));
            cabeceraRecibo.Columns.Add("numeroDocumentoPago", typeof(string));
            cabeceraRecibo.Columns.Add("observacionesPago", typeof(string));
            cabeceraRecibo.Columns.Add("nombreDifuntoCementerio", typeof(string));
            cabeceraRecibo.Columns.Add("fechaDefuncionCementerio", typeof(DateTime));
            cabeceraRecibo.Columns.Add("fechaInHumacionCementerio", typeof(DateTime));
            cabeceraRecibo.Columns.Add("horaInhumacion", typeof(DateTime));
            cabeceraRecibo.Columns.Add("glosa", typeof(string));
            cabeceraRecibo.Columns.Add("valorVenta", typeof(decimal));
            cabeceraRecibo.Columns.Add("igv", typeof(decimal));
            cabeceraRecibo.Columns.Add("precioVenta", typeof(decimal));

            cabeceraRecibo.Columns.Add("macId", typeof(int));
            cabeceraRecibo.Columns.Add("sucursalId", typeof(int));
            cabeceraRecibo.Columns.Add("pc", typeof(string));
            cabeceraRecibo.Columns.Add("usuarioPc", typeof(string));
            cabeceraRecibo.Columns.Add("redPc", typeof(string));
            //cabecera Albergues
            cabeceraRecibo.Columns.Add("albergueDireccion", typeof(string));
            cabeceraRecibo.Columns.Add("alberguecentroGeren", typeof(string));
            cabeceraRecibo.Columns.Add("albergueHabitacion", typeof(string));
            cabeceraRecibo.Columns.Add("alberguePabellon", typeof(string));
            //cabecera cementerio
            cabeceraRecibo.Columns.Add("cuartel", typeof(string));
            cabeceraRecibo.Columns.Add("numero", typeof(string));
            cabeceraRecibo.Columns.Add("letraJardin", typeof(string));
            cabeceraRecibo.Columns.Add("ReciboCementerio", typeof(string));
            //agrega tipo cambio --12/05/2017
            cabeceraRecibo.Columns.Add("tipoCambio", typeof(decimal));
            //agrega detraccion - facturas en alta direccion.
            cabeceraRecibo.Columns.Add("CodigoDetraccion", typeof(string));
            cabeceraRecibo.Columns.Add("MontoDetraccion", typeof(decimal));
            cabeceraRecibo.Columns.Add("FechaCancelacion", typeof(DateTime));

            //agrega columnas tabla detalle
            detalleRecibo.Columns.Add("idCuentaContable", typeof(int));
            detalleRecibo.Columns.Add("idTarifa", typeof(int));
            detalleRecibo.Columns.Add("idRubro", typeof(int));
            detalleRecibo.Columns.Add("idPagina", typeof(int));
            detalleRecibo.Columns.Add("DescripcionRubro", typeof(string));
            detalleRecibo.Columns.Add("precioUnitario", typeof(decimal));
            detalleRecibo.Columns.Add("descuento", typeof(decimal));
            detalleRecibo.Columns.Add("igv", typeof(decimal));
            detalleRecibo.Columns.Add("cantidad", typeof(int));
            detalleRecibo.Columns.Add("importe", typeof(decimal));
            //
            detalleRecibo.Columns.Add("aFiscal", typeof(string));
            detalleRecibo.Columns.Add("mesDeuda", typeof(string));
            detalleRecibo.Columns.Add("Mora", typeof(decimal));
            detalleRecibo.Columns.Add("Acuenta", typeof(decimal));
            detalleRecibo.Columns.Add("ctacteResidenteId", typeof(int));

            DataRow _filaCabecera = cabeceraRecibo.NewRow();

            _filaCabecera["IdComprobante"] = cboComprobante.SelectedValue;
            _filaCabecera["fechaComprobante"] = Convert.ToDateTime(txtFecha.Text);

            int value;
            if (int.TryParse(txtCodigo.Text, out value))
            {
                _filaCabecera["CodigoCliente"] = value;
            }
            else
            {
                _filaCabecera["CodigoCliente"] = DBNull.Value;
            }

            _filaCabecera["NombreRazonSocialCliente"] = TxtNombre.Text.Trim();

            if (txtDniRuc.Text.Trim() == string.Empty)
            {
                _filaCabecera["dniRucCliente"] = DBNull.Value;
            }
            else
            {
                _filaCabecera["dniRucCliente"] = txtDniRuc.Text.Trim();
            }

            if (TxtDireccion.Text.Trim() == string.Empty)
            {
                _filaCabecera["direccionCliente"] = DBNull.Value;
            }
            else
            {
                _filaCabecera["direccionCliente"] = TxtDireccion.Text.Trim();
            }

            _filaCabecera["idCaja"] = VariablesMetodosEstaticos.idcaja;
            _filaCabecera["idcajausuario"] = VariablesMetodosEstaticos.idcajausuario;
            _filaCabecera["idUsuario"] = VariablesMetodosEstaticos.id_user;
            _filaCabecera["UsuarioIngresaRecibo"] = txtUsuarioC.Text;
            _filaCabecera["idModalidadPago"] = cboModalidadPago.SelectedValue;
            _filaCabecera["idConceptopago"] = cboConcepto.SelectedValue;
            if (cboEntidadFinanciera.SelectedIndex == 0)
            {
                _filaCabecera["fechaPago"] = DBNull.Value;
                _filaCabecera["idEntidadFinancieraPago"] = DBNull.Value;
                _filaCabecera["idCuentaPago"] = DBNull.Value;
                _filaCabecera["importePago"] = DBNull.Value;
                _filaCabecera["tipoCambioPago"] = DBNull.Value;
                _filaCabecera["numeroDocumentoPago"] = DBNull.Value;
            }
            else 
            {
                _filaCabecera["fechaPago"] = dtpFechaPago.Value.Date;
                _filaCabecera["idEntidadFinancieraPago"] = cboEntidadFinanciera.SelectedValue;
                _filaCabecera["idCuentaPago"] = cboCuenta.SelectedIndex == 0 ? DBNull.Value : cboCuenta.SelectedValue;
                _filaCabecera["importePago"] = txtImportePago.Text.Trim();
                _filaCabecera["tipoCambioPago"] = txtTipoCambio.Text.Trim();
                _filaCabecera["numeroDocumentoPago"] = txtNumDocumento.Text.Trim();
            }

            if (txtObservacionesPago.Text.Trim() == string.Empty)
            {
                _filaCabecera["observacionesPago"] = DBNull.Value;
            }
            else
            {
                _filaCabecera["observacionesPago"] = txtObservacionesPago.Text.Trim();
            }

            if (txtDifunto.Text.Trim() == string.Empty)
            {
                _filaCabecera["nombreDifuntoCementerio"] = DBNull.Value;
            }
            else
            {
                _filaCabecera["nombreDifuntoCementerio"] = txtDifunto.Text.Trim();
            }

            if (chkFecha.Checked != true)
            {
                _filaCabecera["fechaDefuncionCementerio"] = DBNull.Value;
                _filaCabecera["fechaInHumacionCementerio"] = DBNull.Value;
                _filaCabecera["horaInhumacion"] = DBNull.Value;
            }
            else
            {
                _filaCabecera["fechaDefuncionCementerio"] = dtpFechaDefuncion.Value.Date;
                _filaCabecera["fechaInHumacionCementerio"] = dtpFechaInHumacion.Value.Date;
                _filaCabecera["horaInhumacion"] = dtpHoraInhumacion.Value.ToShortTimeString();
            }
            
            _filaCabecera["glosa"] = txtGlosa.Text;
            _filaCabecera["valorVenta"] = txtValorVentaC.Text.ToString().Replace(",","");
            _filaCabecera["igv"] = txtIGVC.Text.ToString().Replace(",", "");
            _filaCabecera["precioVenta"] = txtPrecioVentaC.Text.ToString().Replace(",", "");

            _filaCabecera["macId"] = VariablesMetodosEstaticos.mac_id;
            _filaCabecera["SucursalID"] = VariablesMetodosEstaticos.id_Sucursal;
            _filaCabecera["pc"] = System.Net.Dns.GetHostName().ToUpper();
            _filaCabecera["usuarioPc"] = MyID.Name.ToUpper();
            _filaCabecera["redPc"] = VariablesMetodosEstaticos.ip_user;

            _filaCabecera["albergueDireccion"] = cboDireccion.SelectedIndex > 0 ? cboDireccion.Text : null;
            _filaCabecera["alberguecentroGeren"] = cboCentroGerontologico.SelectedIndex > 0 ? cboCentroGerontologico.Text : null;
            _filaCabecera["albergueHabitacion"] = txtHabitacion.Text.Trim() != string.Empty ? txtHabitacion.Text.Trim() : null;
            _filaCabecera["alberguePabellon"] = cboPabellon.Text.Trim() 
                != "[seleccione]" ? cboPabellon.Text.Trim() + (cboNroPabellon.Text == "[seleccione]" ? "" : (" - Pabellon Nº" + cboNroPabellon.Text)) : null;

            _filaCabecera["cuartel"] = cboCuartel.SelectedIndex > 0 ? cboCuartel.Text : null;
            _filaCabecera["numero"] = txtNro.Text.Trim() != string.Empty ? txtNro.Text.Trim() : null;
            _filaCabecera["letraJardin"] = txtLetra.Text.Trim() != string.Empty ? txtLetra.Text.Trim() : null;
            _filaCabecera["ReciboCementerio"] = VariablesMetodosEstaticos.id_programa == 4 ? cboCementerio.Text.ToUpper() : "";// cboCementerio.SelectedIndex == 0 ? null : cboCementerio.Text.ToUpper();//ReciboCementerio;
            _filaCabecera["CodigoDetraccion"] = cboTasaDetraccion.SelectedValue.ToString();
            _filaCabecera["MontoDetraccion"] = txtMontoDetraccion.Text.Trim()==string.Empty ? 0.00m: Convert.ToDecimal(txtMontoDetraccion.Text.Trim());
            _filaCabecera["FechaCancelacion"] = Convert.ToInt32(cboModalidadPago.SelectedValue)!=19 ? Convert.ToDateTime(txtFecha.Text) : dtpFechaCancelacion.Value.Date;
            cabeceraRecibo.Rows.Add(_filaCabecera);
            
            int y = 0;

            if (DGVRubros.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVRubros.Rows)
                {
                    y = y + 1;
                    if (y == (10 * paginacion) + 1)
                    {
                        paginacion = paginacion + 1;
                    }

                    DataRow _filaDetalle = detalleRecibo.NewRow();

                    if (Convert.ToInt32(row.Cells[0].Value) == 0)
                    {
                        _filaDetalle["idCuentaContable"] = DBNull.Value;
                    }
                    else
                    {
                        _filaDetalle["idCuentaContable"] = Convert.ToInt32(row.Cells[0].Value);
                    }
                    
                    if (row.Cells[1].Value == DBNull.Value)
                    {
                        _filaDetalle["idTarifa"] = DBNull.Value;
                    }
                    else
                    {
                        _filaDetalle["idTarifa"] = Convert.ToInt32(row.Cells[1].Value);
                    }
                    _filaDetalle["idRubro"] = Convert.ToInt32(row.Cells[2].Value);
                    _filaDetalle["idPagina"] = paginacion;
                    _filaDetalle["DescripcionRubro"] = row.Cells[3].Value.ToString();
                    _filaDetalle["precioUnitario"] = Convert.ToDecimal(row.Cells[4].Value);
                    _filaDetalle["descuento"] = Convert.ToDecimal(row.Cells[5].Value);
                    _filaDetalle["igv"] = Convert.ToDecimal(row.Cells[6].Value);
                    _filaDetalle["cantidad"] = Convert.ToInt32(row.Cells[7].Value);
                    _filaDetalle["importe"] = Convert.ToDecimal(row.Cells[8].Value);
                    //canevaro
                    _filaDetalle["aFiscal"] = DBNull.Value;
                    _filaDetalle["mesDeuda"] = DBNull.Value;
                    _filaDetalle["Mora"] = DBNull.Value;
                    _filaDetalle["Acuenta"] = DBNull.Value;
                    _filaDetalle["ctacteResidenteId"] = DBNull.Value;
                    detalleRecibo.Rows.Add(_filaDetalle);
                }
            }
            else if (dgvCtaCte.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCtaCte.Rows)
                {
                    y = y + 1;
                    if (y == (10 * paginacion) + 1)
                    {
                        paginacion = paginacion + 1;
                    }

                    DataRow _filaDetalle = detalleRecibo.NewRow();
                    //esta forma de trabajo es obsoleto pero se pone para salir del paso-cambiar luego.
                    int DireccionID = 0;
                    int idCtaContable = 0;
                    string rubroPension = "";
                    string descripAcuenta = "";

                    DireccionID =Convert.ToInt32(cn.TraerDataset("usp_obtiene_direccion_x_residente", Convert.ToInt32(txtCodigo.Text.Trim())).Tables[0].Rows[0][0]);
                    //PENSION ANTERIOR COBRANZA DUDOSA
                    if (DireccionID == 1 && Convert.ToInt32(row.Cells[1].Value) < (DateTime.Now.Year-1))//canevaro
                    {
                        rubroPension = "7027"; //pension canevaro
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    else if (DireccionID == 2 && Convert.ToInt32(row.Cells[1].Value) < (DateTime.Now.Year - 1))//perifericos
                    {
                        rubroPension = "7029"; //pension perifericos
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    else if (DireccionID == 3 && Convert.ToInt32(row.Cells[1].Value) < (DateTime.Now.Year - 1))//svp
                    {
                        rubroPension = "7028"; //pension svp
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    //PENSION ACTUAL
                    if (DireccionID == 1 && (DateTime.Now.Year-Convert.ToInt32(row.Cells[1].Value)==1 || 
                        (DateTime.Now.Year - Convert.ToInt32(row.Cells[1].Value))==0))//canevaro
                    {
                        rubroPension = "7017"; //pension canevaro
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    else if (DireccionID == 2 && (DateTime.Now.Year - Convert.ToInt32(row.Cells[1].Value) == 1 ||
                        (DateTime.Now.Year - Convert.ToInt32(row.Cells[1].Value)) == 0))//perifericos
                    {
                        rubroPension = "7016"; //pension perifericos
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    else if (DireccionID == 3 && (DateTime.Now.Year - Convert.ToInt32(row.Cells[1].Value) == 1 ||
                        (DateTime.Now.Year - Convert.ToInt32(row.Cells[1].Value)) == 0))//svp
                        {
                        rubroPension = "7018"; //pension svp
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }

                    //PAGOS ADELANTADO
                    if (DireccionID == 1 && Convert.ToInt32(row.Cells[1].Value) > DateTime.Now.Year)//canevaro
                    {
                        rubroPension = "7024"; //pension canevaro
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    else if (DireccionID == 2 && Convert.ToInt32(row.Cells[1].Value) > DateTime.Now.Year)//perifericos
                    {
                        rubroPension = "7026"; //pension perifericos
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }
                    else if (DireccionID == 3 && Convert.ToInt32(row.Cells[1].Value) > DateTime.Now.Year)//svp
                    {
                        rubroPension = "7025"; //pension svp
                        idCtaContable = Convert.ToInt32(cn.TraerDataset("usp_obtiene_idcta_x_idrubro", rubroPension).Tables[0].Rows[0][0]);
                    }

                    if (Convert.ToDecimal(row.Cells[7].Value) != 0.00m)
                    {
                        descripAcuenta = " ACUENTA";
                    }
                    else
                    {
                        descripAcuenta = " CANCELA";
                    }

                    _filaDetalle["idCuentaContable"] = idCtaContable;
                    _filaDetalle["idTarifa"] = DBNull.Value;
                    _filaDetalle["idRubro"] = rubroPension;
                    _filaDetalle["idPagina"] = paginacion;
                    _filaDetalle["DescripcionRubro"] = row.Cells[3].Value.ToString() + " " + row.Cells[2].Value.ToString() + "-"
                        + row.Cells[1].Value.ToString() + descripAcuenta;
                    _filaDetalle["precioUnitario"] = Convert.ToDecimal(row.Cells[4].Value);
                    _filaDetalle["descuento"] = Convert.ToDecimal(row.Cells[6].Value);
                    _filaDetalle["igv"] = 0.00M;
                    _filaDetalle["cantidad"] = 1;
                    _filaDetalle["importe"] = Convert.ToDecimal(row.Cells[8].Value);
                    //canevaro
                    _filaDetalle["aFiscal"] = row.Cells[1].Value.ToString();
                    _filaDetalle["mesDeuda"] = row.Cells[2].Value.ToString();
                    _filaDetalle["Mora"] = Convert.ToDecimal(row.Cells[5].Value);
                    _filaDetalle["Acuenta"] = Convert.ToDecimal(row.Cells[7].Value);
                    _filaDetalle["ctacteResidenteId"] = Convert.ToInt32(row.Cells[0].Value);
                    detalleRecibo.Rows.Add(_filaDetalle);
                }
            }
        }

        private void EfectuarPago()
        {
            try 
            {	  
                    int k,NroFilas;
                    NroFilas=0;
                    k=0;

		            if (DGVRubros.RowCount > 0)
                    {
                        k = DGVRubros.RowCount;
                        NroFilas = DGVRubros.RowCount;
                    }
                    else if (dgvCtaCte.RowCount > 0)
                    {
                        k = dgvCtaCte.RowCount;
                        NroFilas = dgvCtaCte.RowCount;
                    }
                    if (k>0)
                    {
                        frmEfectuarPago winPago = new frmEfectuarPago();
                        winPago.ParentForm = this;
                        winPago.reciboCabecera = cabeceraRecibo;
                        winPago.reciboDetalle = detalleRecibo;
                        winPago.ModalidadPago = cboModalidadPago.Text.ToString().ToUpper();
                        winPago.Documento = cboComprobante.Text.ToString().ToUpper();
                        winPago.tipoDocumento = Convert.ToInt32(cboComprobante.SelectedValue);

                        winPago.cod_mod_pago = (cboModalidadPago.SelectedValue).ToString();
                        winPago.desc_mod_Pago = cboModalidadPago.Text;
                        winPago.concep_cod = (cboConcepto.SelectedValue).ToString();
                        winPago.FechaDeposito = dtpFechaPago.Value;
                        winPago.cod_entidad_financ = cboEntidadFinanciera.SelectedValue.ToString()=="0" ? null: cboEntidadFinanciera.SelectedValue.ToString();
                        winPago.nombre_entidad = cboEntidadFinanciera.Text== "[seleccione]"? null: cboEntidadFinanciera.Text;
                        winPago.cuenta_bancaria_id = Convert.ToInt32(cboCuenta.SelectedValue)==0 ? null : cboCuenta.SelectedValue.ToString();
                        winPago.numero_cuenta = cboCuenta.Text== "[seleccione]"? null: cboCuenta.Text;
                        winPago.importe_voucher_pago = Convert.ToDecimal(txtImportePago.Text);
                        winPago.TipoCambio = Convert.ToDecimal(txtTipoCambio.Text);
                        winPago.importe_cambio = Convert.ToDecimal(txtTotalCambioDolar.Text);
                        winPago.NumeroDocumento_Voucher_cheque_pago = txtNumDocumento.Text;
                        winPago.ObservacionPago = txtObservacionesPago.Text.Trim();
                        winPago.modalidadPago = modalidadesPago;
                        winPago.ShowDialog();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un Item como mÍnimo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning);
                    }
	        }
	        catch (Exception ex)
	            {

	            }
        }

        private bool ValidarCampos(bool agrega)
        {
            bool flag = true;

            if (cboDireccion.SelectedIndex == 0 && VariablesMetodosEstaticos.id_programa == 4)
            {
                DataSet dts = new DataSet();

                if (cboCuartel.SelectedIndex > 0 && txtNro.Text != string.Empty && txtLetra.Text != string.Empty)
                {
                    dts = cn.EjecutarSqlDTS("select FLAGGABINETE from cementerio.nichoinventario where CODPABELLON='"
                        + Convert.ToInt32(cboCuartel.SelectedValue).ToString("0000") + "' and LETRAFILANICHO='" + txtLetra.Text + "' and NUMEROCOLNICHO=" + txtNro.Text + "");

                    if (dts.Tables[0].Rows.Count > 0)
                    {
                        if (dts.Tables[0].Rows[0][0].ToString() == "0")
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Este nicho se encuentra en proceso de inventario, cordine con el encargado antes de procesar la venta.");
                            return false;
                        }
                        else if (dts.Tables[0].Rows[0][0].ToString() == "1")
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Este nicho ya fue procesado por gabinete.");
                            flag = true;
                        }
                    }
                }
            }
            if (VariablesMetodosEstaticos.id_programa != 1)
            {
                if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 19)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Su caja no puede generar documento PENDIENTES DE COBRO.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (VariablesMetodosEstaticos.id_programa == 1 || VariablesMetodosEstaticos.id_programa == 4)
            {
                if (Convert.ToInt32(cboModalidadPago.SelectedValue) == 19)//cobro pendiente
                {
                    if (Convert.ToInt32(this.cboComprobante.SelectedValue) > 0)//FACTURA BOLETA
                    {
                        if (cboConcepto.SelectedIndex == 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un concepto.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            if (Convert.ToDateTime(dtpFechaCancelacion.Value.ToShortDateString()) <= Convert.ToDateTime(txtFecha.Text))
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de cobro no puede ser menor o igual a la fecha de emisión debido a que se selecciono PENDIENTE DE COBRO.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                                dtpFechaCancelacion.Focus();
                                return false;
                            }
                            else
                            {
                                if (cboCuenta.SelectedValue != null)
                                {
                                    if ((int)cboCuenta.SelectedValue != 0)
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Ha seleccionado PENDIENTE DE COBRO y no puede seleccionar una cuenta bancaria.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                        cboCuenta.Focus();
                                        flag = false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El documento seleccionado no puede ser PENDIENTE DE COBRO.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                        cboComprobante.Focus();
                        return false;
                    }
                }
                else
                {
                    if (Convert.ToInt32(this.cboComprobante.SelectedValue) != 3)//cobro al contado
                    {
                        if (Convert.ToDateTime(dtpFechaCancelacion.Value.ToShortDateString()) != Convert.ToDateTime(txtFechaSistemaC.Text))
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de cobro no puede ser DIFERENTE a la fecha de emisión.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                            dtpFechaCancelacion.Focus();
                            return false;
                        }
                    }
                    //AQUI
                }
            }

            if (cboComprobante.SelectedIndex == 0)
            {
                errorProvider1.SetError(cboComprobante, "Seleccione el tipo de comprobante");
                flag = false;
            }
            else if (cboComprobante.Text != "RECIBO DE CAJA")
            {
                if (txtDniRuc.Text.Trim() == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtDniRuc, "Ingrese Número de documento de identidad");
                    flag = false;
                }
                else if (txtDniRuc.Text.Trim().ToString().Length != 8 && txtDniRuc.Text.Trim().ToString().Length != 11)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtDniRuc, "Para el caso de DNI ingrese 8 dígitos y para RUC 11 dígitos.");
                    flag = false;
                }
                else
                {
                    DataTable dtGenerico = new DataTable();
                    dtGenerico = cn.EjecutarSqlDTS("select descripcionTipo from tb_tipo_modalidad_pago where idTipo in (select idTipo from ta_modalidad_pago where cod_mod_Pago=" + cboModalidadPago.SelectedValue + ")").Tables[0];
                    if (dtGenerico.Rows[0][0].ToString() == "EFECTIVO")
                    {
                        if ((int)cboEntidadFinanciera.SelectedValue != 0)
                        {
                            if ((int)cboEntidadFinanciera.SelectedValue != 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("La modalidad de pago seleccionada no tiene relacion con la entidad bancaria seleccionada.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
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
                                if (modalidadesPago.Rows.Count == 0)
                                {
                                    txtImportePago.Text = txtPrecioVentaC.Text;
                                }

                                if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Debe ingresar el importe de pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                                    txtImportePago.Focus();
                                    flag = false;
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
            }
            else if (TxtNombre.Text.Trim() == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtNombre, "Ingrese nombre");
                flag = false;
            }
            else if (cboModalidadPago.SelectedIndex == 0)
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

            if (cboDireccion.SelectedIndex == 0 && VariablesMetodosEstaticos.id_programa == 2)
            {
                if (Convert.ToDecimal(txtImportePago.Text) <= 0)
                {
                    if (modalidadesPago.Rows.Count == 0)
                    {
                        txtImportePago.Text = txtPrecioVentaC.Text;
                    }
                }
                errorProvider1.Clear();
                errorProvider1.SetError(cboDireccion, "Seleccione una Dirección.");
                flag = false;
            }

            if (cboCementerio.SelectedIndex == 0 && VariablesMetodosEstaticos.id_programa == 4)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una cementerio.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                cboCementerio.Focus();
                flag = false;
            }

            if (VariablesMetodosEstaticos.id_programa == 1)
            {
                if (txtMontoDetraccion.Text.Trim() == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtMontoDetraccion, "Tiene que ser como minimo 0.00 aún asi no tenga detracción.");
                    flag = false;
                }
            }

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

            else
            { 
                if (errorProvider1.GetError(txtDniRuc) != "")
                {

                }
                else
                {
                    errorProvider1.Clear();
                }
            }

            return flag;
        }

        private void limpiarGrillaRubro()
        {
            if (DGVRubros.RowCount > 0)
            {
                while (DGVRubros.RowCount>0)
                {
                    DGVRubros.Rows.Remove(DGVRubros.CurrentRow);
                }
            }
        }

        private void limpiarGrillaCta()
        {
            if (dgvCtaCte.RowCount > 0)
            {
                while (dgvCtaCte.RowCount > 0)
                {
                    dgvCtaCte.Rows.Remove(dgvCtaCte.CurrentRow);
                }
            }
        }
        private void acumulado()
        {
            try
            {
                decimal tot = 0.00m;
                decimal igv = 0.00m;
                decimal subTotal = 0.00m;
         
                for (int i = 0; i < DGVRubros.RowCount; i++)
                {
                    igv = igv + Convert.ToDecimal(DGVRubros.Rows[i].Cells[6].Value)* Convert.ToDecimal(DGVRubros.Rows[i].Cells[7].Value);
                    subTotal = subTotal + (Convert.ToDecimal(DGVRubros.Rows[i].Cells[4].Value)) * Convert.ToDecimal(DGVRubros.Rows[i].Cells[7].Value);//+Convert.ToDecimal(DGVRubros.Rows[i].Cells[4].Value);
                    tot = tot + /*((Convert.ToDecimal(DGVRubros.Rows[i].Cells[6].Value) * Convert.ToDecimal(DGVRubros.Rows[i].Cells[7].Value)) +*/ Convert.ToDecimal(DGVRubros.Rows[i].Cells[8].Value);
                }

                txtValorVentaC.Text = subTotal.ToString("##,##0.00");
                txtIGVC.Text = igv.ToString("##,##0.00");
                txtPrecioVentaC.Text = tot.ToString("##,##0.00");
            }
            catch (Exception)
            {
            }
        }

        private void acumulado2()
        {
            try
            {
                decimal tot = 0.00m;
                decimal igv = 0.00m;
                decimal subTotal = 0.00m;

                for (int i = 0; i < dgvCtaCte.RowCount; i++)
                {
                    //igv = igv + Convert.ToDecimal(DGVRubros.Rows[i].Cells[6].Value);
                    //subTotal = subTotal + (Convert.ToDecimal(DGVRubros.Rows[i].Cells[8].Value) - Convert.ToDecimal(DGVRubros.Rows[i].Cells[6].Value));//Convert.ToDecimal(DGVRubros.Rows[i].Cells[4].Value);
                    tot = tot + Convert.ToDecimal(dgvCtaCte.Rows[i].Cells[8].Value);
                }
                subTotal = tot;
                txtValorVentaC.Text = subTotal.ToString("##,##0.00"); //subTotal
                txtIGVC.Text = igv.ToString("##,##0.00");
                txtPrecioVentaC.Text = tot.ToString("##,##0.00");
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvCtaCte.RowCount > 0)
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("Se procedera a eliminar los registros ingresados en el detalle. ¿Desea continuar.?", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    limpiarGrillaCta();
                }
                else
                {
                    return;
                }
            }
            if (DGVRubros.RowCount > 0)
            {
                if (flagFonavi)
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("Se procedera a eliminar los registros ingresados en el detalle. ¿Desea continuar.?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        DGVRubros.Rows.Clear();
                        flagFonavi = false;
                        direccionClienteOrbegoso = "";
                        nombreClienteOrbegoso = "";
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (cboComprobante.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Tipo de comprobante.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboComprobante.Focus();
                return;
            }

            bool impuesto = false;

            impuesto = Convert.ToBoolean(cn.TraerDataset("usp_s_obtiene_flag_impuesto",cboComprobante.SelectedValue).Tables[0].Rows[0][0]);
            
            DataSet dtsRubros;

            if (VariablesMetodosEstaticos.id_programa == 4)
            {
                frmAgregarRubrosCementerio winAddRubCementerio = new frmAgregarRubrosCementerio();
                dtsRubros = winAddRubCementerio.traerFormulario();
                llamaDetalle(dtsRubros, impuesto);
            }
            else if (VariablesMetodosEstaticos.id_programa == 2)
            {
                if (chkCta.Checked)
                {
                    if (txtCodigo.Text.Trim() == string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Debe seleccionar un residente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BtnBuscarCliente.Focus();
                        return;
                    }
                    frmCtaCteResidente winCtaResi = new frmCtaCteResidente();
                    winCtaResi.ParentForm = this;
                    winCtaResi.idResidente = Convert.ToInt32(txtCodigo.Text);
                    winCtaResi.nombreResidente = TxtNombre.Text;
                    winCtaResi.ShowDialog();
                    acumulado2();
                    marcarGrilla();
                }
                else
                {
                    frmAgregarRubro winAddRub = new frmAgregarRubro();
                    dtsRubros = winAddRub.traerFormulario();
                    llamaDetalle(dtsRubros, impuesto);
                }
            }
            else
            {
                frmAgregarRubro winAddRub = new frmAgregarRubro();
                winAddRub.liquidacion = false;
                dtsRubros = winAddRub.traerFormulario();
                llamaDetalle(dtsRubros, impuesto);
            }
        }

        private void marcarGrilla()
        {
            if (dgvCtaCte.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvCtaCte.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void llamaDetalle(DataSet dtsRubros,bool imp)
        {
            if (dtsRubros.Tables[0].Rows.Count > 0)
            {
                //--SE BLOQUEA EL COMBO CUANDO SE INGRESA UN ITEM A LA GRILLA DGVRUBROS PARA EVITAR EL CAMBIO DEL TIPO DE DOCUMENTO CUANDO YA SE TENGA ITEMS AGREGADOS.
                if (DGVRubros.RowCount == 0)
                {
                    cboComprobante.Enabled = false;
                }

                TraerDatosDetalle(dtsRubros.Tables[0].Rows[0][0].ToString(), Convert.ToInt32(dtsRubros.Tables[0].Rows[0][1]), dtsRubros.Tables[0].Rows[0][2].ToString(),
                              dtsRubros.Tables[0].Rows[0][3].ToString(), Convert.ToDecimal(dtsRubros.Tables[0].Rows[0][4])
                              , Convert.ToInt32(dtsRubros.Tables[0].Rows[0][5]), Convert.ToDecimal(dtsRubros.Tables[0].Rows[0][6]), imp, dtsRubros.Tables[0].Rows[0][7].ToString());
            }
        }
        //idGenerico -> intTaId || intRuId
        private void TraerDatosDetalle(string ctaConta,int idGenerico,
            string CodRubro,string descrip,decimal precio,int cantidad,decimal dscto,bool imp,string ParamCementerio)
        {
           
            foreach (DataGridViewRow row in DGVRubros.Rows)
            {
                if (VariablesMetodosEstaticos.id_programa != 4)
                {
                    if (!(VariablesMetodosEstaticos.id_programa == 5 || VariablesMetodosEstaticos.id_programa == 6))
                    {
                        if (row.Cells[2].Value.ToString() == CodRubro)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El item que desea ingresar ya ha sido ingresado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;// break;
                        }
                    }                
                }
                else
                {
                    if (Convert.ToInt32(row.Cells[1].Value) == idGenerico)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El item que desea ingresar ya ha sido ingresado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;// break;
                    }
                    if (ParamCementerio != string.Empty)
                    {
                        if (row.Cells[9].Value.ToString() != string.Empty)
                        if (row.Cells[9].Value.ToString() != ParamCementerio)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El item que desea ingresar Pertenece a otro cementerio diferente a los items ya ingresados.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;// break;
                        }
                    }
                }
            }

            if (ParamCementerio != string.Empty)
            {
                ReciboCementerio = ParamCementerio;
            }

            DGVRubros.Rows.Add();
            int fila = DGVRubros.RowCount - 1;
            decimal _igv = 0.00m;
            decimal subTotal = 0.00m;
            decimal descuento = 0.00m;
            decimal total = 0.00m;
            decimal tasaIgv = 0.00m;

            descuento =decimal.Round((precio * dscto * cantidad),2);

            if (imp)
            {
                tasaIgv = VariablesMetodosEstaticos.igv;
            }

            subTotal = decimal.Round((precio * (1 - dscto)) / (1 + tasaIgv),2);

            total =decimal.Round((precio * (1 - dscto)),2);

            _igv = imp ? decimal.Round((total - subTotal), 2) : 0.00m;

            DGVRubros.Rows[fila].Cells[0].Value = ctaConta;

            if (VariablesMetodosEstaticos.id_programa != 4)
            {
                DGVRubros.Rows[fila].Cells[1].Value = DBNull.Value;
            }
            else
            {
                DGVRubros.Rows[fila].Cells[1].Value = idGenerico;
            }
            DGVRubros.Rows[fila].Cells[2].Value = CodRubro;
            DGVRubros.Rows[fila].Cells[3].Value = descrip;
            if (_igv != 0.00m)
            {
                //DGVRubros.Rows[fila].Cells[4].Value = subTotal;
                DGVRubros.Rows[fila].Cells[4].Value = subTotal;
            }
            else
            {
                DGVRubros.Rows[fila].Cells[4].Value = precio;//subTotal;
            }          
            DGVRubros.Rows[fila].Cells[5].Value = descuento;
            DGVRubros.Rows[fila].Cells[6].Value = _igv ;
            DGVRubros.Rows[fila].Cells[7].Value = cantidad;
            DGVRubros.Rows[fila].Cells[8].Value =(subTotal+_igv)*cantidad;
            DGVRubros.Rows[fila].Cells[9].Value = ParamCementerio;
            acumulado();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVRubros.RowCount > 0)
                {
                    if (flagFonavi)
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("Por se detalle de pagos de Fonavi se eliminaran los registros. ¿Desea continuar.?", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            DGVRubros.Rows.Clear();
                            flagFonavi = false;
                            direccionClienteOrbegoso = "";
                            nombreClienteOrbegoso = "";
                        }
                    }
                    else
                    {
                        DGVRubros.Rows.RemoveAt(DGVRubros.CurrentRow.Index);

                        if (DGVRubros.RowCount == 0)
                        {
                            cboComprobante.Enabled = true;
                        }
                        acumulado();
                    }                
                }
                else if (dgvCtaCte.RowCount > 0)
                {
                    dgvCtaCte.Rows.Clear();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No existe datos para eliminar",VariablesMetodosEstaticos.encabezado,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                dgvCtaCte.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void cboComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id=0;
                id = Convert.ToInt32(cboComprobante.SelectedValue);
                if (VariablesMetodosEstaticos.id_programa == 1 || VariablesMetodosEstaticos.id_programa==4)
                {
                    if (id == 3)
                    {
                        dtpFechaCancelacion.Value = DateTime.Now;
                        dtpFechaCancelacion.Enabled = true;
                        cboTasaDetraccion.SelectedIndex = 0;
                        cboTasaDetraccion.Enabled = false;
                        txtMontoDetraccion.Clear();
                        txtMontoDetraccion.Text = "0.00";
                        txtMontoDetraccion.Enabled = false;
                    }
                    else if (id == 1)
                    {
                        dtpFechaCancelacion.Value = DateTime.Now;
                        dtpFechaCancelacion.Enabled = true;
                        cboTasaDetraccion.SelectedIndex = 0;
                        cboTasaDetraccion.Enabled = true;
                        txtMontoDetraccion.Clear();
                        txtMontoDetraccion.Text = "0.00";
                        txtMontoDetraccion.Enabled = true;
                    }
                    else if (id == 2)
                    {
                        dtpFechaCancelacion.Value = DateTime.Now;
                        dtpFechaCancelacion.Enabled = true;
                        cboTasaDetraccion.SelectedIndex = 0;
                        cboTasaDetraccion.Enabled = true;
                        txtMontoDetraccion.Clear();
                        txtMontoDetraccion.Text = "0.00";
                        txtMontoDetraccion.Enabled = true;
                    }
                }
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
                dsetMoneda = cn.TraerDataset("usp_obtiene_abreviatura_moneda",idCuenta);

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
                    dt = cn.TraerDataset("usp_select_cuenta_bancaria",cboEntidadFinanciera.SelectedValue,cboModalidadPago.SelectedValue).Tables[0];
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

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.id_programa == 2)
            {
                canevaro.frmMantResidente winCanevaroResidente = new canevaro.frmMantResidente();
                winCanevaroResidente.ParentForm = this;
                winCanevaroResidente.Flag = true;
                winCanevaroResidente.ShowDialog();
            }
        }

        private void chkCta_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                if (DGVRubros.Rows.Count > 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No se puede cambiar a pago de cuentas si se tiene lleno el detalle de otros rubros", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkBox.Checked = false;
                    return;
                }
                dgvCtaCte.Visible = true;
                DGVRubros.Visible = false;
            }
            else
            {
                if (dgvCtaCte.Rows.Count > 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No se puede cambiar a pago de cuentas si se tiene lleno el detalle de otros rubros", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checkBox.Checked = true;
                    return;
                }
                dgvCtaCte.Visible = false;
                DGVRubros.Visible = true;
            }
        }

        private void cboDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_centroGerontologico", cboDireccion.SelectedValue).Tables[0];
                cboCentroGerontologico.DataSource = dt;
                cboCentroGerontologico.DisplayMember = "NombreCentroGerontologico";
                cboCentroGerontologico.ValueMember = "CentroGerontologicoId";
            }
            catch (Exception)
            {

            }
        }

        private void cargarCuartelesFiltro(string filtro, string accion)
        {
            var dt = new DataTable();
            try
            {
                    DataTable filTable = new DataTable();
                    filTable = cn.TraerDataset("usp_select_filtro_tb_cuartel", filtro, accion).Tables[0];
                    if (filTable.Rows.Count > 0)
                    {
                        mantenimiento.frmFiltroCuarteles fi = new mantenimiento.frmFiltroCuarteles();
                        fi.dfiltro = filTable;
                        fi.ShowDialog();
                        if (fi.nomCuartel != string.Empty)
                        {
                            cboCuartel.Text = fi.nomCuartel;
                            txtFiltro.Clear();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos con el filtro proporcionado.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            catch (Exception)
            {

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarCuartelesFiltro(txtFiltro.Text.Trim(), "S");
            }
        }

        private void btnFonavi_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVRubros.RowCount > 0)
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("Se eliminara los registros ya ingresados. ¿Desea continuar.?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        DGVRubros.Rows.Clear();
                        flagFonavi = false;
                        direccionClienteOrbegoso="";
                        nombreClienteOrbegoso="";
                    }
                    else
                    {
                        return;
                    }
                }
                caja.frmPagoFonavi fon = new caja.frmPagoFonavi();
                fon.ParentForm = this;
                fon.ShowDialog();

                if (flagFonavi)
                {
                    TxtDireccion.Text = direccionClienteOrbegoso;
                    TxtNombre.Text = nombreClienteOrbegoso;
                    acumulado();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFecha.Checked)
            {
                inhabilitarFechaCementerio(true);
            }
            else
            {
                inhabilitarFechaCementerio(false);
            }
        }

        private void cboCuartel_DropDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                txtFiltro.Focus();
            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Oemplus)
            {
                txtNro.Focus();
            }
        }

       private void txtNro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                txtLetra.Focus();
            }
        }
       private void txtLetra_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.Tab)
           {
               txtDifunto.Focus();
           }
       }

       private void txtDifunto_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.Tab)
           {
               dtpFechaDefuncion.Focus();
           }
       }

       private void dtpFechaDefuncion_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.Tab)
           {
               dtpFechaInHumacion.Focus();
           }
       }

       private void dtpFechaInHumacion_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.Tab)
           {
               dtpHoraInhumacion.Focus();
           }
       }

       private void dtpHoraInhumacion_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.Control && e.KeyCode == Keys.Tab)
           {
               btnAdd.Focus();
           }
       }

       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
           //if (txtFiltro.Focused == true && keyData == Keys.Space) //== (Keys.LButton | Keys.Back))
           //{
           //    txtFiltro.Text = txtNro.Text.ToString().Trim() ;
           //    txtNro.Focus();
           //}
           //if (txtNro.Focused == true && keyData == Keys.Space) //== (Keys.LButton | Keys.Back))
           //{
           //    txtNro.Text = txtNro.Text.ToString().Trim();
           //    txtLetra.Focus();
           //}
           //if (txtLetra.Focused == true && keyData == Keys.Space) //== (Keys.LButton | Keys.Back))
           //{
           //    txtNro.Text = txtNro.Text.ToString().Trim();
           //    txtLetra.Focus();
           //}

           if (keyData == Keys.Escape)
           {
               this.Close();
               return true;
           }
           return base.ProcessCmdKey(ref msg, keyData);
       }

        private void txtMontoDetraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaCancelacion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
