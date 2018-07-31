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
    public partial class frmRecibosIngreso : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmRecibosIngreso frmInstance = null;
        CNegocio cn = new CNegocio();
        int index = 0;

        public frmRecibosIngreso()
        {
            InitializeComponent();
        }
        private string m_CurUser;

        public string CurrentUser
        {
            get
            {
                if (string.IsNullOrEmpty(m_CurUser))
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

        public static frmRecibosIngreso Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmRecibosIngreso();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmRecibosIngreso_Load(object sender, EventArgs e)
        {
            dgvRecibos.Refresh();
            buscar();
            cargarPrograma();
            dgvRecibosGeneral.Visible = false;
        }

        private void cargarPrograma()
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
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void buscar()
        {
            busquedaRecibos(dtpDesde.Value, dtpHasta.Value, true);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void busquedaRecibos(DateTime fechaDesde, DateTime fechaHasta, bool grupo)
        {
            DataSet dsDatos = new DataSet();

            dsDatos = cn.TraerDataset("usp_busqueda_aperturas_caja",
                fechaDesde, fechaHasta, cboPrograma.Text == "[seleccione]" ? "" : cboPrograma.Text, grupo);

            dgvRecibos.DataSource = dsDatos.Tables[0];

            decimal debe = 0.00m;
            decimal haber = 0.00m;
            int countRow = 0;

            foreach (DataGridViewRow row in dgvRecibos.Rows)
            {
                if (row.Cells["Observacion_AperturaCierreCaja"].Value.ToString() == "Cerrado")
                   {
                        debe = debe + Convert.ToDecimal(row.Cells["Total_Debe"].Value.ToString() == "" ? 0.00 : row.Cells["Total_Debe"].Value);
                        haber = haber + Convert.ToDecimal(row.Cells["Total_Haber"].Value.ToString() == "" ? 0.00 : row.Cells["Total_Haber"].Value);
                        countRow = countRow + 1;
                        lblNroRecibos.Text = countRow.ToString();//dsDatos.Tables[0].Rows.Count.ToString();
                   }
            }
            if (countRow == 0)
            {
                lblNroRecibos.Text = countRow.ToString();
            }
            txtDebe.Text = debe.ToString("##,##0.00");
            txtHaber.Text = haber.ToString("##,##0.00");

            
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            int indiceRecibo = 0;
            validacionRecibosIngresos();

            DataSet dtsRecibo = new DataSet();
            frmReporte winReport = new frmReporte();

            if (dgvRecibos.RowCount <= 0)
            {
                return;
            }
            indiceRecibo = dgvRecibos.CurrentRow.Index;
            dtsRecibo = cn.TraerDataset("usp_genera_recibo_ingreso_contable", Convert.ToInt32(dgvRecibos.Rows[indiceRecibo].Cells[1].Value));

            if (dgvRecibos.RowCount==0)
            {
                MessageBox.Show("Error inesperado, contacte con sistemas..", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Reportes.rptRecibosIngreso rptRecibo = new Reportes.rptRecibosIngreso();
            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
            winReport.crvReportes.ReportSource = rptRecibo;

            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListadoContable_Click(object sender, EventArgs e)
        {
            if (chkPorCajero.Checked)
            {
                validacionRecibosIngresos();

                DataSet dtsListadoContable = new DataSet();
                frmReporte winReport = new frmReporte();

                if (dgvRecibos.RowCount <= 0)
                {
                    return;
                }

                dtsListadoContable = cn.TraerDataset("usp_genera_listado_contable", dgvRecibos.Rows[dgvRecibos.CurrentRow.Index].Cells[1].Value);

                if (dgvRecibos.RowCount == 0)
                {
                    MessageBox.Show("Error inesperado, contacte con sistemas..", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                Reportes.rptListadoContable rptRecibo = new Reportes.rptListadoContable();
                rptRecibo.SetDataSource(dtsListadoContable.Tables[0]);
                winReport.crvReportes.ReportSource = rptRecibo;

                winReport.WindowState = FormWindowState.Maximized;
                winReport.ShowDialog();
            }

            else
            {
                if (dgvRecibosGeneral.Rows.Count <= 0)
                {
                    return;
                }
                DataSet dtsListadoContable = new DataSet();
                frmReporte winReport = new frmReporte();

                dtsListadoContable = cn.TraerDataset("usp_genera_listado_contable", dgvRecibosGeneral.Rows[dgvRecibosGeneral.CurrentRow.Index].Cells[1].Value);

                if (dtsListadoContable.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Reportes.rptListadoContable rptRecibo = new Reportes.rptListadoContable();
                rptRecibo.SetDataSource(dtsListadoContable.Tables[0]);
                winReport.crvReportes.ReportSource = rptRecibo;

                winReport.WindowState = FormWindowState.Maximized;
                winReport.ShowDialog();
            }

        }

        private void validacionRecibosIngresos()
        {
            if (dgvRecibos.RowCount == 0)
            {
                MessageBox.Show("No hay datos seleccionados.", VariablesMetodosEstaticos.encabezado,
                  MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            
            index = dgvRecibos.CurrentRow.Index;

            if (dgvRecibos.Rows[index].Cells["Observacion_AperturaCierreCaja"].Value.ToString() != "Cerrado")
            {
                MessageBox.Show("La caja seleccionada no ha sido cerrado.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }            
        }

        private void chkPorPrograma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPorCajero.Checked)
            {
                dgvRecibos.Visible = true;
                dgvRecibosGeneral.Visible = false;
            }
            else
            {
                dgvRecibos.Visible = false;
                dgvRecibosGeneral.Visible = true;
            }
        }

        private void btnVolverGenerar_Click(object sender, EventArgs e)
        {
            string resultadoCierre = "";

            if ((MessageBox.Show("¿Desea Realizar el Cierre de Caja o recalculo del cierre?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                DataSet dts = new DataSet();
                index = dgvRecibos.CurrentRow.Index;

                //if (dgvRecibos.Rows[index].Cells["Observacion_AperturaCierreCaja"].Value.ToString() != "Cerrado")
                //{
                //    MessageBox.Show("La caja seleccionada no ha sido cerrado.", VariablesMetodosEstaticos.encabezado,
                //           MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}    
                try
                {
                    resultadoCierre = cn.TraerDataset("usp_m_tb_aperturacierrecaja", "R",
                                                  0,
                                                  //VariablesMetodosEstaticos.idcajausuario,
                                                  Convert.ToInt32(dgvRecibos.Rows[index].Cells["Id_Caja_Usuario"].Value),
                                                  "",
                                                  Convert.ToDateTime(dgvRecibos.Rows[index].Cells["FechaAperturaCaja_AperturaCierreCaja"].Value),
                                                  "",
                                                  0,
                                                  "",
                                                  Convert.ToDateTime(dgvRecibos.Rows[index].Cells["FechaAperturaCaja_AperturaCierreCaja"].Value),
                                                  "",//txtHora.Text,
                                                  0.00,//Convert.ToDecimal(txtMontInicial.Text),
                                                  0,//IntCancelados,
                                                  0,//IntExtornados,
                                                  "Cerrado",
                                                  1,
                                                  VariablesMetodosEstaticos.host_user,
                                                  CurrentUser,
                                                  VariablesMetodosEstaticos.ip_user,
                                                  DateTime.Now,
                                                    "Hora", Convert.ToDateTime(dgvRecibos.Rows[index].Cells["FechaAperturaCaja_AperturaCierreCaja"].Value)).Tables[0].Rows[0][0].ToString();

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
                        buscar();
                    }
                    else if (Convert.ToInt32(resultadoCierre) == 0)
                    {
                        MessageBox.Show("Error en la apertura, contacte con sistemas.", VariablesMetodosEstaticos.encabezado,
                      MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }              
                }
                catch (Exception)
                {
                    
                   // throw;
                }
                    
            }
        }

        private void BtnEliminarApertura_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Seguro de eliminar el registro seleccionado?", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {
                index = dgvRecibos.CurrentRow.Index;
                cn.EjecutarSP("usp_eliminar_apertura_caja", Convert.ToInt32(dgvRecibos.Rows[index].Cells["Id_Caja_Usuario"].Value)
                    , Convert.ToInt32(dgvRecibos.Rows[index].Cells["Id_AperturaCierreCaja"].Value));

                MessageBox.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar();
            }
        }
    }
}

