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
using System.Security.Principal;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmMantenimientoCtaCteResidente : DevComponents.DotNetBar.Metro.MetroForm
    {
        WindowsIdentity MyID = WindowsIdentity.GetCurrent();
        private CNegocio cn = new CNegocio();
        private static frmMantenimientoCtaCteResidente frmInstance = null;
        int fila;

        public frmMantenimientoCtaCteResidente()
        {
            InitializeComponent();
        }

        public static frmMantenimientoCtaCteResidente Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantenimientoCtaCteResidente();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantenimientoCtaCteResidente_Load(object sender, EventArgs e)
        {
            //var modificar = new Dictionary<int, bool>();
            cargarAnio();
        }

        private void cargarAnio()
        {
            try
            {
                cboAnio.DataSource = cn.TraerDataset("usp_select_anio", 1).Tables[0];
                cboAnio.DisplayMember = "intAFDescripcionAnno";
                cboAnio.ValueMember = "intAFID";
            }
            catch (Exception)
            {
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                dgvResultado.Focus();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.ToString().Length > 0)
                {
                    DataSet ds = new DataSet();
                    ds = cn.TraerDataset("usp_select_tb_residente_like", txtNombre.Text.Trim());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultado.DataSource = ds.Tables[0];
                        dgvResultado.Visible = true;
                        dgvResultado.BringToFront();
                    }
                    else
                    {
                        dgvResultado.Visible = false;
                    }
                }
                else
                {
                    txtCodigo.Clear();
                    dgvResultado.Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    OcultarGrilla();
                    cboAnio.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        private void OcultarGrilla()
        {
            try
            {
                txtCodigo.Text = dgvResultado.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvResultado.CurrentRow.Cells[1].Value.ToString();
                dgvResultado.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void dgvResultado_DoubleClick(object sender, EventArgs e)
        {
            OcultarGrilla();
        }

        private void BtnCta_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un residente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtNombre.Focus();
                return;
            }
            else if (cboAnio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un año.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                cboAnio.Focus();
                return;
            }
            try
            {
                dgvCtaCte.DataSource = cn.TraerDataset("usp_obtiene_cta_residente",
                    txtCodigo.Text.Trim(), cboAnio.Text).Tables[0];
                dgvCtaCte.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCtaCte_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCtaCte.IsCurrentCellDirty)
            {
                dgvCtaCte.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvCtaCte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCtaCte.CurrentCell.ColumnIndex == 4)
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

        private void dgvCtaCte_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCtaCte.Columns[e.ColumnIndex].Name == "InsolutoCta" || dgvCtaCte.Columns[e.ColumnIndex].Name == "observaciones")
            {
                dgvCtaCte.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }

        private void dgvCtaCte_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCtaCte.CurrentCell.ColumnIndex == 4 || dgvCtaCte.CurrentCell.ColumnIndex == 6)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvCtaCte_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvCtaCte_KeyPress);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool marca = false;
            int resultadiActCta = 0;
            try
            {
                foreach (DataGridViewRow row in dgvCtaCte.Rows)
                {
                    if (row.DefaultCellStyle.BackColor == Color.LightSteelBlue)
                    {
                        marca = true;

                        if (row.Cells["EstadoCta"].Value.ToString() != "A")
                        {
                            resultadiActCta = Convert.ToInt32(cn.TraerDataset("usp_actualiza_ctacte_residente", row.Cells["IdCta"].Value
                            , row.Cells["InsolutoCta"].Value, row.Cells["observaciones"].Value, VariablesMetodosEstaticos.varUsuario
                    , System.Net.Dns.GetHostName().ToUpper(), VariablesMetodosEstaticos.ip_user, MyID.Name.ToUpper()).Tables[0].Rows[0][0].ToString());
                        }
                        else
                        {
                            MessageBox.Show("El mes de" + row.Cells["MesCta"].Value + " del año " + row.Cells["AnioCta"].Value 
                                + " no sera actualizado por estar ANULADO", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, 
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }

                        if (resultadiActCta == 0)
                        {
                            MessageBox.Show("Ocurrio un error en la actualizacion del ID de cuenta : " + row.Cells["IdCta"].Value,
                               VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error
                               , MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                if (marca != false)
                {
                    MessageBox.Show("Actualizado correctamente.",
           VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information
           , MessageBoxDefaultButton.Button1);
                    BtnCta_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No se modifico ningun registro",
          VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information
          , MessageBoxDefaultButton.Button1);
                    BtnCta_Click(sender, e);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            if (dgvCtaCte.RowCount == 0)
            {
                MessageBox.Show("No hay datos para el recalculo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            string estadoRegistro;

            estadoRegistro = dgvCtaCte.Rows[fila].Cells["EstadoCta"].Value.ToString();

            if (estadoRegistro == "A")
            {
                MessageBox.Show("No se puede realizar el recalculo debido a que el año y mes seleccionado esta Anulado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Seguro de realizar el recalculo del mes de " +
                dgvCtaCte.Rows[fila].Cells["MesCta"].Value + " del año " + dgvCtaCte.Rows[fila].Cells["AnioCta"].Value + " ?", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                int resultado = 0;

                dt = cn.TraerDataset("usp_select_total_pension_vs_pago_realizado_residente", dgvCtaCte.Rows[fila].Cells["IdCta"].Value).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(dt.Rows[0][2]) > Convert.ToDecimal(dt.Rows[0][3]))
                    {
                        resultado = cn.EjecutarSP("usp_actualiza_estado_deuda_residente", "E", dgvCtaCte.Rows[fila].Cells["IdCta"].Value);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener los datos. Intente de nuevo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }


                if (resultado > 0)
                {
                    MessageBox.Show("Actualizado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    BtnCta_Click(sender, e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void dgvCtaCte_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fila = dgvCtaCte.CurrentRow.Index;
        }

        private void dgvCtaCte_Click(object sender, EventArgs e)
        {
            fila = dgvCtaCte.CurrentRow.Index;
        }
    }
}
