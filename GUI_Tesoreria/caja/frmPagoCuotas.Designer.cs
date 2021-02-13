namespace GUI_Tesoreria.caja
{
    partial class frmPagoCuotas
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
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCuotas = new System.Windows.Forms.TextBox();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.nrocuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.groupBox1);
            this.GBPago.Controls.Add(this.btnDisminuir);
            this.GBPago.Controls.Add(this.btnAgregar);
            this.GBPago.Controls.Add(this.txtCuotas);
            this.GBPago.Controls.Add(this.label30);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 12);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(273, 328);
            this.GBPago.TabIndex = 2;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Asignación de cuotas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCuotas);
            this.groupBox1.Location = new System.Drawing.Point(21, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 261);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.AllowUserToAddRows = false;
            this.dgvCuotas.AllowUserToDeleteRows = false;
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrocuotas,
            this.importe});
            this.dgvCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuotas.Location = new System.Drawing.Point(3, 17);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.RowHeadersWidth = 25;
            this.dgvCuotas.Size = new System.Drawing.Size(226, 241);
            this.dgvCuotas.TabIndex = 0;
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisminuir.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.ForeColor = System.Drawing.Color.Navy;
            this.btnDisminuir.Image = global::GUI_Tesoreria.Properties.Resources.eliminarV;
            this.btnDisminuir.Location = new System.Drawing.Point(209, 22);
            this.btnDisminuir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(44, 33);
            this.btnDisminuir.TabIndex = 121;
            this.btnDisminuir.UseVisualStyleBackColor = false;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregar.Image = global::GUI_Tesoreria.Properties.Resources.agregarpago;
            this.btnAgregar.Location = new System.Drawing.Point(155, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 33);
            this.btnAgregar.TabIndex = 121;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCuotas
            // 
            this.txtCuotas.BackColor = System.Drawing.Color.White;
            this.txtCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuotas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCuotas.Location = new System.Drawing.Point(21, 33);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.ReadOnly = true;
            this.txtCuotas.Size = new System.Drawing.Size(52, 21);
            this.txtCuotas.TabIndex = 5;
            this.txtCuotas.Text = "0";
            this.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Location = new System.Drawing.Point(21, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Cuotas :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Documento";
            // 
            // txtTotalDocumento
            // 
            this.txtTotalDocumento.BackColor = System.Drawing.Color.White;
            this.txtTotalDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalDocumento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalDocumento.Location = new System.Drawing.Point(12, 358);
            this.txtTotalDocumento.Name = "txtTotalDocumento";
            this.txtTotalDocumento.ReadOnly = true;
            this.txtTotalDocumento.Size = new System.Drawing.Size(95, 21);
            this.txtTotalDocumento.TabIndex = 5;
            this.txtTotalDocumento.Text = "0.00";
            this.txtTotalDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(187, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Cuotas";
            // 
            // txtTotalCuotas
            // 
            this.txtTotalCuotas.BackColor = System.Drawing.Color.White;
            this.txtTotalCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCuotas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCuotas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalCuotas.Location = new System.Drawing.Point(170, 357);
            this.txtTotalCuotas.Name = "txtTotalCuotas";
            this.txtTotalCuotas.ReadOnly = true;
            this.txtTotalCuotas.Size = new System.Drawing.Size(95, 21);
            this.txtTotalCuotas.TabIndex = 5;
            this.txtTotalCuotas.Text = "0.00";
            this.txtTotalCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCancelar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.ForeColor = System.Drawing.Color.Navy;
            this.bntCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.bntCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntCancelar.Location = new System.Drawing.Point(153, 384);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(74, 47);
            this.bntCancelar.TabIndex = 121;
            this.bntCancelar.Text = "&Cancelar";
            this.bntCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntCancelar.UseVisualStyleBackColor = false;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.Color.Navy;
            this.btnSumar.Image = global::GUI_Tesoreria.Properties.Resources.sigma_32_32;
            this.btnSumar.Location = new System.Drawing.Point(115, 346);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(47, 33);
            this.btnSumar.TabIndex = 121;
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Navy;
            this.btnGenerar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerar.Location = new System.Drawing.Point(69, 384);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(74, 47);
            this.btnGenerar.TabIndex = 121;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // nrocuotas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nrocuotas.DefaultCellStyle = dataGridViewCellStyle1;
            this.nrocuotas.HeaderText = "Nº Cuota";
            this.nrocuotas.Name = "nrocuotas";
            this.nrocuotas.ReadOnly = true;
            this.nrocuotas.Width = 80;
            // 
            // importe
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.importe.DefaultCellStyle = dataGridViewCellStyle2;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // frmPagoCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 433);
            this.Controls.Add(this.GBPago);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtTotalCuotas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDocumento);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagoCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Cuotas:::...";
            this.Load += new System.EventHandler(this.frmPagoCuotas_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBPago;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.TextBox txtCuotas;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCuotas;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtTotalDocumento;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTotalCuotas;
        internal System.Windows.Forms.Button btnGenerar;
        internal System.Windows.Forms.Button bntCancelar;
        internal System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}