using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.DGAI
{
    public partial class frmListadoLiquidacion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public DataTable listadoLiquidacion { get; set; }

        public frmListadoLiquidacion()
        {
            InitializeComponent();
        }

        private void frmListadoLiquidacion_Load(object sender, EventArgs e)
        {
            dgvDGAI.DataSource = listadoLiquidacion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListLiquidaciones_Click(object sender, EventArgs e)
        {
            int indice=0;

            if (dgvDGAI.RowCount == 0)
            {
                return;
            }

            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de anular la liquidacion Nº " + dgvDGAI.Rows[dgvDGAI.CurrentRow.Index].Cells[1].Value + "?", VariablesMetodosEstaticos.encabezado,
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                try
                {
                    indice = dgvDGAI.CurrentRow.Index;

                    cn.EjecutarSP("usp_anula_liquidacion_dgai", dgvDGAI.Rows[indice].Cells[0].Value);

                    DevComponents.DotNetBar.MessageBoxEx.Show("Liquidación Nº." + dgvDGAI.Rows[dgvDGAI.CurrentRow.Index].Cells[1].Value 
                        + " fue anulado correctamente", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception)
                {

                }
            }      
        }
    }
}
