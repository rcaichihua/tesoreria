namespace GUI_Tesoreria.caja
{
    partial class frmIngresosporRubroCta
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
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.cboPrograma = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpFechaLiq = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReciboIngreso = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GBPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.txtRubro);
            this.GBPago.Controls.Add(this.label2);
            this.GBPago.Controls.Add(this.cboPrograma);
            this.GBPago.Controls.Add(this.label23);
            this.GBPago.Controls.Add(this.dtpFechaLiq);
            this.GBPago.Controls.Add(this.label1);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 12);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(467, 96);
            this.GBPago.TabIndex = 150;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Reporte de Ingresos";
            // 
            // cboPrograma
            // 
            this.cboPrograma.BackColor = System.Drawing.Color.White;
            this.cboPrograma.DropDownHeight = 200;
            this.cboPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrograma.DropDownWidth = 400;
            this.cboPrograma.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrograma.ForeColor = System.Drawing.Color.Black;
            this.cboPrograma.FormattingEnabled = true;
            this.cboPrograma.IntegralHeight = false;
            this.cboPrograma.Location = new System.Drawing.Point(250, 22);
            this.cboPrograma.Name = "cboPrograma";
            this.cboPrograma.Size = new System.Drawing.Size(193, 21);
            this.cboPrograma.TabIndex = 149;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(181, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 150;
            this.label23.Text = "Programa";
            // 
            // dtpFechaLiq
            // 
            this.dtpFechaLiq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiq.Location = new System.Drawing.Point(58, 19);
            this.dtpFechaLiq.Name = "dtpFechaLiq";
            this.dtpFechaLiq.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaLiq.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha :";
            // 
            // txtRubro
            // 
            this.txtRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRubro.Location = new System.Drawing.Point(250, 49);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(125, 21);
            this.txtRubro.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(134, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "CODIDO DE RUBRO";
            // 
            // btnReciboIngreso
            // 
            this.btnReciboIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciboIngreso.ForeColor = System.Drawing.Color.Navy;
            this.btnReciboIngreso.Image = global::GUI_Tesoreria.Properties.Resources.nuevodoc;
            this.btnReciboIngreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReciboIngreso.Location = new System.Drawing.Point(160, 114);
            this.btnReciboIngreso.Name = "btnReciboIngreso";
            this.btnReciboIngreso.Size = new System.Drawing.Size(78, 61);
            this.btnReciboIngreso.TabIndex = 153;
            this.btnReciboIngreso.Text = "&Recibo de Ingreso";
            this.btnReciboIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReciboIngreso.UseVisualStyleBackColor = true;
            this.btnReciboIngreso.Click += new System.EventHandler(this.btnReciboIngreso_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalir.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(246, 114);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 61);
            this.BtnSalir.TabIndex = 164;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmIngresosporRubroCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 182);
            this.Controls.Add(this.btnReciboIngreso);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresosporRubroCta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresosporRubroCta";
            this.Load += new System.EventHandler(this.frmIngresosporRubroCta_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBPago;
        internal System.Windows.Forms.ComboBox cboPrograma;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpFechaLiq;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtRubro;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReciboIngreso;
        internal System.Windows.Forms.Button BtnSalir;
    }
}