using BL_Tesoreria;
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
using Syncfusion.XlsIO;

namespace GUI_Tesoreria.Deposito
{
    public partial class frmMigraDiario : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public string Programa_ { get; set; }
        public int CodPrograma_ { get; set; }

        private string strConnDbf;
        private string pathSalida;

        private static frmMigraDiario frmInstance = null;
        private CNegocio cn = new CNegocio();

        public static frmMigraDiario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMigraDiario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmMigraDiario()
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
            dtRuta = cn.EjecutarSqlDTS("select path_sis from ruta_sistemas where sistema='contabilidad'").Tables[0];

            pathSalida = @""+ dtRuta.Rows[0][0] + carpeta + @"\";
            //strConnDbf = @"Provider=VFPOLEDB.1;Data Source=" + pathSalida + ";Collating Sequence=general";
            strConnDbf = "Server=192.168.1.14;Database=bdtesoreria;User Id=sa;Password=s3gur1d@dsblm;";

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

                    strConnDbf = Cadena("");

                    DataTable dtFecha = new DataTable();

                    dtFecha = cn.EjecutarSqlDTS("select dbo.fn_UltimoDiaMes('" + Convert.ToInt32(txtAnio.Text).ToString("0000") + "','" +
                        Convert.ToInt32(txtMes.Text) + "')").Tables[0];
                    string fechaini, fechafin;
                    fechaini = Convert.ToInt32(txtAnio.Text).ToString("0000") + "-" + Convert.ToInt32(txtMes.Text).ToString("00") + "-" + "01";
                    fechafin = Convert.ToDateTime(dtFecha.Rows[0][0]).ToString("yyyy-MM-dd");

                    //if (!BuscarArchivo("c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") + txtAnio.Text.Substring(3, 1), pathSalida))
                    //{
                    //    DevComponents.DotNetBar.MessageBoxEx.Show("La tabla " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                    //        txtAnio.Text.Substring(3, 1) + ".DBF no existe.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                    //                        MessageBoxIcon.Warning);
                    //    e.Cancel = true;
                    //    return;
                    //}

                    //using (OleDbConnection cnd = new OleDbConnection(strConnDbf))
                    //{
                    //    using (OleDbCommand cmd = new OleDbCommand())
                    //    {
                    //        cmd.Connection = cnd;
                    //        cnd.Open();

                    //        dtAltaDireccion = cn.TraerDataset("paDiario_Consulta", Convert.ToInt16(txtMes.Text), 
                    //            Convert.ToInt16(txtAnio.Text));

                    //        if (dtAltaDireccion.Tables[0].Rows.Count <= 0)
                    //        {
                    //            DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                    //                        MessageBoxIcon.Error);
                    //            return;
                    //        }

                    //        cmd.CommandText = "DELETE FROM " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") +
                    //                txtAnio.Text.Substring(3, 1) + " WHERE auxcod = ? and " + "Dofech between ? and ? " + " ";
                    //        cmd.Parameters.Clear();

                    //        cmd.Parameters.Add("@aux", OleDbType.Char).Value = "00000040";

                    //        cmd.Parameters.Add("@ini", OleDbType.Date).Value = (fechaini.ToString().Trim() == string.Empty ? new
                    //                DateTime(1900, 1, 1) :
                    //                new DateTime(Convert.ToInt16(fechaini.ToString().Substring(0, 4)),
                    //                Convert.ToInt16(fechaini.ToString().Substring(5, 2)),
                    //                Convert.ToInt16(fechaini.ToString().Substring(8, 2))));

                    //        cmd.Parameters.Add("@fin", OleDbType.Date).Value = (fechafin.ToString().Trim() == string.Empty ? new
                    //                DateTime(1900, 1, 1) :
                    //                new DateTime(Convert.ToInt16(fechafin.ToString().Substring(0, 4)),
                    //                Convert.ToInt16(fechafin.ToString().Substring(5, 2)),
                    //                Convert.ToInt16(fechafin.ToString().Substring(8, 2))));

