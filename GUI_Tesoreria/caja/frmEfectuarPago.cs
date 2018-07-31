using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using CrystalDecisions.CrystalReports.Engine;
using DescripcionMonto;

namespace GUI_Tesoreria.caja
{
    public partial class frmEfectuarPago : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private varGlobales varglo = new varGlobales();
        public int tipoDocumento;
        public DataTable reciboCabecera = new DataTable();
        public DataTable reciboDetalle = new DataTable();
        CNegocio cn = new CNegocio();
        public new Form ParentForm;
        string recibo = "reciboCentral";
        ReportDocument report = new ReportDocument();
        string nombreImpresora;
        DataTable resuImpr = new DataTable();
        public string Documento { get; set; }
        public string ModalidadPago { get; set; }

        public frmEfectuarPago()
        {
            InitializeComponent();
        }

        private void TxtValorAbonado_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculaSaldo();
                BtnGrabar.Focus();
            }
        }

        private void CalculaSaldo()
        {
            try
            {
                if (TxtValorAbonado.Text.Trim().Length == 0 || Convert.ToDecimal(TxtValorAbonado.Text) < Convert.ToDecimal(TxtTotal.Text))
                {
                    TxtValorAbonado.Text = Convert.ToDecimal(TxtTotal.Text).ToString("##,##0.00");
                }
                TxtVuelto.Text = (Convert.ToDecimal(TxtValorAbonado.Text) - Convert.ToDecimal(TxtTotal.Text)).ToString("##,##0.00");
                TxtValorAbonado.Text = Convert.ToDecimal(TxtValorAbonado.Text).ToString("##,##0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TxtVuelto_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dts = new DataSet();

                dts = cn.TraerDataset("usp_s_tb_aperturacierrecaja",
                                                                        2,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        VariablesMetodosEstaticos.idcajausuario,
                                                                        System.Data.SqlTypes.SqlString.Null,

                                                                        //System.Data.SqlTypes.SqlDateTime.Null,
                                                                        Convert.ToDateTime(cn.TraerDataset("usp_obtener_hora_fecha_servidor").Tables[0].Rows[0][0]),
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        System.Data.SqlTypes.SqlDateTime.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        1);

                if (dts.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Apertura de Caja no Realizado ... Usted No Puede Registrar", VariablesMetodosEstaticos.encabezado,
                  MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                    return;
                }
                else
                {
                    if (dts.Tables[0].Rows[0]["Observacion"].ToString() == "Cerrado")
                    {
                        MessageBox.Show("La caja se encuentra cerrada... Usted No Puede Registrar", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        this.Close();
                        return;
                    }
                }

                //DataSet resultado = new DataSet();
                //bool estado = true;

                string NumeroRecibo = "";

                NumeroRecibo = cn.TraerDataset("usp_verifica_duplicidad", reciboCabecera.Rows[0][3].ToString(),
                    reciboCabecera.Rows[0][26],DateTime.Now).Tables[0].Rows[0][0].ToString();

                if (NumeroRecibo!="0000000")
                {
                    if ((MessageBox.Show("Al parecer el documento ya ha sido registrado con numero de Doc " + NumeroRecibo + ", favor de verificar en [Consultas]->[Verificación de Documentos - Extorno]. Si desea guardar de todas maneras seleccione [SI].", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            == DialogResult.Yes))
                    {
                        GenerarRecibo();
                    }
                }     
                else
                {
                    GenerarRecibo();
                }                      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GenerarRecibo()
        {
            DataSet resultado = new DataSet();
            bool directoImpresora = true;
            bool estado = true;

            resultado = cn.IngresaRecibo("usp_generea_ingresos", estado, reciboCabecera, reciboDetalle);

            var frm = (frmPagoDiversos)this.ParentForm;

            int idReciboCabecera = 0;

            idReciboCabecera = Convert.ToInt32(resultado.Tables[0].Rows[0][0].ToString().Trim());

            if (idReciboCabecera == 0)
            {
                frm.GrabaRecibo = false;
                MessageBox.Show("Ocurrio un error al guardar la información, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                frm.GrabaRecibo = true;
                DataSet dtsRecibo = new DataSet();
                //frmReporte winReport = new frmReporte();
                frmImpresionRecibos winReport = new frmImpresionRecibos();

                dtsRecibo = cn.TraerDataset("usp_r_tb_recibocabecera", 2, idReciboCabecera, DateTime.Now, DateTime.Now, 0, 1);

                //bool impuesto = false;

                //impuesto = Convert.ToBoolean(cn.TraerDataset("usp_s_obtiene_flag_impuesto", tipoDocumento).Tables[0].Rows[0][0]);
                NumLetra Letras = new NumLetra();
                //dtsRecibo.WriteXmlSchema(varglo.RUTA_XML_REPORTES + "ReporteReciboCaja.xsd");
                directoImpresora = Convert.ToBoolean(cn.TraerDataset("usp_obtiene_valor_autoimpresion", tipoDocumento).Tables[0].Rows[0][0]);

                if (dtsRecibo.Tables[0].Rows.Count > 0)
                {
                    switch (tipoDocumento)
                    {
                        case 1://BOLETA EN CASO DE CEMENTERIO
                            if (VariablesMetodosEstaticos.id_programa == 2)
                            {
                                Reportes.rptReciboCajaCanevaro rptRecibo = new Reportes.rptReciboCajaCanevaro();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                winReport.crvReportes.ReportSource = rptRecibo;
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 4)//CEMENTERIO
                            {
                                DocsElectronicos.rptBoletaCajaCementerio rptRecibo = new DocsElectronicos.rptBoletaCajaCementerio();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                //rptRecibo.SetParameterValue("@descripMonto", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }
                            break;
                        case 2://FACTURA
                            if (VariablesMetodosEstaticos.id_programa == 2)
                            {
                                Reportes.rptReciboCajaCanevaro rptRecibo = new Reportes.rptReciboCajaCanevaro();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 4)//CEMENTERIO FACTURA
                            {
                                DocsElectronicos.rptFacturaCajaCementerio rptRecibo = new DocsElectronicos.rptFacturaCajaCementerio();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                //rptRecibo.SetParameterValue("@descripMonto", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }
                            break;
                        case 3: //RECIBO CAJA
                            if (VariablesMetodosEstaticos.id_programa == 2)
                            {
                                Reportes.rptReciboCajaCanevaro rptRecibo = new Reportes.rptReciboCajaCanevaro();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 4)
                            {
                                Reportes.rptReciboCajaCementerio rptRecibo = new Reportes.rptReciboCajaCementerio();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                //rptRecibo.SetParameterValue("@descripMonto", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 1 || VariablesMetodosEstaticos.id_programa==6)
                            {
                                Reportes.rptReciboCajaCentral rptRecibo = new Reportes.rptReciboCajaCentral();
                                rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                                //rptRecibo.SetParameterValue("@descripMonto", VariablesMetodosEstaticos.varNombreSucursal);
                                rptRecibo.SetParameterValue("@Total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                                if (directoImpresora)
                                {
                                    Imprimir(rptRecibo);
                                    //rptRecibo.PrintToPrinter(1, false, 0, 0);
                                }
                                else
                                {
                                    winReport.crvReportes.ReportSource = rptRecibo;
                                }
                            }                 
                            break;
                    }
                }
                else
                {
                    winReport.crvReportes.ReportSource = new Reportes.RP();
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

            if (VariablesMetodosEstaticos.id_programa != 1)
            {
                recibo = "reciboCaja";
            }
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

        private void frmEfectuarPago_Load(object sender, EventArgs e)
        {
            if (reciboCabecera.Rows[0]["CodigoCliente"].ToString() != string.Empty)
            {
                TxtCodigoFox.Text = Convert.ToInt32(reciboCabecera.Rows[0]["CodigoCliente"].ToString()).ToString("0000000");
            }
            else
            {
                TxtCodigoFox.Text = "0000000";
            }
            lblModalidadPago.Text = ModalidadPago;
            lblTipoDocumento.Text = Documento;
            TxtNombreCliente.Text = reciboCabecera.Rows[0]["NombreRazonSocialCliente"].ToString();
            txtSucursal.Text = VariablesMetodosEstaticos.varNombreSucursal;
            TxtGlosa.Text = reciboCabecera.Rows[0]["glosa"].ToString();
            TxtTotal.Text = Convert.ToDecimal(reciboCabecera.Rows[0]["precioVenta"]).ToString("##,##0.00");
            TxtValorAbonado.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocuMentoElectronico()
        {

        }
    }
}
