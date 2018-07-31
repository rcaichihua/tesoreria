using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Security.Principal;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmMantTasasDscto : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        WindowsIdentity MyID = WindowsIdentity.GetCurrent();
        CNegocio cn = new CNegocio();
        private static frmMantTasasDscto frmInstance = null;

        public frmMantTasasDscto()
        {
            InitializeComponent();
        }
        public static frmMantTasasDscto Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantTasasDscto();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void frmMantTasasDscto_Load(object sender, EventArgs e)
        {
            cboTipoTasa.SelectedIndex = 0;
            txtAnio.Text = VariablesMetodosEstaticos.intAnnioActual.ToString();
        }

        private void cboTipoTasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtTasas = new DataTable();
            try
            {
                if (cboTipoTasa.Text != "[seleccione]")
                {
                    dtTasas = cn.TraerDataset("usp_mnt_tasas_canevaro", cboTipoTasa.Text, txtAnio.Text).Tables[0];
                    if (dtTasas.Rows.Count > 0)
                    {
                        txtTasa.Text = dtTasas.Rows[0][0].ToString();
                    }
                }
                else
                {
                    txtTasa.Text = "0.00";
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dtControl = new DataTable();
            try
            {
                dtControl = cn.TraerDataset("usp_mnt_tb_control",cboTipoTasa.Text,txtTasa.Text
                    , txtAnio.Text, "tasasCanevaro", VariablesMetodosEstaticos.varUsuario, MyID.Name.ToUpper()
                    , VariablesMetodosEstaticos.ip_user, System.Net.Dns.GetHostName().ToUpper()).Tables[0];

                if (dtControl.Rows.Count > 0)
                {
                    if (dtControl.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Actualizado correctamente.",
                       VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information
                       , MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo o contacte con sistemas.",
                   VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error
                   , MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
