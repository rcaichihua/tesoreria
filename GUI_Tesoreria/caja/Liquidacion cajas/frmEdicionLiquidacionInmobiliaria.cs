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
    public partial class frmEdicionLiquidacionInmobiliaria : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmEdicionLiquidacionInmobiliaria()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();

        public int Id { get; set; }
        public string CodInm { get; set; }
        public string Inquilino { get; set; }
        public string TipDocu { get; set; }
        public string NroDoc { get; set; }
        public string Anio { get; set; }
        public string Mes { get; set; }

        public decimal Renta { get; set; }
        public decimal Igv { get; set; }
        public decimal Mora { get; set; }
        public decimal MontoSoles { get; set; }
        public string TipoMan { get; set; }
        public string FechaLiquidacion { get; set; }
        public string FechaEmision { get; set; }
        public string NroDocumento { get; set; }

        private void frmEdicionLiquidacionInmobiliaria_Load(object sender, EventArgs e)
        {
            if (TipoMan == "E")//edicion
            {
                txtCodInm.Text = CodInm;
                txtInqui.Text = Inquilino;
                txtTipDoc.Text = TipDocu;
                txtNroDoc.Text = NroDoc;
                txtAnio.Text = Anio;
                txtMes.Text = Mes;

                txtRenta.Text = Renta.ToString("###,###,##0.00");
                txtIgv.Text = Igv.ToString("###,###,##0.00");
                txtMora.Text = Mora.ToString("###,###,##0.00");
                txtMontoSoles.Text = MontoSoles.ToString("###,###,##0.00");
                mtbFechaEmision.Text = FechaEmision;
                txtNroDocIdentidad.Text = NroDocumento;
            }
            else
            {
                mtbFechaEmision.Text = FechaEmision;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateValue;

                if (mtbFechaEmision.Text.Trim()!= "/  /")
                {
                    if (!DateTime.TryParse(mtbFechaEmision.Text, out dateValue))
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de emisión tiene un formato incorrecto.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                } 

                if (!Validar()) return;
                String fechaRec = "";
                String concat/*,concat1*/;

                concat = ", FCH_EMI=" + FechaLiquidacion + "";
                //concat1 = ",FCH_EMI";

                fechaRec = FechaLiquidacion;

                if (TipoMan == "E")
                {
                    if (cn.EjecutarUD("update dbo.LiquidacionInmobiliaria set NUM_RUC = "+ (txtNroDocIdentidad.Text.Trim()=="" ? "NULL":"'"+
                        txtNroDocIdentidad.Text.Trim()+"'") + " , FCH_EMI = "+
                        (mtbFechaEmision.Text.Trim()== "  /  /" ? "NULL":("'"+Convert.ToDateTime(mtbFechaEmision.Text).ToString("yyyyMMdd")+"'"))+", COD_INMB='" + 
                        txtCodInm.Text + 
                        "',INQUILINO='" + txtInqui.Text + "',TIP_DOCU='" + txtTipDoc.Text + "',NRO_DOCU='" + txtNroDoc.Text +
                        "',AA='" + txtAnio.Text + "',MM='" + txtMes.Text + "',FCH_PAGO='" + FechaLiquidacion +
                        "',TIP_MOVI='01',TIP_PAGO='01',MONTOSOLES=" + Convert.ToDecimal(txtMontoSoles.Text) +
                        ",RENTA=" + Convert.ToDecimal(txtRenta.Text) + ",IGV=" + Convert.ToDecimal(txtIgv.Text) + ",MORA=" + Convert.ToDecimal(txtMora.Text) +
                        ",USUING=USUING+'*',PCING='" + Environment.MachineName +
                        "',FECHAING=GETDATE() where id=" + Id + "") > 0)
                    //"',FECHAING=GETDATE()"+ (Convert.ToInt32(txtTipDoc.Text)==4 ? concat:"") + " where id=" + Id + "") > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Registro actualizado correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, Intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (cn.EjecutarUD("insert into LiquidacionInmobiliaria(COD_INMB,INQUILINO,TIP_DOCU,NRO_DOCU,AA,MM," +
                        //"FCH_PAGO,TIP_MOVI,TIP_PAGO,MONTOSOLES,RENTA,IGV,MORA,USUING,PCING,FECHAING,IDCOMPROBANTE"+ (Convert.ToInt32(txtTipDoc.Text) == 4 ?  concat1 : "") + ") " + "values('" + txtCodInm.Text +
                        "FCH_PAGO,TIP_MOVI,TIP_PAGO,MONTOSOLES,RENTA,IGV,MORA,USUING,PCING,FECHAING,IDCOMPROBANTE" + ",FCH_EMI" + ") " + "values('" + txtCodInm.Text +
                        "', '" + txtInqui.Text + "', '" + txtTipDoc.Text + "'" +
                        ", '" + txtNroDoc.Text + "', '" + txtAnio.Text + "', '" + txtMes.Text + "', '" + FechaLiquidacion + "', '01', '01', " +
                        Convert.ToDecimal(txtMontoSoles.Text) + ", " + Convert.ToDecimal(txtRenta.Text) + ", " + Convert.ToDecimal(txtIgv.Text) + ", " + 
                        Convert.ToDecimal(txtMora.Text) + ", '" +
                        VariablesMetodosEstaticos.varUsuario +
                        "', '" + VariablesMetodosEstaticos.host_user + "', GETDATE(),0," + (mtbFechaEmision.Text == "  /  /" ? "NULL" : 
                        ("'" + Convert.ToDateTime(mtbFechaEmision.Text).ToString("yyyyMMdd") + "'")) + ")") > 0)
                    //"', '" + VariablesGlobales.UserHostIp + "', GETDATE(),0"+ (Convert.ToInt32(txtTipDoc.Text) == 4 ? ","+FechaLiquidacion : "") + ")") > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Registro insertado correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, Intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validar()
        {
            bool rspta;
            int num;
            decimal importe;
            num = 0;
            importe = 0.00m;
            rspta = false;

            if (txtCodInm.Text.Trim()!=string.Empty)
            {
                if (txtInqui.Text.Trim() != string.Empty)
                {
                    if (txtTipDoc.Text.Trim() != string.Empty)
                    {
                        if (txtNroDoc.Text.Trim() != string.Empty)
                        {
                            if (txtAnio.Text.Trim() != string.Empty)
                            {
                                if (int.TryParse(txtAnio.Text,out num))
                                {
                                    if (txtMes.Text.Trim() != string.Empty)
                                    {
                                        if (int.TryParse(txtMes.Text, out num))
                                        {
                                            if (decimal.TryParse(txtRenta.Text,out importe))
                                            {
                                                if (decimal.TryParse(txtIgv.Text, out importe))
                                                {
                                                    if (decimal.TryParse(txtMora.Text, out importe))
                                                    {
                                                        if (decimal.TryParse(txtMontoSoles.Text, out importe))
                                                        {
                                                            if (txtCodInm.Text.Length >= 2)
                                                            {
                                                                int codinmb;
                                                                string cod;

                                                                if (int.TryParse(txtCodInm.Text.Substring(0, 2), out codinmb))
                                                                {
                                                                    if (Convert.ToInt32(txtCodInm.Text.Substring(0, 2)) > 50)
                                                                    {
                                                                        cod = "50";
                                                                    }
                                                                    else
                                                                    {
                                                                        cod = txtCodInm.Text.Substring(0, 2);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    cod = txtCodInm.Text;
                                                                }

                                                                if (cn.EjecutarSqlDTS("select * from tconverInmobiliaria where tip_inmb='"+ cod.Substring(0,2)+"'").Tables[0].Rows.Count > 0)
                                                                {
                                                                    if ((Convert.ToDecimal(txtRenta.Text) + Convert.ToDecimal(txtIgv.Text)) !=
                                                                        Convert.ToDecimal(txtMontoSoles.Text))
                                                                    {
                                                                        DevComponents.DotNetBar.MessageBoxEx.Show("El total no coninside con la suma de la RENTA E IGV.", VariablesMetodosEstaticos.encabezado,
                                                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                        txtMontoSoles.Focus();
                                                                        rspta = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (cn.EjecutarSqlDTS("select * from sisinmueble.dbo.TIPODOCU where IDTIPODOCU='"+ txtTipDoc.Text.Trim() + "'").Tables[0].Rows.Count>0)
                                                                        {
                                                                            rspta = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            DevComponents.DotNetBar.MessageBoxEx.Show("Código de tipo de documento no existe.", VariablesMetodosEstaticos.encabezado,
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                            txtTipDoc.Focus();
                                                                            rspta = false;
                                                                        }
                                                                    }
                                                                    
                                                                }
                                                                else
                                                                {
                                                                    DevComponents.DotNetBar.MessageBoxEx.Show("Los dos primeros digitos de codigo de inmueble no existe en la tabla de conversiones de cuentas.", VariablesMetodosEstaticos.encabezado,
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    txtCodInm.Focus();
                                                                    rspta = false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                DevComponents.DotNetBar.MessageBoxEx.Show("El codigo de inmueble tiene que ser mayor a dos caracteres.", VariablesMetodosEstaticos.encabezado,
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                txtCodInm.Focus();
                                                                rspta = false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor válido para el Monto Soles.", VariablesMetodosEstaticos.encabezado,
                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            txtMontoSoles.Focus();
                                                            rspta = false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor válido para la Mora.", VariablesMetodosEstaticos.encabezado,
                                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        txtMora.Focus();
                                                        rspta = false;
                                                    }
                                                }
                                                else
                                                {
                                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor válido para el IGV.", VariablesMetodosEstaticos.encabezado,
                                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    txtIgv.Focus();
                                                    rspta = false;
                                                }
                                            }
                                            else
                                            {
                                                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor válido para la renta.", VariablesMetodosEstaticos.encabezado,
                                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtRenta.Focus();
                                                rspta = false;
                                            }
                                        }
                                        else
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un dato correcto para el Mes.", VariablesMetodosEstaticos.encabezado,
                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtMes.Focus();
                                            rspta = false;
                                        }
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Mes.", VariablesMetodosEstaticos.encabezado,
                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtMes.Focus();
                                        rspta = false;
                                    }
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un dato correcto para el Año.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtAnio.Focus();
                                    rspta = false;
                                }
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Año.", VariablesMetodosEstaticos.encabezado,
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtAnio.Focus();
                                rspta = false;
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Nro de documento.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNroDoc.Focus();
                            rspta = false;
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un tipo de documento.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTipDoc.Focus();
                        rspta = false;
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un codigo de inmueble.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInqui.Focus();
                    rspta = false;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un codigo de inmueble.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodInm.Focus();
                rspta = false;
            }
            return rspta;
        }

        private void txtRenta_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void txtIgv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMontoSoles.Text = (Convert.ToDecimal(txtRenta.Text) + Convert.ToDecimal(txtIgv.Text) +
                    Convert.ToDecimal(txtMora.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtRenta_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtMontoSoles.Text = (Convert.ToDecimal(txtRenta.Text) + Convert.ToDecimal(txtIgv.Text) +
                    Convert.ToDecimal(txtMora.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtMora_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMontoSoles.Text = (Convert.ToDecimal(txtRenta.Text) + Convert.ToDecimal(txtIgv.Text) +
                    Convert.ToDecimal(txtMora.Text)).ToString("###,###,##0.00");
            }
            catch (Exception)
            {

            }
        }
    }
}
