using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL_Tesoreria;

namespace GUI_Tesoreria.Deposito
{
    public partial class frmPreparaComprobanteDiario : DevComponents.DotNetBar.Metro.MetroForm
    {
        private static frmPreparaComprobanteDiario frmInstance = null;

        public frmPreparaComprobanteDiario()
        {
            InitializeComponent();
        }
        public bool Save__ { get; set; }

        public static frmPreparaComprobanteDiario Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmPreparaComprobanteDiario();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        CNegocio cn = new CNegocio();

        private void frmPreparaComprobanteDiario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDepositoBanco.Checked)
                {
                    if (cn.TraerDataset("usp_paDiario_existe",
                        dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "1").Tables[0].Rows.Count <= 0)
                    {
                        if (cn.EjecutarSP("usp_paDIARIO", dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "1",
                            VariablesMetodosEstaticos.varUsuario) > 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El comprobante fue creado satisfactoriamente.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El día seleccionado no cuenta con movimientos.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Vaya al boton borrar comprobante Diario.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (rbSinProgRegula.Checked)
                {
                    if (cn.TraerDataset("usp_paDiario_existe",
                        dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "3").Tables[0].Rows.Count <= 0)
                    {
                        if (cn.EjecutarSP("usp_paDIARIO_Regula", dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "3",
                            VariablesMetodosEstaticos.varUsuario) > 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El comprobante fue creado satisfactoriamente.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El día seleccionado no cuenta con movimientos.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Vaya al boton borrar comprobante Diario.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (rbLiqMesAnt.Checked)
                {
                    if (cn.TraerDataset("usp_paDiario_existe",
                        dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "4").Tables[0].Rows.Count <= 0)
                    {
                        if (cn.EjecutarSP("usp_paDIARIO_Liquida", dtpFechaLiquidación.Value.ToString("yyyyMMdd"), "4",
                            VariablesMetodosEstaticos.varUsuario) > 0)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El comprobante fue creado satisfactoriamente.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("El día seleccionado no cuenta con movimientos.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Vaya al boton borrar comprobante Diario.", VariablesMetodosEstaticos.encabezado,
                                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, VariablesMetodosEstaticos.encabezado,
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmBorrarComprobanteDiario win = new frmBorrarComprobanteDiario();
            win._fechaBorrar = dtpFechaLiquidación.Value;
            win.ShowDialog();
        }
    }
}
