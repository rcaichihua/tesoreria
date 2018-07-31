using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.cementerio
{
    public partial class frmAperturaExpedienteInHumacion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmAperturaExpedienteInHumacion frmInstance = null;

        public frmAperturaExpedienteInHumacion()
        {
            InitializeComponent();
        }

        public static frmAperturaExpedienteInHumacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmAperturaExpedienteInHumacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                cementerio.frmAgegarResponsable win = new cementerio.frmAgegarResponsable();
                win.ShowDialog();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
