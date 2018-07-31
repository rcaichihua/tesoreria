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
    public partial class frmMantenimientoCtaContable : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        private static frmMantenimientoCtaContable frmInstance = null;
        public frmMantenimientoCtaContable()
        {
            InitializeComponent();
        }

        public static frmMantenimientoCtaContable Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantenimientoCtaContable();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantenimientoCtaContable_Load(object sender, EventArgs e)
        {
            dgvCta.DataSource = cn.TraerDataset("usp_select_tb_cta_contable").Tables[0];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
