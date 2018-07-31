using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using DAO_Tesoreria;
using System.Security.Principal;

namespace GUI_Tesoreria.caja
{
    public partial class FrmAperturaCierreCaja : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cn = new CNegocio();
        private int IntApertura;
        private varGlobales varglo = new varGlobales();
        private static FrmAperturaCierreCaja frmInstance = null;
        public string IntOpcion="";
        private int IntCerrado = 0;
        private int IntCancelados = 0;
        private int IntExtornados=0;

        public FrmAperturaCierreCaja()
        {
            InitializeComponent();
        }

        private string m_CurUser;

        public string CurrentUser
        {
            get
            {
                if(string.IsNullOrEmpty(m_CurUser))
                {
                    var who = System.Security.Principal.WindowsIdentity.GetCurrent();
                    if (who == null)
                        m_CurUser = System.Environment.UserDomainName + @"\" + System.Environment.UserName;
                    else
                        m_CurUser = who.Name;
                }
                return m_CurUser;
            }
        }

        public static FrmAperturaCierreCaja Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FrmAperturaCierreCaja();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void FrmAperturaCierreCaja_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            DataSet dtsLoadCaja;

            DataTable dt = new DataTable();
            dt = cn.TraerDataset("usp_obtener_hora_fecha_servidor").Tables[0];
          
            txtCajero.Text = VariablesMetodosEstaticos.varNombreUser;
            txtFecha.Text = dt.Rows[0][0].ToString();
            txtHora.Text = dt.Rows[0][1].ToString();

            if (VariablesMetodosEstaticos.mac_id == 0) { btnGuardar.Enabled = false; return; }

