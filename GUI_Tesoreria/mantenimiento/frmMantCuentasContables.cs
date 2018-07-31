using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Tesoreria;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantCuentasContables : frmPadre
    {
        private int xcod;
        private string accion = string.Empty;
        CNegocio cn = new CNegocio();
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantCuentasContables frmInstance = null;

        public frmMantCuentasContables()
        {
            InitializeComponent();
        }

        public static frmMantCuentasContables Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantCuentasContables();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantCuentasContables_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            lblRegistros.Text = "0 de 0";
            cargarCtaContable("");
            if (dgvCtaContable.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
            dgvCtaContable_CurrentCellChanged(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            varGlobales.resetearCampos(this);
            txtDescripcionCtaContable.Focus();
            txtFiltro.Clear();
            txtFiltro.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCtaContable.RowCount > 0)
            {
                int indice = dgvCtaContable.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            CapaNegocioLinQ cn = new CapaNegocioLinQ();
                            tb_cta_contable ctaCont = new tb_cta_contable();

                            ctaCont.id_cuenta_contable = Convert.ToInt32(txtId.Text.Trim());
                            ctaCont.usuario_mod = VariablesMetodosEstaticos.varNombreUser;

                            cn.eliminarCtaCont(ctaCont, VariablesMetodosEstaticos.host_user + " " + VariablesMetodosEstaticos.ip_user);

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
            if (this.dgvCtaContable.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtDescripcionCtaContable.Focus();
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
            cargarCtaContable("");
            accion = "";
            dgvCtaContable_Click(sender, e);
            txtFiltro.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int rspta = 0;

            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("txtId");
                excluidos.Add("txtBuscar");

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
                        tb_cta_contable ctaBanc = new tb_cta_contable();

                        ctaBanc.codigoCuenta = txtCodigoCtaContable.Text.Trim();
                        ctaBanc.descripcionCuenta = txtDescripcionCtaContable.Text.Trim();
                        ctaBanc.usuario_ing = VariablesMetodosEstaticos.varNombreUser;
                        ctaBanc.pc_ing = VariablesMetodosEstaticos.host_user + " " + VariablesMetodosEstaticos.ip_user;

                        rspta = cn.insertarActualizarCtaContable(ctaBanc);
                        

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
                    tb_cta_contable ctaCont = new tb_cta_contable();

                    ctaCont.id_cuenta_contable = Convert.ToInt32(txtId.Text.Trim());
                    ctaCont.codigoCuenta = txtCodigoCtaContable.Text.Trim();
                    ctaCont.descripcionCuenta = txtDescripcionCtaContable.Text.Trim();
                    ctaCont.usuario_mod = VariablesMetodosEstaticos.varNombreUser;
                    ctaCont.pc_mod = VariablesMetodosEstaticos.host_user + " " + VariablesMetodosEstaticos.ip_user;

                    rspta = cn.insertarActualizarCtaContable(ctaCont);

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

        private void dgvCtaContable_Click(object sender, EventArgs e)
        {
            if (dgvCtaContable.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvCtaContable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvCtaContable_Click(sender, e);
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
                if (dgvCtaContable.RowCount > 0)
                {
                    fila = dgvCtaContable.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvCtaContable.Rows[fila].Cells[0].Value);

                    this.txtId.Text = (dgvCtaContable.Rows[fila].Cells[0].Value.ToString());
                    this.txtCodigoCtaContable.Text = (dgvCtaContable.Rows[fila].Cells[1].Value.ToString());
                    this.txtDescripcionCtaContable.Text = (dgvCtaContable.Rows[fila].Cells[2].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarCtaContable(string filtro)
        {
            var dt = new DataTable();
            try
            {
                dgvCtaContable.DataSource = cn.TraerDataset("usp_select_cuenta_contable", 1, filtro).Tables[0];
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
            dgvCtaContable.Enabled = G;
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar == Convert.ToChar(127))
                || ((e.KeyChar == Convert.ToChar(8))
                || (e.KeyChar == Convert.ToChar(32))))
                && (txtFiltro.Text.ToString().Length > 1)))
            {
                cargarCtaContable(txtFiltro.Text.Substring(0, (txtFiltro.Text.ToString().Length - 1)));
                dgvCtaContable_CurrentCellChanged(sender, e);
            }
            else if ((((e.KeyChar == Convert.ToChar(127))
                    || ((e.KeyChar == Convert.ToChar(8))
                    || (e.KeyChar == Convert.ToChar(32))))
                    && (txtFiltro.Text.ToString().Length == 1)))
            {
                cargarCtaContable("");
                dgvCtaContable_CurrentCellChanged(sender, e);
            }
            else if ((((e.KeyChar == Convert.ToChar(13))
                    || ((e.KeyChar == Convert.ToChar(127))
                    || ((e.KeyChar == Convert.ToChar(8))
                    || (e.KeyChar == Convert.ToChar(32)))))
                    && (txtFiltro.Text.Trim() == String.Empty)))
            {
                cargarCtaContable("");
                dgvCtaContable_CurrentCellChanged(sender, e);
            }
            else
            {
                cargarCtaContable(txtFiltro.Text + e.KeyChar.ToString());
                dgvCtaContable_CurrentCellChanged(sender, e);
            }
        }

        private void dgvCtaContable_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCtaContable.Rows.Count > 0)
            {
                if (dgvCtaContable.CurrentRow != null)
                {
                    lblRegistros.Text = (dgvCtaContable.CurrentRow.Index + 1).ToString() + " de " + dgvCtaContable.Rows.Count.ToString();
                }
            }
        }

    }
}
