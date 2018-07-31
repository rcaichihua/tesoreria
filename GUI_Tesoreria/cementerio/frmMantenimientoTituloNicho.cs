using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using BE_Tesoreria;
using System.Data.SqlTypes;

namespace GUI_Tesoreria.cementerio
{
    public partial class frmMantenimientoTituloNicho : DevComponents.DotNetBar.Metro.MetroForm
    {
        CNegocio cn = new CNegocio();
        
        int fila_difunto = 0;
        public string CodPebellon { get; set; }
        public string LetraFilaNicho { get; set; }
        public int NumeroColNicho { get; set; }
        public DataTable DtDifuntos { get; set; }
        public string EstadoNicho { get; set; }
        public int idTituloNicho { get; set; }
        //DataGridViewCellStyle styFecha;

        public frmMantenimientoTituloNicho()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenimientoTituloNicho_Load(object sender, EventArgs e)
        {
            cboEsatado.SelectedIndex = 0;
            LlenarMotivo();
            LlenarCabeceraUbicacion();
            LlenarDifunto();
            FormatoFecha();
        }

        private void FormatoFecha()
        {
            mtbFechaInhumacion.Mask = "00/00/0000";
            mtbFechaInhumacion.ValidatingType = typeof(System.DateTime);
            mtbFechaInhumacion.TypeValidationCompleted += new TypeValidationEventHandler(mtbFechaInhumacion_TypeValidationCompleted);

            mtbFechaConcesion.Mask = "00/00/0000";
            mtbFechaConcesion.ValidatingType = typeof(System.DateTime);
            mtbFechaConcesion.TypeValidationCompleted += new TypeValidationEventHandler(mtbFechaConcesion_TypeValidationCompleted);
        }

        private void mtbFechaConcesion_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (mtbFechaConcesion.Text != "__/__/____")
            {
                if (!e.IsValidInput || this.mtbFechaConcesion.MaskedTextProvider.AssignedEditPositionCount != 8)
                {
                    e.Cancel = true;
                    MessageBox.Show("Formato no valido");
                    mtbFechaConcesion.Focus();
                }
            }
            e.Cancel = false;
        }

