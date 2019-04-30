using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmAsignaPliegoGlosa : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmAsignaPliegoGlosa()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        public int DocIngId { get; set; }
        public string FechaLiq { get; set; }
        public string Programa { get; set; }
        public int ProgramaId { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAsignaPliegoGlosa_Load(object sender, EventArgs e)
        {
            txtFechaLiq.Text = FechaLiq;
            txtPrograma.Text = Programa;

            DataTable dt = new DataTable();
            dt = cn.TraerDataset("usp_consulta_recibo_ingreso_por_programa",ProgramaId,FechaLiq.Substring(6,4)+ 
                FechaLiq.Substring(3, 2)+ FechaLiq.Substring(0, 2)).Tables[0];

            txtGlosa.Text = "PARA CONTABILIZAR LOS INGRESOS SEGUN:";
            if (dt.Rows.Count>0)
            {
                txtNroPliego.Text = dt.Rows[0][1].ToString();
                txtGlosa.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion()) return;

            if (cn.EjecutarSP("usp_actualiza_pliego_glosa", FechaLiq.Substring(6, 4) +
                FechaLiq.Substring(3, 2) + FechaLiq.Substring(0, 2),ProgramaId,txtNroPliego.Text.Trim(),txtGlosa.Text)>0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Actualizado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                Close();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
            }
        }
        private bool Validacion()
        {
            bool dato;

            dato = false;

            if (txtNroPliego.Text.Trim() != "")
            {
                if (txtGlosa.Text.Trim() != "")
                {
                    dato = true;
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la Glosa.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    txtGlosa.Focus();
                    dato = false;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Nro de Pliego.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                txtNroPliego.Focus();
                dato = false;
            }
            return dato;
        }
    }
}
