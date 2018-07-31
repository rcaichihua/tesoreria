namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantCuentasContables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCtaContable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPresupuestal = new System.Windows.Forms.TextBox();
            this.txtCuentaGestion = new System.Windows.Forms.TextBox();
            this.txtCodigoCtaContable = new System.Windows.Forms.TextBox();
            this.txtDescripcionCtaContable = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaContable)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(216, 507);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(372, 507);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(60, 507);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(294, 507);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(138, 507);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(450, 507);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvCtaContable);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 241);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            // 
            // dgvCtaContable
            // 
            this.dgvCtaContable.AllowUserToAddRows = false;
            this.dgvCtaContable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaContable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCtaContable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaContable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvCtaContable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCtaContable.EnableHeadersVisualStyles = false;
            this.dgvCtaContable.Location = new System.Drawing.Point(3, 16);
            this.dgvCtaContable.Name = "dgvCtaContable";
            this.dgvCtaContable.ReadOnly = true;
            this.dgvCtaContable.RowHeadersWidth = 25;
            this.dgvCtaContable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCtaContable.Size = new System.Drawing.Size(548, 222);
            this.dgvCtaContable.TabIndex = 0;
            this.dgvCtaContable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtaContable_CellEnter);
            this.dgvCtaContable.CurrentCellChanged += new System.EventHandler(this.dgvCtaContable_CurrentCellChanged);
            this.dgvCtaContable.Click += new System.EventHandler(this.dgvCtaContable_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_cuenta_contable";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descrip_cuenta_contable";
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "codigo_cuenta_contable";
            this.Column4.HeaderText = "Cuenta contable";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegistros.Location = new System.Drawing.Point(507, 223);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(59, 15);
            this.lblRegistros.TabIndex = 102;
            this.lblRegistros.Text = "1 de 100";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtPresupuestal);
            this.GroupBox1.Controls.Add(this.txtCuentaGestion);
            this.GroupBox1.Controls.Add(this.txtCodigoCtaContable);
            this.GroupBox1.Controls.Add(this.txtDescripcionCtaContable);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(557, 159);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(85, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Presupuestal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cuenta de Gestión";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label4.Location = new System.Drawing.Point(18, 79);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(158, 15);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Codigo cuenta contable";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(46, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(130, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Descripcion cuenta";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label1.Location = new System.Drawing.Point(124, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Codigo";
            // 
            // txtPresupuestal
            // 
            this.txtPresupuestal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresupuestal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuestal.Location = new System.Drawing.Point(182, 130);
            this.txtPresupuestal.Name = "txtPresupuestal";
            this.txtPresupuestal.Size = new System.Drawing.Size(290, 21);
            this.txtPresupuestal.TabIndex = 2;
            // 
            // txtCuentaGestion
            // 
            this.txtCuentaGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaGestion.Location = new System.Drawing.Point(182, 103);
            this.txtCuentaGestion.Name = "txtCuentaGestion";
            this.txtCuentaGestion.Size = new System.Drawing.Size(290, 21);
            this.txtCuentaGestion.TabIndex = 2;
            // 
            // txtCodigoCtaContable
            // 
            this.txtCodigoCtaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCtaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCtaContable.Location = new System.Drawing.Point(182, 76);
            this.txtCodigoCtaContable.Name = "txtCodigoCtaContable";
            this.txtCodigoCtaContable.Size = new System.Drawing.Size(290, 21);
            this.txtCodigoCtaContable.TabIndex = 2;
            // 
            // txtDescripcionCtaContable
            // 
            this.txtDescripcionCtaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCtaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCtaContable.Location = new System.Drawing.Point(182, 49);
            this.txtDescripcionCtaContable.Name = "txtDescripcionCtaContable";
            this.txtDescripcionCtaContable.Size = new System.Drawing.Size(356, 21);
            this.txtDescripcionCtaContable.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(182, 23);
            this.txtId.MaxLength = 4;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(47, 21);
            this.txtId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(13, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Filtro por Cuenta Contable";
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(194, 223);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 21);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1038, 36);
            this.LblTitulo.TabIndex = 105;
            this.LblTitulo.Text = "MANTENIMIENTO - CTAS CONTABLES";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(657, 250);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 122;
            this.label25.Text = "Elemento";
            // 
            // cboCuenta
            // 
            this.cboCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCuenta.BackColor = System.Drawing.Color.White;
            this.cboCuenta.DropDownHeight = 200;
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.DropDownWidth = 400;
            this.cboCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.ForeColor = System.Drawing.Color.Black;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.IntegralHeight = false;
            this.cboCuenta.Items.AddRange(new object[] {
            "[seleccione]"});
            this.cboCuenta.Location = new System.Drawing.Point(660, 266);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(116, 21);
            this.cboCuenta.TabIndex = 121;
            // 
            // frmMantCuentasContables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 579);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cboCuenta);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantCuentasContables";
            this.Text = "...:::Mantenimiento cuenta contable:::...";
            this.Load += new System.EventHandler(this.frmMantCuentasContables_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.txtFiltro, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.LblTitulo, 0);
            this.Controls.SetChildIndex(this.cboCuenta, 0);
            this.Controls.SetChildIndex(this.label25, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaContable)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCtaContable;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCodigoCtaContable;
        internal System.Windows.Forms.TextBox txtDescripcionCtaContable;
        internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.Label lblRegistros;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtFiltro;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtPresupuestal;
        internal System.Windows.Forms.TextBox txtCuentaGestion;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.ComboBox cboCuenta;
    }
}