using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Data.SqlClient;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantRegistrarCaja : frmPadre
    {
        private int xcod;
        private CNegocio cn = new CNegocio();
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmMantRegistrarCaja frmInstance = null;

        public frmMantRegistrarCaja()
        {
            InitializeComponent();
        }

        public static frmMantRegistrarCaja Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantRegistrarCaja();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantRegistrarCaja_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarMac();
            cargarUsuarios();
            cargarCajas();
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int IntResultado;
            int IdCaja;
            try
            {
                if (accion != "U")
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

                    int intParsed;
                    if (int.TryParse(txtParametro.Text.Trim(), out intParsed))
                    {
                        if (intParsed == 0 && accion != "U")
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el paremetro, debe ser un numero mayor a cero.", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                }

                if (accion == "I")
                {
                    DataTable dtVerificaCajaSucursalUSuario = new DataTable();

                    dtVerificaCajaSucursalUSuario = cn.TraerDataset("usp_verifica_usuario_x_sucursal", cboUsuario.SelectedValue, cboMac.SelectedValue).Tables[0];

                    if (Convert.ToInt32(dtVerificaCajaSucursalUSuario.Rows[0][0]) == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El usuario y la MAC tienen asignado sucursales diferentes. Verifique.", VariablesMetodosEstaticos.encabezado, 
                            MessageBoxButtons.OK,
                                   MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresar esta caja?, una vez ingresado no se podra modificar", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {


                        IntResultado = Convert.ToInt32(cn.TraerDataset("usp_s_tb_caja_usuario", 3, System.Data.SqlTypes.SqlInt32.Null, System.Data.SqlTypes.SqlInt32.Null,
                                                cboUsuario.SelectedValue, System.Data.SqlTypes.SqlInt32.Null, System.Data.SqlTypes.SqlInt32.Null,
                                                System.Data.SqlTypes.SqlInt32.Null, 1,cboMac.SelectedValue).Tables[0].Rows[0][0]);


                        if (IntResultado == 0)
                        {
                            IdCaja = Convert.ToInt32(cn.TraerDataset("usp_m_tb_caja", accion, 0, txtDescripcion.Text, 1).Tables[0].Rows[0][0]);

                            cn.EjecutarSP("usp_m_tb_caja_usuario", accion, System.Data.SqlTypes.SqlInt32.Null, IdCaja, cboUsuario.SelectedValue,
                                                          System.Data.SqlTypes.SqlInt32.Null, System.Data.SqlTypes.SqlInt32.Null,
                                                          Convert.ToInt32(txtParametro.Text), 1,cboMac.SelectedValue);

                            DevComponents.DotNetBar.MessageBoxEx.Show("Proceso Realizado con exito", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Usuario Registrado anteriormente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (accion == "U")
                {
                    IntResultado = cn.EjecutarSP("usp_m_tb_caja", accion, dgvAgregarCaja.Rows[dgvAgregarCaja.CurrentRow.Index].Cells[0].Value,
                                                    System.Data.SqlTypes.SqlString.Null, 0);
                    if (IntResultado == 1) 
                    {
                        cn.EjecutarSP("usp_m_tb_caja_usuario", accion, 0, dgvAgregarCaja.Rows[dgvAgregarCaja.CurrentRow.Index].Cells[0].Value,
                                                    System.Data.SqlTypes.SqlInt32.Null, System.Data.SqlTypes.SqlInt32.Null,
                                                    System.Data.SqlTypes.SqlInt32.Null, System.Data.SqlTypes.SqlInt32.Null,
                                                    System.Data.SqlTypes.SqlInt32.Null, System.Data.SqlTypes.SqlInt32.Null);
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

        private void cargarUsuarios()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_usuarios_caja").Tables[0];
                cboUsuario.DataSource = dt;
                cboUsuario.DisplayMember = "varUsuNombreUsuario";
                cboUsuario.ValueMember = "intUsuId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cargarMac()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_mac").Tables[0];
                cboMac.DataSource = dt;
                cboMac.DisplayMember = "descrip";
                cboMac.ValueMember = "macID";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cargarCajas()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_s_tb_caja", 1, 0, "", 1).Tables[0];
                dgvAgregarCaja.DataSource = dt;
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        } 
        private void GeneradorToolTip()
        {
            toolTip.SetToolTip(this.btnEditar, "Edita el elemento seleccionado");
            toolTip.SetToolTip(this.btnCancelar, "Cancela los posibles cambios sobre el elemento seleccionado");
            toolTip.SetToolTip(this.btnGuardar, "Guarda el registro");
            toolTip.SetToolTip(this.btnEliminar, "Anula el elemento seleccionado");
            toolTip.SetToolTip(this.btnSalir, "Salir del mantenimiento");
            toolTip.SetToolTip(this.btnNuevo, "Permite ingresar un nuevo elemento");
        }
        private void habilitaBotones(bool G)
        {
            btnNuevo.Enabled = G;
            btnGuardar.Enabled = !G;
            btnCancelar.Enabled = !G;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = G;
            dgvAgregarCaja.Enabled = G;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCampos(this, true);
            varGlobales.resetearCampos(this);
            txtParametro.Text = "1";
            txtDescripcion.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAgregarCaja.Rows.Count > 0)
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de anular el Registro?", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    accion = "U";
                    btnGuardar_Click(sender, e);
                }
                else
                {
                    btnCancelar_Click(sender, e);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            cargarCajas();
            txtParametro.Text = "1";
            accion = "";
        }

        private void btnAsignarDocumento_Click(object sender, EventArgs e)
        {
            if (dgvAgregarCaja.Rows.Count > 0)
            {
                int indice;
                indice = dgvAgregarCaja.CurrentRow.Index;
                frmMantTiposDocVenta win = new frmMantTiposDocVenta();
                win.id_usuario = Convert.ToInt32(cboUsuario.SelectedValue);
                win.id_usuario = Convert.ToInt32(dgvAgregarCaja.Rows[indice].Cells[0].Value);
                win.ShowDialog();
            }
        }

        private void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvAgregarCaja.RowCount > 0)
                {
                    fila = dgvAgregarCaja.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvAgregarCaja.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cn.TraerDataset("usp_select_usuario_caja_x_id", xcod,1).Tables[0];
                    this.txtId.Text = (dt.Rows[0][0].ToString());
                    this.txtDescripcion.Text = (dt.Rows[0][1].ToString());
                    this.cboMac.SelectedValue = (dt.Rows[0][3]);
                    this.cboUsuario.SelectedValue = (dt.Rows[0][2].ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvAgregarCaja_Click(object sender, EventArgs e)
        {
            if (dgvAgregarCaja.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvAgregarCaja_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvAgregarCaja_Click(sender,e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAgregarCaja.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtDescripcion.Focus();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No Existen Datos a Modificar, verifique",
                    VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
