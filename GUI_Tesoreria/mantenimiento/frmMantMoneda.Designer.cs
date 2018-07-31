namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantMoneda));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMoneda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActivoMoneda = new System.Windows.Forms.CheckBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAbreviaturaMoneda = new System.Windows.Forms.TextBox();
            this.txtDescripcionMoneda = new System.Windows.Forms.TextBox();
            this.txtCodigoMoneda = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvMoneda);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 192);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            // 
            // dgvMoneda
            // 
            this.dgvMoneda.AllowUserToAddRows = false;
            this.dgvMoneda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMoneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMoneda.EnableHeadersVisualStyles = false;
            this.dgvMoneda.Location = new System.Drawing.Point(3, 16);
            this.dgvMoneda.Name = "dgvMoneda";
            this.dgvMoneda.ReadOnly = true;
            this.dgvMoneda.RowHeadersWidth = 25;
            this.dgvMoneda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoneda.Size = new System.Drawing.Size(548, 173);
            this.dgvMoneda.TabIndex = 0;
            this.dgvMoneda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoneda_CellEnter);
            this.dgvMoneda.Click += new System.EventHandler(this.dgvMoneda_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "intMoId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "varMoDescripcion";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bitMoEstado";
            this.Column3.FalseValue = "false";
            this.Column3.HeaderText = "Estado";
            this.Column3.IndeterminateValue = "false";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.TrueValue = "true";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "varMoAbreviatura";
            this.Column4.HeaderText = "Abreviatura";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.chkActivoMoneda);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtAbreviaturaMoneda);
            this.GroupBox1.Controls.Add(this.txtDescripcionMoneda);
            this.GroupBox1.Controls.Add(this.txtCodigoMoneda);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(554, 118);
            this.GroupBox1.TabIndex = 98;
            this.GroupBox1.TabStop = false;
            // 
            // chkActivoMoneda
            // 
            this.chkActivoMoneda.AutoSize = true;
            this.chkActivoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivoMoneda.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkActivoMoneda.Location = new System.Drawing.Point(319, 76);
            this.chkActivoMoneda.Name = "chkActivoMoneda";
            this.chkActivoMoneda.Size = new System.Drawing.Size(63, 19);
            this.chkActivoMoneda.TabIndex = 6;
            this.chkActivoMoneda.Text = "Activo";
            this.chkActivoMoneda.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label4.Location = new System.Drawing.Point(77, 82);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 15);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Abreviatura";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(42, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(114, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Nombre moneda";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label1.Location = new System.Drawing.Point(104, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Codigo";
            // 
            // txtAbreviaturaMoneda
            // 
            this.txtAbreviaturaMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbreviaturaMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviaturaMoneda.Location = new System.Drawing.Point(162, 76);
            this.txtAbreviaturaMoneda.Name = "txtAbreviaturaMoneda";
            this.txtAbreviaturaMoneda.Size = new System.Drawing.Size(151, 21);
            this.txtAbreviaturaMoneda.TabIndex = 2;
            // 
            // txtDescripcionMoneda
            // 
            this.txtDescripcionMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMoneda.Location = new System.Drawing.Point(162, 49);
            this.txtDescripcionMoneda.Name = "txtDescripcionMoneda";
            this.txtDescripcionMoneda.Size = new System.Drawing.Size(356, 21);
            this.txtDescripcionMoneda.TabIndex = 1;
            // 
            // txtCodigoMoneda
            // 
            this.txtCodigoMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMoneda.Location = new System.Drawing.Point(162, 23);
            this.txtCodigoMoneda.MaxLength = 4;
            this.txtCodigoMoneda.Name = "txtCodigoMoneda";
            this.txtCodigoMoneda.ReadOnly = true;
            this.txtCodigoMoneda.Size = new System.Drawing.Size(47, 21);
            this.txtCodigoMoneda.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(212, 367);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 73);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(368, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 73);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(56, 367);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 73);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(290, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 73);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(134, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 73);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(446, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 73);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(11, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(554, 36);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "MANTENIMIENTO - MONEDA";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMantMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 454);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Mantenimiento Moneda:::...";
            this.Load += new System.EventHandler(this.frmMantMoneda_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneda)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMoneda;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAbreviaturaMoneda;
        internal System.Windows.Forms.TextBox txtDescripcionMoneda;
        internal System.Windows.Forms.TextBox txtCodigoMoneda;
        private System.Windows.Forms.CheckBox chkActivoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.Label LblTitulo;
    }
}