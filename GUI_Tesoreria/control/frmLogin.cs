using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DAO_Tesoreria;
using System.Runtime.InteropServices;
using GUI_Tesoreria;
using BL_Tesoreria;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace GUI_Tesoreria.control
{
    public partial class frmLogin : Form
    {
        private varGlobales varglo = new varGlobales();
        private CNegocio cn = new CNegocio();
        private int intentos;
        private DataSet dSet = new DataSet();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Application.Exit();
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
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.intPerfilID = 0;
            VariablesMetodosEstaticos.encabezado = "...::: S G T :::...";
       
            string clave_user = null;

            try 
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese su nombre de Usuario !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                            MessageBoxDefaultButton.Button1);
                    txtUser.Focus();
                    return;
                }
                if ((txtPwd1.Text).ToString().Length <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese su Contraseña !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                        MessageBoxDefaultButton.Button1);
                    txtPwd1.Focus();
                    return;
                }

                dSet = obtieneUsuario("usp_Validar_Usuario", this.txtUser.Text.ToString());

                bool FLG_VIGENTE = false;

                DataSet dtx = new DataSet();
                dtx = cn.EjecutarSqlDTS("select year(getdate())");
                
                VariablesMetodosEstaticos.intAnnioActual = dtx.Tables[0].Rows[0][0].ToString();

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    VariablesMetodosEstaticos.varUsuario = dSet.Tables[0].Rows[0]["varUsuNombreUsuario"].ToString();
                    VariablesMetodosEstaticos.id_user = Convert.ToInt32(dSet.Tables[0].Rows[0]["intUsuId"]);
                    VariablesMetodosEstaticos.varNombrePerfil = dSet.Tables[0].Rows[0]["varPeNombrePerfil"].ToString();
                    VariablesMetodosEstaticos.varNombreSucursal = dSet.Tables[0].Rows[0]["varSuNombreSucursal"].ToString();
                    VariablesMetodosEstaticos.id_programa = Convert.ToInt32(dSet.Tables[0].Rows[0]["intProId"]);
                    VariablesMetodosEstaticos.id_Sucursal = Convert.ToInt32(dSet.Tables[0].Rows[0]["intSuId"]);
                    VariablesMetodosEstaticos.intPerfilID = Convert.ToInt32(dSet.Tables[0].Rows[0]["intPeId"]);
                    VariablesMetodosEstaticos.AnioFiscal = Convert.ToInt32(cboAnio.Text);
                    VariablesMetodosEstaticos.varNombreUser = dSet.Tables[0].Rows[0]["varUsuNombres"].ToString() + " " +
                                                    dSet.Tables[0].Rows[0]["varUsuApellidos"].ToString();

                    clave_user = dSet.Tables[0].Rows[0]["varUsuContraseniaEncrip"].ToString();
                    
                    FLG_VIGENTE = Convert.ToBoolean(dSet.Tables[0].Rows[0]["bitUsuEstado"]);
                    VariablesMetodosEstaticos.igv = Convert.ToDecimal(cn.TraerDataset("usp_select_control", "igv", VariablesMetodosEstaticos.intAnnioActual).Tables[0].Rows[0][0]);
                    byte[] passwordBytes = GetPasswordBytes();

                     if (varGlobales.llave_publica == devuelveLlavePublica(clave_user, passwordBytes))
                    //if(1==1)
                    {
                        if (FLG_VIGENTE == false)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Usuario deshabilitado !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Information
                                                                                                            , MessageBoxDefaultButton.Button1);
                            txtPwd1.Focus();
                        }
                        else
                        {
                            if (VariablesMetodosEstaticos.id_programa == 4)
                            {
                                //cementerio
                                VariablesMetodosEstaticos.mac_pc = "6045CB6EFCAA";
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 2)
                            {
                                //canevaro
                                VariablesMetodosEstaticos.mac_pc = "90FBA6349645";
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 1)
                            {
                                //central
                                VariablesMetodosEstaticos.mac_pc = "107b441ae989";
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 6)
                            {
                                //TERE
                                VariablesMetodosEstaticos.mac_pc = "90FBA6349604";
                            }
                            else if (VariablesMetodosEstaticos.id_programa == 5)
                            {
                                //ROSA
                                VariablesMetodosEstaticos.mac_pc = "90FBA6349622";
                            }
                            string encrip = Encriptar_Clave("123");
                            this.Height = 435;
                            this.Hide();
                            
                            menus.frmMenu m = new menus.frmMenu();
                            m.Show();
                        }
                    }
                    else
                    {
                        intentos += 1;
                        if (intentos == 3)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Acceso Denegado !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                            System.Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Usuario y/o Contraseña incorrectos, verifique !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    this.txtUser.SelectAll();
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error en el logueo: " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        public string Encriptar_Clave(string Clave)
        {
            SHA1 sHA = SHA1.Create();
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] array = sHA.ComputeHash(aSCIIEncoding.GetBytes(Clave));
            checked
            {
                int num = array.Length - 1;
                for (int i = 0; i <= num; i++)
                {
                    stringBuilder.AppendFormat("{0:x2}", array[i]);
                }
                return stringBuilder.ToString();
            }
        }


        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void CargarAnioFiscal()
        {
            var dt = new DataTable();
            try
            {
                //Listas por año
                dt = cn.TraerDataset("USP_LISTA_ANIO_FISCAL").Tables[0];
                cboAnio.DataSource = dt;
                cboAnio.DisplayMember = "intAFDescripcionAnno";
                cboAnio.ValueMember = "intAFID";
            }
            catch (Exception)
            {
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string con_are = "SBLMLAN";
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    VariablesMetodosEstaticos.mac_pc = adapter.GetPhysicalAddress().ToString();
                    if (con_are.ToLower() == adapter.Name.ToString().ToLower() || adapter.Name.ToString().ToLower() == "sblmlan1")
                    {
                        VariablesMetodosEstaticos.tiene_mac = true;
                        break;
                    }
                }

                if (VariablesMetodosEstaticos.tiene_mac == false)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Debe configurar los parametros del sistema correctamente, contacte con el administrador. Se saldrá del sistema.", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                       MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
                //davy
                VariablesMetodosEstaticos.tiene_mac = true;

                VariablesMetodosEstaticos.host_user = Dns.GetHostName();

                VariablesMetodosEstaticos.ip_user = "192.168.1.0";

                cn.TraerServidorSisIngresos(Program.Server, Program.database, Program.dbUsername, Program.dbPassword);
                cn.TraerServidorSGI(Program.Server, Program.database2, Program.dbUsername2, Program.dbPassword2);

                CargarAnioFiscal();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.ToString());
            }
        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese su nombre de Usuario !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                            MessageBoxDefaultButton.Button1);
                    txtUser.Focus();
                    return;
                }
                else if (obtieneUsuario("usp_Validar_Usuario", this.txtUser.Text.ToString()).Tables[0].Rows.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Usuario Incorrecto, verifique !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                    this.txtUser.SelectAll();
                }
                else
                {
                    txtPwd1.Focus();
                }
            }
        }
        private string devuelveLlavePublica(string clave,byte[] pass)
        {
            try
            {
                return varGlobales.Decrypt(clave, pass);
            }
            catch
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Usuario/Contraseña incorrecta !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtPwd1.Focus();
                return null;
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

        private void txtPwd1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((txtPwd1.Text).ToString().Length <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese su Contraseña !!!", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                        MessageBoxDefaultButton.Button1);
                    txtPwd1.Focus();
                    return;
                }
                BtnAceptar_Click(sender, e);
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
