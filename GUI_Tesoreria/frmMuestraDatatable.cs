using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria
{
    public partial class frmMuestraDatatable : Form
    {
        public frmMuestraDatatable()
        {
            InitializeComponent();
        }
        public DataTable datos { get; set; }

        private void frmMuestraDatatable_Load(object sender, EventArgs e)
        {
            dgvMuestra.DataSource = datos;
        }
    }
}
