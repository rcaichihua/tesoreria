using DAO_Tesoreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Tesoreria
{
    public partial class frmExportarIngresos : Form
    {
        public frmExportarIngresos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_exec = "";

            if (cboPrograma.Text == "CEMENTERIO")
            {
                sql_exec = "usp_exportar_data_ingresos_dbf_EC";
            }
            else
                sql_exec = "usp_exportar_data_ingresos_dbf_EC_CANEV";

            if (Databases.Sql2Dbf(conectar.conexionXml,
                "EXEC " + sql_exec + " '"+ ObtieneFecha()+"',"+(cboPrograma.Text == "CEMENTERIO" ? 4 : 2)+"", 
                (cboPrograma.Text=="CEMENTERIO" ? "CEC":"AEC")+dateTimePicker1.Value.Day.ToString("00")+
                dateTimePicker1.Value.Month.ToString("00"),"EC")==false)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se genero el archivo EC, intente nuevamente.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (cboPrograma.Text == "CEMENTERIO")
            {
                sql_exec = "usp_exportar_data_ingresos_dbf_EP";
            }
            else
                sql_exec = "usp_exportar_data_ingresos_dbf_EP_CANEV";

            //if (Databases.Sql2Dbf("Data Source=192.168.1.14;Initial Catalog=bdtesoreria;User ID=usuario_teso;Password=t6s0r6r14",
            if (Databases.Sql2Dbf(conectar.conexionXml,
                "EXEC "+sql_exec+" '" + ObtieneFecha() + "'," + (cboPrograma.Text == "CEMENTERIO" ? 4 : 2) + "",
                (cboPrograma.Text == "CEMENTERIO" ? "CEP" : "AEP") + dateTimePicker1.Value.Day.ToString("00") + 
                dateTimePicker1.Value.Month.ToString("00"),"EP")==false)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se genero el archivo EP, intente nuevamente.", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboPrograma.Text == "CEMENTERIO")
            {
                sql_exec = "usp_exportar_data_ingresos_dbf_REC";
            }
            else
                sql_exec = "usp_exportar_data_ingresos_dbf_REC_CANEV";

            if (Databases.Sql2Dbf(conectar.conexionXml,
                "EXEC "+sql_exec+" '" + ObtieneFecha() + "'," + (cboPrograma.Text == "CEMENTERIO" ? 4 : 2) + "",
                (cboPrograma.Text == "CEMENTERIO" ? "REC" : "REC") + dateTimePicker1.Value.Day.ToString("00") + dateTimePicker1.Value.Month.ToString("00"),"REC")==false)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No se genero el archivo REC, intente nuevamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DevComponents.DotNetBar.MessageBoxEx.Show("Se generaron los archivos correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private string ObtieneFecha()
        {
            string fecha;
            fecha = dateTimePicker1.Value.Year.ToString("0000") + dateTimePicker1.Value.Month.ToString("00") + dateTimePicker1.Value.Day.ToString("00");
            return fecha;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPrograma.SelectedIndex = 0;
        }
    }
}
