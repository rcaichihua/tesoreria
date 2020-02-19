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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.ReciboId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inttaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtGlosa = new System.Windows.Forms.TextBox();
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
            this.GroupBox2.Size = new System.Drawing.Size(757, 206);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciboId,
            this.Id_Recibodetalle,
            this.idrubro,
            this.inttaid,
            this.item_recibodetalle,
            this.precio_recibodetalle,
            this.cantidad_recibodetalle,
            this.total_recibodetalle});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecibos.Location = new System.Drawing.Point(3, 16);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowHeadersWidth = 10;
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(751, 187);
            this.dgvRecibos.TabIndex = 83;
            // 
            // ReciboId
            // 
            this.ReciboId.DataPropertyName = "ReciboId";
            this.ReciboId.HeaderText = "ReciboId";
            this.ReciboId.Name = "ReciboId";
            this.ReciboId.ReadOnly = true;
            this.ReciboId.Visible = false;
            // 
            // Id_Recibodetalle
            // 
            this.Id_Recibodetalle.DataPropertyName = "Id_Recibodetalle";
            this.Id_Recibodetalle.HeaderText = "Id_Recibodetalle";
            this.Id_Recibodetalle.Name = "Id_Recibodetalle";
            this.Id_Recibodetalle.ReadOnly = true;
            this.Id_Recibodetalle.Visible = false;
            this.Id_Recibodetalle.Width = 103;
            // 
            // idrubro
            // 
            this.idrubro.DataPropertyName = "idrubro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idrubro.DefaultCellStyle = dataGridViewCellStyle2;
            this.idrubro.HeaderText = "COD. RUB.";
            this.idrubro.Name = "idrubro";
            this.idrubro.ReadOnly = true;
            this.idrubro.Width = 80;
            // 
            // inttaid
            // 
            this.inttaid.DataPropertyName = "inttaid";
            this.inttaid.HeaderText = "COD TARIFA";
            this.inttaid.Name = "inttaid";
            this.inttaid.ReadOnly = true;
            this.inttaid.Width = 80;
            // 
            // item_recibodetalle
            // 
            this.item_recibodetalle.DataPropertyName = "item_recibodetalle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.item_recibodetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.item_recibodetalle.HeaderText = "DESCRIPCION";
            this.item_recibodetalle.Name = "item_recibodetalle";
            this.item_recibodetalle.ReadOnly = true;
            this.item_recibodetalle.Width = 300;
            // 
            // precio_recibodetalle
            // 
            this.precio_recibodetalle.DataPropertyName = "precio_recibodetalle";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.precio_recibodetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.precio_recibodetalle.HeaderText = "P. UNIT";
            this.precio_recibodetalle.Name = "precio_recibodetalle";
            this.precio_recibodetalle.ReadOnly = true;
            this.precio_recibodetalle.Width = 85;
            // 
            // cantidad_recibodetalle
            // 
            this.cantidad_recibodetalle.DataPropertyName = "cantidad_recibodetalle";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.cantidad_recibodetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.cantidad_recibodetalle.HeaderText = "CANT";
            this.cantidad_recibodetalle.Name = "cantidad_recibodetalle";
            this.cantidad_recibodetalle.ReadOnly = true;
            this.cantidad_recibodetalle.Width = 80;
            // 
            // total_recibodetalle
            // 
            this.total_recibodetalle.DataPropertyName = "total_recibodetalle";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.total_recibodetalle.DefaultCellStyle = dataGridViewCellStyle6;
            this.total_recibodetalle.HeaderText = "TOTAL";
            this.total_recibodetalle.Name = "total_recibodetalle";
            this.total_recibodetalle.ReadOnly = true;
            this.total_recibodetalle.Width = 90;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salirDoc;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(554, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(212, 34);
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
            this.btnVerReporte.Location = new System.Drawing.Point(554, 293);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(212, 34);
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
            this.LblTitulo.Size = new System.Drawing.Size(757, 32);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI_Tesoreria.Properties.Resources.reporte;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(554, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 121;
            this.button1.Text = "&Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // frmEdicionDetalleRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 365);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciboId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn inttaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_recibodetalle;
    }
}