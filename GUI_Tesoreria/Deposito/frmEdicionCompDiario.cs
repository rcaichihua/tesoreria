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
    public partial class frmEdicionCompDiario : DevComponents.DotNetBar.Metro.MetroForm
    {
        private static frmEdicionCompDiario frmInstance = null;

        CNegocio cn = new CNegocio();

        public frmEdicionCompDiario()
        {
            InitializeComponent();
        }

        public static frmEdicionCompDiario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmEdicionCompDiario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvDiarioCabecera.DataSource = cn.TraerDataset("usp_paDiario_Edit",
                    dtpFechaLiquidación.Value.ToString("yyyyMMdd")).Tables[0];
            }
            catch (Exception)
            {
            }
        }

        private void dgvDiarioCabecera_SelectionChanged(object sender, EventArgs e)
        {
            DiarioDetalle();
        }

        private void dgvDiarioCabecera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DiarioDetalle();
        }

        private void DiarioDetalle()
        {
            try
            {
                if (dgvDiarioCabecera.CurrentRow!=null)
                {
                    int index;

                    index = this.dgvDiarioCabecera.CurrentRow.Index;

                    txtNumCompro.Text = this.dgvDiarioCabecera.Rows[index].Cells[0].Value.ToString().Trim();
                    txtReferencia.Text = this.dgvDiarioCabecera.Rows[index].Cells[3].Value.ToString().Trim();
                    dtpFechaComprobante.Value = Convert.ToDateTime(this.dgvDiarioCabecera.Rows[index].Cells[1].Value);

                    this.dgvDiarioCabeceraDet.DataSource = cn.TraerDataset("usp_paDiario_Det_Edit",
                    this.dgvDiarioCabecera.Rows[index].Cells[6].Value).Tables[0];

                    decimal debe, haber;
                    debe = 0.00m;
                    haber = 0.00m;

                    foreach (DataGridViewRow item in dgvDiarioCabeceraDet.Rows)
                    {
                        debe = debe + Convert.ToDecimal(item.Cells["DEBE"].Value);
                        haber = haber + Convert.ToDecimal(item.Cells["HABER"].Value);
                    }

                    txtdebe.Text = debe.ToString("###,###,##0.00");
                    txthaber.Text = haber.ToString("###,###,##0.00");
                }
                else
                {
                    txtNumCompro.Clear();
                    txtReferencia.Clear();
                    dtpFechaComprobante.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEdicionCompDiario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDiarioCabecera.CurrentRow!=null)
            {
                if (this.dgvDiarioCabecera.Rows.Count > 0)
                {
                    Limpiar(true);
                    txtNumCompro.Focus();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDiarioCabecera.CurrentRow != null)
            {
                if (this.dgvDiarioCabecera.Rows.Count > 0)
                {
                    Limpiar(false);

                    int index = this.dgvDiarioCabecera.CurrentRow.Index;

                    cn.EjecutarSP("usp_paDiario_Guardar", this.dgvDiarioCabecera.Rows[index].Cells[6].Value,
                        txtNumCompro.Text.Trim(),
                        txtReferencia.Text.Trim(),
                        dtpFechaComprobante.Value.ToString("yyyyMMdd"));
                    btnVer_Click(sender, e);
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar(false);
            btnVer_Click(sender,e);
        }

        private void Limpiar(bool bo)
        {
            btnEditar.Enabled = !bo;
            btnCancelar.Enabled = bo;
            btnGuardar.Enabled = bo;
            txtNumCompro.Enabled = bo;
            txtReferencia.Enabled = bo;
            dtpFechaComprobante.Enabled = bo;
            dgvDiarioCabecera.Enabled = !bo;
            btnVer.Enabled = !bo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index;
            index = 0;
            if (dgvDiarioCabeceraDet.CurrentRow!=null)
            {
                index = this.dgvDiarioCabeceraDet.CurrentRow.Index;

                Deposito.frmEditarDiarioDetalle win = new Deposito.frmEditarDiarioDetalle();
                win.IdDetDiario = Convert.ToInt32(dgvDiarioCabeceraDet.Rows[index].Cells["REG_ID_"].Value);
                win.Debe_= Convert.ToDecimal(dgvDiarioCabeceraDet.Rows[index].Cells["DEBE"].Value);
                win.Haber_ = Convert.ToDecimal(dgvDiarioCabeceraDet.Rows[index].Cells["HABER"].Value);
                win.Glosa_ = dgvDiarioCabeceraDet.Rows[index].Cells["GLOSA_"].Value.ToString();
                win.Cuenta_ = dgvDiarioCabeceraDet.Rows[index].Cells["PLCODI"].Value.ToString();
                win.ShowDialog();
                if (win._Save)
                {
                    DiarioDetalle();
                }
            }
        }
    }
}
