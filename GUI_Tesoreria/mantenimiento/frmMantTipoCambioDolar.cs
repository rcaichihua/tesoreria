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
    public partial class frmMantTipoCambioDolar : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cn = new CNegocio();

        public frmMantTipoCambioDolar()
        {
            InitializeComponent();
        }

        private static frmMantTipoCambioDolar frmInstance = null;

        public static frmMantTipoCambioDolar Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantTipoCambioDolar();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantTipoCambioDolar_Load(object sender, EventArgs e)
        {
            cargarFechaActual();
            cargarUsuario();
            cargarCambioDolar();
        }

        private void cargarFechaActual()
        {
            try
            {
                txtFecha.Text = cn.EjecutarSqlDTS("SELECT CONVERT(VARCHAR(10),CONVERT(date, SYSDATETIME(),106),103)").Tables[0].Rows[0][0].ToString();
                txtFecha.Text = txtFecha.Text;
            }
            catch (Exception)
            {
            }
        }

        private void cargarCambioDolar()
        {
            try 
	            {
                    DGVCambioDolar.DataSource = cn.TraerDataset("usp_s_tb_tipoCambioDolar").Tables[0];
                    DGVCambioDolar.Refresh();
	            }
	            catch (Exception)
	            {
	            }
        }

        private void cargarUsuario()
        {
            txtUsuarioC.Text = VariablesMetodosEstaticos.varUsuario;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void BtnGrabarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de ingresar? una vez ingresado no se podra modificar."
                , VariablesMetodosEstaticos.encabezado, MessageBoxButtons.YesNo
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (txtValor.Text.Trim() == string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor Válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtValor.Focus();
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt32(txtValor.Text.ToString().Replace(".", "")) == 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor Válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtValor.Focus();
                            return;
                        }
                        else
                        {
                            if (cn.EjecutarSP("usp_m_tb_tipoCambioDolar", txtValor.Text
                                , VariablesMetodosEstaticos.varNombreUser
                                , VariablesMetodosEstaticos.ip_user + ' ' + VariablesMetodosEstaticos.host_user) > 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Registro ingresado correctamente", VariablesMetodosEstaticos.encabezado
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarCambioDolar();
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Registro no ingresado, intente de nuevo.", VariablesMetodosEstaticos.encabezado
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
