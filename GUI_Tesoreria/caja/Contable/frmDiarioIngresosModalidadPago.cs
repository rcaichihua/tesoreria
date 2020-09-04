using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Contable
{
    public partial class frmDiarioIngresosModalidadPago : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmDiarioIngresosModalidadPago()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DataTable dtsReporteIngresos = new DataTable();
            DataTable dtsReporteIngresos2 = new DataTable();
            frmReporte winReport = new frmReporte();

            int dato;
            //int I;
            //I = 0;

            if (!int.TryParse(txtMes.Text, out dato))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un mes válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                txtMes.Focus();
                return;
            }
            if (!int.TryParse(txtAnio.Text, out dato))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un año válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                txtAnio.Focus();
                return;
            }

            if (Convert.ToInt32(txtMes.Text) > 12 || Convert.ToInt32(txtMes.Text) < 1)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un mes válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                txtMes.Focus();
                return;
            }

            dtsReporteIngresos = cn.TraerDataset("usp_diario_debe",
                Convert.ToInt32(txtAnio.Text).ToString("0000"),Convert.ToInt32(txtMes.Text).ToString("00")).Tables[0];

            dtsReporteIngresos2 = cn.TraerDataset("USP_ALTA_DIRECCION_CONTAB2009_POR_MODALIDAD_PAGO",
                   Convert.ToInt32(txtAnio.Text).ToString("0000"), Convert.ToInt32(txtMes.Text).ToString("00")).Tables[0];

           

            foreach (DataRow item in dtsReporteIngresos2.Rows)
            {
                DataRow dr = dtsReporteIngresos.NewRow();

                dr[0] = item[0];
                dr[1] = item[1];
                dr[2] = item[2];
                dr[3] = item[3];
                dr[4] = item[4];
                dr[5] = item[5];
                dr[6] = item[6];

                dtsReporteIngresos.Rows.Add(dr);
            }

            if (dtsReporteIngresos.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataView dv = dtsReporteIngresos.DefaultView;
            dv.Sort = "FECHA asc";
            DataTable sortedDT = dv.ToTable();

            caja.Contable.rptIngresosModalidadDebe rptRecibo = new caja.Contable.rptIngresosModalidadDebe();
            rptRecibo.SetDataSource(sortedDT);
            winReport.crvReportes.ReportSource = rptRecibo;

            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void txtMes_KeyDown(object sender, KeyEventArgs e)
        {
            var left = KeyboardInfo.GetKeyState(Keys.Left);
            var right = KeyboardInfo.GetKeyState(Keys.Right);
            var up = KeyboardInfo.GetKeyState(Keys.Up);
            var down = KeyboardInfo.GetKeyState(Keys.Down);

            if (down.IsPressed)
            {
                if (txtMes.SelectionStart == txtMes.Text.Length)
                {
                    txtAnio.Focus();
                }
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAnio.Focus();
            }
        }

        private void txtAnio_KeyDown(object sender, KeyEventArgs e)
        {
            var left = KeyboardInfo.GetKeyState(Keys.Left);
            var right = KeyboardInfo.GetKeyState(Keys.Right);
            var up = KeyboardInfo.GetKeyState(Keys.Up);
            var down = KeyboardInfo.GetKeyState(Keys.Down);

            if (down.IsPressed)
            {
                if (txtAnio.SelectionStart == txtAnio.Text.Length)
                {
                    btnReporte.Focus();
                }
            }
            else if (up.IsPressed)
            {
                if (txtAnio.SelectionStart == txtAnio.Text.Length)
                {
                    txtMes.Focus();
                }
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnReporte.Focus();

            }
        }
    }
}
