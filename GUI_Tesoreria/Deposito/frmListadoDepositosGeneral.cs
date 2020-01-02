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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dgvListadoVouchers.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(this.dgvListadoVouchers, sfd.FileName); // Here dataGridview1 is your grid view name
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListadoVouchers.CurrentRow != null)
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de eliminar el voucher seleccionado?" + Environment.NewLine +
                                                                "una vez eliminado ya no se podra recuperer el registro " + Environment.NewLine +
                                                                "" + Environment.NewLine + Environment.NewLine
                                                                + "", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    int index = 0;
                    index = dgvListadoVouchers.CurrentRow.Index;

                    if (cn.EjecutarSP("USP_ELIMINA_VOUCHERS", dgvListadoVouchers.Rows[index].Cells[15].Value.ToString(),
                        Convert.ToInt32(dgvListadoVouchers.Rows[index].Cells[1].Value), VariablesMetodosEstaticos.varUsuario,
                        VariablesMetodosEstaticos.host_user)>0)
                    {
                        MessageBox.Show("Voucher Eliminado correctamente.", VariablesGlobales.NombreMensajes,
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnVer_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo.", VariablesGlobales.NombreMensajes,
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
