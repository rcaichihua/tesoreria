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

namespace GUI_Tesoreria.menus
{
    public partial class frmMenu : DevComponents.DotNetBar.Metro.MetroForm//Form
    {
        ToolTip toolTip = new ToolTip();
        private CNegocio cd = new CNegocio();

        public frmMenu()
        {
            InitializeComponent();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que desea salir del Sistema?";
            string caption = "...:::Salir del Sistema:::...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = DevComponents.DotNetBar.MessageBoxEx.Show(message, caption, buttons,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }
        private void Mensajes()
        {
            toolTip.SetToolTip( this.M1, "Control y verificación de cobros");
            toolTip.SetToolTip(this.M2, "Control y verificación de Pagos");
            toolTip.SetToolTip(this.M3, "Control de gestión de cobros y pagos");
            toolTip.SetToolTip(this.M4, "Configuración y mantenimiento del sistema");
        }
        private void Posicionar(int top, int left)
        {
            //this.pbPanelCobros.Top = top;
            //this.pbPanelCobros.Left = left;

            //this.pbPanelPagos.Top = top;
            //this.pbPanelPagos.Left = left;

            //this.pbPanelGestion.Top = top;
            //this.pbPanelGestion.Left = left;

            //this.pbPanelConfiguracion.Top = top;
            //this.pbPanelConfiguracion.Left = left;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 0;
            VariablesMetodosEstaticos.menuPrincipalID = 0;
            //Posicionar(18, 57);
            //Tamaño_Paneles(230, 131);
            Mensajes();
            //Cargar_Cobros();
            //M1_Click(sender, e);
        }

        private void Tamaño_Paneles(int w, int h)
        {
            //this.pbPanelCobros.Width = w;
            //this.pbPanelCobros.Height = h;
            //this.pbPanelPagos.Width = w;
            //this.pbPanelPagos.Height = h;
            //this.pbPanelGestion.Width = w;
            //this.pbPanelGestion.Height = h;
            //this.pbPanelConfiguracion.Width = w;
            //this.pbPanelConfiguracion.Height = h;
        }
        private void Cargar_Cobros()
        {
            //pbPanelCobros.Visible = true;
            //pbPanelPagos.Visible = false;
            //pbPanelConfiguracion.Visible = false;
            //pbPanelGestion.Visible = false;

            Posicionar(118, 230);
            Tamaño_Paneles(230, 131);
        }
        private void Cargar_Recuadacion() {
            //pbPanelCobros.Visible = true;
            //pbPanelPagos.Visible = false;
            //pbPanelConfiguracion.Visible = false;
            //pbPanelGestion.Visible = false;

            Posicionar(118, 230);
            Tamaño_Paneles(230, 131);
        }

        private void pbCierraSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            control.frmLogin login = new control.frmLogin();
            login.Show();
        }
        private void M1_Click(object sender, EventArgs e)
        {
            //COBROS
            if (cd.TraerDataset("usp_verifica_acceso_x_perfil", VariablesMetodosEstaticos.intPerfilID, "COBROS").Tables[0].Rows.Count > 0)
            {
                VariablesMetodosEstaticos.menuPrincipalID = 1;
                varGlobales ruta = new varGlobales();
                Posicionar(118, 230);
                Tamaño_Paneles(230, 131);

                //pbPanelCobros.Visible = true;
                //pbPanelPagos.Visible = false;
                //pbPanelConfiguracion.Visible = false;
                //pbPanelGestion.Visible = false;
                this.btnCaja.Visible = true;
                this.btnReporteIngresos.Visible = true;
                this.btnConfiguracion.Visible = false;
                this.btnCuadroMando.Visible = false;

                this.lblCaja.Visible = true;
                this.lblReporteIngresos.Visible = true;
                this.lblConfiguracion.Visible = false;
                this.lblCuadroMando.Visible = false;

                Cargar_Recuadacion();

                M1.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\cobros2.png");
                M2.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\pagos1.png");
                M3.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\gestion1.png");
                M4.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\config1.png");
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene acceso", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void M2_Click(object sender, EventArgs e)
        {
            //PAGOS
            if (cd.TraerDataset("usp_verifica_acceso_x_perfil", VariablesMetodosEstaticos.intPerfilID, "PAGOS").Tables[0].Rows.Count > 0)
            {
                VariablesMetodosEstaticos.menuPrincipalID = 2;
                varGlobales ruta = new varGlobales();
                Posicionar(118, 230);
                Tamaño_Paneles(230, 131);

                //pbPanelCobros.Visible = false;
                //pbPanelPagos.Visible = true;
                //pbPanelConfiguracion.Visible = false;
                //pbPanelGestion.Visible = false;

                this.btnCaja.Visible = false;
                this.btnReporteIngresos.Visible = false;
                this.btnConfiguracion.Visible = false;
                this.btnCuadroMando.Visible = false;

                this.lblCaja.Visible = false;
                this.lblReporteIngresos.Visible = false;
                this.lblConfiguracion.Visible = false;
                this.lblCuadroMando.Visible = false;

                Cargar_Recuadacion();

                M1.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\cobros1.png");
                M2.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\pagos2.png");
                M3.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\gestion1.png");
                M4.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\config1.png");
            }
           else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene acceso", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void M3_Click(object sender, EventArgs e)
        {
            //GESTION
            if (cd.TraerDataset("usp_verifica_acceso_x_perfil", VariablesMetodosEstaticos.intPerfilID, "GESTION").Tables[0].Rows.Count > 0)
            {
                VariablesMetodosEstaticos.menuPrincipalID = 3;
                varGlobales ruta = new varGlobales();
                Posicionar(118, 230);
                Tamaño_Paneles(230, 131);

                //pbPanelCobros.Visible = false;
                //pbPanelPagos.Visible = false;
                //pbPanelConfiguracion.Visible = true;
                //pbPanelGestion.Visible = false;

                this.btnCaja.Visible = false;
                this.btnReporteIngresos.Visible = false;
                this.btnConfiguracion.Visible = false;
                this.btnCuadroMando.Visible = true;

                this.lblCaja.Visible = false;
                this.lblReporteIngresos.Visible = false;
                this.lblConfiguracion.Visible = false;
                this.lblCuadroMando.Visible = true;

                Cargar_Recuadacion();

                M1.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\cobros1.png");
                M2.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\pagos1.png");
                M3.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\gestion2.png");
                M4.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\config1.png");
            }
              else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene acceso", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void M4_Click(object sender, EventArgs e)
        {
            //CONFIGURACION
            if (cd.TraerDataset("usp_verifica_acceso_x_perfil", VariablesMetodosEstaticos.intPerfilID, "CONFIGURACIÓN").Tables[0].Rows.Count > 0)
            {
                VariablesMetodosEstaticos.menuPrincipalID = 4;
                varGlobales ruta = new varGlobales();
                Posicionar(118, 230);
                Tamaño_Paneles(230, 131);

                //pbPanelCobros.Visible = false;
                //pbPanelPagos.Visible = false;
                //pbPanelConfiguracion.Visible = false;
                //pbPanelGestion.Visible = true;

                this.btnCaja.Visible = false;
                this.btnReporteIngresos.Visible = false;
                this.btnConfiguracion.Visible = true;
                this.btnCuadroMando.Visible = false;

                this.lblCaja.Visible = false;
                this.lblReporteIngresos.Visible = false;
                this.lblConfiguracion.Visible = true;
                this.lblCuadroMando.Visible = false;

                Cargar_Recuadacion();

                M1.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\cobros1.png");
                M2.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\pagos1.png");
                M3.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\gestion1.png");
                M4.Image = Image.FromFile(ruta.ruta1 + @"\FONDO\config2.png");
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("No tiene acceso", VariablesMetodosEstaticos.encabezado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 1;
            lblCaja_Click(sender, e);
        }

        private void lblCaja_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 1;
            if (this.btnCaja.Enabled == true) {
                this.Hide();
                menus.frmMenuCaja caja = new menus.frmMenuCaja();
                caja.Show();
            }
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void lblConfiguracion_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 4;
            if (this.btnCaja.Enabled == true)
            {
                if (this.btnCaja.Enabled == true)
                {
                    this.Hide();
                    menus.frmMenuConfiguracion caja = new menus.frmMenuConfiguracion();
                    caja.Show();
                }
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 4;
            lblConfiguracion_Click(sender, e);
        }

        private void btnCuadroMando_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 3;
            lblCuadroMando_Click(sender, e);
        }

        private void lblCuadroMando_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.Show("En mantenimiento", VariablesMetodosEstaticos.encabezado,
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void lblReporteIngresos_Click(object sender, EventArgs e)
        {
            if (this.btnCaja.Enabled == true)
            {
                this.Hide();
                menus.frmMenuReporteIngreso caja = new menus.frmMenuReporteIngreso();
                caja.Show();
            }
        }

        private void btnReporteIngresos_Click(object sender, EventArgs e)
        {
            VariablesMetodosEstaticos.subMenuPrincipalID = 2;
            lblReporteIngresos_Click(sender, e);
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Salir_Click(sender, e);
            }
        }
    }
}
