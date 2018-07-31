namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantRegistrarCaja
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
            this.dgvAgregarCaja = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMac = new System.Windows.Forms.ComboBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarCaja)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(247, 608);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(455, 608);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(39, 608);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(351, 608);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(143, 608);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(559, 608);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvAgregarCaja);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(668, 393);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            // 
            // dgvAgregarCaja
            // 
            this.dgvAgregarCaja.AllowUserToAddRows = false;
            this.dgvAgregarCaja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgregarCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column3,
            this.descripcion_MAC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgregarCaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgregarCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgregarCaja.EnableHeadersVisualStyles = false;
            this.dgvAgregarCaja.Location = new System.Drawing.Point(4, 19);
            this.dgvAgregarCaja.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAgregarCaja.Name = "dgvAgregarCaja";
            this.dgvAgregarCaja.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgregarCaja.RowHeadersWidth = 25;
            this.dgvAgregarCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregarCaja.Size = new System.Drawing.Size(660, 370);
            this.dgvAgregarCaja.TabIndex = 0;
            this.dgvAgregarCaja.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregarCaja_CellEnter);
            this.dgvAgregarCaja.Click += new System.EventHandler(this.dgvAgregarCaja_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "codigo";
            this.Column8.HeaderText = "Codigo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Descripcion";
            this.Column1.HeaderText = "Descripcion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 240;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "mac";
            this.Column3.HeaderText = "Mac";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // descripcion_MAC
            // 
            this.descripcion_MAC.DataPropertyName = "descripcion_MAC";
            this.descripcion_MAC.HeaderText = "descripcion_MAC";
            this.descripcion_MAC.Name = "descripcion_MAC";
            this.descripcion_MAC.ReadOnly = true;
            this.descripcion_MAC.Width = 150;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.cboMac);
            this.GroupBox1.Controls.Add(this.cboUsuario);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtDescripcion);
            this.GroupBox1.Controls.Add(this.txtParametro);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(16, 59);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(668, 142);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(400, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parametro";
            this.label3.Visible = false;
            // 
            // cboMac
            // 
            this.cboMac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMac.DropDownWidth = 320;
            this.cboMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMac.FormattingEnabled = true;
            this.cboMac.Location = new System.Drawing.Point(341, 43);
            this.cboMac.Margin = new System.Windows.Forms.Padding(4);
            this.cboMac.Name = "cboMac";
            this.cboMac.Size = new System.Drawing.Size(308, 26);
            this.cboMac.TabIndex = 2;
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(12, 97);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(308, 26);
            this.cboUsuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(337, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificador Unico MAC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(81, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripciòn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(8, 21);
            this.lbl12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(24, 18);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "ID";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(85, 43);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(235, 24);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtParametro
            // 
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(507, 97);
            this.txtParametro.Margin = new System.Windows.Forms.Padding(4);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(143, 24);
            this.txtParametro.TabIndex = 1;
            this.txtParametro.Text = "1";
            this.txtParametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParametro.Visible = false;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 24);
            this.txtId.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(16, 11);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(669, 44);
            this.LblTitulo.TabIndex = 102;
            this.LblTitulo.Text = "MANTENIMIENTO - CAJA";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMantRegistrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 711);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMantRegistrarCaja";
            this.Text = "...:::Mantenimiento de Caja:::...";
            this.Load += new System.EventHandler(this.frmMantRegistrarCaja_Load);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.LblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarCaja)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAgregarCaja;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboUsuario;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtParametro;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.ComboBox cboMac;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_MAC;
    }
}