using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;
using GUI_Tesoreria.Gerencia;

namespace GUI_Tesoreria.menus
{
    public partial class frmMenuReporteIngreso : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private varGlobales varglo = new varGlobales();
        private CNegocio cn = new CNegocio();
        public string tipo_reporte_x;

        public frmMenuReporteIngreso()
        {
            InitializeComponent();
        }

        private void frmMenuReporteIngreso_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOFORM.png");
            this.BackgroundImageLayout = ImageLayout.Center;

            tsslUsuario.Text = VariablesMetodosEstaticos.varNombreUser;
            tsslSucursal.Text = VariablesMetodosEstaticos.varNombreSucursal;
            tsslPerfil.Text = VariablesMetodosEstaticos.varNombrePerfil;
            varGlobales.verificaCierre = false;
            habilitarOpcion();
        }

        private void habilitarOpcion()
        {
            DataTable DtOpcionesXPerfil = new DataTable();
            bool lstrHabilitar;
            string lstrOpcion;
            MenuStrip menu = new MenuStrip();

            DtOpcionesXPerfil = cn.TraerDataset("usp_verifica_acceso_x_perfil_x_menu",
                VariablesMetodosEstaticos.intPerfilID, VariablesMetodosEstaticos.menuPrincipalID, VariablesMetodosEstaticos.subMenuPrincipalID).Tables[0];

            foreach (DataRow DrOpcionSistema in DtOpcionesXPerfil.Rows)
            {
                lstrOpcion = DrOpcionSistema[0].ToString().Trim();
                if (DrOpcionSistema[1] == null)
                {
                    lstrHabilitar = false;
                }
                else
                {
                    lstrHabilitar = Convert.ToBoolean(DrOpcionSistema[1].ToString());
                    RecorrerEstructuraMenu(menuStrip1, lstrOpcion, lstrHabilitar);
                }
            }
        }
        private void RecorrerEstructuraMenu(MenuStrip oMenu, string nombre_menu, bool habilitar)
        {
            foreach (ToolStripMenuItem oOpcionMenu in oMenu.Items)
            {
                if (oOpcionMenu.Name == nombre_menu)
                {
                    oOpcionMenu.Visible = habilitar;
                    break;
                }
                if (oOpcionMenu.DropDownItems.Count > 0)
                {
                    RecorrerSubmenu(oOpcionMenu.DropDownItems, nombre_menu, habilitar);
                }
            }
        }
        private void RecorrerSubmenu(ToolStripItemCollection oSubmenuItems, string nombre_menu, bool habilitar)
        {
            try
            {
                foreach (ToolStripMenuItem oSubitem2 in oSubmenuItems)
                {
                    if (oSubitem2.Name == nombre_menu)
                    {
                        oSubitem2.Visible = habilitar;
                        break;
                    }
                    if (oSubitem2.DropDownItems.Count > 0)
                    {
                        RecorrerSubmenu(oSubitem2.DropDownItems, nombre_menu, habilitar);

                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.ToString());
            }

        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            control.frmLogin login = new control.frmLogin();
            login.Show();
        }

        private void IrAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void SalirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que desea salir del Sistema?";
            string caption = "...:::Salir del Sistema:::...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void m_2_1_Click(object sender, EventArgs e)
        {
            caja.frmRecibosIngreso _frmRecibosIngreso = null;
            _frmRecibosIngreso = caja.frmRecibosIngreso.Instance();
            _frmRecibosIngreso.MdiParent = this;
            _frmRecibosIngreso.Show();
        }

        private void m_3_1_1_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoGeneral2 _frmIngresoGeneral2 = null;
            _frmIngresoGeneral2 = Gerencia.frmIngresoGeneral2.Instance();
            _frmIngresoGeneral2.MdiParent = this;
            _frmIngresoGeneral2.TipoReporte = "ResGen";
            _frmIngresoGeneral2.Tipo_Reporte_y = "R";
            _frmIngresoGeneral2.Show();
        }

        private void m_3_1_2_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "DetaCan";
            _frmIngresoGeneral.Tipo_Reporte_y = "D";
            _frmIngresoGeneral.Show();
        }

        private void m_3_2_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "RepGenCem";
            _frmIngresoGeneral.Tipo_Reporte_y = "M";
            _frmIngresoGeneral.Show();
        }

        private void m_3_6_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            canevaro.frmReportePagosResidente _frmReportePagosResidente = null;
            _frmReportePagosResidente = canevaro.frmReportePagosResidente.Instance();
            _frmReportePagosResidente.MdiParent = this;
            _frmReportePagosResidente.Show();
        }

        private void m_1_4_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoGeneral2 _frmIngresoGeneral2 = null;
            _frmIngresoGeneral2 = Gerencia.frmIngresoGeneral2.Instance();
            _frmIngresoGeneral2.MdiParent = this;
            _frmIngresoGeneral2.TipoReporte = "consulta";
            _frmIngresoGeneral2.Show();
        }

        private void m_2_2_1_Click(object sender, EventArgs e)
        {
            Contabilidad.frmMantenimientoDepositos _frmMantenimientoDepositos = null;
            _frmMantenimientoDepositos = Contabilidad.frmMantenimientoDepositos.Instance();
            _frmMantenimientoDepositos.MdiParent = this;
            _frmMantenimientoDepositos.Show();
        }

        private void frmMenuReporteIngreso_Load_1(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOFORM.png");
            //this.BackgroundImageLayout = ImageLayout.Center;
            //if (VariablesMetodosEstaticos.intPerfilID==7 || VariablesMetodosEstaticos.intPerfilID == 8)
            //{
            //    m_1.Visible = false;
            //    m_3.Visible = false;
            //}
            //else
            //{
            //    toolStripMenuItem6.Visible = false;
            //    m_2.Visible = false;
            //}
            tsslUsuario.Text = VariablesMetodosEstaticos.varNombreUser;
            tsslSucursal.Text = VariablesMetodosEstaticos.varNombreSucursal;
            tsslPerfil.Text = VariablesMetodosEstaticos.varNombrePerfil;
            varGlobales.verificaCierre = false;
            habilitarOpcion(); 
        }

        private void m_1_5_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "RegVouchers";
            _frmIngresoGeneral.Tipo_Reporte_y = "R";
            _frmIngresoGeneral.Show();
        }

        private void frmMenuReporteIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            //ir al menu principal
            if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
                //IrAlMenuToolStripMenuItem_Click(sender, e);
            }
            //ir la menu principal
            if (e.Control && e.KeyCode == Keys.M)
            {
                this.Close();
                IrAlMenuToolStripMenuItem_Click(sender, e);
            }
            //cerrar sesion
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.Close();
                CerrarSesionToolStripMenuItem_Click(sender, e);
            }
            //salir del sistema
            if (e.Control && e.KeyCode == Keys.Q)
            {
                SalirDelSistemaToolStripMenuItem_Click(sender, e);
            }
        }

        private void m_3_1_3_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "RepST";
            _frmIngresoGeneral.Show();
        }

        private void m_3_1_4_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "RepSR";
            _frmIngresoGeneral.Show();
        }

        private void frmMenuReporteIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (varGlobales.verificaCierre == false)
            {
                string message = "Esta seguro que desea salir del Sistema?";
                string caption = "...:::Salir del Sistema:::...";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    Application.Exit();
                }
                else if (varGlobales.verificaCierre == false)
                {
                    e.Cancel = true;
                }
            }
        }

        private void m_1_1_Click(object sender, EventArgs e)
        {
            //Gerencia.frmIngresosPorCajero _frmIngresosPorCajero = null;
            //_frmIngresosPorCajero = Gerencia.frmIngresosPorCajero.Instance();
            //_frmIngresosPorCajero.MdiParent = this;
            //_frmIngresosPorCajero.Text = "...:::Ingreso por Programa:::...";
            //_frmIngresosPorCajero.Show();
        }

        private void m_4_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmCambioContrasenaUsuario _frmCambioContrasenaUsuario = null;
            _frmCambioContrasenaUsuario = mantenimiento.frmCambioContrasenaUsuario.Instance();
            _frmCambioContrasenaUsuario.MdiParent = this;
            _frmCambioContrasenaUsuario.Show();
        }

        private void acumuladoPorCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresosPorCajero _frmIngresosPorCajero = null;
            _frmIngresosPorCajero = Gerencia.frmIngresosPorCajero.Instance();
            _frmIngresosPorCajero.MdiParent = this;
            _frmIngresosPorCajero.Show();
        }

        private void acumuladoPorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Gerencia.frmIngresoPorCajeroDia _frmIngresoPorCajeroDia = null;
            _frmIngresoPorCajeroDia = Gerencia.frmIngresoPorCajeroDia.Instance();
            _frmIngresoPorCajeroDia.MdiParent = this;
            _frmIngresoPorCajeroDia.Show();
        }

        private void m_1_6_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            frmExportarIngresos _frmExportarIngresos = new frmExportarIngresos();
            _frmExportarIngresos.MdiParent = this;
            _frmExportarIngresos.Show();
        }

        private void m_1_2_3_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            frmListadoRecibosPrograma _frmListadoRecibosPrograma = new frmListadoRecibosPrograma();
            _frmListadoRecibosPrograma.MdiParent = this;
            _frmListadoRecibosPrograma.Show();
        }

        private void m_1_Click(object sender, EventArgs e)
        {

        }

        private void verificaciónDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.Liquidacion_cajas.frmVerificacionLiquidaciones _frmVerif = new caja.Liquidacion_cajas.frmVerificacionLiquidaciones();
            _frmVerif.Acceso = true;
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }
        
        private void importarInformaciónAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmImportarInformacionAPI _frmVerif = new caja.Liquidacion_cajas.frmImportarInformacionAPI();
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }

        private void ingresoVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caja.frmIngresoVouchers _frmReporteResidentes = null;
            _frmReporteResidentes = caja.frmIngresoVouchers.Instance();
            _frmReporteResidentes.idCajeroIngresoVouchers = VariablesMetodosEstaticos.idcajausuario;
            _frmReporteResidentes.habilita = 1;
            _frmReporteResidentes.MdiParent = this;
            _frmReporteResidentes.Show();
        }

        private void listadoVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito.frmListadoDepositosGeneral _frmListadoDepositosGeneral = null;
            _frmListadoDepositosGeneral = Deposito.frmListadoDepositosGeneral.Instance();
            _frmListadoDepositosGeneral.MdiParent = this;
            _frmListadoDepositosGeneral.Show();
        }

        private void prepararComprobanteDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito.frmPreparaComprobanteDiario _frmfrmPreparaComprobanteDiario = null;
            _frmfrmPreparaComprobanteDiario = Deposito.frmPreparaComprobanteDiario.Instance();
            _frmfrmPreparaComprobanteDiario.MdiParent = this;
            _frmfrmPreparaComprobanteDiario.Show();
        }

        private void listarComprobanteDeDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito.frmListarComprobanteDiario _frmListarComprobanteDiario = null;
            _frmListarComprobanteDiario = Deposito.frmListarComprobanteDiario.Instance();
            _frmListarComprobanteDiario.MdiParent = this;
            _frmListarComprobanteDiario.Show();
        }

        private void editarComprobanteDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito.frmEdicionCompDiario _frmEdicionCompDiario = null;
            _frmEdicionCompDiario = Deposito.frmEdicionCompDiario.Instance();
            _frmEdicionCompDiario.MdiParent = this;
            _frmEdicionCompDiario.Show();
        }

        private void reporteDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.frmIngresosporRubroCta _frmEdicionCompDiario = null;
            _frmEdicionCompDiario = caja.frmIngresosporRubroCta.Instance();
            _frmEdicionCompDiario.MdiParent = this;
            _frmEdicionCompDiario.Show();
        }

        private void reporteResumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerencia.frmIngresosPorCajero _frmIngresosPorCajero = null;
            _frmIngresosPorCajero = Gerencia.frmIngresosPorCajero.Instance();
            _frmIngresosPorCajero.MdiParent = this;
            _frmIngresosPorCajero.Text = "...:::Ingreso por Programa:::...";
            _frmIngresosPorCajero.Show();
        }

        private void reportePorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerencia.frmIngresoPorDiaPrograma _frmIngresosPorCajero = null;
            _frmIngresosPorCajero = Gerencia.frmIngresoPorDiaPrograma.Instance();
            _frmIngresosPorCajero.MdiParent = this;
            _frmIngresosPorCajero.Text = "...:::Ingreso por Programa diario:::...";
            _frmIngresosPorCajero.Show();
        }

        private void m_1_1_Click_1(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            Gerencia.frmIngresosPorCajero _frmIngresosPorCajero = null;
            _frmIngresosPorCajero = Gerencia.frmIngresosPorCajero.Instance();
            _frmIngresosPorCajero.MdiParent = this;
            _frmIngresosPorCajero.Text = "...:::Ingreso por Programa:::...";
            _frmIngresosPorCajero.Show();
        }

        private void altaDirecciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.Contable.frmDiario _frmDiario = null;
            _frmDiario = caja.Contable.frmDiario.Instance();
            _frmDiario.MdiParent = this;
            _frmDiario.gbDiario.Text = "ASIENTO DE DIARIO - ALTA DIRECCION";
            _frmDiario.CodPrograma_ = 1;
            _frmDiario.Show();
        }

        private void alberguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Contable.frmDiario _frmDiario = null;
            _frmDiario = caja.Contable.frmDiario.Instance();
            _frmDiario.MdiParent = this;
            _frmDiario.gbDiario.Text = "ASIENTO DE DIARIO - ALBERGUES";
            _frmDiario.CodPrograma_ = 2;
            _frmDiario.Show();
        }

        private void inmobiliariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Contable.frmDiario _frmDiario = null;
            _frmDiario = caja.Contable.frmDiario.Instance();
            _frmDiario.MdiParent = this;
            _frmDiario.gbDiario.Text = "ASIENTO DE DIARIO - INMOBILIARIA";
            _frmDiario.CodPrograma_ = 3;
            _frmDiario.Show();
        }

        private void cementerioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Contable.frmDiario _frmDiario = null;
            _frmDiario = caja.Contable.frmDiario.Instance();
            _frmDiario.MdiParent = this;
            _frmDiario.gbDiario.Text = "ASIENTO DE DIARIO - CEMENTERIO";
            _frmDiario.CodPrograma_ = 4;
            _frmDiario.Show();
        }

        private void cierreDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmListaLiquidacionesCierre _frmListaLiquidacionesCierre = null;
            _frmListaLiquidacionesCierre = caja.Liquidacion_cajas.frmListaLiquidacionesCierre.Instance();
            _frmListaLiquidacionesCierre.MdiParent = this;
            _frmListaLiquidacionesCierre.Show(); 
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito.frmMigraDiario _frmListadoDepositosGeneral = null;
            _frmListadoDepositosGeneral = Deposito.frmMigraDiario.Instance();
            _frmListadoDepositosGeneral.MdiParent = this;
            _frmListadoDepositosGeneral.Show();
        }

        private void m_2_1_Click_1(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.frmIngresosporRubroCta _frmEdicionCompDiario = null;
            _frmEdicionCompDiario = caja.frmIngresosporRubroCta.Instance();
            _frmEdicionCompDiario.MdiParent = this;
            _frmEdicionCompDiario.Show();
        }

        private void m_2_2_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmReporteIngresosInmobiliaria _frmVerif = new caja.Liquidacion_cajas.frmReporteIngresosInmobiliaria();
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.frmIngresoVouchers _frmReporteResidentes = null;
            _frmReporteResidentes = caja.frmIngresoVouchers.Instance();
            _frmReporteResidentes.idCajeroIngresoVouchers = VariablesMetodosEstaticos.idcajausuario;
            _frmReporteResidentes.habilita = 1;
            _frmReporteResidentes.MdiParent = this;
            _frmReporteResidentes.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            Deposito.frmListadoDepositosGeneral _frmListadoDepositosGeneral = null;
            _frmListadoDepositosGeneral = Deposito.frmListadoDepositosGeneral.Instance();
            _frmListadoDepositosGeneral.MdiParent = this;
            _frmListadoDepositosGeneral.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Deposito.frmPreparaComprobanteDiario _frmfrmPreparaComprobanteDiario = null;
            _frmfrmPreparaComprobanteDiario = Deposito.frmPreparaComprobanteDiario.Instance();
            _frmfrmPreparaComprobanteDiario.MdiParent = this;
            _frmfrmPreparaComprobanteDiario.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Deposito.frmEdicionCompDiario _frmEdicionCompDiario = null;
            _frmEdicionCompDiario = Deposito.frmEdicionCompDiario.Instance();
            _frmEdicionCompDiario.MdiParent = this;
            _frmEdicionCompDiario.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Deposito.frmListarComprobanteDiario _frmListarComprobanteDiario = null;
            _frmListarComprobanteDiario = Deposito.frmListarComprobanteDiario.Instance();
            _frmListarComprobanteDiario.MdiParent = this;
            _frmListarComprobanteDiario.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                if (VariablesMetodosEstaticos.varUsuario != "EPOQUIOMA")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                                   MessageBoxIcon.Warning);
                    return;
                }
            }

            if (VariablesMetodosEstaticos.varUsuario != "EPOQUIOMA")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            Deposito.frmMigraDiario _frmListadoDepositosGeneral = null;
            _frmListadoDepositosGeneral = Deposito.frmMigraDiario.Instance();
            _frmListadoDepositosGeneral.MdiParent = this;
            _frmListadoDepositosGeneral.Show();
        }

        private void reporteIngresosPorModalidadYCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Contable.frmDiarioIngresosModalidadPago _frmListadoDepositosGeneral = new caja.Contable.frmDiarioIngresosModalidadPago();
            _frmListadoDepositosGeneral.MdiParent = this;
            _frmListadoDepositosGeneral.Show();
        }

        private void m_1_7_1_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.Depositos.frmReporteBancoPorPrograma _frmReporteBancoPorPrograma = null;
            _frmReporteBancoPorPrograma = new caja.Depositos.frmReporteBancoPorPrograma(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorPrograma.MdiParent = this;
            _frmReporteBancoPorPrograma.Show();
        }

        private void porBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Depositos.frmReporteBancoPorBanco _frmReporteBancoPorBanco = null;
            _frmReporteBancoPorBanco = new caja.Depositos.frmReporteBancoPorBanco(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorBanco.MdiParent = this;
            _frmReporteBancoPorBanco.Show();
        }

        private void detraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Depositos.frmReporteBancoPorDetraccion _frmReporteBancoPorBanco = new caja.Depositos.frmReporteBancoPorDetraccion(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorBanco.MdiParent = this;
            _frmReporteBancoPorBanco.Show();
        }

        private void generacionDeGlosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Deposito.frmGeneracionGlosa _frmReporteBancoPorBanco = new Deposito.frmGeneracionGlosa(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorBanco.MdiParent = this;
            _frmReporteBancoPorBanco.Show();
        }

        private void recibosDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmVerificacionLiquidaciones _frmVerif = new caja.Liquidacion_cajas.frmVerificacionLiquidaciones();
            _frmVerif.Acceso = false;
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }

        private void regularizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Deposito.frmReporteRegularizacion _frmVerif = new Deposito.frmReporteRegularizacion();
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Depositos.frmReporteBancoPorPrograma _frmReporteBancoPorPrograma = null;
            _frmReporteBancoPorPrograma = new caja.Depositos.frmReporteBancoPorPrograma(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorPrograma.MdiParent = this;
            _frmReporteBancoPorPrograma.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Depositos.frmReporteBancoPorBanco _frmReporteBancoPorBanco = null;
            _frmReporteBancoPorBanco = new caja.Depositos.frmReporteBancoPorBanco(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorBanco.MdiParent = this;
            _frmReporteBancoPorBanco.Show();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Depositos.frmReporteBancoPorDetraccion _frmReporteBancoPorBanco = new caja.Depositos.frmReporteBancoPorDetraccion(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorBanco.MdiParent = this;
            _frmReporteBancoPorBanco.Show();
        }

        private void interesesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            Deposito.frmReporteRegularizacion _frmVerif = new Deposito.frmReporteRegularizacion();
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }

        private void cierreDeLiquidacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmListaLiquidacionesCierre _frmListaLiquidacionesCierre = null;
            _frmListaLiquidacionesCierre = caja.Liquidacion_cajas.frmListaLiquidacionesCierre.Instance();
            _frmListaLiquidacionesCierre.MdiParent = this;
            _frmListaLiquidacionesCierre.Show();
        }

        private void listadoDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmListadoLiquidacion _frmGeneraLiquidacion = null;
            _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmListadoLiquidacion.Instance();
            _frmGeneraLiquidacion.MdiParent = this;
            _frmGeneraLiquidacion.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 & VariablesMetodosEstaticos.intPerfilID != 8)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmFiltroFechaIngresos _frmGeneraLiquidacion = null;
            _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmFiltroFechaIngresos.Instance();
            _frmGeneraLiquidacion.MdiParent = this;
            _frmGeneraLiquidacion.Show();
        }

        private void m_1_3_Click(object sender, EventArgs e)
        {

        }

        private void cajaAltaDirecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void m_3_5_Click(object sender, EventArgs e)
        {

        }

        private void m_3_3_Click(object sender, EventArgs e)
        {

        }

        private void modificaciónDeDetalleDeRecibosDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.frmListadoParaEdicionDetalleReciboAD _frmListadoRecibosPrograma = new caja.frmListadoParaEdicionDetalleReciboAD();
            _frmListadoRecibosPrograma.MdiParent = this;
            _frmListadoRecibosPrograma.Show();
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                if (VariablesMetodosEstaticos.varUsuario != "EPOQUIOMA")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    return;
                }
            }

            Contabilidad.Diario.frmGenerarAsientoAltaDireccion _frmDiario = null;
            _frmDiario = Contabilidad.Diario.frmGenerarAsientoAltaDireccion.Instance();
            _frmDiario.MdiParent = this;
            _frmDiario.gbDiario.Text = "ASIENTO DE DIARIO - ALTA DIRECCION";
            _frmDiario.CodPrograma_ = 1;
            _frmDiario.Show();
        }

        private void imprimirAsientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6)
            {
                if (VariablesMetodosEstaticos.varUsuario != "EPOQUIOMA")
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void cuentasGubYEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 8 && VariablesMetodosEstaticos.intPerfilID != 7)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            mantenimiento.frmCuentasEmpresariales _frmListadoRecibosPrograma = new mantenimiento.frmCuentasEmpresariales();
            _frmListadoRecibosPrograma.MdiParent = this;
            _frmListadoRecibosPrograma.Show();
        }
    }
}
