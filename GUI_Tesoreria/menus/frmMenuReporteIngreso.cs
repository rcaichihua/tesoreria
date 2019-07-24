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
            Gerencia.frmIngresoGeneral2 _frmIngresoGeneral2 = null;
            _frmIngresoGeneral2 = Gerencia.frmIngresoGeneral2.Instance();
            _frmIngresoGeneral2.MdiParent = this;
            _frmIngresoGeneral2.TipoReporte = "ResGen";
            _frmIngresoGeneral2.Tipo_Reporte_y = "R";
            _frmIngresoGeneral2.Show();
        }

        private void m_3_1_2_Click(object sender, EventArgs e)
        {
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "DetaCan";
            _frmIngresoGeneral.Tipo_Reporte_y = "D";
            _frmIngresoGeneral.Show();
        }

        private void m_3_2_Click(object sender, EventArgs e)
        {
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "RepGenCem";
            _frmIngresoGeneral.Tipo_Reporte_y = "M";
            _frmIngresoGeneral.Show();
        }

        private void m_3_6_Click(object sender, EventArgs e)
        {
            canevaro.frmReportePagosResidente _frmReportePagosResidente = null;
            _frmReportePagosResidente = canevaro.frmReportePagosResidente.Instance();
            _frmReportePagosResidente.MdiParent = this;
            _frmReportePagosResidente.Show();
        }

        private void m_1_4_Click(object sender, EventArgs e)
        {
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
            this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOFORM.png");
            this.BackgroundImageLayout = ImageLayout.Center;

            tsslUsuario.Text = VariablesMetodosEstaticos.varNombreUser;
            tsslSucursal.Text = VariablesMetodosEstaticos.varNombreSucursal;
            tsslPerfil.Text = VariablesMetodosEstaticos.varNombrePerfil;
            varGlobales.verificaCierre = false;
            habilitarOpcion(); 
        }

        private void m_1_5_Click(object sender, EventArgs e)
        {
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
            Gerencia.frmIngresoGeneral _frmIngresoGeneral = null;
            _frmIngresoGeneral = Gerencia.frmIngresoGeneral.Instance();
            _frmIngresoGeneral.MdiParent = this;
            _frmIngresoGeneral.TipoReporte = "RepST";
            _frmIngresoGeneral.Show();
        }

        private void m_3_1_4_Click(object sender, EventArgs e)
        {
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
            Gerencia.frmIngresosPorCajero _frmIngresosPorCajero = null;
            _frmIngresosPorCajero = Gerencia.frmIngresosPorCajero.Instance();
            _frmIngresosPorCajero.MdiParent = this;
            _frmIngresosPorCajero.Show();
        }

        private void acumuladoPorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerencia.frmIngresoPorCajeroDia _frmIngresoPorCajeroDia = null;
            _frmIngresoPorCajeroDia = Gerencia.frmIngresoPorCajeroDia.Instance();
            _frmIngresoPorCajeroDia.MdiParent = this;
            _frmIngresoPorCajeroDia.Show();
        }

        private void m_1_6_Click(object sender, EventArgs e)
        {
            frmExportarIngresos _frmExportarIngresos = new frmExportarIngresos();
            _frmExportarIngresos.MdiParent = this;
            _frmExportarIngresos.Show();
        }

        private void m_1_2_3_Click(object sender, EventArgs e)
        {
            frmListadoRecibosPrograma _frmListadoRecibosPrograma = new frmListadoRecibosPrograma();
            _frmListadoRecibosPrograma.MdiParent = this;
            _frmListadoRecibosPrograma.Show();
        }

        private void m_1_Click(object sender, EventArgs e)
        {

        }

        private void verificaciónDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caja.Liquidacion_cajas.frmVerificacionLiquidaciones _frmVerif = new caja.Liquidacion_cajas.frmVerificacionLiquidaciones();
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }
        
        private void importarInformaciónAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            Gerencia.frmIngresosPorCajero _frmIngresosPorCajero = null;
            _frmIngresosPorCajero = Gerencia.frmIngresosPorCajero.Instance();
            _frmIngresosPorCajero.MdiParent = this;
            _frmIngresosPorCajero.Text = "...:::Ingreso por Programa:::...";
            _frmIngresosPorCajero.Show();
        }
    }
}
