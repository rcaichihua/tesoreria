using GUI_Tesoreria.mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using DAO_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmListaRubrosCajaCentral : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        ToolTip toolTip = new ToolTip();
        private string xcod;
        private string accion;
        private varGlobales varglo = new varGlobales();
        private static frmListaRubrosCajaCentral frmInstance = null;

        TesoreriaDBDataContext db = new TesoreriaDBDataContext();

        public static frmListaRubrosCajaCentral Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListaRubrosCajaCentral();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmListaRubrosCajaCentral()
        {
            InitializeComponent();
        }

        private void frmListaRubrosCajaCentral_Load(object sender, EventArgs e)
        {
            cargarprograma();
            cargarCtaContable("", true);
            cargarRubros();
            Cargar();
        }
        private void Cargar()
        {
            if (dgvRubros.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
        }

        private void cargarprograma()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_programa").Tables[0];
                cboPrograma.DataSource = dt;
                cboPrograma.DisplayMember = "varProDescripcion";
                cboPrograma.ValueMember = "intProId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarRubros()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_rubro_central_all_x_id", "0000").Tables[0];
                //dgvRubros.Refresh();
                dgvRubros.DataSource = dt;
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarCtaContable(string filtro, bool accion)
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
                        if (fi.ctaContable != string.Empty)
                        {
                            cboCtaContable.SelectedValue = fi.ctaContable;
                            txtBuscarC.Clear();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos con el filtro proporcionado.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {

            }           
        }
        public void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvRubros.RowCount > 0)
                {
                    fila = dgvRubros.CurrentRow.Index;
                    xcod = dgvRubros.Rows[fila].Cells[0].Value.ToString();
                    DataTable dt = new DataTable();
                    dt = cn.TraerDataset("usp_select_rubro_central_all_x_id", xcod).Tables[0];
                    this.txtCodigoRubro.Text = (dt.Rows[0][0].ToString());
                    this.txtDescripcion.Text = (dt.Rows[0][1].ToString());
                    this.cboCtaContable.Text = dt.Rows[0][2].ToString() == "" ? "[seleccione]" : dt.Rows[0][2].ToString();//(dt.Rows[0][2].ToString());
                    this.txtClasificador.Text = (dt.Rows[0][3].ToString());
                    this.chkActivo.Checked = Convert.ToBoolean(dt.Rows[0][4]);
                    this.cboPrograma.SelectedValue = (dt.Rows[0][5].ToString());
                    if (dt.Rows[0][2].ToString() == "")
                    {
                        chkExonerado.Checked = true;
                        if (cboPrograma.Enabled)
                        {
                            cboCtaContable.Enabled = true;
                        }
                        else
                        {
                            cboCtaContable.Enabled = false;
                        }
                    }
                    else
                    {
                        chkExonerado.Checked = false;
                        if (cboPrograma.Enabled)
                        {
                            cboCtaContable.Enabled = true;
                        }
                        else
                        {
                            cboCtaContable.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
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
        private void habilitaBotones(bool G)
        {
            btnNuevo.Enabled = G;
            btnGuardar.Enabled = !G;
            btnCancelar.Enabled = !G;
            btnEditar.Enabled = G;
            btnEliminar.Enabled = G;
            dgvRubros.Enabled = G;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvRubros.DataSource = cn.TraerDataset("usp_select_rubro_central_all_x_name", txtFiltro.Text.Trim()).Tables[0];
            }
            catch (Exception)
            {

            }
        }

        private void chkExonerado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExonerado.Checked)
            {
                cboCtaContable.Enabled = false;
            }
            else
            {
                cboCtaContable.Enabled = true;
            }
        }

        private void txtBuscarC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarCtaContable(txtBuscarC.Text.Trim(), false);
            }
        }

        private void txtCodigoRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void dgvRubros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvRubros_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("txtClasificador");
                excluidos.Add("txtBuscarC");
                if (chkExonerado.Checked)
                {
                    excluidos.Add("cboCtaContable");
                }

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                int indice = dgvRubros.CurrentRow.Index;

                if (accion == "I")
                {
                    if (cn.TraerDataset("usp_verifica_rubro_central", txtCodigoRubro.Text.Trim(), txtDescripcion.Text.Trim()).Tables[0].Rows.Count > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Codigo o nombre de rubro ya existe, elija otro", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        txtCodigoRubro.Focus();
                        return;
                    }

                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresar el rubro?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_mantenimiento_rubro_central", txtCodigoRubro.Text.Trim(), txtDescripcion.Text.Trim(), chkExonerado.Checked ? null : cboCtaContable.Text, "",
                            txtClasificador.Text.Trim(), chkActivo.Checked, cboPrograma.SelectedValue, VariablesMetodosEstaticos.varNombreUser, accion,
                            chkExonerado.Checked ? DBNull.Value : cboCtaContable.SelectedValue);

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
                    cn.EjecutarSP("usp_mantenimiento_rubro_central", dgvRubros.Rows[indice].Cells[0].Value, txtDescripcion.Text.Trim(), chkExonerado.Checked ? null : cboCtaContable.Text, "",
                            txtClasificador.Text.Trim(), chkActivo.Checked, cboPrograma.SelectedValue, VariablesMetodosEstaticos.varNombreUser, accion
                            , chkExonerado.Checked ? DBNull.Value : cboCtaContable.SelectedValue);

                    DevComponents.DotNetBar.MessageBoxEx.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvRubros_Click(object sender, EventArgs e)
        {
            if (dgvRubros.RowCount > 0) { CargaDatosxId(); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            cargarRubros();
            accion = "";
            dgvRubros_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            varGlobales.resetearCampos(this);
            txtCodigoRubro.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvRubros.RowCount > 0)
            {
                int indice = dgvRubros.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cn.EjecutarSP("usp_mantenimiento_rubro_central", dgvRubros.Rows[indice].Cells[0].Value, "",
                                "", "", "", 0, 0, VariablesMetodosEstaticos.varNombreUser, accion, 0) > 0)
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
                catch (Exception ex)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (this.dgvRubros.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                if (chkExonerado.Checked)
                {
                    cboCtaContable.Enabled = false;
                }
                txtCodigoRubro.Focus();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No Existen Datos a Modificar, verifique",
                    VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
