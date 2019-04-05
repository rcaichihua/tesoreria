using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmMigrar : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        private static frmMigrar frmInstance = null;

        public frmMigrar()
        {
            InitializeComponent();
        }

        public static frmMigrar Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMigrar();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMigrar_Load(object sender, EventArgs e)
        {
            cargarResidente();
            cargarMovimientos();
            cboAnio.SelectedIndex = 0;
        }

        private void cargarResidente()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_residente", 0).Tables[0];
                dgvResidente.Refresh();
                dgvResidente.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }
        private void cargarMovimientos()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_ingreso_movimiento_masivo").Tables[0];
                dgvIngresos.Refresh();
                dgvIngresos.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        //private void txtFiltro_TextChanged(object sender, EventArgs e)
        //{
        //    var dt = new DataTable();
        //    try
        //    {
        //        dt = cn.TraerDataset("usp_select_tb_residente_x_apellido", txtFiltro.Text.Trim()).Tables[0];
        //        dgvResidente.Refresh();
        //        dgvResidente.DataSource = dt;
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void dgvResidente_Click(object sender, EventArgs e)
        {
            if (dgvResidente.RowCount > 0) { CargaDatosxId(); }
        }

        private void CargaDatosxId()
        {
            int xcod;
            try
            {
                int fila;
                if (dgvResidente.RowCount > 0)
                {
                    fila = dgvResidente.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvResidente.Rows[fila].Cells[0].Value);
                    DataTable dt = new DataTable();
                    dt = cn.TraerDataset("usp_select_tb_residente_x_id", xcod).Tables[0];
                    this.txtId.Text = (dt.Rows[0][0].ToString());
                    this.txtNombres.Text = (dt.Rows[0][3].ToString() + " " + dt.Rows[0][2].ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            int resultado;
            DataTable dt = new DataTable();

            resultado = 0;

            if (txtId.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese ID o seleccione un residente");
                txtId.Focus();
                return;
            }
            if (txtNombres.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese nombre o seleccione un residente");
                txtNombres.Focus();
                return;
            }
            if (txtMovi.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese movimiento");
                txtMovi.Focus();
                return;
            }

            if (txtAfect.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese afectacion");
                txtAfect.Focus();
                return;
            }

            if (txtNroRecibo.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese Recibo");
                txtNroRecibo.Focus();
                return;
            }
            if (txtFecha.Text.Trim() == "  /  /    ")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese Fecha");
                txtFecha.Focus();
                return;
            }

            if (txtMonto.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese afectacion");
                txtMonto.Focus();
                return;
            }
            if (txtMonto.Text.Trim() != string.Empty)
            {
                if (Convert.ToDouble(txtMonto.Text.Trim()) == 0.00D)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Monto mayor a cero");
                    txtMonto.Focus();
                    return;
                }
            }
            try
            {
                Boolean searchMov = true;
                Boolean searchAfec = true;

                List<string> mov = new List<string> { "C", "E" };
                List<string> afec = new List<string> { "MO", "DS", "PE" };

                foreach (var value in mov)
                {
                    if (value.ToString() == txtMovi.Text.Trim())
                    {
                        searchMov = false;
                        break;
                    }
                }

                if (searchMov == true)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("El valor de movimiento solo puede ser \"C\" o \"E\"");
                    txtMovi.Focus();
                    return;
                }

                foreach (var value in afec)
                {
                    if (value.ToString() == txtAfect.Text.Trim())
                    {
                        searchAfec = false;
                        break;
                    }
                }

                if (searchAfec == true)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("La afectacion solo puede ser \"MO\" - \"DS\" - \"PE\"");
                    txtAfect.Focus();
                    return;
                }

                dt = cn.TraerDataset("usp_verifica_movimiento_ctacte_masivo", txtId.Text.Trim(), cboAnio.Text
                    , txtMes.Text.Trim(), txtMonto.Text, txtMovi.Text.Trim(), txtAfect.Text.Trim(),txtNroRecibo.Text.Trim()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Este Ingreso ya fue registrador, verifique!");
                    return;
                }

                resultado = cn.EjecutarSP("usp_inserta_movimientos_cta_temporal", txtId.Text.Trim(), cboAnio.Text
                    , txtMes.Text.Trim(), txtMonto.Text, txtMovi.Text.Trim(), txtAfect.Text.Trim(), txtNroRecibo.Text, Convert.ToDateTime(txtFecha.Text));

                if (resultado >= 1)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente!");
                    cargarMovimientos();
                    //txtFiltro.Clear();
                    txtId.Clear();
                    txtNombres.Clear();
                    txtMovi.Clear();
                    txtAfect.Clear();
                    cboAnio.SelectedIndex = 0;
                    txtMes.Clear();
                    txtMonto.Text = "0.00";
                    txtFiltro.Focus();
                    txtNroRecibo.Clear();
                    txtPension.Clear();
                    txtFecha.Clear();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error!");
                }
            }
            catch (Exception)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error!, verifique los datos ingresados .. ex.");
            }

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {
            try
            {
                int filax = 0;

                int resultadox = 0;
                if (dgvIngresos.RowCount > 0)
                {
                    filax = dgvIngresos.CurrentRow.Index;
                    resultadox = cn.EjecutarUD("update tb_movimiento_ctacte set estado=0 where movimientoCtacteId = " + dgvIngresos.Rows[filax].Cells[0].Value + "");
                }
                if (resultadox > 0)
                {
                    if ((DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea poner en estado pendiente el mes " + dgvIngresos.Rows[filax].Cells[2].Value +
                        " del año " + dgvIngresos.Rows[filax].Cells[1].Value + "?",VariablesMetodosEstaticos.encabezado, 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        resultadox = cn.EjecutarUD(" UPDATE tb_ctacte_residente set EstadoCtaCteResidente='P' where ctacteResidenteId= " + dgvIngresos.Rows[filax].Cells[10].Value + "");
                    }
                    DevComponents.DotNetBar.MessageBoxEx.Show("Anulado correctamente el ID " + dgvIngresos.Rows[filax].Cells[0].Value);
                    cargarMovimientos();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMes.Text.Trim() == string.Empty)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el mes.");
                    txtMes.Focus();
                    return;
                }

                txtPension.Text = cn.EjecutarSqlDTS("select ImporteCtacteResidente from tb_ctacte_residente where residenteId=" +
                txtId.Text + " and AFiscalCtacteResidente='" + cboAnio.Text +
                "' and MesCtacteResidente=RIGHT('00'+cast(" + txtMes.Text + " as varchar),2)").Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, verifique los datos como ID residente, año y mes.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_residente_x_apellido", txtFiltro.Text.Trim()).Tables[0];
                dgvResidente.Refresh();
                dgvResidente.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }
    }
}
