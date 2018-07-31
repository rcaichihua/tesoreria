using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Drawing.Imaging;
using System.IO;
using BE_Tesoreria;

namespace GUI_Tesoreria.cementerio.inventario
{
    public partial class frmIngresoNichoInventario : DevComponents.DotNetBar.Metro.MetroForm
    {
        string destinoImagen;
        DataTable dtR = new DataTable();
        int idNichoInventario;
        string ruta_imagen;
        CNegocio cn = new CNegocio();
        int fila_nicho = 0;
        int fila_difunto = 0;
        private static frmIngresoNichoInventario frmInstance = null;

        DateTime? fechaFallecimiento = null;

        public frmIngresoNichoInventario()
        {
            InitializeComponent();
            ruta_imagen = cn.EjecutarSqlDTS("select other from ta_control where parametro='rura_imagen_nicho'").Tables[0].Rows[0][0].ToString();
        }

        public static frmIngresoNichoInventario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoNichoInventario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCuartel.Text.ToString().Length > 0)
                {
                    DataSet ds = new DataSet();
                    ds = cn.TraerDataset("usp_select_cuartel_like", txtNombreCuartel.Text.Trim(),"N");
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
                    txtCodigoCuartel.Clear();
                    dgvResultado.Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OcultarGrilla();
            buscarNichos(txtCodigoCuartel.Text);
            Contabilizar();
        }

