using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.Contabilidad
{
    public partial class frmRegDep : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmRegDep()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegDep_Load(object sender, EventArgs e)
        {

        }
    }
}
