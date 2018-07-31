namespace GUI_Tesoreria.cementerio
{
    partial class frmGenerarCuartel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuFinColumna = new System.Windows.Forms.NumericUpDown();
            this.nuFinalFila = new System.Windows.Forms.NumericUpDown();
            this.nuInicioColumna = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nuInicioFila = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFinColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFinalFila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuInicioColumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuInicioFila)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuFinColumna);
            this.groupBox1.Controls.Add(this.nuFinalFila);
            this.groupBox1.Controls.Add(this.nuInicioColumna);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nuInicioFila);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nuFinColumna
            // 
            this.nuFinColumna.Location = new System.Drawing.Point(310, 40);
            this.nuFinColumna.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nuFinColumna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuFinColumna.Name = "nuFinColumna";
            this.nuFinColumna.Size = new System.Drawing.Size(78, 20);
            this.nuFinColumna.TabIndex = 3;
            this.nuFinColumna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuFinalFila
            // 
            this.nuFinalFila.Location = new System.Drawing.Point(310, 14);
            this.nuFinalFila.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nuFinalFila.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuFinalFila.Name = "nuFinalFila";
            this.nuFinalFila.Size = new System.Drawing.Size(78, 20);
            this.nuFinalFila.TabIndex = 1;
            this.nuFinalFila.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuInicioColumna
            // 
            this.nuInicioColumna.Location = new System.Drawing.Point(119, 40);
            this.nuInicioColumna.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nuInicioColumna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuInicioColumna.Name = "nuInicioColumna";
            this.nuInicioColumna.Size = new System.Drawing.Size(78, 20);
            this.nuInicioColumna.TabIndex = 2;
            this.nuInicioColumna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fin de Columna";
            // 
            // nuInicioFila
            // 
            this.nuInicioFila.Location = new System.Drawing.Point(119, 14);
            this.nuInicioFila.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nuInicioFila.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuInicioFila.Name = "nuInicioFila";
            this.nuInicioFila.Size = new System.Drawing.Size(78, 20);
            this.nuInicioFila.TabIndex = 0;
            this.nuInicioFila.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Final de FIla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio de Columna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de FIla";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(172, 96);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(125, 23);
            this.cboEstado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(225, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(113, 146);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 35);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "&GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmGenerarCuartel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 184);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmGenerarCuartel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGenerarCuartel";
            this.Load += new System.EventHandler(this.frmGenerarCuartel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFinColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFinalFila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuInicioColumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuInicioFila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuFinalFila;
        private System.Windows.Forms.NumericUpDown nuInicioFila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuFinColumna;
        private System.Windows.Forms.NumericUpDown nuInicioColumna;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;

    }
}