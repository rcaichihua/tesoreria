using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Globalization;

namespace GUI_Tesoreria.caja
{
    public partial class frmCtaCteResidente : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cn = new CNegocio();
        public int idResidente;
        public string nombreResidente = "";
        public string Ubicacion = "";
        public new Form ParentForm;
        public DataGridView dgv;
        public bool binv = false;

        public frmCtaCteResidente()
        {
            InitializeComponent();
        }

        private void BtnSalirC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (dgvCta.RowCount - 1)); i++)
            {
                dgvCta.Rows[i].Cells["TipoPago"].Value = true;
                dgvCta.Rows[i].Cells["seleccion"].Value = true;
            }
        }

        private void rdbNinguno_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (dgvCta.RowCount - 1)); i++)
            {
                dgvCta.Rows[i].Cells["seleccion"].Value = false;
            }
        }

        private void dgvCta_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCta.IsCurrentCellDirty)
            {
                dgvCta.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            //DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)(this.dgvCta.CurrentCell);
            //if (cb != null)
            //{
            //    dgvCta.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }

        private void dgvCta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCta.Columns[e.ColumnIndex].Name == "seleccion")
            {
                DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                checkCell = (DataGridViewCheckBoxCell)dgvCta.Rows[e.RowIndex].Cells["seleccion"];
                DataGridViewCell cellAcuenta = dgvCta.Rows[e.RowIndex].Cells["acuenta"];

                if (checkCell.Value == DBNull.Value)
                {
                    checkCell.Value = false;

                }
                if (Convert.ToBoolean(checkCell.Value) == true)
                {
                    dgvCta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                    dgvCta.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    cellAcuenta.Value = 0.00;

                    dgvCta.Rows[e.RowIndex].Cells[9].Value = 1;
                }
                SumaTotales();
            }

            if (dgvCta.Columns[e.ColumnIndex].Name == "TipoPago")
            {
                DataGridViewComboBoxCell combo = dgvCta.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                int idDescuento = Convert.ToInt32(combo.Value);

                DataGridViewCell cellAcuenta = dgvCta.Rows[e.RowIndex].Cells["acuenta"];
                DataGridViewCell cellDscto = dgvCta.Rows[e.RowIndex].Cells["dscto"];

                if (idDescuento == 2)
                {
                    if (Convert.ToDecimal(cellDscto.Value) != 0.00m)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Cuando se realice pagos a cuenta no se consideraran los descuentos.",
                                VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    SumaTotales();
                    dgvCta.CurrentCell = cellAcuenta;
                    dgvCta.BeginEdit(true);
                }
                else
                {
                    cellAcuenta.Value = 0.00;
                }
            }
            if (dgvCta.Columns[e.ColumnIndex].Name == "Acuenta")
            {
                if (dgvCta.Rows[e.RowIndex].Cells["acuenta"].Value.ToString() != string.Empty)
                {

                    if (Convert.ToDecimal(dgvCta.Rows[e.RowIndex].Cells["acuenta"].Value) >= Convert.ToDecimal(dgvCta.Rows[e.RowIndex].Cells["totalDeuda"].Value))
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El Acuenta no puede mayor o igual a pago total",
                                VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El Acuenta no puede estar vacio.",
                                VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SumaTotales();
            }
        }

        private void SumaTotales()
        {
            decimal sumaTotal = 0.00m;

            foreach (DataGridViewRow row in dgvCta.Rows)
            {
                if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true && Convert.ToInt32(row.Cells["TipoPago"].Value) == 1)
                {
                    if (row.Cells["TotalDeuda"].ToString() == string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese valores correctos en la columna Totales",
                            VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    sumaTotal = sumaTotal + Convert.ToDecimal(row.Cells["TotalDeuda"].Value);
                }
                else if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true && Convert.ToInt32(row.Cells["TipoPago"].Value) == 2)
                {
                    if (row.Cells["ACuenta"].Value.ToString() == string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese valores correctos en la columna ACuenta",
                            VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    sumaTotal = sumaTotal + Convert.ToDecimal(row.Cells["ACuenta"].Value);
                }
            }

            txtTotal.Text = sumaTotal.ToString("##,##0.00");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var frm = (frmPagoDiversos)this.ParentForm;

            foreach (DataGridViewRow row in dgvCta.Rows)
            {
                if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true && Convert.ToInt32(row.Cells["TipoPago"].Value) == 1)
                {
                    if (row.Cells["TotalDeuda"].Value.ToString() == string.Empty)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese valores correctos en la celda de Totales",
                            VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    row.Cells["ACuenta"].Value = 0.00m;
                }
                else if (Convert.ToBoolean(row.Cells["seleccion"].Value) == true && Convert.ToInt32(row.Cells["TipoPago"].Value) == 2)
                {
                    if (row.Cells["ACuenta"].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToDecimal(row.Cells["ACuenta"].Value) == 0.00m || Convert.ToDecimal(row.Cells["ACuenta"].Value) >= Convert.ToDecimal(row.Cells["TotalDeuda"].Value))
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese valores correctos en la columna ACuenta - No puede estar vacio o ser mayor o igual al pago total en el Mes de "
                                + row.Cells["mesDeuda"].Value.ToString() + " del año " + row.Cells["aFiscal"].Value.ToString() + ".",
                                VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese valores correctos en la columna ACuenta - No puede estar vacio o ser mayor o igual al pago total en el Mes de "
                                + row.Cells["mesDeuda"].Value.ToString() + " del año " + row.Cells["aFiscal"].Value.ToString() + ".",
                                VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["dscto"].Value = 0.00m;
                }
            }

            CopyDataGridView(dgvCta, frm.dgvCtaCte);
            this.Close();
        }

        private void CopyDataGridView(DataGridView dgv_org, DataGridView dgv_copy)
        {
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgv_org.Rows[i].Cells["seleccion"].Value) == true)
                    {
                        row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                        int intColIndex = 0;
                        foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                        {
                            if (intColIndex == 7)
                            {
                                row.Cells[intColIndex + 1].Value = cell.Value;
                            }
                            else if (intColIndex == 8)
                            {
                                if (Convert.ToDecimal(cell.Value) != 0)
                                {
                                    row.Cells[intColIndex].Value = cell.Value;
                                    row.Cells[intColIndex - 1].Value = cell.Value;
                                }
                                else
                                {
                                    row.Cells[intColIndex - 1].Value = cell.Value;
                                }
                            }
                            else
                            {
                                row.Cells[intColIndex].Value = cell.Value;
                            }
                            intColIndex++;
                        }

                        dgv_copy.Rows.Add(row);
                    }
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception)
            {
            }
        }

        private void cargarTiposPago()
        {
            DataGridViewComboBoxColumn dgccomboDescuento = dgvCta.Columns["tipopago"] as DataGridViewComboBoxColumn;

            dgccomboDescuento.DataSource = cn.TraerDataset("usp_select_tb_tiposCancelacion").Tables[0];
            dgccomboDescuento.DisplayMember = "nombreTipoCancelacion";
            dgccomboDescuento.ValueMember = "tipoCancelacionID";
        }

        private void dgvCta_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView.HitTestInfo info = this.dgvCta.HitTest(e.X, e.Y);

                if (info.Type == DataGridViewHitTestType.Cell)
                {
                    switch (info.ColumnIndex)
                    {
                        case 9:
                            this.dgvCta.CurrentCell =
                                this.dgvCta.Rows[info.RowIndex].Cells[info.ColumnIndex];
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvCta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCta.CurrentCell.ColumnIndex == 8)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvCta_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvCta_KeyPress);
                }
            }
        }

        private void dgvCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCta.CurrentCell.ColumnIndex == 8)
            {
                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                    )
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                        e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DataSet dtsResultado = new DataSet();

            try
            {
                if (Convert.ToInt32(cboHasta.Text) >= Convert.ToInt32(cboDesde.Text))
                {
                    dtsResultado = cn.TraerDataset("usp_calculo_estado_cta_cte", idResidente, cboDesde.Text, cboHasta.Text,false/*,DateTime.Now.ToShortDateString()*/);

                    if (dtsResultado.Tables[0].Rows.Count > 0)
                    {
                        cargarTiposPago();
                        dgvCta.DataSource = dtsResultado.Tables[0];
                        dgvCta.AutoGenerateColumns = false;
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No tiene deudas para el rango seleccionado", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Selecciones un rango de fechas válido", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
            }
        }

        private void frmCtaCteResidente_Load(object sender, EventArgs e)
        {
            cboDesde.Text = DateTime.Now.Year.ToString();
            cboHasta.Text = DateTime.Now.Year.ToString();
            if (binv == true)
            {
                groupBox2.Enabled = false;
                grbSeleccionar.Enabled = false;
                btnOk.Enabled = false;
            }

            CargarAnio();
        }

        private void CargarAnio()
        {
            try
            {
                cboDesde.DataSource = cn.TraerDataset("usp_select_anio", 1).Tables[0];
                cboDesde.DisplayMember = "intAFDescripcionAnno";
                cboDesde.ValueMember = "intAFDescripcionAnno";

                cboHasta.DataSource = cn.TraerDataset("usp_select_anio", 1).Tables[0];
                cboHasta.DisplayMember = "intAFDescripcionAnno";
                cboHasta.ValueMember = "intAFDescripcionAnno";
            }
            catch (Exception ex)
            {
            }
        }

        private void btnImprimie_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte winReport = new frmReporte();
                DataSet dtsResultado = new DataSet();
                dtsResultado = cn.TraerDataset("usp_calculo_estado_cta_cte", idResidente, cboDesde.Text, cboHasta.Text, true/*, DateTime.Now.ToShortDateString()*/);

                if (dtsResultado.Tables[0].Rows.Count > 0)
                {
                    Reportes.rptEstadoDeCuentaResidente rptCtaCte = new Reportes.rptEstadoDeCuentaResidente();
                    rptCtaCte.SetDataSource(dtsResultado.Tables[0]);
                    rptCtaCte.SetParameterValue("@nombreresidente", nombreResidente);
                    rptCtaCte.SetParameterValue("@ubicacion", Ubicacion);
                    winReport.crvReportes.ReportSource = rptCtaCte;
                    winReport.WindowState = FormWindowState.Maximized;
                    winReport.ShowDialog();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No tiene deudas para el rango seleccionado", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}


