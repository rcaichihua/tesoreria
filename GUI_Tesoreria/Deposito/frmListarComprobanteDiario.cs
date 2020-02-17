using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Deposito
{
    public partial class frmListarComprobanteDiario : DevComponents.DotNetBar.Metro.MetroForm
    {
        private static frmListarComprobanteDiario frmInstance = null;
        public frmListarComprobanteDiario()
        {
            InitializeComponent();
        }
        public static frmListarComprobanteDiario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListarComprobanteDiario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        CNegocio cn = new CNegocio();

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (rbDepositoBanco.Checked)
            {
                frmReporte win = new frmReporte();
                DataSet dsDatos = new DataSet();

                dsDatos = cn.TraerDataset("usp_paDiarioRepo",dtpFechaLiquidación.Value.ToString("yyyyMMdd"),"1");
                dsDatos.Tables[0].TableName = "DIARIO_CAB";
                dsDatos.Tables[1].TableName = "DIARIO_DET";

                win.TipoReporteLiquidacion ="DEPOABANCO";

                if (chkcuentas.Checked)
                {
                    DataTable dtCuenta;

                    foreach (DataRow item in dsDatos.Tables[1].Rows)
                    {
                        dtCuenta = new DataTable();

                        dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2 from contable_privado where CODIGO_CONTABLE1='" + item[1] + "'").Tables[0];

                        if (dtCuenta.Rows.Count <= 0)
                        {
                            item[1] = "S/CTA";
                        }
                        else
                        {
                            item[1] = dtCuenta.Rows[0][0];
                        }
                    }
                }
                win.dsDiario = dsDatos;
                win.ShowDialog();
            }
            else if (rbSinProgParaRegul.Checked)
            {
                frmReporte win = new frmReporte();
                DataSet dsDatos = new DataSet();

                dsDatos = cn.TraerDataset("usp_paDiarioRepo", dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "3");
                dsDatos.Tables[0].TableName = "DIARIO_CAB";
                dsDatos.Tables[1].TableName = "DIARIO_DET";

                win.TipoReporteLiquidacion = "DEPOABANCO";
                if (chkcuentas.Checked)
                {
                    DataTable dtCuenta;

                    foreach (DataRow item in dsDatos.Tables[1].Rows)
                    {
                        dtCuenta = new DataTable();

                        dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2 from contable_privado where CODIGO_CONTABLE1='" + item[1] + "'").Tables[0];

                        if (dtCuenta.Rows.Count <= 0)
                        {
                            item[1] = "S/CTA";
                        }
                        else
                        {
                            item[1] = dtCuenta.Rows[0][0];
                        }
                    }
                }
                win.dsDiario = dsDatos;
                win.ShowDialog();
            }
            else if (rbLiqmesAnterior.Checked)
            {
                frmReporte win = new frmReporte();
                DataSet dsDatos = new DataSet();

                dsDatos = cn.TraerDataset("usp_paDiarioRepo", dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "4");
                dsDatos.Tables[0].TableName = "DIARIO_CAB";
                dsDatos.Tables[1].TableName = "DIARIO_DET";
                win.TipoReporteLiquidacion = "DEPOABANCO";
                if (chkcuentas.Checked)
                {
                    DataTable dtCuenta;

                    foreach (DataRow item in dsDatos.Tables[1].Rows)
                    {
                        dtCuenta = new DataTable();

                        dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2 from contable_privado where CODIGO_CONTABLE1='" + item[1] + "'").Tables[0];

                        if (dtCuenta.Rows.Count <= 0)
                        {
                            item[1] = "S/CTA";
                        }
                        else
                        {
                            item[1] = dtCuenta.Rows[0][0];
                        }
                    }
                }
                win.dsDiario = dsDatos;
                win.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
