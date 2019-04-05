using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.IO;

namespace GUI_Tesoreria.cementerio.inventario
{
    public partial class frmIngresoTumbainventario : DevComponents.DotNetBar.Metro.MetroForm
    {
        int idTumbaInventario;
        DataTable dtR = new DataTable();
        string destinoImagen;
        CNegocio cn = new CNegocio();
        int fila_tumba = 0;
        int fila_difunto = 0;
        DateTime? fechaFallecimiento = null;

        private static frmIngresoTumbainventario frmInstance = null;

        public static frmIngresoTumbainventario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoTumbainventario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmIngresoTumbainventario()
        {
            InitializeComponent();
        }

        private void frmIngresoTumbainventario_Load(object sender, EventArgs e)
        {
            cargarCombos();
            ListarTumbas(0);
            dgvTumba.MouseClick += new MouseEventHandler(dgvTumbas_MouseClick);
            dgvDifuntos.MouseClick += new MouseEventHandler(dgvDifuntos_MouseClick);
        }

        void dgvTumbas_MouseClick(object sender, MouseEventArgs e)
        {
            fila_tumba = 0;

            if (e.Button == MouseButtons.Left)
            {
                int posicion_xy_mouse_fila = dgvTumba.HitTest(e.X, e.Y).RowIndex;
                fila_tumba = posicion_xy_mouse_fila;
            }
            else
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvTumba.HitTest(e.X, e.Y).RowIndex;

                //DevComponents.DotNetBar.MessageBoxEx.Show(posicion_xy_mouse_fila.ToString());
                if (posicion_xy_mouse_fila >= 0)
                {
                    fila_tumba = posicion_xy_mouse_fila;
                    my_menu.Items.Add("&Editar").Name = "btnEditar";
                    my_menu.Items.Add("&Agregar ocupante").Name = "btnAgregarOcupante";
                    my_menu.Items.Add("&Eliminar").Name = "btnEliminar";
                }

                my_menu.Show(dgvTumba, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
            }
        }

        void dgvDifuntos_MouseClick(object sender, MouseEventArgs e)
        {
            fila_difunto = 0;

            if (e.Button == MouseButtons.Left)
            {
                //int posicion_xy_mouse_fila = dgvDifuntos.HitTest(e.X, e.Y).RowIndex;
            }
            else
            {
                ContextMenuStrip my_menu_d = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvDifuntos.HitTest(e.X, e.Y).RowIndex;

                //DevComponents.DotNetBar.MessageBoxEx.Show(posicion_xy_mouse_fila.ToString());
                if (posicion_xy_mouse_fila >= 0)
                {
                    fila_difunto = posicion_xy_mouse_fila;
                    my_menu_d.Items.Add("&Editar").Name = "btnEditar";
                    my_menu_d.Items.Add("&Eliminar").Name = "btnEliminar";
                }

                my_menu_d.Show(dgvDifuntos, new Point(e.X, e.Y));

                my_menu_d.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked_d);
            }
        }

        void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //DevComponents.DotNetBar.MessageBoxEx.Show(e.ClickedItem.Name.ToString());
            DataGridViewRow row = dgvTumba.Rows[fila_tumba];

            switch (e.ClickedItem.Name.ToString())
            {
                case "btnEditar":

                    if (row.Cells[10].Value.ToString() == "1")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La tumba ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    cementerio.inventario.frmEditarTumbaInventario winEdit = new cementerio.inventario.frmEditarTumbaInventario();
                    idTumbaInventario = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.idTumbaInventario = idTumbaInventario;
                    winEdit.TipoTumba = row.Cells[3].Value.ToString();
                    winEdit.CodSector = row.Cells[2].Value.ToString();
                    winEdit.Jardin = row.Cells[4].Value.ToString();
                    winEdit.Numero = row.Cells[5].Value.ToString();
                    winEdit.Cabezal = Convert.ToBoolean(row.Cells[6].Value);
                    winEdit.Lapida = Convert.ToBoolean(row.Cells[8].Value);
                    winEdit.Reja = Convert.ToBoolean(row.Cells[7].Value.ToString());
                    winEdit.CodEstadoFisico = row.Cells[9].Value.ToString();
                    winEdit.Observaciones  = row.Cells[10].Value.ToString();
                    winEdit.RutaImagen = row.Cells[12].Value.ToString();
                    winEdit.ShowDialog();
                    ListarTumbas(0);
                    FiltrarFilaAfectada(idTumbaInventario);
                    break;

                case "btnEliminar":
                    if (row.Cells[10].Value.ToString() == "1")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("La Tumba ya fue procesado por GABINETE y ya no se puede eliminar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de eliminar la Tumba " + Environment.NewLine + "?", 
                        VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_TUMBAINVENTARIOEliminar", Convert.ToInt32(row.Cells[0].Value));

                        DevComponents.DotNetBar.MessageBoxEx.Show("La tumba fue eliminado correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarTumbas(0);
                    }
                    break;
                case "btnAgregarOcupante":

                    cementerio.inventario.frmMantDifuntoTumba windif = new cementerio.inventario.frmMantDifuntoTumba();
                    windif.idTumbaInventario = Convert.ToInt32(row.Cells[0].Value);                  
                    windif.tipoMant = "Nuevo";
                    windif.ShowDialog();
                    ListarDIfuntos(Convert.ToInt32(row.Cells[0].Value)); break;
            }
        }

