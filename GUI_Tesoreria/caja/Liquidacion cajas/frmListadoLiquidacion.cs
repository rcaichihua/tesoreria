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
    public partial class frmListadoLiquidacion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        private static frmListadoLiquidacion frmInstance = null;

        public static frmListadoLiquidacion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListadoLiquidacion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmListadoLiquidacion()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = cn.TraerDataset("USP_BUSCA_LIQUIDACION",txtNroLiquidacion.Text.Trim()==""? null: txtNroLiquidacion.Text.Trim(),
                TxtNombre.Text.Trim() == "" ? null : TxtNombre.Text.Trim(),
                dtpFechaDesde.Value.ToString("yyyyMMdd"),dtpFechaHasta.Value.ToString("yyyyMMdd"),
                RBActivos.Checked ? "1" : (RBAnulados.Checked ? "0" : null)).Tables[0];

            if (dtResultado.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListadoLiquidaciones.DataSource=dtResultado;
            }
            else
            {
                dgvListadoLiquidaciones.DataSource = dtResultado;

                if (dgvListadoLiquidaciones.RowCount > 0)
                {
                    decimal TotalCaja = 0.00m;
                    decimal TotalDeposito = 0.00m;

                    foreach (DataGridViewRow row in dgvListadoLiquidaciones.Rows)
                    {
                        TotalCaja = TotalCaja + Convert.ToDecimal(row.Cells["totalIngresoCaja"].Value);
                        TotalDeposito = TotalDeposito + Convert.ToDecimal(row.Cells["diferenciaDeposito"].Value);
                    }
                    txtTotalIngresoCaja.Text = TotalCaja.ToString("###,###,##0.00");
                    txtTotalDeposito.Text = TotalDeposito.ToString("###,###,##0.00");
                    lblNroLiquidaciones.Text = dgvListadoLiquidaciones.Rows.Count.ToString();
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvListadoLiquidaciones.Rows.Count <= 0) return;
            int index = dgvListadoLiquidaciones.CurrentRow.Index;

            if (dgvListadoLiquidaciones.Rows[index].Cells["Estado"].Value.ToString() == "False")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Liquidacíón ya se encuentra anulada.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMotivoAnulacion win = new frmMotivoAnulacion();
            win.Id = Convert.ToInt32(dgvListadoLiquidaciones.Rows[index].Cells[0].Value);
            win.Tipo = "L";
            win.ShowDialog();
            if (win.save)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void dgvListadoLiquidaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListadoLiquidaciones.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvListadoLiquidaciones.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "False")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void frmListadoLiquidacion_Load(object sender, EventArgs e)
        {
            BtnBuscar_Click(sender,e);
        }

        private void btnVerReciboCaja_Click(object sender, EventArgs e)
        {
            if (dgvListadoLiquidaciones.Rows.Count <= 0) return;
            int index = dgvListadoLiquidaciones.CurrentRow.Index;

            if (dgvListadoLiquidaciones.Rows[index].Cells["Estado"].Value.ToString() == "False")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se puede ver recibos, liquidación anulada.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Convert.ToDecimal(dgvListadoLiquidaciones.Rows[index].Cells["TotalRecibo"].Value) <=0 )
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene recibos generados.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmListadoRecibosCajaxPrograma win = new frmListadoRecibosCajaxPrograma();
            win.IdLiquidacion= Convert.ToInt32(dgvListadoLiquidaciones.Rows[index].Cells[0].Value);
            win.ShowDialog();
        }
    }
}

