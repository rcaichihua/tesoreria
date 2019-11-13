using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.caja
{
    public partial class frmEdicionDetaleRecibo : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmEdicionDetaleRecibo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
