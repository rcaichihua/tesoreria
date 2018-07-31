namespace GUI_Tesoreria.canevaro
{
    partial class frmMantenimientoCtaCteResidente
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnCta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCtaCte = new System.Windows.Forms.DataGridView();
            this.AnioCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsolutoCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioIngCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioModCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaModCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcIngCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcModCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedEstacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCte)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResultado);
            this.splitContainer1.Panel2.Controls.Add(this.dgvCtaCte);
            this.splitContainer1.Size = new System.Drawing.Size(886, 475);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRecalcular);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.BtnCta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cboAnio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Location = new System.Drawing.Point(769, 12);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(95, 48);
            this.btnRecalcular.TabIndex = 116;
            this.btnRecalcular.Text = "&Recalcular mes seleccionado";
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit_32px;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(688, 12);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(61, 48);
            this.BtnSalir.TabIndex = 115;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.save_32px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(620, 12);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(61, 48);
            this.btnGuardar.TabIndex = 114;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnCta
            // 
            this.BtnCta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCta.Image = global::GUI_Tesoreria.Properties.Resources.west_direction_32px;
            this.BtnCta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCta.Location = new System.Drawing.Point(551, 12);
            this.BtnCta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCta.Name = "BtnCta";
            this.BtnCta.Size = new System.Drawing.Size(61, 48);
            this.BtnCta.TabIndex = 114;
            this.BtnCta.Text = "&Ver Cta";
            this.BtnCta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCta.UseVisualStyleBackColor = false;
            this.BtnCta.Click += new System.EventHandler(this.BtnCta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(25, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(59, 21);
            this.txtCodigo.TabIndex = 112;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(447, 41);
            this.cboAnio.Margin = new System.Windows.Forms.Padding(2);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(92, 21);
            this.cboAnio.TabIndex = 111;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(98, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(345, 21);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(445, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Año deuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(98, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de Residente";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombres});
            this.dgvResultado.Location = new System.Drawing.Point(110, 2);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(344, 148);
            this.dgvResultado.TabIndex = 1;
            this.dgvResultado.Visible = false;
            this.dgvResultado.DoubleClick += new System.EventHandler(this.dgvResultado_DoubleClick);
            this.dgvResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResultado_KeyDown);
            this.dgvResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvResultado_KeyPress);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 300;
            // 
            // dgvCtaCte
            // 
            this.dgvCtaCte.AllowUserToAddRows = false;
            this.dgvCtaCte.AllowUserToDeleteRows = false;
            this.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaCte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnioCta,
            this.IdCta,
            this.MesCta,
            this.FechaVencCta,
            this.InsolutoCta,
            this.EstadoCta,
            this.observaciones,
            this.UsuarioIngCta,
            this.UsuarioModCta,
            this.FechaIngCta,
            this.FechaModCta,
            this.pcIngCta,
            this.pcModCta,
            this.UsuarioEstacion,
            this.RedEstacion});
            this.dgvCtaCte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCtaCte.Location = new System.Drawing.Point(0, 0);
            this.dgvCtaCte.Name = "dgvCtaCte";
            this.dgvCtaCte.RowHeadersWidth = 23;
            this.dgvCtaCte.Size = new System.Drawing.Size(886, 396);
            this.dgvCtaCte.TabIndex = 0;
            this.dgvCtaCte.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtaCte_CellValueChanged);
            this.dgvCtaCte.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCtaCte_CurrentCellDirtyStateChanged);
            this.dgvCtaCte.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCtaCte_EditingControlShowing);
            this.dgvCtaCte.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCtaCte_RowHeaderMouseClick);
            this.dgvCtaCte.Click += new System.EventHandler(this.dgvCtaCte_Click);
            this.dgvCtaCte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCtaCte_KeyPress);
            // 
            // AnioCta
            // 
            this.AnioCta.DataPropertyName = "AFiscalCtacteResidente";
            this.AnioCta.HeaderText = "Año Deuda";
            this.AnioCta.Name = "AnioCta";
            this.AnioCta.ReadOnly = true;
            this.AnioCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AnioCta.Width = 80;
            // 
            // IdCta
            // 
            this.IdCta.DataPropertyName = "ctacteResidenteId";
            this.IdCta.HeaderText = "ID";
            this.IdCta.Name = "IdCta";
            this.IdCta.ReadOnly = true;
            this.IdCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdCta.Width = 70;
            // 
            // MesCta
            // 
            this.MesCta.DataPropertyName = "mes";
            this.MesCta.HeaderText = "Mes Deuda";
            this.MesCta.Name = "MesCta";
            this.MesCta.ReadOnly = true;
            this.MesCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaVencCta
            // 
            this.FechaVencCta.DataPropertyName = "DiaVencimientoCtacteResidente";
            this.FechaVencCta.HeaderText = "Fecha de Vencimiento";
            this.FechaVencCta.Name = "FechaVencCta";
            this.FechaVencCta.ReadOnly = true;
            this.FechaVencCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InsolutoCta
            // 
            this.InsolutoCta.DataPropertyName = "ImporteCtacteResidente";
            this.InsolutoCta.HeaderText = "Pension del Mes";
            this.InsolutoCta.Name = "InsolutoCta";
            this.InsolutoCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EstadoCta
            // 
            this.EstadoCta.DataPropertyName = "estado";
            this.EstadoCta.HeaderText = "Estado Cta";
            this.EstadoCta.Name = "EstadoCta";
            this.EstadoCta.ReadOnly = true;
            this.EstadoCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observaciones.Width = 250;
            // 
            // UsuarioIngCta
            // 
            this.UsuarioIngCta.DataPropertyName = "usuarioCreacion";
            this.UsuarioIngCta.HeaderText = "Usuario Ingresa Cta";
            this.UsuarioIngCta.Name = "UsuarioIngCta";
            this.UsuarioIngCta.ReadOnly = true;
            this.UsuarioIngCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UsuarioModCta
            // 
            this.UsuarioModCta.DataPropertyName = "usuarioModificacion";
            this.UsuarioModCta.HeaderText = "Usuario Modifica Cta";
            this.UsuarioModCta.Name = "UsuarioModCta";
            this.UsuarioModCta.ReadOnly = true;
            this.UsuarioModCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaIngCta
            // 
            this.FechaIngCta.DataPropertyName = "fechaGeneracion";
            this.FechaIngCta.HeaderText = "Fecha Generacion Cta";
            this.FechaIngCta.Name = "FechaIngCta";
            this.FechaIngCta.ReadOnly = true;
            this.FechaIngCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaModCta
            // 
            this.FechaModCta.DataPropertyName = "fechaModificacion";
            this.FechaModCta.HeaderText = "Fecha Modificacion Cta";
            this.FechaModCta.Name = "FechaModCta";
            this.FechaModCta.ReadOnly = true;
            this.FechaModCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pcIngCta
            // 
            this.pcIngCta.DataPropertyName = "pcIngresaCta";
            this.pcIngCta.HeaderText = "PC Ingresa Cta";
            this.pcIngCta.Name = "pcIngCta";
            this.pcIngCta.ReadOnly = true;
            this.pcIngCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pcModCta
            // 
            this.pcModCta.DataPropertyName = "pcModificaCta";
            this.pcModCta.HeaderText = "PC modifica Cta";
            this.pcModCta.Name = "pcModCta";
            this.pcModCta.ReadOnly = true;
            this.pcModCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UsuarioEstacion
            // 
            this.UsuarioEstacion.DataPropertyName = "UsuarioEstacion";
            this.UsuarioEstacion.HeaderText = "Usuario PC";
            this.UsuarioEstacion.Name = "UsuarioEstacion";
            this.UsuarioEstacion.ReadOnly = true;
            this.UsuarioEstacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RedEstacion
            // 
            this.RedEstacion.DataPropertyName = "RedEstacion";
            this.RedEstacion.HeaderText = "IP Pc";
            this.RedEstacion.Name = "RedEstacion";
            this.RedEstacion.ReadOnly = true;
            this.RedEstacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmMantenimientoCtaCteResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 475);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoCtaCteResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Cuenta Corriente:::...";
            this.Load += new System.EventHandler(this.frmMantenimientoCtaCteResidente_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaCte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCtaCte;
        private System.Windows.Forms.ComboBox cboAnio;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvResultado;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnCta;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsolutoCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioIngCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioModCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaModCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcIngCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcModCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioEstacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedEstacion;
        private System.Windows.Forms.Button btnRecalcular;
    }
}