        void FiltrarFilaAfectada(int idTumbaInventario)
        {
            //string fieldName = string.Concat("[", dtR.Columns[0].ColumnName, "]");
            //dtR.DefaultView.Sort = fieldName;
            //DataView view = dtR.DefaultView;
            //view.RowFilter = string.Empty;
            //view.RowFilter = fieldName + " = " + idNichoInventario.ToString() + "";
            //dgvNichos.DataSource = view;
            int rowIndex = -1;

            dgvTumba.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvTumba.Rows)
                {
                    if (row.Cells["IDTUMBAINVENTARIO"].Value.ToString().Equals(idTumbaInventario.ToString()))
                    {
                        rowIndex = row.Index;
                        dgvTumba.CurrentCell = dgvTumba.Rows[rowIndex].Cells[2];
                        dgvTumba.Rows[dgvTumba.CurrentCell.RowIndex].Selected = true;

                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(exc.Message);
            }
        }

        void my_menu_ItemClicked_d(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridViewRow row = dgvDifuntos.Rows[dgvDifuntos.CurrentRow.Index];//fila_difunto
            DataGridViewRow row_Tumba = dgvTumba.Rows[dgvTumba.CurrentRow.Index];//fila_tumba

            switch (e.ClickedItem.Name.ToString())
            {
                case "btnEditar":

                    if (row.Cells[5].Value.ToString() == "1")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("EL difunto se encuentra asignado a una Tumba " + Environment.NewLine + 
                            "que ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    cementerio.inventario.frmMantDifuntoTumba winEdit = new cementerio.inventario.frmMantDifuntoTumba();
                    winEdit.idDifuntoInv = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.idTumbaInventario = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.nombres = row.Cells[2].Value.ToString();
                    winEdit.apellidos = row.Cells[1].Value.ToString();
                    winEdit.Genero = row.Cells[6].Value.ToString();

                    if (row.Cells[3].Value.ToString() == string.Empty)
                    {
                        winEdit.fechaFallec = fechaFallecimiento;
                    }
                    else
                    {
                        winEdit.fechaFallec = Convert.ToDateTime(row.Cells[3].Value);
                    }
                    
                    winEdit.tipoMant = "Editar";
                    winEdit.observacion = row.Cells[4].Value.ToString();

                    winEdit.ShowDialog();
                    //ListarTumbas(0);
                    ListarDIfuntos(Convert.ToInt32(row_Tumba.Cells[0].Value)); break;

                case "btnEliminar":
                    if (row.Cells[5].Value.ToString() == "1")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("El difunto ya fue procesado por GABINETE y ya no se puede eliminar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta seguro de eliminar al difunto " + Environment.NewLine
                        + "con nombres: " + row.Cells[2].Value.ToString()
                        + row.Cells[1].Value.ToString() + " ?", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_DIFUNTOTUMBAINVENTARIOEliminar", Convert.ToInt32(row.Cells[0].Value));

                        DevComponents.DotNetBar.MessageBoxEx.Show("El difunto se elimino correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //ListarTumbas(0);
                        ListarDIfuntos(Convert.ToInt32(row_Tumba.Cells[0].Value)); break;
                    }
                    break;
            }
        }

        void ListarDIfuntos(int idTumbaDifunto)
        {
            try
            {
                if (dgvTumba.RowCount > 0)
                {
                    dgvDifuntos.DataSource = cn.TraerDataset("usp_Listar_difunto_tumba_inventario", idTumbaDifunto).Tables[0];
                }
            }
            catch (Exception)
            {
            }
        }

        void cargarCombos()
        {
            cargarTipoTumba();
            cargarSector();
            llenarEstadoFisico();
        }

        private void llenarEstadoFisico()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODESTADOFISICO,NOMBREESTADOFISICO from cementerio.ESTADOFISICO").Tables[0];
                cboEstadoFisico.DataSource = dt;
                cboEstadoFisico.DisplayMember = "NOMBREESTADOFISICO";
                cboEstadoFisico.ValueMember = "CODESTADOFISICO";
            }
            catch (Exception)
            {
            }
        }

