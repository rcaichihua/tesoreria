using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmPagoCuotas : DevComponents.DotNetBar.Metro.MetroForm
    {   
        public frmPagoCuotas()
        {
            InitializeComponent();
        }

        int cuotas = 0;
        CNegocio cn = new CNegocio();
        DataTable detalleCuotasRecibos;

        public decimal _ImporteDocumento { get; set; }
        public int _ReciboId { get; set; }

        private void frmPagoCuotas_Load(object sender, EventArgs e)
        {
            txtTotalDocumento.Text = _ImporteDocumento.ToString("###,###,###.00");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = (DataGridViewRow)dgvCuotas.RowTemplate.Clone();
            newRow.CreateCells(dgvCuotas);

            newRow.Cells[0].Value = cuotas + 1;
            newRow.Cells[1].Value = 0.00m;

            dgvCuotas.Rows.Add(newRow);

            cuotas = cuotas + 1;

            txtCuotas.Text = cuotas.ToString();
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (cuotas > 0)
            {
                dgvCuotas.Rows.RemoveAt(cuotas - 1);

                cuotas = cuotas - 1;

                txtCuotas.Text = cuotas.ToString();
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (dgvCuotas.Rows.Count > 0)
                SumarTotal();

            if (!VerificaTotales())
                DevComponents.DotNetBar.MessageBoxEx.Show("La suma total de cuotas debe coincidir con el total del documento, verifique.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void SumarTotal()
        {
            decimal total;

            total = 0.00m;

            foreach (DataGridViewRow rows in dgvCuotas.Rows)
            {
                total = total + Convert.ToDecimal(rows.Cells[1].Value);
            }

            txtTotalCuotas.Text = total.ToString("###,###,###.00");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable dtCuotas = new DataTable();

            if (!VerificaCuotas())
                DevComponents.DotNetBar.MessageBoxEx.Show("El importe de las cuotas deben ser mayor a cero(0.00).", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (!VerificaTotales())
                DevComponents.DotNetBar.MessageBoxEx.Show("La suma total de cuotas debe coincidir con el total del documento, verifique.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            ArmarTablasCabeceraDetalle();

            dtCuotas = cn.GeneraCuotasRecibosCaja("usp_genera_cuotas_recibos_caja", detalleCuotasRecibos).Tables[0];
        }

        private void ArmarTablasCabeceraDetalle()
        {
            detalleCuotasRecibos = new DataTable();

            detalleCuotasRecibos.Columns.Add("ReciboId", typeof(int));
            detalleCuotasRecibos.Columns.Add("NroCuota", typeof(int));
            detalleCuotasRecibos.Columns.Add("ImporteCuota", typeof(decimal));

            if (dgvCuotas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCuotas.Rows)
                {
                    DataRow _filaDetalle = detalleCuotasRecibos.NewRow();

                    _filaDetalle["ReciboId"] = _ReciboId;
                    _filaDetalle["NroCuota"] = Convert.ToInt32(row.Cells[0].Value);
                    _filaDetalle["ImporteCuota"] = Convert.ToDecimal(row.Cells[1].Value);

                    detalleCuotasRecibos.Rows.Add(_filaDetalle);
                }
            }
        }

            private bool VerificaTotales()
        {
            bool rspta;

            rspta = true;

            if (Convert.ToDecimal(txtTotalCuotas.Text) != Convert.ToDecimal(txtTotalDocumento.Text))
            {
                rspta = false;
            }

            return rspta;
        }

        private bool VerificaCuotas()
        {
            bool rspta;

            rspta = false;

            foreach (DataGridViewRow rows in dgvCuotas.Rows)
            {
                if (Convert.ToDecimal(rows.Cells[1].Value)==0)
                {
                    rspta = false;
                    break;
                }
                else
                {
                    rspta = true;
                }
            }

            return rspta;
        }
    }
}
