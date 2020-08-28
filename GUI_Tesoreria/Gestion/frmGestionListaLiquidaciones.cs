using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.Gestion
{
    public partial class frmGestionListaLiquidaciones : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmGestionListaLiquidaciones()
        {
            InitializeComponent();
        }
        public int ProgramaId { get; set; }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionListaLiquidaciones_Load(object sender, EventArgs e)
        {
            if (ProgramaId == 3)
            {
                LblTitulo.Text = ":::   LIQUIDACIONES EMITIDAS INMOBILIARIA   :::";
            }
        }
    }
}
