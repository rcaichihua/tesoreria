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
    public partial class frmFiltroFallecidos : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        private static frmFiltroFallecidos frmInstance = null;

        public static frmFiltroFallecidos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmFiltroFallecidos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmFiltroFallecidos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        void Buscar()
        {
            dgvFiltro.DataSource = cn.TraerDataset("USP_FILTRO_DIFUNTO", txtNombres.Text.Trim()).Tables[0];
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void frmFiltroFallecidos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
