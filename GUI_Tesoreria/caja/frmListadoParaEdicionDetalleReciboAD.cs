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
using GUI_Tesoreria.caja.Reportes;

namespace GUI_Tesoreria.caja
{
    public partial class frmListadoParaEdicionDetalleReciboAD : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        public frmListadoParaEdicionDetalleReciboAD()
        {
            InitializeComponent();
        }

        public static frmListadoParaEdicionDetalleReciboAD Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListadoParaEdicionDetalleReciboAD();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private DataSet dsDatos;
        private int idCliente;
        private CNegocio cn = new CNegocio();
        private varGlobales varglo = new varGlobales();
        private static frmListadoParaEdicionDetalleReciboAD frmInstance = null;
        public Boolean autoziza = false;
        public int cajeroIngreso = 0;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                if (cboPrograma.SelectedIndex == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un programa.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPrograma.Focus();
                    return;
                }

                if (cboPrograma.SelectedValue.ToString() == "2")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No esta permitido listar los recibos de Canevaro.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPrograma.Focus();
                    return;
                }

                dsDatos = new DataSet();
                int estado = 0;

                if (RBTodos.Checked) estado = 2;
                if (RBActivos.Checked) estado = 1;
                if (RBAnulados.Checked) estado = 0;
                if (ChTodos.Checked) idCliente = 0;

                dsDatos = cn.TraerDataset("usp_s_tb_recibocabecera", 3, 0, 0, 0
                     , txtNrorecibo.Text.Trim() == string.Empty ? 0 : Convert.ToInt32(txtNrorecibo.Text.Trim())
                     , 0, 0, idCliente, TxtNombre.Text.Trim(), "", "",
                     Convert.ToDateTime(dtpFechaDesde.Value.ToShortDateString()), 0, 0, 0, ""
                     , cboPrograma.SelectedValue, estado, Convert.ToDateTime(dtpFechaHasta.Value.ToShortDateString()));

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
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEdicionDetalleReciboAD_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_programa").Tables[0];
                cboPrograma.DataSource = dt;
                cboPrograma.DisplayMember = "varProDescripcion";
                cboPrograma.ValueMember = "intProId";
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (cajeroIngreso == 0)
            {
                cajeroIngreso = VariablesMetodosEstaticos.idcajausuario;
            }

            CargarGrilla();
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

            dtsRecibo = cn.TraerDataset("usp_r_tb_recibocabecera", 2, dgvRecibos.Rows[dgvRecibos.CurrentRow.Index].Cells[1].Value, DateTime.Now, DateTime.Now, 0, 1);

            dtsTipoDoc = cn.TraerDataset("usp_obtener_tipo_documento", Convert.ToInt32(dtsRecibo.Tables[0].Rows[0][0]));

            tipoDocumento = Convert.ToInt32(dtsTipoDoc.Tables[0].Rows[0][0]);
            programaRecibo = Convert.ToInt32(cn.TraerDataset("obtener_programa_x_sucursal", Convert.ToInt32(dtsRecibo.Tables[0].Rows[0][10])).Tables[0].Rows[0][0]);


            NumLetra Letras = new NumLetra();

            if (dtsRecibo.Tables[0].Rows.Count > 0)
            {
                switch (tipoDocumento)
                {
                    case 1:
                        if (programaRecibo == 2)
                        {
                            rptReciboCajaCanevaro rptRecibo = new rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            caja.DocsElectronicos.rptBoletaCajaCementerio rptRecibo = new caja.DocsElectronicos.rptBoletaCajaCementerio();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                    case 2:
                        if (programaRecibo == 2)
                        {
                            rptReciboCajaCanevaro rptRecibo = new rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            rptFacturaCajaCementerio rptRecibo = new rptFacturaCajaCementerio();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                    case 3:
                        if (programaRecibo == 2)
                        {
                            rptReciboCajaCanevaro rptRecibo = new rptReciboCajaCanevaro();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@sucursal", VariablesMetodosEstaticos.varNombreSucursal);
                            rptRecibo.SetParameterValue("@total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 4)
                        {
                            rptReciboCajaCementerio rptRecibo = new rptReciboCajaCementerio();

                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@descripMonto", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                            //Reportes.rptPruebaImpreFactura rptRecibo = new Reportes.rptPruebaImpreFactura();
                            //rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            //winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        else if (programaRecibo == 1 || programaRecibo == 5 || programaRecibo == 6)
                        {
                            rptReciboCajaCentral rptRecibo = new rptReciboCajaCentral();
                            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
                            rptRecibo.SetParameterValue("@Total", Letras.Convertir(dtsRecibo.Tables[0].Rows[0]["PrecioVenta_reciboCabecera"].ToString(), true) + " " + cn.TraerDataset("usp_obtener_descripcion_moneda", 1).Tables[0].Rows[0][0].ToString());
                            winReport.crvReportes.ReportSource = rptRecibo;
                        }
                        break;
                }
            }
            else
            {
                winReport.crvReportes.ReportSource = new RP();
            }
            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarDetalle_Click(object sender, EventArgs e)
        {
            if (this.dgvRecibos.CurrentRow!= null)
            {
                int index = 0;
                index = dgvRecibos.CurrentRow.Index;

                if (dgvRecibos.Rows[index].Cells["Estado"].Value.ToString() == "EXTORNADO")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Los documentos extornados no se pueden editar", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmEdicionDetalleRecibo win = new frmEdicionDetalleRecibo();
                win._IdRecibo = Convert.ToInt32(dgvRecibos.Rows[index].Cells[0].Value);
                win._TipoNroRecibo = dgvRecibos.Rows[index].Cells[4].Value.ToString() + " - " + dgvRecibos.Rows[index].Cells[5].Value.ToString() + "-" +
                    dgvRecibos.Rows[index].Cells[6].Value.ToString();

                win._DatosDetalle = cn.EjecutarSqlDTS("select ReciboID,Id_ReciboDetalle, idRubro,intTaId,Item_ReciboDetalle," +
                    "Precio_ReciboDetalle,Cantidad_ReciboDetalle,Total_ReciboDetalle " +
                    " from tb_ReciboDetalle where ReciboID=" + Convert.ToInt32(dgvRecibos.Rows[index].Cells[0].Value) + "").Tables[0];
                win.ShowDialog();
            }
        }
    }
}
