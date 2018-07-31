using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Tesoreria;
using BL_Tesoreria;
using System.Data.SqlClient;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantMAC : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private CNegocio cn = new CNegocio();
        private DataTable dtMacCab  = null;
        //private DataTable dtMacDet = null;

        //private int xcod;
        //private string accion="";
        private varGlobales varglo = new varGlobales();
        private static frmMantMAC frmInstance = null;
        public frmMantMAC()
        {
            InitializeComponent();
        }

        DataTable dtMacDet = new DataTable();

        public static frmMantMAC Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantMAC();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantMAC_Load(object sender, EventArgs e)
        {
            cargarSucursal();
            cargarTipoDocumentos();    
            dtMacDet.Columns.Add("detalleMacId");
            dtMacDet.Columns.Add("Cod_TipoDocVenta");
            dtMacDet.Columns.Add("Desc_TipoDocVenta");
            dtMacDet.Columns.Add("nro_serie_ult");
            dtMacDet.Columns.Add("nro_comprobante_ult");

            dgvMac.DataSource = dtMacDet;
        }
        private void cargarSucursal()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_sucursal_all").Tables[0];
                cboSucursal.DataSource = dt;
                cboSucursal.DisplayMember = "varSuNombreSucursal";
                cboSucursal.ValueMember = "intSuID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        /*Codigo Valido*/
        private void cargarTipoDocumentos()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_TipDocumentos").Tables[0];
                cboDocumentos.DataSource = dt;
                cboDocumentos.DisplayMember = "Desc_TipoDocVenta";
                cboDocumentos.ValueMember = "Cod_TipoDocVenta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        private void txtNroSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void txtNroComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void mtbMacC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void mtbMac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            buscarMac(mtbMacC.Text.ToString().Replace("-",""));
        }

        private void buscarMac(string mac)
        {
            dtMacCab = new DataTable();
            dtMacCab = cn.TraerDataset("usp_buscar_cabecera_mac", mac).Tables[0];

            if (dtMacCab.Rows.Count > 0)
            {
                txtIdC.Text = dtMacCab.Rows[0][0].ToString();
                mtbMaC.Text = dtMacCab.Rows[0][1].ToString();
                txtDescripcionCompuC.Text = dtMacCab.Rows[0][2].ToString();
                cboSucursal.SelectedValue = dtMacCab.Rows[0][3].ToString();

                //dtMacDet = new DataTable();

                dtMacDet = cn.TraerDataset("usp_buscar_detalle_mac", (txtIdC.Text == string.Empty ? 0 : Convert.ToInt32(txtIdC.Text))).Tables[0];

                dgvMac.DataSource = dtMacDet;

                mtbMacC.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No hay resultados para la consulta", VariablesMetodosEstaticos.encabezado
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbMacC.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = new Control();
                List<string> excluidos = new List<string>();
                excluidos.Add("mtbMacC");
                excluidos.Add("txtIdC");

                ctrl = varGlobales.buscarTextoVacio(this, excluidos);

                if (ctrl != null)
                {
                    int TamañoNombre = ctrl.Name.Length;
                    MessageBox.Show("Ingrese " + ctrl.Name.Substring(3, TamañoNombre - 3) + "");
                    ctrl.Focus();
                    return;
                }

                foreach (DataGridViewRow Row in dgvMac.Rows)
                {
                    string Valor = Convert.ToString(Row.Cells["Cod_TipoDocVenta"].Value);

                    if (Valor.ToString() == cboDocumentos.SelectedValue.ToString())
                    {
                        MessageBox.Show("El tipo de documento ya se cuentra ingresado, verifique !!", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (txtIdC.Text.Trim() == string.Empty)
                {
                    DataRow row;

                    row = dtMacDet.NewRow();

                    row["detalleMacId"] = 0;
                    row["Cod_TipoDocVenta"] = cboDocumentos.SelectedValue;
                    row["Desc_TipoDocVenta"] = cboDocumentos.Text;
                    row["nro_serie_ult"] = txtNroSerie.Text;
                    row["nro_comprobante_ult"] = txtNroComprobante.Text;
                    dtMacDet.Rows.Add(row);

                    //dgvMac.DataSource = dtMacDet;
                }
                else
                {

                    cn.EjecutarSP("usp_agrega_mac_detalle_x_id", Convert.ToInt32(txtIdC.Text), cboDocumentos.SelectedValue, txtNroSerie.Text.Trim(), txtNroComprobante.Text.Trim());

                    //dtMacDet = new DataTable();

                    dtMacDet = cn.TraerDataset("usp_buscar_detalle_mac", (txtIdC.Text == string.Empty ? 0 : Convert.ToInt32(txtIdC.Text))).Tables[0];

                    dgvMac.DataSource = dtMacDet;
                }
                
                varGlobales.resetearCampos(this);
            }
            catch (Exception)
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMac.Rows.Count > 0)
                {
                    if (txtIdC.Text != string.Empty)
                    {
                        cn.EjecutarSP("usp_elimina_mac_detalle_x_id", dgvMac["detalleMacId", dgvMac.CurrentRow.Index].Value);

                        MessageBox.Show("Registro eliminado correctamente!.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvMac.Rows.RemoveAt(dgvMac.CurrentRow.Index);
                    dgvMac.Update();
                    dgvMac.Refresh();
                }
                else
                {
                    MessageBox.Show("No existe datos para eliminar, verifique !!", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdC.Text != string.Empty)
                {
                    if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        DataTable resultado = new DataTable();

                        if (txtIdC.Text == string.Empty)
                        {
                            return;
                        }

                        resultado = cn.TraerDataset("usp_elimina_mac", txtIdC.Text.Trim()).Tables[0];

                        if (resultado.Rows[0][0].ToString() == "OK")
                        {
                            MessageBox.Show("Eliminado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1_Click(sender, e);
                        }
                        else
                        {
                            if (resultado.Rows[0][0].ToString() == "547")
                            {
                                varGlobales var = new varGlobales();

                                MessageBox.Show(var.mensajeError(Convert.ToInt32(resultado.Rows[0][0])), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Error desconocido, contacto con sistemas.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtbMaC.Text = string.Empty;
            mtbMacC.Text = string.Empty;
            txtIdC.Text = string.Empty;
            txtDescripcionCompuC.Text = string.Empty;
            txtNroSerie.Text = string.Empty;
            txtNroComprobante.Text = string.Empty;
            cboDocumentos.SelectedIndex = 1;
            dtMacDet.Clear();
            dgvMac.DataSource = dtMacDet;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            DataTable dtbMac = null;
            try
            {
                if (cboSucursal.SelectedIndex==0)
                {
                    MessageBox.Show("Seleccione una sucursal.", VariablesMetodosEstaticos.encabezado
                                , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSucursal.Focus();
                    return;
                }
                if (dgvMac.Rows.Count > 0 && txtDescripcionCompuC.Text != string.Empty && mtbMaC.Text != "  -  -  -  -  -")
                {
                    int idMac;

                    if (mtbMaC.Text.Trim() == "-  -  -  -  -" || txtDescripcionCompuC.Text == string.Empty)
                    {
                        MessageBox.Show("Falta ingresa el codigo MAC o su descripción, verifique.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txtIdC.Text.Trim() != string.Empty)
                    {
                        //dtbMac = new DataTable();
                        DataSet dtsUsuarioCaja;
                        int resul;
                        dtsUsuarioCaja = new DataSet();

                        dtsUsuarioCaja = cn.TraerDataset("usp_verifica_usuario_x_mac", Convert.ToInt32(txtIdC.Text));

                        resul = Convert.ToInt32(dtsUsuarioCaja.Tables[0].Rows[0][0]);

                        if (resul > 1)
                        {
                            MessageBox.Show("Ha ocurrido un error inesperado, contacte con sistemas.", VariablesMetodosEstaticos.encabezado
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        dtsUsuarioCaja = new DataSet();

                        dtsUsuarioCaja = cn.TraerDataset("usp_verifica_sucursal_x_usuario_mac", Convert.ToInt32(txtIdC.Text), cboSucursal.SelectedValue);

                        resul = Convert.ToInt32(dtsUsuarioCaja.Tables[0].Rows[0][0]);

                        if (resul != 0)
                        {
                            MessageBox.Show("Ha ocurrido un error inesperado, contacte con sistemas.", VariablesMetodosEstaticos.encabezado
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        resul = 0;

                        resul = cn.EjecutarSP("usp_u_mac", Convert.ToInt32(txtIdC.Text), mtbMaC.Text.ToString().Replace("-", ""),
                            txtDescripcionCompuC.Text.Trim(), VariablesMetodosEstaticos.varUsuario
                            , VariablesMetodosEstaticos.ip_user + " " + VariablesMetodosEstaticos.host_user,cboSucursal.SelectedValue);

                        if (resul > 0)
                        {
                            MessageBox.Show("Cabecera actualizado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se actualizo, verifique o intente de nuevo.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        dtbMac = cn.TraerDataset("usp_i_mac", mtbMaC.Text.ToString().Replace("-", ""), txtDescripcionCompuC.Text.Trim(), VariablesMetodosEstaticos.varUsuario, VariablesMetodosEstaticos.host_user, cboSucursal.SelectedValue).Tables[0];

                        if (dtbMac.Rows.Count > 0)
                        {
                            idMac = Convert.ToInt32(dtbMac.Rows[0][0]);
                            foreach (DataGridViewRow Row in dgvMac.Rows)
                            {
                                cn.EjecutarSP("usp_i_mac_detalle", idMac, Row.Cells["Cod_TipoDocVenta"].Value, Row.Cells["nro_serie_ult"].Value, Row.Cells["nro_comprobante_ult"].Value);
                            }
                            MessageBox.Show("Ingresado correctamente.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            buscarMac(mtbMaC.Text.ToString().Replace("-", ""));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                    MessageBox.Show("Error: " + varglo.mensajeError(Convert.ToInt32(ex.Errors[0].Number)), VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void LimpiarControles()
        {
            txtIdC.Text = string.Empty;
            mtbMaC.Text = string.Empty;
            txtDescripcionCompuC.Text = string.Empty;
            cboDocumentos.SelectedIndex = 1;
            txtNroSerie.Text = string.Empty;
            txtNroComprobante.Text = string.Empty;
            dgvMac.Rows.Clear();
        }
    }
}
