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
    public partial class frmMantDifuntoMausoleo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public int idMousoleoInventario { get; set; }
        public int idDifuntoMausoleo { get; set; }
        public string familia { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime? fechaFallec { get; set; }
        public string observacion { get; set; }
        public string tipoMant { get; set; }
        public string Genero { get; set; }

        CNegocio cn = new CNegocio();

        public frmMantDifuntoMausoleo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantDifuntoMausoleo_Load(object sender, EventArgs e)
        {
            if (tipoMant == "Nuevo")
            {
                txtFamilia.Text = familia;
                txtNombres.Focus();
            }
            else
            {
                txtFamilia.Text = familia;
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
                if (Genero == "F")
                {
                    chkFemenino.Checked = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }

            try
            {
                if (tipoMant == "Nuevo")
                {
                    if (cn.EjecutarSP("usp_DIFUNTOMAUSOLEOINVENTARIOInsertar", idMousoleoInventario
                    , txtNombres.Text, txtApellidos.Text, dtpFecha.Enabled ? dtpFecha.Value.ToShortDateString() : null
                    , txtObservacion.Text,chkMasculino.Checked ? "M" : "F") > 0)
                    {
                        MessageBox.Show("Los datos fueron guardados correctamente.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (tipoMant == "Editar")
                {
                    if (cn.EjecutarSP("usp_DIFUNTOMAUSOLEOINVENTARIOActualizar", idDifuntoMausoleo
                    , txtNombres.Text, txtApellidos.Text, dtpFecha.Enabled ? dtpFecha.Value.ToShortDateString() : null,
                    txtObservacion.Text, chkMasculino.Checked ? "M" : "F") > 0)
                    {
                        MessageBox.Show("Los datos fueron actualizados correctamente.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado
                               , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            catch (Exception)
            {
            }  
        }
        bool validar()
        {
            if (txtNombres.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el nombre del difunto");
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese los apellidos del difunto");
                txtApellidos.Focus();
                return false;
            }
            return true;
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
