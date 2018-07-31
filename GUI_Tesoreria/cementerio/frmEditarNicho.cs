using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.cementerio
{
    public partial class frmEditarNicho : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();

        public string codCuartel { get; set; }
        public string letraFila { get; set; }
        public int numColumna { get; set; }
        public string material { get; set; }
        public string tipoCuartel { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }

        public frmEditarNicho()
        {
            InitializeComponent();
        }

        private void frmEditarNicho_Load(object sender, EventArgs e)
        {
            llenarMaterial();
            llenarEstado();
            txtCodigoCuartel.Text = codCuartel;
            txtFila.Text = letraFila;
            txtColumna.Text = numColumna.ToString();
            cboMaterial.Text = material;
            txtTipoCuartel.Text = tipoCuartel;
            cboEstado.Text = estado;
            txtObservacion.Text = observacion;
            txtFila.Text = letraFila;        
        }

        private void llenarMaterial()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODMATERIAL,NOMBREMATERIAL from cementerio.MATERIAL").Tables[0];
                cboMaterial.DataSource = dt;
                cboMaterial.DisplayMember = "NOMBREMATERIAL";
                cboMaterial.ValueMember = "CODMATERIAL";
            }
            catch (Exception)
            {
            }
        }
        private void llenarEstado()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODESTADO,DESCRIPESTADO from cementerio.ESTADO").Tables[0];
                cboEstado.DataSource = dt;
                cboEstado.DisplayMember = "DESCRIPESTADO";
                cboEstado.ValueMember = "CODESTADO";
            }
            catch (Exception)
            {
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.EjecutarSP("usp_actualizar_nicho", txtCodigoCuartel.Text, txtFila.Text, txtColumna.Text,
                    cboMaterial.SelectedValue, cboEstado.SelectedValue, txtObservacion.Text) > 0)
                {
                    MessageBox.Show("Actualizado correctamente.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error. Intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
