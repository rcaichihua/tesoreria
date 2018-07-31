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
    public partial class frmFiltroResidente : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        //public DataTable  dfiltro = new DataTable();
        public string ctaContable="";
        public new Form ParentForm;

        private DataTable _dfiltro = new DataTable();

        public DataTable Dfiltro
        {
            set
            {
                _dfiltro = value;
            }
        }

        public frmFiltroResidente()
        {
            InitializeComponent();
        }

        public frmFiltroResidente(DataTable dtbFiltroResidente)
        {
            InitializeComponent();
            _dfiltro = dtbFiltroResidente;
        }
        private void dgvFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int fila;
                fila = dgvFiltro.CurrentRow.Index;
                ctaContable = dgvFiltro.Rows[fila].Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void frmFiltroResidente_Load(object sender, EventArgs e)
        {
            dgvFiltro.DataSource = _dfiltro;
        }
    }
}
