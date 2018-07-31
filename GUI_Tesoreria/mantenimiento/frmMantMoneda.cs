using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Tesoreria;
using BL_Tesoreria;
namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantMoneda : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cd = new CNegocio();
        ToolTip toolTip = new ToolTip();
        private int xcod;
        private string accion;
        private varGlobales varglo = new varGlobales();
        private static frmMantMoneda frmInstance = null;
        public frmMantMoneda()
        {
            InitializeComponent();
        }
        public static frmMantMoneda Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantMoneda();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantMoneda_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarMoneda();
            if (dgvMoneda.RowCount > 0) { CargaDatosxId(); }
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
            txtDescripcionMoneda.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMoneda.RowCount > 0)
            {
                int indice = dgvMoneda.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cd.EjecutarSP("usp_mantenimiento_Moneda", dgvMoneda.Rows[indice].Cells[0].Value, "",
                                0, "", accion) > 0)
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
                catch (Exception ex)
                {
                    MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (this.dgvMoneda.RowCount > 0)
            {
                accion = "U";
                habilitaBotones(false);
                varGlobales.habilitarCampos(this, true);
                txtCodigoMoneda.Focus();
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
            cargarMoneda();
            varGlobales.habilitarCampos(this, false);
            accion = "";
            dgvMoneda_Click(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("txtCodigoMoneda");

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    MessageBox.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                int indice=0;

                if (dgvMoneda.RowCount>0)
                {
                    indice = dgvMoneda.CurrentRow.Index;
                }

                if (accion == "I")
                {
                    if ((MessageBox.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cd.EjecutarSP("usp_mantenimiento_Moneda", 0, txtDescripcionMoneda.Text.Trim(), chkActivoMoneda.Checked,
                            txtAbreviaturaMoneda.Text.Trim(), accion);

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
                    cd.EjecutarSP("usp_mantenimiento_Moneda", dgvMoneda.Rows[indice].Cells[0].Value, txtDescripcionMoneda.Text.Trim(), chkActivoMoneda.Checked,
                            txtAbreviaturaMoneda.Text.Trim(), accion);

                    MessageBox.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarMoneda()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_Moneda_all_x_id", 0).Tables[0];
                dgvMoneda.Refresh();
                dgvMoneda.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvMoneda.RowCount > 0)
                {
                    fila = dgvMoneda.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvMoneda.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cd.TraerDataset("usp_select_Moneda_all_x_id", xcod).Tables[0];
                    this.txtCodigoMoneda.Text = (dt.Rows[0][0].ToString());
                    this.txtDescripcionMoneda.Text = (dt.Rows[0][1].ToString());
                    this.chkActivoMoneda.Checked = Convert.ToBoolean(dt.Rows[0][2].ToString());
                    this.txtAbreviaturaMoneda.Text = (dt.Rows[0][3].ToString());
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
            dgvMoneda.Enabled = G;
        }

        private void dgvMoneda_Click(object sender, EventArgs e)
        {
            if (dgvMoneda.RowCount > 0) { CargaDatosxId(); }
        }

        private void dgvMoneda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvMoneda_Click(sender, e);
        }
    }
}
