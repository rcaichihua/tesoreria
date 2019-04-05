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
    public partial class frmEditarNichoInventario : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        string destinoImagen;
        public int idNichoInventario { get; set; }
        public string codCementerio { get; set; }
        public string codCuartel { get; set; }
        public string codEstado { get; set; }
        public bool tapa { get; set; }
        public string fila { get; set; }
        public int columna { get; set; }
        public string codEstadoFisico { get; set; }
        public string codMaterial { get; set; }
        public bool lapida { get; set; }
        public bool reja { get; set; }
        public string observacion { get; set; }
        public string RutaImagen { get; set; }
        private string ruta_imagen;

        public frmEditarNichoInventario()
        {
            InitializeComponent();
        }

        private void frmEditarNichoInventario_Load(object sender, EventArgs e)
        {
            try
            {
                Bitmap picture;

                ruta_imagen = cn.EjecutarSqlDTS("select other from ta_control where parametro='rura_imagen_nicho'").Tables[0].Rows[0][0].ToString();

                llenarCombos();
                txtIdNicho.Text = idNichoInventario.ToString();
                cboCementerio.Text = codCementerio;
                txtCodigoCuartel.Text = codCuartel;
                cboEstado.Text = codEstado;
                chkTapa.Checked = tapa;
                txtFila.Text = fila;
                txtColumna.Text = columna.ToString();
                cboEstadoFisico.Text = codEstadoFisico;
                cboMaterial.Text = codMaterial;
                chkLapida.Checked = lapida;
                chkReja.Checked = reja;
                txtObservacion.Text = observacion;

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
                    string ruta;
                    ruta = System.Windows.Forms.Application.StartupPath.ToString() + @"\FONDO\\sin imagen.jpg";
                    lblRuta.Text = ruta;
                    picture = new Bitmap(ruta);
                }              
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
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

        private void txtColumna_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
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

                if (cn.EjecutarSP("usp_NICHOINVENTARIOActualizar",idNichoInventario, cboCementerio.SelectedValue, cboEstado.SelectedValue
                , chkTapa.Checked, txtFila.Text, txtColumna.Text, txtCodigoCuartel.Text
                , cboEstadoFisico.SelectedValue, cboMaterial.SelectedValue, chkLapida.Checked
                , chkReja.Checked, txtObservacion.Text, "0", VariablesMetodosEstaticos.varNombreUser,destino) > 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El Nicho fue actualizado correctamente.", VariablesMetodosEstaticos.encabezado
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error. Intente de nuevo o contacte con sistemas.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }     
        }

        bool validar()
        {
            if (txtFila.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la FILA");
                txtFila.Focus();
                return false;
            }
            if (txtColumna.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la COLUMNA");
                txtColumna.Focus();
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
