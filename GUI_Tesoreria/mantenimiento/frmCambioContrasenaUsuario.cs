using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Runtime.InteropServices;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmCambioContrasenaUsuario : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        private static frmCambioContrasenaUsuario frmInstance = null;

        public frmCambioContrasenaUsuario()
        {
            InitializeComponent();
        }

        public static frmCambioContrasenaUsuario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmCambioContrasenaUsuario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmCambioContrasenaUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = VariablesMetodosEstaticos.varUsuario;
            txtContrasena1.Focus();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string devuelveLlavePublica(string clave, byte[] pass)
        {
            try
            {
                return varGlobales.Decrypt(clave, pass);
            }
            catch
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Contraseña incorrecta !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtContraseñaActual.Focus();
                return null;
            }
        }

        private DataSet obtieneUsuario(string usp, string nomUsuario)
        {
            try
            {
                DataSet dt = new DataSet();
                dt = cn.TraerDataset("usp_Validar_Usuario", VariablesMetodosEstaticos.varUsuario);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dSet = new DataSet();

                //actual contraseña
                byte[] pass = GetPasswordBytes();
                //nueva contraseña
                byte[] passwordBytes = GetPasswordBytes2();

                dSet = obtieneUsuario("usp_Validar_Usuario", VariablesMetodosEstaticos.varUsuario);

                if (varGlobales.llave_publica == devuelveLlavePublica(dSet.Tables[0].Rows[0]["varUsuContraseniaEncrip"].ToString(), pass))
                {
                    if (txtContrasena1.Text != txtContrasena2.Text)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Las contraseñas no coinciden, verifique.", VariablesMetodosEstaticos.encabezado, 
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (txtContrasena1.Text.Trim() == string.Empty && txtContrasena2.Text.Trim() == string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La contraseña no puede estar vacia, verifique.", 
                            VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (cn.EjecutarSP("usp_actualiza_contrasenia_usuario", VariablesMetodosEstaticos.id_user, varGlobales.Encrypt(varGlobales.llave_publica, passwordBytes)) > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Contraseña actualizado correctamente!.", VariablesMetodosEstaticos.encabezado, 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error intente de nuevo o contacte con sistemas.", 
                            VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("La contraseña introducida no corresponde a la contraseña del usuario.", 
                        VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private byte[] GetPasswordBytes()
        {
            byte[] ba = null;

            if (txtContrasena1.Text.Length == 0)
                ba = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            else
            {
                IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(VariablesMetodosEstaticos.ConvertToSecureString(txtContraseñaActual.Text));
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

        private byte[] GetPasswordBytes2()
        {
            byte[] ba = null;

            if (txtContrasena1.Text.Length == 0)
                ba = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            else
            {
                IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(VariablesMetodosEstaticos.ConvertToSecureString(txtContrasena1.Text));
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
    }
}
