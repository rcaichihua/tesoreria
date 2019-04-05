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
    public partial class frmEditarTumbaInventario : DevComponents.DotNetBar.Metro.MetroForm
    {
        string destinoImagen;
        CNegocio cn = new CNegocio();
        public int idTumbaInventario { get; set; }
        public string TipoTumba { get; set; }
        public string CodSector { get; set; }
        public string Jardin { get; set; }
        public string Numero { get; set; }
        public bool Cabezal { get; set; }
        public bool Lapida { get; set; }
        public bool Reja { get; set; }
        public string CodEstadoFisico { get; set; }
        public string Observaciones { get; set; }
        public string RutaImagen { get; set; }

        public frmEditarTumbaInventario()
        {
            InitializeComponent();
        }

        private void frmEditarTumbaInventario_Load(object sender, EventArgs e)
        {
            Bitmap picture;

            cargarCombos();
            txtCodigoTumba.Text = idTumbaInventario.ToString("0000");
            cboTipoTumba.Text = TipoTumba;
            cboSector.Text = CodSector;
            txtJardin.Text = Jardin;
            txtNumero.Text = Numero;
            chkCabezal.Checked = Cabezal;
            chkLapida.Checked = Lapida;
            chkReja.Checked = Reja;
            cboEstadoFisico.Text = CodEstadoFisico;
            txtObservacion.Text = Observaciones;
            if (File.Exists(RutaImagen))
            {
                //pictureBox1.Image = (Image)(new Bitmap(RutaImagen));

                System.IO.FileStream fs;
                fs = new System.IO.FileStream(RutaImagen, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
                lblRuta.Text = RutaImagen;
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
                dt = cn.EjecutarSqlDTS("select CODSECTOR,NOMBRESECTOR from cementerio.SECTOR ORDER BY CODSECTOR ASC").Tables[0];
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            destinoImagen = @"\\192.168.1.8\imagenesgt\cementerio\tumba\";
            string destino = destinoImagen + "T" + txtCodigoTumba.Text + ".jpg";

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

            cn.EjecutarSP("usp_TUMBAINVENTARIOActualizar", txtCodigoTumba.Text, "01", cboTipoTumba.SelectedValue,
                cboSector.SelectedValue, cboEstadoFisico.SelectedValue, txtJardin.Text.Trim(), chkCabezal.Checked
                , txtNumero.Text.Trim(), chkReja.Checked, chkLapida.Checked,
                txtObservacion.Text.Trim(), "0", VariablesMetodosEstaticos.varNombreUser, destino);

            DevComponents.DotNetBar.MessageBoxEx.Show("Actualizado correctamente");

            this.Close();
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

                        //lblRuta.Text = "";
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message + " :" + "El archivo seleccionado no es un tipo de imagen válido");
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
