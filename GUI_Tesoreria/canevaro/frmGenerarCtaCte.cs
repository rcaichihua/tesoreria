using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmGenerarCtaCte : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public int IdResidente = 0;

        public frmGenerarCtaCte()
        {
            InitializeComponent();
        }

        private void txtPabellon_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            decimal importe = 0;
            bool canConvert;
            int resultadoGenera = 0;
            try
            {
                canConvert = decimal.TryParse(txtImporte.Text.Trim(), out importe);

                if (canConvert == true)
                {
                    if (Convert.ToDecimal(txtImporte.Text) == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor válido", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtImporte.Focus();
                        return;
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un valor válido", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtImporte.Focus();
                    return;
                }
                if (cboAnio.SelectedIndex == -1 || string.IsNullOrEmpty(cboAnio.Text.Trim()))
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un año válido", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboAnio.Focus();
                    return;
                }

                if ((DevComponents.DotNetBar.MessageBoxEx.Show("Se va a generar el estado de cuenta corriente del año " + cboAnio.Text +". ¿Desea continuar?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    resultadoGenera = Convert.ToInt32(cn.TraerDataset("usp_genera_ctacte_residente", IdResidente,
                            //cn.EjecutarSqlDTS("select YEAR(GETDATE())").Tables[0].Rows[0][0].ToString()
                            cboAnio.Text.Trim()
                            , txtImporte.Text, VariablesMetodosEstaticos.varNombreUser,rdbPriSeme.Checked == true ? 6 : 12)
                            .Tables[0].Rows[0][0]);

                    if (resultadoGenera == 13 || resultadoGenera == 7)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Cuenta corriente generada satisfactoriamente", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Cuenta corriente para este residente ya fue generada. "
                            , "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void frmGenerarCtaCte_Load(object sender, EventArgs e)
        {
            cargarAnio();
        }

        private void cargarAnio()
        {
            try
            {
                cboAnio.DataSource = cn.TraerDataset("usp_select_anio", 1).Tables[0];
                cboAnio.DisplayMember = "intAFDescripcionAnno";
                cboAnio.ValueMember = "intAFDescripcionAnno";
            }
            catch (Exception)
            {
            }
        }
        //private void rdbPriSeme_CheckedChanged(object sender, EventArgs e)
        //{
        //    gb1.Visible = true;
        //    gb2.Visible = false;
        //}

        //private void rdbSegSeme_CheckedChanged(object sender, EventArgs e)
        //{
        //    gb1.Visible = false;
        //    gb2.Visible = true;
        //}
    }
}
