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

namespace GUI_Tesoreria.mantenimiento
{
    public partial class frmTarifario : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private int index = 0;
        private CNegocio cn = new CNegocio();
        private int xcod;
        private string accion = string.Empty;
        ToolTip toolTip = new ToolTip();

        private varGlobales varglo = new varGlobales();
        private static frmTarifario frmInstance = null;

        public frmTarifario()
        {
            InitializeComponent();
        }

        public static frmTarifario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmTarifario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void frmTarifario_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOCON.png");
            primeraCarga();
            if (dgvTarifario.RowCount > 0) { CargaDatosxId(); }
            habilitaBotones(true);
            varGlobales.habilitarCamposTabControl(this, false, index);
            GeneradorToolTip();
        }
        public void CargaDatosxId()
        {
            try
            {
                int fila;
                if (dgvTarifario.RowCount > 0)
                {
                    fila = dgvTarifario.CurrentRow.Index;
                    xcod = Convert.ToInt16(dgvTarifario.Rows[fila].Cells[1].Value);
                    DataTable dt = new DataTable();
                    dt = cn.TraerDataset("usp_select_grilla_tarifa", xcod, index).Tables[0];
                    if (index == 0)
                    {
                        this.txtRubroNicho.Text = (dt.Rows[0][1].ToString());
                        this.txtDescripcionNicho.Text = (dt.Rows[0][2].ToString());
                        this.cboCementerioNicho.SelectedValue = dt.Rows[0][3].ToString();
                        this.cboServicioNicho.SelectedValue = (dt.Rows[0][4].ToString());
                        this.cboTipoPabellon.SelectedValue = dt.Rows[0][5].ToString();
                        this.cboTipoNicho.SelectedValue = (dt.Rows[0][6].ToString());
                        this.cboNivelNicho.SelectedValue = (dt.Rows[0][7].ToString());
                        this.txtCostoNicho.Text = dt.Rows[0][8].ToString();
                        this.cboMonedaNicho.SelectedValue = dt.Rows[0][9].ToString();
                        this.txtAniosNicho.Text = dt.Rows[0][10].ToString();
                        this.chkPerpetuoNicho.Checked = (Convert.ToBoolean(dt.Rows[0][11]) ? true : false);
                        this.chkActivoNicho.Checked = (Convert.ToBoolean(dt.Rows[0][12]) ? true : false);
                        this.txtIdRubro.Text = dt.Rows[0][13].ToString();
                        this.lblDescripcionNicho.Text = dt.Rows[0][14].ToString();
                        this.cboTipoGrupoNicho.SelectedValue = dt.Rows[0][15].ToString();
                        this.cboTipoMaterial.SelectedValue = dt.Rows[0][16].ToString();
                    }
                    else if (index == 1)
                    {
                        this.txtRubroSepultura.Text = (dt.Rows[0][1].ToString());
                        this.txtDescripcionSepultura.Text = (dt.Rows[0][2].ToString());
                        this.cboCementerioSepultura.SelectedValue = dt.Rows[0][3].ToString();
                        this.cboTipoTumba.SelectedValue = (dt.Rows[0][4].ToString());
                        this.cboServicioSepultura.SelectedValue = dt.Rows[0][5].ToString();
                        this.txtNivelSepultura.Text = (dt.Rows[0][6].ToString());
                        this.cboZonaSepultura.SelectedValue = dt.Rows[0][7].ToString();
                        this.cboTipoSepultura.SelectedValue = dt.Rows[0][8].ToString();
                        this.txtCostoSepultura.Text = dt.Rows[0][9].ToString();
                        this.cboMonedaSepultura.SelectedValue = dt.Rows[0][10].ToString();
                        this.txtAniosSepultura.Text = dt.Rows[0][11].ToString();
                        this.chkPerpetuoSepultura.Checked = (Convert.ToBoolean(dt.Rows[0][12]) ? true : false);
                        this.chkActivoSepultura.Checked = (Convert.ToBoolean(dt.Rows[0][13]) ? true : false);
                        this.txtIdRubro.Text = dt.Rows[0][14].ToString();
                        this.lblDescripcionSepultura.Text = dt.Rows[0][15].ToString();
                        this.cboTipoGrupoSepultura.SelectedValue = dt.Rows[0][16].ToString();
                    }
                    else if (index == 2)
                    {
                        this.txtRubroMausoleo.Text = (dt.Rows[0][1].ToString());
                        this.txtDescripcionMausoleo.Text = (dt.Rows[0][2].ToString());
                        this.cboCementerioMausoleo.SelectedValue = dt.Rows[0][3].ToString();
                        this.cboTipoMausoleo.SelectedValue = (dt.Rows[0][4].ToString());
                        this.cboTipo.SelectedValue = dt.Rows[0][5].ToString();
                        this.txtDimenA.Text = (dt.Rows[0][6].ToString());
                        this.txtDimenB.Text = (dt.Rows[0][7].ToString());
                        this.txtMetrosCuadrados.Text = dt.Rows[0][8].ToString();
                        this.chkPerpetuoMausoleo.Checked = (Convert.ToBoolean(dt.Rows[0][9]) ? true : false);
                        this.chkActivoMausoleo.Checked = (Convert.ToBoolean(dt.Rows[0][10]) ? true : false);
                        this.txtCostoMausoleo.Text = dt.Rows[0][11].ToString();
                        this.cboMonedaMausoleo.SelectedValue = dt.Rows[0][12].ToString();
                        this.txtAniosMausoleo.Text = dt.Rows[0][13].ToString();
                        this.txtIdRubro.Text = dt.Rows[0][14].ToString();
                        this.lblDescripcionMausoleo.Text = dt.Rows[0][15].ToString();
                        this.cboTipoGrupoMausoleo.SelectedValue = dt.Rows[0][16].ToString();
                    }
                    else if (index == 3)
                    {
                        this.txtRubroServicio.Text = (dt.Rows[0][1].ToString());
                        this.txtDescripcionServicio.Text = (dt.Rows[0][2].ToString());
                        this.cboTipoServiciosFunerarios.SelectedValue = dt.Rows[0][3].ToString();
                        this.txtObservacionServicios.Text = (dt.Rows[0][4].ToString());
                        this.chkActivoServicio.Checked = (Convert.ToBoolean(dt.Rows[0][5]) ? true : false);
                        this.txtCostoServicio.Text = dt.Rows[0][6].ToString();
                        this.cboMonedaServicio.SelectedValue = dt.Rows[0][7].ToString();
                        this.txtIdRubro.Text = dt.Rows[0][8].ToString();
                        this.lblDescripcionServicios.Text = dt.Rows[0][9].ToString();
                        this.cboTipoGrupoServiciosOtros.SelectedValue = dt.Rows[0][10].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void primeraCarga()
        {
            index = 0;
            LblTitulo.Text = LblTitulo.Text + " - NICHO";
            //obtenerCuartel();
            obtenerCementerio(0);
            obtenerTipoServicio(0);
            obtenerTipoPabellon();
            obtenerMoneda(0);
            obtenerMoneda(0);
            obtenerNivel(0);
            obtenerTipoNicho();
            cargarTarifario();
            cargarGrupo(index);
            cargarTipoMaterial();
            lblRegistros.Text = dgvTarifario.RowCount.ToString();
        }
        private void cargarTarifario()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tarifa_x_tipo", index + 1).Tables[0];
                dgvTarifario.Refresh();
                dgvTarifario.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cargarTipoMaterial()
        {
            try
            {
                var dt = new DataTable();

                dt = cn.TraerDataset("usp_select_tb_tipoMaterial").Tables[0];
                cboTipoMaterial.DataSource = dt;
                cboTipoMaterial.DisplayMember = "nombreTipoMaterial";
                cboTipoMaterial.ValueMember = "tipoMaterialID";
            }
            catch (Exception)
            {
            }
        }

        private void cargarGrupo(int page)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_tipoGrupo").Tables[0];
                if (page == 0)
                {
                    cboTipoGrupoNicho.DataSource = dt;
                    cboTipoGrupoNicho.DisplayMember = "nombreGrupo";
                    cboTipoGrupoNicho.ValueMember = "tipoGrupoID";
                }
                else if (page == 1)
                {
                    cboTipoGrupoSepultura.DataSource = dt;
                    cboTipoGrupoSepultura.DisplayMember = "nombreGrupo";
                    cboTipoGrupoSepultura.ValueMember = "tipoGrupoID";
                }
                else if (page == 2)
                {
                    cboTipoGrupoMausoleo.DataSource = dt;
                    cboTipoGrupoMausoleo.DisplayMember = "nombreGrupo";
                    cboTipoGrupoMausoleo.ValueMember = "tipoGrupoID";
                }
                else if (page == 3)
                {
                    cboTipoGrupoServiciosOtros.DataSource = dt;
                    cboTipoGrupoServiciosOtros.DisplayMember = "nombreGrupo";
                    cboTipoGrupoServiciosOtros.ValueMember = "tipoGrupoID";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        //private void obtenerCuartel()
        //{
        //    var dt = new DataTable();
        //    try
        //    {
        //        dt = cn.TraerDataset("usp_select_ta_cuartel", index + 1).Tables[0];
        //        dgvTarifario.Refresh();
        //        dgvTarifario.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
        //            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //    }
        //}

        private void GeneradorToolTip()
        {
            toolTip.SetToolTip(this.btnEditar, "Edita el elemento seleccionado");
            toolTip.SetToolTip(this.btnCancelar, "Cancela los posibles cambios sobre el elemento seleccionado");
            toolTip.SetToolTip(this.btnGuardar, "Guarda el registro");
            toolTip.SetToolTip(this.btnEliminar, "Elimina el elemento seleccionado");
            toolTip.SetToolTip(this.btnSalir, "Salir del mantenimiento");
            toolTip.SetToolTip(this.btnNuevo, "Permite ingresar un nuevo elemento");
        }
        private void obtenerCementerio(int page)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "C").Tables[0];
                if (page == 0)
                {
                    cboCementerioNicho.DataSource = dt;
                    cboCementerioNicho.DisplayMember = "varCeNombre";
                    cboCementerioNicho.ValueMember = "intCeId";
                }
                else if (page == 1)
                {
                    cboCementerioSepultura.DataSource = dt;
                    cboCementerioSepultura.DisplayMember = "varCeNombre";
                    cboCementerioSepultura.ValueMember = "intCeId";
                }
                else if (page == 2)
                {
                    cboCementerioMausoleo.DataSource = dt;
                    cboCementerioMausoleo.DisplayMember = "varCeNombre";
                    cboCementerioMausoleo.ValueMember = "intCeId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerTipoServicio(int page)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "S").Tables[0];
                if (page == 0)
                {
                    cboServicioNicho.DataSource = dt;
                    cboServicioNicho.DisplayMember = "varDescipcionServicio";
                    cboServicioNicho.ValueMember = "intTiSId";
                }
                else if (page == 1)
                {
                    cboServicioSepultura.DataSource = dt;
                    cboServicioSepultura.DisplayMember = "varDescipcionServicio";
                    cboServicioSepultura.ValueMember = "intTiSId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerTipoPabellon()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "P").Tables[0];
                cboTipoPabellon.DataSource = dt;
                cboTipoPabellon.DisplayMember = "varTpDescripcion";
                cboTipoPabellon.ValueMember = "intTpId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerServicios()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "F").Tables[0];
                cboTipoServiciosFunerarios.DataSource = dt;
                cboTipoServiciosFunerarios.DisplayMember = "VarServFunDescripcion";
                cboTipoServiciosFunerarios.ValueMember = "intServFunId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerMoneda(int page)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "M").Tables[0];
                if (page == 0)
                {
                    cboMonedaNicho.DataSource = dt;
                    cboMonedaNicho.DisplayMember = "varMoDescripcion";
                    cboMonedaNicho.ValueMember = "intMoId";
                }
                else if (page == 1)
                {
                    cboMonedaSepultura.DataSource = dt;
                    cboMonedaSepultura.DisplayMember = "varMoDescripcion";
                    cboMonedaSepultura.ValueMember = "intMoId";
                }
                else if (page == 2)
                {
                    cboMonedaMausoleo.DataSource = dt;
                    cboMonedaMausoleo.DisplayMember = "varMoDescripcion";
                    cboMonedaMausoleo.ValueMember = "intMoId";
                }
                else if (page == 3)
                {
                    cboMonedaServicio.DataSource = dt;
                    cboMonedaServicio.DisplayMember = "varMoDescripcion";
                    cboMonedaServicio.ValueMember = "intMoId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerNivel(int page)
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "N").Tables[0];
                if (page == 0)
                {
                    cboNivelNicho.DataSource = dt;
                    cboNivelNicho.DisplayMember = "varNivelDescripcion";
                    cboNivelNicho.ValueMember = "intNivelId";
                }
                else if (page == 2)
                {
                    cboTipo.DataSource = dt;
                    cboTipo.DisplayMember = "varNivelDescripcion";
                    cboTipo.ValueMember = "intNivelId";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerTipoNicho()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "T").Tables[0];
                cboTipoNicho.DataSource = dt;
                cboTipoNicho.DisplayMember = "varTipNiDescripcion";
                cboTipoNicho.ValueMember = "intTipNiId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerTipoTumba()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_tb_tipoTumba").Tables[0];
                cboTipoTumba.DataSource = dt;
                cboTipoTumba.DisplayMember = "nombreTipoTumba";
                cboTipoTumba.ValueMember = "tipoTumbaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerZona()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "O").Tables[0];
                cboZonaSepultura.DataSource = dt;
                cboZonaSepultura.DisplayMember = "varZDescripcion";
                cboZonaSepultura.ValueMember = "intZId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerTipoSepultura()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "U").Tables[0];
                cboTipoSepultura.DataSource = dt;
                cboTipoSepultura.DisplayMember = "varTsDescripcion";
                cboTipoSepultura.ValueMember = "intTsId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerTipoMausoleo()
        {
            var dt = new DataTable();
            try
            {
                dt = cn.TraerDataset("usp_select_combo_tarifario", "E").Tables[0];
                cboTipoMausoleo.DataSource = dt;
                cboTipoMausoleo.DisplayMember = "varTipMauDescripcion";
                cboTipoMausoleo.ValueMember = "intTipMauId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -> " + ex.ToString() + "", VariablesMetodosEstaticos.encabezado,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "I";
            habilitaBotones(false);
            varGlobales.habilitarCamposTabControl(this, true, index);
            varGlobales.resetearCamposTabControl(this);
            borrarLabels();
            reiniciarControles();
        }
        private void reiniciarControles()
        {
            if (index == 0)
            {
                txtRubroNicho.Focus();
                chkActivoNicho.Checked = true;
                chkPerpetuoNicho.Checked = false;
                txtCostoNicho.Text = "0.00";
                txtAniosNicho.Text = "0";
            }
            else if (index == 1)
            {
                txtRubroSepultura.Focus();
                chkActivoSepultura.Checked = true;
                chkPerpetuoSepultura.Checked = false;
                txtCostoSepultura.Text = "0.00";
                txtAniosSepultura.Text = "0";
                txtNivelSepultura.Text = "0";
            }
            else if (index == 2)
            {
                txtRubroMausoleo.Focus();
                chkActivoMausoleo.Checked = true;
                chkPerpetuoMausoleo.Checked = false;
                txtDimenA.Text = "0.00";
                txtDimenB.Text = "0.00";
                txtMetrosCuadrados.Text = "0.00";
                txtCostoMausoleo.Text = "0.00";
                txtAniosMausoleo.Text = "0";
            }
            else if (index == 3)
            {
                txtRubroServicio.Focus();
                txtCostoServicio.Text = "0.00";
                chkActivoServicio.Checked = true;
            }
        }
        private void habilitaBotones(bool G)
        {
            btnNuevo.Enabled = G;
            btnGuardar.Enabled = !G;
            btnCancelar.Enabled = !G;
            btnEditar.Enabled = G;
            btnEliminar.Enabled = G;
            dgvTarifario.Enabled = G;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitaBotones(true);
            varGlobales.habilitarCamposTabControl(this, false, index);
            cargarTarifario();
            accion = string.Empty;
            reiniciarControles();
            borrarLabels();
            txtIdRubro.Text = string.Empty;
            dgvTarifario_Click(sender, e);
        }

        private void borrarLabels()
        {
            lblDescripcionMausoleo.Text = string.Empty;
            lblDescripcionNicho.Text = string.Empty;
            lblDescripcionSepultura.Text = string.Empty;
            lblDescripcionServicios.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultDelete = 0;
            if (this.dgvTarifario.RowCount > 0)
            {
                int indice = dgvTarifario.CurrentRow.Index;
                accion = "D";
                try
                {
                    if (accion == "D")
                    {
                        if ((MessageBox.Show("¿Seguro de eliminar el Registro?", VariablesMetodosEstaticos.encabezado,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            if (index == 0)
                            {
                                resultDelete = cn.EjecutarSP("usp_mantenimiento_nicho", dgvTarifario.Rows[indice].Cells[1].Value, "", ""
                                    , 0, 0, 0, 0, 0, true, true, 0.00, 0, 0, "D", "", 0, 0, 0);
                            }
                            else if (index == 1)
                            {
                                resultDelete = cn.EjecutarSP("usp_mantenimiento_sepultura", dgvTarifario.Rows[indice].Cells[1].Value, "", ""
                                    , 0, 0, 0, "", 0, 0, true, true, 0.00, 0, 0, "D", "", 0, 0);
                            }
                            else if (index == 2)
                            {
                                resultDelete = cn.EjecutarSP("usp_mantenimiento_mausoleo", dgvTarifario.Rows[indice].Cells[1].Value, "", ""
                                    , 0, 0, 0, 0.00, 0.00, true, true, 0.00, 0, 0, "D", "", 0, 0);
                            }
                            else if (index == 3)
                            {
                                resultDelete = cn.EjecutarSP("usp_mantenimiento_servicio", dgvTarifario.Rows[indice].Cells[1].Value, "", 0
                                    , "", "", true, 0.00, 0, "D", "", 0, 0);
                            }

                            if (resultDelete == 3)
                            {
                                MessageBox.Show("Eliminado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("No se elimino, verifíque o intente de nuevo", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    btnCancelar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No Existen Datos para eliminar, verifíque", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultadoINgreso = 0;
            int indice = 0;
            Control cont = new Control();
            try
            {
                cont = varGlobales.buscarTextoVacioTabControl(this, index);

                if (cont != null)
                {
                    int TamañoNombre = cont.Name.Length;
                    MessageBox.Show("Falta ingresar o seleccionar " +
                        cont.Name.Substring(3, TamañoNombre - 3) + "");
                    cont.Focus();
                    return;
                }

                if (dgvTarifario.Rows.Count > 0)
                {
                    indice = dgvTarifario.CurrentRow.Index;
                }

                if (VerificaDatoRubro() == false)
                {
                    MessageBox.Show("El codigo de rubro no corresponde a su descripción", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (accion == "I")
                {
                    if ((MessageBox.Show("¿Seguro de ingresar la nueva tarifa ?", VariablesMetodosEstaticos.encabezado,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                    {
                        if (index == 0)
                        {

                            resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_nicho", 0, txtRubroNicho.Text.Trim(), txtDescripcionNicho.Text.Trim()
                            , cboCementerioNicho.SelectedValue, cboServicioNicho.SelectedValue, cboTipoPabellon.SelectedValue
                            , cboTipoNicho.SelectedValue, cboNivelNicho.SelectedValue, chkPerpetuoNicho.Checked, chkActivoNicho.Checked
                            , txtCostoNicho.Text.Trim(), cboMonedaNicho.SelectedValue, txtAniosNicho.Text.Trim()
                            , "I", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text, cboTipoGrupoNicho.SelectedValue,
                            cboTipoMaterial.SelectedValue).Tables[0].Rows[0][0]);
                        }
                        else if (index == 1)
                        {
                            resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_sepultura", 0, txtRubroSepultura.Text.Trim(), txtDescripcionSepultura.Text.Trim()
                            , cboCementerioSepultura.SelectedValue, cboTipoTumba.SelectedValue, cboServicioSepultura.SelectedValue
                            , txtNivelSepultura.Text.Trim(), cboZonaSepultura.SelectedValue, cboTipoSepultura.SelectedValue
                            , chkPerpetuoSepultura.Checked, chkActivoSepultura.Checked, txtCostoSepultura.Text.Trim(), cboMonedaSepultura.SelectedValue
                            , txtAniosSepultura.Text.Trim(), "I", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text
                            , cboTipoGrupoSepultura.SelectedValue).Tables[0].Rows[0][0]);
                        }
                        else if (index == 2)
                        {
                            resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_mausoleo", 0, txtRubroMausoleo.Text.Trim(), txtDescripcionMausoleo.Text.Trim()
                                , cboCementerioMausoleo.SelectedValue, cboTipoMausoleo.SelectedValue, cboTipo.SelectedValue
                                , txtDimenA.Text.Trim(), txtDimenB.Text.Trim(), chkPerpetuoMausoleo.Checked, chkActivoMausoleo.Checked,
                                txtCostoMausoleo.Text.Trim(), cboMonedaMausoleo.SelectedValue, txtAniosMausoleo.Text.Trim()
                                , "I", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text
                                , cboTipoGrupoMausoleo.SelectedValue).Tables[0].Rows[0][0]);
                        }
                        else if (index == 3)
                        {
                            resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_servicio", 0, txtRubroServicio.Text.Trim(), cboTipoServiciosFunerarios.SelectedValue
                                , txtDescripcionServicio.Text.Trim(), txtObservacionServicios.Text, chkActivoServicio.Checked,
                                txtCostoServicio.Text.Trim(), cboMonedaServicio.SelectedValue
                                , "I", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text
                                , cboTipoGrupoServiciosOtros.SelectedValue).Tables[0].Rows[0][0]);
                        }
                        if (resultadoINgreso == 1)
                        {
                            MessageBox.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error en le ingreso. contacte con sistemas.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else if (accion == "U")
                {
                    if (index == 0)
                    {
                        resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_nicho", dgvTarifario.Rows[indice].Cells[1].Value, txtRubroNicho.Text.Trim(), txtDescripcionNicho.Text.Trim()
                            , cboCementerioNicho.SelectedValue, cboServicioNicho.SelectedValue, cboTipoPabellon.SelectedValue
                            , cboTipoNicho.SelectedValue, cboNivelNicho.SelectedValue, chkPerpetuoNicho.Checked, chkActivoNicho.Checked
                            , txtCostoNicho.Text.Trim(), cboMonedaNicho.SelectedValue, txtAniosNicho.Text.Trim()
                            , "U", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text, cboTipoGrupoNicho.SelectedValue,
                            cboTipoMaterial.SelectedValue).Tables[0].Rows[0][0]);
                    }
                    else if (index == 1)
                    {
                        resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_sepultura", dgvTarifario.Rows[indice].Cells[1].Value, txtRubroSepultura.Text.Trim(), txtDescripcionSepultura.Text.Trim()
                            , cboCementerioSepultura.SelectedValue, cboTipoTumba.SelectedValue, cboServicioSepultura.SelectedValue
                            , txtNivelSepultura.Text.Trim(), cboZonaSepultura.SelectedValue, cboTipoSepultura.SelectedValue
                            , chkPerpetuoSepultura.Checked, chkActivoSepultura.Checked, txtCostoSepultura.Text.Trim(), cboMonedaSepultura.SelectedValue
                            , txtAniosSepultura.Text.Trim(), "U", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text
                            , cboTipoGrupoSepultura.SelectedValue).Tables[0].Rows[0][0]);
                    }
                    else if (index == 2)
                    {
                        resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_mausoleo", dgvTarifario.Rows[indice].Cells[1].Value, txtRubroMausoleo.Text.Trim(), txtDescripcionMausoleo.Text.Trim()
                            , cboCementerioMausoleo.SelectedValue, cboTipoMausoleo.SelectedValue, cboTipo.SelectedValue
                            , txtDimenA.Text.Trim(), txtDimenB.Text.Trim(), chkPerpetuoMausoleo.Checked, chkActivoMausoleo.Checked,
                            txtCostoMausoleo.Text.Trim(), cboMonedaMausoleo.SelectedValue, txtAniosMausoleo.Text.Trim()
                            , "U", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text, cboTipoGrupoMausoleo.SelectedValue).Tables[0].Rows[0][0]);
                    }
                    else if (index == 3)
                    {
                        resultadoINgreso = Convert.ToInt32(cn.TraerDataset("usp_mantenimiento_servicio", dgvTarifario.Rows[indice].Cells[1].Value, txtRubroServicio.Text.Trim(), cboTipoServiciosFunerarios.SelectedValue
                            , txtDescripcionServicio.Text.Trim(), txtObservacionServicios.Text, chkActivoServicio.Checked,
                            txtCostoServicio.Text.Trim(), cboMonedaServicio.SelectedValue
                            , "U", VariablesMetodosEstaticos.varNombreUser, txtIdRubro.Text, cboTipoGrupoServiciosOtros.SelectedValue).Tables[0].Rows[0][0]);
                    }

                    if (resultadoINgreso == 1)
                    {
                        MessageBox.Show("Actualizado correctamente", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al actualizar. contacte con sistemas.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                btnCancelar_Click(sender, e);
                accion = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte con sistema, error" + ex.Message + "", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTarifario_Click(object sender, EventArgs e)
        {
            if (dgvTarifario.RowCount > 0)
            {
                CargaDatosxId();
            }
            else
            {
                varGlobales.resetearCamposTabControl(this);
                reiniciarControles();
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (accion != string.Empty)
            {
                e.Cancel = true;
            }
            else
            {
                if (this.tabControl1.SelectedIndex == 0)
                {
                    index = 0;
                    LblTitulo.Text = "MANTENIMIENTO - TARIFARIO / NICHO";
                    obtenerCementerio(0);
                    obtenerTipoServicio(0);
                    obtenerTipoPabellon();
                    obtenerMoneda(0);
                    obtenerMoneda(0);
                    obtenerNivel(0);
                    obtenerTipoNicho();
                    cargarGrupo(index);
                }
                else if (this.tabControl1.SelectedIndex == 1)
                {
                    index = 1;
                    LblTitulo.Text = "MANTENIMIENTO - TARIFARIO / SEPULTURA";
                    obtenerCementerio(1);
                    obtenerTipoTumba();
                    obtenerTipoServicio(1);
                    obtenerZona();
                    obtenerTipoSepultura();
                    obtenerMoneda(1);
                    cargarGrupo(index);
                }
                else if (this.tabControl1.SelectedIndex == 2)
                {
                    index = 2;
                    LblTitulo.Text = "MANTENIMIENTO - TARIFARIO / MAUSOLEO";
                    obtenerCementerio(2);
                    obtenerTipoMausoleo();
                    obtenerMoneda(2);
                    obtenerNivel(2);
                    cargarGrupo(index);
                }
                else if (this.tabControl1.SelectedIndex == 3)
                {
                    index = 3;
                    LblTitulo.Text = "MANTENIMIENTO - TARIFARIO / SERVICIO";
                    obtenerMoneda(3);
                    obtenerServicios();
                    cargarGrupo(index);                 
                }
                cargarTarifario();
                lblRegistros.Text = dgvTarifario.RowCount.ToString();
                dgvTarifario_Click(sender, e);
            }

        }

        private void chkPerpetuoNicho_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPerpetuoNicho.Checked)
            {
                txtAniosNicho.Text = "0";
            }
        }

        private void txtCostoMausoleo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Decimales_KeyPress(sender, e);
        }

        private void txtAniosMausoleo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void txtDimenA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMetrosCuadrados.Text = (Convert.ToDecimal(txtDimenA.Text) * Convert.ToDecimal(txtDimenB.Text)).ToString("###.##");
            }
            catch (Exception)
            {

            }
        }

        private void chkPerpetuoSepultura_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPerpetuoSepultura.Checked)
            {
                txtAniosSepultura.Text = "0";
            }
        }

        private void chkPerpetuoMausoleo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPerpetuoMausoleo.Checked)
            {
                txtAniosMausoleo.Text = "0";
            }
        }

        private void txtDimenB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMetrosCuadrados.Text = (Convert.ToDecimal(txtDimenA.Text) * Convert.ToDecimal(txtDimenB.Text)).ToString("###.##");
            }
            catch (Exception)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvTarifario.RowCount > 0)
            {
                accion = "U";
                if (index == 0)
                {
                    txtRubroNicho.Focus();
                }
                else if (index == 1)
                {
                    txtRubroSepultura.Focus();
                }
                else if (index == 2)
                {
                    txtRubroMausoleo.Focus();
                }
                else if (index == 3)
                {
                    txtRubroServicio.Focus();
                }
                habilitaBotones(false);
                varGlobales.habilitarCamposTabControl(this, true, index);
            }
            else
            {
                MessageBox.Show("No Existen Datos para Modificar, verifique",
                    VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvTarifario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvTarifario_Click(sender, e);
        }

        private void btnBuscarNicho_Click(object sender, EventArgs e)
        {
            llamarFiltro();
        }

        private void txtRubroNicho_TextChanged(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);
        }

        private void txtRubroNicho_KeyPress(object sender, KeyPressEventArgs e)
        {
            VariablesMetodosEstaticos.Numeros_KeyPress(sender, e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarRubro();
            }
        }

        private void buscarRubro()
        {
            DataTable dtFilter = new DataTable();
            if (index == 0)
            {
                if (txtRubroNicho.Text.Trim() != string.Empty)
                {
                    dtFilter = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroNicho.Text.Trim(), "", "1").Tables[0];

                    if (dtFilter.Rows.Count > 0)
                    {
                        txtIdRubro.Text = dtFilter.Rows[0][0].ToString();
                        lblDescripcionNicho.Text = dtFilter.Rows[0][2].ToString();
                    }
                    else
                    {
                        llamarFiltro();
                    }
                }
                else
                {
                    llamarFiltro();
                }
            }
            else if (index == 1)
            {
                if (txtRubroSepultura.Text.Trim() != string.Empty)
                {
                    dtFilter = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroSepultura.Text.Trim(), "", "1").Tables[0];

                    if (dtFilter.Rows.Count > 0)
                    {
                        txtIdRubro.Text = dtFilter.Rows[0][0].ToString();
                        lblDescripcionSepultura.Text = dtFilter.Rows[0][2].ToString();
                    }
                    else
                    {
                        llamarFiltro();
                    }
                }
                else
                {
                    llamarFiltro();
                }
            }
            else if (index == 2)
            {
                if (txtRubroMausoleo.Text.Trim() != string.Empty)
                {
                    dtFilter = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroMausoleo.Text.Trim(), "", "1").Tables[0];

                    if (dtFilter.Rows.Count > 0)
                    {
                        txtIdRubro.Text = dtFilter.Rows[0][0].ToString();
                        lblDescripcionMausoleo.Text = dtFilter.Rows[0][2].ToString();
                    }
                    else
                    {
                        llamarFiltro();
                    }
                }
                else
                {
                    llamarFiltro();
                }
            }
            else if (index == 3)
            {
                if (txtRubroServicio.Text.Trim() != string.Empty)
                {
                    dtFilter = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroServicio.Text.Trim(), "", "1").Tables[0];

                    if (dtFilter.Rows.Count > 0)
                    {
                        txtIdRubro.Text = dtFilter.Rows[0][0].ToString();
                        lblDescripcionServicios.Text = dtFilter.Rows[0][2].ToString();
                    }
                    else
                    {
                        llamarFiltro();
                    }
                }
                else
                {
                    llamarFiltro();
                }
            }
        }

        private void llamarFiltro()
        {
            frmFiltroRubros winFiltros = new frmFiltroRubros();
            winFiltros.ParentForm = this;
            winFiltros.index = index;
            winFiltros.ShowDialog();
        }

        public void asignarValoresCampoRubros(int id, string codigo, string descripcion)
        {
            txtIdRubro.Text = id.ToString();

            switch (index)
            {
                case 0:
                    txtRubroNicho.Text = codigo;
                    lblDescripcionNicho.Text = descripcion; break;
                case 1:
                    txtRubroSepultura.Text = codigo;
                    lblDescripcionSepultura.Text = descripcion; break;
                case 2:
                    txtRubroMausoleo.Text = codigo;
                    lblDescripcionMausoleo.Text = descripcion; break;
                case 3:
                    txtRubroServicio.Text = codigo;
                    lblDescripcionServicios.Text = descripcion; break;
            }
        }

        private bool VerificaDatoRubro()
        {
            DataTable dtVeri = new DataTable();

            switch (index)
            {
                case 0:
                    dtVeri = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroNicho.Text.Trim(), "", 1).Tables[0];
                    return (dtVeri.Rows.Count > 0) ? ((txtIdRubro.Text == dtVeri.Rows[0][0].ToString()) ? true : false) : false;
                case 1:
                    dtVeri = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroSepultura.Text.Trim(), "", 1).Tables[0];
                    return (dtVeri.Rows.Count > 0) ? ((txtIdRubro.Text == dtVeri.Rows[0][0].ToString()) ? true : false) : false;
                case 2:
                    dtVeri = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroMausoleo.Text.Trim(), "", 1).Tables[0];
                    return (dtVeri.Rows.Count > 0) ? ((txtIdRubro.Text == dtVeri.Rows[0][0].ToString()) ? true : false) : false;
                case 3:
                    dtVeri = cn.TraerDataset("usp_buscar_rubro_x_cod_nombre", txtRubroServicio.Text.Trim(), "", 1).Tables[0];
                    return (dtVeri.Rows.Count > 0) ? ((txtIdRubro.Text == dtVeri.Rows[0][0].ToString()) ? true : false) : false;

                default: return false;
            }
        }

        private void bntBuscarSepultura_Click(object sender, EventArgs e)
        {
            llamarFiltro();
        }

        private void btnBuscarMausoleo_Click(object sender, EventArgs e)
        {
            llamarFiltro();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            llamarFiltro();
        }
    }
}
