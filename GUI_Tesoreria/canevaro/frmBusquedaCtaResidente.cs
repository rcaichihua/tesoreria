using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI_Tesoreria.DGAI;
using BL_Tesoreria;

namespace GUI_Tesoreria.canevaro
{
    public partial class frmBusquedaCtaResidente : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private static frmBusquedaCtaResidente frmInstance = null;
        CNegocio cn = new CNegocio();

        public frmBusquedaCtaResidente()
        {
            InitializeComponent();
        }

        public static frmBusquedaCtaResidente Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmBusquedaCtaResidente();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void BtnCta_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Residente");
                    return;
            }
            if (txtNombre.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un Residente");
                    return;
            }

            caja.frmCtaCteResidente winCtaResi = new caja.frmCtaCteResidente();
            winCtaResi.ParentForm = this;
            winCtaResi.binv = true;
            winCtaResi.idResidente = Convert.ToInt32(txtCodigo.Text);
            winCtaResi.nombreResidente = txtNombre.Text;
            winCtaResi.Ubicacion = txtubicacion.Text;
            winCtaResi.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                dgvResultado.Focus();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.ToString().Length > 0)
                {
                    DataSet ds = new DataSet();
                    ds = cn.TraerDataset("usp_select_tb_residente_like", txtNombre.Text.Trim());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultado.DataSource = ds.Tables[0];
                        dgvResultado.Visible = true;
                        dgvResultado.BringToFront();
                    }
                    else
                    {
                        dgvResultado.Visible = false;
                    }
                }
                else
                {
                    txtCodigo.Clear();
                    dgvResultado.Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    OcultarGrilla();
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvResultado_DoubleClick(object sender, EventArgs e)
        {
            OcultarGrilla();
        }

        private void OcultarGrilla()
        {
            try
            {
                txtCodigo.Text = dgvResultado.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvResultado.CurrentRow.Cells[1].Value.ToString();
                txtubicacion.Text = dgvResultado.CurrentRow.Cells[2].Value.ToString();
                dgvResultado.Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void frmBusquedaCtaResidente_Load(object sender, EventArgs e)
        //{
        //    cargarAnio();
        //}
        //private void cargarAnio()
        //{
        //    try
        //    {
        //        cboAnio.DataSource = cn.TraerDataset("usp_select_anio", 1).Tables[0];
        //        cboAnio.DisplayMember = "intAFDescripcionAnno";
        //        cboAnio.ValueMember = "intAFID";
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
    }
}
