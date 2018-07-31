namespace GUI_Tesoreria.caja.Depositos
{
    partial class frmReporteBancoPorPrograma
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
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMismoMes = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(64, 125);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(75, 31);
            this.btnVerReporte.TabIndex = 0;
            this.btnVerReporte.Text = "&Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(145, 125);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(86, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha :";
            // 
            // chkMismoMes
            // 
            this.chkMismoMes.AutoSize = true;
            this.chkMismoMes.Location = new System.Drawing.Point(86, 64);
            this.chkMismoMes.Name = "chkMismoMes";
            this.chkMismoMes.Size = new System.Drawing.Size(138, 17);
            this.chkMismoMes.TabIndex = 4;
            this.chkMismoMes.Text = "Reporte del mismo mes.";
            this.chkMismoMes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.chkMismoMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // frmReporteBancoPorPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerReporte);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporteBancoPorPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteBancoPorPrograma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMismoMes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}