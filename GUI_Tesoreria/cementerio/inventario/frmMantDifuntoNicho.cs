using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.cementerio.inventario
{
    public partial class frmMantDifuntoNicho : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        public int idNichoInventario { get; set; }
        public int idDifuntoNichoInventario { get; set; }
        public string fila { get; set; }
        public int columna { get; set; }
        public string nombres { get; set; }
        public string codTipoRestos { get; set; }
        public string apellidos { get; set; }
        public DateTime? fechaFallec { get; set; }
        public string observacion { get; set; }
        public string tipoMant { get; set; }
        public string Genero { get; set; }

        public frmMantDifuntoNicho()
        {
            InitializeComponent();
        }

        private void frmMantDifuntoNicho_Load(object sender, EventArgs e)
        {
            llenarComboRestos();
            cboRestos.SelectedIndex = 2;
            txtFila.Text = fila;
            txtColumna.Text = columna.ToString();
            if (tipoMant != "Nuevo")
            {
                cboRestos.Text = codTipoRestos;
                txtNombres.Text = nombres;
                txtApellidos.Text = apellidos;
                if (fechaFallec == null)
                {
                    dtpFecha.Value = DateTime.Now;
                    dtpFecha.Enabled = false;
                    chkFecha.Checked = true;
                }
                else
                {
                    dtpFecha.Value = fechaFallec.Value;
                }      
                txtObservacion.Text = observacion;
                if (Genero=="F") {
                    chkFemenino.Checked = true;
                }
            }
        }

        private void llenarComboRestos()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.EjecutarSqlDTS("select CODTIPORESTOS,NOMBRERESTOS from cementerio.TIPORESTOS").Tables[0];
                cboRestos.DataSource = dt;
                cboRestos.DisplayMember = "NOMBRERESTOS";
                cboRestos.ValueMember = "CODTIPORESTOS";
            }
            catch (Exception)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            try
            {
                if (tipoMant == "Nuevo")
                {

                    if (cn.EjecutarSP("usp_DIFUNTONICHOINVENTARIOInsertar", idNichoInventario, cboRestos.SelectedValue
                    , txtNombres.Text, txtApellidos.Text, dtpFecha.Enabled ? dtpFecha.Value.ToShortDateString() : null
                    , txtObservacion.Text,chkMasculino.Checked ? "M" : "F") > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Los datos fueron guardados correctamente.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (tipoMant=="Editar")
                {
                    if (cn.EjecutarSP("usp_DIFUNTONICHOINVENTARIOActualizar", idDifuntoNichoInventario, cboRestos.SelectedValue
                    , txtNombres.Text, txtApellidos.Text, dtpFecha.Enabled ? dtpFecha.Value.ToShortDateString() : null
                    , txtObservacion.Text, chkMasculino.Checked ? "M" : "F") > 0)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Los datos fueron actualizados correctamente.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            catch (Exception)
            {
            }           
        }

        bool Validar()
        {
            if (txtNombres.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el nombre del difunto");
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text.Trim() == string.Empty)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese los apellidos del difunto");
                txtApellidos.Focus();
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked)
            {
                dtpFecha.Enabled = false;
            }
            else
            {
                dtpFecha.Enabled = true;
            }
        }
    }
}
