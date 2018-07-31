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
    public partial class frmIngresoMausoleoInventario : DevComponents.DotNetBar.Metro.MetroForm
    {
        int IdMausoleoInv;
        DataTable dtR = new DataTable();
        string destinoImagen;
        CNegocio cn = new CNegocio();
        private static frmIngresoMausoleoInventario frmInstance = null;
        int fila_Mausoleo = 0;
        int fila_difunto = 0;
        DateTime? fechaFallecimiento = null;

        public static frmIngresoMausoleoInventario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoMausoleoInventario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }
        public frmIngresoMausoleoInventario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            try
            {              
                txtCodigoMausoleo.Text = Convert.ToInt32(cn.TraerDataset("usp_MAUSOLEOINVENTARIOInsertar", cboCementerio.SelectedValue,
                cboTipoMausoleo.SelectedValue, txtFamilia.Text, cboSector.Text != "" ? cboSector.SelectedValue : null,
                cboSubSector.Text != "" ? cboSubSector.SelectedValue : null,
                txtJardin.Text, txtLote.Text, txtBobedas.Text,
                cboPuerta.Enabled ? cboPuerta.Text : null, txtReferencia.Text
                , cboEstadoFisico.SelectedValue, txtObservacion.Text, "0"
                , VariablesMetodosEstaticos.varNombreUser).Tables[0].Rows[0][0]).ToString("0000");

                destinoImagen = @"\\192.168.1.8\imagenesgt\cementerio\mausoleo\";
                string destino = destinoImagen + "M" + txtCodigoMausoleo.Text + ".jpg";

                string origen = lblRuta.Text;

                if (File.Exists(destino))
                {
                    File.Delete(destino);
                }
                if (origen == "label1") origen = System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg";
                File.Copy(origen, destino);

                MessageBox.Show("Mausoleo fue registrado correctamente.");
                LimpiarControles();
                LlenarGrillaMausoleo(0);
                       
            }
            catch (Exception)
            {

            }          
        }

        void LimpiarControles()
        {
            cboCementerio.SelectedIndex = 0;
            cboTipoMausoleo.SelectedIndex = 0;
            txtCodigoMausoleo.Clear();
            txtFamilia.Clear();
            cboSector.SelectedIndex = 0;
            cboSubSector.SelectedIndex = 0;
            txtJardin.Clear();
            txtLote.Clear();
            txtBobedas.Clear();
            cboPuerta.SelectedIndex = 0;
            txtReferencia.Clear();
            cboEstadoFisico.SelectedIndex = 0;
            txtObservacion.Clear();
        }

        void LlenarGrillaMausoleo(int idMausoleoInv)
        {
            

            try
            {
                dtR=cn.TraerDataset("usp_MAUSOLEOINVENTARIOListar", idMausoleoInv).Tables[0];

                if (dtR.Rows.Count > 0)
                {
                    dgvMausoleo.DataSource = dtR;
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar");
                }
            }
            catch (Exception)
            {
            }
        }

        bool validar()
        {
            if (txtFamilia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Familia.");
                txtFamilia.Focus();
                return false;
            }
            if (txtJardin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Jardin.");
                txtJardin.Focus();
                return false;
            }
            if (txtLote.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Lote.");
                txtLote.Focus();
                return false;
            }
            if (txtLote.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Lote.");
                txtLote.Focus();
                return false;
            }
            if (txtBobedas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Bobedas.");
                txtBobedas.Focus();
                return false;
            }
            if (cboPuerta.Enabled && cboPuerta.Text==string.Empty)
            {
                MessageBox.Show("Seleccione una Puerta.");
                cboPuerta.Focus();
                return false;
            }
            if (cboSector.Enabled && cboSector.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Sector.");
                cboSector.Focus();
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngresoMausoleoInventario_Load(object sender, EventArgs e)
        {
            llenarCombos();
            LlenarGrillaMausoleo(0);
            dgvMausoleo.MouseClick += new MouseEventHandler(dgvMausoleo_MouseClick);
            dgvDifuntos.MouseClick += new MouseEventHandler(dgvDifuntos_MouseClick);
        }

        void dgvMausoleo_MouseClick(object sender, MouseEventArgs e)
        {
            fila_Mausoleo = 0;

            if (e.Button == MouseButtons.Left)
            {
                int posicion_xy_mouse_fila = dgvMausoleo.HitTest(e.X, e.Y).RowIndex;
                fila_Mausoleo = posicion_xy_mouse_fila;
            }
            else
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvMausoleo.HitTest(e.X, e.Y).RowIndex;

                //MessageBox.Show(posicion_xy_mouse_fila.ToString());
                if (posicion_xy_mouse_fila >= 0)
                {
                    fila_Mausoleo= posicion_xy_mouse_fila;
                    my_menu.Items.Add("&Editar").Name = "btnEditar";
                    my_menu.Items.Add("&Agregar ocupante").Name = "btnAgregarOcupante";
                    my_menu.Items.Add("&Eliminar").Name = "btnEliminar";
                }

                my_menu.Show(dgvMausoleo, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
            }
        }

        void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show(e.ClickedItem.Name.ToString());
            DataGridViewRow row = dgvMausoleo.Rows[fila_Mausoleo];

            switch (e.ClickedItem.Name.ToString())
            {
                case "btnEditar":

                    if (row.Cells[10].Value.ToString() == "1")
                    {
                        MessageBox.Show("La tumba ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    cementerio.inventario.frmEditarMausoleoInventario winEdit = new cementerio.inventario.frmEditarMausoleoInventario();
                    IdMausoleoInv = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.idMausoleoInventario = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.CodCementerio = row.Cells[1].Value.ToString();
                    winEdit.CodTipoMausoleo = row.Cells[2].Value.ToString();
                    winEdit.Familia = row.Cells[3].Value.ToString();
                    winEdit.CodSector = row.Cells[4].Value.ToString();
                    winEdit.CodSubSector = row.Cells[5].Value.ToString();
                    winEdit.Jardin = row.Cells[6].Value.ToString();
                    winEdit.Lote = row.Cells[7].Value.ToString();
                    winEdit.Bobedas = Convert.ToInt32(row.Cells[8].Value.ToString());
                    winEdit.CodPuerta = row.Cells[9].Value.ToString();
                    winEdit.Referencia = row.Cells[10].Value.ToString();
                    winEdit.CodEstado = row.Cells[11].Value.ToString();
                    winEdit.Observacion = row.Cells[12].Value.ToString();
                    winEdit.Gabinete = row.Cells[13].Value.ToString();
                    winEdit.RutaImagenMausoleo = row.Cells[14].Value.ToString();
                    winEdit.ShowDialog();
                    LlenarGrillaMausoleo(0);
                    FiltrarFilaAfectada(IdMausoleoInv);
                    break;

                case "btnEliminar":
                    if (row.Cells[13].Value.ToString() == "1")
                    {
                        MessageBox.Show("El Mausoleo ya fue procesado por GABINETE y ya no se puede eliminar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    if ((MessageBox.Show("¿Esta seguro de eliminar el Mausoleo?",
                        VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_MAUSOLEOINVENTARIOEliminar", Convert.ToInt32(row.Cells[0].Value));

                        MessageBox.Show("Se elimino el Mausoleo correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LlenarGrillaMausoleo(0);
                    }
                    break;
                case "btnAgregarOcupante":

                    cementerio.inventario.frmMantDifuntoMausoleo windif = new cementerio.inventario.frmMantDifuntoMausoleo();
                    windif.idMousoleoInventario = Convert.ToInt32(row.Cells[0].Value);
                    windif.familia = row.Cells[3].Value.ToString();
                    windif.tipoMant = "Nuevo";
                    windif.ShowDialog();//break;
                    ListarDIfuntos(Convert.ToInt32(row.Cells[0].Value)); break;
            }
        }

        void FiltrarFilaAfectada(int idMausoleoInventario)
        {
            //string fieldName = string.Concat("[", dtR.Columns[0].ColumnName, "]");
            //dtR.DefaultView.Sort = fieldName;
            //DataView view = dtR.DefaultView;
            //view.RowFilter = string.Empty;
            //view.RowFilter = fieldName + " = " + idNichoInventario.ToString() + "";
            //dgvNichos.DataSource = view;
            int rowIndex = -1;

            dgvMausoleo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvMausoleo.Rows)
                {
                    if (row.Cells["IDMAUSOLEOINV"].Value.ToString().Equals(IdMausoleoInv.ToString()))
                    {
                        rowIndex = row.Index;
                        dgvMausoleo.CurrentCell = dgvMausoleo.Rows[rowIndex].Cells[2];
                        dgvMausoleo.Rows[dgvMausoleo.CurrentCell.RowIndex].Selected = true;

                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void dgvDifuntos_MouseClick(object sender, MouseEventArgs e)
        {
            fila_difunto = 0;

            if (e.Button == MouseButtons.Left)
            {
                int posicion_xy_mouse_fila = dgvDifuntos.HitTest(e.X, e.Y).RowIndex;
                fila_difunto = posicion_xy_mouse_fila;
            }
            else
            {
                ContextMenuStrip my_menu_d = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvDifuntos.HitTest(e.X, e.Y).RowIndex;

                //MessageBox.Show(posicion_xy_mouse_fila.ToString());
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

        void my_menu_ItemClicked_d(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridViewRow row = dgvDifuntos.Rows[fila_difunto];
            DataGridViewRow row_Mausoleo = dgvMausoleo.Rows[fila_Mausoleo];

            switch (e.ClickedItem.Name.ToString())
            {
                case "btnEditar":

                    if (row.Cells[5].Value.ToString() == "1")
                    {
                        MessageBox.Show("EL difunto se encuentra asignado a un Mausoleo " + Environment.NewLine +
                            "que ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    cementerio.inventario.frmMantDifuntoMausoleo winEdit = new cementerio.inventario.frmMantDifuntoMausoleo();
                    winEdit.idDifuntoMausoleo = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.idMousoleoInventario = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.nombres = row.Cells[1].Value.ToString();
                    winEdit.apellidos = row.Cells[2].Value.ToString();
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
                    winEdit.familia = row.Cells[6].Value.ToString();
                    winEdit.Genero = row.Cells[7].Value.ToString();

                    winEdit.ShowDialog();
                    //ListarTumbas(0);
                    ListarDIfuntos(Convert.ToInt32(row_Mausoleo.Cells[0].Value)); break;

                case "btnEliminar":
                    if (row.Cells[5].Value.ToString() == "1")
                    {
                        MessageBox.Show("El difunto ya fue procesado por GABINETE y ya no se puede eliminar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    if ((MessageBox.Show("¿Esta seguro de eliminar al difunto " + Environment.NewLine
                        + "con nombres: " + row.Cells[2].Value.ToString() + " " 
                        + row.Cells[1].Value.ToString() + " ?", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_DIFUNTOMAUSOLEOINVENTARIOEliminar", Convert.ToInt32(row.Cells[0].Value));

                        MessageBox.Show("El difunto se elimino correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //ListarTumbas(0);
                        ListarDIfuntos(Convert.ToInt32(row_Mausoleo.Cells[0].Value)); break;
                    }
                    break;
            }
        }

        void ListarDIfuntos(int idMausoleoDifunto)
        {
            try
            {
                if (dgvMausoleo.RowCount > 0)
                {
                    dgvDifuntos.DataSource = cn.TraerDataset("usp_Listar_difunto_mausoleo_inventario", idMausoleoDifunto).Tables[0];
                }
            }
            catch (Exception)
            {
            }
        }

        private void llenarCombos()
        {
            llenarCementerio();
            llenarTipoMausoleo();
            llenarSector();
            //llenarSubSector();
            llenarEstado();
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

        private void llenarTipoMausoleo()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("SELECT CODTIPOMAUSOLEO,DESCRIPTIPOMAUSOLEO FROM cementerio.TIPOMAUSOLEO").Tables[0];
                cboTipoMausoleo.DataSource = dt;
                cboTipoMausoleo.DisplayMember = "DESCRIPTIPOMAUSOLEO";
                cboTipoMausoleo.ValueMember = "CODTIPOMAUSOLEO";
            }
            catch (Exception)
            {
            }
        }

        private void llenarEstado()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("SELECT CODESTADOMAUSOLEO,DESCRIPESTADOMAUSOLEO FROM cementerio.ESTADOMAUSOLEO").Tables[0];
                cboEstadoFisico.DataSource = dt;
                cboEstadoFisico.DisplayMember = "DESCRIPESTADOMAUSOLEO";
                cboEstadoFisico.ValueMember = "CODESTADOMAUSOLEO";
            }
            catch (Exception)
            {
            }
        }

        private void llenarSector()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODSECTOR,NOMBRESECTOR from cementerio.SECTOR WHERE TUMBA in (1,0) ORDER BY CODSECTOR ASC").Tables[0];
                cboSector.DataSource = dt;
                cboSector.DisplayMember = "NOMBRESECTOR";
                cboSector.ValueMember = "CODSECTOR";
            }
            catch (Exception)
            {
            }
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarSubSector();
        }

        private void llenarSubSector()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("SELECT CODSUBSECTOR,DESCRIPSUBSECTOR FROM cementerio.SUBSECTOR WHERE CODSECTOR='" + 
                    cboSector.SelectedValue.ToString()+"'").Tables[0];

                cboSubSector.DataSource = dt;
                cboSubSector.DisplayMember = "DESCRIPSUBSECTOR";
                cboSubSector.ValueMember = "CODSUBSECTOR";
            }
            catch (Exception)
            {
            }
        }

        private void cboCementerio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCementerio.SelectedValue.ToString() == "02")
                {
                    cboSector.SelectedIndex = -1;
                    cboSubSector.SelectedIndex = -1;
                    cboSector.Enabled = false;
                    cboSubSector.Enabled = false;
                    cboPuerta.Enabled = true;
                }
                else
                {
                    cboPuerta.SelectedIndex = -1;
                    cboPuerta.Enabled = false;

                    cboSector.SelectedIndex = -1;
                    cboSubSector.SelectedIndex = -1;
                    cboSector.Enabled = true;
                    cboSubSector.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvMausoleo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMausoleo.RowCount > 0)
            {
                ListarDIfuntos(Convert.ToInt32(dgvMausoleo.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void dgvMausoleo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvMausoleo_CellClick(sender,e);
        }

        private void frmIngresoMausoleoInventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                cementerio.inventario.frmFiltroBusquedaPorCodigo win = new cementerio.inventario.frmFiltroBusquedaPorCodigo();
                win.ShowDialog();
                if (win.accion)
                {
                   LlenarGrillaMausoleo(win.Codigo);
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
                        MessageBox.Show("No ha Seleccionado ninguna Imagen");
                        lblRuta.Text = "";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " :" + "El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
