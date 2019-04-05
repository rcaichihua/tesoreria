namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmFiltroFechaIngresos
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.mtbFechaLiquidacion = new System.Windows.Forms.MaskedTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkIngresoDiario = new System.Windows.Forms.RadioButton();
            this.chkReciboIngresos = new System.Windows.Forms.RadioButton();
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.GBPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 24);
            this.label3.TabIndex = 144;
            this.label3.Text = "REPORTES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(177, 173);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Navy;
            this.btnReporte.Image = global::GUI_Tesoreria.Properties.Resources.nuevodoc;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(59, 173);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(109, 42);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "&Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // mtbFechaLiquidacion
            // 
            this.mtbFechaLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFechaLiquidacion.ForeColor = System.Drawing.Color.Black;
            this.mtbFechaLiquidacion.Location = new System.Drawing.Point(172, 51);
            this.mtbFechaLiquidacion.Mask = "00/00/0000";
            this.mtbFechaLiquidacion.Name = "mtbFechaLiquidacion";
            this.mtbFechaLiquidacion.Size = new System.Drawing.Size(104, 21);
            this.mtbFechaLiquidacion.TabIndex = 0;
            this.mtbFechaLiquidacion.ValidatingType = typeof(System.DateTime);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(63, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 128;
            this.Label2.Text = "Fecha liquidación";
            // 
            // chkIngresoDiario
            // 
            this.chkIngresoDiario.AutoSize = true;
            this.chkIngresoDiario.Checked = true;
            this.chkIngresoDiario.Location = new System.Drawing.Point(33, 29);
            this.chkIngresoDiario.Name = "chkIngresoDiario";
            this.chkIngresoDiario.Size = new System.Drawing.Size(186, 17);
            this.chkIngresoDiario.TabIndex = 129;
            this.chkIngresoDiario.TabStop = true;
            this.chkIngresoDiario.Text = "Reporte de Ingresos Diarios.";
            this.chkIngresoDiario.UseVisualStyleBackColor = true;
            // 
            // chkReciboIngresos
            // 
            this.chkReciboIngresos.AutoSize = true;
            this.chkReciboIngresos.Location = new System.Drawing.Point(33, 52);
            this.chkReciboIngresos.Name = "chkReciboIngresos";
            this.chkReciboIngresos.Size = new System.Drawing.Size(197, 17);
            this.chkReciboIngresos.TabIndex = 130;
            this.chkReciboIngresos.Text = "Reporte de Recibos de Ingeso.";
            this.chkReciboIngresos.UseVisualStyleBackColor = true;
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.chkReciboIngresos);
            this.GBPago.Controls.Add(this.chkIngresoDiario);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 78);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(322, 89);
            this.GBPago.TabIndex = 145;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Filtro de ingresos";
            // 
            // frmFiltroFechaIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 228);
            this.Controls.Add(this.GBPago);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbFechaLiquidacion);
            this.Controls.Add(this.btnReporte);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroFechaIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Fecha de Liquidación:::...";
            this.Load += new System.EventHandler(this.frmFiltroFechaIngresos_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbFechaLiquidacion;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.RadioButton chkReciboIngresos;
        private System.Windows.Forms.RadioButton chkIngresoDiario;
        internal System.Windows.Forms.GroupBox GBPago;
    }
}