                    //        cmd.ExecuteNonQuery();

                    //        cmd.CommandText = "set null off";

                    //        cmd.ExecuteNonQuery();

                    //        process = dtAltaDireccion.Tables[0].Rows.Count;
                    //        index = 0;

                    //        _inputparameter.Process = 1;
                    //        _inputparameter.Delay = 1;

                    //        foreach (DataRow item in dtAltaDireccion.Tables[0].Rows)
                    //        {
                    //            if (!backgroundWorker.CancellationPending)
                    //            {
                    //                cmd.CommandText = "INSERT INTO " + "c01cd" + Convert.ToInt32(txtMes.Text).ToString("00") + txtAnio.Text.Substring(3, 1) + " "
                    //                        + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                    //                "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,user)"
                    //                        + "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?, ?)";
                    //                decimal tipo;
                    //                cmd.Parameters.Clear();
                    //                cmd.Parameters.Add("docodi", OleDbType.Char).Value = item[0].ToString();//
                    //                if (decimal.TryParse(item[1].ToString().Trim(), out tipo))
                    //                {
                    //                    cmd.Parameters.Add("donume", OleDbType.Char).Value = item[1].ToString().Trim() == "" ? "" :
                    //                    Convert.ToInt32(item[1].ToString()).ToString("000000");//
                    //                }
                    //                else
                    //                {
                    //                    cmd.Parameters.Add("donume", OleDbType.Char).Value = (item[1].ToString().Trim() == "" ? "" :
                    //                    item[1].ToString());//
                    //                }

                    //                cmd.Parameters.Add("dofech", OleDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                    //                    DateTime(1900, 1, 1) :
                    //                    new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                    //                    Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                    //                    Convert.ToInt16(item[2].ToString().Substring(6, 2))));//
                    //                cmd.Parameters.Add("auxcod", OleDbType.Char).Value = "00000040";//
                    //                cmd.Parameters.Add("dorfcodi", OleDbType.Char).Value = "";//
                    //                cmd.Parameters.Add("dorffech", OleDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                    //                    DateTime(1900, 1, 1) :
                    //                    new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                    //                    Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                    //                    Convert.ToInt16(item[2].ToString().Substring(6, 2))));//
                    //                cmd.Parameters.Add("dorfnume", OleDbType.Char).Value = "";//
                    //                cmd.Parameters.Add("donoco", OleDbType.Char).Value = item[4].ToString();//
                    //                cmd.Parameters.Add("doglco", OleDbType.Char).Value = "";//
                    //                cmd.Parameters.Add("plcodi", OleDbType.Char).Value = item[6].ToString();//
                    //                cmd.Parameters.Add("dodeha", OleDbType.Char).Value = Convert.ToDecimal(item[7].ToString()) > 0 ? "D" :
                    //                    (Convert.ToDecimal(item[8].ToString()) > 0 ? "H" : "E");//
                    //                cmd.Parameters.Add("domovi", OleDbType.Decimal).Value =                     
                    //                Convert.ToDecimal(item[7].ToString()) > 0 ? Convert.ToDecimal(item[7].ToString()) :
                    //                    (Convert.ToDecimal(item[8].ToString()) > 0 ? Convert.ToDecimal(item[8].ToString()) : 0.00M);//
                    //                cmd.Parameters.Add("anulado", OleDbType.Char).Value = "";//
                    //                cmd.Parameters.Add("clase", OleDbType.Char).Value = "";//

                    //                string memoContent;

                    //                memoContent = item[9].ToString();//

                    //                cmd.Parameters.Add("Cammem", OleDbType.Char).Value = memoContent;//
                    //                cmd.Parameters.Add("fsis", OleDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                    //                    DateTime(1900, 1, 1) :
                    //                    new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                    //                    Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                    //                    Convert.ToInt16(item[2].ToString().Substring(6, 2))));//
                    //                cmd.Parameters.Add("user", OleDbType.Char).Value = VariablesMetodosEstaticos.varUsuario.Substring(0, VariablesMetodosEstaticos.varUsuario.Length>10 ? 10 : VariablesMetodosEstaticos.varUsuario.Length);//

