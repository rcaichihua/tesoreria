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
    public partial class frmReciboCajaPrincipalModifica : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public int NroLiquidacion { get; set; }
        public int IdCaja { get; set; }
        public string NroReciboCaja { get; set; }
        public int FuenteIngreso { get; set; }
        public string FechaLiquidacion { get; set; }
        public string FechaCaja { get; set; }
        public decimal TotalLiquidacion { get; set; }
        public string usuario { get; set; }
        public string nombreReceptor { get; set; }
        public string ModalidadPago { get; set; }
        public decimal ImporteIngreso { get; set; }
        public decimal tc { get; set; }
        public decimal importeCambio { get; set; }
        public string glosa { get; set; }
        public DataSet DetalleRecibo { get; set; }

        decimal SaldoLiquidacion = 0.00m;

        private DataTable cabeceraRecibo;
        private DataTable detalleRecibo;

        CNegocio cn = new CNegocio();

        public frmReciboCajaPrincipalModifica()
        {
            InitializeComponent();
        }

        private void frmReciboCajaPrincipalModifica_Load(object sender, EventArgs e)
        {
            cargarModalidadPago();

            lblNro.Text = NroLiquidacion.ToString("000000");
            txtFechaCajaC.Text = FechaCaja;
            txtFechaLiquidacionC.Text = FechaLiquidacion;
            txtTotalLiquidacionC.Text = TotalLiquidacion.ToString("###,###,##0.00");
            mtbNroReciboCaja.Text = "001" + "-" + NroReciboCaja;
            txtUsuarioC.Text = usuario;
            TxtNombreC.Text = nombreReceptor;
            cboModalidadPago.SelectedValue = ModalidadPago;
            txtImportePago.Text = ImporteIngreso.ToString("###,###,##0.00");
            txtTipoCambio.Text=tc.ToString("###,###,##0.000");
            txtTotalCambioDolar.Text=importeCambio.ToString("###,###,##0.00");
            txtGlosa.Text = glosa;
            this.DGVRubros.AutoGenerateColumns = false;
            //BuscaSaldoLiquidacion();

            bool impuesto = false;

            impuesto = Convert.ToBoolean(cn.TraerDataset("usp_s_obtiene_flag_impuesto", 3).Tables[0].Rows[0][0]);

            llamaDetalle(DetalleRecibo, impuesto);
            BuscaSaldoLiquidacion();
            //DGVRubros.DataSource = DetalleRecibo;
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
        private void BuscaSaldoLiquidacion()
        {
            txtSaldoC.Text = Convert.ToDecimal(cn.TraerDataset("usp_ObtieneSaldoLiquidacion", Convert.ToInt32(lblNro.Text),
                FuenteIngreso, Convert.ToDateTime(FechaCaja).ToString("yyyyMMdd")).Tables[0].Rows[0][0]).ToString("###,###,##0.00");
            SaldoLiquidacion = Convert.ToDecimal(txtSaldoC.Text);
            //if (Convert.ToDecimal(txtSaldoC.Text) <= 0)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Ya no se pueden generar mas recibos de caja, ya no hay saldo disponible.", VariablesMetodosEstaticos.encabezado,
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Close();
            //}

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

        private void txtCodigoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de cancelar? si presiona [SI] saldrá de la ventana.", VariablesMetodosEstaticos.encabezado,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                this.Close();
            }
        }

        private bool Validaciones()
        {
            int nrorecibo;
            bool resu = false;

            if (int.TryParse((mtbNroReciboCaja.Text.Substring(mtbNroReciboCaja.Text.IndexOf("-") + 1, mtbNroReciboCaja.Text.Length - mtbNroReciboCaja.Text.IndexOf("-") - 1)), out nrorecibo))
            {
                if (mtbNroReciboCaja.Text.Length == 10)
                {
                    if (TxtNombreC.Text.Trim() != "")
                    {
                        if (cboModalidadPago.SelectedIndex != 0)
                        {
                            if (Convert.ToDecimal(txtTotalCambioDolar.Text) == Convert.ToDecimal(txtTotalDocumentoC.Text))
                            {
                                DataTable dt = new DataTable();
                                dt = cn.EjecutarSqlDTS("select COUNT(*) from reciboCajaPrincipalCabecera where nro_recibo_caja=" + Convert.ToInt32(mtbNroReciboCaja.Text.Substring(mtbNroReciboCaja.Text.IndexOf("-") + 1, mtbNroReciboCaja.Text.Length - mtbNroReciboCaja.Text.IndexOf("-") - 1)).ToString() + "").Tables[0];
                                if (Convert.ToInt32(dt.Rows[0][0]) > 0 && mtbNroReciboCaja.Text != "001" + "-" + NroReciboCaja)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("El Nº de recibo " + mtbNroReciboCaja.Text + " ya se encuentra registrado. Verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                                            MessageBoxIcon.Warning);
                                    resu = false;
                                }
                                else
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
            _filaCabecera["moneda"] = Convert.ToDecimal(txtTipoCambio.Text) > 1 ? "DOLARES" : "SOLES";
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

        private void txtTipoCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
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
            DataTable dtBuscaNroRecibo = new DataTable();

            if (cn.EjecutarSqlDTS("select a.estado from liquidacionPrincipal a inner join liquidacionCajaPrincipalCabecera b on a.numeroLiquidacion=b.numeroLiquidacion where CONVERT(varchar(10), a.fechaLiquidacion,112)='" +
                Convert.ToDateTime(txtFechaLiquidacionC.Text).ToString("yyyyMMdd") +"'").Tables[0].Rows[0][0].ToString()== "True and intProId="+FuenteIngreso+ " and b.estado=1")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se puede modificar debido a que la fecha de liquidación ya se encuentra cerrada.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (!Validaciones()) return;

            ArmarTablasCabeceraDetalle();
            DataSet resultado = new DataSet();

            resultado = cn.ActualizaReciboPrincipal("usp_actualiza_ingresosCaja",IdCaja, cabeceraRecibo, detalleRecibo);

            int idReciboCabecera = 0;

            idReciboCabecera = Convert.ToInt32(resultado.Tables[0].Rows[0][0]);

            if (idReciboCabecera == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error al actualizar el recibo, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Recibo actualizado correctamente.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            
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
            winAddRub.EsCentral = true;//
            winAddRub.FuenteIngreso = FuenteIngreso;//
            winAddRub.SaldoDocumento = SaldoLiquidacion;
            winAddRub.TotalDocumento = Convert.ToDecimal(txtTotalDocumentoC.Text);
            winAddRub.Modifica = true;
            dtsRubros = winAddRub.traerFormulario();

            llamaDetalle(dtsRubros, impuesto);

            //bool impuesto = false;

            //impuesto = Convert.ToBoolean(cn.TraerDataset("usp_s_obtiene_flag_impuesto", 3).Tables[0].Rows[0][0]);

            //DataSet dtsRubros;

            //frmAgregarRubro winAddRub = new frmAgregarRubro();
            //winAddRub.liquidacion = true;
            //winAddRub.EsCentral = true;
            //winAddRub.FuenteIngreso = FuenteIngreso;
            //winAddRub.SaldoDocumento = SaldoLiquidacion;
            //winAddRub.TotalDocumento = Convert.ToDecimal(txtTotalDocumentoC.Text);
            //dtsRubros = winAddRub.traerFormulario();
            //llamaDetalle(dtsRubros, impuesto);
        }

        private void llamaDetalle(DataSet dtsRubros, bool imp)
        {
            for (int i = 0; i < dtsRubros.Tables[0].Rows.Count; i++)
            {
                if (dtsRubros.Tables[0].Rows.Count > 0)
                {
                    TraerDatosDetalle(dtsRubros.Tables[0].Rows[i][0].ToString(), Convert.ToInt32(dtsRubros.Tables[0].Rows[i][1]), 
                        Convert.ToInt32(dtsRubros.Tables[0].Rows[i][2].ToString()).ToString("0000"),
                                  dtsRubros.Tables[0].Rows[i][3].ToString(), Convert.ToDecimal(dtsRubros.Tables[0].Rows[i][4])
                                  , Convert.ToInt32(dtsRubros.Tables[0].Rows[i][5]), Convert.ToDecimal(dtsRubros.Tables[0].Rows[i][6]), imp, dtsRubros.Tables[0].Rows[i][7].ToString());
                }
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
            acumulado2();
        }

        private void acumulado2()
        {
            try
            {
                decimal tot = 0.00m;

                for (int i = 0; i < DGVRubros.RowCount; i++)
                {
                    tot = tot + Convert.ToDecimal(DGVRubros.Rows[i].Cells[4].Value);
                }
                SaldoLiquidacion = SaldoLiquidacion==0 ? 0.00m: SaldoLiquidacion - tot;
                txtTotalDocumentoC.Text = tot.ToString("##,##0.00");
                //txtImportePago.Text = tot.ToString("##,##0.00");
                txtSaldoC.Text = SaldoLiquidacion.ToString("###,###,##0.00");//(SaldoLiquidacion==0 ? 0: SaldoLiquidacion - tot).ToString("###,##0.00");
            }
            catch (Exception)
            {
            }
        }
        private void acumulado(decimal tot2)
        {
            try
            {
                decimal tot = 0.00m;

                for (int i = 0; i < DGVRubros.RowCount; i++)
                {
                    tot = tot + Convert.ToDecimal(DGVRubros.Rows[i].Cells[4].Value);
                }

                txtTotalDocumentoC.Text = tot.ToString("##,##0.00");
                //txtImportePago.Text = tot.ToString("##,##0.00");
                SaldoLiquidacion = SaldoLiquidacion + tot2;
                txtSaldoC.Text = (SaldoLiquidacion).ToString("###,###,##0.00");//(SaldoLiquidacion == 0 ? 0 : SaldoLiquidacion - tot).ToString("###,##0.00");
            }
            catch (Exception)
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int index = DGVRubros.CurrentRow.Index;

                decimal tot = 0.00m;

                for (int i = 0; i < DGVRubros.RowCount; i++)
                {
                    tot = tot + Convert.ToDecimal(DGVRubros.Rows[index].Cells[4].Value);
                }

                if (DGVRubros.RowCount > 0)
                {
                    DGVRubros.Rows.RemoveAt(index);
                    acumulado(tot);
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
    }
}
