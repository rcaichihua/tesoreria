using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using GUI_Tesoreria.mantenimiento;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmReportePagosResidente : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private DataTable dtDatosReporte = new DataTable();
        private static frmReportePagosResidente frmInstance = null;
        private CNegocio cn = new CNegocio();

        public frmReportePagosResidente()
        {
            InitializeComponent();
        }
        public static frmReportePagosResidente Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmReportePagosResidente();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmReporteProceso_Load(object sender, EventArgs e)
        {
            cboAFiscal.Text = DateTime.Now.Year.ToString();
            cargarResidentes();
            //buscarIngresosDiarios();
        }

        private void cargarResidentes()
        {
            try
            {
                cboResidentes.DataSource = cn.TraerDataset("usp_select_residente_canevaro","").Tables[0];
                cboResidentes.DisplayMember = "nombres";
                cboResidentes.ValueMember = "residenteId";
            }
            catch (Exception)
            {

            }
        }

        private void buscarIngresosDiarios()
        {
            try
            {
                dtDatosReporte = cn.TraerDataset("usp_obtiene_pagos_residentes",cboResidentes.SelectedValue, cboAFiscal.Text.Trim()).Tables[0];
                if (dtDatosReporte.Rows.Count > 0)
                {
                    caja.Reportes.rptControlCobranza rptReportePagos = new caja.Reportes.rptControlCobranza();
                    rptReportePagos.SetDataSource(dtDatosReporte);
                    crvReportes.ReportSource = rptReportePagos;
                }
                else
                {
                    MessageBox.Show("No hay datos para el reporte", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cboAFiscal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un año valido.", VariablesMetodosEstaticos.encabezado
                       , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            buscarIngresosDiarios();
        }

        private void cargarResidente(string filtro, bool accion)
        {
            var dt = new DataTable();
            try
            {
                if (accion == true)
                {
                    dt = cn.TraerDataset("usp_select_residente_canevaro", filtro).Tables[0];
                    cboResidentes.DataSource = dt;
                    cboResidentes.DisplayMember = "nombres";
                    cboResidentes.ValueMember = "residenteId";
                }
                else
                {
                    DataTable filTable = new DataTable();
                    filTable = cn.TraerDataset("usp_select_residente_canevaro", filtro).Tables[0];
                    if (filTable.Rows.Count > 0)
                    {
                        frmFiltroResidente fi = new frmFiltroResidente(filTable);
                        fi.ParentForm = this;
                        //fi.Dfiltro = filTable;
                        fi.ShowDialog();
                        if (fi.ctaContable != string.Empty)
                        {
                            cboResidentes.Text = fi.ctaContable;
                            txtBuscar.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos con el filtro proporcionado.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtBuscar_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarResidente(txtBuscar.Text.Trim(), false);
            }
        }
    }
}
