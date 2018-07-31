using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI_Tesoreria.cementerio.inventario
{
    public partial class frmImagen : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string RutaImagen { get; set; }

        public frmImagen()
        {
            InitializeComponent();
        }

        private void frmImagen_Load(object sender, EventArgs e)
        {
            System.IO.FileStream fs;
            fs = new System.IO.FileStream(RutaImagen, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
        }

        private void frmImagen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
