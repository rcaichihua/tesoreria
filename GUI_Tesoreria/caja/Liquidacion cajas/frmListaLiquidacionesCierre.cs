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
    public partial class frmListaLiquidacionesCierre : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmListaLiquidacionesCierre()
        {
            InitializeComponent();
        }
        private static frmListaLiquidacionesCierre frmInstance = null;
        public static frmListaLiquidacionesCierre Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListaLiquidacionesCierre();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        CNegocio cn = new CNegocio();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = cn.TraerDataset("USP_BUSCA_Nro_Liquidacion", dtpFechaDesde.Value.ToString("yyyyMMdd"), 
                dtpFechaHasta.Value.ToString("yyyyMMdd"),
                RBActivos.Checked ? "0" : (RBAnulados.Checked ? "1" : null)).Tables[0];

            if (dtResultado.Rows.Count <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListadoLiquidaciones.DataSource = dtResultado;
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

        private void btnCerrarLiquidacion_Click(object sender, EventArgs e)
        {
            if (dgvListadoLiquidaciones.Rows.Count <= 0) return;
            int index = dgvListadoLiquidaciones.CurrentRow.Index;
            decimal resu = 0.00m;
            DataTable dtResultado = new DataTable();
            DataTable dtResultado_totalLiq = new DataTable();

            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta Seguro de CERRAR.?", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {

                if (dgvListadoLiquidaciones.Rows[index].Cells["Estado"].Value.ToString() == "CERRADO")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Fecha de liquidación ya se encuentra cerrada.", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Convert.ToDecimal(dgvListadoLiquidaciones.Rows[index].Cells["TotalRecibo"].Value) <
                    Convert.ToDecimal(dgvListadoLiquidaciones.Rows[index].Cells["diferenciaDeposito"].Value))
                {
                    dtResultado_totalLiq = cn.TraerDataset("usp_SumaTotal_Carta_Fianza",
                    Convert.ToDateTime(dgvListadoLiquidaciones.Rows[index].Cells["FechaLiquidacion"].Value).ToString("yyyyMMdd")).Tables[0];

                    if (Convert.ToDecimal(dgvListadoLiquidaciones.Rows[index].Cells["TotalRecibo"].Value) +
                        Convert.ToDecimal(dtResultado_totalLiq.Rows[0][0].ToString()) !=
                        Convert.ToDecimal(dgvListadoLiquidaciones.Rows[index].Cells["diferenciaDeposito"].Value))
                    {
                        //if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Al parecer falta recibos por ingresar, esta seguro de cerrar la fecha de liquidación seleccionada.?", VariablesMetodosEstaticos.encabezado,
                        //  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No))
                        //{
                        //}
                        DevComponents.DotNetBar.MessageBoxEx.Show("Quedan recibos pendientes por ingresar.", VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                dtResultado = cn.TraerDataset("usp_CerrarLiquidacion",
                    Convert.ToDateTime(dgvListadoLiquidaciones.Rows[index].Cells["FechaLiquidacion"].Value).ToString("yyyyMMdd"),
                    VariablesMetodosEstaticos.varNombreUser, VariablesMetodosEstaticos.ip_user + "/" + VariablesMetodosEstaticos.host_user).Tables[0];
                if (decimal.TryParse(dtResultado.Rows[0][0].ToString(),out resu))
                {
                    if (Convert.ToDecimal(dtResultado.Rows[0][0]) <= Convert.ToDecimal(dgvListadoLiquidaciones.Rows[index].Cells["totalIngresoCaja"].Value))
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Liquidación cerrado correctamente.", VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnBuscar_Click(sender, e);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El monto total de cierre no coincide con el total de los recibos de caja, se procedera a anular.", VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BtnBuscar_Click(sender, e);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(dtResultado.Rows[0][0].ToString(), VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListadoLiquidaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListadoLiquidaciones.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvListadoLiquidaciones.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "CERRADO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
            }
        }

        private void frmListaLiquidacionesCierre_Load(object sender, EventArgs e)
        {
            BtnBuscar_Click(sender, e);
        }
    }
}
