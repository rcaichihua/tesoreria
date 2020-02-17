using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
namespace GUI_Tesoreria.Contabilidad
{
    public partial class frmGeneracionCuentasContables : Form
    {
        public frmGeneracionCuentasContables()
        {
            InitializeComponent();
        }

        public string _Mantenimiento { get; set; }
        public int _Id_cuenta_contable { get; set; }
        public int _Id_elemento_general { get; set; }
        public int _Id_elemento { get; set; }
        public int _Id_clasificacion { get; set; }
        public string _Subcuenta { get; set; }
        public string _Divisionaria { get; set; }
        public string _Subdivisionaria { get; set; }
        public bool _Movimiento { get; set; }
        public string _Codigo_cuenta { get; set; }
        public string _Descripcion_cuenta { get; set; }
        public bool _Estado { get; set; }

        CNegocio cn = new CNegocio();
        DataTable dt;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGeneracionCuentasContables_Load(object sender, EventArgs e)
        {
            LlenarElementoGeneral();

            if (_Mantenimiento == "U")
            {
                cboElementoGeneral.SelectedValue = _Id_elemento_general;
                cboElemento.SelectedValue = _Id_elemento;
                cboClasificacion.SelectedValue = _Id_clasificacion;
                if (_Subcuenta.ToString().Trim() == string.Empty)
                {
                    cboSubCuenta.SelectedValue = -1;
                }
                else
                {
                    cboSubCuenta.Text = _Subcuenta.ToString();
                }
                if (_Divisionaria.ToString().Trim() == string.Empty)
                {
                    cboDivisionaria.SelectedValue = -1;
                }
                else
                {
                    cboDivisionaria.Text = _Divisionaria.ToString();
                }
                if (_Subdivisionaria.ToString().Trim() == string.Empty)
                {
                    cboSubDivisionaria.SelectedValue = -1;
                }
                else
                {
                    cboSubDivisionaria.Text = _Subdivisionaria.ToString();
                }
                chkMovimiento.Checked = _Movimiento;
                txtCodigoCuenta1.Text = _Codigo_cuenta;
                txtDescripcionCuenta.Text = _Descripcion_cuenta;
                chkCuentaActiva.Checked = _Estado;
            }
            else
            {

            }
        }

