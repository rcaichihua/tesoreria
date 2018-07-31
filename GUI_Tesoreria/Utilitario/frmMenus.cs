using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Tesoreria;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMenus : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmMenus frmInstance = null;
        private CNegocio cd = new CNegocio();
        private varGlobales varglo = new varGlobales();

        public frmMenus()
        {
            InitializeComponent();
        }
        public static frmMenus Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMenus();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void frmMenus_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            lblRegistros.Text = "0 de 0";
            cargarDatos();
        }
        private void cargarDatos()
        {
            try
            {
                dgvMenu.Refresh();
                dgvMenu.DataSource = cd.TraerDataset("usp_select_menu").Tables[0];
            }
            catch (Exception)
            {             
                throw;
            }           
        }

        private void dgvMenu_CurrentCellChanged(object sender, EventArgs e)
        {
           if (dgvMenu.Rows.Count > 0) {
            if (dgvMenu.CurrentRow != null) {
                lblRegistros.Text = (dgvMenu.CurrentRow.Index + 1).ToString() + " de " + dgvMenu.Rows.Count.ToString();
            }
           }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
