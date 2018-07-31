namespace GUI_Tesoreria.usuario
{
    partial class frmAccesoPorPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoPorPerfil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSubMenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMenuPrincipal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOpcionesSistema = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSeleccionar = new System.Windows.Forms.GroupBox();
            this.rdbNinguno = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcionesSistema)).BeginInit();
            this.grbSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboSubMenu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMenuPrincipal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPerfil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(760, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboSubMenu
            // 
            this.cboSubMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubMenu.FormattingEnabled = true;
            this.cboSubMenu.Location = new System.Drawing.Point(204, 85);
            this.cboSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSubMenu.Name = "cboSubMenu";
            this.cboSubMenu.Size = new System.Drawing.Size(308, 24);
            this.cboSubMenu.TabIndex = 1;
            this.cboSubMenu.SelectedIndexChanged += new System.EventHandler(this.cboSubMenu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(89, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SUB MENÚ";
            // 
            // cboMenuPrincipal
            // 
            this.cboMenuPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuPrincipal.FormattingEnabled = true;
            this.cboMenuPrincipal.Location = new System.Drawing.Point(204, 52);
            this.cboMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMenuPrincipal.Name = "cboMenuPrincipal";
            this.cboMenuPrincipal.Size = new System.Drawing.Size(308, 24);
            this.cboMenuPrincipal.TabIndex = 1;
            this.cboMenuPrincipal.SelectedIndexChanged += new System.EventHandler(this.cboMenuPrincipal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MENÚ PRINCIPAL";
            // 
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(204, 18);
            this.cboPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(193, 24);
            this.cboPerfil.TabIndex = 1;
            this.cboPerfil.SelectedIndexChanged += new System.EventHandler(this.cboPerfil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(123, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFÍL";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvOpcionesSistema);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(760, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENÚ";
            // 
            // dgvOpcionesSistema
            // 
            this.dgvOpcionesSistema.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpcionesSistema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpcionesSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpcionesSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column12,
            this.Column13,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.estado,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvOpcionesSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOpcionesSistema.EnableHeadersVisualStyles = false;
            this.dgvOpcionesSistema.Location = new System.Drawing.Point(4, 21);
            this.dgvOpcionesSistema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOpcionesSistema.Name = "dgvOpcionesSistema";
            this.dgvOpcionesSistema.ReadOnly = true;
            this.dgvOpcionesSistema.RowHeadersWidth = 28;
            this.dgvOpcionesSistema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpcionesSistema.Size = new System.Drawing.Size(752, 387);
            this.dgvOpcionesSistema.TabIndex = 0;
            this.dgvOpcionesSistema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpcionesSistema_CellContentClick);
            this.dgvOpcionesSistema.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvOpcionesSistema_CurrentCellDirtyStateChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "intMeId";
            this.Column1.HeaderText = "intMeId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "intMPID";
            this.Column12.HeaderText = "intMPID";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "intSMPID";
            this.Column13.HeaderText = "intSMPID";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "varMeNombreMenu";
            this.Column2.HeaderText = "Nombre Menú";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 450;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "varMeNombreVariable";
            this.Column3.HeaderText = "varMeNombreVariable";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "intMePadre";
            this.Column4.HeaderText = "intMePadre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "intMeOrden";
            this.Column5.HeaderText = "intMeOrden";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "bitAcEstado";
            this.estado.FalseValue = "false";
            this.estado.HeaderText = "Estado";
            this.estado.IndeterminateValue = "false";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.estado.TrueValue = "true";
            this.estado.Width = 60;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "intMeId_submenu0";
            this.Column7.HeaderText = "intMeId_submenu0";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "intMeId_submenu1";
            this.Column8.HeaderText = "intMeId_submenu1";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "intMeId_submenu2";
            this.Column9.HeaderText = "intMeId_submenu2";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "intMeId_submenu3";
            this.Column10.HeaderText = "intMeId_submenu3";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "intMeId_submenu4";
            this.Column11.HeaderText = "intMeId_submenu4";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // grbSeleccionar
            // 
            this.grbSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.grbSeleccionar.Controls.Add(this.rdbNinguno);
            this.grbSeleccionar.Controls.Add(this.rdbTodos);
            this.grbSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeleccionar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grbSeleccionar.Location = new System.Drawing.Point(20, 617);
            this.grbSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSeleccionar.Name = "grbSeleccionar";
            this.grbSeleccionar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSeleccionar.Size = new System.Drawing.Size(261, 55);
            this.grbSeleccionar.TabIndex = 63;
            this.grbSeleccionar.TabStop = false;
            this.grbSeleccionar.Text = "Seleccionar";
            // 
            // rdbNinguno
            // 
            this.rdbNinguno.AutoSize = true;
            this.rdbNinguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNinguno.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbNinguno.Location = new System.Drawing.Point(127, 20);
            this.rdbNinguno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNinguno.Name = "rdbNinguno";
            this.rdbNinguno.Size = new System.Drawing.Size(91, 22);
            this.rdbNinguno.TabIndex = 1;
            this.rdbNinguno.TabStop = true;
            this.rdbNinguno.Text = "&Ninguno";
            this.rdbNinguno.UseVisualStyleBackColor = true;
            this.rdbNinguno.CheckedChanged += new System.EventHandler(this.rdbNinguno_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbTodos.Location = new System.Drawing.Point(33, 20);
            this.rdbTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(77, 22);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "&Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(687, 617);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 90);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(589, 617);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 90);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.LblTitulo.Size = new System.Drawing.Size(743, 44);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "MANTENIMIENTO - ACCESO POR PERFIL";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAccesoPorPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 716);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbSeleccionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAccesoPorPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::ACCESO POR PERFIL:::...";
            this.Load += new System.EventHandler(this.frmAccesoPorPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpcionesSistema)).EndInit();
            this.grbSeleccionar.ResumeLayout(false);
            this.grbSeleccionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSubMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMenuPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox grbSeleccionar;
        internal System.Windows.Forms.RadioButton rdbNinguno;
        internal System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DataGridView dgvOpcionesSistema;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        internal System.Windows.Forms.Label LblTitulo;
    }
}