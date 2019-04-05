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

        private void frmEdicionLiquidacionInmobiliaria_Load(object sender, EventArgs e)
        {
            if (TipoMan=="E")//edicion
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
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            if (TipoMan == "E")
            {
                if(cn.EjecutarUD("update dbo.LiquidacionInmobiliaria set COD_INMB='"+txtCodInm.Text+
                    "',INQUILINO='"+txtInqui.Text+"',TIP_DOCU='"+txtTipDoc.Text+"',NRO_DOCU='"+txtNroDoc.Text+
                    "',AA='"+txtAnio.Text+"',MM='"+txtMes.Text+"',FCH_PAGO='"+FechaLiquidacion+
                    "',TIP_MOVI='01',TIP_PAGO='01',MONTOSOLES="+txtMontoSoles.Text+
                    ",RENTA="+txtRenta.Text+",IGV="+txtIgv.Text+",MORA="+txtMora.Text+
                    ",USUING=USUING+'*',PCING='"+VariablesGlobales.NombreUsuario+
                    "',FECHAING=GETDATE() where id="+Id+"")>0)
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
                    "FCH_PAGO,TIP_MOVI,TIP_PAGO,MONTOSOLES,RENTA,IGV,MORA,USUING,PCING,FECHAING,IDCOMPROBANTE) " + "values('"+txtCodInm.Text+
                    "', '"+txtInqui.Text+"', '"+txtTipDoc.Text+"'"+
                    ", '"+txtNroDoc.Text+"', '"+txtAnio.Text+"', '"+txtMes.Text+"', '"+FechaLiquidacion+"', '01', '01', "+
                    txtMontoSoles.Text+", "+txtRenta.Text+", "+txtIgv.Text+", "+txtMora.Text+", '"+
                    VariablesGlobales.NombreUsuario+
                    "', '"+VariablesGlobales.UserHostIp+"', GETDATE(),0)") > 0)
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
                                                            if (txtCodInm.Text.Length > 2)
                                                            {
                                                                if (cn.EjecutarSqlDTS("select * from tconverInmobiliaria where tip_inmb='"+txtCodInm.Text.Substring(0,2)+"'").Tables[0].Rows.Count > 0)
                                                                {
                                                                    rspta = true;
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
    }
}
