using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.cementerio
{
    public partial class frmCuarteles : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int CuartelId { get; set; }

        DataTable dtResultado;
        string accion = "";
        int fila = 0;
        private static frmCuarteles frmInstance = null;
        CNegocio cn = new CNegocio();

        public frmCuarteles()
        {
            InitializeComponent();
        }

        public static frmCuarteles Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmCuarteles();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmCuarteles_Load(object sender, EventArgs e)
        {
            nuColumnas.Maximum = 2500;
            nuColumnas.Minimum = 0;

            nuFila.Maximum = 2500;
            nuFila.Minimum = 0;

            llenarCombos();
            bloqueoBotones(true, false, false, true, true);
            cboPuerta.SelectedIndex = 0;
            dgvCuarteles.MouseClick += new MouseEventHandler(dgvCuarteles_MouseClick);
        }

        private void LlamaFiltro()
        {
            cementerio.frmListarCuarteles winC = new cementerio.frmListarCuarteles();
            winC.ShowDialog();
            CuartelId = winC.CuartelId;
            if (CuartelId != 0)
            {
                txtCodigo.Text = CuartelId.ToString("0000");
                txtNombreCuartel.Text = winC.NombreCuartel;

                if (winC.TipoMaterial == "PARVULO" || winC.TipoMaterial.ToString() == "")
                {
                    cboMaterial.SelectedIndex = -1;
                }
                else
                {
                    cboMaterial.Text = winC.TipoMaterial;
                }

                if (winC.Puerta.ToString() == "")
                {
                    cboPuerta.SelectedIndex = -1;
                }
                else
                {
                    cboPuerta.Text = winC.Puerta;
                }
                if (winC.CementerioId.ToString() == "")
                {
                    cboCementerio.SelectedIndex = -1;
                }
                else
                {
                    cboCementerio.SelectedValue = winC.CementerioId.ToString("00");
                }
                nuFila.Value = winC.Niveles.Value;
                nuColumnas.Value = winC.Nichos.Value;
            }
        }

        void dgvCuarteles_MouseClick(object sender, MouseEventArgs e)
        {
            fila = 0;

            if (e.Button == MouseButtons.Left)
            {

            }
            else
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvCuarteles.HitTest(e.X, e.Y).RowIndex;

                //DevComponents.DotNetBar.MessageBoxEx.Show(posicion_xy_mouse_fila.ToString());
                if (posicion_xy_mouse_fila >= 0)
                {
                    fila = posicion_xy_mouse_fila;
                    my_menu.Items.Add("&Modificar").Name = "btnModificar";
                    my_menu.Items.Add("&Eliminar").Name = "btnEliminar";
                }

                my_menu.Show(dgvCuarteles, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
            }
        }

        void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //DevComponents.DotNetBar.MessageBoxEx.Show(e.ClickedItem.Name.ToString());
            switch(e.ClickedItem.Name.ToString())
            {
                case "btnModificar":
                    cementerio.frmEditarNicho winNi = new cementerio.frmEditarNicho();                   

                    DataGridViewRow row = dgvCuarteles.Rows[fila];

                    string valor1 = row.Cells[2].Value.ToString();

                    winNi.codCuartel = row.Cells[0].Value.ToString();
                    winNi.letraFila = row.Cells[1].Value.ToString();
                    winNi.numColumna = Convert.ToInt32(row.Cells[2].Value);
                    winNi.material = row.Cells[3].Value.ToString();
                    winNi.tipoCuartel = row.Cells[4].Value.ToString();
                    winNi.estado = row.Cells[5].Value.ToString();
                    winNi.observacion = row.Cells[6].Value.ToString();
                    winNi.ShowDialog();
                    buscarNichos(txtCodigo.Text);
                    break;
            }
        }

        private void llenarCombos()
        {
            llenarTipoCuartel();
            llenarCementerio();
            llenarMaterial();
        }

        private void llenarTipoCuartel()   
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODTIPOCUARTEL, DESCRIPTIPOCUARTEL from cementerio.TIPOCUARTEL").Tables[0];
                cboTipoCuartel.DataSource = dt;
                cboTipoCuartel.DisplayMember = "DESCRIPTIPOCUARTEL";
                cboTipoCuartel.ValueMember = "CODTIPOCUARTEL";
            }
            catch (Exception)
            {
            }
        }

        private void llenarCementerio()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODCEMENTERIO,NOMBRECEMENTERIO from cementerio.CEMENTERIO").Tables[0];
                cboCementerio.DataSource = dt;
                cboCementerio.DisplayMember = "NOMBRECEMENTERIO";
                cboCementerio.ValueMember = "CODCEMENTERIO";
            }
            catch (Exception)
            {
            }
        }

        private void llenarMaterial()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODMATERIAL,NOMBREMATERIAL from cementerio.MATERIAL").Tables[0];
                cboMaterial.DataSource = dt;
                cboMaterial.DisplayMember = "NOMBREMATERIAL";
                cboMaterial.ValueMember = "CODMATERIAL";
            }
            catch (Exception)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validadiones() == false)
            {
                return;
            }
            try
            {
                if (cn.EjecutarSqlDTS("select COUNT(*) from Cementerio.CUARTEL where CODCUARTEL='" + txtCodigo.Text + "'").Tables[0].Rows[0][0].ToString()!="0")
                {
                    accion = "U";
                }

                if (accion == "I")
                {
                    dtResultado = new DataTable();

                    dtResultado = cn.TraerDataset("usp_mantenimiento_cuartel", txtCodigo.Text, cboTipoCuartel.SelectedValue
                        , cboMaterial.SelectedValue, txtNombreCuartel.Text, nuFila.Value, nuColumnas.Value
                        , cboCementerio.SelectedValue, cboPuerta.Text, txtObservacion.Text, 1, VariablesMetodosEstaticos.varNombreUser, accion, CuartelId).Tables[0];

                    if (dtResultado.Rows[0][0].ToString() != "BAD")
                    {
                        txtCodigo.Text = dtResultado.Rows[0][0].ToString();
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar_Click(sender, e);
                        buscarNichos("0000");
                        //buscarNichos(txtCodigo.Text);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error verifique", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else if (accion == "U")
                {
                    dtResultado = new DataTable();

                    dtResultado = cn.TraerDataset("usp_mantenimiento_cuartel", txtCodigo.Text, cboTipoCuartel.SelectedValue
                        , cboMaterial.SelectedValue, txtNombreCuartel.Text, nuFila.Value, nuColumnas.Value
                        , cboCementerio.SelectedValue, cboPuerta.Text, txtObservacion.Text, 1, VariablesMetodosEstaticos.varNombreUser, accion, CuartelId).Tables[0];
                    if (dtResultado.Rows[0][0].ToString() != "BAD")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Actualziado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar_Click(sender, e);
                        buscarNichos(txtCodigo.Text);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error verifique", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (accion == "D")
                {
                    dtResultado = new DataTable();

                    dtResultado = cn.TraerDataset("usp_mantenimiento_cuartel", txtCodigo.Text, ""
                        , "", txtNombreCuartel.Text, 0, 0, "", "", "", 0, VariablesMetodosEstaticos.varNombreUser, accion).Tables[0];
                    if (dtResultado.Rows[0][0].ToString() != "BAD")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar_Click(sender, e);
                        buscarNichos("0000");
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error verifique", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                CuartelId = 0;
            }
        }

        private void  resetearCampos()
        {
            cboTipoCuartel.SelectedIndex = 0;
            txtCodigo.Clear();
            txtNombreCuartel.Clear();
            nuFila.Value = 0;
            nuColumnas.Value= 0;
            cboPuerta.SelectedIndex = 0;
            cboCementerio.SelectedIndex = 0;
            cboMaterial.SelectedIndex = 0;
            cboTipoCuartel.Focus();
        }

        private void bloqueoBotones(bool nuevo,bool editar,bool guardar,bool eliminar,bool cancelar)
        {
            btnNuevo.Enabled = nuevo;
            btnEditar.Enabled = editar;
            btnGuardar.Enabled = guardar;
            btnEliminar.Enabled = eliminar;
            btnCancelar.Enabled = cancelar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            resetearCampos();           
            bloqueoBotones(false, false,true , false, true);
            LlamaFiltro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            accion = "";
            resetearCampos();
            bloqueoBotones(true, false, false, true, true);
            buscarNichos("0000");
            CuartelId = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "U";
            bloqueoBotones(false, false, true, false, true);
        }

        private bool validadiones()
        {
            if (txtCodigo.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un cuartel de la lista de cuarteles.");
                txtNombreCuartel.Focus();
                return false;
            }
            DataSet dts = new DataSet();
            dts = cn.EjecutarSqlDTS("select nombreCuartel from tb_cuartel where RIGHT('0000'+CONVERT(varchar,cuartelID),4) ='"+txtCodigo.Text+"'");

            if (dts.Tables[0].Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El codigo ingresado no existe, verifique o seleccione otro cuartel.");
                txtNombreCuartel.Focus();
                return false;
            }
            else
            {
                if (dts.Tables[0].Rows[0][0].ToString() != txtNombreCuartel.Text)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El nombre ingresado ha sido modificado, verifique que sea identico al seleccionado de la lista de cuarteles.");
                    txtNombreCuartel.Focus();
                    return false;
                }
            }

            if (txtNombreCuartel.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el nombre del cuartel");
                txtNombreCuartel.Focus();
                return false;
            }
            if (nuFila.Value <= 0 || nuColumnas.Value <= 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Nro de Fila o columna correstamente");
                return false;
            }
            if (cboMaterial.Text=="")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Tipo de Material.");
                return false;
            }
            if (cboPuerta.Text == "" && cboCementerio.SelectedValue.ToString()=="02")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione Puerta.");
                return false;
            }
            //if (CuartelId == 0)
            //{
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Debe seleccionar el nombre y datos del cuartel de la Lista mostrada. Cancele y vuelva a intentar");
            //    return false;
            //}
            return true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCuartel.Text.ToString().Length > 0)
                {
                    DataSet ds = new DataSet();
                    ds = cn.TraerDataset("usp_select_cuartel_like", txtNombreCuartel.Text.Trim(), "N");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultado.DataSource = ds.Tables[0];
                        dgvResultado.Visible = true;
                        dgvResultado.BringToFront();
                    }
                    else
                    {
                        dgvResultado.Visible = false;
                    }
                }
                else
                {
                    txtCodigo.Clear();
                    dgvResultado.Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    OcultarGrilla();
                }
            }
            catch (Exception)
            {
            }
        }
        private void OcultarGrilla()
        {
            try
            {
                txtCodigo.Text = dgvResultado.CurrentRow.Cells[0].Value.ToString();
                cboTipoCuartel.SelectedValue = dgvResultado.CurrentRow.Cells[1].Value;
                cboMaterial.SelectedValue = dgvResultado.CurrentRow.Cells[2].Value;
                txtNombreCuartel.Text = dgvResultado.CurrentRow.Cells[3].Value.ToString();
                nuFila.Value = Convert.ToInt32(dgvResultado.CurrentRow.Cells[4].Value);
                nuColumnas.Value = Convert.ToInt32(dgvResultado.CurrentRow.Cells[5].Value);
                cboCementerio.SelectedValue = dgvResultado.CurrentRow.Cells[6].Value;
                cboPuerta.Text = dgvResultado.CurrentRow.Cells[8].Value.ToString();
                txtObservacion.Text = dgvResultado.CurrentRow.Cells[9].Value.ToString();

                dgvResultado.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void dgvResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvResultado_DoubleClick(object sender, EventArgs e)
        {
            OcultarGrilla();
            bloqueoBotones(true, true, false, true, true);
            buscarNichos(txtCodigo.Text);
        }

        void buscarNichos(string codigoCuartel)
        {
            try
            {
                dgvCuarteles.DataSource = cn.TraerDataset("usp_select_cuartel", txtCodigo.Text).Tables[0];
            }
            catch (Exception)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cn.EjecutarSqlDTS("select * from cementerio.CUARTEL WHERE CODCUARTEL = '"+txtCodigo.Text+"' and estado=1").Tables[0].Rows.Count==0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El codigo que desea eliminar no esxiste", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de eliminar el cuartel " + txtNombreCuartel.Text + " con codigo " + txtCodigo.Text + "?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                if ((cn.EjecutarSqlDTS("select count(*) from cementerio.NICHO where CODCUARTEL= '" + txtCodigo.Text + "'").Tables[0].Rows[0][0].ToString() != "0"))
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("El cuartel que desea eliminar tiene nichos generados. ¿Esta seguro de continuar?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No se puede eliminar debido a que el cuartel tiene nichos ingresados. Contacte con el administrador \n del sistema.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //accion = "D";
                        //btnGuardar_Click(sender, e);
                        //resetearCampos();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    accion = "D";
                    btnGuardar_Click(sender, e);
                    resetearCampos();
                }
            }
            CuartelId = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!Verifica())
            {
                return;
            }

            try
            {
                cementerio.frmGenerarCuartel win = new cementerio.frmGenerarCuartel();
                win.codCuartel = txtCodigo.Text;
                win.codTipoCuartel = cboTipoCuartel.SelectedValue.ToString();
                win.codMaterial = cboMaterial.SelectedValue.ToString();
                win.nroFilas = Convert.ToInt32(nuFila.Value);
                win.nroColumnas = Convert.ToInt32(nuColumnas.Value);
                win.ShowDialog();
            }
            catch (Exception)
            {
            }          
        }

        bool Verifica()
        {
            if (cn.EjecutarSqlDTS("select CODCUARTEL from cementerio.CUARTEL WHERE CODCUARTEL = '" + txtCodigo.Text + "' and estado=1").Tables[0].Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El cuartel al que desea generar los nichos no se encuentra registrado, verifique y vuelva a intentarlo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtCodigo.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se puede generar, seleccione un cuartel.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }
    }
}
