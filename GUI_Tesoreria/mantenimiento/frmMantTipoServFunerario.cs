using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using DAO_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantTipoServFunerario : frmPadre
    {
        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantTipoServFunerario frmInstance = null;

        public frmMantTipoServFunerario()
        {
            InitializeComponent();
        }

        public static frmMantTipoServFunerario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantTipoServFunerario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantTipoServFunerario_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarTipServFun();
            if (dgvTipoServFun.RowCount > 0) { CargaDatosxId(); }
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvTipoServFun.RowCount > 0)
            {
                int indice = dgvTipoServFun.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            CapaNegocioLinQ cn = new CapaNegocioLinQ();
                            ta_serviciosFunerarios tipSep = new ta_serviciosFunerarios();

                            tipSep.intServFunId = Convert.ToInt32(txtId.Text.Trim());

                            cn.eliminarTipServFun(tipSep);

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
            if (this.dgvTipoServFun.RowCount > 0)
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
            varGlobales.habilitarCampos(this, false);
            cargarTipServFun();
            accion = "";
            dgvTipoServFun_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int rspta = 0;

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

                if (accion == "I")
                {
                    if ((MessageBox.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        CapaNegocioLinQ cn = new CapaNegocioLinQ();
                        ta_serviciosFunerarios tipServFun = new ta_serviciosFunerarios();

                        tipServFun.varServFunDescripcion = txtNombre.Text.Trim();

                        rspta = cn.insertarActualizarlistarTipServFun(tipServFun);

                        if (rspta == 1)
                        {
                            MessageBox.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error, intenete de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (accion == "U")
                {
                    CapaNegocioLinQ cn = new CapaNegocioLinQ();
                    ta_serviciosFunerarios tipServFun = new ta_serviciosFunerarios();

                    tipServFun.intServFunId = Convert.ToInt32(txtId.Text.Trim());
                    tipServFun.varServFunDescripcion = txtNombre.Text.Trim();

                    rspta = cn.insertarActualizarlistarTipServFun(tipServFun);

                    if (rspta == 2)
                    {
                        MessageBox.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intenete de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void dgvTipoServFun_Click(object sender, EventArgs e)
        {
            if (dgvTipoServFun.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvTipoServFun_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvTipoServFun_Click(sender, e);
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
                if (dgvTipoServFun.RowCount > 0)
                {
                    fila = dgvTipoServFun.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvTipoServFun.Rows[fila].Cells[0].Value);

                    this.txtId.Text = (dgvTipoServFun.Rows[fila].Cells[0].Value.ToString());
                    this.txtNombre.Text = (dgvTipoServFun.Rows[fila].Cells[1].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarTipServFun()
        {
            var dt = new DataTable();
            try
            {
                CapaNegocioLinQ cn = new CapaNegocioLinQ();

                dt = cn.listarTipServFun();
                dgvTipoServFun.Refresh();
                dgvTipoServFun.DataSource = dt;
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
            dgvTipoServFun.Enabled = G;
        }
    }
}
