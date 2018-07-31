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
    public partial class frmFiltroCuarteles : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public DataTable dfiltro = new DataTable();
        public string nomCuartel;

        public frmFiltroCuarteles()
        {
            InitializeComponent();
        }

        private void frmFiltroCuarteles_Load(object sender, EventArgs e)
        {
            dgvFiltro.DataSource = dfiltro;
        }

        private void dgvFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvFiltro.RowCount > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    int fila;
                    fila = dgvFiltro.CurrentRow.Index;
                    nomCuartel = dgvFiltro.Rows[fila].Cells[1].Value.ToString();
                    this.Close();
                }
            }
        }
    }
}
