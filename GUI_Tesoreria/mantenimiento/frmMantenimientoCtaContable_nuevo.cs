using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmMantenimientoCtaContable_nuevo : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        CNegocio cn = new CNegocio();
        private static frmMantenimientoCtaContable_nuevo frmInstance = null;
        public frmMantenimientoCtaContable_nuevo()
        {
            InitializeComponent();
        }

        public static frmMantenimientoCtaContable_nuevo Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmMantenimientoCtaContable_nuevo();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmMantenimientoCtaContable_nuevo_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dgvCta.DataSource = cn.TraerDataset("usp_select_tb_cta_contable",VariablesMetodosEstaticos.AnioFiscal).Tables[0];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmMantContable win = new frmMantContable();
            win.TipoMant = "N";
            win.ShowDialog();
            if (win.Save_)
            {
                Cargar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCta.CurrentRow!=null)
            {
                int index;
                DataTable dtRow;

                index = this.dgvCta.CurrentRow.Index;

                
                if (this.dgvCta.Rows[index].Cells["movimiento"].Value.ToString()=="")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No se puede editar la cuenta seleccionada.", VariablesMetodosEstaticos.encabezado,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    frmMantContable win = new frmMantContable();
                    win.IdCta = Convert.ToInt32(this.dgvCta.Rows[index].Cells["id_cuenta_contable"].Value);

                    dtRow = cn.TraerDataset("usp_cta_busca", win.IdCta).Tables[0];
                    win.IdEstrucutura = Convert.ToInt32(dtRow.Rows[0][0].ToString());
                    win.IdElemento = Convert.ToInt32(dtRow.Rows[0][1].ToString());
                    win.Movimiento = dtRow.Rows[0][2].ToString();
                    win.DescripCuenta = dtRow.Rows[0][3].ToString();
                    win.Codigo1 = dtRow.Rows[0][4].ToString();
                    win.Codigo2 = dtRow.Rows[0][5].ToString();
                    win.IdGestion = Convert.ToInt32(dtRow.Rows[0][6].ToString());
                    win.TipoMant = "U";
                    win.ShowDialog();
                    if (win.Save_)
                    {
                        Cargar();
                    }
                }              
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
