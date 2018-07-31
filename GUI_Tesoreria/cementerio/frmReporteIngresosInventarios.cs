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
    public partial class frmReporteIngresosInventarios : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmReporteIngresosInventarios()
        {
            InitializeComponent();
        }

        private void frmReporteIngresosInventarios_Load(object sender, EventArgs e)
        {
            CNegocio cn = new CNegocio();
            //cementerio.frmReporteIngresosInventarios winReport = new cementerio.frmReporteIngresosInventarios();
            DataSet dtsNichos = new DataSet();

            dtsNichos = cn.TraerDataset("usp_LISTADO_NICHOS_INVENTARIO","0000");

            reportes.rptNichosInventario rptRecibo = new reportes.rptNichosInventario();
            rptRecibo.SetDataSource(dtsNichos.Tables[0]);
            crvReportes.ReportSource = rptRecibo;
        }
    }
}
