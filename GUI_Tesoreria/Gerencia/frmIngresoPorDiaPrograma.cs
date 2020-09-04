using BL_Tesoreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tesoreria.Gerencia
{
    public partial class frmIngresoPorDiaPrograma : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmIngresoPorDiaPrograma frmInstance = null;
        private CNegocio cn = new CNegocio();

        public static frmIngresoPorDiaPrograma Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmIngresoPorDiaPrograma();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmIngresoPorDiaPrograma()
        {
            InitializeComponent();
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
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtIngCajeros = new DataTable();
                DataTable dtIngCajerosSGI = new DataTable();
                DataTable dtUnion = new DataTable();

                if (this.Text == "...:::Ingreso por Programa diario:::...")//ingreso por cajero
                {
                    Gerencia.frmIngresosPorCajero_2Mov_cobradoDelDia winResIngCajero = new Gerencia.frmIngresosPorCajero_2Mov_cobradoDelDia();
                    winResIngCajero.FechaReporteDesde = dtpFechaDesde.Value;
                    winResIngCajero.FechaReporteHasta = dtpHasta.Value;
                    winResIngCajero.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
