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
        public string _Anio { get; set; }
        public string _Mes { get; set; }
        public DateTime _FechaLiq { get; set; }
        public string _Fuente { get; set; }

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
            if (_Fuente=="08")
            {
                btnExportar.Enabled = false;
            }
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
                        caja= TipoCaja,
                        _FechaLiq=_FechaLiq,
                        _Fuente_=_Fuente
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string idTipo;
            string PROG_COD;
            PROG_COD = "";
            idTipo = "";

            if (Convert.ToInt16(_Fuente)<1 && Convert.ToInt16(_Fuente) >4)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se puede migrar estos vouchers", VariablesGlobales.NombreMensajes,
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de exportar la información al sistem de vouchers "+ (_Fuente == "03" ? "INMOBILIARIA" : (_Fuente == "04" ? "CEMENTERIO" : (_Fuente == "01" ?
                          "ALTA DIRECCION" : (_Fuente == "02" ? "ALBERGUE" : "-")))) + "?" +
                Environment.NewLine + "Si la información existe en el sistema de voushers se eliminara.",
                VariablesMetodosEstaticos.encabezado,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    cn.EjecutarUD("delete from [192.168.1.7].DBERP.DBO.deposito where CONVERT(varchar(10),FEC_LIQ,103)='" + _FechaLiq.ToString("dd/MM/yyyy") + "' AND PROG_COD='"+ _Fuente + "'");
                    foreach (DataGridViewRow item in dgvListadoVouchers.Rows)
                    {
                        idTipo = cn.EjecutarSqlDTS("select idTipo from ta_modalidad_pago where cod_mod_Pago='"+ item.Cells["cod_mod_Pago"].Value + "'").Tables[0].Rows[0][0].ToString();

                        if (Convert.ToInt32(idTipo)>3)
                        {
                            idTipo = "3";
                        }
                        cn.EjecutarUD("INSERT INTO [192.168.1.7].DBERP.DBO.DEPOSITO " +
                        "(ANO, MES, PROG_COD, BANCO_COD, CUENTA_NUM, CONCEP_COD, " +
                            " FEC_LIQ, FEC_DEPO, MODAL_COD, IMPORTE, MONE_COD, CAMBIO, " +
                            " IMPORTE_ME, VOUCHER, CHEQUE, GLOSA, USUARIO, FEC_CREA, FEC_MODI, USUARIO2, TIPO_REG) " +
                         " VALUES " +
                         " (" + _Anio + ", '" + Convert.ToInt32(_Mes).ToString("00") + "' , '"+ _Fuente + "', '" + Convert.ToInt32(item.Cells["cod_entidad_financ"].Value).ToString("00")
                         + "', '" + item.Cells["numero_cuenta"].Value + "', '" + (Convert.ToInt32(item.Cells["concep_cod"].Value).ToString("00") == "06" ? "05" : (Convert.ToInt32(item.Cells["concep_cod"].Value).ToString("00"))) + "'," +
                          " '" + _FechaLiq.ToString("dd/MM/yyyy") + "', '" + item.Cells["FechaDeposito"].Value + "', '" +
                          (idTipo.ToString() == "1" ? "1" : (idTipo.ToString() == "2" ? "2" : (idTipo.ToString() == "3" ? "1" : "3"))) +
                          "', " + Convert.ToDecimal(item.Cells["importe_cambio"].Value) + ", '" + (Convert.ToDecimal(item.Cells["TipoCambio"].Value) != 1.00m ? "2" : "1") +
                          "', " + (Convert.ToDecimal(item.Cells["TipoCambio"].Value) == 1.00m ? 0.00m : Convert.ToDecimal(item.Cells["TipoCambio"].Value)) + ", " +
                          " " + (Convert.ToDecimal(item.Cells["TipoCambio"].Value) == 1.00m ? 0.00m : Convert.ToDecimal(item.Cells["importe_voucher_pago"].Value)) + ", '" +
                          (item.Cells["cod_mod_Pago"].Value.ToString() != "2" ? (item.Cells["NumeroDocumento_Voucher_cheque_pago"].Value) : ("")) + "', '" +
                          (item.Cells["cod_mod_Pago"].Value.ToString() == "2" ? (item.Cells["NumeroDocumento_Voucher_cheque_pago"].Value) : ("")) + "', '" +
                          (_Fuente == "03" ? "ARRENDT":(_Fuente=="04" ? "CEMENT" : (_Fuente =="01" ? 
                          "ALT DIRE":(_Fuente=="02" ? "ALBERGUE":"")))) + "', '" + 
                          VariablesGlobales.NombreUsuario + "', GETDATE(), NULL, NULL, '1')");
                    }
                    DevComponents.DotNetBar.MessageBoxEx.Show("Se exporto los vouchers correctamente.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesGlobales.NombreMensajes,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }
    }
}
