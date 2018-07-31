using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using DescripcionMonto;

namespace GUI_Tesoreria.caja
{
    public partial class frmConsultaRecibos : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private DataSet dsDatos;
        private int idCliente;
        private CNegocio cn = new CNegocio();
        private varGlobales varglo = new varGlobales();
        private static frmConsultaRecibos frmInstance = null;
        public Boolean autoziza = false;
        public int cajeroIngreso = 0;

        public frmConsultaRecibos()
        {
            InitializeComponent();
        }

        public static frmConsultaRecibos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmConsultaRecibos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmConsultaRecibos_Load(object sender, EventArgs e)
        {
            if (cajeroIngreso == 0)
            {
                cajeroIngreso = VariablesMetodosEstaticos.idcajausuario;
                BtnVer.Enabled = false;
            }
            else
            {
                BtnEliminar.Enabled = false;
                BtnVer.Enabled = false;
            }
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            try 
	        {	        
		        dsDatos = new DataSet();
                    int estado = 0;

                    if (RBTodos.Checked) estado = 2;
                    if (RBActivos.Checked) estado = 1;
                    if (RBAnulados.Checked) estado = 0;
                    if (ChTodos.Checked) idCliente = 0;

                    dsDatos = cn.TraerDataset("usp_s_tb_recibocabecera", 2, 0, 0, 0
                        , txtNrorecibo.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtNrorecibo.Text.Trim())
                        , 0, 0, idCliente, TxtNombre.Text.Trim(), "", "",
                        Convert.ToDateTime(dtpFechaDesde.Value.ToShortDateString()), 0, 0, 0, ""
                        , cajeroIngreso, estado, Convert.ToDateTime(dtpFechaHasta.Value.ToShortDateString()));

                    dgvRecibos.DataSource = dsDatos.Tables[0];

                    decimal subTotal = 0.00m;
                    decimal igv = 0.00m;
                    decimal total = 0.00m;
                    
                    foreach (DataGridViewRow row in dgvRecibos.Rows)
	                {
                        if (row.Cells["Estado"].Value.ToString() == "ACTIVO")
                        {
                            subTotal = subTotal + Convert.ToDecimal(row.Cells["subTotal"].Value);
                            igv = igv + Convert.ToDecimal(row.Cells["Igv"].Value);
                            total = total + Convert.ToDecimal(row.Cells["Total"].Value);
                        }
	                }

                    txtSubTotal.Text = subTotal.ToString("##,##0.00");
                    txtIgv.Text = igv.ToString("##,##0.00");
                    txtTotal.Text = total.ToString("##,##0.00");

                    lblNroRecibos.Text = dsDatos.Tables[0].Rows.Count.ToString();

	        }
	        catch (Exception)
	        {

	        }
        }

        private void marcarGrilla()
        {
            if (dgvRecibos.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvRecibos.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "EXTORNADO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral; 
                    }
                }
            }
        }

        private void RBTodos_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void LimpiarGrilla()
        {
            try
            {
                if (dgvRecibos.RowCount > 0)
                {
                    for (int i = 0; i < dgvRecibos.RowCount - 1; i++)
                    {
                        dgvRecibos.Rows.RemoveAt(dgvRecibos.CurrentRow.Index);
                    }
                }
                txtNrorecibo.Clear();
                TxtCodigoContribuyente.Clear();
                TxtNombre.Clear();
                idCliente = 0;
            }
            catch (Exception)
            {
            }          
        }

        private void RBActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void BtnBuscarContribuyente_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void RBAnulados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void ChTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarGrilla();
                if (ChTodos.Checked)
                {
                    ChTodos.Text = "DesMarcar Todos";
                    CargarGrilla();
                }
                else
                {
                    ChTodos.Text = "Mostrar Todos";
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            int tipoDocumento;
            DataSet dtsRecibo = new DataSet();
            DataSet dtsTipoDoc = new DataSet();
            frmImpresionRecibos winReport = new frmImpresionRecibos();
            int programaRecibo = 0;

            if (dgvRecibos.RowCount <= 0)
            {
                return;
            }

            dtsRecibo = cn.TraerDataset("usp_r_tb_recibocabecera", 2, dgvRecibos.Rows[dgvRecibos.CurrentRow.Index].Cells[1].Value, DateTime.Now, DateTime.Now,0,1);

            dtsTipoDoc = cn.TraerDataset("usp_obtener_tipo_documento", Convert.ToInt32(dtsRecibo.Tables[0].Rows[0][0]));

            tipoDocumento = Convert.ToInt32(dtsTipoDoc.Tables[0].Rows[0][0]);
            programaRecibo =Convert.ToInt32(cn.TraerDataset("obtener_programa_x_sucursal", Convert.ToInt32(dtsRecibo.Tables[0].Rows[0][10])).Tables[0].Rows[0][0]);


            NumLetra Letras = new NumLetra();

            if (dtsRecibo.Tables[0].Rows.Count > 0)
            {
                switch (tipoDocumento)
                {
                    case 1:
                       if (programaRecibo == 2)
                        {
                            Reportes.rptReciboCajaCanevaro rptRecibo = new Reportes.rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            DocsElectronicos.rptBoletaCajaCementerio rptRecibo = new DocsElectronicos.rptBoletaCajaCementerio();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;                           
                        }
                        break;
                    case 2:
                       if (programaRecibo == 2)
                        {
                            Reportes.rptReciboCajaCanevaro rptRecibo = new Reportes.rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            DocsElectronicos.rptFacturaCajaCementerio rptRecibo = new DocsElectronicos.rptFacturaCajaCementerio();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                    case 3:
                        if (programaRecibo == 2)
                        {
                            Reportes.rptReciboCajaCanevaro rptRecibo = new Reportes.rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            Reportes.rptReciboCajaCementerio rptRecibo = new Reportes.rptReciboCajaCementerio();

                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                            //Reportes.rptPruebaImpreFactura rptRecibo = new Reportes.rptPruebaImpreFactura();
                            //rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            //winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 1 || programaRecibo == 5 || programaRecibo ==6 )
                        {
                            Reportes.rptReciboCajaCentral rptRecibo = new Reportes.rptReciboCajaCentral();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@Total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                }
            }
            else
            {
                winReport.crvReportes.ReportSource = new Reportes.RP();
            }
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecibos.RowCount > 0)
                {
                    frmExtornarRecibo winExt = new frmExtornarRecibo();
                    int index = 0;
                    index = dgvRecibos.CurrentRow.Index;

                    DataSet dtsExterno = new DataSet();

                    dtsExterno = cn.TraerDataset("usp_s_tb_aperturacierrecaja",
                                                                            2,
                                                                            System.Data.SqlTypes.SqlInt32.Null,
                                                                            cajeroIngreso,
                                                                            System.Data.SqlTypes.SqlString.Null,
                                                                            dgvRecibos.Rows[index].Cells["Fecha"].Value,
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

                    if (dtsExterno.Tables[0].Rows[0]["Observacion"].ToString() != "Aperturado")
                    {
                        MessageBox.Show("La caja ya fue cerrada ... Usted No Puede Extornar.", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    if (dgvRecibos.Rows[index].Cells["Estado"].Value.ToString() == "EXTORNADO")
                    {
                        MessageBox.Show("El documento ya se encuentra Extornado", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; 
                    }
                    else if (dgvRecibos.Rows[index].Cells["Estado"].Value.ToString() == "ACTIVO")
                    {
                        int fechaActual = 0;
                        fechaActual = Convert.ToInt32(cn.TraerDataset("usp_verifica_fechaActual_reciboCabecera"
                            , Convert.ToInt32(dgvRecibos.Rows[index].Cells["id_reciboCabecera"].Value)).Tables[0].Rows[0][0]);

                        if (fechaActual == 0)
                        {
                            MessageBox.Show("No se puede extornar un recibo que no se haya girado el dia de hoy."
                                , VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }

                        frmAutorizaExtorno winAutoriza = new frmAutorizaExtorno();
                        winAutoriza.ParentForm = this;
                        winAutoriza.ShowDialog();
                        if (autoziza == true)
                        {
                            winExt.id_reciboCabecera = Convert.ToInt32(dgvRecibos.Rows[index].Cells["id_reciboCabecera"].Value);
                            winExt.totalExtorno = Convert.ToDecimal(dgvRecibos.Rows[index].Cells["total"].Value);
                            winExt.nombreClienteExtorno = dgvRecibos.Rows[index].Cells["NombreCompleto_Cliente"].Value.ToString();
                            winExt.serieExtorno = dgvRecibos.Rows[index].Cells["SerieRecibo"].Value.ToString();
                            winExt.numeroExtorno = dgvRecibos.Rows[index].Cells["numero_recibo"].Value.ToString();
                            winExt.ShowDialog();
                            CargarGrilla();
                        }
                        autoziza = false;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            frmDetalleRecibo winDetalle = new frmDetalleRecibo();
            winDetalle.ShowDialog();
        }

        private void dgvRecibos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcarGrilla();
        }
    }
}