        private void OcultarGrilla()
        {
            try
            {
                txtCodigoCuartel.Text = dgvResultado.CurrentRow.Cells[0].Value.ToString();
                txtNombreCuartel.Text = dgvResultado.CurrentRow.Cells[3].Value.ToString();
                cboMaterial.SelectedValue = dgvResultado.CurrentRow.Cells[2].Value.ToString();
                cboCementerio.SelectedValue = dgvResultado.CurrentRow.Cells[6].Value;

                dgvResultado.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        void Contabilizar()
        {
            DataTable dt = new DataTable();
            dt = cn.TraerDataset("usp_listar_ingresos_nicho_inventario", txtCodigoCuartel.Text).Tables[0];
            lblTotal.Text = dt.Rows[0][0].ToString();
            lblIngresados.Text = dt.Rows[0][1].ToString();
            lblFaltaIngresar.Text = dt.Rows[0][2].ToString();
        }

        void buscarNichos(string codigoCuartel)
        {
            try
            {
                dtR = cn.TraerDataset("usp_listar_nichos_inventario", txtCodigoCuartel.Text).Tables[0];
                dgvNichos.DataSource = dtR;
                if (dtR.Rows.Count > 0)
                {
                    dgvNichos.DataSource = dtR;
                }
                else
                {
                    MessageBox.Show("No hay nichos a mostrar.");
                    dgvNichos.DataSource = dtR;
                    ListarDIfuntos(0);
                }
            }
            catch (Exception)
            {
            }
        }

        void buscarNichosCodigo(int codigo)
        {
            DataTable dtR;
            DataTable dtFiltro = new DataTable();
            try
            {
                dtR = cn.TraerDataset("usp_listar_nichos_inventario_id", codigo).Tables[0];

                if (dtR.Rows.Count > 0)
                {
                    dgvNichos.DataSource = dtR;

                    txtCodigoCuartel.Text = dtR.Rows[0]["CODCUARTEL"].ToString();

                    dtFiltro = cn.TraerDataset("usp_select_cuartel_like", txtCodigoCuartel.Text, "C").Tables[0];

                    txtNombreCuartel.Text = dtFiltro.Rows[0]["NOMBRECUARTEL"].ToString();
                    cboMaterial.SelectedValue = dtFiltro.Rows[0]["CODMATERIAL"].ToString();
                    cboCementerio.SelectedValue = dtFiltro.Rows[0]["CODCEMENTERIO"].ToString();
                }
                else
                {
                    MessageBox.Show("No hay nichos a mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            try
            {
                destinoImagen = @ruta_imagen;
                string destino = destinoImagen + txtCodigoCuartel.Text + txtFila.Text.Trim() + txtColumna.Text.Trim() + ".jpg";
                //MessageBox.Show("1");
                string origen = lblRuta.Text;
                if (origen == "label1") origen = System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg";
                //MessageBox.Show("2");
                if (File.Exists(destino))
                {
                    File.Delete(destino);
                }
                //MessageBox.Show("3");
                File.Copy(origen, destino);
                //MessageBox.Show("4");
                if (cn.EjecutarSP("usp_NICHOINVENTARIOInsertar", cboCementerio.SelectedValue, cboEstado.SelectedValue
                , chkTapa.Checked, txtFila.Text, txtColumna.Text, txtCodigoCuartel.Text
                , cboEstadoFisico.SelectedValue, cboMaterial.SelectedValue, chkLapida.Checked
                , chkReja.Checked, txtObservacion.Text, "0", VariablesMetodosEstaticos.varNombreUser
                , destino) > 0)
                {
                    MessageBox.Show("El Nicho fue registrado correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buscarNichos(txtCodigoCuartel.Text);
                    limpiar();
                    cboEstado.Focus();
                    Contabilizar();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error. Intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool validar()
        {
            if (txtCodigoCuartel.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningun cuartel.");
                txtNombreCuartel.Focus();
                return false;
            }
            if (txtFila.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la FILA");
                txtFila.Focus();
                return false;
            }
            if (txtColumna.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la COLUMNA");
                txtColumna.Focus();
                return false;
            }
            if (cn.EjecutarSqlDTS("select COUNT(*) from cementerio.NICHOINVENTARIO where CODPABELLON='"
                + txtCodigoCuartel.Text + "' and LETRAFILANICHO= '" + txtFila.Text.Trim() + "' and NUMEROCOLNICHO="
                + txtColumna.Text.Trim() + "").Tables[0].Rows[0][0].ToString() != "0")
            {
                MessageBox.Show("La fila y/o columna ya fue registrado.");
                txtFila.Focus();
                return false;
            }
            if (cn.EjecutarSqlDTS("select COUNT(*) from cementerio.NICHO where CODCUARTEL='"
                + txtCodigoCuartel.Text + "' and LETRAFILANICHO= '" + txtFila.Text.Trim() + "' and NUMEROCOLNICHO="
                + txtColumna.Text.Trim() + "").Tables[0].Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("La Fila y/o columna no existe.");
                txtFila.Focus();
                return false;
            }
            return true;
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

        private void frmIngresoNichoInventario_Load(object sender, EventArgs e)
        {
            llenarCombos();
            cboEstado.Focus();
            dgvNichos.MouseClick += new MouseEventHandler(dgvNichos_MouseClick);
            dgvDifuntos.MouseClick += new MouseEventHandler(dgvDifuntos_MouseClick);
        }

        void dgvNichos_MouseClick(object sender, MouseEventArgs e)
        {
            fila_nicho = 0;

            if (e.Button == MouseButtons.Left)
            {

            }
            else
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvNichos.HitTest(e.X, e.Y).RowIndex;

                //MessageBox.Show(posicion_xy_mouse_fila.ToString());
                if (posicion_xy_mouse_fila >= 0)
                {
                    fila_nicho = posicion_xy_mouse_fila;
                    my_menu.Items.Add("&Editar").Name = "btnEditar";
                    my_menu.Items.Add("&Agregar ocupante o beneficiario").Name = "btnAgregarOcupante";
                    my_menu.Items.Add("&Pasar a estado conforme y validado / llenar datos del titulo").Name = "btnConforme";
                    my_menu.Items.Add("&Anular ingreso de Gabinete").Name = "btnAnular";
                    my_menu.Items.Add("&Eliminar").Name = "btnEliminar";
                }

                my_menu.Show(dgvNichos, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                //my_menu.Visible = false;
            }
        }

        void dgvDifuntos_MouseClick(object sender, MouseEventArgs e)
        {
            fila_difunto = 0;

            if (e.Button == MouseButtons.Left)
            {

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

        void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int id;
                DataGridViewRow row = dgvNichos.Rows[fila_nicho];
                id = Convert.ToInt32(row.Cells[0].Value);

                switch (e.ClickedItem.Name.ToString())
                {
                    case "btnEditar":

                        if (row.Cells[12].Value.ToString() == "1")
                        {
                            MessageBox.Show("El nicho ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        cementerio.inventario.frmEditarNichoInventario winEdit = new cementerio.inventario.frmEditarNichoInventario();
                        idNichoInventario = Convert.ToInt32(row.Cells[0].Value);
                        winEdit.idNichoInventario = idNichoInventario;
                        winEdit.codCementerio = row.Cells[1].Value.ToString();
                        winEdit.codCuartel = row.Cells[6].Value.ToString();
                        winEdit.codEstado = row.Cells[2].Value.ToString();
                        winEdit.tapa = Convert.ToBoolean(row.Cells[3].Value);
                        winEdit.fila = row.Cells[4].Value.ToString();
                        winEdit.columna = Convert.ToInt32(row.Cells[5].Value);
                        winEdit.codEstadoFisico = row.Cells[7].Value.ToString();
                        winEdit.codMaterial = row.Cells[8].Value.ToString();
                        winEdit.lapida = Convert.ToBoolean(row.Cells[9].Value);
                        winEdit.reja = Convert.ToBoolean(row.Cells[10].Value);
                        winEdit.observacion = row.Cells[11].Value.ToString();
                        winEdit.RutaImagen = row.Cells[13].Value.ToString();
                        winEdit.ShowDialog();
                        buscarNichos(txtCodigoCuartel.Text);
                        FiltrarFilaAfectada(idNichoInventario);
                        break;

                    case "btnEliminar":
                        if (row.Cells[12].Value.ToString() == "1")
                        {
                            MessageBox.Show("El nicho ya fue procesado por GABINETE y ya no se puede eliminar.", VariablesMetodosEstaticos.encabezado
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }

                        if ((MessageBox.Show("¿Esta seguro de eliminar el nicho " + Environment.NewLine
                            + "ubicado en la fila " + row.Cells[4].Value.ToString() + " y columna "
                            + row.Cells[5].Value.ToString() + " ?", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            == DialogResult.Yes))
                        {
                            cn.EjecutarSP("usp_NICHOINVENTARIOEliminar", Convert.ToInt32(row.Cells[0].Value));

                            MessageBox.Show("El Nicho fue eliminado correctamente.", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            buscarNichos(row.Cells[6].Value.ToString());
                            Contabilizar();
                        }
                        break;
                    case "btnAgregarOcupante":
                        if (row.Cells[12].Value.ToString() == "1")
                        {
                            MessageBox.Show("El nicho ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }

                        if ((row.Cells[2].Value).ToString() == "LIBRE")
                        {
                            MessageBox.Show("No se puede asignar ocupantes a un nicho LIBRE.", VariablesMetodosEstaticos.encabezado
                           , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            break;
                        }

                        cementerio.inventario.frmMantDifuntoNicho windif = new cementerio.inventario.frmMantDifuntoNicho();
                        windif.idNichoInventario = Convert.ToInt32(row.Cells[0].Value);
                        windif.fila = row.Cells[4].Value.ToString();
                        windif.columna = Convert.ToInt32(row.Cells[5].Value);
                        windif.tipoMant = "Nuevo";
                        windif.ShowDialog();
                        ListarDIfuntos(Convert.ToInt32(row.Cells[0].Value)); break;
                    case "btnConforme":

                        if ((row.Cells[2].Value).ToString() != "LIBRE")
                        {
                            if (dgvDifuntos.RowCount > 0)
                            {
                                if ((row.Cells[2].Value).ToString() == "OCUPADO")
                                {
                                    foreach (DataGridViewRow rowDifunto in dgvDifuntos.Rows)
                                    {
                                        if (rowDifunto.Cells[5].Value.ToString() == "")
                                        {
                                            MessageBox.Show("Debe ingresar la fecha de fallecimiento de todos los difuntos.");
                                            return;
                                        }
                                    }
                                }
                                else if ((row.Cells[2].Value).ToString() == "RESERVADO EN VIDA")
                                {
                                    foreach (DataGridViewRow rowDifunto in dgvDifuntos.Rows)
                                    {
                                        if (rowDifunto.Cells[5].Value.ToString() != "")
                                        {
                                            MessageBox.Show("Los benficiarios asignados para la reserva en vida no deben tener fecha de fallecimiento.");
                                            return;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese difunto o beneficiario.");
                                return;
                            }
                        }

                        if (Convert.ToInt32(cn.EjecutarSqlDTS("select COUNT(*) from cementerio.TITULONICHO where CODCUARTEL='" + row.Cells[6].Value.ToString()
                            + "' and LETRAFILANICHO='" + row.Cells[4].Value.ToString() + "' AND NUMEROCOLNICHO=" + Convert.ToInt32(row.Cells[5].Value.ToString())
                            + " AND ANULADO='0' AND IDMOTIVO is null").Tables[0].Rows[0][0].ToString()) > 0)
                        {
                            MessageBox.Show("El titulo ya fue registrado anteriormente.");
                            return;
                        }

                        if ((MessageBox.Show("¿Esta seguro de pasar la informacion a conforme y validado? " + Environment.NewLine
                            + "Una vez que usted ACEPTE los datos del inventario ya no podran ser modificados.", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            == DialogResult.Yes))
                        {
                            if ((row.Cells[2].Value).ToString() == "LIBRE")
                            {
                                //id = Convert.ToInt32(row.Cells[0].Value);

                                cn.TraerDataset("USP_VALIDACION_DATOS_NICHO_1", row.Cells[6].Value.ToString(), row.Cells[4].Value.ToString(),
                                Convert.ToInt32(row.Cells[5].Value)).Tables[0].Rows[0][0].ToString();

                                MessageBox.Show("Se actualizo el estado del nicho a LIBRE");
                                buscarNichos(row.Cells[6].Value.ToString());
                                Contabilizar();
                                FiltrarFilaAfectada(id);
                                //ListarDIfuntos(Convert.ToInt32(row.Cells[0].Value));
                                return;
                            }
                            TituloNichoNegocio TiNiNe = new TituloNichoNegocio();
                            TituloNicho tituNicho = new TituloNicho();

                            cementerio.frmMantenimientoTituloNicho winT = new cementerio.frmMantenimientoTituloNicho();

                            if (TiNiNe.ExisteTituloNichoPorNicho(row.Cells[6].Value.ToString(), row.Cells[4].Value.ToString(), Convert.ToInt32(row.Cells[5].Value)))
                            {
                                tituNicho = TiNiNe.BuscarTituloNichoPorNicho(row.Cells[6].Value.ToString(), row.Cells[4].Value.ToString(), Convert.ToInt32(row.Cells[5].Value));
                                winT.idTituloNicho = tituNicho.IDTITULONICHO;
                            }
                            else { winT.idTituloNicho = 0; }
                            
                            //id = Convert.ToInt32(row.Cells[0].Value);
                            winT.CodPebellon = row.Cells[6].Value.ToString();
                            winT.NumeroColNicho = Convert.ToInt32(row.Cells[5].Value);
                            winT.LetraFilaNicho = row.Cells[4].Value.ToString();
                            winT.EstadoNicho = row.Cells[2].Value.ToString();
                            winT.DtDifuntos = cn.TraerDataset("USP_MUESTRA_DIFUNTO_NICHO_INV", winT.CodPebellon, winT.LetraFilaNicho, winT.NumeroColNicho).Tables[0];
                            winT.ShowDialog();
                            buscarNichos(row.Cells[6].Value.ToString());
                            Contabilizar();
                            FiltrarFilaAfectada(id);
                            //ListarDIfuntos(Convert.ToInt32(row.Cells[0].Value));
                            break;
                            //}
                        }
                        break;
                    case "btnAnular":
                        if ((MessageBox.Show("¿Esta seguro de anular lo ingresado por gabinete? " + Environment.NewLine
                            + "Una vez anulado se perdera la informacion procesada.", VariablesMetodosEstaticos.encabezado
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            == DialogResult.Yes))
                        {
                            if (row.Cells[2].Value.ToString()=="LIBRE")
                            {
                                cn.EjecutarUD("UPDATE cementerio.NICHOINVENTARIO SET FECHAMODIFICA=GETDATE(), USUARIOMODIFICA='" + VariablesMetodosEstaticos.varNombreUser + "', FLAGGABINETE=0 WHERE CODPABELLON='" + row.Cells[6].Value.ToString() 
                                    + "' AND NUMEROCOLNICHO="+ Convert.ToInt32(row.Cells[5].Value.ToString()) + " AND LETRAFILANICHO='"
                                    + row.Cells[4].Value.ToString() + "' AND FLAGGABINETE='1'");
                                MessageBox.Show("Anulado correctamente");
                                buscarNichos(row.Cells[6].Value.ToString());
                                Contabilizar();
                                FiltrarFilaAfectada(id);
                                return;
                            }

                            TituloNichoNegocio TiNiNe = new TituloNichoNegocio();
                            if (Convert.ToInt32(cn.EjecutarSqlDTS("select COUNT(*) from cementerio.TITULONICHO where CODCUARTEL='" + row.Cells[6].Value.ToString() +
                                "' and LETRAFILANICHO='" + row.Cells[4].Value.ToString() + "' AND NUMEROCOLNICHO="
                                + Convert.ToInt32(row.Cells[5].Value.ToString() + "") + " AND ANULADO='0' AND IDMOTIVO IS NULL").Tables[0].Rows[0][0].ToString()) == 0)
                            {
                                MessageBox.Show("No se puede anular porque ya fue anulado anteriormente o porque no se ha generado aún el título para este nicho.");
                                return;
                            }
                            //if (TiNiNe.AnularTituloNicho(Convert.ToInt32(row.Cells[0].Value), VariablesMetodosEstaticos.id_user)==1)
                            if (cn.TraerDataset("usp_AnulaIngresoGabinete", Convert.ToInt32(row.Cells[0].Value), VariablesMetodosEstaticos.id_user).Tables[0].Rows[0][0].ToString() == "1")
                            {
                                MessageBox.Show("Anulación ejecutada correctamente.");
                                //id = Convert.ToInt32(row.Cells[0].Value);
                                buscarNichos(row.Cells[6].Value.ToString());
                                Contabilizar();
                                //ListarDIfuntos(id);
                                FiltrarFilaAfectada(id);
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error en la anulación. Intente de nuevo o contacte con sistemas");
                            }
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void FiltrarFilaAfectada(int idNichoInventario)
        {
            int rowIndex = -1;

            dgvNichos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvNichos.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(idNichoInventario.ToString()))
                    {
                        rowIndex = row.Index;
                        dgvNichos.CurrentCell = dgvNichos.Rows[rowIndex].Cells[2];
                        dgvNichos.Rows[dgvNichos.CurrentCell.RowIndex].Selected = true;

                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void my_menu_ItemClicked_d(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridViewRow row = dgvDifuntos.Rows[fila_difunto];
            DataGridViewRow row_nicho = dgvNichos.Rows[fila_nicho];

            switch (e.ClickedItem.Name.ToString())
            {
                case "btnEditar":

                    if (row.Cells[7].Value.ToString() == "1")
                    {
                        MessageBox.Show("EL difunto se encunetra asignado a un nicho que ya fue procesado por GABINETE y ya no se puede editar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    cementerio.inventario.frmMantDifuntoNicho winEdit = new cementerio.inventario.frmMantDifuntoNicho();
                    winEdit.idDifuntoNichoInventario = Convert.ToInt32(row.Cells[0].Value);
                    winEdit.idNichoInventario = Convert.ToInt32(row.Cells[1].Value);
                    winEdit.codTipoRestos = row.Cells[2].Value.ToString();
                    winEdit.fila = row_nicho.Cells[4].Value.ToString();
                    winEdit.Genero = row.Cells[8].Value.ToString();
                    winEdit.tipoMant = "Editar";
                    winEdit.columna = Convert.ToInt32(row_nicho.Cells[5].Value);
                    if (row.Cells[5].Value.ToString() == string.Empty)
                    {
                        winEdit.fechaFallec = fechaFallecimiento;
                    }
                    else
                    {
                        winEdit.fechaFallec = Convert.ToDateTime(row.Cells[5].Value);
                    }
                    winEdit.nombres = row.Cells[3].Value.ToString();
                    winEdit.apellidos = row.Cells[4].Value.ToString();
                    winEdit.observacion = row.Cells[6].Value.ToString();

                    winEdit.ShowDialog();
                    ListarDIfuntos(Convert.ToInt32(row.Cells[1].Value)); break;

                case "btnEliminar":
                    if (row.Cells[7].Value.ToString() == "1")
                    {
                        MessageBox.Show("El difunto ya fue procesado por GABINETE y ya no se puede eliminar.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    if ((MessageBox.Show("¿Esta seguro de eliminar al difunto " + Environment.NewLine
                        + "con nombres: " + row.Cells[4].Value.ToString()
                        + row.Cells[3].Value.ToString() + " ?", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes))
                    {
                        cn.EjecutarSP("usp_DIFUNTONICHOINVENTARIOEliminar", Convert.ToInt32(row.Cells[0].Value));

                        MessageBox.Show("El difunto fue eliminado correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarDIfuntos(Convert.ToInt32(row.Cells[1].Value)); break;
                    }
                    break;
            }
        }

        private void llenarCombos()
        {
            llenarCementerio();
            llenarEstado();
            llenarEstadoFisico();
            llenarMaterial();
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

        private void llenarEstado()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODESTADO,DESCRIPESTADO from cementerio.ESTADO").Tables[0];
                cboEstado.DataSource = dt;
                cboEstado.DisplayMember = "DESCRIPESTADO";
                cboEstado.ValueMember = "CODESTADO";
            }
            catch (Exception)
            {
            }
        }

        void limpiar()
        {
            cboEstado.SelectedIndex = 0;
            chkTapa.Checked = false;
            cboEstadoFisico.SelectedIndex = 0;
            txtFila.Clear();
            txtColumna.Clear();
            cboMaterial.SelectedIndex = 0;
            chkReja.Checked = false;
            chkLapida.Checked = false;
            txtObservacion.Clear();
            Bitmap picture = new Bitmap(System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg");
            pictureBox1.Image = (Image)picture;
        }

        private void txtColumna_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void dgvNichos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNichos.RowCount > 0)
            {
                ListarDIfuntos(Convert.ToInt32(dgvNichos.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        void ListarDIfuntos(int idNichoDifunto)
        {
            try
            {
                if (dgvNichos.RowCount > 0 && idNichoDifunto!=0)
                {
                    dgvDifuntos.DataSource = cn.TraerDataset("usp_Listar_difunto_nicho_inventario", idNichoDifunto).Tables[0];
                }
                else if (idNichoDifunto==0)
                {
                    dgvDifuntos.DataSource = cn.TraerDataset("usp_Listar_difunto_nicho_inventario", idNichoDifunto).Tables[0];
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngresoNichoInventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                cementerio.inventario.frmFiltroBusquedaPorCodigo win = new cementerio.inventario.frmFiltroBusquedaPorCodigo();
                //win.Tipo = "N";
                win.ShowDialog();
                if (win.accion)
                {
                    if (win.Codigo == 0)
                    {
                        MessageBox.Show("En el caso de nichos filtre el cuartel para desplegar todos los nichos.");
                        txtNombreCuartel.Focus();
                    }
                    else
                    {
                        buscarNichosCodigo(win.Codigo);
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvResultado.Visible = false;
            }          
        }

        private void dgvNichos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvNichos_CellClick(sender, e);
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

        private void dgvNichos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
        }

        private void marcarGrilla()
        {
            if (dgvNichos.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvNichos.Rows)
                {
                    //SON ASIGNAR
                    if (Convert.ToInt32(row.Cells["FLAGGABINETE_"].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.MediumAquamarine;
                    }
                }
            }
        }
    }
}
