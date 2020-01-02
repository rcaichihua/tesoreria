namespace GUI_Tesoreria.caja
{
    partial class frmEdicionDetalleRecibo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtGlosa = new System.Windows.Forms.TextBox();
            this.Id_ReciboCabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODRUBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPRUBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.dgvRecibos);
            this.GroupBox2.Location = new System.Drawing.Point(12, 44);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(675, 206);
            this.GroupBox2.TabIndex = 120;
            this.GroupBox2.TabStop = false;
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            this.dgvRecibos.AllowUserToResizeColumns = false;
            this.dgvRecibos.AllowUserToResizeRows = false;
            this.dgvRecibos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ReciboCabecera,
            this.CODRUBRO,
            this.DESCRIPRUBRO,
            this.punit,
            this.cant,
            this.Total});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecibos.Location = new System.Drawing.Point(3, 16);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowHeadersWidth = 10;
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(669, 187);
            this.dgvRecibos.TabIndex = 83;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salirDoc;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(561, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 34);
            this.btnSalir.TabIndex = 122;
            this.btnSalir.Text = "&Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReporte.Image = global::GUI_Tesoreria.Properties.Resources.reporte;
            this.btnVerReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerReporte.Location = new System.Drawing.Point(561, 290);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(123, 34);
            this.btnVerReporte.TabIndex = 121;
            this.btnVerReporte.Text = "&Guardar";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(298, 32);
            this.LblTitulo.TabIndex = 125;
            this.LblTitulo.Text = "RC - 0000-00000000";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(14, 259);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 127;
            this.Label1.Text = "Glosa :";
            // 
            // txtGlosa
            // 
            this.txtGlosa.BackColor = System.Drawing.Color.White;
            this.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGlosa.Location = new System.Drawing.Point(64, 256);
            this.txtGlosa.Multiline = true;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGlosa.Size = new System.Drawing.Size(484, 104);
            this.txtGlosa.TabIndex = 128;
            // 
            // Id_ReciboCabecera
            // 
            this.Id_ReciboCabecera.DataPropertyName = "Id_ReciboCabecera";
            this.Id_ReciboCabecera.HeaderText = "Id_ReciboCabecera";
            this.Id_ReciboCabecera.Name = "Id_ReciboCabecera";
            this.Id_ReciboCabecera.ReadOnly = true;
            this.Id_ReciboCabecera.Visible = false;
            this.Id_ReciboCabecera.Width = 103;
            // 
            // CODRUBRO
            // 
            this.CODRUBRO.DataPropertyName = "CODRUBRO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODRUBRO.DefaultCellStyle = dataGridViewCellStyle9;
            this.CODRUBRO.HeaderText = "COD. RUB.";
            this.CODRUBRO.Name = "CODRUBRO";
            this.CODRUBRO.ReadOnly = true;
            this.CODRUBRO.Width = 80;
            // 
            // DESCRIPRUBRO
            // 
            this.DESCRIPRUBRO.DataPropertyName = "DESCRIPRUBRO";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DESCRIPRUBRO.DefaultCellStyle = dataGridViewCellStyle10;
            this.DESCRIPRUBRO.HeaderText = "DESCRIPCION";
            this.DESCRIPRUBRO.Name = "DESCRIPRUBRO";
            this.DESCRIPRUBRO.ReadOnly = true;
            this.DESCRIPRUBRO.Width = 300;
            // 
            // punit
            // 
            this.punit.DataPropertyName = "punit";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "n2";
            this.punit.DefaultCellStyle = dataGridViewCellStyle11;
            this.punit.HeaderText = "P. UNIT";
            this.punit.Name = "punit";
            this.punit.ReadOnly = true;
            this.punit.Width = 85;
            // 
            // cant
            // 
            this.cant.DataPropertyName = "cant";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "n2";
            this.cant.DefaultCellStyle = dataGridViewCellStyle12;
            this.cant.HeaderText = "CANT";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle13;
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 90;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI_Tesoreria.Properties.Resources.reporte;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(561, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 121;
            this.button1.Text = "&Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // frmEdicionDetalleRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 365);
            this.Controls.Add(this.txtGlosa);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.GroupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdicionDetalleRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Detalle Documento:::...";
            this.Load += new System.EventHandler(this.frmEdicionDetaleRecibo_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerReporte;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtGlosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ReciboCabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODRUBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPRUBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn punit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
    }
}