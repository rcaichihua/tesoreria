using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using System.Globalization;

namespace GUI_Tesoreria.cementerio
{
    public partial class frmEditarDifuntoNichoTitutlo : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        public string TipoResto { get; set; }
        public DateTime? Finhumacion { get; set; }
        public string Marca { get; set; }
        public string Estado { get; set; }
        string formatted="";

        public frmEditarDifuntoNichoTitutlo()
        {
            InitializeComponent();
        }

        private void frmEditarDifuntoNichoTitutlo_Load(object sender, EventArgs e)
        {
            cboTipoResto.DataSource = cn.EjecutarSqlDTS("SELECT CODTIPORESTOS,NOMBRERESTOS from cementerio.TIPORESTOS").Tables[0];
            cboTipoResto.DisplayMember = "NOMBRERESTOS";
            cboTipoResto.ValueMember = "CODTIPORESTOS";

            mtbFechaInhumacion.Mask = "00/00/0000";
            mtbFechaInhumacion.ValidatingType = typeof(System.DateTime);
            mtbFechaInhumacion.TypeValidationCompleted += new TypeValidationEventHandler(mtbFechaConcesion_TypeValidationCompleted);

            cboTipoResto.Text = TipoResto;
            if (Finhumacion == null)
            {
                mtbFechaInhumacion.Text = "  /  /";
                return;
            }
            DateTime dateValue;

            if (DateTime.TryParse(Finhumacion.ToString(), out dateValue))
            {
                formatted = dateValue.ToString("dd/MM/yyyy");
            }

            DateTime dt = DateTime.ParseExact(formatted, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            string s = dt.ToString("dd/MM/yyyy");
            mtbFechaInhumacion.Text =s;

            Marca = "0";
        }
        private void mtbFechaConcesion_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            //if (!e.IsValidInput || this.mtbFechaInhumacion.MaskedTextProvider.AssignedEditPositionCount != 8)
            //{
            //    e.Cancel = true;
            //    DevComponents.DotNetBar.MessageBoxEx.Show("Formato no valido");
            //    mtbFechaInhumacion.Focus();
            //}

            if (mtbFechaInhumacion.Text != "  /  /")
            {
                if (!e.IsValidInput || this.mtbFechaInhumacion.MaskedTextProvider.AssignedEditPositionCount != 8)
                {
                    e.Cancel = true;
                    DevComponents.DotNetBar.MessageBoxEx.Show("Formato no valido");
                    mtbFechaInhumacion.Focus();
                }
            }
            e.Cancel = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Estado == "INHUMADO")
            {
                if (mtbFechaInhumacion.Text == "  /  /")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la fecha de Inhumacion");
                    mtbFechaInhumacion.Focus();
                    return;
                }
            }
            if (Estado == "RESERVADO EN VIDA")
            {
                if (mtbFechaInhumacion.Text != "  /  /")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No se puede asignar una fecha de inhumacion cuando se encuentra en estado RESERVADO EN VIDA");
                    mtbFechaInhumacion.Focus();
                    return;
                }
            }
            Marca = "1";
            if (mtbFechaInhumacion.Text == "  /  /")
            {
                Finhumacion = null;
            }
            else
            {
                Finhumacion = Convert.ToDateTime(mtbFechaInhumacion.Text);
            }
            
            TipoResto = cboTipoResto.Text;
            this.Close();
        }
    }
}
