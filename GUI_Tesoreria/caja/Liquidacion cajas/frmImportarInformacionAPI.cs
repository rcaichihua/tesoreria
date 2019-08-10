using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmImportarInformacionAPI : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmImportarInformacionAPI()
        {
            InitializeComponent();
        }
        DataTable tbapi;
        //string cadena = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = \\192.168.1.192\Archivos_Maliciosos\teso\Api99\ ; Extended Properties = dBase IV; user ID=;Password=";
        OdbcConnectionStringBuilder csbOdbc = new OdbcConnectionStringBuilder()
        {
            Dsn = "PSAP_FOX_DBF"
        };

        DataSet ds = new DataSet();

        CNegocio cn = new CNegocio();

        private void BtnSalirC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            int valorInt;
            valorInt = 0;
            if (!int.TryParse(txtNroPliego.Text, out valorInt))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor valido para Nro de Pliego.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                txtNroPliego.Focus();
                return;
            }

            if (cn.EjecutarSqlDTS("select * from  [dbo].[apii_con] where fch_pago='" +
                dtpFechaLiquidacion.Value.ToString("yyyy-MM-dd") + "'").Tables[0].Rows.Count > 0)// and donume='"+ Convert.ToInt32(txtNroPliego.Text).ToString("000000") + "'").Tables[0].Rows.Count>0)
            {
                string message = "Se han encontrado datos en la fecha de liquidacion seleccionada. " + Environment.NewLine + 
                    "¿Esta seguro de continuar con la importación?"+Environment.NewLine + "Si continua la información ya almacenada de eliminara.";
                string caption = "...:::Salir del Sistema:::...";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cn.EjecutarUD("delete from [dbo].[apii_con] where fch_pago='" +
                dtpFechaLiquidacion.Value.ToString("yyyy-MM-dd") + "' and donume='" + Convert.ToInt32(txtNroPliego.Text).ToString("000000") + "'");

                    cn.EjecutarUD("delete from documentosIngresoDetalle where docIngresoID in " +
                            " (select docIngresoID from documentosIngresoCabecera where NumeroLiquidacion in ( " +
                            " select numeroLiquidacion from liquidacionCajaPrincipalCabecera " +
                            " where convert(varchar(8), fechaLiquidacion, 112) = '" +
                            dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and " +
                            " fechaCajaOrigen = '" + dtpFechaCaja.Value.ToString("yyyyMMdd") +
                            "' and estado = 1 and intProId = 3))");

                    cn.EjecutarUD("delete from documentosIngresoCabecera where NumeroLiquidacion in ( " +
                                " select numeroLiquidacion from liquidacionCajaPrincipalCabecera " +
                                " where convert(varchar(8), fechaLiquidacion, 112) = '" +
                                dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and " +
                                " fechaCajaOrigen = '" + dtpFechaCaja.Value.ToString("yyyyMMdd") +
                                "' and estado = 1 and intProId = 3)");

                    EjecutaBusqueda();
                }
            }
            else
            {
                EjecutaBusqueda();
            }
        }

        private void EjecutaBusqueda()
        {
            filtroCuenta();
        }

        private void filtroCuenta()
        {
            DataTable dt = new DataTable();
            int id_Liq, num_Liq;
            id_Liq = 0;
            num_Liq = 0;

            dt = cn.EjecutarSqlDTS("select numeroLiquidacion,idLiquidacion from liquidacionCajaPrincipalCabecera " + 
                "where convert(varchar(8),fechaLiquidacion,112)='" +
               dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and fechaCajaOrigen='" +
               dtpFechaCaja.Value.ToString("yyyyMMdd") + "' and estado=1 and intProId=3").Tables[0];

            if (dt.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay información de la liquidación segun la fecha de caja y fecha de liquidacoón.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                return;
            }
            num_Liq = Convert.ToInt32(dt.Rows[0][0]);//numero de liquidacion
            id_Liq = Convert.ToInt32(dt.Rows[0][1]);//id de liquidacion

            string consultaFactura = @"exec USP_IMPORTA_LIQUIDACION '"+dtpFechaLiquidacion.Value.ToString("yyyyMMdd")+"',"+
                num_Liq+","+id_Liq+",'"+ VariablesMetodosEstaticos.varUsuario+"','"+ VariablesMetodosEstaticos.ip_user+
                "/"+ VariablesMetodosEstaticos.host_user + "'";

            filtroGenericoConsulta(consultaFactura);
        }

        private void filtroGenericoConsulta(string query)
        {
            DataTable idCtaDt;
            try
            {
                idCtaDt = cn.EjecutarSqlDTS(query).Tables[0];
                dgvListado.DataSource = idCtaDt;
                dgvListado.Refresh();
                //using (OdbcConnection connOdbc = new OdbcConnection(csbOdbc.ToString()))
                //{
                //    connOdbc.Open();

                //    ds = new DataSet();
                //    DataTable dt = new DataTable();
                //    //string fechaFiltro = "{^" + Convert.ToDateTime("29/04/2016").ToString("yyyy-MM-dd") + "}"; 
                //    //query = "select cod_inmb,num_contr,aa,mm,tip_docu,nro_docu,fch_pago,tip_pago,tip_movi,tip_pago,codigo,codigor,monto,fdepo,flag,donume from apii_con where fch_pago = #2018-12-14#";
                //    OdbcDataAdapter adapter2 = new OdbcDataAdapter(query, connOdbc);
                //    adapter2.Fill(ds);
                //    dt = ds.Tables[0];
                //    dt.Columns.Add("id_cta_contable").SetOrdinal(10);
                //    connOdbc.Close();
                //    decimal total;
                //    total = 0.00m;
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        total = total + Convert.ToDecimal(row["monto"]);

                //        idCtaDt = new DataTable();
                //        idCtaDt = cn.EjecutarSqlDTS("select id_cuenta_contable from tb_cta_contable where codigoCuenta='" + row["codigo"].ToString().Trim() + "'").Tables[0];

                //        row["id_cta_contable"] = idCtaDt.Rows.Count <= 0 ? 0 : Convert.ToInt32(idCtaDt.Rows[0][0]);


                //        DataRow _filaCabecera = tbapi.NewRow();

                //        _filaCabecera["cod_inmb"] = row["cod_inmb"];
                //        _filaCabecera["num_contr"] = row["num_contr"];
                //        _filaCabecera["aa"] = row["aa"];
                //        _filaCabecera["mm"] = row["mm"];
                //        _filaCabecera["tip_docu"] = row["tip_docu"];
                //        _filaCabecera["nro_docu"] = row["nro_docu"];
                //        _filaCabecera["fch_pago"] = Convert.ToDateTime(row["fch_pago"]).ToString("yyyyMMdd");
                //        _filaCabecera["tip_movi"] = row["tip_movi"];
                //        _filaCabecera["tip_pago"] = row["tip_pago"];
                //        _filaCabecera["id_cta"] = row["id_cta_contable"];
                //        _filaCabecera["codigo"] = row["codigo"];
                //        _filaCabecera["codigor"] = row["codigor"];
                //        _filaCabecera["monto"] = row["monto"];
                //        _filaCabecera["fdepo"] = row["fdepo"];
                //        _filaCabecera["flag"] = row["flag"];
                //        _filaCabecera["donume"] = row["donume"];

                //        tbapi.Rows.Add(_filaCabecera);
                //    }
                //    if (ds.Tables[0].Rows.Count <= 0)
                //    {
                //        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos con la fecha de liquidación ingresada." +
                //            dtpFechaLiquidacion.Value.ToString("dd/MM/yyyy") + ", verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK);
                //        return;
                //    }

                //    //dgvLiquidaciones.DataSource = ds.Tables[0];
                //    tctTotal.Text = total.ToString("###,###,###,##0.00");
                //}
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void GBPago_Enter(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (cn.EjecutarSqlDTS("select * from  [dbo].[apii_con] where fch_pago='" +
                dtpFechaLiquidacion.Value.ToString("yyyy-MM-dd") + "' and donume='"+ Convert.ToInt32(txtNroPliego.Text).ToString("000000") + "'").Tables[0].Rows.Count>0)
            {
                string message2 = "Se han encontrado datos en la fecha de liquidacion seleccionada. " + Environment.NewLine +
                    "¿Esta seguro de continuar con la importación?" + Environment.NewLine + "Si continua la información ya almacenada de eliminara.";
                string caption2 = "...:::Salir del Sistema:::...";
                MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                DialogResult result2;

                result2 = DevComponents.DotNetBar.MessageBoxEx.Show(message2, caption2, buttons2, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result2 == System.Windows.Forms.DialogResult.Yes)
                {
                    cn.EjecutarUD("delete from [dbo].[apii_con] where fch_pago='" +
                dtpFechaLiquidacion.Value.ToString("yyyy-MM-dd") + "' and donume='" + Convert.ToInt32(txtNroPliego.Text).ToString("000000") + "'");

                    cn.EjecutarUD("delete from documentosIngresoDetalle where docIngresoID in " +
                            " (select docIngresoID from documentosIngresoCabecera where NumeroLiquidacion in ( " + 
                            " select numeroLiquidacion from liquidacionCajaPrincipalCabecera " +
                            " where convert(varchar(8), fechaLiquidacion, 112) = '"+
                            dtpFechaLiquidacion.Value.ToString("yyyyMMdd")+"' and " +
                            " fechaCajaOrigen = '"+ dtpFechaCaja.Value.ToString("yyyyMMdd") + 
                            "' and estado = 1 and intProId = 3))");

                    cn.EjecutarUD("delete from documentosIngresoCabecera where NumeroLiquidacion in ( " +
                                " select numeroLiquidacion from liquidacionCajaPrincipalCabecera " +
                                " where convert(varchar(8), fechaLiquidacion, 112) = '"+ 
                                dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and " +
                                " fechaCajaOrigen = '"+ dtpFechaCaja.Value.ToString("yyyyMMdd") + 
                                "' and estado = 1 and intProId = 3)");
                    Importa();


                }
            }   
            else
            {
                Importa();
            }
            
           
        }
        private void Importa()
        {
            int id_Liq, num_Liq;
            id_Liq = 0;
            num_Liq = 0;
            DataTable dt = new DataTable();
 
            dt = cn.EjecutarSqlDTS("select numeroLiquidacion,idLiquidacion from liquidacionCajaPrincipalCabecera where convert(varchar(8),fechaLiquidacion,112)='" +
               dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and fechaCajaOrigen='" +
               dtpFechaCaja.Value.ToString("yyyyMMdd") + "' and estado=1 and intProId=3").Tables[0];

            if (dt.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay información de la liquidación segun la fecha de caja y fecha de liquidacoón.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                return;
            }
            num_Liq = Convert.ToInt32(dt.Rows[0][0]);//numero de liquidacion
            id_Liq = Convert.ToInt32(dt.Rows[0][1]);//id de liquidacion

            if (tbapi != null)
            {
                if (tbapi.Rows.Count <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No ha realizado la importación del API, importe e intente de nuevo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No ha realizado la importación del API, importe e intente de nuevo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                return;
            }

            decimal total;
            total = 0.00m;

            foreach (DataRow item in tbapi.Rows)
            {
                total = total + Convert.ToDecimal(item["monto"]);
                item["fdepo"] = Convert.ToDateTime(item["fdepo"]).ToString("yyyyMMdd");
            }

            string message = "¿Esta seguro de realizar la importación al módulo de tesoreria.? " + Environment.NewLine +
                    "El monto total que se va migrar es :" + Environment.NewLine + total.ToString("###,###,###,##0.00");
            string caption = VariablesGlobales.NombreMensajes;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show(num_Liq.ToString()+" "+ id_Liq.ToString());
                frmMuestraDatatable win = new frmMuestraDatatable();
                win.datos = tbapi;
                win.ShowDialog();

                if (cn.IngresarLiquiApi("usp_ingresar_appi_contable", num_Liq, VariablesMetodosEstaticos.varUsuario,
                VariablesMetodosEstaticos.host_user, tbapi, id_Liq).Tables[0].Rows[0][0].ToString() == "1")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Iformación exportado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                }
            }
        }
        private void frmImportarInformacionAPI_Load(object sender, EventArgs e)
        {
            
        }

        private void btnImportaLiquidacionInmobiliaria_Click(object sender, EventArgs e)
        {          
            DataTable dtResultado = new DataTable();
            dtResultado = cn.TraerDataset("usp_verifica_cierre", dtpFechaLiquidacion.Value.ToString("yyyyMMdd"), 3).Tables[0];

            if (dtResultado.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                return;
            }

            if (cn.TraerDataset("usp_verifica_cierre", dtpFechaLiquidacion.Value.ToString("yyyyMMdd"),3).Tables[0].Rows[0][0].ToString()=="False")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se ha cerrado la fecha de liquidación del "+ dtpFechaLiquidacion.Value.ToString("dd/MM/yyyy"), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
                return;
            }
            if (cn.EjecutarSqlDTS("select * from  [dbo].[LiquidacionInmobiliaria] where fch_pago='" +
                dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "'").Tables[0].Rows.Count > 0)
            {
                string message = "Se han encontrado datos en la fecha de liquidacion seleccionada. " + Environment.NewLine + Environment.NewLine +
                    "¿Esta seguro de continuar con la importación?" + Environment.NewLine + Environment.NewLine+"[Si] Eliminara los cambios de la información ya procesada." + 
                    Environment.NewLine + "[No] Se cargara con la informacion ya procesada.";
                string caption = VariablesGlobales.NombreMensajes;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cn.EjecutarUD("delete from [dbo].[LiquidacionInmobiliaria] where fch_pago='" +
                dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "'");

                    cn.EjecutarUD("delete from documentosIngresoDetalle where docIngresoID in " +
                            " (select docIngresoID from documentosIngresoCabecera where NumeroLiquidacion in ( " +
                            " select numeroLiquidacion from liquidacionCajaPrincipalCabecera " +
                            " where convert(varchar(8), fechaLiquidacion, 112) = '" +
                            dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and " +
                            " fechaCajaOrigen = '" + dtpFechaCaja.Value.ToString("yyyyMMdd") +
                            "' and estado = 1 and intProId = 3))");

                    cn.EjecutarUD("delete from documentosIngresoCabecera where NumeroLiquidacion in ( " +
                                " select numeroLiquidacion from liquidacionCajaPrincipalCabecera " +
                                " where convert(varchar(8), fechaLiquidacion, 112) = '" +
                                dtpFechaLiquidacion.Value.ToString("yyyyMMdd") + "' and " +
                                " fechaCajaOrigen = '" + dtpFechaCaja.Value.ToString("yyyyMMdd") +
                                "' and estado = 1 and intProId = 3)");

                    EjecutaBusqueda();
                    SumaTotales();
                }
                else
                {
                    LlenarDatos();
                }
            }
            else
            {
                EjecutaBusqueda();
            }
        }

        private void dtpFechaLiquidacion_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCaja.Value = dtpFechaLiquidacion.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarLiq_Click(object sender, EventArgs e)
        {
            frmEdicionLiquidacionInmobiliaria win = new frmEdicionLiquidacionInmobiliaria();          
            win.TipoMan = "I";
            win.FechaLiquidacion = dtpFechaLiquidacion.Value.ToString("yyyyMMdd");
            win.ShowDialog();
            LlenarDatos();
        }

        private void btnModificarLiq_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count>0)
            {
                if (dgvListado.CurrentRow!=null)
                {
                    int index;
                    index = 0;

                    index = dgvListado.CurrentRow.Index;

                    frmEdicionLiquidacionInmobiliaria win = new frmEdicionLiquidacionInmobiliaria();
                    win.Id = Convert.ToInt32(dgvListado.Rows[index].Cells[0].Value);
                    win.CodInm = dgvListado.Rows[index].Cells[1].Value.ToString();
                    win.Inquilino = dgvListado.Rows[index].Cells[3].Value.ToString();
                    win.TipDocu = dgvListado.Rows[index].Cells[8].Value.ToString();
                    win.NroDoc = dgvListado.Rows[index].Cells[9].Value.ToString();
                    win.Anio = dgvListado.Rows[index].Cells[6].Value.ToString();
                    win.Mes = dgvListado.Rows[index].Cells[7].Value.ToString();

                    win.Renta = Convert.ToDecimal(dgvListado.Rows[index].Cells[17].Value);
                    win.Igv = Convert.ToDecimal(dgvListado.Rows[index].Cells[18].Value);
                    win.Mora = Convert.ToDecimal(dgvListado.Rows[index].Cells[19].Value);
                    win.MontoSoles = Convert.ToDecimal(dgvListado.Rows[index].Cells[16].Value);
                    win.FechaLiquidacion = dtpFechaLiquidacion.Value.ToString("yyyyMMdd");
                    win.TipoMan = "E";

                    win.ShowDialog();

                    LlenarDatos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvListado.Rows.Count > 0)
            {
                if (dgvListado.CurrentRow != null)
                {
                    int index;
                    index = 0;

                    index = dgvListado.CurrentRow.Index;

                    if (MessageBox.Show("Esta seguro de eliminar el registro seleccionado?",VariablesGlobales.NombreMensajes,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                    {
                        cn.EjecutarUD("delete from dbo.LiquidacionInmobiliaria where id = "+ 
                            dgvListado.Rows[index].Cells[0].Value+ "");
                        LlenarDatos();
                    }
                }
            }
        }

        private void LlenarDatos()
        {
            dgvListado.DataSource = cn.TraerDataset("USP_LLENA_LIQUIDACION_INMOBILIARIA", 
                dtpFechaLiquidacion.Value.ToString("yyyyMMdd")).Tables[0];
            SumaTotales();
        }

        private void SumaTotales()
        {
            if (dgvListado.Rows.Count > 0)
            {
                decimal renta, igv, mora, montosoles;
                renta = 0.00m;
                igv = 0.00m;
                mora = 0.00m;
                montosoles = 0.00m;
                foreach (DataGridViewRow item in dgvListado.Rows)
                {
                    renta = renta + Convert.ToDecimal(item.Cells[17].Value);
                    igv = igv + Convert.ToDecimal(item.Cells[18].Value);
                    mora = mora + Convert.ToDecimal(item.Cells[19].Value);
                    montosoles = montosoles + Convert.ToDecimal(item.Cells[16].Value);
                }
                txtMora.Text = mora.ToString("###,###,###,##0.00");
                txtRenta.Text = renta.ToString("###,###,###,##0.00");
                txtIgv.Text = igv.ToString("###,###,###,##0.00");
                txtMontoSoles.Text = (montosoles+ mora).ToString("###,###,###,##0.00");
            }
        }

        private void btnGeneraCodigoContable_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvListado.Rows)
            {
                if (item.Cells[1].Value.ToString().Trim() == string.Empty)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Falta asignar un código de INMUEBLE al documento " + item.Cells[9].Value.ToString() +" del inquilino "+ item.Cells[3].Value.ToString(), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                    return;                   
                }
            }

            try
            {
                if (cn.TraerDataset("usp_verifica_cierre", dtpFechaLiquidacion.Value.ToString("yyyyMMdd"), 3).Tables[0].Rows[0][0].ToString() == "False")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No se ha cerrado la fecha de liquidación del " + dtpFechaLiquidacion.Value.ToString("dd/MM/yyyy"), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
                    return;
                }

                cn.TraerDataset("USP_CTA_CONTABLE_SGI", dtpFechaLiquidacion.Value.ToString("yyyyMMdd"),
                    dtpFechaCaja.Value.ToString("yyyyMMdd"));

                if (cn.TraerDataset("USP_CTA_CONTABLE_SGI",dtpFechaLiquidacion.Value.ToString("yyyyMMdd"),
                    dtpFechaCaja.Value.ToString("yyyyMMdd")).Tables[0].Rows[0][0].ToString()=="0")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Se asigno las cuentas contables correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    LlenarDatos();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Hay importe sin cuentas contables válidas.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void btnReporteIngresos_Click(object sender, EventArgs e)
        {
                DataSet dtsReporteIngresos = new DataSet();
                frmReporte winReport = new frmReporte();

            dtsReporteIngresos = cn.TraerDataset("USP_LLENA_LIQUIDACION_INMOBILIARIA2",
                    dtpFechaCaja.Value.ToString("yyyyMMdd"));

                if (dtsReporteIngresos.Tables[0].Rows.Count <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reportes.rptReporteDeIngresos rptRecibo = new Reportes.rptReporteDeIngresos();
                rptRecibo.SetDataSource(dtsReporteIngresos.Tables[0]);
                winReport.crvReportes.ReportSource = rptRecibo;

                winReport.WindowState = FormWindowState.Maximized;
                winReport.ShowDialog();
        }
    }
}