                    //                cmd.ExecuteNonQuery();
                    //                index = index + 1;
                    //                backgroundWorker.ReportProgress(index * 100 / process, string.Format("Transfiriendo... {0}%", index));

                    //            }
                    //            else
                    //            {
                    //                e.Cancel = true;
                    //                break;
                    //            }
                    //        }

                    //        cmd.CommandText = "set null on";

                    //        cmd.ExecuteNonQuery();
                    //        cnd.Close();
                    //    }
                    //}
                    using (SqlConnection cnd = new SqlConnection(strConnDbf))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = cnd;
                            cnd.Open();

                            dtAltaDireccion = cn.TraerDataset("paDiario_Consulta", Convert.ToInt16(txtMes.Text),
                                Convert.ToInt16(txtAnio.Text));

                            if (dtAltaDireccion.Tables[0].Rows.Count <= 0)
                            {
                                DevComponents.DotNetBar.MessageBoxEx.Show("No hay Datos de Glosa, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                return;
                            }

                            cmd.CommandText = "DELETE FROM " + "DIARIO_DEPOSITO WHERE ANIO = "+ txtAnio.Text + " and " + "MES = "+ Convert.ToInt32(txtMes.Text).ToString("00") + " " + " ";
                            cmd.Parameters.Clear();

                            cmd.ExecuteNonQuery();

                            cmd.ExecuteNonQuery();

                            process = dtAltaDireccion.Tables[0].Rows.Count;
                            index = 0;

                            _inputparameter.Process = 1;
                            _inputparameter.Delay = 1;

                            foreach (DataRow item in dtAltaDireccion.Tables[0].Rows)
                            {
                                if (!backgroundWorker.CancellationPending)
                                {
                                    cmd.CommandText = "INSERT INTO " + "DIARIO_DEPOSITO" + " "
                                            + "(docodi,donume,dofech,auxcod,dorfcodi,dorffech,dorfnume,donoco,doglco," +
                                    "plcodi,dodeha,domovi,anulado,clase,cammem,fsis,[user],ANIO,MES)"
                                            + "VALUES (@docodi, @donume, @dofech, @auxcod, @dorfcodi, @dorffech, @dorfnume, @donoco, @doglco, @plcodi, @dodeha, @domovi, @anulado, @clase, @Cammem, @fsis, @user, @anio, @mes)";
                                    decimal tipo;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.Add("@docodi", SqlDbType.VarChar).Value = item[0].ToString();//
                                    if (decimal.TryParse(item[1].ToString().Trim(), out tipo))
                                    {
                                        cmd.Parameters.Add("@donume", SqlDbType.VarChar).Value = item[1].ToString().Trim() == "" ? "" :
                                        Convert.ToInt32(item[1].ToString()).ToString("000000");//
                                    }
                                    else
                                    {
                                        cmd.Parameters.Add("@donume", SqlDbType.VarChar).Value = (item[1].ToString().Trim() == "" ? "" :
                                        item[1].ToString());//
                                    }

                                    cmd.Parameters.Add("@dofech", SqlDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                                        DateTime(1900, 1, 1) :
                                        new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                                        Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                                        Convert.ToInt16(item[2].ToString().Substring(6, 2))));//
                                    cmd.Parameters.Add("@auxcod", SqlDbType.VarChar).Value = "00000040";//
                                    cmd.Parameters.Add("@dorfcodi", SqlDbType.VarChar).Value = "";//
                                    cmd.Parameters.Add("@dorffech", SqlDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                                        DateTime(1900, 1, 1) :
                                        new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                                        Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                                        Convert.ToInt16(item[2].ToString().Substring(6, 2))));//
                                    cmd.Parameters.Add("@dorfnume", SqlDbType.VarChar).Value = "";//
                                    cmd.Parameters.Add("@donoco", SqlDbType.VarChar).Value = item[4].ToString();//
                                    cmd.Parameters.Add("@doglco", SqlDbType.VarChar).Value = "";//
                                    cmd.Parameters.Add("@plcodi", SqlDbType.VarChar).Value = item[6].ToString();//
                                    cmd.Parameters.Add("@dodeha", SqlDbType.VarChar).Value = Convert.ToDecimal(item[7].ToString()) > 0 ? "D" :
                                        (Convert.ToDecimal(item[8].ToString()) > 0 ? "H" : "E");//
                                    cmd.Parameters.Add("@domovi", SqlDbType.Decimal).Value =
                                    Convert.ToDecimal(item[7].ToString()) > 0 ? Convert.ToDecimal(item[7].ToString()) :
                                        (Convert.ToDecimal(item[8].ToString()) > 0 ? Convert.ToDecimal(item[8].ToString()) : 0.00M);//
                                    cmd.Parameters.Add("@anulado", SqlDbType.VarChar).Value = "";//
                                    cmd.Parameters.Add("@clase", SqlDbType.VarChar).Value = "";//

                                    string memoContent;

                                    memoContent = item[9].ToString();//

                                    cmd.Parameters.Add("@Cammem", SqlDbType.VarChar).Value = memoContent;//
                                    cmd.Parameters.Add("@fsis", SqlDbType.Date).Value = (item[2].ToString().Trim() == string.Empty ? new
                                        DateTime(1900, 1, 1) :
                                        new DateTime(Convert.ToInt16(item[2].ToString().Substring(0, 4)),
                                        Convert.ToInt16(item[2].ToString().Substring(4, 2)),
                                        Convert.ToInt16(item[2].ToString().Substring(6, 2))));//
                                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = VariablesMetodosEstaticos.varUsuario.Substring(0, VariablesMetodosEstaticos.varUsuario.Length > 10 ? 10 : VariablesMetodosEstaticos.varUsuario.Length);//
                                    cmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = txtAnio.Text;
                                    cmd.Parameters.Add("@mes", SqlDbType.VarChar).Value = Convert.ToInt32(txtMes.Text).ToString("00");
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

                            cmd.ExecuteNonQuery();
                            cnd.Close();
                        }
                    }
                    //Create an instance of ExcelEngine
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        //Initialize Application
                        IApplication application = excelEngine.Excel;

                        //Set the default application version as Excel 2016
                        application.DefaultVersion = ExcelVersion.Excel2016;

                        //Create a new workbook
                        IWorkbook workbook = application.Workbooks.Create(1);
                        workbook.Application.DefaultFilePath = @"C:\tmp\";
                        //Access first worksheet from the workbook instance
                        IWorksheet worksheet = workbook.Worksheets[0];

                        //Exporting DataTable to worksheet
                        DataTable dataTable = GetDataTable();
                        worksheet.ImportDataTable(dataTable, true, 1, 1);
                        worksheet.UsedRange.AutofitColumns();
                        
                        //Save the workbook to disk in xlsx format
                        workbook.SaveAs("DIARIO.xlsx");
                    }
                }
                catch (Exception EX)

                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(EX.Message+ index, VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
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

        private DataTable GetDataTable()
        {
            //Create a DataTable with four columns
            DataTable table = new DataTable();

            table = cn.TraerDataset("USP_OBTIENE_DIARIO_DEPOSITO", Convert.ToInt32(txtMes.Text).ToString("00"),txtAnio.Text).Tables[0];

            return table;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCantidadProcesos.Text = _inputparameter.Process.ToString() + " de " + _inputparameter.Delay.ToString();
            progressbar.Value = e.ProgressPercentage;
            lblPorcentaje.Text = string.Format("Transfiriendo... {0}%", e.ProgressPercentage);
            progressbar.Update();
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
                DevComponents.DotNetBar.MessageBoxEx.Show("Información exportada correctamente es C:\tmp\"", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information);
            }
            btnAceptar.Enabled = true;
            lblCantidadProcesos.Visible = false;
        }
    }
}
