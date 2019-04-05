using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BL_Tesoreria;
using DAO_Tesoreria;
using System.Data.SqlClient;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantEntidadFinanciera : frmPadre
    {
        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantEntidadFinanciera frmInstance = null;

        public frmMantEntidadFinanciera()
        {
            InitializeComponent();
        }

        public static frmMantEntidadFinanciera Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantEntidadFinanciera();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantEntidadFinanciera_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarEntFin();
            if (dgvEntiFinanciera.RowCount > 0) { CargaDatosxId(); }
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
            if (this.dgvEntiFinanciera.RowCount > 0)
            {
                int indice = dgvEntiFinanciera.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            CapaNegocioLinQ cn = new CapaNegocioLinQ();
                            ta_entidad_financiera entFin = new ta_entidad_financiera();

                            entFin.cod_entidad_financ = Convert.ToInt32(txtId.Text.Trim());

                            cn.eliminarEntFin(entFin);

                            DevComponents.DotNetBar.MessageBoxEx.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
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
                    DevComponents.DotNetBar.MessageBoxEx.Show("Error: " + varglo.mensajeError(Convert.ToInt32(ex.Errors[0].Number)), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No Existen Datos a Modificar, verifíque", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEntiFinanciera.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtNombre.Focus();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No Existen Datos a Modificar, verifique",
                    VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            cargarEntFin();
            accion = "";
            dgvEntiFinanciera_Click(sender, e);
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
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                if (accion == "I")
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        CapaNegocioLinQ cn = new CapaNegocioLinQ();
                        ta_entidad_financiera entFin = new ta_entidad_financiera();

                        entFin.nombre_entidad = txtNombre.Text.Trim();
                        entFin.obs_entidad = txtObservacion.Text.Trim();

                        rspta = cn.insertarActualizarEntFin(entFin);

                        if (rspta == 1)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intenete de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
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
                    ta_entidad_financiera entFin = new ta_entidad_financiera();

                    entFin.cod_entidad_financ = Convert.ToInt32(txtId.Text);
                    entFin.nombre_entidad = txtNombre.Text.Trim();
                    entFin.obs_entidad = txtObservacion.Text.Trim();

                    rspta = cn.insertarActualizarEntFin(entFin);

                    if (rspta == 2)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intenete de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                btnCancelar_Click(sender, e);
            }
            catch (SqlException ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error: " + varglo.mensajeError(Convert.ToInt32(ex.Errors[0].Number)), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEntiFinanciera_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvEntiFinanciera_Click(sender, e);
        }

        private void dgvEntiFinanciera_Click(object sender, EventArgs e)
        {
            if (dgvEntiFinanciera.RowCount > 0) { CargaDatosxId(); }
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
                if (dgvEntiFinanciera.RowCount > 0)
                {
                    fila = dgvEntiFinanciera.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvEntiFinanciera.Rows[fila].Cells[0].Value);

                    this.txtId.Text = (dgvEntiFinanciera.Rows[fila].Cells[0].Value.ToString());
                    this.txtNombre.Text = (dgvEntiFinanciera.Rows[fila].Cells[1].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarEntFin()
        {
            var dt = new DataTable();
            try
            {
                CapaNegocioLinQ cn = new CapaNegocioLinQ();

                dt = cn.listarEntFin();
                dgvEntiFinanciera.Refresh();
                dgvEntiFinanciera.DataSource = dt;
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
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
            dgvEntiFinanciera.Enabled = G;
        }
    }
}
