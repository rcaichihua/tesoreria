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
    public partial class frmMantTiposDocVenta : frmPadre
    {
        public int id_caja;
        public int id_usuario;

        public new Form ParentForm;

        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantTiposDocVenta frmInstance = null;

        public frmMantTiposDocVenta()
        {
            InitializeComponent();
        }

        public static frmMantTiposDocVenta Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantTiposDocVenta();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantTiposDocVenta_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarTipDocVenta();
            if (dgvTipDocVentas.RowCount > 0) { CargaDatosxId(); }
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
            if (this.dgvTipDocVentas.RowCount > 0)
            {
                int indice = dgvTipDocVentas.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            CapaNegocioLinQ cn = new CapaNegocioLinQ();
                            Ta_TipoDocVenta tipDocVEnta = new Ta_TipoDocVenta();

                            tipDocVEnta.Cod_TipoDocVenta = Convert.ToInt32(txtId.Text.Trim());

                            cn.eliminarTipDocVenta(tipDocVEnta);

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
            if (this.dgvTipDocVentas.RowCount > 0)
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
            cargarTipDocVenta();
            accion = "";
            dgvTipDocVentas_Click(sender, e);
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
                        Ta_TipoDocVenta tipDocVEnta = new Ta_TipoDocVenta();

                        tipDocVEnta.Desc_TipoDocVenta = txtNombre.Text.Trim();
                        tipDocVEnta.flag_autoimpresion = chkAutoImpre.Checked;
                        tipDocVEnta.Flag_Comprob = chkComprobante.Checked;
                        tipDocVEnta.Flag_Ruc = chkReqRuc.Checked;
                        tipDocVEnta.flag_impuesto = chkReqIgv.Checked;
                        tipDocVEnta.nro_serie_ult = txtAbreviatura.Text.Trim();
                        tipDocVEnta.nro_comprobante_ult = txtNroComprobante.Text.Trim();

                        rspta = cn.insertarActualizarlistarTipDocVenta(tipDocVEnta);

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
                    Ta_TipoDocVenta tipDocVEnta = new Ta_TipoDocVenta();
                    //return;
                    tipDocVEnta.Cod_TipoDocVenta = Convert.ToInt32(txtId.Text.Trim());
                    tipDocVEnta.Desc_TipoDocVenta = txtNombre.Text.Trim();
                    tipDocVEnta.flag_autoimpresion = chkAutoImpre.Checked;
                    tipDocVEnta.Flag_Comprob = chkComprobante.Checked;
                    tipDocVEnta.Flag_Ruc = chkReqRuc.Checked;
                    tipDocVEnta.flag_impuesto = chkReqIgv.Checked;
                    tipDocVEnta.nro_serie_ult = txtAbreviatura.Text.Trim();
                    tipDocVEnta.nro_comprobante_ult = txtNroComprobante.Text.Trim();

                    rspta = cn.insertarActualizarlistarTipDocVenta(tipDocVEnta);

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

        private void dgvTipDocVentas_Click(object sender, EventArgs e)
        {
            if (dgvTipDocVentas.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvTipDocVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvTipDocVentas_Click(sender,e);
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
                if (dgvTipDocVentas.RowCount > 0)
                {
                    fila = dgvTipDocVentas.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvTipDocVentas.Rows[fila].Cells[0].Value);

                    this.txtId.Text = (dgvTipDocVentas.Rows[fila].Cells[0].Value.ToString());
                    this.txtNombre.Text = (dgvTipDocVentas.Rows[fila].Cells[1].Value.ToString());
                    this.chkComprobante.Checked = Convert.ToBoolean(dgvTipDocVentas.Rows[fila].Cells[2].Value);
                    this.chkReqRuc.Checked = Convert.ToBoolean(dgvTipDocVentas.Rows[fila].Cells[3].Value);
                    this.chkReqIgv.Checked = Convert.ToBoolean(dgvTipDocVentas.Rows[fila].Cells[4].Value);
                    this.chkAutoImpre.Checked = Convert.ToBoolean(dgvTipDocVentas.Rows[fila].Cells[5].Value);
                    this.txtAbreviatura.Text = (dgvTipDocVentas.Rows[fila].Cells[6].Value.ToString());
                    this.txtNroComprobante.Text = (dgvTipDocVentas.Rows[fila].Cells[6].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarTipDocVenta()
        {
            var dt = new DataTable();
            try
            {
                CapaNegocioLinQ cn = new CapaNegocioLinQ();

                dt = cn.listarTipDocVenta();
                dgvTipDocVentas.Refresh();
                dgvTipDocVentas.DataSource = dt;
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
            dgvTipDocVentas.Enabled = G;
        }

        private void frmMantTiposDocVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frm = (frmMantRegistrarCaja)this.ParentForm;

        }

    }
}