        private void mtbFechaInhumacion_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (mtbFechaInhumacion.Text != "__/__/____")
            {
                if (!e.IsValidInput || this.mtbFechaInhumacion.MaskedTextProvider.AssignedEditPositionCount != 8)
                {
                    e.Cancel = true;
                    MessageBox.Show("Formato no valido");
                    mtbFechaInhumacion.Focus();
                }
            }
            e.Cancel = false;
        }

        private void LlenarMotivo()
        {
            cboMotivo.DataSource = cn.EjecutarSqlDTS("SELECT IDMOTIVO,NOMBREMOTIVO FROM cementerio.MOTIVOANULACIONTITULO").Tables[0];
            cboMotivo.DisplayMember = "NOMBREMOTIVO";
            cboMotivo.ValueMember = "IDMOTIVO";
        }

        private void LlenarCabeceraUbicacion()
        {
            DataTable Dt;
            Dt = new DataTable();
            Dt = cn.TraerDataset("USP_MUESTRA_UBICACION_NICHO_TITULO", CodPebellon, LetraFilaNicho, NumeroColNicho).Tables[0];
            if (Dt.Rows.Count > 0)
            {
                txtCodCementerio.Text = Dt.Rows[0][0].ToString();
                txtCementerio.Text = Dt.Rows[0][1].ToString();
                txtCodCuartel.Text = Dt.Rows[0][2].ToString();
                txtCuartel.Text = Dt.Rows[0][3].ToString();
                txtMaterial.Text = Dt.Rows[0][4].ToString();
                txtNumero.Text = Dt.Rows[0][5].ToString();
                txtLetra.Text = Dt.Rows[0][6].ToString();
            }
        }

        private void LlenarDifunto()
        {
            if (EstadoNicho=="RESERVADO EN VIDA")
            {
                foreach (DataRow row in DtDifuntos.Rows)
                {
                    if (row[3].ToString()!="")
                    {
                        row[3] = "";
                    }
                }
            }
            dgvDifuntos.DataSource = DtDifuntos;
        }

        private void cboEsatado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEsatado.Text == "ANULADO")
            {
                gbMotivo.Enabled = true;
                return;
            }
            gbMotivo.Enabled = false;
        }

        private void dgvDifuntos_MouseClick(object sender, MouseEventArgs e)
        {
            fila_difunto = 0;

            if (e.Button == MouseButtons.Left)
            {

            }
            else
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int posicion_xy_mouse_fila = dgvDifuntos.HitTest(e.X, e.Y).RowIndex;

                //MessageBox.Show(posicion_xy_mouse_fila.ToString());
                if (posicion_xy_mouse_fila >= 0)
                {
                    fila_difunto = posicion_xy_mouse_fila;
                    my_menu.Items.Add("&Editar").Name = "btnEditar";
                }

                my_menu.Show(dgvDifuntos, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
            }
        }
        void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridViewRow row = dgvDifuntos.Rows[fila_difunto];

            switch (e.ClickedItem.Name.ToString())
            {
                case "btnEditar":
                    if (cboEsatado.SelectedIndex == 0)
                    {
                        MessageBox.Show("Seleccione un estado");
                        cboEsatado.Focus();
                        return;
                    }
                    cementerio.frmEditarDifuntoNichoTitutlo frm = new cementerio.frmEditarDifuntoNichoTitutlo();
                    frm.TipoResto = dgvDifuntos.Rows[dgvDifuntos.CurrentRow.Index].Cells[0].Value.ToString();
                    if (dgvDifuntos.Rows[dgvDifuntos.CurrentRow.Index].Cells[3].Value.ToString() == "")
                    {
                        frm.Finhumacion = null;
                    }
                    else
                    {
                        frm.Finhumacion = Convert.ToDateTime(dgvDifuntos.Rows[dgvDifuntos.CurrentRow.Index].Cells[3].Value.ToString());
                    }
                    frm.Estado = cboEsatado.Text;
                    frm.ShowDialog();
                    if (frm.Marca == "1")
                    {
                        if (frm.Finhumacion == null)
                        {
                            dgvDifuntos.Rows[fila_difunto].Cells["FECHAINHUMACION"].Value = "";
                        }
                        else
                        {
                            dgvDifuntos.Rows[fila_difunto].Cells["FECHAINHUMACION"].Value = frm.Finhumacion.Value.ToShortDateString();
                        }
                        
                        dgvDifuntos.Rows[fila_difunto].Cells["NOMBRERESTOS"].Value = frm.TipoResto;
                    }
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
            {
                return;
            }

            try
            {
                DataSet ds = new DataSet();

                TituloNichoNegocio TiNiNe = new TituloNichoNegocio();
                if (TiNiNe.ExisteTituloNichoPorNicho(txtCodCuartel.Text, txtLetra.Text, Convert.ToInt32(txtNumero.Text)))
                {
                    MessageBox.Show("Los datos ya fueron ingresados anteriormente.");
                    //TituloNicho TiNi = new TituloNicho();
                    //TiNi.ESTADO = cboEsatado.Text;
                    //TiNi.NUMEROTITULO = txtNroTitulo.Text;
                    //TiNi.NUMERODOCUMENTOVENTA = txtNroDocumento.Text;
                    //TiNi.CEMENTERIO = txtCementerio.Text;
                    //TiNi.CODCUARTEL = txtCodCuartel.Text;
                    //TiNi.NOMBRECUARTEL = txtCuartel.Text;
                    //TiNi.NUMEROCOLNICHO = Convert.ToInt32(txtNumero.Text);
                    //TiNi.LETRAFILANICHO = txtLetra.Text;
                    //TiNi.NOMBRERESPONSABLE = txtResponsable.Text;
                    //TiNi.ANULADO = "0";
                    //TiNi.FECHAINHUMACION = Convert.ToDateTime(mtbFechaInhumacion.Text == "  /  /" ? null : mtbFechaInhumacion.Text);
                    //TiNi.FECHACONCESION = Convert.ToDateTime(mtbFechaConcesion.Text == "  /  /" ? null : mtbFechaConcesion.Text);
                    //TiNi.IDMOTIVO = Convert.ToInt32(cboMotivo.SelectedValue);
                    //TiNi.OBSERVACIONMOTIVO = txtObservacion.Text;
                    //TiNi.GENEROTITULO = chkGeneroNicho.Checked;
                    //TiNi.RECOGIOTITULO = rdbSi.Checked ? true : (rdbNo.Checked ? false : true);
                    //TiNi.USUARIOMOD = VariablesMetodosEstaticos.id_user;
                    //TiNi.FECHAMOD = DateTime.Now;

                    //TiNiNe.EditarTituloNicho(TiNi);
                    return;
                }
                DateTime fechaInhu;
                DateTime? fechaInhu_NULL;

                DateTime fechaConce;
                DateTime? fechaConce_NULL;

                if (DateTime.TryParse(mtbFechaInhumacion.Text, out fechaInhu))
                {
                    fechaInhu_NULL = fechaInhu;
                }

                else
                {
                    if (mtbFechaInhumacion.Text.Trim() == "__/__/____")
                    {
                        fechaInhu_NULL = null;
                    }
                    else
                    {
                        MessageBox.Show("El valor instroducido : (" + mtbFechaInhumacion.Text + ") no es valido. Favor instroducir un valor valido");
                        mtbFechaInhumacion.Focus();
                        return;
                    }
                }

                if (DateTime.TryParse(mtbFechaConcesion.Text, out fechaConce))
                {
                    fechaConce_NULL = fechaInhu;
                }

                else
                {
                    if (mtbFechaConcesion.Text.Trim() == "__/__/____")
                    {
                        fechaConce_NULL = null;
                    }
                    else
                    {
                        MessageBox.Show("El valor instroducido : (" + mtbFechaConcesion.Text + ") no es valido. Favor instroducir un valor valido");
                        mtbFechaConcesion.Focus();
                        return;
                    }
                }
                ds = cn.IngresaTituloNicho("USP_INGRESO_TITULO_NICHO", txtCodCuartel.Text, txtLetra.Text, Convert.ToInt32(txtNumero.Text)
                  , VariablesMetodosEstaticos.id_user, cboEsatado.Text, txtNroTitulo.Text, txtNroDocumento.Text, txtResponsable.Text.Trim()
                  //, Convert.ToDateTime(mtbFechaInhumacion.Text.Trim() == "/  /" ? "01/01/1753" : mtbFechaInhumacion.Text)
                  , fechaInhu_NULL
                  //, Convert.ToDateTime(mtbFechaConcesion.Text.Trim() == "/  /" ? "01/01/1753" : mtbFechaConcesion.Text)
                  , fechaConce_NULL
                  , Convert.ToInt32(gbMotivo.Enabled == false ? null : cboMotivo.SelectedValue)
                  , txtObservacion.Text, chkGeneroNicho.Checked, rdbSi.Checked ? true : (rdbNo.Checked ? false : true)
                  , txtCementerio.Text, txtCuartel.Text, rdbTemporal.Checked ? Convert.ToInt32(txtAniosTemporal.Text) : 1000, 
                  rdbTemporal.Checked ? '0' : '1', DtDifuntos,txtMaterial.Text.Trim());

                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Ingresado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error.");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
                 
        }
        

        //DateTime objdte = new DateTime(1000, 1, 1);
        //dte.ToSafeDbDateDBnull();
        private bool Validacion()
        {
            if (cboEsatado.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un estado");
                cboEsatado.Focus();
                return false;
            }
            if (txtNroTitulo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el Nro de Titulo");
                txtNroTitulo.Focus();
                return false;
            }
            if (txtNroDocumento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese Nro de Documento");
                txtNroDocumento.Focus();
                return false;
            }
            if (txtResponsable.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese al responsable");
                txtResponsable.Focus();
                return false;
            }
            if (dgvDifuntos.RowCount <= 0)
            {
                MessageBox.Show("No hay beneficiarios registrados");
                return false;
            }
            //if (mtbFechaConcesion.Text == "  /  /")
            //{
            //    MessageBox.Show("Ingrese la fecha de concesión");
            //    mtbFechaConcesion.Focus();
            //    return false;
            //}
            if (rdbTemporal.Checked)
            {
                if(txtAniosTemporal.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Ingrese los años para temporal.");
                    txtAniosTemporal.Focus();
                    return false;
                }
            }

            if (cboEsatado.Text=="RESERVADO EN VIDA")
            {
                if (dgvDifuntos.RowCount>1)
                {
                    MessageBox.Show("No se puede ingresar mas de dos difuntos cuando cuando se encuentra en estado RESERVADO EN VIDA");
                    return false;
                }
                foreach (DataGridViewRow row in dgvDifuntos.Rows)
                {
                    if (row.Cells[3].Value.ToString()!="")
                    {
                        MessageBox.Show("No se puede ingresar fecha de inhumacion cuando se encuentra en estado RESERVADO EN VIDA");
                        return false;
                    }
                }
            }
            //DateTime dateValue;
            //bool FlagFecha = false;

            //foreach (DataGridViewRow row in dgvDifuntos.Rows)
            //{
            //    if (!DateTime.TryParse(row.Cells[3].Value.ToString(), out dateValue))
            //    {
            //        FlagFecha = true;
            //    }
            //}

            //if (FlagFecha == false && mtbFechaInhumacion.Text == "  /  /")
            //{
            //    MessageBox.Show("Ingrese una fecha de Inhumacion valida.");
            //    return false;
            //}
            return true;
        }

        private void chkGeneroNicho_CheckedChanged(object sender, EventArgs e)
        {
            gbRecogio.Enabled = chkGeneroNicho.Checked;
        }

        private void drbPerpetuo_CheckedChanged(object sender, EventArgs e)
        {
            txtAniosTemporal.Enabled = !rdbPerpetuo.Checked;
            txtAniosTemporal.Clear();
        }

        private void rdbTemporal_CheckedChanged(object sender, EventArgs e)
        {
            txtAniosTemporal.Enabled = rdbTemporal.Checked;
            txtAniosTemporal.Clear();
            txtAniosTemporal.Focus();
        }

        private void txtAniosTemporal_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }
    }
}
