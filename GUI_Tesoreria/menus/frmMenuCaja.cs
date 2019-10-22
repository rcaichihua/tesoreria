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
    public partial class frmMenuCaja : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        private varGlobales varglo = new varGlobales();
        private CNegocio cn = new CNegocio();

        public frmMenuCaja()
        {
            InitializeComponent();
        }
        
        //cierra sesion
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            control.frmLogin login = new control.frmLogin();
            login.Show();
           
        }

        //ir al menu principal
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            varGlobales.verificaCierre = true;
            this.Close();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
        //salir del sistema
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
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
        private void frmMenuCaja_KeyDown(object sender, KeyEventArgs e)
        {
            //ir al menu principal
            if (e.KeyCode == Keys.Escape)
            {               
                //toolStripMenuItem5_Click(sender, e);
                //this.Close();
            }
            //ir al menu principal
            if (e.Control && e.KeyCode == Keys.M)
            {
                toolStripMenuItem5_Click(sender, e);
                this.Close();
            }
            //cerrar sesion
            if (e.Control && e.KeyCode == Keys.S)
            {
                toolStripMenuItem4_Click(sender, e);
                this.Close();
            }
            if (e.Control && e.KeyCode == Keys.Q)
            {
                toolStripMenuItem6_Click(sender, e);
            }
        }
        private void frmMenuCaja_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(varglo.RUTA_FONDO + "FONDOFORM.png");
            //this.BackgroundImageLayout = ImageLayout.Center;

            DataTable macDt = new DataTable();
            DataTable cajaUsuario = new DataTable();

            macDt = cn.EjecutarSqlDTS("select macID from tb_mac where mac='" + VariablesMetodosEstaticos.mac_pc + "'").Tables[0];

            if (macDt.Rows.Count > 0)
            {
                cajaUsuario = cn.EjecutarSqlDTS("select COUNT(*) as cantidad from Tb_Caja_Usuario where macID='" + macDt.Rows[0][0].ToString()
                + "' and intUsuId=" + VariablesMetodosEstaticos.id_user.ToString() + " and Estado_Caja_Usuario=1").Tables[0];
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Su computador no se encuentra registrado para realizar caja. Si desea comuniquese con el administrador.", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                        MessageBoxDefaultButton.Button1);
                toolStripMenuItem5_Click(sender, e);
                inhabilitaMenu();
            }

            if (cajaUsuario.Rows.Count > 0)
            {
                if (Convert.ToInt32(cajaUsuario.Rows[0][0]) != 0)
                {
                    VariablesMetodosEstaticos.mac_id = Convert.ToInt32(macDt.Rows[0][0]);
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Este computador no puede realizar caja con el usuario Logueado, contacte con sistemas.", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                            MessageBoxDefaultButton.Button1);
                    toolStripMenuItem5_Click(sender, e);
                    
                    inhabilitaMenu();

                    return;
                }
            }
            
            DataTable dtcajasuario = new DataTable();

            dtcajasuario = cn.TraerDataset("usp_s_tb_caja_usuario", 1, 0, 0, VariablesMetodosEstaticos.id_user, 0, 0, 0, 1, VariablesMetodosEstaticos.mac_id).Tables[0];

            if (dtcajasuario.Rows.Count > 0)
            {
                VariablesMetodosEstaticos.idcajausuario = Convert.ToInt32(dtcajasuario.Rows[0]["id_caja_usuario"].ToString());
                VariablesMetodosEstaticos.idcaja = Convert.ToInt32(dtcajasuario.Rows[0]["id_caja"].ToString());
                VariablesMetodosEstaticos.numeroapertura = dtcajasuario.Rows[0]["VaucherApertura"].ToString();

                tsslUsuario.Text = VariablesMetodosEstaticos.varNombreUser;
                tsslSucursal.Text = VariablesMetodosEstaticos.varNombreSucursal;
                tsslPerfil.Text = VariablesMetodosEstaticos.varNombrePerfil;
                varGlobales.verificaCierre = false;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Su computador no se encuentra registrado para realizar caja. Si desea comuniquese con el administrador.", ":: :: ACCESO AL SISTEMA :: ::", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                                                                                       MessageBoxDefaultButton.Button1);
                toolStripMenuItem5_Click(sender, e);
                return;
            }           
        }

        private void inhabilitaMenu()
        {
            m_1.Enabled = false;
            m_2.Enabled = false;
            m_3.Enabled = false;
        }

        private void frmMenuCaja_FormClosing(object sender, FormClosingEventArgs e)
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
            caja.FrmAperturaCierreCaja _FrmAperturaCierreCaja = null;
            _FrmAperturaCierreCaja = caja.FrmAperturaCierreCaja.Instance();
            _FrmAperturaCierreCaja.IntOpcion = "Apertura de Caja";
            _FrmAperturaCierreCaja.MdiParent = this;
            _FrmAperturaCierreCaja.Show();
        }

        private void m_1_4_Click(object sender, EventArgs e)
        {
            caja.FrmAperturaCierreCaja _FrmAperturaCierreCaja = null;
            _FrmAperturaCierreCaja = caja.FrmAperturaCierreCaja.Instance();
            _FrmAperturaCierreCaja.IntOpcion = "Cierre de Caja";
            _FrmAperturaCierreCaja.MdiParent = this;
            _FrmAperturaCierreCaja.Show();
        }

        private void m_1_2_Click(object sender, EventArgs e)
        {
            caja.frmPagoDiversos _frmPagoDiversos = null;
            _frmPagoDiversos = caja.frmPagoDiversos.Instance();
            _frmPagoDiversos.MdiParent = this;
            _frmPagoDiversos.Show();
        }

        private void m_2_1_Click(object sender, EventArgs e)
        {
            caja.frmConsultaRecibos _frmConsultaRecibos = null;
            _frmConsultaRecibos = caja.frmConsultaRecibos.Instance();
            _frmConsultaRecibos.MdiParent = this;
            _frmConsultaRecibos.cajeroIngreso = 0;
            _frmConsultaRecibos.Show();
        }

        private void m_3_6_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 11)
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

        private void m_3_1_1_Click(object sender, EventArgs e)
        {
            frmReporteIngresoDiario _frmReporteProceso = null;
            _frmReporteProceso = frmReporteIngresoDiario.Instance();
            _frmReporteProceso.tipo_reporte = "R";
            _frmReporteProceso.MdiParent = this;
            _frmReporteProceso.Show();
        }

        private void m_3_1_2_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 11)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            frmReporteIngresoDiario _frmReporteProceso = null;
            _frmReporteProceso = frmReporteIngresoDiario.Instance();
            _frmReporteProceso.tipo_reporte = "D";
            _frmReporteProceso.MdiParent = this;
            _frmReporteProceso.Show();
        }

        private void m_3_2_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 10)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            frmReporteIngresoDiario _frmReporteProceso = null;
            _frmReporteProceso = frmReporteIngresoDiario.Instance();
            _frmReporteProceso.tipo_reporte = "M";
            _frmReporteProceso.MdiParent = this;
            _frmReporteProceso.Show();
        }

        private void m_2_2_Click(object sender, EventArgs e)
        {
            caja.frmRecibosIngreso _frmRecibosIngreso = null;
            _frmRecibosIngreso = caja.frmRecibosIngreso.Instance();
            _frmRecibosIngreso.MdiParent = this;
            _frmRecibosIngreso.Show();
        }

        private void m_4_1_Click(object sender, EventArgs e)
        {
            mantenimiento.frmCambioContrasenaUsuario _frmCambioContrasenaUsuario = null;
            _frmCambioContrasenaUsuario = mantenimiento.frmCambioContrasenaUsuario.Instance();
            _frmCambioContrasenaUsuario.MdiParent = this;
            _frmCambioContrasenaUsuario.Show();
        }

        private void m_3_7_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 11)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            canevaro.frmInformeDeudasPorAnio _frmInformeDeudasPorAnio = null;
            _frmInformeDeudasPorAnio = canevaro.frmInformeDeudasPorAnio.Instance();
            _frmInformeDeudasPorAnio.MdiParent = this;
            _frmInformeDeudasPorAnio.Show();
        }

        private void m_3_8_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 11)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            frmReporteIngresoDiario _frmReporteProceso = null;
            _frmReporteProceso = frmReporteIngresoDiario.Instance();
            _frmReporteProceso.tipo_reporte = "D";
            _frmReporteProceso.MdiParent = this;
            _frmReporteProceso.Show();
            canevaro.frmReporteResidentes _frmReporteResidentes = null;
            _frmReporteResidentes = canevaro.frmReporteResidentes.Instance();
            _frmReporteResidentes.MdiParent = this;
            _frmReporteResidentes.Show();
        }

        private void m_1_4_Click_1(object sender, EventArgs e)
        {
            caja.frmIngresoVouchers _frmReporteResidentes = null;
            _frmReporteResidentes = caja.frmIngresoVouchers.Instance();
            _frmReporteResidentes.idCajeroIngresoVouchers = VariablesMetodosEstaticos.idcajausuario;
            _frmReporteResidentes.habilita = 1;
            _frmReporteResidentes.MdiParent = this;
            _frmReporteResidentes.Show();           
        }

        private void m_3_1_3_Click(object sender, EventArgs e)
        {
            frmReporteIngresoDiario _frmReporteProceso = null;
            _frmReporteProceso = frmReporteIngresoDiario.Instance();
            _frmReporteProceso.tipo_reporte = "ResumenComedor";
            _frmReporteProceso.MdiParent = this;
            _frmReporteProceso.Show();
        }

        private void m_3_1_4_Click(object sender, EventArgs e)
        {
            frmReporteIngresoDiario _frmReporteProceso = null;
            _frmReporteProceso = frmReporteIngresoDiario.Instance();
            _frmReporteProceso.tipo_reporte = "ResumenComedor";
            _frmReporteProceso.MdiParent = this;
            _frmReporteProceso.Show();
        }

        private void m_1_5_Click(object sender, EventArgs e)
        {
            DGAI.frmGeneraLiquidacionDGAI _frmGeneraLiquidacionDGAI = null;
            _frmGeneraLiquidacionDGAI = DGAI.frmGeneraLiquidacionDGAI.Instance();
            _frmGeneraLiquidacionDGAI.MdiParent = this;
            _frmGeneraLiquidacionDGAI.Show();
        }

        private void m_1_6_1_1_Click(object sender, EventArgs e)
        {
            cementerio.frmAperturaExpedienteInHumacion _frmAperturaExpedienteInHumacion = null;
            _frmAperturaExpedienteInHumacion = cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmAperturaExpedienteInHumacion.MdiParent = this;
            _frmAperturaExpedienteInHumacion.Show();
        }

        private void m_1_7_1_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
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

        private void reporteIngresosPorRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void m_1_9_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 9 && VariablesMetodosEstaticos.intPerfilID != 1)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmGeneraLiquidacion _frmGeneraLiquidacion = null;
            _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmGeneraLiquidacion.Instance();
            _frmGeneraLiquidacion.MdiParent = this;
            _frmGeneraLiquidacion.Show();
        }

        private void generaciónDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmGeneraLiquidacion _frmGeneraLiquidacion = null;
            _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmGeneraLiquidacion.Instance();
            _frmGeneraLiquidacion.MdiParent = this;
            _frmGeneraLiquidacion.Show();
        }

        private void listadoDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
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

        private void listadoDeRecibosDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }
            caja.Liquidacion_cajas.frmListadoRecibosTotal _frmGeneraLiquidacion = null;
            _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmListadoRecibosTotal.Instance();
            _frmGeneraLiquidacion.MdiParent = this;
            _frmGeneraLiquidacion.Show();
        }

        //private void ingresosDiariosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (VariablesMetodosEstaticos.varUsuario != "ESOTOMAYOR")
        //    {
        //        DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
        //                                       MessageBoxIcon.Warning);
        //        return;
        //    }
        //    caja.Liquidacion_cajas.frmFiltroFechaIngresos _frmGeneraLiquidacion = null;
        //    _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmFiltroFechaIngresos.Instance();
        //    _frmGeneraLiquidacion.MdiParent = this;
        //    _frmGeneraLiquidacion.Tipo = "ID";
        //    _frmGeneraLiquidacion.Show();
        //}

        //private void recibosEmitidosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (VariablesMetodosEstaticos.varUsuario != "ESOTOMAYOR")
        //    {
        //        DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
        //                                       MessageBoxIcon.Warning);
        //        return;
        //    }
        //    caja.Liquidacion_cajas.frmFiltroFechaIngresos _frmGeneraLiquidacion = null;
        //    _frmGeneraLiquidacion = caja.Liquidacion_cajas.frmFiltroFechaIngresos.Instance();
        //    _frmGeneraLiquidacion.MdiParent = this;
        //    _frmGeneraLiquidacion.Tipo = "RE";
        //    _frmGeneraLiquidacion.Show();
        //}

        private void cierreDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
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

        private void listaadoDeRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.Liquidacion_cajas.frmListaRubrosCajaCentral _frmListaRubrosCajaCentral = null;
            _frmListaRubrosCajaCentral = caja.Liquidacion_cajas.frmListaRubrosCajaCentral.Instance();
            _frmListaRubrosCajaCentral.MdiParent = this;
            _frmListaRubrosCajaCentral.Show();
        }

        private void reporteDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
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

        private void porBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
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
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            caja.Depositos.frmReporteBancoPorDetraccion _frmReporteBancoPorBanco = new caja.Depositos.frmReporteBancoPorDetraccion(); //cementerio.frmAperturaExpedienteInHumacion.Instance();
            _frmReporteBancoPorBanco.MdiParent = this;
            _frmReporteBancoPorBanco.Show();
        }

        private void regularizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesMetodosEstaticos.intPerfilID != 1 && VariablesMetodosEstaticos.intPerfilID != 6 && VariablesMetodosEstaticos.intPerfilID != 9)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene permiso para acceder a este menú.", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                return;
            }

            Deposito.frmReporteRegularizacion _frmVerif = new Deposito.frmReporteRegularizacion();
            _frmVerif.MdiParent = this;
            _frmVerif.Show();
        }
    }
}
