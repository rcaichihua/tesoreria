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
        public Boolean Acceso { get; set; }

        public frmVerificacionLiquidaciones()
        {
            InitializeComponent();
        }

        private void frmVerificacionLiquidaciones_Load(object sender, EventArgs e)
        {
            ListarProgramas();
            if (!Acceso)
            {
                btnRecalcular.Enabled = false;
                btnAsignarPliego.Enabled = false;
                btnModificarLiq.Enabled = false;
                btnAgregarLiq.Enabled = false;
                btnEliminar.Enabled = false;
            }
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

            dtResu = cn.TraerDataset("usp_ListaLiquidaciones_new", dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue).Tables[0];
            
            if (dtResu.Rows.Count == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No hay liquidaciones registradas para el rango de fecha ingresado.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                cboPrograma.Focus();
               // return;
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
            if (dtpFechaLiqDesde.Value != dtpFechaLiqHasta.Value)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Para el ingreso de la glosa y número de pliego seleccione una sola fecha.", VariablesMetodosEstaticos.encabezado,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaLiqDesde.Focus();
                return;
            }

            int id_Liq;
            id_Liq = 0;
            DataTable dt = new DataTable();

            dt = cn.TraerDataset("usp_ListaLiquidaciones", dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue).Tables[0];
            if (dt.Rows.Count<=0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El programa " + cboPrograma .Text+ " no tiene datos para asignar pliego y glosa." + dtpFechaLiqDesde.Value.ToString("dd/MM/yyyy") + ".", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                return;
            }
            frmAsignaPliegoGlosa win = new frmAsignaPliegoGlosa();
            win.FechaLiq = dtpFechaLiqDesde.Value.ToString("dd/MM/yyyy");
            win.Programa = cboPrograma.Text;
            win.ProgramaId = Convert.ToInt32(cboPrograma.SelectedValue);
            win.ShowDialog();
            //DataTable dt = new DataTable();
            //dt = cn.EjecutarSqlDTS("select donume,observaciones from documentosIngresoCabecera where idLiquidacion="++" and estado=1").Tables[0];
        }

        private void btnModificarLiq_Click(object sender, EventArgs e)
        {
            if (dtpFechaLiqDesde.Value != dtpFechaLiqHasta.Value)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Para modificar seleccione una sola fecha.", VariablesMetodosEstaticos.encabezado,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaLiqDesde.Focus();
                return;
            }

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
            if (dtpFechaLiqDesde.Value != dtpFechaLiqHasta.Value)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Para agregar seleccione una sola fecha.", VariablesMetodosEstaticos.encabezado,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaLiqDesde.Focus();
                return;
            }

            frmModAgregaReciboIngreso win = new frmModAgregaReciboIngreso();
            win.Tipo = "I";
            win.FechaLiq = dtpFechaLiqDesde.Value.ToString("dd/MM/yyyy");
            win.ProgramaId = Convert.ToInt32(cboPrograma.SelectedValue);
            win.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtpFechaLiqDesde.Value != dtpFechaLiqHasta.Value)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Para eliminar seleccione una sola fecha.", VariablesMetodosEstaticos.encabezado,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaLiqDesde.Focus();
                return;
            }

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
                DataSet dtsListadoContableNegativo = new DataSet();
                frmReporte winReport = new frmReporte();

                if (dtpFechaLiqDesde.Value.Year<2020)
                {
                    dtsListadoContable = cn.TraerDataset("usp_ListaLiquidaciones_contable_new",
                        dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue);

                    if (dtsListadoContable.Tables[0].Rows.Count > 0)
                    {
                        if (chkcuentas.Checked)
                        {
                            DataTable dtCuenta;

                            foreach (DataRow item in dtsListadoContable.Tables[0].Rows)
                            {
                                dtCuenta = new DataTable();

                                dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[2] + "'").Tables[0];

                                if (dtCuenta.Rows.Count <= 0)
                                {
                                    item[2] = "S/CTA";
                                    item[3] = "S/NOMBRE";
                                }
                                else
                                {
                                    item[2] = dtCuenta.Rows[0][0];
                                    item[3] = dtCuenta.Rows[0][1];
                                }
                            }
                        }
                    }

                    dtsListadoContableNegativo = cn.TraerDataset("usp_ListaLiquidaciones_contable_negativo_new",
                        dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue);

                    if (dtsListadoContableNegativo.Tables[0].Rows.Count > 0)
                    {
                        if (chkcuentas.Checked)
                        {
                            DataTable dtCuenta;

                            foreach (DataRow item in dtsListadoContableNegativo.Tables[0].Rows)
                            {
                                dtCuenta = new DataTable();

                                dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[2] + "'").Tables[0];

                                if (dtCuenta.Rows.Count <= 0)
                                {
                                    item[2] = "S/CTA";
                                    item[3] = "S/NOMBRE";
                                }
                                else
                                {
                                    item[2] = dtCuenta.Rows[0][0];
                                    item[3] = dtCuenta.Rows[0][1];
                                }
                            }
                        }
                    }

                    if (dtsListadoContable.Tables[0].Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    // usp_listado_contable_cuenta_empresarial_
                    dtsListadoContable = cn.TraerDataset("usp_listado_contable_cuenta_empresarial_rango"
                        , cboPrograma.SelectedValue, dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"));

                    dtsListadoContableNegativo = cn.TraerDataset("usp_ListaLiquidaciones_contable_negativo_new",
                        dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue);


                    dtsListadoContableNegativo.AcceptChanges();

                    foreach (DataRow row in dtsListadoContableNegativo.Tables[0].Rows)
                    {
                        // If this row is offensive then
                        row.Delete();
                    }
                }
                /*DataSet dtsListadoContableNegativo = new DataSet();

                frmReporte winReport = new frmReporte();

                dtsListadoContable = cn.TraerDataset("usp_ListaLiquidaciones_contable_new", 
                    dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue);

                if (dtsListadoContable.Tables[0].Rows.Count > 0)
                {
                    if (chkcuentas.Checked)
                    {
                        DataTable dtCuenta;

                        foreach (DataRow item in dtsListadoContable.Tables[0].Rows)
                        {
                            dtCuenta = new DataTable();

                            dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[2] + "'").Tables[0];

                            if (dtCuenta.Rows.Count <= 0)
                            {
                                item[2] = "S/CTA";
                                item[3] = "S/NOMBRE";
                            }
                            else
                            {
                                item[2] = dtCuenta.Rows[0][0];
                                item[3] = dtCuenta.Rows[0][1];
                            }
                        }
                    }
                }

                dtsListadoContableNegativo = cn.TraerDataset("usp_ListaLiquidaciones_contable_negativo_new",
                    dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), dtpFechaLiqHasta.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue);

                if(dtsListadoContableNegativo.Tables[0].Rows.Count > 0)
                {
                    if (chkcuentas.Checked)
                    {
                        DataTable dtCuenta;

                        foreach (DataRow item in dtsListadoContableNegativo.Tables[0].Rows)
                        {
                            dtCuenta = new DataTable();

                            dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[2] + "'").Tables[0];

                            if (dtCuenta.Rows.Count <= 0)
                            {
                                item[2] = "S/CTA";
                                item[3] = "S/NOMBRE";
                            }
                            else
                            {
                                item[2] = dtCuenta.Rows[0][0];
                                item[3] = dtCuenta.Rows[0][1];
                            }
                        }
                    }
                }

                if (dtsListadoContable.Tables[0].Rows.Count <= 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }*/
                

                Reportes.rptListadoContable rptRecibo = new Reportes.rptListadoContable();

                rptRecibo.Subreports[0].Database.Tables[0].SetDataSource(dtsListadoContableNegativo.Tables[0]);

                rptRecibo.SetDataSource(dtsListadoContable.Tables[0]);
                rptRecibo.SetParameterValue("@desde", dtpFechaLiqDesde.Value.ToString("dd/MM/yyyy"));
                rptRecibo.SetParameterValue("@hasta", dtpFechaLiqHasta.Value.ToString("dd/MM/yyyy"));
                winReport.crvReportes.ReportSource = rptRecibo;

                winReport.WindowState = FormWindowState.Maximized;
                winReport.ShowDialog();
            }
        }

        private void btnReciboIngreso_Click(object sender, EventArgs e)
        {
            //int indiceRecibo = 0;
            if (dtpFechaLiqDesde.Value != dtpFechaLiqHasta.Value)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("El recibo de ingreso solo es visible para un día.", VariablesMetodosEstaticos.encabezado,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 dtpFechaLiqDesde.Focus();
                return;
            }

            DataSet dtsRecibo = new DataSet();
            frmReporte winReport = new frmReporte();

            if (Convert.ToInt32(cboPrograma.SelectedValue) == 3 || Convert.ToInt32(cboPrograma.SelectedValue)==4 )
            {
                if (dtpFechaLiqDesde.Value.Year > 2019)
                {                 //dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", cboPrograma.SelectedValue,dtpFechaLiqDesde.Value.ToString("yyyyMMdd"));
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso_cuenta_empresarial_", cboPrograma.SelectedValue,
                        dtpFechaLiqDesde.Value.ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //if (chkcuentas.Checked)
                    //{
                    //    DataTable dtCuenta;

                    //    foreach (DataRow item in dtsRecibo.Tables[0].Rows)
                    //    {
                    //        dtCuenta = new DataTable();

                    //        dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[6] + "'").Tables[0];

                    //        if (dtCuenta.Rows.Count <= 0)
                    //        {
                    //            item[6] = "S/CTA";
                    //            item[7] = "S/NOMBRE";
                    //        }
                    //        else
                    //        {
                    //            item[6] = dtCuenta.Rows[0][0];
                    //            item[7] = dtCuenta.Rows[0][1];
                    //        }
                    //    }
                    //}
                }
                else
                {
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", cboPrograma.SelectedValue,
                    dtpFechaLiqDesde.Value.ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (chkcuentas.Checked)
                    {
                        DataTable dtCuenta;

                        foreach (DataRow item in dtsRecibo.Tables[0].Rows)
                        {
                            dtCuenta = new DataTable();

                            dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[6] + "'").Tables[0];

                            if (dtCuenta.Rows.Count <= 0)
                            {
                                item[6] = "S/CTA";
                                item[7] = "S/NOMBRE";
                            }
                            else
                            {
                                item[6] = dtCuenta.Rows[0][0];
                                item[7] = dtCuenta.Rows[0][1];
                            }
                        }
                    }
                }
            }
            else
            {
                if (dtpFechaLiqDesde.Value.Year > 2019)
                {
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso_cuenta_empresarial_", cboPrograma.SelectedValue,
                    dtpFechaLiqDesde.Value.ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    dtsRecibo = cn.TraerDataset("usp_recibo_ingreso_teso", cboPrograma.SelectedValue,
                    dtpFechaLiqDesde.Value.ToString("yyyyMMdd"));

                    if (dtsRecibo.Tables[0].Rows.Count == 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para motrar.", VariablesMetodosEstaticos.encabezado,
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (chkcuentas.Checked)
                    {
                        DataTable dtCuenta;

                        foreach (DataRow item in dtsRecibo.Tables[0].Rows)
                        {
                            dtCuenta = new DataTable();

                            dtCuenta = cn.EjecutarSqlDTS("select CODIGO_CONTABLE2,DENOMINACION2 from contable_privado where CODIGO_CONTABLE1='" + item[6] + "'").Tables[0];

                            if (dtCuenta.Rows.Count <= 0)
                            {
                                item[6] = "S/CTA";
                                item[7] = "S/NOMBRE";
                            }
                            else
                            {
                                item[6] = dtCuenta.Rows[0][0];
                                item[7] = dtCuenta.Rows[0][1];
                            }
                        }
                    }
                }
            }

            Reportes.rptRecibosIngreso rptRecibo = new Reportes.rptRecibosIngreso();
            rptRecibo.SetDataSource(dtsRecibo.Tables[0]);
            winReport.crvReportes.ReportSource = rptRecibo;

            winReport.WindowState = FormWindowState.Maximized;
            winReport.ShowDialog();
        }

        private void cboPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaLiqDesde.Value!=dtpFechaLiqHasta.Value)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El recálculo solo se puede realizar a un día.", VariablesMetodosEstaticos.encabezado,
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaLiqDesde.Focus();
                    return;
                }
                if (Convert.ToInt32(cboPrograma.SelectedValue)==3)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Para Inmobiliaria no se puede realizar la actualziación de cuentas.", VariablesMetodosEstaticos.encabezado,
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable resuActuCtas = new DataTable();

                resuActuCtas = cn.TraerDataset("usp_verifica_Actualizacion_ctas", dtpFechaLiqDesde.Value.ToString("yyyyMMdd"),
                    cboPrograma.SelectedValue).Tables[0];

                if (resuActuCtas.Rows.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No hay datatos para actualizar.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Esta Seguro actualizar las cuentas.?" +
                    Environment.NewLine + "Se eliminaran las cuentas existentes.", VariablesMetodosEstaticos.encabezado,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                              DialogResult.Yes))
                {
                    cn.TraerDataset("usp_ActualizaCtaLiquidacion", dtpFechaLiqDesde.Value.ToString("yyyyMMdd"), cboPrograma.SelectedValue,
                        VariablesMetodosEstaticos.varNombreUser, VariablesMetodosEstaticos.ip_user + "/" +
                        VariablesMetodosEstaticos.host_user);
                    DevComponents.DotNetBar.MessageBoxEx.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnBuscar_Click(sender,e);                   
                }
            }
            catch (Exception ex )
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dtpFechaLiqDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaLiqHasta.Value = dtpFechaLiqDesde.Value;
        }
    }
}
