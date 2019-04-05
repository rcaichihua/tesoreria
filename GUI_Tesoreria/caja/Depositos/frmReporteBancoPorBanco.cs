using DAO_Tesoreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Depositos
{
    public partial class frmReporteBancoPorBanco : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        public frmReporteBancoPorBanco()
        {
            InitializeComponent();
        }

        private void frmReporteBancoPorBanco_Load(object sender, EventArgs e)
        {
            cargarEntidadFinanciera();
        }

        private void cargarEntidadFinanciera()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_entidad_financiera").Tables[0];
                cboEntidadFinanciera.DataSource = dt;
                cboEntidadFinanciera.DisplayMember = "nombre_entidad";
                cboEntidadFinanciera.ValueMember = "cod_entidad_financ";
            }
            catch (Exception)
            {
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesGlobales.NombreMensajes,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cargarCuentaBancaria()
        {
            cboCuenta.SelectedIndex = 0;
        }

        private void cboEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = new DataTable();
                dt = cn.TraerDataset("usp_select_cuenta_bancaria_filtro",
                    cboEntidadFinanciera.SelectedValue).Tables[0];
                cboCuenta.Refresh();
                cboCuenta.DataSource = dt;
                cboCuenta.DisplayMember = "numero_cuenta";
                cboCuenta.ValueMember = "cuenta_bancaria_id";
            }
            catch (Exception)
            {
                //DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesGlobales.NombreMensajes,
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            if (cboCuenta.SelectedIndex==0 ||cboCuenta.DataSource==null)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una cuenta bancaria.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtResu = new DataTable();
            dtResu = cn.TraerDataset("usp_DEPOSITO_BANCO", cboCuenta.SelectedValue, dtpFechaDesde.Value.ToString("yyyyMMdd"), dtpFechaHasta.Value.ToString("yyyyMMdd")).Tables[0];

            if (dtResu.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para mostrar.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmReporte winReport = new frmReporte();
            Reportes.rptDepositosPorRangoFDepositos rptRecibo = new Reportes.rptDepositosPorRangoFDepositos();
            rptRecibo.SetDataSource(dtResu);
            winReport.crvReportes.ReportSource = rptRecibo;
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

    }
}
