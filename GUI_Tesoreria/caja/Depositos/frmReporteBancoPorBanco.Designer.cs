namespace GUI_Tesoreria.caja.Depositos
{
    partial class frmReporteBancoPorBanco
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
            this.label25 = new System.Windows.Forms.Label();
            this.cboEntidadFinanciera = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.GBPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.label25);
            this.GBPago.Controls.Add(this.cboEntidadFinanciera);
            this.GBPago.Controls.Add(this.dtpFechaHasta);
            this.GBPago.Controls.Add(this.label27);
            this.GBPago.Controls.Add(this.label2);
            this.GBPago.Controls.Add(this.dtpFechaDesde);
            this.GBPago.Controls.Add(this.cboCuenta);
            this.GBPago.Controls.Add(this.label1);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 12);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(378, 163);
            this.GBPago.TabIndex = 149;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Filtro de Vouchers por Banco y Cuenta";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(30, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 13);
            this.label25.TabIndex = 153;
            this.label25.Text = "Cuenta Bancaria";
            // 
            // cboEntidadFinanciera
            // 
            this.cboEntidadFinanciera.BackColor = System.Drawing.Color.White;
            this.cboEntidadFinanciera.DropDownHeight = 200;
            this.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidadFinanciera.DropDownWidth = 300;
            this.cboEntidadFinanciera.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntidadFinanciera.ForeColor = System.Drawing.Color.Black;
            this.cboEntidadFinanciera.FormattingEnabled = true;
            this.cboEntidadFinanciera.IntegralHeight = false;
            this.cboEntidadFinanciera.Location = new System.Drawing.Point(135, 35);
            this.cboEntidadFinanciera.Name = "cboEntidadFinanciera";
            this.cboEntidadFinanciera.Size = new System.Drawing.Size(237, 21);
            this.cboEntidadFinanciera.TabIndex = 150;
            this.cboEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboEntidadFinanciera_SelectedIndexChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(135, 116);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(115, 21);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Navy;
            this.label27.Location = new System.Drawing.Point(88, 38);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 13);
            this.label27.TabIndex = 152;
            this.label27.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(89, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(135, 89);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(115, 21);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // cboCuenta
            // 
            this.cboCuenta.BackColor = System.Drawing.Color.White;
            this.cboCuenta.DropDownHeight = 150;
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.DropDownWidth = 300;
            this.cboCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.ForeColor = System.Drawing.Color.Black;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.IntegralHeight = false;
            this.cboCuenta.Items.AddRange(new object[] {
            "[seleccione]"});
            this.cboCuenta.Location = new System.Drawing.Point(135, 62);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(237, 21);
            this.cboCuenta.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(87, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salirDoc;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(213, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 46);
            this.btnSalir.TabIndex = 148;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReporte.Image = global::GUI_Tesoreria.Properties.Resources.reporte;
            this.btnVerReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerReporte.Location = new System.Drawing.Point(98, 181);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(109, 46);
            this.btnVerReporte.TabIndex = 147;
            this.btnVerReporte.Text = "&Ver Reporte";
            this.btnVerReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // frmReporteBancoPorBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 240);
            this.Controls.Add(this.GBPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerReporte);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporteBancoPorBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Filtro por Cuenta:::...";
            this.Load += new System.EventHandler(this.frmReporteBancoPorBanco_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBPago;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cboCuenta;
        internal System.Windows.Forms.ComboBox cboEntidadFinanciera;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label25;
    }
}