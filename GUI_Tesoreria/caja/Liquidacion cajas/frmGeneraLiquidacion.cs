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
    public partial class frmGeneraLiquidacion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmGeneraLiquidacion frmInstance = null;
        private CNegocio cn = new CNegocio();
        DataSet dsResultado = new DataSet();
        DataTable dtListadoVouchers = new DataTable();
        string caja = "";

        public static frmGeneraLiquidacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmGeneraLiquidacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmGeneraLiquidacion()
        {
            InitializeComponent();
        }

        private void frmGeneraLiquidacion_Load(object sender, EventArgs e)
        {
            ListarProgramas();
            btnNuevoIngreso_Click(sender, e);
            mtbFechaLiquidacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ListarProgramas()
        {
            DataTable dtb = new DataTable();

            DataRow row;

            dtb = cn.TraerDataset("usp_ListaProgramas").Tables[0];
            row = dtb.NewRow();
            row["intProId"] = 0;
            row["varProDescripcion"] = "[-- SELECCIONE --]";

            dtb.Rows.InsertAt(row, 0);

            cboFuenteIngreso.DisplayMember = "varProDescripcion";
            cboFuenteIngreso.ValueMember = "intProId";
            cboFuenteIngreso.DataSource = dtb;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SumarColumnaTotal(string caja)
        {
            decimal totalDeposito = 0.00m;
            decimal totalDepoMas = 0.00m;

            if (caja == "01") //cementerio, albergues, comedores, alta direccion
            {
                foreach (DataGridViewRow item in this.dgvModalidadIngreso.Rows)
                {
                    totalDeposito = totalDeposito + (Convert.ToDecimal(item.Cells[6].Value) > 0 ? Convert.ToDecimal(item.Cells[6].Value) : 0.00m);
                    totalDepoMas = totalDepoMas + Convert.ToDecimal(item.Cells[7].Value);
                }
                txtDiferenciaDepositoIngreso.Text = (totalDepoMas).ToString("###,###,##0.00");
                txtTotalDeposito.Text = totalDeposito.ToString("###,###,##0.00");
                txtDiferenciaDepositoIngreso.Text= (totalDeposito - Convert.ToDecimal(txtIngresoTotalCaja.Text)).ToString("###,###,##0.00");
            }
            else if (caja == "02") //inmobiliaria
            {
                foreach (DataGridViewRow item in this.dgvIngresosInmobiliaria.Rows)
                {
                    totalDeposito = totalDeposito + (Convert.ToDecimal(item.Cells[4].Value) > 0 ? Convert.ToDecimal(item.Cells[4].Value) : 0.00m);
                    totalDepoMas = totalDepoMas + Convert.ToDecimal(item.Cells[5].Value);
                }
                txtDiferenciaDepositoIngreso.Text = (totalDepoMas).ToString("###,###,##0.00");
                txtTotalDeposito.Text = totalDeposito.ToString("###,###,##0.00");
            }
        }

        private void DeshabilitarBotones(Boolean activo)
        {
            mtbFechaCajaOrigen.Enabled = activo;
            mtbFechaLiquidacion.Enabled = activo;
            cboFuenteIngreso.Enabled = activo;
            txtTotalDeposito.Enabled = activo;
            txtTotalIgv.Enabled = activo;
            txtIngresoTotalCaja.Enabled = activo;
            txtTotalLiquidacion.Enabled = activo;
            txtTotalAGenerar.Enabled = activo;
            txtSubTotalCaja.Enabled = activo;
            btnVerIngresos.Enabled = activo;
            txtObservaciones.ReadOnly = activo;
            //btnGeneraLiquidación.Enabled = !activo;
            //btnIngresoRecibosCaja.Enabled = !activo;
        }
        private void LimpiarDatos()
        {
            int filas;
            
            mtbFechaCajaOrigen.Clear();
            mtbFechaLiquidacion.Clear();
            cboFuenteIngreso.SelectedIndex = 0;
            txtTotalDeposito.Text = "0.00";
            txtTotalIgv.Text = "0.00";
            txtIngresoTotalCaja.Text = "0.00";
            txtSubTotalCaja.Text = "0.00";
            txtDiferenciaDepositoIngreso.Text = "0.00";
            filas = dgvModalidadIngreso.Rows.Count;
            btnGeneraLiquidación.Enabled = false;
            btnIngresoRecibosCaja.Enabled = false;
            lblNro.Text = "00000";
            for (int i = 0; i <filas ; i++)
            {
                this.dgvModalidadIngreso.Rows.RemoveAt(0);
            }
            lblMensaje.Text = "";
            mtbFechaLiquidacion.Focus();
            txtObservaciones.Clear();
            txtTotalAGenerar.Text = "0.00";
            txtTotalLiquidacion.Text = "0.00";
        }

        private void AnchoFilas()
        {
            if (dgvModalidadIngreso.Rows.Count > 0)
            {
                for (int i = 0; i < dgvModalidadIngreso.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvModalidadIngreso.Rows[i];
                    row.Height = 25;
                }
            }
            if (dgvIngresosInmobiliaria.Rows.Count > 0)
            {
                for (int i = 0; i < dgvIngresosInmobiliaria.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvIngresosInmobiliaria.Rows[i];
                    row.Height = 25;
                }
            }
            
        }

        private void btnVerIngresos_Click(object sender, EventArgs e)
        {
            DateTime dateValue;

            if (DateTime.TryParse(mtbFechaLiquidacion.Text, out dateValue))
            {
                if (DateTime.TryParse(mtbFechaCajaOrigen.Text, out dateValue))
                {
                    if (Convert.ToDateTime(mtbFechaLiquidacion.Text)< Convert.ToDateTime(mtbFechaLiquidacion.Text))
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de liquidación no puede ser menor a la fecha de caja.",
                                        VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mtbFechaLiquidacion.Select();
                        return;
                    }
                    if (cn.TraerDataset("uspVerificaLiquidacion", Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd"),
                    Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd"), cboFuenteIngreso.SelectedValue).Tables[0].Rows[0][0].ToString() == "1")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de caja que intenta ingresar ya fue ingresado en otra fecha de liquidación.",
                                        VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    if (Convert.ToInt32(cboFuenteIngreso.SelectedValue)==3)
                    {
                        caja = "02"; //02 sistema inmobiliaria
                        groupBox4.Text = "Listado ingresos recaudación";
                    }
                    else
                    {
                        caja = "01";
                        groupBox4.Text= "Listado de modalidades de pago";
                    }
                    dsResultado = cn.TraerDataset("usp_consultaLiquidaciones",
                        Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd"),
                        Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd"),
                        cboFuenteIngreso.SelectedValue,
                        VariablesMetodosEstaticos.intAnnioActual.ToString(),
                        caja);
                    if (dsResultado.Tables[0].Rows.Count* dsResultado.Tables[1].Rows.Count > 0)
                    {
                        txtSubTotalCaja.Text = Convert.ToDecimal(dsResultado.Tables[0].Rows[0][1]).ToString("###,###,##0.00");
                        txtTotalIgv.Text = Convert.ToDecimal(dsResultado.Tables[0].Rows[0][2]).ToString("###,###,##0.00");
                        txtIngresoTotalCaja.Text = Convert.ToDecimal(dsResultado.Tables[0].Rows[0][3]).ToString("###,###,##0.00");                      
                        lblNro.Text = Convert.ToInt32(dsResultado.Tables[0].Rows[0][0]).ToString("000000");
                        txtObservaciones.Text = dsResultado.Tables[0].Rows[0][5].ToString();
                        
                        if (dsResultado.Tables[0].Rows[0][4].ToString()=="0")
                        {
                            lblMensaje.Text = "Por Generar Nº de Liquidación";
                            btnGeneraLiquidación.Enabled = true;
                            txtObservaciones.ReadOnly = false;
                            btnIngresoRecibosCaja.Enabled = false;
                        }
                        else if (dsResultado.Tables[0].Rows[0][4].ToString() == "1")
                        {
                            lblMensaje.Text = "Nº de Liquidación Generado";
                            txtObservaciones.ReadOnly = true;
                            btnGeneraLiquidación.Enabled = true;
                            btnIngresoRecibosCaja.Enabled = false;
                        }
                        else if (dsResultado.Tables[0].Rows[0][4].ToString() == "2")
                        {
                            lblMensaje.Text = "Nº de Liquidación Generado";
                            txtObservaciones.ReadOnly = true;
                            btnGeneraLiquidación.Enabled = false;
                            btnIngresoRecibosCaja.Enabled = true;
                        }
                        if (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 3)
                        {
                            //02 sistema inmobiliaria
                            dgvIngresosInmobiliaria.Visible = true;
                            dgvModalidadIngreso.Visible = false;
                            dgvIngresosInmobiliaria.DataSource = dsResultado.Tables[1];
                        }
                        else
                        {
                            dgvIngresosInmobiliaria.Visible = false;
                            dgvModalidadIngreso.Visible = true;
                            dgvModalidadIngreso.DataSource = dsResultado.Tables[1];
                        }
                        
                        AnchoFilas();
                        SumarColumnaTotal(caja);
                        txtTotalLiquidacion.Text = Convert.ToDecimal(cn.EjecutarSqlDTS("select isnull(sum(diferenciaDeposito),0.00) as TotalLiquidacion from liquidacionCajaPrincipalCabecera where estado=1 and year(fechaRegistro)=year(GETDATE()) and numeroLiquidacion=" + Convert.ToInt32(dsResultado.Tables[0].Rows[0][0]) + "").Tables[0].Rows[0][0]).ToString("###,###,##0.00");
                         txtTotalAGenerar.Text = (Convert.ToDecimal(txtTotalLiquidacion.Text) + Convert.ToDecimal(txtDiferenciaDepositoIngreso.Text)).ToString("###,###,##0.00");
                        DeshabilitarBotones(false);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese una fecha de caja válida", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbFechaCajaOrigen.Focus();                    return;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese una fecha de liquidación válida", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbFechaLiquidacion.Focus();
                return;
            }
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            string fechaLiq;
            fechaLiq = mtbFechaLiquidacion.Text;
            DeshabilitarBotones(true);
            LimpiarDatos();
            mtbFechaLiquidacion.Text = fechaLiq;
            //mtbFechaLiquidacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
            mtbFechaCajaOrigen.Focus();
            dgvIngresosInmobiliaria.Visible = false;
            dgvModalidadIngreso.Visible = true;
            groupBox4.Text = "Listado de modalidades de pago";
        }

        private void dgvModalidadIngreso_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.verdepositos.Width;
                var h = Properties.Resources.verdepositos.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.verdepositos, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvModalidadIngreso_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.ToolTipText = "Ver listado de depósitos.";
            }
            else if (e.ColumnIndex == 8)
            {
                if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "DM")
                {
                    e.ToolTipText = "Tiene Depósito de más .";
                } 
                else if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "CO")
                {
                    e.ToolTipText = "Tiene Depósito COMPLETO.";
                }
                else if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "PA")
                {
                    e.ToolTipText = "Tiene Depósito PARCIAL.";
                }
                else if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "SD")
                {
                    e.ToolTipText = "No tiene depósitos asignados.";
                }
                else if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "CD")
                {
                    e.ToolTipText = "Cuenta con deposito.";
                }
            }
            else if (e.ColumnIndex == 9)
            {
                if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "VO")
                {
                    e.ToolTipText = "Depósito ingresado en el formulario de depósitos.";
                }
                else if (dgvModalidadIngreso.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "RE")
                {
                    e.ToolTipText = "Depósito ingresado junto al documento origen.";
                }
            }
        }

        private void dgvModalidadIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            int index = dgvModalidadIngreso.CurrentRow.Index;
            DataTable dtResultadoBusqueda = new DataTable();

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (this.dgvModalidadIngreso.Columns[e.ColumnIndex].Name == "Depositos")
                {
                    dtResultadoBusqueda = cn.TraerDataset("usp_ListaDepositosdeEfectivo", cboFuenteIngreso.SelectedValue,
                        //Convert.ToInt32(dgvModalidadIngreso.Rows[index].Cells[2].Value) == 11 ? 11 : 3,
                        dgvModalidadIngreso.Rows[index].Cells[2].Value,
                        Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyMMdd"),
                        dgvModalidadIngreso.Rows[index].Cells[9].Value.ToString()).Tables[0];

                        if (dtResultadoBusqueda.Rows.Count>0)
                        {
                            frmListadoDepositosLiquidacion frmDetalle = new frmListadoDepositosLiquidacion
                            {
                                dtListadoVouchers = dtResultadoBusqueda,
                                TipoCaja = caja,
                                _Anio = mtbFechaLiquidacion.Text.Substring(6, 4),
                                _Mes = mtbFechaLiquidacion.Text.Substring(3, 2),
                                _FechaLiq = Convert.ToDateTime(mtbFechaLiquidacion.Text),
                                _Fuente = Convert.ToInt16(cboFuenteIngreso.SelectedValue).ToString("00")
                            };
                            //verifica si el voucher seleccionado ya se encuentra en una liquidación para que
                            //no se pueda modificar.
                            frmDetalle.Existe = Convert.ToBoolean(cn.TraerDataset("usp_BuscaLiquidacion", Convert.ToInt32(lblNro.Text),
                            cboFuenteIngreso.SelectedValue, Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd"),
                            Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd")).Tables[0].Rows[0][0]);

                            frmDetalle.ShowDialog();

                            if (frmDetalle.Save__==true)
                            {
                                btnVerIngresos_Click(sender, e);
                            }
                        }                   
                }
            }
            AnchoFilas();
        }

        private void btnGeneraLiquidación_Click(object sender, EventArgs e)
        {
            DataTable dtResultadoLiq = new DataTable();

            int idLiquidacion = 0;
            dtResultadoLiq = cn.EjecutarSqlDTS("select estado from liquidacionPrincipal where numeroLiquidacion in (select numeroLiquidacion " + 
                "from liquidacionCajaPrincipalCabecera where intProId = "+cboFuenteIngreso.SelectedValue+ 
                " and CONVERT(varchar(10), fechaLiquidacion, 112) = '"+mtbFechaLiquidacion.Text+ "'  AND CONVERT(varchar(10), fechaCajaOrigen, 112) ='"+
                mtbFechaCajaOrigen.Text+"' and estado = 1)").Tables[0];
            try
            {
                if (dtResultadoLiq.Rows.Count > 0)
                {
                    if (dtResultadoLiq.Rows[0][0].ToString() == "True")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ya no se puede generar mas liquidaciones con la fecha de liquidación ingresada debido a que ya se encuentra cerrada.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                dtResultadoLiq = new DataTable();

                foreach (DataGridViewRow item in dgvModalidadIngreso.Rows)
                {
                    if (item.Cells[2].Value.ToString() != "14")
                    {
                        if (item.Cells[8].Value.ToString() == "PA" || item.Cells[8].Value.ToString() == "SD")
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Hay pagos parciales(PA) o pagos sin deposito(SD), no se puede generar la liquidación.", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }   
                }

                //if (Convert.ToInt32(cboFuenteIngreso.SelectedValue)==3)
                //{
                //    decimal total;
                //    total = 0.00m;
                //    foreach (DataGridViewRow item in dgvIngresosInmobiliaria.Rows)
                //    {
                //        total = Convert.ToDecimal(item.Cells[4].Value);
                //        if (total != Convert.ToDecimal(txtTotalDeposito.Text))
                //        {
                //            DevComponents.DotNetBar.MessageBoxEx.Show("Ha ocurrido un error con la diferencia de deposito, contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //            return;
                //        }
                //    }                   
                //}
                //else
                //{
                //    decimal total;
                //    total = 0.00m;
                //    foreach (DataGridViewRow item in dgvModalidadIngreso.Rows)
                //    {
                //        total = total + Convert.ToDecimal(item.Cells[5].Value);
                //    }

                //    if (total != Convert.ToDecimal(txtTotalDeposito.Text))
                //    {
                //        DevComponents.DotNetBar.MessageBoxEx.Show("Ha ocurrido un error con la diferencia de deposito, contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
                //}

                if (Convert.ToDecimal(txtDiferenciaDepositoIngreso.Text)<0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("La diferencia de depositos de más esta en negativo, verifique si no tiene pagos parciales(PA).", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (cn.TraerDataset("usp_VerificaFechaLiquidacion", Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd")).Tables[0].Rows[0][0].ToString()=="0")
                //{
                //    DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de liquidación ingresada no puede ser menor a la última liquidación ingresada.", VariablesMetodosEstaticos.encabezado,
                //           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                /*CAJA=02 ES DE INMOBILIARIA Y VERIFICA QUE A TODAS LAS LIQUIDACIONES DE LOS COBRADORES NO LE FALTE INGRESAR UN VOUCHER*/
                if (caja=="02")
                {
                    DataTable dtResu = new DataTable();
                    dtResu = cn.TraerDataset("usp_SelectLiquidacionDetalleCajero",
                        Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd")).Tables[0];
                    if (dtResu.Rows.Count <= 0) return;
                    foreach (DataRow item in dtResu.Rows)
                    {
                        if (Convert.ToDecimal(item[1])-Convert.ToDecimal(item[2]) < 0 )
                        {
                            if (Convert.ToDecimal(item[1]) + Convert.ToDecimal(item[3]) - Convert.ToDecimal(item[2]) < 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Falta ingresar el voucher en la liquidacion de uno o mas cobradores, verifíque.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                return;
                            }
                        }
                    }
                }
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de registrar la liquidacion Nro" + " " + lblNro.Text + " ", VariablesMetodosEstaticos.encabezado,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    dtResultadoLiq = cn.TraerDataset("usp_IngresoLiquidacion", Convert.ToInt32(lblNro.Text), cboFuenteIngreso.SelectedValue,
                    Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd"),
                    Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd"), txtIngresoTotalCaja.Text, txtTotalDeposito.Text,
                    txtObservaciones.Text, VariablesMetodosEstaticos.varNombreUser, 
                    VariablesMetodosEstaticos.host_user+"/"+VariablesMetodosEstaticos.ip_user).Tables[0];
                    idLiquidacion = Convert.ToInt32(dtResultadoLiq.Rows[0][0]);

                    if (idLiquidacion > 0)
                    {
                        foreach (DataGridViewRow item in dgvModalidadIngreso.Rows)
                        {
                            cn.EjecutarSP("usp_IngresoLiquidacionDetalle", idLiquidacion, item.Cells[2].Value, item.Cells[5].Value, item.Cells[8].Value);
                        }
                        DevComponents.DotNetBar.MessageBoxEx.Show("La liquidación fue generado correctamente", VariablesMetodosEstaticos.encabezado, 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGeneraLiquidación.Enabled = false;
                        btnIngresoRecibosCaja.Enabled = true;
                        txtObservaciones.ReadOnly = true;
                        btnVerIngresos_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbFechaLiquidacion.Focus();
            }           
        }

        private void btnIngresoRecibosCaja_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtResu = new DataTable();
                frmReciboCajaPrincipal win = new frmReciboCajaPrincipal();
                dtResu = cn.EjecutarSqlDTS("select NOMBREOFICINASECUNDARIA from SUNATFE.dbo.SISTEMAS WHERE ID = " +
                    (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 1 ? "7" :
                    (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 2 ? "4" :
                    (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 3 ? "1" :
                    (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 4 ? "2" :
                    (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 5 ? "5" :
                    (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 6 ? "6" : "0")))))) + "").Tables[0];
                if (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 5 || Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 6)
                {
                    win.Glosa = cn.TraerDataset("USP_DETALLE_COMEDORES", Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd"),
                        cboFuenteIngreso.SelectedValue).Tables[0].Rows[0][0].ToString();
                }
                else if (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 4)
                {
                    win.Glosa = cn.TraerDataset("USP_DETALLE_CEMENTERIO", Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd"),
                        cboFuenteIngreso.SelectedValue).Tables[0].Rows[0][0].ToString();
                }
                else if (Convert.ToInt32(cboFuenteIngreso.SelectedValue) == 2)
                {
                    win.Glosa = cn.TraerDataset("USP_DETALLE_ALBERGUES", Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd"),
                        cboFuenteIngreso.SelectedValue).Tables[0].Rows[0][0].ToString();
                }
                win.FuenteIngreso = Convert.ToInt32(cboFuenteIngreso.SelectedValue);
                win.Nombre = dtResu.Rows.Count > 0 ? dtResu.Rows[0][0].ToString() : "";
                win.NroLiquidacion = Convert.ToInt32(lblNro.Text);//.ToString("0000000");
                win.FechaCaja = mtbFechaCajaOrigen.Text;
                win.FechaLiquidacion = mtbFechaLiquidacion.Text;
                win.TotalLiquidacion = Convert.ToDecimal(txtTotalDeposito.Text);
                win.ShowDialog();
                btnVerIngresos_Click(sender, e);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbFechaLiquidacion.Focus();
            }
            
        }

        private void txtTotalAGenerar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvIngresosInmobiliaria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.verdepositos.Width;
                var h = Properties.Resources.verdepositos.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.verdepositos, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvIngresosInmobiliaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvIngresosInmobiliaria.CurrentRow.Index;
            DataTable dtResultadoBusqueda = new DataTable();

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (this.dgvIngresosInmobiliaria.Columns[e.ColumnIndex].Name == "verdepo")
                {
                    dtResultadoBusqueda = cn.TraerDataset("usp_ListaDepositosdeEfectivo_dgai", 
                        Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd")).Tables[0];

                    if (dtResultadoBusqueda.Rows.Count > 0)
                    {
                        frmListadoDepositosLiquidacion frmDetalle = new frmListadoDepositosLiquidacion
                        {
                            dtListadoVouchers = dtResultadoBusqueda,
                            TipoCaja = caja,
                            _Anio = mtbFechaLiquidacion.Text.Substring(6, 4),
                            _Mes = mtbFechaLiquidacion.Text.Substring(3, 2),
                            _FechaLiq = Convert.ToDateTime(mtbFechaLiquidacion.Text),
                            _Fuente = Convert.ToInt16(cboFuenteIngreso.SelectedValue).ToString("00")
                        };
                        frmDetalle.Existe = Convert.ToBoolean(cn.TraerDataset("usp_BuscaLiquidacion", Convert.ToInt32(lblNro.Text),
                            cboFuenteIngreso.SelectedValue, Convert.ToDateTime(mtbFechaLiquidacion.Text).ToString("yyyyMMdd"),
                            Convert.ToDateTime(mtbFechaCajaOrigen.Text).ToString("yyyyMMdd")).Tables[0].Rows[0][0]);
                        frmDetalle.ShowDialog();
                        if (frmDetalle.Save__ == true)
                        {
                            btnVerIngresos_Click(sender, e);
                        }
                    }
                }
            }
            AnchoFilas();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {

        }
    }
}
