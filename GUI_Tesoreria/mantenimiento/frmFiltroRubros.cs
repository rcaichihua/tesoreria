using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmFiltroRubros : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private varGlobales varglo = new varGlobales();
        private CNegocio cn = new CNegocio();
        public string codigo;
        public string descrip;
        public int index;

        public new Form ParentForm;

        public frmFiltroRubros()
        {
            InitializeComponent();
        }

        private void frmFiltroRubros_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            try
            {
                dgvRubros.DataSource = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", "", "", 3).Tables[0];
            }
            catch (Exception)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error al cargar los rubros, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado
                    , MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRubros.DataSource = (txtCodigoRubro.Text.Trim() != string.Empty) ? 
                    cn.TraerDataset("usp_buscar_rubro_x_cod_nombre",txtCodigoRubro.Text.Trim(),"",1).Tables[0] :
                    cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", "", txtDescripcion.Text.Trim(), 2).Tables[0];
            }
            catch (Exception)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error al buscar, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado
                    , MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
           
        }

        private void dgvRubros_DoubleClick(object sender, EventArgs e)
        {   
            if (dgvRubros.Rows.Count > 0)
            {
                AsignaValores();
            }
            this.Close();
        }

        private void AsignaValores()
        {
            int id;
            string cod, descripcion;
            var frm = (frmTarifario)this.ParentForm;

            id = Convert.ToInt32(dgvRubros.Rows[dgvRubros.CurrentRow.Index].Cells[0].Value);
            cod = dgvRubros.Rows[dgvRubros.CurrentRow.Index].Cells[1].Value.ToString();
            descripcion = dgvRubros.Rows[dgvRubros.CurrentRow.Index].Cells[2].Value.ToString();

            frm.asignarValoresCampoRubros(id, cod, descripcion);
        }
    }
}