        private void LlenarElementoGeneral()
        {
            dt = new DataTable();

            try
            {
                dt = cn.EjecutarSqlDTS("SELECT id_elemento_general,descripcion_elemento_general FROM CONTABILIDAD_ELEMENTOS_GENERALES ORDER BY id_elemento_general;;").Tables[0];

                DataRow row = dt.NewRow();
                row["descripcion_elemento_general"] = "- SELECCIONE -";
                row["id_elemento_general"] = 0;
                dt.Rows.InsertAt(row, 0);

                cboElementoGeneral.DataSource = dt;
                cboElementoGeneral.DisplayMember = "descripcion_elemento_general";
                cboElementoGeneral.ValueMember = "id_elemento_general";
                cboElementoGeneral.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private bool Validar()
        {
            bool rspta;
            rspta = false;

            if (Convert.ToInt32(cboElementoGeneral.SelectedValue) != 0)
            {
                if (Convert.ToInt32(cboElemento.SelectedValue) != 0)
                {
                    if (Convert.ToInt32(cboClasificacion.SelectedValue) != 0)
                    {
                        if (chkMovimiento.Checked)
                        {
                            if ($"{cboSubCuenta.Text}{cboDivisionaria.Text}{cboSubDivisionaria.Text}" == string.Empty)
                            {
                                MessageBox.Show("Seleccione al menos una Sub Cuenta para MOVIMIENTO.", VariablesGlobales.NombreMensajes,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cboSubCuenta.Focus();
                                rspta = false;
                            }
                            else
                            {
                                if (txtCodigoCuenta1.Text.Trim() != string.Empty)
                                {
                                    if (txtDescripcionCuenta.Text.Trim() != string.Empty)
                                    {
                                        rspta = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese la descripcion de la cuenta.", VariablesGlobales.NombreMensajes,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        rspta = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un codigo de cuenta.", VariablesGlobales.NombreMensajes,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    rspta = false;
                                }
                            }
                        }
                        else
                        {
                            if ($"{cboSubCuenta.Text}{cboDivisionaria.Text}{cboSubDivisionaria.Text}" != string.Empty)
                            {
                                MessageBox.Show("Para MOVIMIENTO no se puede seleccionar una Sub Cuenta al menos.", VariablesGlobales.NombreMensajes,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cboSubCuenta.Focus();
                                rspta = false;
                            }
                            else
                            {
                                if (txtCodigoCuenta1.Text.Trim() != string.Empty)
                                {
                                    if (txtDescripcionCuenta.Text.Trim() != string.Empty)
                                    {
                                        rspta = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese la descripción de la cuenta.", VariablesGlobales.NombreMensajes,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        rspta = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un código de cuenta.", VariablesGlobales.NombreMensajes,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    rspta = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un clasificador.", VariablesGlobales.NombreMensajes,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboClasificacion.Focus();
                        rspta = false;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un elemento.", VariablesGlobales.NombreMensajes,
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboElemento.Focus();
                    rspta = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento General.", VariablesGlobales.NombreMensajes,
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboElementoGeneral.Focus();
                rspta = false;
            }
            return rspta;
        }

        private void cboElementoGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();

            try
            {
                dt = cn.EjecutarSqlDTS("SELECT id_elemento, CONCAT(descripcion_elemento,' - ',detalle_elemento) as descripcion_elemento FROM CONTABILIDAD_ELEMENTOS WHERE id_elemento_general = " + cboElementoGeneral.SelectedValue +
                    " ORDER BY id_elemento ASC;").Tables[0];

                DataRow row = dt.NewRow();
                row["descripcion_elemento"] = "- SELECCIONE -";
                row["id_elemento"] = 0;
                dt.Rows.InsertAt(row, 0);

                cboElemento.DataSource = dt;
                cboElemento.DisplayMember = "descripcion_elemento";
                cboElemento.ValueMember = "id_elemento";
                cboElemento.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void cboElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();

            try
            {
                dt = cn.EjecutarSqlDTS("SELECT id_clasificacion,CONCAT(cod_clasificacion,' - ',descripcion) as descripcion FROM CONTABILIDAD_CLASIFICACION WHERE id_elemento=" +
                    cboElemento.SelectedValue + " ORDER BY cod_clasificacion ASC;").Tables[0];

                DataRow row = dt.NewRow();
                row["descripcion"] = "- SELECCIONE -";
                row["id_clasificacion"] = 0;
                dt.Rows.InsertAt(row, 0);

                cboClasificacion.DataSource = dt;
                cboClasificacion.DisplayMember = "descripcion";
                cboClasificacion.ValueMember = "id_clasificacion";
                cboClasificacion.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private void cboSubCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboClasificacion.SelectedValue) != 0)
            {
                cboDivisionaria.SelectedIndex = -1;
                cboSubDivisionaria.SelectedIndex = -1;
                txtCodigoCuenta1.Text = $"{cboClasificacion.Text.Substring(0, 2).ToString()}{cboSubCuenta.Text.Trim()}{cboDivisionaria.Text.Trim()}{cboSubDivisionaria.Text.Trim()}";
                txtDescripcionCuenta.Focus();
            }
            else
            {
                Resetear();
            }
        }

        private void Resetear()
        {
            cboSubCuenta.SelectedIndex = -1;
            cboDivisionaria.SelectedIndex = -1;
            cboSubDivisionaria.SelectedIndex = -1;
            txtCodigoCuenta2.Text = string.Empty;

            if (Convert.ToInt32(cboClasificacion.SelectedValue) != 0)
            {
                txtCodigoCuenta2.Text = $"{cboClasificacion.Text.Substring(0, 2).ToString()}{cboSubCuenta.Text.Trim()}{cboDivisionaria.Text.Trim()}{cboSubDivisionaria.Text.Trim()}";
                txtDescripcionCuenta.Focus();
            }
        }

        private void cboSubDivisionaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboClasificacion.SelectedValue) != 0)
            {
                if (cboSubCuenta.Text.Trim() != string.Empty)
                {
                    if (cboDivisionaria.Text.Trim() != string.Empty)
                    {
                        txtCodigoCuenta2.Text = $"{cboClasificacion.Text.Substring(0, 2).ToString()}{cboSubCuenta.Text.Trim()}{cboDivisionaria.Text.Trim()}{cboSubDivisionaria.Text.Trim()}";
                        txtDescripcionCuenta.Focus();
                    }
                    else
                    {
                        cboSubDivisionaria.SelectedIndex = -1;
                        return;//Resetear();
                    }
                }
                else
                {
                    Resetear();
                }
            }
            else
            {
                Resetear();
            }
        }
    }
}