            IntApertura = Convert.ToInt32(cn.TraerDataset("usp_s_tb_aperturacierrecaja",
                                                                        1,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        VariablesMetodosEstaticos.idcajausuario,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        Convert.ToDateTime(txtFecha.Text),
                                                                        //System.Data.SqlTypes.SqlDateTime.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        System.Data.SqlTypes.SqlDateTime.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlInt32.Null,
                                                                        System.Data.SqlTypes.SqlString.Null,
                                                                        1).Tables[0].Rows[0][0].ToString());
            if (IntApertura == 0) {
                dtsLoadCaja = new DataSet();

                dtsLoadCaja = cn.TraerDataset("usp_s_tb_caja_usuario", 1, 0, 0, VariablesMetodosEstaticos.id_user, 0, 0, 0, 1,VariablesMetodosEstaticos.mac_id);

                if (dtsLoadCaja.Tables[0].Rows.Count > 0)
                {
                    txtVoucher.Text = dtsLoadCaja.Tables[0].Rows[0]["VaucherApertura"].ToString();
                    VariablesMetodosEstaticos.idcajausuario = Convert.ToInt32(dtsLoadCaja.Tables[0].Rows[0]["id_caja_usuario"].ToString());
                    VariablesMetodosEstaticos.idcaja = Convert.ToInt32(dtsLoadCaja.Tables[0].Rows[0]["id_caja"].ToString());

                    //Elimina columnas innecesarias
                    while (dtsLoadCaja.Tables[0].Columns.Count > 4)
                    {
                        int i = 0;
                        dtsLoadCaja.Tables[0].Columns.RemoveAt(i);
                        i++;
                    }

                    dgvAperturaCaja.DataSource = dtsLoadCaja.Tables[0];
                }
                else
                {
                    MessageBox.Show("No puede aperturar caja debido a que su usuario no tiene asignado una caja",
                  VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                
                txtMontInicial.ReadOnly = false;
                btnGuardar.Enabled = true;
                txtMontInicial.Focus();
            }
            else {
                if (IntOpcion == "Apertura de Caja") {
                    dtsLoadCaja = new DataSet();
                    dtsLoadCaja = cn.TraerDataset("usp_s_tb_aperturacierrecaja", 2,
                                                                             0,
                                                                             VariablesMetodosEstaticos.idcajausuario,
                                                                             System.Data.SqlTypes.SqlString.Null,
                                                                             //davy 26/01/2017
                                                                             Convert.ToDateTime(txtFecha.Text),
                                                                             //System.Data.SqlTypes.SqlDateTime.Null,
                                                                             System.Data.SqlTypes.SqlString.Null,
                                                                             System.Data.SqlTypes.SqlInt32.Null,
                                                                             System.Data.SqlTypes.SqlString.Null,
                                                                             System.Data.SqlTypes.SqlDateTime.Null,
                                                                             System.Data.SqlTypes.SqlString.Null,
                                                                             System.Data.SqlTypes.SqlInt32.Null,
                                                                             System.Data.SqlTypes.SqlInt32.Null,
                                                                             System.Data.SqlTypes.SqlInt32.Null,
                                                                             System.Data.SqlTypes.SqlString.Null,
                                                                             1);

                    //Se muestra información de tb_detalleAperturaCierreCaja de los primeros numeros de serie y correlativo con que se abre la caja del dia.
                    dgvAperturaCaja.DataSource = cn.TraerDataset("usp_s_tb_detalleAperturaCierreCaja", Convert.ToInt32(dtsLoadCaja.Tables[0].Rows[0]["Id"])).Tables[0];

                    txtFecha.Text = Convert.ToDateTime(dtsLoadCaja.Tables[0].Rows[0]["FechaApertura"]).ToString("dd/M/yyyy");
                    txtHora.Text = dtsLoadCaja.Tables[0].Rows[0]["HoraApertura"].ToString();
                    txtVoucher.Text = dtsLoadCaja.Tables[0].Rows[0]["VaucherApertura"].ToString();
                    txtMontInicial.Text = dtsLoadCaja.Tables[0].Rows[0]["ImporteApertura"].ToString();
                    txtMontInicial.ReadOnly = true;
                    btnGuardar.Enabled = false;
                    btnSalir.Focus();
                }
                else{
                    this.Text = "Cierre de Caja !!!";
                    LblTitulo.Text = "::::   CIERRE DE CAJA   ::::";
                    Label3.Text = "Monto Final";
                    IntCerrado = Convert.ToInt32(cn.TraerDataset("usp_s_tb_aperturacierrecaja",
                                                                         3,
                                                                         System.Data.SqlTypes.SqlInt32.Null,
                                                                         VariablesMetodosEstaticos.idcajausuario,
                                                                         System.Data.SqlTypes.SqlString.Null,
                                                                         Convert.ToDateTime(txtFecha.Text),
                                                                         //System.Data.SqlTypes.SqlDateTime.Null,
                                                                         System.Data.SqlTypes.SqlString.Null,
                                                                         System.Data.SqlTypes.SqlInt32.Null,
                                                                         System.Data.SqlTypes.SqlString.Null,
                                                                         System.Data.SqlTypes.SqlDateTime.Null,
                                                                         System.Data.SqlTypes.SqlString.Null,
                                                                         System.Data.SqlTypes.SqlInt32.Null,
                                                                         System.Data.SqlTypes.SqlInt32.Null,
                                                                         System.Data.SqlTypes.SqlInt32.Null,
                                                                         "Cerrado",1).Tables[0].Rows[0][0].ToString());
                    dtsLoadCaja = new DataSet();
                    dtsLoadCaja = cn.TraerDataset("usp_obtiene_cierreCaja", VariablesMetodosEstaticos.idcajausuario,Convert.ToDateTime(txtFecha.Text));

                    DataTable CorrelativoRecibos = new DataTable();
                    CorrelativoRecibos = cn.TraerDataset("usp_s_ultimo_doc_venta", VariablesMetodosEstaticos.mac_id).Tables[0];

                    dgvAperturaCaja.DataSource = CorrelativoRecibos;

                    txtMontInicial.ReadOnly = true;
                    if (dtsLoadCaja.Tables[0].Rows.Count > 0)
                    {
                        //txtVoucher.Text = dtsLoadCaja.Tables[0].Rows[0]["VaucherCierre"].ToString();
                        txtMontInicial.Text = dtsLoadCaja.Tables[0].Rows[0]["ImporteCierre"].ToString();
                        IntCancelados = Convert.ToInt32(dtsLoadCaja.Tables[0].Rows[0]["CantidadEstados"].ToString());
                    }
                    else {
                        dtsLoadCaja = new DataSet();
                        dtsLoadCaja = cn.TraerDataset("usp_s_tb_aperturacierrecaja", 2,
                                                                    0,
                                                                    VariablesMetodosEstaticos.idcajausuario,
                                                                    System.Data.SqlTypes.SqlString.Null,
                                                                    Convert.ToDateTime(txtFecha.Text),
                                                                    //System.Data.SqlTypes.SqlDateTime.Null,
                                                                    System.Data.SqlTypes.SqlString.Null,
                                                                    System.Data.SqlTypes.SqlInt32.Null,
                                                                    System.Data.SqlTypes.SqlString.Null,
                                                                    System.Data.SqlTypes.SqlDateTime.Null,
                                                                    System.Data.SqlTypes.SqlString.Null,
                                                                    System.Data.SqlTypes.SqlInt32.Null,
                                                                    System.Data.SqlTypes.SqlInt32.Null,
                                                                    System.Data.SqlTypes.SqlInt32.Null,
                                                                    System.Data.SqlTypes.SqlString.Null,1);

                        dgvAperturaCaja.DataSource = cn.TraerDataset("usp_s_tb_detalleAperturaCierreCaja", Convert.ToInt32(dtsLoadCaja.Tables[0].Rows[0]["Id"])).Tables[0];
                        txtVoucher.Text = dtsLoadCaja.Tables[0].Rows[0]["VaucherApertura"].ToString();
                        txtMontInicial.Text = dtsLoadCaja.Tables[0].Rows[0]["ImporteApertura"].ToString();
                    }

                    if (dtsLoadCaja.Tables[0].Rows.Count > 1)
                    {
                        IntExtornados = Convert.ToInt32(dtsLoadCaja.Tables[0].Rows[1]["CantidadEstados"]);
                    }
                    if (IntCerrado == 0) {
                        btnGuardar.Enabled = true;
                        btnGuardar.Focus();
                    }
                    else {
                        btnGuardar.Enabled = false;
                        btnSalir.Focus();
                    }
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int intresultado;
            string resultadoCierre;
            try
            {
                if (IntApertura == 0)
                {
                    DataTable data = new DataTable();
                    intresultado = 0;

                    if (txtMontInicial.Text.Trim() == string.Empty)
                    {
                        txtMontInicial.Text = "0";
                    }

                    intresultado = Convert.ToInt32(cn.TraerDataset("usp_m_tb_aperturacierrecaja", "I",
                                                            0,
                                                            VariablesMetodosEstaticos.idcajausuario,
                                                            txtVoucher.Text,
                                                            Convert.ToDateTime(txtFecha.Text),
                                                            //System.Data.SqlTypes.SqlDateTime.Null,
                                                            System.Data.SqlTypes.SqlString.Null,
                                                            Convert.ToDecimal(txtMontInicial.Text),
                                                            System.Data.SqlTypes.SqlString.Null,
                                                            System.Data.SqlTypes.SqlDateTime.Null,
                                                            System.Data.SqlTypes.SqlString.Null,
                                                            System.Data.SqlTypes.SqlInt32.Null,
                                                            System.Data.SqlTypes.SqlInt32.Null,
                                                            System.Data.SqlTypes.SqlInt32.Null,
                                                            "Aperturado", 1,
                                                            VariablesMetodosEstaticos.host_user,
                                                            CurrentUser,
                                                            VariablesMetodosEstaticos.ip_user,
                                                            DateTime.Now,
                                                            "HoraToshort",DateTime.Now).Tables[0].Rows[0][0]);

                    if (intresultado > 0)
                    {
                        DataTable dtDetalle = (DataTable)(dgvAperturaCaja.DataSource);

                        //devuelve el nro de registros ingresado (aroja 3 fila por ser tres tipos de doc FA - BV - RC)
                        intresultado = cn.IngresaAperturaCierreCaja("usp_i_tb_aperturacierrecaja_detalle", intresultado, dtDetalle);

                        if (intresultado == dtDetalle.Rows.Count)
                        {
                            MessageBox.Show("Apertura de Caja Realizado", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Apertura no Registrada, contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                      else if ( intresultado == 0)
                    {
                        MessageBox.Show("Error en la apertura, contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else if (intresultado == -1)
                    {
                        MessageBox.Show("Esta intentado cerrar una fecha que no conincide con la fecha de su ventana de cierre. Este intento sera registrado.", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    } 
                }
                else
                {
                    if ((MessageBox.Show("¿Desea Realizar el Cierre de Caja?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        DataSet dts = new DataSet();

                        resultadoCierre = cn.TraerDataset("usp_m_tb_aperturacierrecaja", "U",
                                                          0,
                                                          VariablesMetodosEstaticos.idcajausuario,
                                                          "",
                                                          Convert.ToDateTime(txtFecha.Text),
                                                          "",
                                                          0,
                                                          txtVoucher.Text,
                                                          Convert.ToDateTime(txtFecha.Text),
                                                          txtHora.Text,
                                                          Convert.ToDecimal(txtMontInicial.Text),
                                                          IntCancelados,
                                                          IntExtornados,
                                                          "Cerrado",
                                                          1,
                                                          VariablesMetodosEstaticos.host_user,
                                                          CurrentUser,
                                                          VariablesMetodosEstaticos.ip_user,
                                                          DateTime.Now,
                                                            "Hora",DateTime.Now).Tables[0].Rows[0][0].ToString();

                        if (Convert.ToInt32(resultadoCierre) == -1)
                        {
                            MessageBox.Show("Esta intentado cerrar una fecha que no conincide con la fecha de su ventana de cierre. Este intento sera registrado.", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        } 
                        else if (Convert.ToInt32(resultadoCierre) == -2)
                        {
                            MessageBox.Show("Caja cerrado con exito.", VariablesMetodosEstaticos.encabezado,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        else if (Convert.ToInt32(resultadoCierre) == 0)
                        {
                            MessageBox.Show("Error en la apertura, contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            return;
                        }

                        //dts = cn.TraerDataset("usp_r_tb_aperturacierrecaja",
                        //                 1, VariablesMetodosEstaticos.idcajausuario);

                        //if (dts.Tables[0].Rows.Count == 0)
                        //{
                        //    MessageBox.Show("No se ha realizado ningun movimiento.", VariablesMetodosEstaticos.encabezado,
                        //     MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        //}
                        //else
                        //{
                        //    // Dim rpt As New REPORTECAJA4
                        //    //dts.WriteXmlSchema(RUTA_XML & "REPORTECAJA4.xsd")
                        //    //rpt.Database.Tables(0).SetDataSource(dts.Tables(0))
                        //    //FrmReporteCaja4.CRVDiario.ReportSource = rpt
                        //    //FrmReporteCaja4.Text = "Reporte General de Rubros"
                        //    //FrmReporteCaja4.WindowState = FormWindowState.Maximized
                        //    //FrmReporteCaja4.Show()
                        //    //Me.Close()
                        //}                  
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtMontInicial_KeyPress(object sender, KeyPressEventArgs e)
    {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }
    }
}
