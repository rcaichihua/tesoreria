using BL_Tesoreria;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmReciboCajaPrincipal : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public int NroLiquidacion { get; set; }
        public int FuenteIngreso { get; set; }
        public string Glosa { get; set; }
        public string FechaLiquidacion { get; set; }
        public string FechaCaja { get; set; }
        public decimal TotalLiquidacion { get; set; }
        public string Nombre { get; set; }
        private DataTable cabeceraRecibo;
        private DataTable detalleRecibo;
        //private DataSet dtsRubros;
        CNegocio cn = new CNegocio();
        ReportDocument report = new ReportDocument();
        decimal SaldoLiquidacion = 0.00m;

        public frmReciboCajaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnNuevoC_Click(object sender, EventArgs e)
        {
            limpia();
            varGlobales.habilitarCampos(this, true);
            BtnNuevoC.Enabled = false;
            BtnCancelarC.Enabled = true;
            BtnGrabarC.Enabled = true;
            TxtNombreC.Focus();
        }
        private void limpia()
        {
            varGlobales.resetearCampos(this);
            habilitaCampoMontos(true);
            txtImportePago.Text = "0.00";
            txtTipoCambio.Text = "1.000";
            txtTotalCambioDolar.Text = "0.00";
            txtGlosa.Clear();
            //dtpFechaPago.Value = DateTime.Now;

            if (DGVRubros.RowCount > 0)
            {
                limpiarGrillaRubro();
            }
            acumulado();
        }

        private void acumulado()
        {
            try
            {
                decimal tot = 0.00m;

                for (int i = 0; i < DGVRubros.RowCount; i++)
                {
                    tot = tot + Convert.ToDecimal(DGVRubros.Rows[i].Cells[4].Value);
                }

                txtTotalDocumentoC.Text = tot.ToString("##,##0.00");
                txtImportePago.Text = tot.ToString("##,##0.00");
                txtSaldoC.Text = (SaldoLiquidacion - tot).ToString("###,##0.00");
            }
            catch (Exception)
            {
            }
        }

        private void frmReciboCajaPrincipal_Load(object sender, EventArgs e)
        {
            lblNro.Text =NroLiquidacion.ToString("000000");
            txtFechaCajaC.Text = FechaCaja;
            txtFechaLiquidacionC.Text = FechaLiquidacion;
            txtUsuarioC.Text = VariablesMetodosEstaticos.varUsuario;
            TxtNombreC.Text = Nombre.ToUpper();
            txtTotalLiquidacionC.Text = TotalLiquidacion.ToString("###,###,##0.00");
            CargaNroCajaPrincipal();
            cargarModalidadPago();
            BuscaSaldoLiquidacion();
            txtGlosa.Text = Glosa;
            if (Convert.ToDecimal(txtSaldoC.Text)==Convert.ToDecimal(cn.TraerDataset("usp_obtiene_importe_garantia", FechaLiquidacion).Tables[0].Rows[0][0].ToString()))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ya no se pueden generar mas recibos de caja, el saldo pendiente fue ya ingresa por garantia.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            //varGlobales.habilitarCampos(this, false);
        }

        private void CargaNroCajaPrincipal()
        {
            try
            {
                mtbNroReciboCaja.Text = "001" + "-" + Convert.ToInt32(cn.TraerDataset("usp_obtiene_CorrelativoCajaPrincipal").Tables[0].Rows[0][0]).ToString("000000");
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BuscaSaldoLiquidacion()
        {
            txtSaldoC.Text = Convert.ToDecimal(cn.TraerDataset("usp_ObtieneSaldoLiquidacion",Convert.ToInt32(lblNro.Text), 
                FuenteIngreso,Convert.ToDateTime(FechaCaja).ToString("yyyyMMdd")).Tables[0].Rows[0][0]).ToString("###,###,#00.00");
            SaldoLiquidacion = Convert.ToDecimal(txtSaldoC.Text);
            if (Convert.ToDecimal(txtSaldoC.Text)<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ya no se pueden generar mas recibos de caja, ya no hay saldo disponible.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void cargarModalidadPago()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_SelectModalidadPagoPrincipal").Tables[0];
                cboModalidadPago.DataSource = dt;
                cboModalidadPago.DisplayMember = "descripcionModalidad";
                cboModalidadPago.ValueMember = "codmodalidad";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habilitaCampoMontos(Boolean flag)
        {
            txtTotalDocumentoC.Enabled = flag;
            txtSaldoC.Enabled = flag;
            txtTotalLiquidacionC.Enabled = flag;
        }
        private void limpiarGrillaCta()
        {
            if (DGVRubros.RowCount > 0)
            {
                while (DGVRubros.RowCount > 0)
                {
                    DGVRubros.Rows.Remove(DGVRubros.CurrentRow);
                }
            }
        }

        private void limpiarGrillaRubro()
        {
            if (DGVRubros.RowCount > 0)
            {
                while (DGVRubros.RowCount > 0)
                {
                    DGVRubros.Rows.Remove(DGVRubros.CurrentRow);
                }
            }
        }
        private void calcularSaldo()
        {
            decimal acu = 0.00m;

            acu = Convert.ToDecimal(cn.TraerDataset("usp_obtiene_total_por_liquidacion_dgai", Convert.ToInt32(lblNro.Text)).Tables[0].Rows[0][0]);

            txtSaldoC.Text = (Convert.ToDecimal(txtTotalLiquidacionC.Text) - acu).ToString("##,##0.00");
        }

        private bool validacion()
        {
            if (cboModalidadPago.SelectedIndex == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione modalidad de pago.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboModalidadPago.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtImportePago.Text) <= 0.00M)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor mayor a 0.00 en importe cambio.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImportePago.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtTotalCambioDolar.Text) <= 0.00M)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione modalidad de pago.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalCambioDolar.Focus();
                return true;
            }
            if (DGVRubros.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Debe ingresar al menos un item en el detalle de ingreso.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtSaldoC.Text) == 0.00m)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ya no queda saldo disponible para generar recibo.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldoC.Focus();
                return true;
            }
            if (Convert.ToDecimal(txtTotalDocumentoC.Text) != Convert.ToDecimal(txtTotalCambioDolar.Text))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El monto total del documento debe ser igual al monto total cambio.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImportePago.Focus();
                return true;
            }

            return false;
        }

        private void BtnSalirC_Click(object sender, EventArgs e)
        {
            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de cancelar? si presiona [SI] saldrá de la ventana.", VariablesMetodosEstaticos.encabezado,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool impuesto = false;

            impuesto = Convert.ToBoolean(cn.TraerDataset("usp_s_obtiene_flag_impuesto", 3).Tables[0].Rows[0][0]);

            DataSet dtsRubros;

            frmAgregarRubro winAddRub = new frmAgregarRubro();
            winAddRub.liquidacion = true;
            winAddRub.EsCentral = true;
            winAddRub.FuenteIngreso = FuenteIngreso;
            winAddRub.SaldoDocumento = SaldoLiquidacion;
            winAddRub.TotalDocumento = Convert.ToDecimal(txtTotalDocumentoC.Text);
            winAddRub.Modifica = false;
            winAddRub.TipoRecibo = "N";
            dtsRubros = winAddRub.traerFormulario();
            llamaDetalle(dtsRubros, impuesto);

        }

        private void llamaDetalle(DataSet dtsRubros, bool imp)
        {
            if (dtsRubros.Tables[0].Rows.Count > 0)
            {
                TraerDatosDetalle(dtsRubros.Tables[0].Rows[0][0].ToString(), Convert.ToInt32(dtsRubros.Tables[0].Rows[0][1]),Convert.ToInt32(dtsRubros.Tables[0].Rows[0][2].ToString()).ToString("0000"),
                              dtsRubros.Tables[0].Rows[0][3].ToString(), Convert.ToDecimal(dtsRubros.Tables[0].Rows[0][4])
                              , Convert.ToInt32(dtsRubros.Tables[0].Rows[0][5]), Convert.ToDecimal(dtsRubros.Tables[0].Rows[0][6]), imp, dtsRubros.Tables[0].Rows[0][7].ToString());
            }
        }

        private void TraerDatosDetalle(string ctaConta, int idGenerico,
            string CodRubro, string descrip, decimal precio, int cantidad, decimal dscto, bool imp, string ParamCementerio)
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

            DGVRubros.Rows.Add();
            int fila = DGVRubros.RowCount - 1;
            decimal _igv = 0.00m;
            decimal subTotal = 0.00m;
            decimal descuento = 0.00m;
            decimal total = 0.00m;
            decimal tasaIgv = 0.00m;

            descuento = decimal.Round((precio * dscto * cantidad), 2);

            if (imp)
            {
                tasaIgv = VariablesMetodosEstaticos.igv;
            }

            subTotal = decimal.Round((precio * (1 - dscto)) / (1 + tasaIgv), 2);

            total = decimal.Round((precio * (1 - dscto)), 2);

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
            DGVRubros.Rows[fila].Cells[6].Value = _igv;
            DGVRubros.Rows[fila].Cells[7].Value = cantidad;
            DGVRubros.Rows[fila].Cells[8].Value = (subTotal + _igv) * cantidad;
            DGVRubros.Rows[fila].Cells[9].Value = ParamCementerio;
            acumulado();
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

        private void txtImportePago_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void BtnGrabarC_Click(object sender, EventArgs e)
        {
            frmImpresionRecibos winReport = new frmImpresionRecibos();
            winReport.GeneraReciboPrincipal = true;
            DataTable dtBuscaNroRecibo = new DataTable();
            bool directoImpresora = true;

            if (!Validaciones()) return;
            dtBuscaNroRecibo = cn.TraerDataset("usp_BuscaNumeroRecibo", 
                Convert.ToInt32(mtbNroReciboCaja.Text.Substring(mtbNroReciboCaja.Text.IndexOf("-") + 1, 
                mtbNroReciboCaja.Text.Length - mtbNroReciboCaja.Text.IndexOf("-") - 1))).Tables[0];
            if (dtBuscaNroRecibo.Rows[0][0].ToString()=="1")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El Número de recibo ya existe.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                mtbNroReciboCaja.Focus();
                return;
            }
            ArmarTablasCabeceraDetalle();
            DataSet resultado = new DataSet();

            resultado = cn.IngresaReciboPrincipal("usp_genera_ingresosCaja", cabeceraRecibo, detalleRecibo);

            int idReciboCabecera = 0;

            idReciboCabecera = Convert.ToInt32(resultado.Tables[0].Rows[0][0]);

            if (idReciboCabecera == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error al guardar el recibo, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Recibo Ingresado correctamente.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                directoImpresora = Convert.ToBoolean(cn.EjecutarSqlDTS("select valor from ta_control where parametro='imprimeDirecto_recibo_caja'").Tables[0].Rows[0][0]);

                Reportes.rptReciboCaja rptRecibo = new Reportes.rptReciboCaja();
                rptRecibo.SetDataSource(cn.TraerDataset("usp_ObtieneReciboCajaPrincipal", idReciboCabecera).Tables[0]);
                //rptRecibo.SetParameterValue("@descripMonto", VariablesMetodosEstaticos.varNombreSucursal);
                //rptRecibo.SetParameterValue("@Total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                if (directoImpresora)
                {
                    Imprimir(rptRecibo);
                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                }
                else
                {
                    winReport.crvReportes.ReportSource = rptRecibo;
                }
                if (!directoImpresora)
                {
                    winReport.WindowState = FormWindowState.Maximized;
                    winReport.ShowDialog();
                }
                this.Close();
            }
        }

        void Imprimir(ReportDocument repo)
        {
            string nombreImpresora;
            DataTable resuImpr = new DataTable();
            string recibo = "reciboCentralPrincipal";

            resuImpr = cn.TraerDataset("usp_obtiene_printer_por_mac", VariablesMetodosEstaticos.mac_id).Tables[0];

            if (resuImpr.Rows.Count <= 0)
            {
                nombreImpresora = "EPSON FX-890 ESC/P";
            }
            else
            {
                nombreImpresora = resuImpr.Rows[0][0].ToString();
            }

            report = (ReportDocument)repo;

            var doctoPrint = new System.Drawing.Printing.PrintDocument();
            doctoPrint.PrinterSettings.PrinterName = nombreImpresora;//"EPSON LX-350 ESC/P"; //printer es el nombre de la impresora por donde imprimirá

            for (var j = 0; j < doctoPrint.PrinterSettings.PaperSizes.Count; j++)
                if (doctoPrint.PrinterSettings.PaperSizes[j].PaperName == recibo) //tamañoPapel es el nombre del tamaño parametrizado
                {
                    report.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)doctoPrint.PrinterSettings.PaperSizes[j].RawKind;
                    report.PrintOptions.PrinterName = nombreImpresora;
                    break;
                }
            report.PrintToPrinter(1, false, 0, 0);
        }

        private bool Validaciones()
        {
            int nrorecibo;
            bool resu = false;

            if (int.TryParse((mtbNroReciboCaja.Text.Substring(mtbNroReciboCaja.Text.IndexOf("-") + 1, mtbNroReciboCaja.Text.Length - mtbNroReciboCaja.Text.IndexOf("-") - 1)),out nrorecibo))
            {
                if (mtbNroReciboCaja.Text.Length == 10)
                {
                    if (TxtNombreC.Text.Trim() != "")
                    {
                        if (cboModalidadPago.SelectedIndex != 0)
                        {
                            if (Convert.ToDecimal(txtTotalCambioDolar.Text) == Convert.ToDecimal(txtTotalDocumentoC.Text))
                            {
                                if (DGVRubros.Rows.Count != 0)
                                {
                                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de guardar el recibo de caja?", 
                                        VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                        MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                                    {
                                        resu = true;
                                    }
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese al menos un item.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                    btnAdd.Focus();
                                    resu = false;
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("El total del documento debe ser igual a total cambio.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                                txtTotalCambioDolar.Focus();
                                resu = false;
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione la modalidad de pago.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                            cboModalidadPago.Focus();
                            resu = false;
                        }

                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un nombre.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                        TxtNombreC.Focus();
                        resu = false;
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese correctamente el Nº del recibo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                    mtbNroReciboCaja.Focus();
                    resu = false;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese correctamente el Nº del recibo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                mtbNroReciboCaja.Focus();
                resu = false;
            }
            
            
            return resu;
        }

        private void ArmarTablasCabeceraDetalle()
        {
            cabeceraRecibo = new DataTable();
            detalleRecibo = new DataTable();

            cabeceraRecibo.Clear();
            detalleRecibo.Clear();

            cabeceraRecibo.Columns.Add("idLiquidacion", typeof(int));
            cabeceraRecibo.Columns.Add("nro_recibo_caja", typeof(int));
            cabeceraRecibo.Columns.Add("receptorNombre", typeof(string));
            cabeceraRecibo.Columns.Add("codModalidad", typeof(string));
            cabeceraRecibo.Columns.Add("moneda", typeof(string));
            cabeceraRecibo.Columns.Add("ImporteOrigen", typeof(decimal));
            cabeceraRecibo.Columns.Add("tipoCambio", typeof(decimal));
            cabeceraRecibo.Columns.Add("importeCambioIngreso", typeof(decimal));
            cabeceraRecibo.Columns.Add("glosa", typeof(string));
            cabeceraRecibo.Columns.Add("totalDocumento", typeof(decimal));
            cabeceraRecibo.Columns.Add("usuarioRegistro", typeof(string));
            cabeceraRecibo.Columns.Add("pcRegistro", typeof(string));

            //agrega columnas tabla detalle
            detalleRecibo.Columns.Add("chaRuCodigo", typeof(string));
            detalleRecibo.Columns.Add("idCtaContable", typeof(string));
            detalleRecibo.Columns.Add("descripcion", typeof(string));
            detalleRecibo.Columns.Add("precioUnitario", typeof(decimal));
            detalleRecibo.Columns.Add("cantidad", typeof(int));
            detalleRecibo.Columns.Add("importe", typeof(decimal));

            DataRow _filaCabecera = cabeceraRecibo.NewRow();

            _filaCabecera["idLiquidacion"] = Convert.ToInt32(cn.TraerDataset("usp_ObtieneIdLiquidacion", Convert.ToInt32(lblNro.Text),
                FuenteIngreso, Convert.ToDateTime(FechaCaja).ToString("yyyyMMdd")).Tables[0].Rows[0][0]);
            _filaCabecera["nro_recibo_caja"] = Convert.ToInt32(mtbNroReciboCaja.Text.Substring(mtbNroReciboCaja.Text.IndexOf("-") + 1, mtbNroReciboCaja.Text.Length - mtbNroReciboCaja.Text.IndexOf("-") - 1));
            _filaCabecera["receptorNombre"] = TxtNombreC.Text;          
            _filaCabecera["codModalidad"] = cboModalidadPago.SelectedValue;
            _filaCabecera["moneda"] = Convert.ToDecimal(txtTipoCambio.Text)>1 ? "DOLARES":"SOLES";
            _filaCabecera["ImporteOrigen"] = Convert.ToDecimal(txtImportePago.Text);
            _filaCabecera["tipoCambio"] = Convert.ToDecimal(txtTipoCambio.Text);
            _filaCabecera["importeCambioIngreso"] = Convert.ToDecimal(txtTotalCambioDolar.Text);
            _filaCabecera["glosa"] = txtGlosa.Text;
            _filaCabecera["totalDocumento"] = Convert.ToDecimal(txtTotalDocumentoC.Text);
            _filaCabecera["usuarioRegistro"] = VariablesMetodosEstaticos.varUsuario;
            _filaCabecera["pcRegistro"] = VariablesMetodosEstaticos.ip_user + " / " + VariablesMetodosEstaticos.host_user;

            cabeceraRecibo.Rows.Add(_filaCabecera);

            if (DGVRubros.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVRubros.Rows)
                {
                    DataRow _filaDetalle = detalleRecibo.NewRow();

                    _filaDetalle["chaRuCodigo"] = Convert.ToInt32(row.Cells[2].Value);
                    _filaDetalle["idCtaContable"] = Convert.ToInt32(row.Cells[0].Value);
                    _filaDetalle["descripcion"] = row.Cells[3].Value.ToString();
                    _filaDetalle["precioUnitario"] = Convert.ToDecimal(row.Cells[4].Value);
                    _filaDetalle["cantidad"] = Convert.ToDecimal(row.Cells[7].Value);
                    _filaDetalle["importe"] = Convert.ToDecimal(row.Cells[8].Value);

                    detalleRecibo.Rows.Add(_filaDetalle);
                }
            }
        }

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVRubros.RowCount > 0)
                {
                    DGVRubros.Rows.RemoveAt(DGVRubros.CurrentRow.Index);
                    acumulado();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No existe datos para eliminar", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DGVRubros.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void txtCodigoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtCodigoMod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cboModalidadPago.SelectedValue = Convert.ToInt16(txtCodigoMod.Text.Trim() == "" ? "0" :
                    txtCodigoMod.Text.Trim()).ToString("00");
                if (cboModalidadPago.SelectedValue == null)
                {
                    cboModalidadPago.SelectedValue = "00";
                    txtCodigoMod.Focus();
                }
            }
            catch (Exception)
            {
            }

        }

        private void cboModalidadPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigoMod.Text = Convert.ToInt16(cboModalidadPago.SelectedValue).ToString("00");
            }
            catch (Exception)
            {
                txtCodigoMod.Text = "00";
            }

        }
    }
}
