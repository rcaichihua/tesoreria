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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdicionDetaleRecibo_Load(object sender, EventArgs e)
        {
            DataTable dtG = new DataTable();
            LblTitulo.Text = _TipoNroRecibo;
            this.dgvRecibos.DataSource = _DatosDetalle;
            dtG= cn.EjecutarSqlDTS("select Glosa_ReciboCabecera from tb_ReciboCabecera where ReciboID="+ _IdRecibo + "").Tables[0];
            if (dtG.Rows.Count > 0)
            {
                txtGlosa.Text = dtG.Rows[0][0].ToString();
            }
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
