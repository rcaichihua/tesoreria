using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Contabilidad
{
    public partial class frmMantenimientoDepositos : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        string StrTip;
        private static frmMantenimientoDepositos frmInstance = null;
        DataTable dtDepositos;
        CNegocio cn = new CNegocio();
        public frmMantenimientoDepositos()
        {
            InitializeComponent();
        }
        public static frmMantenimientoDepositos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantenimientoDepositos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantenimientoDepositos_Load(object sender, EventArgs e)
        {
            habilitarBotones(false);
        }

        private void habilitarBotones(bool e)
        {
            BtnNuevo.Enabled = e;
            btnEliminar.Enabled = e;
            btnModificar.Enabled = e;
            btnImprimir.Enabled = e;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            verDepositos();
        }

        private void verDepositos()
        {
            dtDepositos = new DataTable();
            StrTip = "1";
            if (chkOtros.Checked == true) StrTip = "2";
            dtDepositos = cn.TraerDataset("usp_DEPOSITO_CONSULTAS","1",dtpFechaLiq.Value.ToShortDateString(),StrTip).Tables[0];
            dgvDepositos.DataSource = dtDepositos;
    
            if (dtDepositos.Rows.Count >0){
                habilitarBotones(true);
            }
            else
            {
                habilitarBotones(false);
                MessageBox.Show("No hay datos.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
