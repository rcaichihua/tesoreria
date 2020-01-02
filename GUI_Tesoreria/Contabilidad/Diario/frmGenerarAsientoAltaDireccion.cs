using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using DAO_Tesoreria;

namespace GUI_Tesoreria.Contabilidad.Diario
{
    public partial class frmGenerarAsientoAltaDireccion : DevComponents.DotNetBar.Metro.MetroForm
    {
        public string Programa_ { get; set; }
        public int CodPrograma_ { get; set; }

        private string pathSalida;
        private string pathSalida2;

        private string strConnDbf;
        private string strConnDbf_2;

        private static frmGenerarAsientoAltaDireccion frmInstance = null;
        private CNegocio cn = new CNegocio();
        CDatos cd = new CDatos();

        public static frmGenerarAsientoAltaDireccion Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmGenerarAsientoAltaDireccion();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmGenerarAsientoAltaDireccion()
        {
            InitializeComponent();
        }

        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

        private DataParameter _inputparameter;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblCantidadProcesos.Visible = true;
            if (!backgroundWorker.IsBusy)
            {
                btnAceptar.Enabled = false;
                backgroundWorker.RunWorkerAsync(_inputparameter);
            }
        }

        private string Cadena(string carpeta)
        {
            DataTable dtRuta = new DataTable();
            dtRuta = cn.EjecutarSqlDTS("select path_sis from ruta_sistemas where sistema='tesoreria'").Tables[0];

            pathSalida = @"" + dtRuta.Rows[0][0].ToString() + carpeta + @"\";

            strConnDbf = @"Provider = Microsoft.Jet.OLEDB.4.0" +
                                   ";Data Source = " + pathSalida +
                                   ";Extended Properties = dBASE IV" +
                                   ";User ID=Admin;Password=;";

            dtRuta = cn.EjecutarSqlDTS("select path_sis from ruta_sistemas where sistema='Contabilidad'").Tables[0];

            pathSalida2 = @"" + dtRuta.Rows[0][0].ToString();

            strConnDbf_2 = @"Provider=VFPOLEDB.1;Data Source=" + pathSalida2 + ";Collating Sequence=general";

            return strConnDbf;
        }

        private Boolean BuscarArchivo(string fileSearch, string dir1)
        {
            Boolean resu;
            System.IO.DirectoryInfo dirOrigenInfo = new DirectoryInfo(dir1);

            System.IO.FileInfo[] fileDirOrigenNames = dirOrigenInfo.GetFiles("*.DBF*");

            var file2 = fileDirOrigenNames.FirstOrDefault(f => f.Name.ToUpper() == (fileSearch + ".dbf").ToUpper());
            if (file2 == null)
            {
                resu = false;
            }
            else
            {
                resu = true;
            }
            return resu;
        }

        private void txtMes_KeyDown(object sender, KeyEventArgs e)
        {
            var left = KeyboardInfo.GetKeyState(Keys.Left);
            var right = KeyboardInfo.GetKeyState(Keys.Right);
            var up = KeyboardInfo.GetKeyState(Keys.Up);
            var down = KeyboardInfo.GetKeyState(Keys.Down);

            if (down.IsPressed)
            {
                if (txtMes.SelectionStart == txtMes.Text.Length)
                {
                    txtAnio.Focus();
                }
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAnio.Focus();
            }
        }

        private void txtAnio_KeyDown(object sender, KeyEventArgs e)
        {
            var left = KeyboardInfo.GetKeyState(Keys.Left);
            var right = KeyboardInfo.GetKeyState(Keys.Right);
            var up = KeyboardInfo.GetKeyState(Keys.Up);
            var down = KeyboardInfo.GetKeyState(Keys.Down);

            if (down.IsPressed)
            {
                if (txtAnio.SelectionStart == txtAnio.Text.Length)
                {
                    btnAceptar.Focus();
                }
            }
            else if (up.IsPressed)
            {
                if (txtAnio.SelectionStart == txtAnio.Text.Length)
                {
                    txtMes.Focus();
                }
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se cancelo la exportación según la petición del usuario o sucedio un error inesperado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
            }
            else if (e.Error != null)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error. " + e.Error.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information);
            }
            btnAceptar.Enabled = true;
            lblCantidadProcesos.Visible = false;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;

