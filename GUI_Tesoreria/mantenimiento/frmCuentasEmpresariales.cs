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
    public partial class frmCuentasEmpresariales : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmCuentasEmpresariales()
        {
            InitializeComponent();
        }
        CNegocio cn = new CNegocio();
        string TipoMant;

        private void frmCuentasEmpresariales_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            dgvListadoCuentas.DataSource = cn.EjecutarSqlDTS("select CODIGO_CONTABLE1,DENOMINACION1,CODIGO_CONTABLE2 ,DENOMINACION2 from contable_privado order by CODIGO_CONTABLE1 asc").Tables[0];
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                (this.dgvListadoCuentas.DataSource as DataTable).DefaultView.RowFilter = "CODIGO_CONTABLE1 like '%" + txtBuscar.Text.Trim() + "%'";
            }
            else if (rb2.Checked)
            {
                (this.dgvListadoCuentas.DataSource as DataTable).DefaultView.RowFilter = "DENOMINACION1 like '%" + txtBuscar.Text.Trim() + "%'";
            }
            else if (rb3.Checked)
            {
                (this.dgvListadoCuentas.DataSource as DataTable).DefaultView.RowFilter = "CODIGO_CONTABLE2 like '%" + txtBuscar.Text.Trim() + "%'";
            }
            else if (rb4.Checked)
            {
                (this.dgvListadoCuentas.DataSource as DataTable).DefaultView.RowFilter = "DENOMINACION2 like '%" + txtBuscar.Text.Trim() + "%'";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoMant = "I";
            gbBuscar.Enabled = false;
            gbDatos.Enabled = false;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnNuevo.Enabled = false;

            gbInfo.Enabled = true;
            txtCodigGub.Clear();
            txtDescGub.Clear();
            txtCodEmp.Clear();
            txtDescEmp.Clear();
            txtCodigGub.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            gbBuscar.Enabled = true;
            gbDatos.Enabled = true;
            gbInfo.Enabled = true;

            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnNuevo.Enabled = true;

            rb1.Checked = true;

            txtBuscar.Clear();
            txtCodigGub.Clear();
            txtDescGub.Clear();
            txtCodEmp.Clear();
            txtDescEmp.Clear();

            TipoMant = "";

            LlenarDatos();
        }

        private void dgvListadoCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoCuentas.Rows.Count > 0)
            {
                if (dgvListadoCuentas.CurrentRow != null)
                {
                    int indice;

                    indice = dgvListadoCuentas.CurrentRow.Index;

                    txtCodigGub.Text = dgvListadoCuentas.Rows[indice].Cells[0].Value.ToString();
                    txtDescGub.Text = dgvListadoCuentas.Rows[indice].Cells[1].Value.ToString();
                    txtCodEmp.Text = dgvListadoCuentas.Rows[indice].Cells[2].Value.ToString();
                    txtDescEmp.Text = dgvListadoCuentas.Rows[indice].Cells[3].Value.ToString();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigGub.Text.Trim()!=string.Empty)
            {
                if (txtDescGub.Text.Trim() != string.Empty)
                {
                    if (txtCodEmp.Text.Trim() != string.Empty)
                    {
                        if (txtDescEmp.Text.Trim() != string.Empty)
                        {
                            if (TipoMant=="I")
                            {
                                if (cn.EjecutarSqlDTS("select * from tb_cta_contable where codigoCuenta='" + txtCodigGub.Text.Replace("'", "").Replace("--", "") + "'").Tables[0].Rows.Count==0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("EL codigo Gub. que intenta ingresar no existe en la tabla de cuentas " + 
                                        "del sistema, se abrira una ventana para que cree la cuenta Gub.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    frmMantContable win = new frmMantContable();
                                    win.TipoMant = "N";
                                    win.ShowDialog();
                                    if (win.Save_)
                                    {
                                        LlenarDatos();
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Cancelo el registro de la cuenta nueva.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtCodigGub.Focus();
                                        return;
                                    }
                                }

                                if (cn.EjecutarUD("insert into contable_privado(CODIGO_CONTABLE1,DENOMINACION1,CODIGO_CONTABLE2,DENOMINACION2,usuing,fechaing) values('" + 
                                    txtCodigGub.Text.Replace("'","").Replace("--","")+"','"+ 
                                    txtDescGub.Text.Replace("'", "").Replace("--", "") + "','"+ txtCodEmp.Text.Replace("'", "").Replace("--", "") + "','"+ 
                                    txtDescEmp.Text.Replace("'", "").Replace("--", "") + "','"+VariablesMetodosEstaticos.varNombreUser + "',getdate())")>0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Cancelar();
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (TipoMant=="U")
                            {
                                if (cn.EjecutarSqlDTS("select * from tb_cta_contable where codigoCuenta='" + txtCodigGub.Text.Replace("'", "").Replace("--", "") + "'").Tables[0].Rows.Count == 0)
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("EL codigo Gub. que intenta ingresar no existe en la tabla de cuentas " +
                                        "del sistema, se abrira una ventana para que cree la cuenta Gub.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    frmMantContable win = new frmMantContable();
                                    win.TipoMant = "N";
                                    win.ShowDialog();
                                    if (win.Save_)
                                    {
                                        LlenarDatos();
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Cancelo el registro de la cuenta nueva.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtCodigGub.Focus();
                                        return;
                                    }
                                }

                                if (dgvListadoCuentas.Rows.Count > 0)
                                {
                                    if (dgvListadoCuentas.CurrentRow != null)
                                    {
                                        int indice;

                                        indice = dgvListadoCuentas.CurrentRow.Index;

                                        if (cn.EjecutarUD("update contable_privado set CODIGO_CONTABLE1='"+ 
                                            txtCodigGub.Text.Replace("'", "").Replace("--", "") + "',DENOMINACION1='"+ 
                                            txtDescGub.Text.Replace("'", "").Replace("--", "") + "',CODIGO_CONTABLE2='"+ 
                                            txtCodEmp.Text.Replace("'", "").Replace("--", "") + "',DENOMINACION2='"+ 
                                            txtDescEmp.Text.Replace("'", "").Replace("--", "") + "',usumod='"+
                                            VariablesMetodosEstaticos.varNombreUser+"',fechamod=getdate() where CODIGO_CONTABLE1='"+ 
                                            dgvListadoCuentas.Rows[indice].Cells[0].Value.ToString() + "'") > 0)
                                        {
                                            cn.EjecutarUD("update tb_cta_contable set descripcionCuenta='"+
                                                txtDescGub.Text.Replace("'", "").Replace("--", "") + 
                                                "' where codigoCuenta='"+ txtCodigGub.Text.Replace("'", "").Replace("--", "") + "'");

                                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingresado correctamente", VariablesMetodosEstaticos.encabezado,
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Cancelar();
                                        }
                                        else
                                        {
                                            DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, cancele e intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    DevComponents.DotNetBar.MessageBoxEx.Show("Ocurrio un error, cancele e intente de nuevo.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la descripción del código Emp.", VariablesMetodosEstaticos.encabezado,
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDescEmp.Focus();
                        }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el código Emp.", VariablesMetodosEstaticos.encabezado,
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodEmp.Focus();
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese la descripción del código Gub.", VariablesMetodosEstaticos.encabezado,
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescGub.Focus();
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Ingrese el código Gub.", VariablesMetodosEstaticos.encabezado,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigGub.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListadoCuentas.Rows.Count > 0)
            {

                TipoMant = "U";

                gbBuscar.Enabled = false;
                gbDatos.Enabled = false;

                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnRefrescar.Enabled = false;
                btnNuevo.Enabled = false;

                gbInfo.Enabled = true;
                txtCodigGub.Focus();
            }

        }
    }
}
