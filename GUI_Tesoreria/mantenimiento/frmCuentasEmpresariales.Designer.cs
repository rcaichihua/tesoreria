namespace GUI_Tesoreria.mantenimiento
{
    partial class frmCuentasEmpresariales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dgvListadoCuentas = new System.Windows.Forms.DataGridView();
            this.txtDescGub = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtDescEmp = new System.Windows.Forms.TextBox();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.txtCodigGub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.CODIGO_GUBERNAMENTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_CUENTA_GUBERNAMENTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_EMPRESARIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_CUENTA_EMPRESARIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCuentas)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Navy;
            this.btnEditar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(979, 131);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 57);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Navy;
            this.btnNuevo.Image = global::GUI_Tesoreria.Properties.Resources.imprimirD;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(979, 68);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 57);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(979, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 71);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.dgvListadoCuentas);
            this.gbDatos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.Maroon;
            this.gbDatos.Location = new System.Drawing.Point(15, 62);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(956, 453);
            this.gbDatos.TabIndex = 152;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Listado de Vouchers";
            // 
            // dgvListadoCuentas
            // 
            this.dgvListadoCuentas.AllowUserToAddRows = false;
            this.dgvListadoCuentas.AllowUserToDeleteRows = false;
            this.dgvListadoCuentas.AllowUserToResizeColumns = false;
            this.dgvListadoCuentas.AllowUserToResizeRows = false;
            this.dgvListadoCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_GUBERNAMENTAL,
            this.DESCRIP_CUENTA_GUBERNAMENTAL,
            this.CODIGO_EMPRESARIAL,
            this.DESCRIP_CUENTA_EMPRESARIAL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoCuentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoCuentas.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListadoCuentas.Location = new System.Drawing.Point(3, 17);
            this.dgvListadoCuentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoCuentas.Name = "dgvListadoCuentas";
            this.dgvListadoCuentas.ReadOnly = true;
            this.dgvListadoCuentas.RowHeadersVisible = false;
            this.dgvListadoCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCuentas.Size = new System.Drawing.Size(950, 433);
            this.dgvListadoCuentas.TabIndex = 16;
            this.dgvListadoCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoCuentas_CellClick);
            // 
            // txtDescGub
            // 
            this.txtDescGub.Location = new System.Drawing.Point(190, 45);
            this.txtDescGub.Name = "txtDescGub";
            this.txtDescGub.Size = new System.Drawing.Size(277, 20);
            this.txtDescGub.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(470, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(238, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtCodigGub);
            this.gbInfo.Controls.Add(this.txtCodEmp);
            this.gbInfo.Controls.Add(this.txtDescEmp);
            this.gbInfo.Controls.Add(this.txtDescGub);
            this.gbInfo.Location = new System.Drawing.Point(15, 521);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(956, 84);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            // 
            // txtDescEmp
            // 
            this.txtDescEmp.Location = new System.Drawing.Point(657, 45);
            this.txtDescEmp.Name = "txtDescEmp";
            this.txtDescEmp.Size = new System.Drawing.Size(281, 20);
            this.txtDescEmp.TabIndex = 3;
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.Location = new System.Drawing.Point(473, 45);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.Size = new System.Drawing.Size(178, 20);
            this.txtCodEmp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "BUSCAR POR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 157;
            this.label2.Text = "DESCRIP. CODIGO CONTABLE GUB.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "CODIGO CONTABLE EMP.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 157;
            this.label4.Text = "DESCRIP. CODIGO CONTABLE EMP.";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(100, 14);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(93, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "CODIGO GUB";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(196, 14);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(83, 17);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "DESC. GUB";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(285, 14);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(93, 17);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "CODIGO EMP";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(381, 14);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(83, 17);
            this.rb4.TabIndex = 3;
            this.rb4.Text = "DESC. EMP";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // txtCodigGub
            // 
            this.txtCodigGub.Location = new System.Drawing.Point(6, 45);
            this.txtCodigGub.Name = "txtCodigGub";
            this.txtCodigGub.Size = new System.Drawing.Size(178, 20);
            this.txtCodigGub.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 157;
            this.label5.Text = "CODIGO CONTABLE GUB.";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(979, 194);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 57);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CODIGO_GUBERNAMENTAL
            // 
            this.CODIGO_GUBERNAMENTAL.DataPropertyName = "CODIGO_CONTABLE1";
            this.CODIGO_GUBERNAMENTAL.Frozen = true;
            this.CODIGO_GUBERNAMENTAL.HeaderText = "CODIGO GUBERNAMENTAL";
            this.CODIGO_GUBERNAMENTAL.Name = "CODIGO_GUBERNAMENTAL";
            this.CODIGO_GUBERNAMENTAL.ReadOnly = true;
            this.CODIGO_GUBERNAMENTAL.Width = 210;
            // 
            // DESCRIP_CUENTA_GUBERNAMENTAL
            // 
            this.DESCRIP_CUENTA_GUBERNAMENTAL.DataPropertyName = "DENOMINACION1";
            this.DESCRIP_CUENTA_GUBERNAMENTAL.Frozen = true;
            this.DESCRIP_CUENTA_GUBERNAMENTAL.HeaderText = "DESCRIP CUENTA GUBERNAMENTAL";
            this.DESCRIP_CUENTA_GUBERNAMENTAL.Name = "DESCRIP_CUENTA_GUBERNAMENTAL";
            this.DESCRIP_CUENTA_GUBERNAMENTAL.ReadOnly = true;
            this.DESCRIP_CUENTA_GUBERNAMENTAL.Width = 250;
            // 
            // CODIGO_EMPRESARIAL
            // 
            this.CODIGO_EMPRESARIAL.DataPropertyName = "CODIGO_CONTABLE2";
            this.CODIGO_EMPRESARIAL.Frozen = true;
            this.CODIGO_EMPRESARIAL.HeaderText = "CODIGO EMPRESARIAL";
            this.CODIGO_EMPRESARIAL.Name = "CODIGO_EMPRESARIAL";
            this.CODIGO_EMPRESARIAL.ReadOnly = true;
            this.CODIGO_EMPRESARIAL.Width = 210;
            // 
            // DESCRIP_CUENTA_EMPRESARIAL
            // 
            this.DESCRIP_CUENTA_EMPRESARIAL.DataPropertyName = "DENOMINACION2";
            this.DESCRIP_CUENTA_EMPRESARIAL.Frozen = true;
            this.DESCRIP_CUENTA_EMPRESARIAL.HeaderText = "DESCRIP CUENTA EMPRESARIAL";
            this.DESCRIP_CUENTA_EMPRESARIAL.Name = "DESCRIP_CUENTA_EMPRESARIAL";
            this.DESCRIP_CUENTA_EMPRESARIAL.ReadOnly = true;
            this.DESCRIP_CUENTA_EMPRESARIAL.Width = 250;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Controls.Add(this.rb4);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.rb2);
            this.gbBuscar.Controls.Add(this.rb1);
            this.gbBuscar.Controls.Add(this.rb3);
            this.gbBuscar.Location = new System.Drawing.Point(12, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(959, 44);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.Navy;
            this.btnRefrescar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescar.Location = new System.Drawing.Point(979, 257);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 57);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "&Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(979, 320);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 57);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCuentasEmpresariales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 617);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbDatos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCuentasEmpresariales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Cuentas Empresariales:::...";
            this.Load += new System.EventHandler(this.frmCuentasEmpresariales_Load);
            this.gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCuentas)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.GroupBox gbDatos;
        internal System.Windows.Forms.DataGridView dgvListadoCuentas;
        private System.Windows.Forms.TextBox txtDescGub;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.TextBox txtDescEmp;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigGub;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_GUBERNAMENTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_CUENTA_GUBERNAMENTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_EMPRESARIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_CUENTA_EMPRESARIAL;
        private System.Windows.Forms.GroupBox gbBuscar;
        internal System.Windows.Forms.Button btnRefrescar;
        internal System.Windows.Forms.Button btnCancelar;
    }
}