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
    public partial class frmMotivoAnulacion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        CNegocio cn = new CNegocio();
        public bool save { get; set; }
        string procedimiento;

        public frmMotivoAnulacion()
        {
            InitializeComponent();
        }

        private void frmMotivoAnulacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            save = false;

            if (txtDescripcion.Text.Length<15)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Tiene que ser mas decriptivo en la descripcion de la anulación.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de anular?", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                if (Tipo=="L")
                {
                    procedimiento = "usp_AnulaLiquidacion";
                }
                else
                {
                    procedimiento = "usp_AnulaRecibo";
                }

                if (cn.EjecutarSP(procedimiento, Id, txtDescripcion.Text,
                VariablesMetodosEstaticos.ip_user + "/" + VariablesMetodosEstaticos.host_user,
                VariablesMetodosEstaticos.varNombreUser)>0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Anulado correctamente.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    save = true;
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error en la anulación, intente de nuevo o contactese con la SGTI.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    save = false;
                }
            }                
        }
    }
}
