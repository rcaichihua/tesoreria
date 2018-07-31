using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Tesoreria;
using System.Runtime.InteropServices;
using System.Security;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmUsuario : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cn = new CNegocio();
        ToolTip toolTip = new ToolTip();
        private int xcod;
        private string accion;

        private varGlobales varglo = new varGlobales();
        private static frmUsuario frmInstance = null;

        public frmUsuario()
        {
            InitializeComponent();
        }

        public static frmUsuario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmUsuario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarPerfil();
            cargarSucursal();
            cargarUsuarios();
            if (dgvUsuarios.RowCount > 0){CargaDatosxId();}
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            txtContraseña.Enabled = false;
            GeneradorToolTip();
        }
        private void GeneradorToolTip()
        {
            toolTip.SetToolTip(this.btnEditar, "Edita el elemento seleccionado");
            toolTip.SetToolTip(this.btnCancelar, "Cancela los posibles cambios sobre el elemento seleccionado");
            toolTip.SetToolTip(this.btnGuardar, "Guarda el registro");
            toolTip.SetToolTip(this.btnEliminar, "Elimina el elemento seleccionado");
            toolTip.SetToolTip(this.btnSalir, "Salir del mantenimiento");
            toolTip.SetToolTip(this.btnNuevo, "Permite ingresar un nuevo elemento");
        }
        public void CargaDatosxId()
        {
            try
            {
                int fila;
                string estado = "ACTIVO";
                //DataTable dt1 = new DataTable();
                //dt1 = (DataTable)dgvUsuarios.DataSource;
                if (dgvUsuarios.RowCount > 0)
                {
                    fila = dgvUsuarios.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvUsuarios.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cn.TraerDataset("usp_select_usuario_all_x_id", xcod).Tables[0];
                    this.txtNombres.Text = (dt.Rows[0][1].ToString());
                    this.txtApellidos.Text = (dt.Rows[0][2].ToString());
                    this.txtContraseña.Text = varGlobales.llave_publica;      //VariablesMetodosEstaticos.GetPasswordBytes(txtClave)          
                    this.txtUsuario.Text = (dt.Rows[0][4].ToString());
                    this.chkActivo.Checked = (dt.Rows[0][5].ToString() == estado ? true : false);
                    this.cboSucursal.Text=(dt.Rows[0][6].ToString());
                    this.cboPerfil.Text = (dt.Rows[0][7].ToString());
                    this.chkCaja.Checked = (Convert.ToBoolean(dt.Rows[0][8]) ? true : false);
                    this.chkExtorna.Checked = (Convert.ToBoolean(dt.Rows[0][9]) ? true : false);
                }
            }
            catch (Exception)
            {
            }
        }
        private void cargarPerfil()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_perfil_all").Tables[0];
                cboPerfil.DataSource = dt;
                cboPerfil.DisplayMember = "varPeNombrePerfil";
                cboPerfil.ValueMember = "intPeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarSucursal()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_sucursal_all").Tables[0];
                cboSucursal.DataSource = dt;
                cboSucursal.DisplayMember = "varSuNombreSucursal";
                cboSucursal.ValueMember = "intSuID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarUsuarios()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_usuario_all_x_id",0).Tables[0];
                //dgvUsuarios.DataSource = null;
                dgvUsuarios.Refresh();
                dgvUsuarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void habilitaBotones(bool G)
        {
            btnNuevo.Enabled = G;
            btnGuardar.Enabled = !G;
            btnCancelar.Enabled = !G;
            btnEditar.Enabled = G;
            btnEliminar.Enabled = G;
            dgvUsuarios.Enabled = G;
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0) { CargaDatosxId();}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            txtContraseña.Enabled = true;
            varGlobales.resetearCampos(this);
            txtContraseña.Clear();
            limpiar();
            txtNombres.Focus();
        }
        private void limpiar()
        {
            chkActivo.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            txtContraseña.Enabled = false;
            cargarUsuarios();
            accion = "";
            dgvUsuarios_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.RowCount > 0) { 
            accion = "U";
            txtNombres.Focus();
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            txtContraseña.Enabled = true;
            txtNombres.Focus();
            }
            else {
                 MessageBox.Show("No Existen Datos a Modificar, verifique",
                     VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.RowCount > 0)
            {
                int indice = dgvUsuarios.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cn.EjecutarSP("usp_mantenimiento_usuario", dgvUsuarios.Rows[indice].Cells[0].Value, 0,
                                "", 0, "", "", "", true, VariablesMetodosEstaticos.varNombreUser, DateTime.Now, "", DateTime.Now, accion,chkCaja.Checked) == 1)
                            {
                                MessageBox.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("No se elimino, verifíque o intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    btnCancelar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No Existen Datos a Modificar, verifíque", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cambioClave = "NO"; 
            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    MessageBox.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese la clave");
                    txtContraseña.Focus();
                    return;
                }
                if ((cboPerfil.SelectedIndex==0) || (cboSucursal.SelectedIndex==0))
                {
                    MessageBox.Show("Selecciones el perfil o sucursal", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                int indice = dgvUsuarios.CurrentRow.Index;
                byte[] pass = GetPasswordBytes();

                if (txtContraseña.Text.Trim() != varGlobales.llave_publica)
                {
                    cambioClave = "SI";
                }

                if (accion == "I")
                {                  
                    if (cn.TraerDataset("usp_verifica_login_usuario",txtUsuario.Text.Trim()).Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Nombre de inicio de sesion ya existe, elija otro", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        txtUsuario.Focus();
                        return;
                    }

                    if ((MessageBox.Show("¿Seguro de ingresa el Usuario?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_mantenimiento_usuario", 0, cboSucursal.SelectedValue, txtUsuario.Text.Trim(), cboPerfil.SelectedValue,
                            varGlobales.Encrypt(varGlobales.llave_publica, pass), txtNombres.Text.Trim(), txtApellidos.Text.Trim(), chkActivo.Checked
                            , VariablesMetodosEstaticos.varNombreUser, DateTime.Now, cambioClave, DateTime.Now, accion,chkCaja.Checked,chkExtorna.Checked);

                        MessageBox.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        return;
                    }
                }
                    else if (accion == "U")
                    {
                        DataSet dtsVerificaCajaUSuario = new DataSet();

                        dtsVerificaCajaUSuario = cn.TraerDataset("usp_verifica_usuario_x_caja", dgvUsuarios.Rows[indice].Cells[0].Value, cboSucursal.SelectedValue);

                        if (dtsVerificaCajaUSuario.Tables[0].Rows[0][0].ToString() == "0")
                        {
                            MessageBox.Show("No se puede cambiar de sucursal debido a que este usuario tiene asignado una caja activa a otra sucursal", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Stop);
                            return;
                        }

                        cn.EjecutarSP("usp_mantenimiento_usuario", dgvUsuarios.Rows[indice].Cells[0].Value, cboSucursal.SelectedValue, txtUsuario.Text.Trim(), cboPerfil.SelectedValue,
                            varGlobales.Encrypt(varGlobales.llave_publica, pass), txtNombres.Text.Trim(), txtApellidos.Text.Trim(), chkActivo.Checked
                            , cambioClave, DateTime.Now, VariablesMetodosEstaticos.varNombreUser, DateTime.Now, accion, chkCaja.Checked, chkExtorna.Checked);

                        MessageBox.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private byte[] GetPasswordBytes()
        {
            byte[] ba = null;

            if (txtContraseña.Text.Length == 0)
                ba = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            else
            {
                IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(VariablesMetodosEstaticos.ConvertToSecureString(txtContraseña.Text));
                try
                {
                    unsafe
                    {
                        byte* byteArray = (byte*)unmanagedBytes.ToPointer();

                        byte* pEnd = byteArray;
                        while (*pEnd++ != 0) { }

                        int length = (int)((pEnd - byteArray) - 1);

                        ba = new byte[length];

                        for (int i = 0; i < length; ++i)
                        {
                            byte dataAtIndex = *(byteArray + i);
                            ba[i] = dataAtIndex;
                        }
                    }
                }
                finally
                {
                    Marshal.ZeroFreeGlobalAllocAnsi(unmanagedBytes);
                }
            }
            return System.Security.Cryptography.SHA256.Create().ComputeHash(ba);
        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios_Click(sender, e);
        }
    }
}
