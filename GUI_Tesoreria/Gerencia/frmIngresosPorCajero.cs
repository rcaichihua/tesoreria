using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Gerencia
{
    public partial class frmIngresosPorCajero : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmIngresosPorCajero frmInstance = null;
        private CNegocio cn = new CNegocio();

        public static frmIngresosPorCajero Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresosPorCajero();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmIngresosPorCajero()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtIngCajeros = new DataTable();
                DataTable dtIngCajerosSGI = new DataTable();
                DataTable dtUnion = new DataTable();

                if (this.Text != "...:::Ingreso por Programa:::...")//ingreso por cajero
                {
                    Gerencia.frmIngresosPorCajero_2Mov_cobradoDelDia winResIngCajero = new Gerencia.frmIngresosPorCajero_2Mov_cobradoDelDia();
                    winResIngCajero.FechaReporteDesde = dtpFechaDesde.Value.ToShortDateString();
                    winResIngCajero.FechaReporteHasta = dtpHasta.Value.ToShortDateString();
                    winResIngCajero.ShowDialog();
                }
                else
                {
                    dtIngCajeros = cn.TraerDataset("usp_select_ingreso_x_programa", dtpFechaDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString()).Tables[0];

                    dtIngCajerosSGI = cn.TraerDataset("USP_INMOBILIARIA_INGRESO_TOTAL", dtpFechaDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString()).Tables[0];
                    
                    if (dtIngCajeros.Rows.Count==0 && dtIngCajerosSGI.Rows.Count != 0)
                    {
                        dtUnion = Union(dtIngCajerosSGI, dtIngCajeros);
                    }
                    if (dtIngCajeros.Rows.Count!=0 && dtIngCajerosSGI.Rows.Count == 0)
                    {
                        dtUnion = Union(dtIngCajeros,dtIngCajerosSGI);
                    }
                    if (dtIngCajeros.Rows.Count != 0 && dtIngCajerosSGI.Rows.Count != 0)
                    {
                        dtUnion = Union(dtIngCajeros, dtIngCajerosSGI);
                    }
                    if (dtUnion.Rows.Count <= 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos para el reporte.", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    Gerencia.frmIngresosPorPrograma_2Mov_cobradoDelDia winResIngCajero = new Gerencia.frmIngresosPorPrograma_2Mov_cobradoDelDia();
                    winResIngCajero.datosIngCajero = Union(dtIngCajeros, dtIngCajerosSGI);
                    winResIngCajero.FechaReporteDesde = dtpFechaDesde.Value.ToShortDateString();
                    winResIngCajero.FechaReporteHasta = dtpHasta.Value.ToShortDateString();
                    winResIngCajero.ShowDialog();
                }
               
            }
            catch (Exception)
            {
            }
        }

        public static DataTable Union(DataTable First, DataTable Second)
        {

            DataTable table = new DataTable("Union");

            DataColumn[] newcolumns = new DataColumn[First.Columns.Count];

            for (int i = 0; i < First.Columns.Count; i++)
            {
                newcolumns[i] = new DataColumn(
                First.Columns[i].ColumnName, First.Columns[i].DataType);
            }

            table.Columns.AddRange(newcolumns);
            table.BeginLoadData();

            foreach (DataRow row in First.Rows)
            {
                table.LoadDataRow(row.ItemArray, true);
            }

            foreach (DataRow row in Second.Rows)
            {
                table.LoadDataRow(row.ItemArray, true);
            }

            table.EndLoadData();
            return table;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
