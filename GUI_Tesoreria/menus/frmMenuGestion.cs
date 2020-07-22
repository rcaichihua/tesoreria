using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.menus
{
    public partial class frmMenuGestion : Form
    {
        public frmMenuGestion()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Application.Exit();
        }
    }
}
