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

namespace GUI_Tesoreria.Deposito
{
    public partial class frmEditarDiarioDetalle : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmEditarDiarioDetalle()
        {
            InitializeComponent();
        }
        public string Cuenta_ { get; set; }
        public decimal Debe_ { get; set; }
        public decimal Haber_ { get; set; }
        public string Glosa_ { get; set; }
        public int IdDetDiario { get; set; }
        public bool _Save { get; set; }

        CNegocio cn = new CNegocio();

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                cargarCtaContable(txtBuscar.Text.Trim(), false);
            }
        }

        private void cargarCtaContable(string filtro, bool accion)
        {
            var dt = new DataTable();
            try
            {
                if (accion == true)
                {
                    dt = cn.TraerDataset("usp_select_cuenta_contable", 0, filtro).Tables[0];
                    cboCtaContable.DataSource = dt;
                    cboCtaContable.DisplayMember = "codigoCuenta";
                    cboCtaContable.ValueMember = "id_cuenta_contable";
                }
                else
                {
                    DataTable filTable = new DataTable();
                    filTable = cn.TraerDataset("usp_select_cuenta_contable", 0, filtro).Tables[0];
                    if (filTable.Rows.Count > 0)
                    {
                        frmFiltro fi = new frmFiltro();
                        fi.dfiltro = filTable;
                        fi.ShowDialog();
                        if (fi.ctaContable != string.Empty)
                        {
                            cboCtaContable.SelectedValue = fi.ctaContable;
                            txtBuscar.Clear();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("No hay datos con el filtro proporcionado.", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void frmEditarDiarioDetalle_Load(object sender, EventArgs e)
        {
            cargarCtaContable("", true);
            cboCtaContable.Text = Cuenta_;
            txtdebe.Text = Debe_.ToString("###,###,##0.00");
            txthaber.Text = Haber_.ToString("###,###,##0.00");
            txtglosa.Text = Glosa_;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _Save = false;

                if (!Validar()) return;

                if (cn.EjecutarSP("usp_paDiario_Det_Update", IdDetDiario, cboCtaContable.Text,
                    Convert.ToDecimal(txtdebe.Text), Convert.ToDecimal(txthaber.Text), txtglosa.Text.Trim()) > 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Se actualizo correctamente.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Save = true;
                    this.Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Save = false;
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool Validar()
        {
            bool retu;
            retu = false;
            if (Convert.ToInt32(cboCtaContable.SelectedValue)!=0)
            {
                decimal imp;
                imp = 0.00m;
                if (decimal.TryParse(txtdebe.Text, out imp))
                {
                    imp = 0.00m;
                    if (decimal.TryParse(txthaber.Text, out imp))
                    {
                        retu = true;
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe válido", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txthaber.Focus();
                        retu = false;
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese un importe válido", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtdebe.Focus();
                    retu = false;
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione una cuenta.", VariablesMetodosEstaticos.encabezado,
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCtaContable.Focus();
                retu = false;
            }
            return retu;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
