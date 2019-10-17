using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmReporteIngresosInmobiliaria : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmReporteIngresosInmobiliaria()
        {
            InitializeComponent();
        }

        CNegocio cn = new CNegocio();

        private void btnReporteIngresos_Click(object sender, EventArgs e)
        {
            DataSet dtsReporteIngresos = new DataSet();
            frmReporte winReport = new frmReporte();

            dtsReporteIngresos = cn.TraerDataset("USP_LLENA_LIQUIDACION_INMOBILIARIA3",
                    dtpFechaCaja.Value.ToString("yyyyMMdd"));

            if (dtsReporteIngresos.Tables[0].Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInmobiliaria.DataSource = null;
                txtIgv.Text = "0.00";
                txtMontoSoles.Text = "0.00";
                txtMora.Text = "0.00";
                txtRenta.Text = "0.00";
                return;
            }

            dgvInmobiliaria.DataSource = dtsReporteIngresos.Tables[0];
            SumaTotales();
            //Reportes.rptReporteDeIngresos rptRecibo = new Reportes.rptReporteDeIngresos();
            //rptRecibo.SetDataSource(dtsReporteIngresos.Tables[0]);
            //winReport.crvReportes.ReportSource = rptRecibo;

            //winReport.WindowState = FormWindowState.Maximized;
            //winReport.ShowDialog();
        }

        private void SumaTotales()
        {
            if (dgvInmobiliaria.Rows.Count > 0)
            {
                decimal renta, igv, mora, montosoles;
                renta = 0.00m;
                igv = 0.00m;
                mora = 0.00m;
                montosoles = 0.00m;
                foreach (DataGridViewRow item in this.dgvInmobiliaria.Rows)
                {
                    renta = renta + Convert.ToDecimal(item.Cells[10].Value);
                    igv = igv + Convert.ToDecimal(item.Cells[11].Value);
                    mora = mora + Convert.ToDecimal(item.Cells[12].Value);
                    montosoles = montosoles + Convert.ToDecimal(item.Cells[9].Value);
                }
                txtMora.Text = mora.ToString("###,###,###,##0.00");
                txtRenta.Text = renta.ToString("###,###,###,##0.00");
                txtIgv.Text = igv.ToString("###,###,###,##0.00");
                txtMontoSoles.Text = (montosoles + mora).ToString("###,###,###,##0.00");
            }
        }

        private void dtpFechaLiquidacion_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCaja.Value = dtpFechaLiquidacion.Value;
        }

        private void BtnSalirC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dgvInmobiliaria.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(this.dgvInmobiliaria, sfd.FileName); // Here dataGridview1 is your grid view name

                    DevComponents.DotNetBar.MessageBoxEx.Show("Exportado correctamente", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            try
            {
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i <= dGV.RowCount - 1; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlobales.NombreMensajes,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
