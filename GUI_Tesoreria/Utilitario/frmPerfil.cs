using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Tesoreria;
using System.Runtime.InteropServices;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmPerfil : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cd = new CNegocio();
        ToolTip toolTip = new ToolTip();
        private int xcod;
        private string accion;
        private varGlobales varglo = new varGlobales();
        private static frmPerfil frmInstance = null;

        public frmPerfil()
        {
            InitializeComponent();
        }

        public static frmPerfil Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmPerfil();
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
            txtPerfil.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPerfil.RowCount > 0)
            {
                int indice = dgvPerfil.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cd.EjecutarSP("usp_mantenimiento_perfil", dgvPerfil.Rows[indice].Cells[0].Value, "",
                                true, "", DateTime.Now, "", DateTime.Now,"" , accion) == 1)
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
            if (this.dgvPerfil.RowCount > 0)
            {
                accion = "U";
                txtPerfil.Focus();
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
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
            cargarPerfiles();
            accion = "";
            dgvPerfil_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                int indice = dgvPerfil.CurrentRow.Index;

                if (accion == "I")
                {
                    if (cd.TraerDataset("usp_verifica_perfil", txtPerfil.Text.Trim()).Tables[0].Rows.Count > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Nombre de perfil ya existe, elija otro", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        txtPerfil.Focus();
                        return;
                    }

                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresa el Usuario?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cd.EjecutarSP("usp_mantenimiento_perfil", 0, txtPerfil.Text.Trim(), chkActivo.Checked
                            , VariablesMetodosEstaticos.varNombreUser, DateTime.Now,"",DateTime.Now,txtDescripcion.Text,accion);

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
                    cd.EjecutarSP("usp_mantenimiento_perfil", dgvPerfil.Rows[indice].Cells[0].Value, txtPerfil.Text.Trim(), chkActivo.Checked
                            , "", DateTime.Now, VariablesMetodosEstaticos.varNombreUser, DateTime.Now, txtDescripcion.Text, accion);


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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPerfil_Click(object sender, EventArgs e)
        {
            if (dgvPerfil.RowCount > 0) { CargaDatosxId(); }
        }

        private void fmrPerfil_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarPerfiles();
            if (dgvPerfil.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
        }

        private void dgvPerfil_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvPerfil_Click(sender, e);
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
                string estado = "ACTIVO";
                if (dgvPerfil.RowCount > 0)
                {
                    fila = dgvPerfil.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvPerfil.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cd.TraerDataset("usp_select_perfil_all_x_id", xcod).Tables[0];
                    this.txtPerfil.Text = (dt.Rows[0][1].ToString());
                    this.txtDescripcion.Text = (dt.Rows[0][3].ToString());
                    this.chkActivo.Checked = (dt.Rows[0][2].ToString() == estado ? true : false);
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarPerfiles()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_perfil_all_x_id", 0).Tables[0];
                dgvPerfil.Refresh();
                dgvPerfil.DataSource = dt;
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
            dgvPerfil.Enabled = G;
        }

    }
}
