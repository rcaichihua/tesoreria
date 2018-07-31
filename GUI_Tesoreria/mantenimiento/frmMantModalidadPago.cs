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
    public partial class frmMantModalidadPago : frmPadre
    {
         private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantModalidadPago frmInstance = null;

        public frmMantModalidadPago()
        {
            InitializeComponent();
        }

        public static frmMantModalidadPago Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantModalidadPago();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantModalidadPago_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarModPago();
            if (dgvModPago.RowCount > 0) { CargaDatosxId(); }
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
            if (this.dgvModPago.RowCount > 0)
            {
                int indice = dgvModPago.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            CapaNegocioLinQ cn = new CapaNegocioLinQ();
                            ta_modalidad_pago modPago = new ta_modalidad_pago();

                            modPago.cod_mod_Pago = Convert.ToInt32(txtId.Text.Trim());

                            cn.eliminarModPago(modPago);

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
            if (this.dgvModPago.RowCount > 0)
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
            cargarModPago();
            accion = "";
            dgvModPago_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int rspta = 0;

            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("txtId");
                excluidos.Add("txtObservacion");

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
                    if ((MessageBox.Show("¿Seguro de ingresar modalidad de pago?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        CapaNegocioLinQ cn = new CapaNegocioLinQ();
                        ta_modalidad_pago modPag = new ta_modalidad_pago();

                        modPag.desc_mod_Pago = txtNombre.Text.Trim();
                        modPag.obs_mod_pagp = txtObservacion.Text.Trim();
                        if (chkDolares.Checked) { modPag.intMoId = 2; } else { modPag.intMoId = 0; }

                        rspta = cn.insertarActualizarModPago(modPag);

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
                    ta_modalidad_pago modPag = new ta_modalidad_pago();

                    modPag.cod_mod_Pago = Convert.ToInt32(txtId.Text.Trim());
                    modPag.desc_mod_Pago = txtNombre.Text.Trim();
                    modPag.obs_mod_pagp = txtObservacion.Text.Trim();
                    if (chkDolares.Checked) { modPag.intMoId = 2; } else { modPag.intMoId = 0; }

                    rspta = cn.insertarActualizarModPago(modPag);

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

        private void dgvModPago_Click(object sender, EventArgs e)
        {
            if (dgvModPago.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvModPago_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvModPago_Click(sender, e);
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
                if (dgvModPago.RowCount > 0)
                {
                    fila = dgvModPago.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvModPago.Rows[fila].Cells[0].Value);

                    this.txtId.Text = (dgvModPago.Rows[fila].Cells[0].Value.ToString());
                    this.txtNombre.Text = (dgvModPago.Rows[fila].Cells[1].Value.ToString());
                    this.txtObservacion.Text = (dgvModPago.Rows[fila].Cells[2].Value.ToString());
                    if (dgvModPago.Rows[fila].Cells[3].Value.ToString() == "")
                    {
                        this.chkDolares.Checked = false;
                    }
                    else
                    {
                        this.chkDolares.Checked = true;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarModPago()
        {
            var dt = new DataTable();
            try
            {
                CapaNegocioLinQ cn = new CapaNegocioLinQ();

                dt = cn.listarModPag();
                dgvModPago.Refresh();
                dgvModPago.DataSource = dt;
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
            dgvModPago.Enabled = G;
        }
    }
}
