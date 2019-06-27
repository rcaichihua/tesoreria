using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria
{
    public partial class frmListadoDocumentosLiqInmo : Form
    {
        public frmListadoDocumentosLiqInmo()
        {
            InitializeComponent();
        }
        public int IdLiq { get; set; }

        CNegocio cn = new CNegocio();

        public DataTable  Lista { get; set; }

        private void frmListadoDocumentosLiqInmo_Load(object sender, EventArgs e)
        {
            dgvListaDocumentos.DataSource = Lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cn.TraerDataset("USP_LISTA_DOC_LIQUIDACION",
                IdLiq, txtFiltro.Text.Trim()).Tables[0];

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No hay datos para el reporte.", "Aplicacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvListaDocumentos.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaDocumentos.CurrentRow!=null)
            {
                int index;
                index = dgvListaDocumentos.CurrentRow.Index;

                if (MessageBox.Show("Esta seguro de eliminar el documento seleccionado?",
                    VariablesMetodosEstaticos.encabezado, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
                {
                    if (cn.EjecutarSP("USP_RECALCULA_LIQUIDACION",
                        dgvListaDocumentos.Rows[index].Cells[0].Value,
                        VariablesGlobales.NombreUsuario,
                        VariablesGlobales.UserHostIp)>0)
                    {
                        MessageBox.Show("Se actualizo correctamente.",VariablesGlobales.NombreMensajes,
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo con contacte con sistemas.", VariablesGlobales.NombreMensajes,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
