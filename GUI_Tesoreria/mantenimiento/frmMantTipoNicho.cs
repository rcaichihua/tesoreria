using System;
using System.Windows.Forms;
using DAO_Tesoreria;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantTipoNicho : frmPadre
    {
        private CNegocio cd = new CNegocio();
        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantTipoNicho frmInstance = null;
        public frmMantTipoNicho()
        {
            InitializeComponent();
        }

        public static frmMantTipoNicho Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantTipoNicho();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantTipoNicho_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarTipoNicho();
            if (dgvTipoNicho.RowCount > 0) { CargaDatosxId(); }
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
            txtNombreNIcho.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvTipoNicho.RowCount > 0)
            {
                int indice = dgvTipoNicho.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cd.EjecutarSP("usp_mantenimiento_tipoNicho", dgvTipoNicho.Rows[indice].Cells[0].Value,"", accion) == 1)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No se elimino, verifíque o intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                                return;
                            }
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
            if (this.dgvTipoNicho.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtNombreNIcho.Focus();
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
            cargarTipoNicho();
            accion = "";
            dgvTipoNicho_Click(sender, e);
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
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                int indice = dgvTipoNicho.CurrentRow.Index;

                if (accion == "I")
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cd.EjecutarSP("usp_mantenimiento_tipoNicho", 0, txtNombreNIcho.Text.Trim(), accion);

                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (accion == "U")
                {
                    cd.EjecutarSP("usp_mantenimiento_tipoNicho", dgvTipoNicho.Rows[indice].Cells[0].Value, txtNombreNIcho.Text.Trim(), accion);


                    DevComponents.DotNetBar.MessageBoxEx.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                if (dgvTipoNicho.RowCount > 0)
                {
                    fila = dgvTipoNicho.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvTipoNicho.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cd.TraerDataset("usp_select_TipoNicho_all_x_id", xcod).Tables[0];
                    this.txtId.Text = (dt.Rows[0][0].ToString());
                    this.txtNombreNIcho.Text = (dt.Rows[0][1].ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarTipoNicho()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_TipoNicho_all_x_id", 0).Tables[0];
                //dgvUsuarios.DataSource = null;
                dgvTipoNicho.Refresh();
                dgvTipoNicho.DataSource = dt;
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
            dgvTipoNicho.Enabled = G;
        }

        private void dgvTipoNicho_Click(object sender, EventArgs e)
        {
            if (dgvTipoNicho.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvTipoNicho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvTipoNicho_Click(sender, e);
        }
    }
}
