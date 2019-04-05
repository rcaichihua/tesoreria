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
    public partial class frmComparaVouchersPagoEfectivo : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();

        public string desde { get; set; }
        public string hasta { get; set; }
        public int idPrograma { get; set; }
        public int modPago { get; set; }

        public frmComparaVouchersPagoEfectivo()
        {
            InitializeComponent();
        }

        private void frmComparaVouchersPagoEfectivo_Load(object sender, EventArgs e)
        {
            DataTable dtComp = new DataTable();
            try
            {
                dtComp = cn.TraerDataset("usp_verificacion_vouchers_deposito",desde,hasta,idPrograma,modPago).Tables[0];

                if (dtComp.Rows.Count > 0)
                {
                    dgvCompara.DataSource = dtComp;
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para moestrar", VariablesMetodosEstaticos.encabezado,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
