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
    public partial class frmListadoDepositosLiquidacion : DevComponents.DotNetBar.Metro.MetroForm
    {
        public bool Existe { get; set; }
        public bool Save__ { get; set; }
        public string TipoCaja { get; set; }
        public DataTable dtListadoVouchers { get; set; }
        CNegocio cn = new CNegocio();

        public frmListadoDepositosLiquidacion()
        {
            InitializeComponent();
        }

        private void frmListadoDepositosLiquidacion_Load(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            dgvListadoVouchers.DataSource = dtListadoVouchers;
            AnchoFilas();
            SumarTotales();           
        }

        private void AnularAutocompletadoColumnas()
        {
            this.dgvListadoVouchers.AutoGenerateColumns = false;
            this.dgvListadoVouchers.AutoGenerateColumns = false;
            this.dgvListadoVouchers.AutoGenerateColumns = false;
        }

        private void SumarTotales()
        {
            decimal sumaTotal = 0;
            foreach (DataGridViewRow row in dgvListadoVouchers.Rows)
            {
                sumaTotal = sumaTotal + Convert.ToDecimal(row.Cells[13].Value);
            }
            txtTotalVouchers.Text = sumaTotal.ToString("###,###,##0.00");
        }

        private void AnchoFilas()
        {
            for (int i = 0; i < dgvListadoVouchers.Rows.Count; i++)
            {
                DataGridViewRow row = dgvListadoVouchers.Rows[i];
                row.Height = 35;
            }
        }

        private void dgvListadoVouchers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.editarvoucher.Width;
                var h = Properties.Resources.editarvoucher.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editarvoucher, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListadoVouchers_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex == 0)
                e.ToolTipText = "Editar voucher."; 
        }

        private void dgvListadoVouchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvListadoVouchers.CurrentRow.Index;
            DataTable dtResultadoBusqueda = new DataTable();

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (this.dgvListadoVouchers.Columns[e.ColumnIndex].Name == "Depositos")
                {
                    frmEdicionVouchers winfrmEdicionVouchers = new frmEdicionVouchers
                    {
                        IdDocumento = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[1].Value),
                        Tabla = dgvListadoVouchers.Rows[index].Cells[14].Value.ToString(),
                        ModalidadPagoId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[3].Value),
                        ConceptoId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[2].Value),
                        FechaDeposito = Convert.ToDateTime(dgvListadoVouchers.Rows[index].Cells[5].Value),
                        EntidadFinancieraId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[6].Value),
                        CuentaBancariaId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[8].Value),
                        Monto = Convert.ToDecimal(dgvListadoVouchers.Rows[index].Cells[11].Value),
                        TipoCambio = Convert.ToDecimal(dgvListadoVouchers.Rows[index].Cells[12].Value),
                        Total = Convert.ToDecimal(dgvListadoVouchers.Rows[index].Cells[13].Value),
                        NroVoucher = dgvListadoVouchers.Rows[index].Cells[10].Value.ToString(),
                        Observaciones = dgvListadoVouchers.Rows[index].Cells[15].Value.ToString(),
                        caja= TipoCaja

                    };
                    winfrmEdicionVouchers.Existe_ = Existe;
                    winfrmEdicionVouchers.ShowDialog();

                    if (winfrmEdicionVouchers.Save_==true)
                    {
                        this.Close();
                        Save__ = true;
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReporte win = new frmReporte();
            win.TipoReporteLiquidacion = "VO";
            win.dtR = dtListadoVouchers;
            win.Show();
        }
    }
}
