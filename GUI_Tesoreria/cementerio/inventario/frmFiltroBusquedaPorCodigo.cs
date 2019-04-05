using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.cementerio.inventario
{
    public partial class frmFiltroBusquedaPorCodigo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string Tipo { get; set; }
        public int Codigo { get; set; }
        public bool accion { get; set; }

        CNegocio cn = new CNegocio();

        public frmFiltroBusquedaPorCodigo()
        {
            InitializeComponent();
        }

        private void frmFiltroBusquedaPorCodigo_Load(object sender, EventArgs e)
        {
            accion = false;
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            accion = true;

            if (txtCodigo.Text.Trim() == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el codigo para la Busqueda");
                txtCodigo.Focus();
                return;
            }
            Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);

            if (e.KeyChar == Convert.ToChar(13))
            {
                btnBuscar_Click(sender, e);
            }
        }
    }
}
