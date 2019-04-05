using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Security.Principal;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmMantResidente : mantenimiento.frmPadre
    {
        WindowsIdentity MyID = WindowsIdentity.GetCurrent();
        ToolTip toolTip = new ToolTip();
        private int xcod;
        private string accion;
        private varGlobales varglo = new varGlobales();
        private static frmMantResidente frmInstance = null;
        private CNegocio cn = new CNegocio();
        public bool Flag = false;
        public new Form ParentForm;
        string tipoBaja = "";

        public frmMantResidente()
        {
            InitializeComponent();
        }

        public static frmMantResidente Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantResidente();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantResidente_Load(object sender, EventArgs e)
        {
            cargarTipoPago();
            cargarPabellon();
            cargarDireccion();
            cargarResidente();
            if (dgvResidente.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();

            if (Flag == true)
            {
                btnGenerarCtaCte.Enabled = false;
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnAplicar.Visible = true;
            }
            lblRegistros.Text = "0" + " de " + dgvResidente.Rows.Count.ToString();
        }

        private void cargarTipoPago()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_tipopagoResidente").Tables[0];
                cboTipoPago.DataSource = dt;
                cboTipoPago.DisplayMember = "descripcionTipoPagoResidenteID";
                cboTipoPago.ValueMember = "tipoPagoResidenteID";
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
                dt = cn.TraerDataset("usp_select_tb_pabellon").Tables[0];
                cboPabellon.DataSource = dt;
                cboPabellon.DisplayMember = "nombrePabellon";
                cboPabellon.ValueMember = "pabellonID";
            }
            catch (Exception)
            {

            }
        }

        private void cargarDireccion()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_direcciones").Tables[0];
                cboDireccion.DataSource = dt;
                cboDireccion.DisplayMember = "NombreDireccion";
                cboDireccion.ValueMember = "DireccionId";
            }
            catch (Exception)
            {

            }
        }

        private void cboDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_centroGerontologico", cboDireccion.SelectedValue).Tables[0];
                cboCentroGerontologico.DataSource = dt;
                cboCentroGerontologico.DisplayMember = "NombreCentroGerontologico";
                cboCentroGerontologico.ValueMember = "CentroGerontologicoId";
            }
            catch (Exception)
            {

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            varGlobales.resetearCampos(this);
            chkEstado.Checked = true;
            txtFechaBaja.Enabled = false;
            txtDni.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (this.dgvResidente.RowCount > 0)
            //{
            //    int indice = dgvResidente.CurrentRow.Index;
            //    accion = "D";
            //    try
            //    {
            //        if (accion == "D")
            //        {
            //            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
            //                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            //            {
            //                if (Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_residente", dgvResidente.Rows[indice].Cells[0].Value, txtDni.Text.Trim()
            //                    , txtNombres.Text.Trim(), txtApePat.Text.Trim(), txtApeMat.Text.Trim(),
            //                    dtpFIngreso.Value.ToShortDateString(), cboTipoPago.SelectedValue
            //                    , cboNroPabellon.Text, txtHabitacion.Text.Trim(), cboDireccion.SelectedValue,
            //                    Convert.ToInt32(cboCentroGerontologico.SelectedValue) == 0 ? DBNull.Value : cboCentroGerontologico.SelectedValue, accion,
            //                    Convert.ToInt32(cboPabellon.SelectedValue) == 0 ? DBNull.Value : cboPabellon.SelectedValue,
            //                    String.IsNullOrWhiteSpace(cboNroPabellon.Text) ? null : cboNroPabellon.Text,
            //                    VariablesMetodosEstaticos.varUsuario, System.Net.Dns.GetHostName().ToUpper(), MyID.Name.ToUpper()
            //                    , VariablesMetodosEstaticos.ip_user).Tables[0].Rows[0][0]) > 0)
            //                {
            //                    DevComponents.DotNetBar.MessageBoxEx.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
            //                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //                }
            //                else
            //                {
            //                    DevComponents.DotNetBar.MessageBoxEx.Show("No se elimino, verifíque o intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
            //                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                return;
            //            }
            //        }
            //        btnCancelar_Click(sender, e);
            //    }
            //    catch (Exception ex)
            //    {
            //        DevComponents.DotNetBar.MessageBoxEx.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("No Existen Datos a Modificar, verifíque", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
            //                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvResidente.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                //if (chkEstado.Checked)
                //{
                //    txtFechaBaja.Enabled = false;
                //}
                //else
                //{
                //    txtFechaBaja.Enabled = true;
                //}
                MarcaEstado();
                txtDni.Focus();
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
            cargarResidente();
            varGlobales.habilitarCampos(this, false);
            varGlobales.resetearCampos(this);
            accion = "";
            dgvResidente_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacion() == false)
                {
                    return;
                }
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("txtId");
                excluidos.Add("txtPabellon");
                excluidos.Add("txtHabitacion");
                excluidos.Add("cboCentroGerontologico");
                excluidos.Add("cboPabellon");
                excluidos.Add("cboNroPabellon");

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                if (chkEstado.Checked == false)
                {
                    if (rdbEgreso.Checked == true && txtFechaBaja.Text=="  /  /")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingese la fecha de egreso");
                        txtFechaBaja.Focus();
                        return;
                    }
                    else if (rdbFallecio.Checked == true && txtFechaBaja.Text == "  /  /")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingese la fecha de fallecimiento");
                        txtFechaBaja.Focus();
                        return;
                    }
                    else if (rdbAnulado.Checked == true)
                    {
                        tipoBaja = "A";
                    }
                    if (rdbEgreso.Checked)
                    {
                        tipoBaja = "E";
                    }
                    else if (rdbFallecio.Checked)
                    {
                        tipoBaja = "F";
                    }
                    
                    //DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese Fecha de baja");
                    //txtFechaBaja.Focus();
                    //return;
                }

                int indice = 0;

                if (dgvResidente.RowCount > 0)
                {
                    indice = dgvResidente.CurrentRow.Index;
                }

                DateTime? fechaBaja = null;
                DateTime? fechaAlta = null;

                DateTime fechatemp;
                DateTime fechatemp1;

                if (DateTime.TryParse(txtFechaIngreso.Text, out fechatemp1))
                {
                    fechaAlta = fechatemp1;
                }
                if (DateTime.TryParse(txtFechaBaja.Text, out fechatemp))
                {
                    fechaBaja = fechatemp;
                }

                if (accion == "I")
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresar residente?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_mantenimiento_residente", 0, txtDni.Text.Trim()
                                , txtNombres.Text.Trim(), txtApePat.Text.Trim(), txtApeMat.Text.Trim(),
                                fechaAlta, cboTipoPago.SelectedValue
                                , cboPabellon.Text == "[seleccione]" ? null : cboPabellon.Text, txtHabitacion.Text.Trim(), cboDireccion.SelectedValue,
                                Convert.ToInt32(cboCentroGerontologico.SelectedValue) == 0 ? DBNull.Value : cboCentroGerontologico.SelectedValue, accion,
                                Convert.ToInt32(cboPabellon.SelectedValue) == 0 ? DBNull.Value : cboPabellon.SelectedValue,
                            //Convert.ToInt32(cboPabellon.SelectedValue) == 0 ? DBNull.Value : (Convert.ToInt32(cboPabellon.SelectedValue) == 1 ? "" : cboPabellon.SelectedValue),
                            //String.IsNullOrWhiteSpace(cboNroPabellon.Text) ? null : cboNroPabellon.Text,
                                cboNroPabellon.Text == "[seleccione]" ? null : cboNroPabellon.Text,
                                VariablesMetodosEstaticos.varUsuario, System.Net.Dns.GetHostName().ToUpper(), MyID.Name.ToUpper()
                                , VariablesMetodosEstaticos.ip_user,
                                chkEstado.Checked, (chkEstado.Checked == false ? fechaBaja : null), tipoBaja);

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
                    cn.TraerDataset("usp_mantenimiento_residente", dgvResidente.Rows[indice].Cells[0].Value, txtDni.Text.Trim()
                                , txtNombres.Text.Trim(), txtApePat.Text.Trim(), txtApeMat.Text.Trim(),
                                fechaAlta, cboTipoPago.SelectedValue
                                , cboPabellon.Text == "[seleccione]" ? null : cboPabellon.Text, txtHabitacion.Text.Trim(), cboDireccion.SelectedValue,
                                Convert.ToInt32(cboCentroGerontologico.SelectedValue) == 0 ? DBNull.Value : cboCentroGerontologico.SelectedValue, accion,
                                Convert.ToInt32(cboPabellon.SelectedValue) == 0 ? DBNull.Value : cboPabellon.SelectedValue,
                                //Convert.ToInt32(cboPabellon.SelectedValue) == 0 ? DBNull.Value : (Convert.ToInt32(cboPabellon.SelectedValue) == 1 ? "" : cboPabellon.SelectedValue),
                                //String.IsNullOrWhiteSpace(cboNroPabellon.Text) ? null : cboNroPabellon.Text,
                                cboNroPabellon.Text == "[seleccione]" ? null : cboNroPabellon.Text,
                                 VariablesMetodosEstaticos.varUsuario, System.Net.Dns.GetHostName().ToUpper()
                                 , MyID.Name.ToUpper(), VariablesMetodosEstaticos.ip_user,
                                 chkEstado.Checked, (chkEstado.Checked == false ? fechaBaja : null), tipoBaja);

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

        private Boolean validacion()
        {
            bool resultado = true;
            if (cboPabellon.SelectedIndex > 0)
            {
                if (cboNroPabellon.Text == "[seleccione]" && cboDireccion.Text == "CANEVARO" && cboPabellon.Text != "PABELLON CENTRAL")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Nro de Pabellon.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    resultado = false;
                }
            }
            if (cboPabellon.Text == "PABELLON CENTRAL" && cboNroPabellon.SelectedIndex > 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El PABELLON CENTRAL no debe tener asignado un nro de pabellon. Verifíque.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                resultado = false;
            }
            if (cboDireccion.Text == "ALBERGUES PERIFERICOS")
            {
                if (cboCentroGerontologico.SelectedIndex == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un C. Gerentologico.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    resultado = false;
                }
            }
            if (cboDireccion.Text == "CANEVARO")
            {
                if (cboPabellon.SelectedIndex == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Pabellon.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    resultado = false;
                }
            }
            else
            {
                if (cboPabellon.SelectedIndex != 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("La direccion seleccionada no contiene estos pabellones, no seleccione ninguno", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    resultado = false;
                }
            }

            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarResidente()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_residente", 0).Tables[0];
                dgvResidente.Refresh();
                dgvResidente.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        private void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvResidente.RowCount > 0)
                {
                    fila = dgvResidente.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvResidente.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cn.TraerDataset("usp_select_tb_residente_x_id", xcod).Tables[0];
                    this.txtId.Text = (dt.Rows[0][0].ToString());
                    this.txtDni.Text = (dt.Rows[0][1].ToString());
                    this.txtNombres.Text = (dt.Rows[0][2].ToString());
                    this.txtApePat.Text = (dt.Rows[0][3].ToString());
                    this.txtApeMat.Text = (dt.Rows[0][4].ToString());
                    this.txtFechaIngreso.Text = dt.Rows[0][5].ToString() == "" ? "  /  /    " : Convert.ToDateTime(dt.Rows[0][5]).ToString("dd/MM/yyyy");
                    this.cboTipoPago.SelectedValue = Convert.ToInt32(dt.Rows[0][6]);
                    this.cboNroPabellon.SelectedIndex = (dt.Rows[0][12].ToString() == string.Empty ? 0 : Convert.ToInt32(dt.Rows[0][12]));
                    this.txtHabitacion.Text = (dt.Rows[0][8].ToString());
                    this.cboDireccion.SelectedValue = Convert.ToInt32(dt.Rows[0][9]);
                    this.cboCentroGerontologico.SelectedValue = Convert.ToInt32(dt.Rows[0][10].ToString() == "" ? 0 : Convert.ToInt32(dt.Rows[0][10]));
                    this.cboPabellon.SelectedValue = Convert.ToInt32(dt.Rows[0][11].ToString() == "" ? 0 : Convert.ToInt32(dt.Rows[0][11]));
                    this.chkEstado.Checked =Convert.ToBoolean(dt.Rows[0][13].ToString());
                    this.txtFechaBaja.Text = dt.Rows[0][14].ToString() == "" ? "  /  /    " : Convert.ToDateTime(dt.Rows[0][14]).ToString("dd/MM/yyyy");
                    this.txtFechaBaja.Enabled = false;
                    if (dt.Rows[0][15].ToString() == "A")
                    {
                        rdbAnulado.Checked = true;
                    }
                    else if (dt.Rows[0][15].ToString() == "E")
                    {
                        rdbEgreso.Checked = true;
                    }
                    else if (dt.Rows[0][15].ToString() == "F")
                    {
                        rdbFallecio.Checked = true;
                    }
                    else
                    {
                        if (txtId.Enabled)
                        {
                            rdbAnulado.Checked = false;
                            rdbEgreso.Checked = false;
                            rdbFallecio.Checked = false;
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
            dgvResidente.Enabled = G;
        }

        private void dgvResidente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvResidente_Click(sender, e);
            //if (dgvResidente.Rows.Count > 0)
            //{
            //    if (dgvResidente.CurrentRow != null)
            //    {
            //        lblRegistros.Text = (dgvResidente.CurrentRow.Index + 1).ToString() + " de " + dgvResidente.Rows.Count.ToString();
            //    }
            //}
        }

        private void dgvResidente_Click(object sender, EventArgs e)
        {
            if (dgvResidente.RowCount > 0) { CargaDatosxId(); }
            MarcaEstado();
        }

        private void btnGenerarCtaCte_Click(object sender, EventArgs e)
        {
            if (chkEstado.Checked == false)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El residente esta de baja, no se puede generar las cuentas.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            frmGenerarCtaCte winCtaCte = new frmGenerarCtaCte();

            if (txtId.Text != string.Empty)
            {
                winCtaCte.IdResidente = Convert.ToInt32(txtId.Text.Trim());
                winCtaCte.ShowDialog();
            }
        }

        //private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    var dt = new DataTable();
        //    try
        //    {
        //        dt = cn.TraerDataset("usp_select_tb_residente_x_apellido", txtFiltro.Text.Trim()).Tables[0];
        //        dgvResidente.Refresh();
        //        dgvResidente.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void txtFiltro_TextChanged(object sender, EventArgs e)
        //{
        //    var dt = new DataTable();
        //    try
        //    {
        //        dt = cn.TraerDataset("usp_select_tb_residente_x_apellido", txtFiltro.Text.Trim()).Tables[0];
        //        dgvResidente.Refresh();
        //        dgvResidente.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var frm = (caja.frmPagoDiversos)this.ParentForm;
            frm.txtCodigo.Text = txtId.Text;
            frm.TxtNombre.Text = txtApePat.Text.Trim() + " " + txtApeMat.Text.Trim() + " " + txtNombres.Text.Trim();
            frm.txtDniRuc.Text = txtDni.Text.Trim();
            if (cboNroPabellon.Text == string.Empty)
            {
                frm.cboNroPabellon.SelectedIndex = 0;
            }
            else
            {
                frm.cboNroPabellon.Text = cboNroPabellon.Text;
            }
            frm.txtHabitacion.Text = txtHabitacion.Text;

            frm.cboPabellon.SelectedValue = cboPabellon.SelectedValue;
            frm.cboDireccion.SelectedValue = cboDireccion.SelectedValue;
            frm.cboCentroGerontologico.SelectedValue = cboCentroGerontologico.SelectedValue;
            this.Close();
        }

        private void dgvResidente_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvResidente.Rows.Count > 0)
            {
                if (dgvResidente.CurrentRow != null)
                {
                    lblRegistros.Text = (dgvResidente.CurrentRow.Index + 1).ToString() + " de " + dgvResidente.Rows.Count.ToString();
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_residente_x_apellido", txtFiltro.Text.Trim()).Tables[0];
                dgvResidente.Refresh();
                dgvResidente.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            MarcaEstado();
        }

        void MarcaEstado()
        {
            if (chkEstado.Checked)
            {
                txtFechaBaja.Enabled = false;
                rdbAnulado.Enabled = false;
                rdbEgreso.Enabled = false;
                rdbFallecio.Enabled = false;

                rdbAnulado.Checked = false;
                rdbEgreso.Checked = false;
                rdbFallecio.Checked = false;

                txtFechaBaja.Clear();
            }
            else
            {
                if (txtId.Enabled)
                {
                    rdbAnulado.Checked = false;
                    rdbEgreso.Checked = false;
                    rdbFallecio.Checked = false;

                    rdbAnulado.Enabled = true;
                    rdbEgreso.Enabled = true;
                    rdbFallecio.Enabled = true;
                }
                txtFechaBaja.Enabled = true;
                rdbAnulado.Focus();
            }
        }
    }
}
