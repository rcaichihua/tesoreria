using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Contable
{
    public partial class frmDiario : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public string Programa_ { get; set; }
        public int CodPrograma_ { get; set; }

        private DbProviderFactory factoria;
        private string cadenaConexion;
        private string sql;
        private string pathSalida;
        private string ficheroSalida;
        private string nombreTabla;

        private List<string> campos = new List<string>();
        private List<string> parametros = new List<string>();
        private List<string> nombreCampos = new List<string>();

        private string strConnDbf;

        private static frmDiario frmInstance = null;
        private CNegocio cn = new CNegocio();

        public static frmDiario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmDiario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmDiario()
        {
            InitializeComponent();
        }

        private void frmDiario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dato;
            int I;
            I = 0;
            try
            {
                if (!int.TryParse(txtMes.Text, out dato))
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un mes válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
                    txtMes.Focus();
                    return;
                }
                if (!int.TryParse(txtAnio.Text, out dato))
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un año válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
                    txtAnio.Focus();
                    return;
                }

                if (Convert.ToInt32(txtMes.Text) > 12 || Convert.ToInt32(txtMes.Text) < 1)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un mes válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
                    txtMes.Focus();
                    return;
                }

                string message = "Esta seguro de exportar la información a contabilidad?, se van a borrar los datos del mes ingresado.";
                string caption = "...:::Exportar a contabilidad:::...";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                DataTable dtReccem = new DataTable();
                DataTable dtApii_cont = new DataTable();
                DataTable dtAstos = new DataTable();

                //if (!int.TryParse(txtMes.Text,out dato))
                //{
                //    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un mes válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                //                         MessageBoxIcon.Exclamation);
                //    return;
                //}
                //if (!int.TryParse(txtAnio.Text, out dato))
                //{
                //    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un año válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                //                         MessageBoxIcon.Exclamation);
                //    return;
                //}

                //if (Convert.ToInt32(txtMes.Text)>12 || Convert.ToInt32(txtMes.Text) < 1)
                //{
                //    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un mes válido.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                //                         MessageBoxIcon.Exclamation);
                //    return;
                //}

                if (CodPrograma_==1)
                {
                    strConnDbf = Cadena("Siscaja");
                }
                else if (CodPrograma_ == 2)
                {
                    strConnDbf = Cadena("Canevaro");
                }
                else if (CodPrograma_ == 3)
                {
                    strConnDbf = Cadena("Api99");
                }
                else if (CodPrograma_ == 4)
                {
                    strConnDbf = Cadena("Cemecaj");
                }

                DataTable dtFecha = new DataTable();
                dtFecha = cn.EjecutarSqlDTS("select dbo.fn_UltimoDiaMes('"+Convert.ToInt32(txtAnio.Text).ToString("0000")+"','"+
                    Convert.ToInt32(txtMes.Text)+"')").Tables[0];
                string fechaini, fechafin;
                fechaini = Convert.ToInt32(txtAnio.Text).ToString("0000") + "-" + Convert.ToInt32(txtMes.Text).ToString("00") + "-" + "01";
                fechafin = Convert.ToDateTime(dtFecha.Rows[0][0]).ToString("yyyy-MM-dd");

                if (CodPrograma_ == 4)
                {
                    using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = cnd;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = "DELETE FROM RECCEM WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                            cnd.Open();
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "DELETE FROM ASTOS WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                            cmd.ExecuteNonQuery();

                            //astos
                            dtAstos = cn.TraerDataset("USP_OBTIENE_ASTOS", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text),4).Tables[0];

                            if (dtAstos.Rows.Count<=0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }

                            foreach (DataRow item in dtAstos.Rows)
                            {
                                cmd.CommandText = "INSERT INTO ASTOS(FECHA,RECIBO,EFECTIVO,CHEQUE,DOLARES,GARAN,GLOSA1,GLOSA2,GLOSA3,GLOSA4,GLOSA5,GLOSA6) " +
                                " VALUES(#"+item[0].ToString()+"#,'"+ item[1].ToString() + "',"+ item[2].ToString() + ","+ item[3].ToString() + ","+ item[4].ToString() 
                                + ","+ item[5].ToString() + ",'"+ item[6].ToString() + "','" + item[7].ToString() + "','" + item[8].ToString() + "','" + 
                                item[9].ToString() + "','" + item[10].ToString() + "','" + item[11].ToString() + "')";

                                cmd.ExecuteNonQuery();
                            }

                            dtReccem = cn.TraerDataset("usp_exportar_data_ingresos_rango_dbf_EC", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text), 4).Tables[0];

                            if (dtReccem.Rows.Count <= 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de INGRESO, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }

                            foreach (DataRow item in dtReccem.Rows)
                            {
                                cmd.CommandText = "INSERT INTO RECCEM(FECHA,NRODOC,CODCONT,CODCON_REN,MONTO,MODPAG,TIPPAG,FDEPO,CODIGO,FLAG,DONUME) " +
                                " VALUES(#" + item[0].ToString().Substring(6, 4) + "-" +
                                item[0].ToString().Substring(3, 2) + "-" + item[0].ToString().Substring(0, 2) + "#,'" + item[1].ToString() + "','" + item[2].ToString() + "','" + item[3].ToString() + "'," + 
                                item[4].ToString()
                                + ",'" + item[5].ToString() + "','" + item[6].ToString() + "',#" + item[7].ToString().Substring(6,4)+"-"+ 
                                item[7].ToString().Substring(3, 2)+"-"+ item[7].ToString().Substring(0, 2) + "#,'" + item[8].ToString() + "','" +
                                item[9].ToString() + "','" + item[10].ToString() + "')";

                                cmd.ExecuteNonQuery();
                            }
                            cnd.Close();
                            DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                        }
                    }
                }
                else if (CodPrograma_ == 2)
                {
                    using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = cnd;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = "DELETE FROM RECCAN WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                            cnd.Open();
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "DELETE FROM ASTOS WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                            cmd.ExecuteNonQuery();

                            //astos
                            dtAstos = cn.TraerDataset("USP_OBTIENE_ASTOS", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text), 2).Tables[0];

                            if (dtAstos.Rows.Count <= 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }

                            foreach (DataRow item in dtAstos.Rows)
                            {
                                cmd.CommandText = "INSERT INTO ASTOS(FECHA,RECIBO,GLOSA1,GLOSA2,GLOSA3) " +
                                " VALUES(#" + item[0].ToString().Substring(6, 4) + "-" +
                                item[0].ToString().Substring(3, 2) + "-" + item[0].ToString().Substring(0, 2) + "#,'" + item[1].ToString() + "','" + item[2].ToString() + "','" + 
                                item[3].ToString() + "','" + item[4].ToString() + "')";

                                cmd.ExecuteNonQuery();
                            }

                            dtReccem = cn.TraerDataset("usp_exportar_data_ingresos_rango_dbf_EC", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text), 2).Tables[0];

                            if (dtReccem.Rows.Count <= 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de INGRESO, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }

                            foreach (DataRow item in dtReccem.Rows)
                            {
                                cmd.CommandText = "INSERT INTO RECCAN(FECHA,NRODOC,CODIGO,MONTO,MODPAG,TIPPAG,FDEPO,DONUME) " +
                                " VALUES(#" + item[0].ToString().Substring(6, 4) + "-" +
                                item[0].ToString().Substring(3, 2) + "-" + item[0].ToString().Substring(0, 2) + "#,'" + item[1].ToString() + "','" + 
                                item[2].ToString() + "'," + item[3].ToString() + ",'" +
                                item[4].ToString()
                                + "','" + item[5].ToString() + "',#" + item[6].ToString().Substring(6, 4) + "-" +
                                item[6].ToString().Substring(3, 2) + "-" + item[6].ToString().Substring(0, 2) + "#,'" + item[7].ToString() + "')";

                                cmd.ExecuteNonQuery();
                            }
                            cnd.Close();
                            DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                        }
                    }
                }
                else if (CodPrograma_ == 3)
                {
                    using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = cnd;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = "DELETE FROM Apimae WHERE Fch_pago>=#" + fechaini + "# and Fch_pago <=#" + fechafin + "# ";
                            cnd.Open();
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "DELETE FROM Apii_con WHERE Fch_pago>=#" + fechaini + "# and Fch_pago <=#" + fechafin + "# ";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "DELETE FROM ASTOS WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                            cmd.ExecuteNonQuery();

                            //astos
                            dtAstos = cn.TraerDataset("USP_OBTIENE_ASTOS", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text), 3).Tables[0];

                            if (dtAstos.Rows.Count <= 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }

                            foreach (DataRow item in dtAstos.Rows)
                            {
                                cmd.CommandText = "INSERT INTO ASTOS(FECHA,RECIBO,GLOSA1,GLOSA2,GLOSA3,EFECTIVO,CHEQUE,DOLARES,GARAN) " +
                                " VALUES(#" + item[0].ToString().Substring(6, 4) + "-" +
                                item[0].ToString().Substring(3, 2) + "-" + item[0].ToString().Substring(0, 2) + "#,'" + item[1].ToString() + "','" + item[2].ToString() + "','" +
                                item[3].ToString() + "','" + item[4].ToString() + "',0.00,0.00,0.00,0.00)";

                                cmd.ExecuteNonQuery();
                            }

                            dtReccem = cn.TraerDataset("usp_exportar_data_ingresos_rango_dbf_EC", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text), 3).Tables[0];

                            if (dtReccem.Rows.Count <= 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de INGRESO, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }

                            foreach (DataRow item in dtReccem.Rows)
                            {
                                cmd.CommandText = "INSERT INTO APIMAE(COD_INMB,NUM_CONTR,INQUILINO,NUM_RUC,AA,MM,TIP_DOCU,NRO_DOCU,FGIRO,FCH_PAGO,TIP_MOVI" +
                                ",TIP_PAGO,FCH_EM,RENTA,DOCRET,IGV,IGVRET,AUTOSEG,MORA,JUDIC,COD_COB,FDEPO,FLAG,CODCON_REN,CODCON_MOR,CODCON_IGV," +
                                "CODCO_IGVR,CODCON_RES,PRES_IGV,PRES_IGVR,PRES_MOR,PRES_REN,DONUME) " +
                                " VALUES('" + item[0].ToString() + "','" + item[1].ToString() + "','" + item[2].ToString() + "','" + item[3].ToString() + "','" +
                                item[4].ToString() + "','" + item[5].ToString() + "','" + item[6].ToString() + "','" + item[7].ToString() + "',#" +
                                item[8].ToString() + "#,#" + item[9].ToString() + "#,'" +
                                item[10].ToString() + "','" + item[11].ToString() + "',#" + (item[12].ToString().Trim() == string.Empty ? "1900-01-01" :
                                item[12].ToString()) + "#," + item[13].ToString() + ",'" + item[14].ToString() + "'," + item[15].ToString() + "," +
                                item[16].ToString() + "," + (item[17].ToString().Trim() == string.Empty ? "0.00" : item[17].ToString()) + "," + item[18].ToString() +
                                "," + (item[19].ToString().Trim() == string.Empty ? "0.00" : item[19].ToString()) + "," +
                                (item[20].ToString().Trim() == string.Empty ? "0" : item[20].ToString()) + ",#" + item[21].ToString() + "#,'" +
                                item[22].ToString() + "','" + item[23].ToString() + "','" + item[24].ToString() + "','" + item[25].ToString() + "','" +
                                item[26].ToString() + "','" + item[27].ToString() + "','" + item[28].ToString() + "','" + item[29].ToString() + "','" +
                                item[30].ToString() + "','" + item[31].ToString() + "','" + item[32].ToString() + "')";
                                //if (I == 758)
                                //{
                                //    DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                //        MessageBoxIcon.Information);
                                //}
                                //I =  I + 1;
                                cmd.ExecuteNonQuery();
                            }
                            dtApii_cont = cn.TraerDataset("USP_LISTA_APIICONT", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text)).Tables[0];

                            foreach (DataRow item in dtApii_cont.Rows)
                            {
                                cmd.CommandText = "INSERT INTO APII_CON(Cod_inmb,Num_contr,Aa,Mm,Tip_docu,Nro_docu,Fch_pago,Tip_movi,Tip_pago,Codigo,Codigor" +
                                ",monto,Fdepo,Flag,donume) " +
                                " VALUES('" + item[0].ToString() + "','" + item[1].ToString() + "','" + item[2].ToString() + "','" + item[3].ToString() + "','" +
                                item[4].ToString() + "','" + item[5].ToString() + "',#" +
                                item[6].ToString() + "#,'" + item[7].ToString() + "','" +
                                item[8].ToString() + "','" + item[9].ToString() + "','" + item[10].ToString() + "'," + (item[11].ToString().Trim() + ",#" + 
                                item[12].ToString() + "#,'" + item[13].ToString() + "','" + item[14].ToString() + "')");
                                //if (I == 758)
                                //{
                                //    DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                //        MessageBoxIcon.Information);
                                //}
                                //I = I + 1;
                                cmd.ExecuteNonQuery();
                            }

                            cnd.Close();
                            DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (Exception EX)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(EX.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
            }
            
        }
        private string Cadena(string carpeta)
        {
            pathSalida = @"\\192.168.1.192\Archivos_Maliciosos\teso\"+ carpeta + "";

            strConnDbf = @"Provider = Microsoft.Jet.OLEDB.4.0" +
                                   ";Data Source = " + pathSalida +
                                   ";Extended Properties = dBASE IV" +
                                   ";User ID=Admin;Password=;";
            return strConnDbf;
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAnio.Focus();
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();

            }
        }
    }
}
