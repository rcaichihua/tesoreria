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
    public partial class frmEdicionDetalleRecibo_editar : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmEdicionDetalleRecibo_editar()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        public int Id_detalleRecibo { get; set; }
        public int Cod_Rubro { get; set; }
        public int Cod_TaId { get; set; }
        public string Descripcion { get; set; }
        public int Programa_ { get; set; }
        DataTable dtSearch;

        private void frmEdicionDetalleRecibo_editar_Load(object sender, EventArgs e)
        {
            try
            {
                if (Programa_ == 4)
                {
                    lblCuenta.Text = BuscarCuenta(Cod_Rubro.ToString("0000"));
                    txtCodigoRubro.Text = Cod_Rubro.ToString("0000");
                    txtCodTaId.Text = Cod_TaId.ToString();
                    txtDescripcion.Text = Descripcion;
                    txtCodigoRubro.ReadOnly = true;
                    txtCodTaId.ReadOnly = false;
                }
                else
                {
                    lblCuenta.Text = BuscarCuenta(Cod_Rubro.ToString("0000"));
                    txtCodigoRubro.Text = Cod_Rubro.ToString("0000");
                    txtCodTaId.Text = "";
                    txtDescripcion.Text = Descripcion;
                    txtCodigoRubro.ReadOnly = false;
                    txtCodTaId.ReadOnly = true;
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarNumeros()
        {
            bool rspta;
            rspta = false;

            if (int.TryParse(txtCodigoRubro.Text,out int codigo))
            {
                if (Programa_ == 4)
                {
                    if (int.TryParse(txtCodTaId.Text, out int cod_tarifa))
                    {
                        rspta = true;
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un codigo de tarifa Válido.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodTaId.Focus();
                        rspta = false;
                    }
                }
                else
                {
                    rspta = true;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un codigo de rubro Válido.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodTaId.Focus();
                rspta = false;
            }

            return rspta;
        }

        private void txtCodTaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Programa_ == 4)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (!ValidarNumeros()) return;
                    txtCodigoRubro.Text = BuscarRubroPorTarifa();
                    lblCuenta.Text = BuscarCuenta(Convert.ToInt32(txtCodigoRubro.Text).ToString("0000"));
                    txtDescripcion.Text = cn.EjecutarSqlDTS("select varTaDescripcion from ta_tarifa where intTaId="+txtCodTaId.Text+"").Tables[0].Rows[0][0].ToString();
                }
            }
        }

        private string  BuscarRubroPorTarifa()
        {

            dtSearch = new DataTable();
            dtSearch = cn.EjecutarSqlDTS("select b.chaRuCodigo from ta_tarifa a inner join rubro b on a.intRuId = b.intRuId where intTaId = "+
                Convert.ToInt32(txtCodTaId.Text)+"" +
                                                    "").Tables[0];

            return dtSearch.Rows[0][0].ToString();
        }

        private string BuscarRubroPorCajaCentral()
        {

            dtSearch = new DataTable();
            dtSearch = cn.EjecutarSqlDTS("select b.chaRuCodigo from rubro b where chaRuCodigo = " +
                Convert.ToInt32(txtCodigoRubro.Text).ToString("0000") + "" +
                                                    "").Tables[0];

            return dtSearch.Rows[0][0].ToString();
        }

        private string BuscarCuenta(string rubro)
        {
            try
            {
                dtSearch = new DataTable();
                dtSearch = cn.EjecutarSqlDTS("select a.codigoCuenta+' / '+c.CODIGO_CONTABLE2 from tb_cta_contable a " +
                                                    "inner join rubro b on a.id_cuenta_contable = b.id_cuenta_contable " +
                                                    "inner join contable_privado c on c.CODIGO_CONTABLE1 = a.codigoCuenta " +
                                                    " where b.chaRuCodigo = '" + rubro + "'").Tables[0];
                rubro = (dtSearch.Rows.Count > 0 ? dtSearch.Rows[0][0].ToString() : "SIN CUENTA EMPR. ASIGNADA");
            }
            catch (Exception)
            {

                throw;
            }
            return rubro;
        }

        private void txtCodigoRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Programa_ == 1)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (!ValidarNumeros()) return;
                    if (BuscarDescripRubroAltaDireccion()==string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El codigo de Rubro no existe o no esta asignado para Alta dirección.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    lblCuenta.Text = BuscarCuenta(BuscarRubroPorCajaCentral());
                    txtDescripcion.Text = cn.EjecutarSqlDTS("select varRuDescripcion from rubro where intProId=1 and chaRuCodigo='"+Convert.ToInt32(txtCodigoRubro.Text).ToString("0000")+"'").Tables[0].Rows[0][0].ToString();
                }
            }
        }

        private string BuscarDescripRubroAltaDireccion()
        {
            string respuesta;

            dtSearch = new DataTable();
            dtSearch = cn.EjecutarSqlDTS("select varRuDescripcion from rubro where intProId=1 and chaRuCodigo = " +
                Convert.ToInt32(txtCodigoRubro.Text).ToString("0000") + "" +
                                                    "").Tables[0];
            if (dtSearch.Rows.Count <= 0)
            {
                respuesta = "";
            }
            else
            {
                respuesta = dtSearch.Rows[0][0].ToString();
            }
            return respuesta;
        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            if (!ValidarNumeros()) return;

            string message = "Usuario : " + VariablesMetodosEstaticos.varNombreUser + Environment.NewLine + "Usted modificara el detalle del Documento." +
                Environment.NewLine + Environment.NewLine + "Estos cambios quedaran registrados con los siguientes datos." + Environment.NewLine + Environment.NewLine +
                "Usuario          : " + VariablesMetodosEstaticos.varUsuario + Environment.NewLine +
                "Nombre de su PC  : " + Environment.MachineName + Environment.NewLine +
                "Fecha y Hora     : " + DateTime.Now.ToString("dd/MM/yyyy") + " a horas " + DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine + Environment.NewLine +
                "¿Esta seguro de continuar?";

            string caption = VariablesGlobales.NombreMensajes;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (Programa_ == 4)
                {
                    if (cn.EjecutarSqlDTS("select * from ta_tarifa a inner join rubro b on a.intRuId=b.intRuId where b.chaRuCodigo='" +
                        Convert.ToInt16(txtCodigoRubro.Text).ToString("0000") + "' and a.intTaId=" + Convert.ToInt32(txtCodTaId.Text) + "").Tables[0].Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No se puede registrar, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }

                    cn.EjecutarUD("update tb_ReciboDetalle set idRubro='" + Convert.ToInt32(txtCodigoRubro.Text.Trim()) + "',intTaID="+ 
                        Convert.ToInt32(txtCodTaId.Text)+ ",idCuentaContanble=(select id_cuenta_contable from rubro where chaRuCodigo='"+ 
                        Convert.ToInt32(txtCodigoRubro.Text.Trim()) + "'),Item_ReciboDetalle='" + txtDescripcion.Text+"' " +
                    " from tb_ReciboDetalle where Id_ReciboDetalle=" + Id_detalleRecibo + "");

                    DevComponents.DotNetBar.MessageBoxEx.Show("Se actualizo el detalle correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (cn.EjecutarSqlDTS("select chaRuCodigo from rubro where intProId=1 and chaRuCodigo='" +
                        Convert.ToInt16(txtCodigoRubro.Text).ToString("0000") + "'").Tables[0].Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No se puede registrar, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;

                    }

                    cn.EjecutarUD("update tb_ReciboDetalle set idRubro='" + Convert.ToInt32(txtCodigoRubro.Text.Trim()) + "',idCuentaContanble=(select id_cuenta_contable from rubro where chaRuCodigo='" +
                        Convert.ToInt32(txtCodigoRubro.Text.Trim()) + "'),Item_ReciboDetalle='" + txtDescripcion.Text + "' " +
                    " from tb_ReciboDetalle where Id_ReciboDetalle=" + Id_detalleRecibo + "");

                    DevComponents.DotNetBar.MessageBoxEx.Show("Se actualizo el detalle correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                //MODIF_DETALLE CON ESTE SE INGRESA EL ID DEL DETALLE DEL RECIBO
                //MODIF_GLOSA CON ESTE SE INGRESA EL ID DE LA CANECERA DEL RECIBO
                cn.EjecutarUD("insert into auditoria_ReciboCabecera(usumod,pcmod,fechamod,tipomod,glosa_ant,glosa_mod,id_moddif) VALUES('" +
                    VariablesMetodosEstaticos.varUsuario + "','" + Environment.MachineName + "',GETDATE(),'MODIF_DETALLE',null,null," + 
                    Id_detalleRecibo + ")");
            }
        }
    }
}
