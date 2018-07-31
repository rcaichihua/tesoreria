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
    public partial class frmEditarMausoleoInventario : DevComponents.DotNetBar.Metro.MetroForm
    {
        string destinoImagen;
        public int idMausoleoInventario { get; set; }
        public string CodCementerio { get; set; }
        public string CodTipoMausoleo { get; set; }
        public string Familia { get; set; }
        public string CodSector { get; set; }
        public string CodSubSector { get; set; }
        public string Jardin { get; set; }
        public string Lote { get; set; }
        public int Bobedas { get; set; }
        public string CodPuerta { get; set; }
        public string Referencia { get; set; }
        public string CodEstado { get; set; }
        public string Observacion { get; set; }
        public string Gabinete { get; set; }
        public string RutaImagenMausoleo { get; set; }

        CNegocio cn = new CNegocio();

        public frmEditarMausoleoInventario()
        {
            InitializeComponent();
        }

        private void frmEditarMausoleoInventario_Load(object sender, EventArgs e)
        {
            llenarCombos();
            llenarCampos();
        }

        void llenarCampos()
        {
            Bitmap picture;

            txtCodigoMausoleo.Text = idMausoleoInventario.ToString("0000");
            cboCementerio.Text = CodCementerio;
            txtFamilia.Text = Familia;
            if (CodSector.ToString() == string.Empty)
            {
                cboSector.SelectedIndex = -1;
                cboSector.Enabled = false;
            }
            else
            {
                cboSector.Text = CodSector;
                llenarSubSector();
            }
            if (CodSubSector.ToString() == string.Empty && CodSector.ToString() == string.Empty)
            {
                cboSubSector.SelectedIndex = -1;
                cboSubSector.Enabled = false;
            }
            else
            {
                if (CodSubSector!=CodSubSector) cboSubSector.Text = CodSubSector;
            }

            txtJardin.Text = Jardin;
            txtLote.Text = Lote;
            txtBobedas.Text = Bobedas.ToString();

            if (cboPuerta.ToString() == string.Empty)
            {
                cboPuerta.SelectedIndex = -1;
                cboPuerta.Enabled = false;
            }
            else
            {
                cboPuerta.Text = CodPuerta;
            }
            txtReferencia.Text = Referencia;
            cboEstado.Text = CodEstado;
            txtObservacion.Text = Observacion;
            lblRuta.Text = RutaImagenMausoleo;

            if (File.Exists(RutaImagenMausoleo))
            {
                //pictureBox1.Image = (Image)(new Bitmap(RutaImagen));

                System.IO.FileStream fs;
                fs = new System.IO.FileStream(RutaImagenMausoleo, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
                lblRuta.Text = RutaImagenMausoleo;
            }
            else
            {
                //picture = new Bitmap(System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg");
                string ruta;
                ruta = System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg";
                lblRuta.Text = ruta;
                picture = new Bitmap(ruta);
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
                cboEstado.DataSource = dt;
                cboEstado.DisplayMember = "DESCRIPESTADOMAUSOLEO";
                cboEstado.ValueMember = "CODESTADOMAUSOLEO";
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
                    cboSector.SelectedValue.ToString() + "'").Tables[0];

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            try
            {
                destinoImagen = @"\\192.168.1.8\imagenesgt\cementerio\mausoleo\";
                string destino = destinoImagen +"M"+ txtCodigoMausoleo.Text + ".jpg";

                string origen = lblRuta.Text;

                if (origen == destino)
                {
                    if (File.Exists(@"c:\\img\\" + Path.GetFileName(destino)))
                    {
                        File.Delete(@"c:\\img\\" + Path.GetFileName(destino));
                    }
                    File.Copy(origen, @"c:\\img\\" + Path.GetFileName(destino));

                    origen = @"c:\\img\\" + Path.GetFileName(destino);
                }

                if (File.Exists(destino))
                {
                    File.Delete(destino);
                }

                File.Copy(origen, destino);

                cn.EjecutarSP("usp_MAUSOLEOINVENTARIOActualizar",Convert.ToInt32(txtCodigoMausoleo.Text), cboCementerio.SelectedValue,
                cboTipoMausoleo.SelectedValue, txtFamilia.Text, cboSector.Text != "" ? cboSector.SelectedValue : null,
                cboSubSector.Text != "" ? cboSubSector.SelectedValue : null,
                txtJardin.Text, txtLote.Text, txtBobedas.Text,
                cboPuerta.Enabled ? cboPuerta.Text : null, txtReferencia.Text
                , cboEstado.SelectedValue, txtObservacion.Text, "0", VariablesMetodosEstaticos.varNombreUser,destino);

                MessageBox.Show("Mausoleo fue actualizado correctamente.");

                this.Close();
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
            if (cboPuerta.Enabled && cboPuerta.Text == string.Empty)
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

        private void cboSector_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            llenarSubSector();
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

                        //lblRuta.Text = "";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " :" + "El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmImagen win = new frmImagen();
            win.RutaImagen = lblRuta.Text;
            win.ShowDialog();
        }
    }
}
