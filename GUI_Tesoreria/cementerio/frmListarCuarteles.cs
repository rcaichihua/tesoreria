using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.cementerio
{
    public partial class frmListarCuarteles : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int CuartelId { get; set; }
        public string NombreCuartel { get; set; }
        public string TipoMaterial { get; set; }
        public int CementerioId { get; set; }
        public string Puerta { get; set; }
        public int? Nichos { get; set; }
        public int? Niveles { get; set; }

        CNegocio cn = new CNegocio();

        public frmListarCuarteles()
        {
            InitializeComponent();
        }

        private void frmListarCuarteles_Load(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void Filtrar()
        {
            cargarCuartelesFiltro(txtFiltro.Text.Trim(), "M");
        }

        private void cargarCuartelesFiltro(string filtro, string accion)
        {
            var dt = new DataTable();
            try
            {
                DataTable filTable = new DataTable();
                filTable = cn.TraerDataset("usp_select_filtro_tb_cuartel", filtro, accion).Tables[0];

                dgvFiltro.DataSource = filTable;
            }
            catch (Exception)
            {

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgvFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CuartelId = Convert.ToInt32(dgvFiltro.Rows[e.RowIndex].Cells["cuartelID"].Value);
            NombreCuartel = dgvFiltro.Rows[e.RowIndex].Cells["nombreCuartel"].Value.ToString();
            TipoMaterial = dgvFiltro.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            Puerta = dgvFiltro.Rows[e.RowIndex].Cells["puerta"].Value.ToString();
            CementerioId = Convert.ToInt32(dgvFiltro.Rows[e.RowIndex].Cells["intCeId"].Value);
            Nichos = Convert.ToInt32(dgvFiltro.Rows[e.RowIndex].Cells["nichos"].Value == DBNull.Value ? 0 : Convert.ToInt32(dgvFiltro.Rows[e.RowIndex].Cells["nichos"].Value));
            Niveles = Convert.ToInt32(dgvFiltro.Rows[e.RowIndex].Cells["niveles"].Value == DBNull.Value ? 0 : Convert.ToInt32(dgvFiltro.Rows[e.RowIndex].Cells["niveles"].Value));

            this.Close();
        }
    }
}
