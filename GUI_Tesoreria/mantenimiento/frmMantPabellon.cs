using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DAO_Tesoreria;
using System.Data.SqlClient;
using System.Collections.Generic;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantPabellon : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cd = new CNegocio();
        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantPabellon frmInstance = null;

        public frmMantPabellon()
        {
            InitializeComponent();
        }

        public static frmMantPabellon Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantPabellon();
            }
            frmInstance.BringToFront();
            return frmInstance;
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
            if (this.dgvPabellon.RowCount > 0)
            {
                int indice = dgvPabellon.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cd.EjecutarSP("usp_mantenimiento_pabellon", dgvPabellon.Rows[indice].Cells[0].Value, "",
                                "", accion) == 1)
                            {
                                MessageBox.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("No se elimino, verifíque o intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
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
            if (this.dgvPabellon.RowCount > 0)
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
            cargarPabellon();
            accion = "";
            dgvPabellon_Click(sender, e);
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

                int indice = dgvPabellon.CurrentRow.Index;

                if (accion == "I")
                {
                    if ((MessageBox.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cd.EjecutarSP("usp_mantenimiento_pabellon", 0, txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), accion);

                        MessageBox.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (accion == "U")
                {
                    cd.EjecutarSP("usp_mantenimiento_pabellon", dgvPabellon.Rows[indice].Cells[0].Value, txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), accion);


                    MessageBox.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                if (dgvPabellon.RowCount > 0)
                {
                    fila = dgvPabellon.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvPabellon.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cd.TraerDataset("usp_select_Pabellon_all_x_id", xcod).Tables[0];
                    this.txtId.Text = (dt.Rows[0][0].ToString());
                    this.txtNombre.Text = (dt.Rows[0][1].ToString());
                    this.txtDescripcion.Text = (dt.Rows[0][2].ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarPabellon()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_Pabellon_all_x_id", 0).Tables[0];
                dgvPabellon.Refresh();
                dgvPabellon.DataSource = dt;
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
            dgvPabellon.Enabled = G;
        }

        private void dgvPabellon_Click(object sender, EventArgs e)
        {
            if (dgvPabellon.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvPabellon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvPabellon_Click(sender, e);
        }

        private void frmMantPabellon_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarPabellon();
            if (dgvPabellon.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
        }
    }
}