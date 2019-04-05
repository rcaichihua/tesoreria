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
    public partial class frmModAgregaReciboIngreso : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmModAgregaReciboIngreso()
        {
            InitializeComponent();
        }
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public decimal Importe { get; set; }
        public int CtaId { get; set; }
        public string Tipo { get; set; }
        public int idRegistro { get; set; }
        public int ProgramaId { get; set; }
        public string FechaLiq { get; set; }
        public string FechaCaja { get; set; }
        public string CodInmueble { get; set; }

        CNegocio cn = new CNegocio();
        private void frmModAgregaReciboIngreso_Load(object sender, EventArgs e)
        {
            cargarCtaContable("", true);
            if (Tipo=="M")
            {
                dtpFechaCaja.Enabled = false;
                txtTipoDoc.Text = TipoDoc;
                txtNroDoc.Text = NroDoc;
                txtImporte.Text = Importe.ToString("###,###,###,##0.00");
                cboCtaContable.SelectedValue = CtaId;
                txtCodInmueble.Text = CodInmueble;
            }
            else
            {
                dtpFechaCaja.Enabled = true;
                txtBuscarC.Focus();
            }
        }

        private void cargarCtaContable(string filtro, bool accion)
        {
            var dt = new DataTable();
            try
            {
                if (accion == true)
                {
                    dt = cn.TraerDataset("usp_select_cuenta_contable", 0, filtro).Tables[0];
                    cboCtaContable.DataSource = dt;
                    cboCtaContable.DisplayMember = "codigoCuenta";
                    cboCtaContable.ValueMember = "id_cuenta_contable";
                }
                else
                {
                    DataTable filTable = new DataTable();
                    filTable = cn.TraerDataset("usp_select_cuenta_contable", 0, filtro).Tables[0];
                    if (filTable.Rows.Count > 0)
                    {
                        mantenimiento.frmFiltro fi = new mantenimiento.frmFiltro();
                        fi.dfiltro = filTable;
                        fi.ShowDialog();
                        if (fi.ctaContable != string.Empty)
                        {
                            cboCtaContable.SelectedValue = fi.ctaContable;
                            txtBuscarC.Clear();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos con el filtro proporcionado.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tipo!="M") if (!ValidaFechaLiq()) return;
                if (!ValidarCampos()) return;
 
                if (cn.EjecutarSP("usp_mantenimiento_Doc_Ingreso_Detalle_Liquidacion", Tipo, txtTipoDoc.Text, txtNroDoc.Text,
                    txtImporte.Text, cboCtaContable.SelectedValue, idRegistro, FechaLiq, 
                    dtpFechaCaja.Value.ToString("yyyyMMdd"), ProgramaId, VariablesGlobales.NombreUsuario, 
                    VariablesGlobales.UserHostIp,txtCodInmueble.Text) > 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Se guardo correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               
        }

        private void txtBuscarC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarCtaContable(txtBuscarC.Text.Trim(), false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidaFechaLiq()
        {
            bool valor;
            valor = false;
            DataTable dt = new DataTable();

            dt =    cn.EjecutarSqlDTS("(select idLiquidacion from liquidacionCajaPrincipalCabecera " +
                    "where CONVERT(varchar(8),fechaCajaOrigen,112)='"+dtpFechaCaja.Value.ToString("yyyyMMdd")+
                    "' and intProId="+ ProgramaId + " and estado=1 " +
                    "and CONVERT(varchar(10), fechaLiquidacion,103)='"+FechaLiq+"')").Tables[0];
            if (dt.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("La fecha de caja que ha ingresado no coincide con ninguna fecha de liquidación.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                valor = false;
            }
            else
            {
                valor = true;
            }
            return valor;
        }

        private bool ValidarCampos()
        {
            bool valor;
            valor = false;
            if (txtTipoDoc.Text.Trim()!="")
            {
                if(txtNroDoc.Text.Trim()!="")
                {
                    if (txtImporte.Text.Trim() != "")
                    {
                        decimal imp = 0.00m;

                        if (decimal.TryParse(txtImporte.Text,out imp))
                        {

                            valor = true;
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe válido.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            txtImporte.Focus();
                            valor = false;
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese importe de documento.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        txtImporte.Focus();
                        valor = false;
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Nro de documento.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtNroDoc.Focus();
                    valor = false;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el tipo de documento.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtTipoDoc.Focus();
                valor = false;
            }
            return valor;
        }
    }
}
