using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Deposito
{
    public partial class frmBorrarComprobanteDiario : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmBorrarComprobanteDiario()
        {
            InitializeComponent();
        }

        CNegocio cn = new CNegocio();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta segur de borrar el Diario?",
                    VariablesMetodosEstaticos.encabezado, 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
                {
                    if (cn.EjecutarSP("usp_paDiario_Borrar", dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "1") > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La información fue borrada del sistema.", 
                            VariablesMetodosEstaticos.encabezado,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay información que borrar en el día seleccionado.", 
                            VariablesMetodosEstaticos.encabezado,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }              
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
