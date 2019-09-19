using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAO_Tesoreria;
using BL_Tesoreria;
using System.Windows.Forms;

namespace GUI_Tesoreria.menus
{
    public partial class frmMenuConfiguracion : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private varGlobales varglo = new varGlobales();
        private CNegocio cd = new CNegocio();

        public frmMenuConfiguracion()
        {
            InitializeComponent();
        }
        //cierra sesion
        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            control.frmLogin login = new control.frmLogin();
            login.Show();
            
        }

        //ir al menu principal
        private void IrAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        //salir del sistema
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
        private void frmMenuConfiguracion_KeyDown(object sender, KeyEventArgs e)
        {
            //ir al menu principal
            if (e.KeyCode == Keys.Escape) {
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
            if (e.Control && e.KeyCode == Keys.S) { 
            this.Close();
                CerrarSesionToolStripMenuItem_Click(sender, e);
            }
            //salir del sistema
            if (e.Control && e.KeyCode == Keys.Q)
            {
                SalirDelSistemaToolStripMenuItem_Click(sender, e);
            }
        }
        private void frmMenuConfiguracion_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOFORM.png");
            //this.BackgroundImageLayout = ImageLayout.Center;

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

        DtOpcionesXPerfil = cd.TraerDataset("usp_verifica_acceso_x_perfil_x_menu", 
            VariablesMetodosEstaticos.intPerfilID,VariablesMetodosEstaticos.menuPrincipalID,VariablesMetodosEstaticos.subMenuPrincipalID).Tables[0];

          foreach (DataRow DrOpcionSistema in DtOpcionesXPerfil.Rows)
	        {
              lstrOpcion = DrOpcionSistema[0].ToString().Trim();
            if (DrOpcionSistema[1]==null) {
                lstrHabilitar = false;
            }
            else{
                lstrHabilitar = Convert.ToBoolean(DrOpcionSistema[1].ToString());
                RecorrerEstructuraMenu(menuStrip1, lstrOpcion, lstrHabilitar);
	            }
            }
        }
        private void RecorrerEstructuraMenu(MenuStrip oMenu , string nombre_menu, bool habilitar){
            foreach (ToolStripMenuItem oOpcionMenu in oMenu.Items)
	            {
            		 if (oOpcionMenu.Name == nombre_menu) {
                        oOpcionMenu.Visible = habilitar;
                        break;
                     }
                    if (oOpcionMenu.DropDownItems.Count > 0) {
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
            catch (Exception ex )
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.ToString());
            }
            
        }
       
        private void m_3_3_Click(object sender, EventArgs e)
        { 
            usuario.frmAccesoPorPerfil  _frmAccesoPorPerfil = null;
            _frmAccesoPorPerfil = usuario.frmAccesoPorPerfil.Instance();

            _frmAccesoPorPerfil.MdiParent = this;
            _frmAccesoPorPerfil.Show();
        }

        private void frmMenuConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void m_3_4_Click(object sender, EventArgs e)
        {
            mantenimiento.frmUsuario _frmUsuario  = null;
            _frmUsuario = mantenimiento.frmUsuario.Instance();

            _frmUsuario.MdiParent = this;
            _frmUsuario.Show();
        }

        private void m_3_2_Click(object sender, EventArgs e)
        {
            mantenimiento.frmPerfil _frmPerfil = null;
            _frmPerfil = mantenimiento.frmPerfil.Instance();

            _frmPerfil.MdiParent = this;
            _frmPerfil.Show();
        }

        private void m_3_5_Click(object sender, EventArgs e)
        {
            mantenimiento.frmSucursal _frmSucursal = null;
            _frmSucursal = mantenimiento.frmSucursal.Instance();

            _frmSucursal.MdiParent = this;
            _frmSucursal.Show();
        }

        private void m_3_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMenus _frmMenus = null;
            _frmMenus = mantenimiento.frmMenus.Instance();

            _frmMenus.MdiParent = this;
            _frmMenus.Show();
        }

        private void m_2_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmRubros _frmRubros = null;
            _frmRubros = mantenimiento.frmRubros.Instance();

            _frmRubros.MdiParent = this;
            _frmRubros.Show();
        }

        private void m_2_6_Click(object sender, EventArgs e)
        {
            mantenimiento.frmTarifario _frmTarifario = null;
            _frmTarifario = mantenimiento.frmTarifario.Instance();

            _frmTarifario.MdiParent = this;
            _frmTarifario.Show();
        }

        private void m_2_6_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmTarifario _frmTarifario = null;
            _frmTarifario = mantenimiento.frmTarifario.Instance();

            _frmTarifario.MdiParent = this;
            _frmTarifario.Show();
        }

        private void m_2_2_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTiposDocVenta _frmMantTiposDocVenta = null;
            _frmMantTiposDocVenta = mantenimiento.frmMantTiposDocVenta.Instance();

            _frmMantTiposDocVenta.MdiParent = this;
            _frmMantTiposDocVenta.Show();
        }

        private void m_2_6_6_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantCementerio _frmMantCementerio = null;
            _frmMantCementerio = mantenimiento.frmMantCementerio.Instance();

            _frmMantCementerio.MdiParent = this;
            _frmMantCementerio.Show();
        }

        private void m_2_10_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantMoneda _frmMantMoneda = null;
            _frmMantMoneda = mantenimiento.frmMantMoneda.Instance();

            _frmMantMoneda.MdiParent = this;
            _frmMantMoneda.Show();
        }

        private void m_2_6_2_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoServicio _frmMantTipoServicio = null;
            _frmMantTipoServicio = mantenimiento.frmMantTipoServicio.Instance();

            _frmMantTipoServicio.MdiParent = this;
            _frmMantTipoServicio.Show();
        }

        private void m_2_6_2_2_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantPabellon _frmMantPabellon = null;
            _frmMantPabellon = mantenimiento.frmMantPabellon.Instance();

            _frmMantPabellon.MdiParent = this;
            _frmMantPabellon.Show();
        }

        private void m_2_6_2_3_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoNicho _frmMantTipoNicho = null;
            _frmMantTipoNicho = mantenimiento.frmMantTipoNicho.Instance();

            _frmMantTipoNicho.MdiParent = this;
            _frmMantTipoNicho.Show();
        }

        private void m_2_6_3_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoZona _frmMantTipoZona = null;
            _frmMantTipoZona = mantenimiento.frmMantTipoZona.Instance();

            _frmMantTipoZona.MdiParent = this;
            _frmMantTipoZona.Show();
        }

        private void m_2_6_3_2_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoServicio _frmMantTipoServicio = null;
            _frmMantTipoServicio = mantenimiento.frmMantTipoServicio.Instance();

            _frmMantTipoServicio.MdiParent = this;
            _frmMantTipoServicio.Show();
        }

        private void m_2_6_3_3_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantZona _frmMantZona  = null;
            _frmMantZona = mantenimiento.frmMantZona.Instance();

            _frmMantZona.MdiParent = this;
            _frmMantZona.Show();
        }

        private void m_2_6_3_4_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoSepultura _frmMantTipoSepultura = null;
            _frmMantTipoSepultura = mantenimiento.frmMantTipoSepultura.Instance();

            _frmMantTipoSepultura.MdiParent = this;
            _frmMantTipoSepultura.Show();
            
        }

        private void m_2_6_4_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoMausoleo _frmMantTipoMausoleo = null;
            _frmMantTipoMausoleo = mantenimiento.frmMantTipoMausoleo.Instance();

            _frmMantTipoMausoleo.MdiParent = this;
            _frmMantTipoMausoleo.Show();
        }

        private void m_2_6_5_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoServFunerario _frmMantTipoServFunerario = null;
            _frmMantTipoServFunerario = mantenimiento.frmMantTipoServFunerario.Instance();

            _frmMantTipoServFunerario.MdiParent = this;
            _frmMantTipoServFunerario.Show();
        }

        private void m_2_3_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantModalidadPago _frmMantModalidadPago = null;
            _frmMantModalidadPago = mantenimiento.frmMantModalidadPago.Instance();

            _frmMantModalidadPago.MdiParent = this;
            _frmMantModalidadPago.Show();
        }

        private void m_2_4_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantEntidadFinanciera _frmMantEntidadFinanciera = null;
            _frmMantEntidadFinanciera = mantenimiento.frmMantEntidadFinanciera.Instance();

            _frmMantEntidadFinanciera.MdiParent = this;
            _frmMantEntidadFinanciera.Show();
        }

        private void m_2_5_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantCuentasBancarias _frmMantCuentasBancarias  = null;
            _frmMantCuentasBancarias = mantenimiento.frmMantCuentasBancarias.Instance();
            _frmMantCuentasBancarias.MdiParent = this;
            _frmMantCuentasBancarias.Show();
        }

        private void cuentasContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantenimientoCtaContable _frmMantenimientoCtaContable = null;
            _frmMantenimientoCtaContable = mantenimiento.frmMantenimientoCtaContable.Instance();
            _frmMantenimientoCtaContable.MdiParent = this;
            _frmMantenimientoCtaContable.Show();
        }

        private void registrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento.frmMantRegistrarCaja _frmMantRegistrarCaja = null;
            _frmMantRegistrarCaja = mantenimiento.frmMantRegistrarCaja.Instance();
            _frmMantRegistrarCaja.MdiParent = this;
            _frmMantRegistrarCaja.Show();
        }

        private void m_2_2_Click_1(object sender, EventArgs e)
        {
            mantenimiento.frmMantMAC _frmMantMAC = null;
            _frmMantMAC = mantenimiento.frmMantMAC.Instance();
            _frmMantMAC.MdiParent = this;
            _frmMantMAC.Show();
        }

        private void m_2_10_Click_1(object sender, EventArgs e)
        {
            mantenimiento.frmMantTipoCambioDolar _frmMantTipoCambioDolar = null;
            _frmMantTipoCambioDolar = mantenimiento.frmMantTipoCambioDolar.Instance();
            _frmMantTipoCambioDolar.MdiParent = this;
            _frmMantTipoCambioDolar.Show();
        }

        private void m_1_2_1_Click(object sender, EventArgs e)
        {
            canevaro.frmMantResidente _frmMantResidente = null;
            _frmMantResidente = canevaro.frmMantResidente.Instance();

            _frmMantResidente.MdiParent = this;
            _frmMantResidente.Show();
        }

        private void m_1_2_3_Click(object sender, EventArgs e)
        {
            canevaro.frmMantenimientoCtaCteResidente _frmMantenimientoCtaCteResidente = null;
            _frmMantenimientoCtaCteResidente = canevaro.frmMantenimientoCtaCteResidente.Instance();

            _frmMantenimientoCtaCteResidente.MdiParent = this;
            _frmMantenimientoCtaCteResidente.Show();
        }

        private void m_1_2_2_Click(object sender, EventArgs e)
        {
            canevaro.frmMantTasasDscto _frmMantTasasDscto = null;
            _frmMantTasasDscto = canevaro.frmMantTasasDscto.Instance();

            _frmMantTasasDscto.MdiParent = this;
            _frmMantTasasDscto.Show();
        }

        private void m_1_2_4_Click(object sender, EventArgs e)
        {
            canevaro.frmMigrar _frmMigrar = null;
            _frmMigrar = canevaro.frmMigrar.Instance();
            _frmMigrar.MdiParent = this;
            _frmMigrar.Show();
        }

        private void m_1_2_5_Click(object sender, EventArgs e)
        {
            canevaro.frmBusquedaCtaResidente _frmBusquedaCtaResidente = null;
            _frmBusquedaCtaResidente = canevaro.frmBusquedaCtaResidente.Instance();
            _frmBusquedaCtaResidente.MdiParent = this;
            _frmBusquedaCtaResidente.Show();
        }

        private void m_4_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmCambioContrasenaUsuario _frmCambioContrasenaUsuario = null;
            _frmCambioContrasenaUsuario = mantenimiento.frmCambioContrasenaUsuario.Instance();
            _frmCambioContrasenaUsuario.MdiParent = this;
            _frmCambioContrasenaUsuario.Show();
        }

        private void m_1_1_2_4_Click(object sender, EventArgs e)
        {
            cementerio.frmCuarteles _frmGenerarCuartel = null;
            _frmGenerarCuartel = cementerio.frmCuarteles.Instance();
            _frmGenerarCuartel.MdiParent = this;
            _frmGenerarCuartel.Show();
        }

        private void m_1_1_8_2_1_Click(object sender, EventArgs e)
        {
             cementerio.inventario.frmIngresoNichoInventario _frmIngresoNichoInventario = null;
            _frmIngresoNichoInventario =  cementerio.inventario.frmIngresoNichoInventario.Instance();
            _frmIngresoNichoInventario.MdiParent = this;
            _frmIngresoNichoInventario.Show();
        }

        private void m_1_1_8_3_1_Click(object sender, EventArgs e)
        {
            cementerio.inventario.frmIngresoTumbainventario _frmIngresoTumbainventario = null;
            _frmIngresoTumbainventario = cementerio.inventario.frmIngresoTumbainventario.Instance();
            _frmIngresoTumbainventario.MdiParent = this;
            _frmIngresoTumbainventario.Show();
        }

        private void m_1_1_8_4_1_Click(object sender, EventArgs e)
        {
            cementerio.inventario.frmIngresoMausoleoInventario _frmIngresoMausoleoInventario = null;
            _frmIngresoMausoleoInventario = cementerio.inventario.frmIngresoMausoleoInventario.Instance();
            _frmIngresoMausoleoInventario.MdiParent = this;
            _frmIngresoMausoleoInventario.Show();
        }

        private void m_1_1_8_5_Click(object sender, EventArgs e)
        {
            cementerio.inventario.frmFiltroFallecidos _frmFiltroFallecidos = null;
            _frmFiltroFallecidos = cementerio.inventario.frmFiltroFallecidos.Instance();
            _frmFiltroFallecidos.MdiParent = this;
            _frmFiltroFallecidos.Show();
        }

        private void m_1_1_8_2_2_Click(object sender, EventArgs e)
        {
            cementerio.inventario.frmListadoTituloNicho _frmListadoTituloNicho = null;
            _frmListadoTituloNicho = new cementerio.inventario.frmListadoTituloNicho();
            _frmListadoTituloNicho.MdiParent = this;
            _frmListadoTituloNicho.Show();
        }

        private void m_1_1_8_2_3_Click(object sender, EventArgs e)
        {
            cementerio.frmReporteIngresosInventarios _frmReporteIngresosInventarios = null;
            _frmReporteIngresosInventarios = new cementerio.frmReporteIngresosInventarios();
            _frmReporteIngresosInventarios.MdiParent = this;
            _frmReporteIngresosInventarios.Show();
        }
    }
}
