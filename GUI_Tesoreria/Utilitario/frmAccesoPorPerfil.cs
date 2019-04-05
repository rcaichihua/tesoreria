using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DAO_Tesoreria;
using BL_Tesoreria;

namespace GUI_Tesoreria.usuario
{
    public partial class frmAccesoPorPerfil : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cd = new CNegocio();

        private varGlobales varglo = new varGlobales();
        private static frmAccesoPorPerfil frmInstance = null;
        public frmAccesoPorPerfil()
        {
            InitializeComponent();
        }

        public static frmAccesoPorPerfil Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmAccesoPorPerfil();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        private void frmAccesoPorPerfil_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            cargarPerfil();
            cargarMenuPrincipal();
        }
        private void cargarPerfil()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_perfil_all").Tables[0];
                cboPerfil.DataSource = dt;
                cboPerfil.DisplayMember = "varPeNombrePerfil";
                cboPerfil.ValueMember = "intPeId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void cargarMenuPrincipal()
        {
            var dt = new DataTable();
            try
            {
                dt = cd.TraerDataset("usp_select_menuPrincipal_all").Tables[0];
                cboMenuPrincipal.Refresh();
                cboMenuPrincipal.DataSource = dt;
                cboMenuPrincipal.DisplayMember = "varMPDescripcion";
                cboMenuPrincipal.ValueMember = "intMPId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMenuPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = new DataTable();
            int selectIndex = 0;
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                selectIndex = comboBox.SelectedIndex;

                if (selectIndex != -1)
                {
                    dt = cd.TraerDataset("usp_select_submenu_x_id",
                    ((DataTable)cboMenuPrincipal.DataSource).Rows[cboMenuPrincipal.SelectedIndex]["intMPID"]).Tables[0];
                    cboSubMenu.DataSource = dt;
                    cboSubMenu.DisplayMember = "varSMPDescripcion";
                    cboSubMenu.ValueMember = "intSMPID";
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error al cargar: -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboMenuPrincipal.SelectedIndex = -1;
                //cboSubMenu.SelectedIndex = -1;
                cboSubMenu.DataSource = null;
                cboSubMenu.Refresh();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.ToString());
            }
        }

        //private void frmAccesoPorPerfil_Paint(object sender, PaintEventArgs e)
        //{
        //    int y = 0;
        //    int x = 0;
        //    int ancho = this.Width;
        //    int alto = this.Height;
        //    Color color1;
        //    Color color2;
        //    color1 = Color.SteelBlue; //Color.SteelBlue;
        //    color2 = Color.LightBlue; //Color.LightBlue;
        //    LinearGradientBrush black_white_brush = new LinearGradientBrush(new Point(x, y), new Point((x + ancho), y), color1, color2);
        //    ColorBlend color_blend = new ColorBlend(3);
        //    color_blend.Colors = new Color[] {color1,color2,color1};
        //    color_blend.Positions = new float[] {0,0.2F,1};
        //    black_white_brush.InterpolationColors = color_blend;
        //    e.Graphics.FillRectangle(black_white_brush, x, y, ancho, alto);
        //}
        private void cboSubMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(cboPerfil.SelectedValue == null) && !(cboMenuPrincipal.SelectedValue == null) && !(cboSubMenu.SelectedValue == null))
                {
                    CargaOpcionesXPerfil();
                }
            }
            catch (Exception)
            {
            }
        }
        private void CargaOpcionesXPerfil()
        {
            DataTable Dt;
            int lstrCodPerfil;
            if ((cboPerfil.Text == ""))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Perfil", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            lstrCodPerfil = Convert.ToInt32(cboPerfil.SelectedValue);
            Dt = cd.TraerDataset("usp_select_menu_x_perfil", lstrCodPerfil, cboMenuPrincipal.SelectedValue, cboSubMenu.SelectedValue).Tables[0];
            if ((Dt.Rows.Count == 0))
            {
                Dt = new DataTable();
                Dt = cd.TraerDataset("usp_select_actualiza_accesos", lstrCodPerfil, cboMenuPrincipal.SelectedValue, cboSubMenu.SelectedValue,
                    VariablesMetodosEstaticos.varNombreUser).Tables[0];
            }
            dgvOpcionesSistema.Refresh();
            dgvOpcionesSistema.DataSource = Dt;
        }

        private void dgvOpcionesSistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lstrIdMenu0;
            int lstrIdMenu1;
            int lstrIdMenu2;
            int lstrIdMenu3;
            int lstrIdMenu4;
            int indice = e.RowIndex;
            DataTable Dt = new DataTable();
            bool activo;

            if (e.RowIndex == -1)
                return;

            if (dgvOpcionesSistema.Columns[e.ColumnIndex].Name == "estado")
            {
                DataGridViewRow row = dgvOpcionesSistema.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["estado"] as DataGridViewCheckBoxCell;

                Dt = ((DataTable)(dgvOpcionesSistema.DataSource));
                if (cellSelecion != null)
                {
                    lstrIdMenu0 = Convert.ToInt16(dgvOpcionesSistema.Rows[indice].Cells[8].Value);
                    lstrIdMenu1 = Convert.ToInt16(dgvOpcionesSistema.Rows[indice].Cells[9].Value);
                    lstrIdMenu2 = Convert.ToInt16(dgvOpcionesSistema.Rows[indice].Cells[10].Value);
                    lstrIdMenu3 = Convert.ToInt16(dgvOpcionesSistema.Rows[indice].Cells[11].Value);
                    lstrIdMenu4 = Convert.ToInt16(dgvOpcionesSistema.Rows[indice].Cells[12].Value);

                    if (DBNull.Value.Equals((Convert.ToBoolean(cellSelecion.Value))))
                    {
                        activo = false;
                    }
                    else
                    {
                        activo = ((bool)cellSelecion.Value ? false : true);
                    }

                    activando_hijos(Dt, activo, lstrIdMenu0, lstrIdMenu1, lstrIdMenu2, lstrIdMenu3, lstrIdMenu4);
                }
            }
        }
        private void activando_hijos(DataTable Dt, bool activado, int lstrIdMenu0, int lstrIdMenu1, int lstrIdMenu2, int lstrIdMenu3, int lstrIdMenu4)
        {
            if (((lstrIdMenu0 != 0) && ((lstrIdMenu1 == 0) && ((lstrIdMenu2 == 0) && ((lstrIdMenu3 == 0) && (lstrIdMenu4 == 0))))))
            {
                foreach (DataRow Dr in Dt.Rows)
                {
                    if (((Convert.ToInt16(Dr[8]) == lstrIdMenu0)))
                    {
                        Dr[7] = activado;
                    }
                    //if (((Convert.ToInt16(Dr[9]) == lstrIdMenu1)))
                    //{
                    //    Dr[7] = activado;
                    //}
                }
            }

            if (((lstrIdMenu0 != 0) && ((lstrIdMenu1 != 0) && ((lstrIdMenu2 == 0) && ((lstrIdMenu3 == 0) && (lstrIdMenu4 == 0))))))
            {
                foreach (DataRow Dr in Dt.Rows)
                {
                    //if (((Convert.ToInt16(Dr[8]) == lstrIdMenu0))) {
                    //    Dr[7] = activado;
                    //}
                    if (((Convert.ToInt16(Dr[9]) == lstrIdMenu1)))
                    {
                        Dr[7] = activado;
                    }
                }
            }
            if (((lstrIdMenu0 != 0) && ((lstrIdMenu1 != 0) && ((lstrIdMenu2 != 0) && ((lstrIdMenu3 == 0) && (lstrIdMenu4 == 0))))))
            {
                foreach (DataRow Dr in Dt.Rows)
                {
                    if (((Convert.ToInt16(Dr[9]) == lstrIdMenu1) && (Convert.ToInt16(Dr[10]) == lstrIdMenu2)))
                    {
                        Dr[7] = activado;
                    }
                }
            }
            if (((lstrIdMenu0 != 0) && ((lstrIdMenu1 != 0) && ((lstrIdMenu2 != 0) && ((lstrIdMenu3 != 0) && (lstrIdMenu4 == 0))))))
            {
                foreach (DataRow Dr in Dt.Rows)
                {
                    if (((Convert.ToInt16(Dr[9]) == lstrIdMenu1) && ((Convert.ToInt16(Dr[10]) == lstrIdMenu2) && (Convert.ToInt16(Dr[11]) == lstrIdMenu3))))
                    {
                        Dr[7] = activado;
                    }
                }
            }
        }
        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (dgvOpcionesSistema.RowCount - 1)); i++)
            {
                dgvOpcionesSistema.Rows[i].Cells[7].Value = true;
            }
        }

        private void rdbNinguno_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (dgvOpcionesSistema.RowCount - 1)); i++)
            {
                dgvOpcionesSistema.Rows[i].Cells[7].Value = false;
            }
        }

        private void dgvOpcionesSistema_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)(this.dgvOpcionesSistema.CurrentCell);
            if (cb != null)
            {
                dgvOpcionesSistema.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable Dt;
            bool lstrHabilitado;
            Dt = ((DataTable)(dgvOpcionesSistema.DataSource));
            if (cboPerfil.Text.Trim() == "" || cboMenuPrincipal.Text.Trim() == string.Empty || cboSubMenu.Text.Trim() == string.Empty)
            {
                return;
            }

            if ((Dt.Rows.Count == 0))
            {
                return;
            }

            foreach (DataRow fila in Dt.Rows)
            {
                if ((fila.RowState == DataRowState.Modified))
                {
                    lstrHabilitado = Convert.ToBoolean(fila[7]);
                    cd.EjecutarSP("usp_update_perfilxopcion", cboPerfil.SelectedValue, Convert.ToInt16(fila[0]),
                        cboMenuPrincipal.SelectedValue, cboSubMenu.SelectedValue
                       , lstrHabilitado, VariablesMetodosEstaticos.varNombreUser);
                }
            }
            DevComponents.DotNetBar.MessageBoxEx.Show("Cambios guardados satisfactoriamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
