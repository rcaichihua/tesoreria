namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantCuentasBancarias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCtaBancaria = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboCtaContable = new System.Windows.Forms.ComboBox();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtCtaBancaria = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaBancaria)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(616, 65);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(538, 144);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(460, 65);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(460, 144);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(538, 65);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(616, 144);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvCtaBancaria);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 220);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // dgvCtaBancaria
            // 
            this.dgvCtaBancaria.AllowUserToAddRows = false;
            this.dgvCtaBancaria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaBancaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCtaBancaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaBancaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCtaBancaria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCtaBancaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCtaBancaria.EnableHeadersVisualStyles = false;
            this.dgvCtaBancaria.Location = new System.Drawing.Point(3, 16);
            this.dgvCtaBancaria.Name = "dgvCtaBancaria";
            this.dgvCtaBancaria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtaBancaria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCtaBancaria.RowHeadersWidth = 25;
            this.dgvCtaBancaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCtaBancaria.Size = new System.Drawing.Size(667, 201);
            this.dgvCtaBancaria.TabIndex = 0;
            this.dgvCtaBancaria.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtaBancaria_CellEnter);
            this.dgvCtaBancaria.CurrentCellChanged += new System.EventHandler(this.dgvCtaBancaria_CurrentCellChanged);
            this.dgvCtaBancaria.Click += new System.EventHandler(this.dgvCtaBancaria_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cuenta_bancaria_id";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "numero_cuenta";
            this.Column1.HeaderText = "Cta Bancaria";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "codigoCuenta";
            this.Column2.HeaderText = "Cta contable";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 240;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nombre_entidad";
            this.Column3.HeaderText = "Banco";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "varMoDescripcion";
            this.Column4.HeaderText = "Moneda";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.cboCtaContable);
            this.GroupBox1.Controls.Add(this.cboMoneda);
            this.GroupBox1.Controls.Add(this.cboBanco);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtBuscar);
            this.GroupBox1.Controls.Add(this.txtCtaBancaria);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(15, 52);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(439, 165);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(62, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Moneda";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(74, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Banco";
            // 
            // cboCtaContable
            // 
            this.cboCtaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCtaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCtaContable.FormattingEnabled = true;
            this.cboCtaContable.Location = new System.Drawing.Point(127, 71);
            this.cboCtaContable.Name = "cboCtaContable";
            this.cboCtaContable.Size = new System.Drawing.Size(184, 23);
            this.cboCtaContable.TabIndex = 2;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(127, 129);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(146, 23);
            this.cboMoneda.TabIndex = 5;
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(127, 100);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(184, 23);
            this.cboBanco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cuenta Bancaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta Contable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(314, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar...";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(100, 20);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(21, 15);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "ID";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(317, 71);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(112, 21);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_TextChanged);
            // 
            // txtCtaBancaria
            // 
            this.txtCtaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCtaBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtaBancaria.Location = new System.Drawing.Point(127, 44);
            this.txtCtaBancaria.Name = "txtCtaBancaria";
            this.txtCtaBancaria.Size = new System.Drawing.Size(184, 21);
            this.txtCtaBancaria.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(127, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 21);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(23, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro por Cuenta Contable";
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(204, 233);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 21);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegistros.Location = new System.Drawing.Point(26, 483);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(59, 15);
            this.lblRegistros.TabIndex = 100;
            this.lblRegistros.Text = "1 de 100";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(15, 13);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(673, 36);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "MANTENIMIENTO - CTAS BANCARIAS";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMantCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 519);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantCuentasBancarias";
            this.Text = "...:::Mantenimiento cuenta Bancaria:::...";
            this.Load += new System.EventHandler(this.frmMantCuentasBancarias_Load);
            this.Controls.SetChildIndex(this.txtFiltro, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.LblTitulo, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaBancaria)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCtaBancaria;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtCtaBancaria;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.ComboBox cboCtaContable;
        internal System.Windows.Forms.ComboBox cboMoneda;
        internal System.Windows.Forms.ComboBox cboBanco;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtFiltro;
        internal System.Windows.Forms.Label lblRegistros;
        internal System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}