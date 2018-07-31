using System;
using System.Data;
using System.Windows.Forms;
using DAO_Tesoreria;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantZona : frmPadre
    {
        private CapaNegocioLinQ tipoZonaLinq = new CapaNegocioLinQ();
        private CNegocio cn = new CNegocio();
        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantZona frmInstance = null;

        public frmMantZona()
        {
            InitializeComponent();
        }

        public static frmMantZona Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantZona();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmServicioSepultura_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarZonas();
            cargarComboCementerio();
            cargarComboTipoZonas();
            if (dgvZonas.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            varGlobales.resetearCampos(this);
            txtNombre.Focus();
            chkConstruido.Checked = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvZonas.RowCount > 0)
            {
                int indice = dgvZonas.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            ta_zona zona = new ta_zona();
                            zona.intZId = Convert.ToInt32(txtId.Text.Trim());

                            tipoZonaLinq.eliminarZonas(zona);

                            MessageBox.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        }
                        else
                        {
                            return;
                        }
                    }
                    btnCancelar_Click(sender, e);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + varglo.mensajeError(Convert.ToInt32(ex.Errors[0].Number)), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("No Existen Datos a Modificar, verifíque", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvZonas.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("No Existen Datos a Modificar, verifique",
                    VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            cargarZonas();
            varGlobales.habilitarCampos(this, false);
            accion = "";
            dgvZonas_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("txtId");

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    MessageBox.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                //int indice = dgvZonas.CurrentRow.Index;

                if (accion == "I")
                {
                    if ((MessageBox.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        ta_zona zona = new ta_zona();
                        zona.intTzId = Convert.ToInt32(cboTipoZona.SelectedValue);
                        zona.bitZEstado = chkActivo.Checked;
                        zona.bitZConstruido = chkConstruido.Checked;
                        zona.varZDescripcion = txtNombre.Text.Trim();
                        zona.intZnroFilas = Convert.ToInt32(txtNroFilas.Text.Trim());
                        zona.intZNivel = Convert.ToInt32(txtNiveles.Text.Trim());
                        zona.intZnroSepulturas = Convert.ToInt32(txtNroColumnas.Text.Trim());
                        zona.intCeId = Convert.ToInt32(cboCementerio.SelectedValue);

                        byte resu = tipoZonaLinq.insertarActualizarZonas(zona);

                        if (resu == 1)
                        {
                            MessageBox.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error, intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }

                    }
                    else
                    {
                        return;
                    }
                }
                else if (accion == "U")
                {
                        ta_zona zona = new ta_zona();

                        zona.intZId = Convert.ToInt32(txtId.Text.Trim());
                        zona.intTzId = Convert.ToInt32(cboTipoZona.SelectedValue);
                        zona.bitZEstado = chkActivo.Checked;
                        zona.bitZConstruido = chkConstruido.Checked;
                        zona.varZDescripcion = txtNombre.Text.Trim();
                        zona.intZnroFilas = Convert.ToInt32(txtNroFilas.Text.Trim());
                        zona.intZNivel = Convert.ToInt32(txtNiveles.Text.Trim());
                        zona.intZnroSepulturas = Convert.ToInt32(txtNroColumnas.Text.Trim());
                        zona.intCeId = Convert.ToInt32(cboCementerio.SelectedValue);

                        byte resu = tipoZonaLinq.insertarActualizarZonas(zona);

                        if (resu == 2)
                        {
                            MessageBox.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error, intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }

                }
                btnCancelar_Click(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + varglo.mensajeError(Convert.ToInt32(ex.Errors[0].Number)), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvZonas_Click(object sender, EventArgs e)
        {
            if (dgvZonas.RowCount > 0) { CargaDatosxId(); }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvZonas_Click(sender,e);
        }

        private void GeneradorToolTip()
        {
            toolTip.SetToolTip(this.btnEditar, "Edita el elemento seleccionado");
            toolTip.SetToolTip(this.btnCancelar, "Cancela los posibles cambios sobre el elemento seleccionado");
            toolTip.SetToolTip(this.btnGuardar, "Guarda el registro");
            toolTip.SetToolTip(this.btnEliminar, "Elimina el elemento seleccionado");
            toolTip.SetToolTip(this.btnSalir, "Salir del mantenimiento");
            toolTip.SetToolTip(this.btnNuevo, "Permite ingresar un nuevo elemento");
        }

        public void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvZonas.RowCount > 0)
                {
                    fila = dgvZonas.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvZonas.Rows[fila].Cells[0].Value);

                    txtId.Text = dgvZonas.Rows[fila].Cells[0].Value.ToString();
                    cboTipoZona.Text = dgvZonas.Rows[fila].Cells[1].Value.ToString();
                    txtNombre.Text = dgvZonas.Rows[fila].Cells[2].Value.ToString();
                    cboCementerio.Text = dgvZonas.Rows[fila].Cells[4].Value.ToString();
                    chkConstruido.Checked = Convert.ToBoolean(dgvZonas.Rows[fila].Cells[3].Value);
                    chkActivo.Checked = Convert.ToBoolean(dgvZonas.Rows[fila].Cells[8].Value);
                    txtNroFilas.Text = dgvZonas.Rows[fila].Cells[6].Value.ToString();
                    txtNiveles.Text = dgvZonas.Rows[fila].Cells[7].Value.ToString();
                    txtNroColumnas.Text = dgvZonas.Rows[fila].Cells[5].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarZonas()
        {
            var dt = new DataTable();
            try
            {
                dt = tipoZonaLinq.listarZonas(0);
                dgvZonas.Refresh();
                dgvZonas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void habilitaBotones(bool G)
        {
            btnNuevo.Enabled = G;
            btnGuardar.Enabled = !G;
            btnCancelar.Enabled = !G;
            btnEditar.Enabled = G;
            btnEliminar.Enabled = G;
            dgvZonas.Enabled = G;
        }

        private void cargarComboCementerio()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "C").Tables[0];
                    cboCementerio.DataSource = dt;
                    cboCementerio.DisplayMember = "varCeNombre";
                    cboCementerio.ValueMember = "intCeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cargarComboTipoZonas()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "Z").Tables[0];
                cboTipoZona.DataSource = dt;
                cboTipoZona.DisplayMember = "varTZDescripcion";
                cboTipoZona.ValueMember = "intTZId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtNroFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void txtNiveles_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }
    }
}
