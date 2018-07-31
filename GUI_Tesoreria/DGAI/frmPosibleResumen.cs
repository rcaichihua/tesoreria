using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.DGAI
{
    public partial class frmPosibleResumen : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public DataTable dtResultado { get; set; }
        public frmPosibleResumen()
        {
            InitializeComponent();
        }

        private void frmPosibleResumen_Load(object sender, EventArgs e)
        {
            dgvAsigna.DataSource = dtResultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
