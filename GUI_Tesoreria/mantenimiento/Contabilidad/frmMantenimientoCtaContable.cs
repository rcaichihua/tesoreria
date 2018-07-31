using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.mantenimiento.Contabilidad
{
    public partial class frmMantenimientoCtaContable : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmMantenimientoCtaContable()
        {
            InitializeComponent();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.Focus();
        }
    }
}