        private void cargarSector()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODSECTOR,NOMBRESECTOR from cementerio.SECTOR WHERE TUMBA=1 ORDER BY CODSECTOR ASC").Tables[0];
                cboSector.DataSource = dt;
                cboSector.DisplayMember = "NOMBRESECTOR";
                cboSector.ValueMember = "CODSECTOR";
            }
            catch (Exception)
            {
            }
        }

        private void cargarTipoTumba()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("SELECT [CODTIPOTUMBA],[NOMBRETIPOTUMBA] FROM [cementerio].[TIPOTUMBA]").Tables[0];
                cboTipoTumba.DataSource = dt;
                cboTipoTumba.DisplayMember = "NOMBRETIPOTUMBA";
                cboTipoTumba.ValueMember = "CODTIPOTUMBA";
            }
            catch (Exception)
            {
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cementerio.inventario.frmMantDifuntoTumba winT = new cementerio.inventario.frmMantDifuntoTumba();
            winT.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

             txtCodigoTumba.Text = Convert.ToInt32(cn.TraerDataset("usp_TUMBAINVENTARIOInsertar","01",cboTipoTumba.SelectedValue,
                cboSector.SelectedValue,cboEstadoFisico.SelectedValue,txtJardin.Text.Trim(),chkCabezal.Checked
                ,txtNumero.Text.Trim(),chkReja.Checked,chkLapida.Checked,
                txtObservacion.Text.Trim(), "0", VariablesMetodosEstaticos.varNombreUser).Tables[0].Rows[0][0]).ToString("0000");

             destinoImagen = @"\\192.168.1.8\imagenesgt\cementerio\tumba\";
             string destino = destinoImagen + "T" + txtCodigoTumba.Text + ".jpg";

             string origen = lblRuta.Text;

             if (File.Exists(destino))
             {
                 File.Delete(destino);
             }
             if (origen == "label1" || origen=="") origen = System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg";

            File.Copy(origen, destino);

            DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente");
            LimpiarControles();
            ListarTumbas(0);
        }

        void LimpiarControles()
        {
            cboTipoTumba.SelectedIndex = 0;
            txtCodigoTumba.Clear();
            cboSector.SelectedIndex = 0;
            txtJardin.Clear();
            txtNumero.Clear();
            chkCabezal.Checked = false;
            chkReja.Checked = false;
            chkLapida.Checked = false;
            cboEstadoFisico.SelectedIndex = 0;
            txtObservacion.Clear();
            cboTipoTumba.Focus();
        }

        void ListarTumbas(int filtro)
        {
            dtR=cn.TraerDataset("usp_TUMBAINVENTARIOListar",filtro).Tables[0];

            if (dtR.Rows.Count > 0)
            {
                dgvTumba.DataSource = dtR;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar");
            }
        }

        bool Validar()
        {
            if (txtJardin.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Jardin");
                txtJardin.Focus();
                return false;
            }
            if (txtNumero.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el Numero");
                txtNumero.Focus(); 
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTumba_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTumba.RowCount > 0)
            {
                ListarDIfuntos(Convert.ToInt32(dgvTumba.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void dgvTumba_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvTumba_CellClick(sender, e);
        }

        private void frmIngresoTumbainventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6) 
            {
                cementerio.inventario.frmFiltroBusquedaPorCodigo win = new cementerio.inventario.frmFiltroBusquedaPorCodigo();
                win.ShowDialog();
                if (win.accion)
                {
                    ListarTumbas(win.Codigo);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "JPG(*.jpg)|*.jpg";//|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; //formatos soportados
                openFileDialog1.FilterIndex = 4;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string nombreArchivo = Path.GetFileName(openFileDialog1.FileName);
                    VariablesMetodosEstaticos.ComprimirImagen(openFileDialog1.FileName, @"c:\\img\\" + nombreArchivo, 30);
                    //Bitmap picture = new Bitmap(@"c:\\img\\" + nombreArchivo);

                    System.IO.FileStream fs;
                    fs = new System.IO.FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                    lblRuta.Text = @"c:\\img\\" + nombreArchivo;
                    //pictureBox1.Image = (Image)picture;
                }
                else
                {
                    if (string.IsNullOrEmpty(openFileDialog1.FileName))
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No ha Seleccionado ninguna Imagen");
                        lblRuta.Text = "";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message + " :" + "El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
