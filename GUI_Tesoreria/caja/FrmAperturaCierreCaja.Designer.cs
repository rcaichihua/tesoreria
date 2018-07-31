namespace GUI_Tesoreria.caja
{
    partial class FrmAperturaCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAperturaCierreCaja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtMontInicial = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAperturaCaja = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperturaCaja)).BeginInit();
            this.SuspendLayout();
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
            this.LblTitulo.Size = new System.Drawing.Size(442, 36);
            this.LblTitulo.TabIndex = 105;
            this.LblTitulo.Text = "::::   APERTURA DE CAJA   ::::";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.btnGuardar);
            this.GroupBox1.Controls.Add(this.btnSalir);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtMontInicial);
            this.GroupBox1.Controls.Add(this.txtHora);
            this.GroupBox1.Controls.Add(this.txtFecha);
            this.GroupBox1.Controls.Add(this.txtCajero);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(446, 135);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(284, 49);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 73);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(362, 49);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 73);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label3.Location = new System.Drawing.Point(23, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(90, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Monto inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(75, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(67, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Fecha";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(64, 23);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(49, 15);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "Cajero";
            // 
            // txtMontInicial
            // 
            this.txtMontInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontInicial.Location = new System.Drawing.Point(125, 101);
            this.txtMontInicial.Name = "txtMontInicial";
            this.txtMontInicial.Size = new System.Drawing.Size(153, 21);
            this.txtMontInicial.TabIndex = 3;
            this.txtMontInicial.Text = "0";
            this.txtMontInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontInicial_KeyPress);
            // 
            // txtHora
            // 
            this.txtHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(125, 74);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(153, 21);
            this.txtHora.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(125, 47);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(153, 21);
            this.txtFecha.TabIndex = 1;
            // 
            // txtCajero
            // 
            this.txtCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajero.Location = new System.Drawing.Point(125, 20);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.ReadOnly = true;
            this.txtCajero.Size = new System.Drawing.Size(309, 21);
            this.txtCajero.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(41, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nro de Recibo";
            // 
            // txtVoucher
            // 
            this.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(152, 343);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.ReadOnly = true;
            this.txtVoucher.Size = new System.Drawing.Size(153, 21);
            this.txtVoucher.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvAperturaCaja);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 148);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            // 
            // dgvAperturaCaja
            // 
            this.dgvAperturaCaja.AllowUserToAddRows = false;
            this.dgvAperturaCaja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAperturaCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAperturaCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAperturaCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column8,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAperturaCaja.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAperturaCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAperturaCaja.EnableHeadersVisualStyles = false;
            this.dgvAperturaCaja.Location = new System.Drawing.Point(3, 16);
            this.dgvAperturaCaja.Name = "dgvAperturaCaja";
            this.dgvAperturaCaja.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAperturaCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAperturaCaja.RowHeadersWidth = 25;
            this.dgvAperturaCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAperturaCaja.Size = new System.Drawing.Size(440, 129);
            this.dgvAperturaCaja.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cod_TipoDocVenta";
            this.Column3.HeaderText = "cod_TipoDocVenta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Desc_TipoDocVenta";
            this.Column8.HeaderText = "Documento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "serie";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Serie";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nroComprobante";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Correlativo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 160;
            // 
            // FrmAperturaCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVoucher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAperturaCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Apertura de caja:::...";
            this.Load += new System.EventHandler(this.FrmAperturaCierreCaja_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperturaCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.TextBox txtCajero;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtMontInicial;
        internal System.Windows.Forms.TextBox txtVoucher;
        internal System.Windows.Forms.TextBox txtHora;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAperturaCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}