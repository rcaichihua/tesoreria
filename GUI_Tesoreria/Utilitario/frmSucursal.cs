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
    public partial class frmSucursal : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cd = new CNegocio();
        ToolTip toolTip = new ToolTip();
        private int xcod;
        private string accion;
        private varGlobales varglo = new varGlobales();
        private static frmSucursal frmInstance = null;

        TesoreriaDBDataContext db = new TesoreriaDBDataContext();
        
        public frmSucursal()
        {
            InitializeComponent();
        }
        public static frmSucursal Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmSucursal();
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
            if (this.dgvSucursal.RowCount > 0)
            {
                int indice = dgvSucursal.CurrentRow.Index;
                int usuariosSuc = 0;
                accion = "D";
                try
                {
                    usuariosSuc = Convert.ToInt32(cd.EjecutarSqlDTS("select count(intUsuId) from usuario where intSuID= " + dgvSucursal.Rows[indice].Cells[0].Value.ToString() + " and bitUsuEstado=1").Tables[0].Rows[0][0]);

                    if (usuariosSuc > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Hay "+ usuariosSuc + " usuario(s) asignados a esta sucursal y no se puede eliminar.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    if (accion == "D")
                    {
                        if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (cd.EjecutarSP("usp_mantenimiento_sucursal", dgvSucursal.Rows[indice].Cells[0].Value, "",
                                "", "", "",DateTime.Now, "", DateTime.Now, accion,0) == 1)
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
            if (this.dgvSucursal.RowCount > 0)
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
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

                int indice = dgvSucursal.CurrentRow.Index;

                if (accion == "I")
                {
                    if (cd.TraerDataset("usp_verifica_sucursal", txtNombre.Text.Trim()).Tables[0].Rows.Count > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Nombre de sucursal ya existe, elija otro", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        txtNombre.Focus();
                        return;
                    }

                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Seguro de ingresar sucursal?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        cd.EjecutarSP("usp_mantenimiento_sucursal", 0, txtNombre.Text.Trim(),txtDireccion.Text.Trim(),txtTelefono.Text.Trim(),
                            VariablesMetodosEstaticos.varNombreUser, DateTime.Now, "", DateTime.Now,  accion,cboPrograma.SelectedValue);

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
                    if (Convert.ToInt32(cboPrograma.SelectedValue) != Convert.ToInt32(dgvSucursal.Rows[indice].Cells[4].Value))
                    {
                        DataTable dtVerificaUsuariosCaja = new DataTable();

                        dtVerificaUsuariosCaja = cd.TraerDataset("usp_verifica_recibos_x_usuario_x_sucursal", dgvSucursal.Rows[indice].Cells[0].Value).Tables[0];

                        if (Convert.ToInt32(dtVerificaUsuariosCaja.Rows[0][0]) > 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("hay usuarios que han realizado movimiento de caja y es imposible realizar cambios en esta sucursal.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    
                    cd.EjecutarSP("usp_mantenimiento_sucursal", dgvSucursal.Rows[indice].Cells[0].Value, txtNombre.Text.Trim(), txtDireccion.Text.Trim()
                            , txtTelefono.Text.Trim(), "", DateTime.Now, VariablesMetodosEstaticos.varNombreUser, DateTime.Now, accion, cboPrograma.SelectedValue);


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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            cargarsucursales();
            accion = "";
            dgvSucursal_Click(sender, e);
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarsucursales();
            cargarPrograma();
            if (dgvSucursal.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCampos(this, false);
            GeneradorToolTip();
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
            dgvSucursal.Enabled = G;
        }
        public void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvSucursal.RowCount > 0)
                {
                    fila = dgvSucursal.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvSucursal.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    var beverages = (from p in db.sucursal where p.intSuID == Convert.ToInt16(xcod)
                                     orderby p.intSuID descending
                                     select new
                                     {
                                         p.intSuID,
                                         p.varSuNombreSucursal,
                                         p.varSuDireccion,
                                         p.varSuTelefonos,
                                         p.intProId
                                     });
                    dt = varglo.ToDataTable(beverages);
                    //dt = cd.TraerDataset("usp_select_sucursal_all_x_id", xcod).Tables[0];
                    this.txtNombre.Text = (dt.Rows[0][1].ToString());
                    this.txtDireccion.Text = (dt.Rows[0][2].ToString());
                    this.txtTelefono.Text = (dt.Rows[0][3].ToString());
                    this.cboPrograma.SelectedValue= (dt.Rows[0][4].ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void cargarsucursales()
        {
            var dt = new DataTable();
            try
            {
                var beverages = (from p in db.sucursal where p.bitEstadoSucursal == true
                                                  orderby p.intSuID descending
                                                  select new 
                                                  {   p.intSuID,
                                                      p.varSuNombreSucursal,
                                                      p.varSuDireccion,
                                                      p.varSuTelefonos,
                                                      p.intProId
                                                  }) ;
                dgvSucursal.Refresh();
                dgvSucursal.DataSource = varglo.ToDataTable(beverages);

            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvSucursal_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.RowCount > 0) { CargaDatosxId(); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSucursal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvSucursal_Click(sender, e);
        }

        private void cargarPrograma()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_programa").Tables[0];
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
    }
}
