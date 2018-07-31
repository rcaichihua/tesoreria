using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmFiltro : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public DataTable  dfiltro = new DataTable();
        public string ctaContable="";

        public frmFiltro()
        {
            InitializeComponent();
        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            dgvFiltro.DataSource = dfiltro;
        }

        private void dgvFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int fila;
                fila = dgvFiltro.CurrentRow.Index;
                ctaContable = dgvFiltro.Rows[fila].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
