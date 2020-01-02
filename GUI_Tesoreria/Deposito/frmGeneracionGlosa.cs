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
    public partial class frmGeneracionGlosa : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmGeneracionGlosa()
        {
            InitializeComponent();
        }

        CNegocio cn = new CNegocio();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DataTable dtP = new DataTable();

            int valor;

            if (!int.TryParse(txtNumInicio.Text, out valor ))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un número válido.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumInicio.Focus();
                return;
            }

            dtP = cn.EjecutarSqlDTS("select top 1 GLOSA from DIARIO_CAB where CONVERT(VARCHAR(8),FEC_LIQ,112) BETWEEN '"+
                dtpDesde.Value.ToString("yyyyMMdd")+"' AND '"+ dtpHasta.Value.ToString("yyyyMMdd") +"' and isnull(LTRIM(rtrim(GLOSA)),'')<>''").Tables[0];

            if (dtP.Rows.Count > 0)
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("Hay información ingresada en la Glosa con el" + Environment.NewLine +
                                                                "rango de fecha de liquidación ingresada, "+ Environment.NewLine +
                                                                "si continua se elminara las glosas ingresadas. "+ Environment.NewLine + Environment.NewLine 
                                                                +"¿Esta seguro de continuar?.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    cn.EjecutarSP("USP_GENERA_GLOSA_BANCOS", dtpDesde.Value.ToString("yyyyMMdd"), 
                        dtpHasta.Value.ToString("yyyyMMdd"),Convert.ToInt16(txtNumInicio.Text));

                    DevComponents.DotNetBar.MessageBoxEx.Show("Se generó la Glosa exitosamente.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                cn.EjecutarSP("USP_GENERA_GLOSA_BANCOS", dtpDesde.Value.ToString("yyyyMMdd"),
                        dtpHasta.Value.ToString("yyyyMMdd"), Convert.ToInt16(txtNumInicio.Text));

                DevComponents.DotNetBar.MessageBoxEx.Show("Se generó la Glosa exitosamente.", VariablesMetodosEstaticos.encabezado,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
