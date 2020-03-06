using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmEdicionDetalleRecibo : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmEdicionDetalleRecibo()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        public int _IdRecibo { get; set; }
        public string _TipoNroRecibo { get; set; }
        public DataTable _DatosDetalle { get; set; }
        public int Programa_ { get; set; }
        public string Glosa_ { get; set; }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdicionDetaleRecibo_Load(object sender, EventArgs e)
        {
            DataTable dtG = new DataTable();
            LblTitulo.Text = _TipoNroRecibo;
            this.dgvDetalle.DataSource = _DatosDetalle;
            dtG= cn.EjecutarSqlDTS("select Glosa_ReciboCabecera from tb_ReciboCabecera where ReciboID="+ _IdRecibo + "").Tables[0];
            if (dtG.Rows.Count > 0)
            {
                txtGlosa.Text = dtG.Rows[0][0].ToString();
                Glosa_ = txtGlosa.Text;
            }
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow !=null)
            {
                int indice;
                indice = dgvDetalle.CurrentRow.Index;

                frmEdicionDetalleRecibo_editar win = new frmEdicionDetalleRecibo_editar();
                win.Id_detalleRecibo = Convert.ToInt32(dgvDetalle.Rows[indice].Cells[1].Value);
                win.Cod_Rubro = Convert.ToInt32(dgvDetalle.Rows[indice].Cells[2].Value);
                win.Cod_TaId = Convert.ToInt32(dgvDetalle.Rows[indice].Cells[3].Value.ToString()==string.Empty ? "0": dgvDetalle.Rows[indice].Cells[3].Value.ToString());
                win.Descripcion = dgvDetalle.Rows[indice].Cells[4].Value.ToString();
                win.Programa_ = Programa_;
                win.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string message = "Usuario : "+VariablesMetodosEstaticos.varNombreUser+ Environment.NewLine+ "Usted modificara la Glosa del Documento."+
                Environment.NewLine+Environment.NewLine +"Estos cambios quedaran registrados con los siguientes datos." +Environment.NewLine +Environment.NewLine+ 
                "Usuario          : " + VariablesMetodosEstaticos.varUsuario+Environment.NewLine+
                "Nombre de su PC  : "+Environment.MachineName+Environment.NewLine+
                "Fecha y Hora     : "+DateTime.Now.ToString("dd/MM/yyyy") +" a horas "+ DateTime.Now.ToString("HH:mm:ss")+ Environment.NewLine+Environment.NewLine+
                "¿Esta seguro de continuar?";

            string caption = VariablesGlobales.NombreMensajes;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                cn.EjecutarUD("update tb_ReciboCabecera set Glosa_ReciboCabecera='"+txtGlosa.Text.Replace("'","")+"' from tb_ReciboCabecera a inner join tb_ReciboDetalle b on a.ReciboID=b.ReciboID where a.ReciboID=" + _IdRecibo + "");

                cn.EjecutarUD("insert into auditoria_ReciboCabecera(usumod,pcmod,fechamod,tipomod,glosa_ant,glosa_mod,id_moddif) VALUES('" +
                    VariablesMetodosEstaticos.varUsuario+"','"+Environment.MachineName+"',GETDATE(),'MODIF_GLOSA','"+Glosa_+"','"+txtGlosa.Text+"',"+ _IdRecibo + ")");

                DevComponents.DotNetBar.MessageBoxEx.Show("Se actualizo la Glosa correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