            try
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
                        e.Cancel = true;
                        return;
                    }

                    DataTable dtReccem = new DataTable();
                    DataTable dtApii_cont = new DataTable();
                    DataTable dtAstos = new DataTable();
                    DataSet dtAltaDireccion = new DataSet();

                    if (CodPrograma_ == 1)
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

                    dtFecha = cn.EjecutarSqlDTS("select dbo.fn_UltimoDiaMes('" + Convert.ToInt32(txtAnio.Text).ToString("0000") + "','" +
                        Convert.ToInt32(txtMes.Text) + "')").Tables[0];
                    string fechaini, fechafin;
                    fechaini = Convert.ToInt32(txtAnio.Text).ToString("0000") + "-" + Convert.ToInt32(txtMes.Text).ToString("00") + "-" + "01";
                    fechafin = Convert.ToDateTime(dtFecha.Rows[0][0]).ToString("yyyy-MM-dd");
                    //cementerio
                    if (CodPrograma_ == 4)
                    {
                        using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = cnd;
                                cmd.CommandType = CommandType.Text;
                                cnd.Open();

                                cmd.CommandText = "DELETE FROM TRUBROS pack";
                                cmd.ExecuteNonQuery();

                                cmd.CommandText = "DELETE FROM RECCEM pack";// WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                                cmd.ExecuteNonQuery();

                                cmd.CommandText = "DELETE FROM ASTOS pack";// WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                                cmd.ExecuteNonQuery();

                                dtAltaDireccion = cn.TraerDataset("usp_obtiene_rubros_cuentas_alta_direccion");

                                foreach (DataRow item in dtAltaDireccion.Tables[2].Rows)
                                {
                                    cmd.CommandText = "INSERT INTO TRUBROS" +
                                    " VALUES('" + item[0].ToString() + "','" + item[1].ToString() + "','" +
                                    item[2].ToString() + "','" + item[4].ToString() + "','" + item[3].ToString() + "','" +
                                    item[5].ToString() + "')";

                                    cmd.ExecuteNonQuery();
                                }

                                //astos
                                dtAstos = cn.TraerDataset("USP_OBTIENE_ASTOS", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text), 4).Tables[0];

                                if (dtAstos.Rows.Count <= 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                                    return;
                                }

                                foreach (DataRow item in dtAstos.Rows)
                                {
                                    cmd.CommandText = "INSERT INTO ASTOS(FECHA,RECIBO,EFECTIVO,CHEQUE,DOLARES,GARAN,GLOSA1,GLOSA2,GLOSA3,GLOSA4,GLOSA5,GLOSA6) " +
                                    " VALUES(#" + item[0].ToString() + "#,'" + item[1].ToString() + "'," + item[2].ToString() + "," + item[3].ToString() + "," + item[4].ToString()
                                    + "," + item[5].ToString() + ",'" + item[6].ToString() + "','" + item[7].ToString() + "','" + item[8].ToString() + "','" +
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

                                process = dtReccem.Rows.Count;
                                index = 0;

                                _inputparameter.Process = 1;
                                _inputparameter.Delay = 1;


                                foreach (DataRow item in dtReccem.Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO RECCEM(FECHA,NRODOC,CODCONT,CODCON_REN,MONTO,MODPAG,TIPPAG,FDEPO,CODIGO,FLAG,DONUME) " +
                                    " VALUES(#" + item[0].ToString().Substring(6, 4) + "-" +
                                    item[0].ToString().Substring(3, 2) + "-" + item[0].ToString().Substring(0, 2) + "#,'" + item[1].ToString() + "','" + item[2].ToString() + "','" + item[3].ToString() + "'," +
                                    item[4].ToString()
                                    + ",'" + item[5].ToString() + "','" + (item[6].ToString().Length > 1 ? (item[6].ToString() == "03" ? "B" : (item[6].ToString() == "01" ? "F" : "R")) : item[6].ToString()) + "',#" + item[7].ToString().Substring(6, 4) + "-" +
                                    item[7].ToString().Substring(3, 2) + "-" + item[7].ToString().Substring(0, 2) + "#,'" + item[8].ToString() + "','" +
                                    item[9].ToString() + "','" + item[10].ToString() + "')";

                                        cmd.ExecuteNonQuery();
                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));
                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }
                                cnd.Close();
                                //DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                //             MessageBoxIcon.Information);

                            }
                        }
                    }
                    //albergues
                    else if (CodPrograma_ == 2)
                    {
                        using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = cnd;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "DELETE FROM RECCAN PACK";// WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
                                cnd.Open();
                                cmd.ExecuteNonQuery();

                                cmd.CommandText = "DELETE FROM ASTOS pack";// WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
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

                                process = dtReccem.Rows.Count;
                                index = 0;

                                _inputparameter.Process = 1;
                                _inputparameter.Delay = 1;

                                foreach (DataRow item in dtReccem.Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO RECCAN(FECHA,NRODOC,CODIGO,MONTO,MODPAG,TIPPAG,FDEPO,DONUME) " +
                                        " VALUES(#" + item[0].ToString().Substring(6, 4) + "-" +
                                        item[0].ToString().Substring(3, 2) + "-" + item[0].ToString().Substring(0, 2) + "#,'" + item[1].ToString() + "','" +
                                        item[2].ToString() + "'," + item[3].ToString() + ",'" +
                                        item[4].ToString()
                                        + "','" + item[5].ToString() + "',#" + item[6].ToString().Substring(6, 4) + "-" +
                                        item[6].ToString().Substring(3, 2) + "-" + item[6].ToString().Substring(0, 2) + "#,'" + item[7].ToString() + "')";

                                        cmd.ExecuteNonQuery();
                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));
                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }
                                cnd.Close();
                                //DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                //             MessageBoxIcon.Information);

                            }
                        }
                    }
                    //inmobiliaria  
                    else if (CodPrograma_ == 3)
                    {
                        using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = cnd;
                                cmd.CommandType = CommandType.Text;

                                cmd.CommandText = "DELETE FROM Apimae pack";// WHERE Fch_pago>=#" + fechaini + "# and Fch_pago <=#" + fechafin + "# ";
                                cnd.Open();
                                cmd.ExecuteNonQuery();

                                cmd.CommandText = "DELETE FROM Apii_con pack";// WHERE Fch_pago>=#" + fechaini + "# and Fch_pago <=#" + fechafin + "# ";
                                cmd.ExecuteNonQuery();

                                cmd.CommandText = "DELETE FROM ASTOS pack";// WHERE FECHA>=#" + fechaini + "# and FECHA <=#" + fechafin + "# ";
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

                                process = dtReccem.Rows.Count;
                                index = 0;

                                _inputparameter.Process = 1;
                                _inputparameter.Delay = 2;

                                foreach (DataRow item in dtReccem.Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO APIMAE(COD_INMB,NUM_CONTR,INQUILINO,NUM_RUC,AA,MM,TIP_DOCU,NRO_DOCU,FGIRO,FCH_PAGO,TIP_MOVI" +
                                        ",TIP_PAGO,FCH_EM,RENTA,DOCRET,IGV,IGVRET,AUTOSEG,MORA,JUDIC,COD_COB,FDEPO,FLAG,CODCON_REN,CODCON_MOR,CODCON_IGV," +
                                        "CODCO_IGVR,CODCON_RES,PRES_IGV,PRES_IGVR,PRES_MOR,PRES_REN,DONUME) " +
                                        " VALUES('" + item[0].ToString() + "','" + item[1].ToString() + "','" + item[2].ToString().Replace("'", "''").ToString() + "','" + item[3].ToString() + "','" +
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

                                        cmd.ExecuteNonQuery();

                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));
                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }
                                dtApii_cont = cn.TraerDataset("USP_LISTA_APIICONT", Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtMes.Text)).Tables[0];

                                process = dtApii_cont.Rows.Count;
                                index = 0;

                                _inputparameter.Process = 2;
                                _inputparameter.Delay = 2;

                                foreach (DataRow item in dtApii_cont.Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO APII_CON(Cod_inmb,Num_contr,Aa,Mm,Tip_docu,Nro_docu,Fch_pago,Tip_movi,Tip_pago,Codigo,Codigor" +
                                        ",monto,Fdepo,Flag,donume) " +
                                        " VALUES('" + item[0].ToString() + "','" + item[1].ToString() + "','" + item[2].ToString() + "','" + item[3].ToString() + "','" +
                                        item[4].ToString() + "','" + item[5].ToString() + "',#" +
                                        item[6].ToString() + "#,'" + item[7].ToString() + "','" +
                                        item[8].ToString() + "','" + item[9].ToString() + "','" + item[10].ToString() + "'," + (item[11].ToString().Trim() + ",#" +
                                        item[12].ToString() + "#,'" + item[13].ToString() + "','" + item[14].ToString() + "')");

                                        cmd.ExecuteNonQuery();
                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));
                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }
                                cnd.Close();
                            }
                        }
                    }
                    //ALTA DIRECCIOMN
                    else if (CodPrograma_ == 1)
                    {
                        if (!BuscarArchivo("c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") + txtAnio.Text.Substring(3, 1), pathSalida2))
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("La tabla " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                txtAnio.Text.Substring(3, 1) + ".DBF no existe.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
                            e.Cancel = true;
                            return;
                        }

                        using (OleDbConnection cnd = new OleDbConnection(strConnDbf_2))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = cnd;
                                cnd.Open();

                                dtAltaDireccion = cn.TraerDataset("USP_ALTA_DIRECCION_CONTAB2009", txtAnio.Text, Convert.ToInt16(txtMes.Text).ToString("00"));

                                if (dtAltaDireccion.Tables[0].Rows.Count <= 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                                    return;
                                }

                                cmd.CommandText = "DELETE FROM " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                    txtAnio.Text.Substring(3, 1) + " WHERE auxcod = ? and " + "Dofech between ? and ? " + " ";
                                cmd.Parameters.Clear();

                                cmd.Parameters.Add("@aux", OleDbType.Char).Value = "00000039";

                                cmd.Parameters.Add("@ini", OleDbType.Date).Value = (fechaini.ToString().Trim() == string.Empty ? new
                                        DateTime(1900, 1, 1) :
                                        new DateTime(Convert.ToInt16(fechaini.ToString().Substring(0, 4)),
                                        Convert.ToInt16(fechaini.ToString().Substring(5, 2)),
                                        Convert.ToInt16(fechaini.ToString().Substring(8, 2))));

                                cmd.Parameters.Add("@fin", OleDbType.Date).Value = (fechafin.ToString().Trim() == string.Empty ? new
                                        DateTime(1900, 1, 1) :
                                        new DateTime(Convert.ToInt16(fechafin.ToString().Substring(0, 4)),
                                        Convert.ToInt16(fechafin.ToString().Substring(5, 2)),
                                        Convert.ToInt16(fechafin.ToString().Substring(8, 2))));

                                //cmd.ExecuteNonQuery();

                                cmd.CommandText = "set null off";

                                cmd.ExecuteNonQuery();

                                process = dtAltaDireccion.Tables[0].Rows.Count;
                                index = 0;

                                _inputparameter.Process = 1;
                                _inputparameter.Delay = 3;

                                foreach (DataRow item in dtAltaDireccion.Tables[0].Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                    txtAnio.Text.Substring(3, 1) + " "
                                             + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                        "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user)"
                                             + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?)";

                                        /*cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                    txtAnio.Text.Substring(3, 1) + " "
                                             + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                        "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user,periodo,glosa,dorgcodi,dorgnume)"
                                             + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?, ?, ?, ?, ?)";*/

                                        cmd.Parameters.Clear();
                                        cmd.Parameters.Add("docodi", OleDbType.Char).Value = item[0].ToString();
                                        cmd.Parameters.Add("donume", OleDbType.Char).Value = item[1].ToString();
                                        cmd.Parameters.Add("dofech", OleDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                                            DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                                            Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[2].ToString().Substring(6, 2))));
                                        cmd.Parameters.Add("auxcod", OleDbType.Char).Value = item[3].ToString();
                                        cmd.Parameters.Add("dorfcodi", OleDbType.Char).Value = item[4].ToString();
                                        cmd.Parameters.Add("dorffech", OleDbType.Date).Value = null;/*(item[5].ToString().Trim() == string.Empty ? new
                                            DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[5].ToString().Substring(0, 4)),
                                            Convert.ToInt16(item[5].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[5].ToString().Substring(6, 2))))*/;
                                        cmd.Parameters.Add("dorfnume", OleDbType.Char).Value = item[6].ToString();
                                        cmd.Parameters.Add("donoco", OleDbType.Char).Value = item[7].ToString();
                                        cmd.Parameters.Add("doglco", OleDbType.Char).Value = item[8].ToString();
                                        cmd.Parameters.Add("plcodi", OleDbType.Char).Value = item[9].ToString();
                                        cmd.Parameters.Add("dodeha", OleDbType.Char).Value = item[10].ToString();
                                        cmd.Parameters.Add("domovi", OleDbType.Decimal).Value = (item[11].ToString().Trim() == string.Empty ? 0.00m : Convert.ToDecimal(item[11].ToString()));
                                        cmd.Parameters.Add("anulado", OleDbType.Char).Value = item[12].ToString();
                                        cmd.Parameters.Add("clase", OleDbType.Char).Value = item[13].ToString();

                                        //string file2read = @"\\192.168.1.192\Archivos_Maliciosos\conta\contab2009\prueba.txt";
                                        string memoContent;
                                        //using (StreamReader sr = new StreamReader(file2read))
                                        //{
                                        memoContent = item[17].ToString();// sr.ReadToEnd();
                                                                          //}
                                        cmd.Parameters.Add("Cammem", OleDbType.Char).Value = memoContent;
                                        cmd.Parameters.Add("fsis", OleDbType.Date).Value = null /*(item[14].ToString().Trim() == string.Empty ? new DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[14].ToString().Substring(0, 4)), Convert.ToInt16(item[14].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[14].ToString().Substring(6, 2))))*/;
                                        cmd.Parameters.Add("user", OleDbType.Char).Value = VariablesMetodosEstaticos.varUsuario;
                                        /*cmd.Parameters.Add("periodo", OleDbType.Char).Value = item[16].ToString();
                                        cmd.Parameters.Add("glosa", OleDbType.Char).Value = item[17].ToString();
                                        cmd.Parameters.Add("dorgcodi", OleDbType.Char).Value = item[18].ToString();
                                        cmd.Parameters.Add("dorgnume", OleDbType.Char).Value = item[19].ToString();*/

                                        cmd.ExecuteNonQuery();
                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));

                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }

                                dtAltaDireccion = cn.TraerDataset("usp_haber_ingresos_contab", CodPrograma_, txtAnio.Text,
                                    Convert.ToInt16(txtMes.Text).ToString("00"));

                                if (dtAltaDireccion.Tables[0].Rows.Count <= 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                                    return;
                                }

                                process = dtAltaDireccion.Tables[0].Rows.Count;
                                index = 0;

                                _inputparameter.Process = 2;
                                _inputparameter.Delay = 3;

                                foreach (DataRow item in dtAltaDireccion.Tables[0].Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                    txtAnio.Text.Substring(3, 1) + " "
                                             + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                        "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user)"
                                             + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?)";

                                        /*cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                        txtAnio.Text.Substring(3, 1) + " "
                                                 + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                            "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user,periodo,glosa,dorgcodi,dorgnume)"
                                                 + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?, ?, ?, ?, ?)";*/

                                        cmd.Parameters.Clear();
                                        cmd.Parameters.Add("docodi", OleDbType.Char).Value = item[0].ToString();
                                        cmd.Parameters.Add("donume", OleDbType.Char).Value = item[1].ToString();
                                        cmd.Parameters.Add("dofech", OleDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                                            DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                                            Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[2].ToString().Substring(6, 2))));
                                        cmd.Parameters.Add("auxcod", OleDbType.Char).Value = item[3].ToString();
                                        cmd.Parameters.Add("dorfcodi", OleDbType.Char).Value = item[4].ToString();
                                        cmd.Parameters.Add("dorffech", OleDbType.Date).Value = null;/*(item[5].ToString().Trim() == string.Empty ? new
                                            DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[5].ToString().Substring(0, 4)),
                                            Convert.ToInt16(item[5].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[5].ToString().Substring(6, 2))))*/
                                        ;
                                        cmd.Parameters.Add("dorfnume", OleDbType.Char).Value = item[6].ToString();
                                        cmd.Parameters.Add("donoco", OleDbType.Char).Value = item[7].ToString();
                                        cmd.Parameters.Add("doglco", OleDbType.Char).Value = item[8].ToString();
                                        cmd.Parameters.Add("plcodi", OleDbType.Char).Value = item[9].ToString();
                                        cmd.Parameters.Add("dodeha", OleDbType.Char).Value = item[10].ToString();
                                        cmd.Parameters.Add("domovi", OleDbType.Decimal).Value = (item[11].ToString().Trim() == string.Empty ? 0.00m : Convert.ToDecimal(item[11].ToString()));
                                        cmd.Parameters.Add("anulado", OleDbType.Char).Value = item[12].ToString();
                                        cmd.Parameters.Add("clase", OleDbType.Char).Value = item[13].ToString();

                                        //string file2read = @"\\192.168.1.192\Archivos_Maliciosos\conta\contab2009\prueba.txt";
                                        string memoContent;
                                        //using (StreamReader sr = new StreamReader(file2read))
                                        //{
                                        memoContent = item[17].ToString();// sr.ReadToEnd();
                                                                          //}
                                        cmd.Parameters.Add("Cammem", OleDbType.Char).Value = memoContent;
                                        cmd.Parameters.Add("fsis", OleDbType.Date).Value = null;/*(item[14].ToString().Trim() == string.Empty ? new DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[14].ToString().Substring(0, 4)), Convert.ToInt16(item[14].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[14].ToString().Substring(6, 2))))*/;
                                        cmd.Parameters.Add("user", OleDbType.Char).Value = VariablesMetodosEstaticos.varUsuario; //item[15].ToString();
                                        /*cmd.Parameters.Add("periodo", OleDbType.Char).Value = item[16].ToString();
                                        cmd.Parameters.Add("glosa", OleDbType.Char).Value = item[17].ToString();
                                        cmd.Parameters.Add("dorgcodi", OleDbType.Char).Value = item[18].ToString();
                                        cmd.Parameters.Add("dorgnume", OleDbType.Char).Value = item[19].ToString();*/

                                        cmd.ExecuteNonQuery();
                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));

                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }

                                process = dtAltaDireccion.Tables[1].Rows.Count;
                                index = 0;

                                _inputparameter.Process = 3;
                                _inputparameter.Delay = 3;

                                foreach (DataRow item in dtAltaDireccion.Tables[1].Rows)
                                {
                                    if (!backgroundWorker.CancellationPending)
                                    {
                                        cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                    txtAnio.Text.Substring(3, 1) + " "
                                             + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                        "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user)"
                                             + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?)";

                                        /*cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                                        txtAnio.Text.Substring(3, 1) + " "
                                                 + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                            "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user,periodo,glosa,dorgcodi,dorgnume)"
                                                 + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?, ?, ?, ?, ?)";*/

                                        cmd.Parameters.Clear();
                                        cmd.Parameters.Add("docodi", OleDbType.Char).Value = item[0].ToString();
                                        cmd.Parameters.Add("donume", OleDbType.Char).Value = item[1].ToString();
                                        cmd.Parameters.Add("dofech", OleDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                                            DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                                            Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[2].ToString().Substring(6, 2))));
                                        cmd.Parameters.Add("auxcod", OleDbType.Char).Value = item[3].ToString();
                                        cmd.Parameters.Add("dorfcodi", OleDbType.Char).Value = item[4].ToString();
                                        cmd.Parameters.Add("dorffech", OleDbType.Date).Value = null;/*(item[5].ToString().Trim() == string.Empty ? new
                                            DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[5].ToString().Substring(0, 4)),
                                            Convert.ToInt16(item[5].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[5].ToString().Substring(6, 2))));*/
                                        cmd.Parameters.Add("dorfnume", OleDbType.Char).Value = item[6].ToString();
                                        cmd.Parameters.Add("donoco", OleDbType.Char).Value = item[7].ToString();
                                        cmd.Parameters.Add("doglco", OleDbType.Char).Value = item[8].ToString();
                                        cmd.Parameters.Add("plcodi", OleDbType.Char).Value = item[9].ToString();
                                        cmd.Parameters.Add("dodeha", OleDbType.Char).Value = item[10].ToString();
                                        cmd.Parameters.Add("domovi", OleDbType.Decimal).Value = (item[11].ToString().Trim() == string.Empty ? 0.00m : Convert.ToDecimal(item[11].ToString()));
                                        cmd.Parameters.Add("anulado", OleDbType.Char).Value = item[12].ToString();
                                        cmd.Parameters.Add("clase", OleDbType.Char).Value = item[13].ToString();

                                        //string file2read = @"\\192.168.1.192\Archivos_Maliciosos\conta\contab2009\prueba.txt";
                                        string memoContent;
                                        //using (StreamReader sr = new StreamReader(file2read))
                                        //{
                                        memoContent = item[17].ToString();// sr.ReadToEnd();
                                                                          //}
                                        cmd.Parameters.Add("Cammem", OleDbType.Char).Value = memoContent;
                                        cmd.Parameters.Add("fsis", OleDbType.Date).Value = null;/*(item[14].ToString().Trim() == string.Empty ? new DateTime(1900, 1, 1) :
                                            new DateTime(Convert.ToInt16(item[14].ToString().Substring(0, 4)), Convert.ToInt16(item[14].ToString().Substring(4, 2)),
                                            Convert.ToInt16(item[14].ToString().Substring(6, 2))));*/
                                        cmd.Parameters.Add("user", OleDbType.Char).Value = VariablesMetodosEstaticos.varUsuario; // item[15].ToString();
                                        /*cmd.Parameters.Add("periodo", OleDbType.Char).Value = item[16].ToString();
                                        cmd.Parameters.Add("glosa", OleDbType.Char).Value = item[17].ToString();
                                        cmd.Parameters.Add("dorgcodi", OleDbType.Char).Value = item[18].ToString();
                                        cmd.Parameters.Add("dorgnume", OleDbType.Char).Value = item[19].ToString();*/

                                        cmd.ExecuteNonQuery();
                                        index = index + 1;
                                        backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));

                                    }
                                    else
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }
                                cmd.CommandText = "set null on";

                                cmd.ExecuteNonQuery();

                                cnd.Close();
                            }
                        }
                    }
                }
                catch (Exception EX)

                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(EX.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCantidadProcesos.Text = _inputparameter.Process.ToString() + " de " + _inputparameter.Delay.ToString();
            progressbar.Value = e.ProgressPercentage;
            lblPorcentaje.Text = string.Format("Transfiriendo... {0}%", e.ProgressPercentage);
            progressbar.Update();
        }

        private void frmGenerarAsientoAltaDireccion_Load(object sender, EventArgs e)
        {

        }
    }
}
