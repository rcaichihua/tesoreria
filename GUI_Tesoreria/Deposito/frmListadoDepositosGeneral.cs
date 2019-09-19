using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using GUI_Tesoreria.caja.Liquidacion_cajas;

namespace GUI_Tesoreria.Deposito
{
    public partial class frmListadoDepositosGeneral : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string TipoCaja { get; set; }
        public DateTime _FechaLiq { get; set; }

        private static frmListadoDepositosGeneral frmInstance = null;

        public frmListadoDepositosGeneral()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        DataTable dtResultadoBusqueda = new DataTable();
        public bool Save__ { get; set; }

        public static frmListadoDepositosGeneral Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListadoDepositosGeneral();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dtResultadoBusqueda = cn.TraerDataset("usp_lista_vouchers_tesoreria", dtpFechaLiquidación.Value.ToString("yyyMMdd")).Tables[0];
            dgvListadoVouchers.DataSource = dtResultadoBusqueda;
            AnchoFilas();
            SumarTotales();
            lblCantidad.Text = dtResultadoBusqueda.Rows.Count.ToString();
        }

        private void frmListadoDepositosGeneral_Load(object sender, EventArgs e)
        {
            AnularAutocompletadoColumnas();
            AnchoFilas();
            SumarTotales();

            //foreach (DataGridViewColumn column in dgvListadoVouchers.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}
        }

        private void AnularAutocompletadoColumnas()
        {
            this.dgvListadoVouchers.AutoGenerateColumns = false;
        }

        private void SumarTotales()
        {
            decimal sumaTotal = 0;
            foreach (DataGridViewRow row in dgvListadoVouchers.Rows)
            {
                sumaTotal = sumaTotal + Convert.ToDecimal(row.Cells["importe_cambio"].Value);
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
            this.Close();
        }

        private void dgvListadoVouchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                int index = this.dgvListadoVouchers.CurrentRow.Index;
                DataTable dtResultadoBusqueda = new DataTable();
                if (this.dgvListadoVouchers.Columns[e.ColumnIndex].Name == "Depositos")
                {
                    frmEdicionVouchers winfrmEdicionVouchers = new frmEdicionVouchers
                    {
                        IdDocumento = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[1].Value),
                        Tabla = dgvListadoVouchers.Rows[index].Cells[15].Value.ToString(),
                        ModalidadPagoId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[3].Value),
                        ConceptoId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[2].Value),
                        FechaDeposito = Convert.ToDateTime(dgvListadoVouchers.Rows[index].Cells[6].Value),
                        EntidadFinancieraId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[7].Value),
                        CuentaBancariaId = Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[9].Value),
                        Monto = Convert.ToDecimal(dgvListadoVouchers.Rows[index].Cells[12].Value),
                        TipoCambio = Convert.ToDecimal(dgvListadoVouchers.Rows[index].Cells[13].Value),
                        Total = Convert.ToDecimal(dgvListadoVouchers.Rows[index].Cells[14].Value),
                        NroVoucher = dgvListadoVouchers.Rows[index].Cells[11].Value.ToString(),
                        Observaciones = dgvListadoVouchers.Rows[index].Cells[16].Value.ToString(),
                        caja = dgvListadoVouchers.Rows[index].Cells[15].Value.ToString() == "INMOBILIARIA" ? "02":"01",
                        //caja = TipoCaja,
                        _FechaLiq = Convert.ToDateTime(dtpFechaLiquidación.Value)

                    };
                    //winfrmEdicionVouchers.Existe_ = Existe;
                    winfrmEdicionVouchers.ShowDialog();

                    if (winfrmEdicionVouchers.Save_ == true)
                    {
                        //this.Close();
                        btnVer_Click(sender,e);
                        Save__ = true;
                    }
                }
            }
        }
    }
}
