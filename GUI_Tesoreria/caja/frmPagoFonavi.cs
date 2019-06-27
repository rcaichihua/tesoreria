using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja
{
    public partial class frmPagoFonavi : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public DataTable dtbFonavi;
        private CNegocio cn = new CNegocio();
        string cadena = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = \\sblmdgai\Tesoreria\Fonavi\DBFS\ ; Extended Properties = dBase IV; user ID=;Password=";
        //string cadena = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = \\192.168.1.192\Archivos_Maliciosos\teso\Fonavi\DBFS\ ; Extended Properties = dBase IV; user ID=;Password=";
        DataSet ds = new DataSet();
        DataTable dtTabla = new DataTable();

        public new Form ParentForm;
        private string cliOrbegoso;
        private string dirOrbegoso;
        private string lugOrbegoso;
        private DataTable tablaPagosFonavi;
        private DataTable dtRubros;

        public frmPagoFonavi()
        {
            InitializeComponent();
        }

        private void frmPagoFonavi_Load(object sender, EventArgs e)
        {
            dgvFonavi.DataSource = dtbFonavi;
            cliOrbegoso = "";
            dirOrbegoso = "";
            lugOrbegoso = "";
            txtCliente.Clear();
            txtSuministro.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSuministro_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);

            if (e.KeyChar == 13)
            {
                if (txtSuministro.Text.Trim() == string.Empty)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el suministro", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                filtroNombre();
                filtroCuenta();
            }

        }

        private void filtroNombre()
        {
            string consultaFactura = @"select nombre,direccion,lugar from clientes " +
            "where suministro=\"" + Convert.ToInt32(txtSuministro.Text).ToString("000000") + "\"";

            filtroGenericoConsulta(consultaFactura);
            cliOrbegoso = ds.Tables[0].Rows[0][0].ToString();
            txtCliente.Text = cliOrbegoso;
            dirOrbegoso = ds.Tables[0].Rows[0][1].ToString();
            lugOrbegoso = ds.Tables[0].Rows[0][2].ToString();
        }

        private void filtroCuenta()
        {
            string fechaFiltro = "#" + Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd") + "#";
            string consultaFactura = @"select factura,fechpago,cuota,importe,amortiza,interes,seguro,silat,morafona,moraconc " +
                ",comision,igv,total from factura where suministro=\"" + 
                Convert.ToInt32(txtSuministro.Text).ToString("000000") + "\" and fechpago = " + fechaFiltro;

            filtroGenericoConsulta(consultaFactura);
        }

        private void filtroGenericoConsulta(string query)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = cadena;
                con.Open();
                ds = new DataSet();
                dtTabla = new DataTable();

                //string fechaFiltro = "{^" + Convert.ToDateTime("29/04/2016").ToString("yyyy-MM-dd") + "}";           
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                adapter.Fill(ds);
                con.Close();
                dtTabla = ds.Tables[0];

                if (query.IndexOf(" from clientes ") == -1)
                {
                    dtTabla.Columns.Add("Marca", typeof(bool));

                    foreach (DataRow item in dtTabla.Rows)
                    {
                        item["Marca"] = false;
                    }
                }

                dgvFonavi.DataSource = dtTabla;//ds.Tables[0];
                if (ds.Tables[0].Rows.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No se verifica cobros con fecha de hoy " + DateTime.Now.ToShortDateString() + ", verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool marca = false;

            if (dgvFonavi.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvFonavi.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[13].Value) == true)
                    {
                         marca = true;
                    }
                }
                if (!marca) return;

                crearPagosDatatable();
                dgvCopiaOriginal.DataSource = tablaPagosFonavi;
                var frm = (frmPagoDiversos)this.ParentForm;
                frm.direccionClienteOrbegoso = dirOrbegoso + " / " + lugOrbegoso;
                frm.nombreClienteOrbegoso = cliOrbegoso;
                frm.flagFonavi = true;
                CopyDataGridView(dgvCopiaOriginal, frm.DGVRubros);
                this.Close();
            }
        }

        private /*DataGridView*/ void CopyDataGridView(DataGridView dgv_org,DataGridView dgvDestino)
        {
            //DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgvDestino.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgvDestino.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgvDestino.Rows.Add(row);
                }
                dgvDestino.AllowUserToAddRows = false;
                dgvDestino.Refresh();

            }
            catch (Exception)
            {
                //cf.ShowExceptionErrorMsg("Copy DataGridViw", ex);
            }
            //return dgvDestino;
        }

        private void crearPagosDatatable()
        {
            tablaPagosFonavi = new DataTable();
            dtRubros = new DataTable();
            dtRubros = cn.EjecutarSqlDTS("select chaRuCodigo as codigo,varRuDescripcion as descrip,id_cuenta_contable as cuenta from rubro where chaRuCodigo in ('1159','1160','1161','4462','1162')").Tables[0];
            tablaPagosFonavi.Clear();

            tablaPagosFonavi.Columns.Add("id_cuenta_contable", typeof(int));
            tablaPagosFonavi.Columns.Add("idTarifa", typeof(int));
            tablaPagosFonavi.Columns.Add("CodigoRubro", typeof(string));
            tablaPagosFonavi.Columns.Add("Descripcion", typeof(string));
            tablaPagosFonavi.Columns.Add("Precio", typeof(string));
            tablaPagosFonavi.Columns.Add("Dscto", typeof(string));
            tablaPagosFonavi.Columns.Add("Igv", typeof(decimal));
            tablaPagosFonavi.Columns.Add("Cantidad", typeof(int));//
            tablaPagosFonavi.Columns.Add("Importe", typeof(decimal));//
            tablaPagosFonavi.Columns.Add("varCeNombre", typeof(string));//

            if (dgvFonavi.Rows.Count > 0)
            {
                //se insertan 5 registro por cada registro del pago en fonavi
                string factura = "";
                DateTime fechaPago;
                string cuota;
                decimal importe = 0.00M;
                decimal amortiza = 0.00M;
                decimal interes = 0.00M;
                decimal seguro = 0.00M;
                decimal silat = 0.00M;
                decimal morafona = 0.00M;
                decimal moraconc = 0.00M;
                decimal comision = 0.00M;
                decimal igv = 0.00M;
                decimal total = 0.00M;
                decimal otrosIngresos = 0.00M;
                decimal montoTemporal = 0.00M;
                bool flag = false;

                foreach (DataGridViewRow row in dgvFonavi.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[13].Value)==true)
                    {
                        factura = row.Cells[0].Value.ToString();
                        fechaPago = Convert.ToDateTime(row.Cells[1].Value);
                        cuota = row.Cells[2].Value.ToString();
                        importe = Convert.ToDecimal(row.Cells[3].Value);
                        amortiza = Convert.ToDecimal(row.Cells[4].Value);
                        interes = Convert.ToDecimal(row.Cells[5].Value);
                        seguro = Convert.ToDecimal(row.Cells[6].Value); //1159
                        silat = Convert.ToDecimal(row.Cells[7].Value);
                        morafona = Convert.ToDecimal(row.Cells[8].Value);
                        moraconc = Convert.ToDecimal(row.Cells[9].Value); //1160
                        comision = Convert.ToDecimal(row.Cells[10].Value); //1161
                        igv = Convert.ToDecimal(row.Cells[11].Value); //4462
                        total = Convert.ToDecimal(row.Cells[12].Value);
                        otrosIngresos = amortiza + interes + silat + morafona; //1162

                        foreach (DataRow dtRow in dtRubros.Rows)
                        {
                            if (dtRow.ItemArray[0].ToString() == "1159")
                            {
                                if (seguro != 0.00M)
                                {
                                    flag = true;
                                    montoTemporal = seguro;
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                            else if (dtRow.ItemArray[0].ToString() == "1160")
                            {
                                montoTemporal = moraconc;
                                flag = true;
                            }
                            else if (dtRow.ItemArray[0].ToString() == "1161")
                            {
                                montoTemporal = comision;
                                flag = true;
                            }
                            else if (dtRow.ItemArray[0].ToString() == "4462")
                            {
                                montoTemporal = igv;
                                flag = true;
                            }
                            else if (dtRow.ItemArray[0].ToString() == "1162")
                            {
                                montoTemporal = otrosIngresos;
                                flag = true;
                            }

                            if (flag == true)
                            {
                                DataRow _filaDetalle = tablaPagosFonavi.NewRow();

                                _filaDetalle["id_Cuenta_Contable"] = dtRow.ItemArray[2];//dtRubros.Select("codigo = 1159")[0][2].ToString();
                                _filaDetalle["idTarifa"] = DBNull.Value;
                                _filaDetalle["CodigoRubro"] = dtRow.ItemArray[0];
                                _filaDetalle["Descripcion"] = dtRow.ItemArray[1].ToString().Trim() + " - CORRESPONDE A " +
                                    factura.Substring(4, 2) + "/" + factura.Substring(0, 4);
                                _filaDetalle["Precio"] = montoTemporal;
                                _filaDetalle["Dscto"] = 0.00M;
                                _filaDetalle["Igv"] = 0.00M;
                                _filaDetalle["Cantidad"] = 1;
                                _filaDetalle["Importe"] = montoTemporal;
                                _filaDetalle["varCeNombre"] = DBNull.Value;

                                tablaPagosFonavi.Rows.Add(_filaDetalle);
                            }
                            flag = false;
                        }
                    }                  
                }
            }
        }
    }
}
