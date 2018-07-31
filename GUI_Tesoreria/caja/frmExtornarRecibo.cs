using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmExtornarRecibo : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public string nombreClienteExtorno;
        public decimal totalExtorno;
        public string serieExtorno;
        public string numeroExtorno;
        public int id_reciboCabecera;
        private CNegocio cn = new CNegocio();

        public frmExtornarRecibo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExtornarRecibo_Load(object sender, EventArgs e)
        {
            TxtSerie.Text = serieExtorno;
            TxtNumeroRecibo.Text = numeroExtorno;
            TxtNombre.Text = nombreClienteExtorno;
            TxtMonto.Text = totalExtorno.ToString("##,##0.00");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Seguro de extornar el documento?", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                int resultado = 0;
                DataSet dtsResultadoExtorno = new DataSet();

                dtsResultadoExtorno = cn.TraerDataset("usp_m_tb_anularecibo",id_reciboCabecera,VariablesMetodosEstaticos.varNombreUser
                    ,VariablesMetodosEstaticos.host_user+'-'+VariablesMetodosEstaticos.ip_user,TxtObservacion.Text.Trim());

                resultado = Convert.ToInt32(dtsResultadoExtorno.Tables[0].Rows[0][0]);

                if (resultado == 1)
                {
                    MessageBox.Show("Extornado correctamente!!.", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("Ocurrio un error al Extornar, intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
