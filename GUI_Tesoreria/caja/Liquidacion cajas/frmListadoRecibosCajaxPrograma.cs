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
    public partial class frmListadoRecibosCajaxPrograma : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public int IdLiquidacion { get; set; }
        CNegocio cn = new CNegocio();

        public frmListadoRecibosCajaxPrograma()
        {
            InitializeComponent();
        }

        private void frmListadoRecibosCajaxPrograma_Load(object sender, EventArgs e)
        {
            LlenaRecibo();
        }

        private void LlenaRecibo()
        {
            DataTable dt = new DataTable();
            decimal total = 0.00m;

            dt = cn.TraerDataset("usp_ListaReciboCajaxPrograma", IdLiquidacion).Tables[0];
            if (dt.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se han generado recibos para la liquidacion seleccionada.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvListadoRecibos.DataSource = dt;
            foreach (DataGridViewRow item in dgvListadoRecibos.Rows)
            {
                total = total + Convert.ToDecimal(item.Cells["totalDocumento"].Value);
            }
            txtTotalIngresoCaja.Text = total.ToString("###,###,##0.00");
            lblNroLiquidaciones.Text = dt.Rows.Count.ToString();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvListadoRecibos.Rows.Count <= 0) return;
            int index = dgvListadoRecibos.CurrentRow.Index;

            if (dgvListadoRecibos.Rows[index].Cells["Estado"].Value.ToString() == "False")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Recibo ya se encuentra anulada.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMotivoAnulacion win = new frmMotivoAnulacion();
            win.Id = Convert.ToInt32(dgvListadoRecibos.Rows[index].Cells[0].Value);
            win.Tipo = "R";
            win.ShowDialog();
            if (win.save)
            {
                LlenaRecibo();
            }
        }

        private void dgvListadoRecibos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListadoRecibos.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvListadoRecibos.Rows)
                {
                    if (row.Cells["ESTADO"].Value.ToString() == "False")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvListadoRecibos.Rows.Count <= 0) return;

            DataTable dt = new DataTable();
            frmImpresionRecibos winReport = new frmImpresionRecibos();
            winReport.GeneraReciboPrincipal = true;
            int index = 0;
            index = dgvListadoRecibos.CurrentRow.Index;

            dt = cn.TraerDataset("usp_ObtieneReciboCajaPrincipal", dgvListadoRecibos.Rows[index].Cells[0].Value).Tables[0];

            Reportes.rptReciboCaja rptRecibo = new Reportes.rptReciboCaja();
            rptRecibo.SetDataSource(dt);
            winReport.crvReportes.ReportSource = rptRecibo;
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListadoRecibos.Rows.Count <= 0) return;

            DataSet ds = new DataSet();
            frmImpresionRecibos winReport = new frmImpresionRecibos();
            int index = 0;
            index = dgvListadoRecibos.CurrentRow.Index;

            if (dgvListadoRecibos.Rows[index].Cells["Estado"].Value.ToString() == "False")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El Recibo se encuentra anulado, no se puede editar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int IdCaja = Convert.ToInt32(dgvListadoRecibos.Rows[index].Cells[0].Value);

            ds = cn.TraerDataset("usp_BuscaDatosReciboCajaLiq", IdCaja);

            if (ds.Tables[0].Rows.Count <= 0) return;

            frmReciboCajaPrincipalModifica win = new frmReciboCajaPrincipalModifica();
            win.IdCaja = IdCaja;
            win.FuenteIngreso = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            win.NroLiquidacion = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());//.ToString("0000000");
            win.FechaCaja = ds.Tables[0].Rows[0][2].ToString();
            win.FechaLiquidacion = ds.Tables[0].Rows[0][3].ToString();
            win.TotalLiquidacion = Convert.ToDecimal(ds.Tables[0].Rows[0][4].ToString());
            win.NroReciboCaja = Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString()).ToString("000000");
            win.usuario = ds.Tables[0].Rows[0][6].ToString();
            win.nombreReceptor = ds.Tables[0].Rows[0][7].ToString();
            win.ModalidadPago = ds.Tables[0].Rows[0][8].ToString();
            win.ImporteIngreso = Convert.ToDecimal(ds.Tables[0].Rows[0][9].ToString());
            win.tc= Convert.ToDecimal(ds.Tables[0].Rows[0][10].ToString());
            win.importeCambio = Convert.ToDecimal(ds.Tables[0].Rows[0][11].ToString());
            win.glosa = ds.Tables[0].Rows[0][12].ToString();
            DataTable dtNew = new DataTable();
            DataTable dtNew2 = new DataTable();
            dtNew = (ds.Tables[1]);//.Copy(ds.Tables[0]);
            dtNew2 = dtNew.Copy();
            DataSet dset = new DataSet();
            dset.Tables.Add(dtNew2);
            win.DetalleRecibo = dset;
            win.ShowDialog();
            LlenaRecibo();
        }
    }
}
