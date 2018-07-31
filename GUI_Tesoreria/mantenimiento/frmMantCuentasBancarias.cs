using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL_Tesoreria;
using DAO_Tesoreria;
using System.Text;
using System.Net;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantCuentasBancarias : frmPadre
    {
        private int xcod;
        private string accion = string.Empty;
        CNegocio cn = new CNegocio();
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantCuentasBancarias frmInstance = null;

        public frmMantCuentasBancarias()
        {
            InitializeComponent();
        }

        public static frmMantCuentasBancarias Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantCuentasBancarias();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantCuentasBancarias_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            lblRegistros.Text = "0 de 0";
            cargarCtaBanc("");
            cargarMoneda();
            cargarBancos();
            cargarCtaContable("",true);
            if (dgvCtaBancaria.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
            dgvCtaBancaria_CurrentCellChanged(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            varGlobales.resetearCampos(this);
            txtCtaBancaria.Focus();
            txtFiltro.Clear();
            txtFiltro.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCtaBancaria.RowCount > 0)
            {
                int indice = dgvCtaBancaria.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            CapaNegocioLinQ cn = new CapaNegocioLinQ();
                            tb_cuenta_bancaria ctaBanc = new tb_cuenta_bancaria();

                            ctaBanc.cuenta_bancaria_id = Convert.ToInt32(txtId.Text.Trim());
                            ctaBanc.usuario_modifica = VariablesMetodosEstaticos.varNombreUser;

                            cn.eliminarCtaBanc(ctaBanc, VariablesMetodosEstaticos.host_user + " " + VariablesMetodosEstaticos.ip_user);

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
            if (this.dgvCtaBancaria.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtCtaBancaria.Focus();
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
            cargarCtaBanc("");
            accion = "";
            dgvCtaBancaria_Click(sender, e);
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
                        tb_cuenta_bancaria ctaBanc = new tb_cuenta_bancaria();

                        ctaBanc.numero_cuenta = txtCtaBancaria.Text.Trim();
                        ctaBanc.cod_entidad_financ = Convert.ToInt32(cboBanco.SelectedValue);
                        ctaBanc.id_cuenta_contable = Convert.ToInt32(cboCtaContable.SelectedValue);
                        ctaBanc.intMoId=Convert.ToInt32(cboMoneda.SelectedValue);
                        ctaBanc.usuario_ingresa = VariablesMetodosEstaticos.varNombreUser;
                        ctaBanc.nombre_host_ip_ing = VariablesMetodosEstaticos.host_user + " " + VariablesMetodosEstaticos.ip_user;

                        rspta = cn.insertarActualizarCtaBanc(ctaBanc);

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
                    tb_cuenta_bancaria ctaBanc = new tb_cuenta_bancaria();

                    ctaBanc.cuenta_bancaria_id = Convert.ToInt32(txtId.Text.Trim());
                    ctaBanc.numero_cuenta = txtCtaBancaria.Text.Trim();
                    ctaBanc.cod_entidad_financ = Convert.ToInt32(cboBanco.SelectedValue);
                    ctaBanc.id_cuenta_contable = Convert.ToInt32(cboCtaContable.SelectedValue);
                    ctaBanc.intMoId = Convert.ToInt32(cboMoneda.SelectedValue);
                    ctaBanc.usuario_modifica = VariablesMetodosEstaticos.varNombreUser;
                    ctaBanc.nombre_host_ip_mod = VariablesMetodosEstaticos.host_user + " " + VariablesMetodosEstaticos.ip_user;

                    rspta = cn.insertarActualizarCtaBanc(ctaBanc);

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

        private void dgvCtaBancaria_Click(object sender, EventArgs e)
        {
            if (dgvCtaBancaria.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvCtaBancaria_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvCtaBancaria_Click(sender, e);
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
                if (dgvCtaBancaria.RowCount > 0)
                {
                    fila = dgvCtaBancaria.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvCtaBancaria.Rows[fila].Cells[0].Value);

                    this.txtId.Text = (dgvCtaBancaria.Rows[fila].Cells[0].Value.ToString());
                    this.txtCtaBancaria.Text = (dgvCtaBancaria.Rows[fila].Cells[2].Value.ToString());
                    cboBanco.Text = (dgvCtaBancaria.Rows[fila].Cells[1].Value.ToString());
                    cboCtaContable.Text = (dgvCtaBancaria.Rows[fila].Cells[3].Value.ToString());
                    cboMoneda.Text = (dgvCtaBancaria.Rows[fila].Cells[4].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarCtaBanc(string filtro)
        {
            var dt = new DataTable();
            try
            {
                CapaNegocioLinQ cn = new CapaNegocioLinQ();

                dt = cn.listarCtaBancaria(filtro);
                dgvCtaBancaria.Refresh();
                dgvCtaBancaria.DataSource = dt;
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
            dgvCtaBancaria.Enabled = G;
        }
        private void cargarMoneda()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "M").Tables[0];
                cboMoneda.DataSource = dt;
                cboMoneda.DisplayMember = "varMoDescripcion";
                cboMoneda.ValueMember = "intMoId";
            }
            catch(Exception)
            {

            }
        }
        private void cargarBancos()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_bancos", 0).Tables[0];
                cboBanco.DataSource = dt;
                cboBanco.DisplayMember = "nombre_entidad";
                cboBanco.ValueMember = "cod_entidad_financ";
            }
            catch (Exception)
            {

            }
        }
        private void cargarCtaContable(string filtro,bool accion)
        {
            var dt = new DataTable();
            try
            {
                if (accion == true)
                {
                    dt = cn.TraerDataset("usp_select_cuenta_contable", 0, filtro).Tables[0];
                    cboCtaContable.DataSource = dt;
                    cboCtaContable.DisplayMember = "codigoCuenta";
                    cboCtaContable.ValueMember = "id_cuenta_contable";
                }
                else
                {
                    DataTable filTable = new DataTable();
                    filTable = cn.TraerDataset("usp_select_cuenta_contable", 0, filtro).Tables[0];
                    if (filTable.Rows.Count > 0)
                    {
                        frmFiltro fi = new frmFiltro();
                        fi.dfiltro = filTable;
                        fi.ShowDialog();
                        if (fi.ctaContable!=string.Empty)
                        {
                            cboCtaContable.SelectedValue = fi.ctaContable;
                            txtBuscar.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos con el filtro proporcionado.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((((e.KeyChar == Convert.ToChar(127)) 
                    || ((e.KeyChar == Convert.ToChar(8)) 
                    || (e.KeyChar == Convert.ToChar(32)))) 
                    && (txtFiltro.Text.ToString().Length > 1)))
            {
                cargarCtaBanc(txtFiltro.Text.Substring(0, (txtFiltro.Text.ToString().Length - 1)));
                dgvCtaBancaria_CurrentCellChanged(sender, e);
            }
                else if ((((e.KeyChar == Convert.ToChar(127))
                        || ((e.KeyChar == Convert.ToChar(8))
                        || (e.KeyChar == Convert.ToChar(32))))
                        && (txtFiltro.Text.ToString().Length == 1)))
            {
                cargarCtaBanc("");
                dgvCtaBancaria_CurrentCellChanged(sender, e);
            }
                else if ((((e.KeyChar == Convert.ToChar(13))
                        || ((e.KeyChar == Convert.ToChar(127))
                        || ((e.KeyChar == Convert.ToChar(8))
                        || (e.KeyChar == Convert.ToChar(32)))))
                        && (txtFiltro.Text.Trim() == String.Empty)))
            {
                cargarCtaBanc("");
                dgvCtaBancaria_CurrentCellChanged(sender, e);
            }
            else
            {
                cargarCtaBanc(txtFiltro.Text + e.KeyChar.ToString());
                dgvCtaBancaria_CurrentCellChanged(sender, e);
            }
        }

        private void dgvCtaBancaria_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCtaBancaria.Rows.Count > 0)
            {
                if (dgvCtaBancaria.CurrentRow != null)
                {
                    lblRegistros.Text = (dgvCtaBancaria.CurrentRow.Index + 1).ToString() + " de " + dgvCtaBancaria.Rows.Count.ToString();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarCtaContable(txtBuscar.Text.Trim(), false);
            }
        }

    }
}
