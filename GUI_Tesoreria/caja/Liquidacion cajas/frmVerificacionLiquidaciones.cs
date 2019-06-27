using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmVerificacionLiquidaciones : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        DataTable dtResu;

        public frmVerificacionLiquidaciones()
        {
            InitializeComponent();
        }

        private void frmVerificacionLiquidaciones_Load(object sender, EventArgs e)
        {
            ListarProgramas();
        }

        private void ListarProgramas()
        {
            DataTable dtb = new DataTable();

            DataRow row;

            dtb = cn.TraerDataset("usp_ListaProgramas").Tables[0];
            row = dtb.NewRow();
            row["intProId"] = 0;
            row["varProDescripcion"] = "[-- SELECCIONE --]";

            dtb.Rows.InsertAt(row, 0);

            cboPrograma.DisplayMember = "varProDescripcion";
            cboPrograma.ValueMember = "intProId";
            cboPrograma.DataSource = dtb;
        }

        private void BtnGrabarC_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.Show("Se guardo correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboPrograma.SelectedIndex==0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Selecione un programa.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                cboPrograma.Focus();
                return;
            }
            dtResu = new DataTable();

            dtResu = cn.TraerDataset("usp_ListaLiquidaciones", dtpFechaLiq.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue).Tables[0];
            
            if (dtResu.Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay liquidaciones registradas para el dia "+dtpFechaLiq.Value.ToString("dd/MM/yyyy")+".", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                cboPrograma.Focus();
                return;
            }

            dgvLiquidaciones.DataSource = dtResu;
            decimal Total;
            Total = 0.00m;
            foreach (DataGridViewRow item in dgvLiquidaciones.Rows)
            {
                Total = Total + Convert.ToDecimal(item.Cells[4].Value);
            }

            txtTotal.Text = Total.ToString("###,###,###,###,##0.00");
        }

        private void btnAsignarPliego_Click(object sender, EventArgs e)
        {
            int id_Liq;
            id_Liq = 0;
            DataTable dt = new DataTable();

            dt = cn.TraerDataset("usp_ListaLiquidaciones", dtpFechaLiq.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue).Tables[0];
            if (dt.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El programa " + cboPrograma .Text+ " no tiene datos para asignar pliego y glosa." + dtpFechaLiq.Value.ToString("dd/MM/yyyy") + ".", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                return;
            }
            frmAsignaPliegoGlosa win = new frmAsignaPliegoGlosa();
            win.FechaLiq = dtpFechaLiq.Value.ToString("dd/MM/yyyy");
            win.Programa = cboPrograma.Text;
            win.ProgramaId = Convert.ToInt32(cboPrograma.SelectedValue);
            win.ShowDialog();
            //DataTable dt = new DataTable();
            //dt = cn.EjecutarSqlDTS("select donume,observaciones from documentosIngresoCabecera where idLiquidacion="++" and estado=1").Tables[0];
        }

        private void btnModificarLiq_Click(object sender, EventArgs e)
        {
            if (dgvLiquidaciones.CurrentRow!=null)
            {
                int index = 0;
                index = dgvLiquidaciones.CurrentRow.Index;

                frmModAgregaReciboIngreso win = new frmModAgregaReciboIngreso();
                win.Tipo = "M";
                win.idRegistro = Convert.ToInt32(dgvLiquidaciones.Rows[index].Cells[1].Value);
                win.TipoDoc = dgvLiquidaciones.Rows[index].Cells[2].Value.ToString();
                win.NroDoc= dgvLiquidaciones.Rows[index].Cells[3].Value.ToString();
                win.Importe= Convert.ToDecimal(dgvLiquidaciones.Rows[index].Cells[4].Value);
                win.CtaId = Convert.ToInt32(dgvLiquidaciones.Rows[index].Cells[5].Value);
                win.CodInmueble = dgvLiquidaciones.Rows[index].Cells[7].Value.ToString();
                win.ShowDialog();
                btnBuscar_Click(sender,e);
            }
            
        }

        private void btnAgregarLiq_Click(object sender, EventArgs e)
        {
            frmModAgregaReciboIngreso win = new frmModAgregaReciboIngreso();
            win.Tipo = "I";
            win.FechaLiq = dtpFechaLiq.Value.ToString("dd/MM/yyyy");
            win.ProgramaId = Convert.ToInt32(cboPrograma.SelectedValue);
            win.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLiquidaciones.CurrentRow != null)
            {
                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta Seguro de eliminar.?", VariablesMetodosEstaticos.encabezado,
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {

                    int index = 0;
                    index = dgvLiquidaciones.CurrentRow.Index;

                    if (cn.EjecutarSP("usp_mantenimiento_Doc_Ingreso_Detalle_Liquidacion", "D", "", "",
                    0, 0, Convert.ToInt32(dgvLiquidaciones.Rows[index].Cells[1].Value), 
                    "", "", 0,VariablesGlobales.NombreUsuario,VariablesGlobales.UserHostIp) > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Se elimino correctamente.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btnBuscar_Click(sender,e);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnListadoContable_Click(object sender, EventArgs e)
        {
            if (dgvLiquidaciones.CurrentRow!=null)
            {
                DataSet dtsListadoContable = new DataSet();
                frmReporte winReport = new frmReporte();

                dtsListadoContable = cn.TraerDataset("usp_ListaLiquidaciones_contable", dtpFechaLiq.Value.ToString("yyyyMMdd"),cboPrograma.SelectedValue);

                if (dtsListadoContable.Tables[0].Rows.Count <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
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

        private void btnReciboIngreso_Click(object sender, EventArgs e)
        {
            //int indiceRecibo = 0;

            DataSet dtsRecibo = new DataSet();
            frmReporte winReport = new frmReporte();

            dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", cboPrograma.SelectedValue,dtpFechaLiq.Value.ToString("yyyyMMdd"));

            if (dtsRecibo.Tables[0].Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Reportes.rptRecibosIngreso rptRecibo = new Reportes.rptRecibosIngreso();
            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
            winReport.crvReportes.ReportSource = rptRecibo;

            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }
    }
}
