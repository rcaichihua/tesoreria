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
    public partial class frmGenerarCuartel : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        public string codCuartel { get; set; }
        public string codTipoCuartel { get; set; }//adulto, parvulo etc.
        public string codMaterial { get; set; }//marmol, cuarzo etc.
        public int nroFilas { get; set; }
        public int nroColumnas { get; set; }

        public frmGenerarCuartel()
        {
            InitializeComponent();
        }

        private void frmGenerarCuartel_Load(object sender, EventArgs e)
        {
            llenarEstado();
            AsignarNúmeracion();
        }
        private void llenarEstado()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODESTADO,DESCRIPESTADO from cementerio.ESTADO").Tables[0];
                cboEstado.DataSource = dt;
                cboEstado.DisplayMember = "DESCRIPESTADO";
                cboEstado.ValueMember = "CODESTADO";
            }
            catch (Exception)
            {
            }
        }
        private void AsignarNúmeracion()
        {
            nuInicioFila.Value = 1;
            nuFinalFila.Value = nroFilas;
            nuInicioColumna.Value = 1;
            nuFinColumna.Value = nroColumnas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtResultado = new DataTable();
                dtResultado = cn.TraerDataset("usp_Generar_cuarteles", codCuartel, codTipoCuartel, codMaterial, cboEstado.SelectedValue, Convert.ToInt32(nuInicioFila.Value),Convert.ToInt32(nuFinalFila.Value)
                    , Convert.ToInt32(nuInicioColumna.Value), Convert.ToInt32(nuFinColumna.Value)).Tables[0];

                if (dtResultado.Rows[0][0].ToString() != "0")
                {
                    MessageBox.Show("Los nichos han sido correctamente Generados." + Environment.NewLine +
                    "Numero de Nichos creados = " + dtResultado.Rows[0][0].ToString() + "." + Environment.NewLine
                    + "Si desea generar mas nichos ingrese los " + Environment.NewLine 
                    + "nuevos parametros y pulse el boton GENERAR.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                MessageBox.Show("Ocurrio un error, intente de nuevo o contacte con sistemas", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }
    }
}
