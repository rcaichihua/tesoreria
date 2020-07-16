using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantContable : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmMantContable()
        {
            InitializeComponent();
        }

        CNegocio cn = new CNegocio();
        DataTable dt;
        public string TipoMant { get; set; }
        public int IdEstrucutura { get; set; }
        public int IdElemento { get; set; }
        public string Movimiento { get; set; }
        public string DescripCuenta { get; set; }
        public string Codigo1 { get; set; }
        public string Codigo2 { get; set; }
        public int IdGestion { get; set; }
        public int IdCta { get; set; }
        public bool Save_ { get; set; }

        private void txtdebe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantContable_Load(object sender, EventArgs e)
        {
            LlenaEstructura();
            LlenaElemento(Convert.ToInt32(cboEstructura.SelectedValue));
            LlenaMovimiento(Convert.ToInt32(cboElemento.SelectedValue));
            cargarCtaContable("",true);
            if (TipoMant=="U")
            {
                cboEstructura.SelectedValue = IdEstrucutura;
                cboElemento.SelectedValue = IdElemento;
                cboMovimiento.Text = Movimiento + " . " +cn.EjecutarSqlDTS("select descripcionCuenta from tb_cta_contable where codigoCuenta='"+ Movimiento + "'").Tables[0].Rows[0][0].ToString();
                txtDescripCodigo.Text = DescripCuenta;
                txtCodigo1.Text = Codigo1;
                txtCodigo2.Text = Codigo2;
                cboCtaContable.SelectedValue = IdGestion;
            }
        }

        private void LlenaEstructura()
        {
            dt = new DataTable();

            try
            {
                dt = cn.EjecutarSqlDTS("select idestructura,descripEstructura from tb_estructura").Tables[0];

                DataRow row = dt.NewRow();
                row["descripEstructura"] = "--SELECCIONE--";
                row["idestructura"] = 0;
                dt.Rows.InsertAt(row, 0);

                cboEstructura.DataSource = dt;
                cboEstructura.DisplayMember = "descripEstructura";
                cboEstructura.ValueMember = "idestructura";
                cboEstructura.Refresh();
            }
            catch (Exception)
            {

            }
        }
        private void LlenaElemento(int idEstructura)
        {
            dt = new DataTable();

            try
            {
                dt = cn.EjecutarSqlDTS("select elementoID,elementoCod + ' - '+ descripcion as descrip," + 
                    "idestructura from tb_elementos where idestructura="+ idEstructura + "").Tables[0];

                DataRow row = dt.NewRow();
                row["descrip"] = "--SELECCIONE--";
                row["elementoID"] = 0;
                dt.Rows.InsertAt(row, 0);

                cboElemento.DataSource = dt;
                cboElemento.DisplayMember = "descrip";
                cboElemento.ValueMember = "elementoID";
                cboElemento.Refresh();
            }
            catch (Exception)
            {

            }
        }
        private void LlenaMovimiento(int idMov)
        {
            dt = new DataTable();

            try
            {
                dt = cn.EjecutarSqlDTS("select id_cuenta_contable,codigoCuenta+' . '+descripcionCuenta as " + 
                    "movimiento from tb_cta_contable c where movimiento=0 and LEN(codigoCuenta)<>1 and " + 
                    "elementoID="+ idMov + " order by c.codigoCuenta").Tables[0];

                DataRow row = dt.NewRow();
                row["movimiento"] = "--SELECCIONE--";
                row["id_cuenta_contable"] = 0;
                dt.Rows.InsertAt(row, 0);

                cboMovimiento.DataSource = dt;
                cboMovimiento.DisplayMember = "movimiento";
                cboMovimiento.ValueMember = "id_cuenta_contable";
                cboMovimiento.Refresh();
            }
            catch (Exception)
            {

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
                        frmFiltro fi = new frmFiltro();
                        fi.dfiltro = filTable;
                        fi.ShowDialog();
                        if (fi.ctaContable != string.Empty)
                        {
                            cboCtaContable.SelectedValue = fi.ctaContable;
                            txtBuscar.Clear();
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarCtaContable(txtBuscar.Text.Trim(), false);
            }
        }

        private void cboEstructura_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenaElemento(Convert.ToInt32(cboEstructura.SelectedValue));
            }
            catch (Exception)
            {
            }
        }

        private void cboElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenaMovimiento(Convert.ToInt32(cboElemento.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void cboMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboMovimiento.SelectedValue) != 0)
                {
                    txtCodigo1.Text = cboMovimiento.Text.Substring(0, 4);
                }
            }
            catch (Exception)
            {

            }          

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            Save_ = false;
            try
            {
                if (cn.EjecutarSP("usp_mantenimiento_cta_contable",IdCta,txtCodigo1.Text.Trim()+"."+txtCodigo2.Text.Trim(),
                    txtDescripCodigo.Text.Trim(),Convert.ToInt32(cboCtaContable.SelectedValue)==0 ? null: cboCtaContable.SelectedValue,
                    cboElemento.SelectedValue,VariablesGlobales.NombreUsuario,VariablesGlobales.UserHostIp,TipoMant) >0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente.", VariablesMetodosEstaticos.encabezado,
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Save_ = true;
                    this.Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Save_ = false;
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Save_ = false;
            }
        }

        private bool Validar()
        {
            bool resu;
            resu = false;

            if (Convert.ToDecimal(cboEstructura.SelectedValue)!=0)
            {
                if (Convert.ToDecimal(cboElemento.SelectedValue) != 0)
                {
                    if (Convert.ToDecimal(cboMovimiento.SelectedValue) != 0)
                    {
                        if (txtDescripCodigo.Text.Trim() != string.Empty)
                        {
                            if (txtCodigo2.Text.Trim() != string.Empty)
                            {
                                resu = true;
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el codigo asignado a la cuenta.", VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtCodigo2.Focus();
                                resu = false;
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la descripción de la cuenta.", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtDescripCodigo.Focus();
                            resu = false;
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un movimiento.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboMovimiento.Focus();
                        resu = false;
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un elemento.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboElemento.Focus();
                    resu = false;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una estructura.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboEstructura.Focus();
                resu = false;
            }
            return resu;
        }
    }
}
