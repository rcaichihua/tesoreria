using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace GUI_Tesoreria.caja
{
    public partial class frmAutorizaExtorno : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private varGlobales varglo = new varGlobales();
        private CNegocio cn = new CNegocio();
        private int intentos;
        private DataSet dSet = new DataSet();
        public new Form ParentForm;

        public frmAutorizaExtorno()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           string clave_user = null;

            try
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    MessageBox.Show("Ingrese su nombre de Usuario !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                            MessageBoxDefaultButton.Button1);
                    txtUser.Focus();
                    return;
                }
                if ((txtPwd1.Text).ToString().Length <= 0)
                {
                    MessageBox.Show("Ingrese su Contraseña !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                        MessageBoxDefaultButton.Button1);
                    txtPwd1.Focus();
                    return;
                }
                dSet = obtieneUsuario("usp_Validar_Usuario", this.txtUser.Text.ToString());

                bool FLG_VIGENTE = false;

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    clave_user = dSet.Tables[0].Rows[0]["varUsuContraseniaEncrip"].ToString();

                    FLG_VIGENTE = Convert.ToBoolean(dSet.Tables[0].Rows[0]["bitUsuEstado"]);

                    byte[] passwordBytes = GetPasswordBytes();

                    if (varGlobales.llave_publica == devuelveLlavePublica(clave_user, passwordBytes))
                    {
                        if (FLG_VIGENTE == false)
                        {
                            MessageBox.Show("Usuario deshabilitado !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Information
                                                                                                            , MessageBoxDefaultButton.Button1);
                            txtPwd1.Focus();
                        }
                        else if (Convert.ToBoolean(dSet.Tables[0].Rows[0]["extornar"].ToString()==string.Empty ? false : Convert.ToBoolean(dSet.Tables[0].Rows[0]["extornar"])) == false)
                        {
                            MessageBox.Show("El usuario Ingresado no tiene privilegios para Anular/Extornar el Recibo.", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Information
                                                                                                           , MessageBoxDefaultButton.Button1);
                            txtPwd1.Focus();
                        }
                        else
                        {
                            var frm = (frmConsultaRecibos)this.ParentForm;
                            frm.autoziza = true;
                            this.Close();
                        }
                    }
                    else
                    {
                        intentos += 1;
                        if (intentos == 3)
                        {
                            MessageBox.Show("Acceso Denegado !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                            System.Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto, verifique !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    this.txtUser.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el logueo: " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }
        private DataSet obtieneUsuario(string usp, string nomUsuario)
        {
            try
            {
                DataSet dt = new DataSet();
                dt = cn.TraerDataset("usp_Validar_Usuario", this.txtUser.Text.ToString());
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private byte[] GetPasswordBytes()
        {
            byte[] ba = null;

            if (txtPwd1.Text.Length == 0)
                ba = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            else
            {
                IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(VariablesMetodosEstaticos.ConvertToSecureString(txtPwd1.Text));
                try
                {
                    unsafe
                    {
                        byte* byteArray = (byte*)unmanagedBytes.ToPointer();

                        // Find the end of the string
                        byte* pEnd = byteArray;
                        while (*pEnd++ != 0) { }
                        // Length is effectively the difference here (note we're 1 past end) 
                        int length = (int)((pEnd - byteArray) - 1);

                        ba = new byte[length];

                        for (int i = 0; i < length; ++i)
                        {
                            // Work with data in byte array as necessary, via pointers, here
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
        private string devuelveLlavePublica(string clave, byte[] pass)
        {
            try
            {
                return varGlobales.Decrypt(clave, pass);
            }
            catch
            {
                MessageBox.Show("Usuario/Contraseña incorrecta !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtPwd1.Focus();
                return null;
            }
        }
    }
}
