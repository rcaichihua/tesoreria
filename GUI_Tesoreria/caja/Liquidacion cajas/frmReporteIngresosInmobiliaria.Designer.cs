namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmReporteIngresosInmobiliaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSalirC = new System.Windows.Forms.Button();
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.btnReporteIngresos = new System.Windows.Forms.Button();
            this.dtpFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInmobiliaria = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoSoles = new System.Windows.Forms.TextBox();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GBPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmobiliaria)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalirC
            // 
            this.BtnSalirC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalirC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirC.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalirC.Image = global::GUI_Tesoreria.Properties.Resources.salirDoc;
            this.BtnSalirC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalirC.Location = new System.Drawing.Point(1044, 15);
            this.BtnSalirC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalirC.Name = "BtnSalirC";
            this.BtnSalirC.Size = new System.Drawing.Size(80, 34);
            this.BtnSalirC.TabIndex = 162;
            this.BtnSalirC.Text = "&Salir";
            this.BtnSalirC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalirC.UseVisualStyleBackColor = false;
            this.BtnSalirC.Click += new System.EventHandler(this.BtnSalirC_Click);
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.BtnSalirC);
            this.GBPago.Controls.Add(this.btnExcel);
            this.GBPago.Controls.Add(this.btnReporteIngresos);
            this.GBPago.Controls.Add(this.dtpFechaLiquidacion);
            this.GBPago.Controls.Add(this.label1);
            this.GBPago.Controls.Add(this.dtpFechaCaja);
            this.GBPago.Controls.Add(this.label3);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(10, 12);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(1131, 57);
            this.GBPago.TabIndex = 163;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Filtro de liquidaciones";
            // 
            // btnReporteIngresos
            // 
            this.btnReporteIngresos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReporteIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteIngresos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteIngresos.ForeColor = System.Drawing.Color.Navy;
            this.btnReporteIngresos.Image = global::GUI_Tesoreria.Properties.Resources.nuevodoc;
            this.btnReporteIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteIngresos.Location = new System.Drawing.Point(438, 12);
            this.btnReporteIngresos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnReporteIngresos.Name = "btnReporteIngresos";
            this.btnReporteIngresos.Size = new System.Drawing.Size(163, 34);
            this.btnReporteIngresos.TabIndex = 166;
            this.btnReporteIngresos.Text = "&Reporte de Ingresos";
            this.btnReporteIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteIngresos.UseVisualStyleBackColor = false;
            this.btnReporteIngresos.Click += new System.EventHandler(this.btnReporteIngresos_Click);
            // 
            // dtpFechaLiquidacion
            // 
            this.dtpFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidacion.Location = new System.Drawing.Point(98, 15);
            this.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion";
            this.dtpFechaLiquidacion.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaLiquidacion.TabIndex = 2;
            this.dtpFechaLiquidacion.ValueChanged += new System.EventHandler(this.dtpFechaLiquidacion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Liqui";
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Enabled = false;
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(313, 17);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaCaja.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(222, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Caja";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvInmobiliaria);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(10, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 463);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado";
            // 
            // dgvInmobiliaria
            // 
            this.dgvInmobiliaria.AllowUserToAddRows = false;
            this.dgvInmobiliaria.AllowUserToDeleteRows = false;
            this.dgvInmobiliaria.AllowUserToResizeColumns = false;
            this.dgvInmobiliaria.AllowUserToResizeRows = false;
            this.dgvInmobiliaria.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInmobiliaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInmobiliaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInmobiliaria.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInmobiliaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInmobiliaria.Location = new System.Drawing.Point(3, 17);
            this.dgvInmobiliaria.Name = "dgvInmobiliaria";
            this.dgvInmobiliaria.ReadOnly = true;
            this.dgvInmobiliaria.RowHeadersVisible = false;
            this.dgvInmobiliaria.RowHeadersWidth = 10;
            this.dgvInmobiliaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInmobiliaria.Size = new System.Drawing.Size(1125, 443);
            this.dgvInmobiliaria.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Navy;
            this.btnExcel.Image = global::GUI_Tesoreria.Properties.Resources.excel_32_32;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(611, 12);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(82, 34);
            this.btnExcel.TabIndex = 166;
            this.btnExcel.Text = "&Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMora
            // 
            this.txtMora.BackColor = System.Drawing.Color.White;
            this.txtMora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMora.ForeColor = System.Drawing.Color.Maroon;
            this.txtMora.Location = new System.Drawing.Point(802, 549);
            this.txtMora.Name = "txtMora";
            this.txtMora.ReadOnly = true;
            this.txtMora.Size = new System.Drawing.Size(90, 21);
            this.txtMora.TabIndex = 170;
            this.txtMora.Text = "0.00";
            this.txtMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIgv
            // 
            this.txtIgv.BackColor = System.Drawing.Color.White;
            this.txtIgv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIgv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.Color.Maroon;
            this.txtIgv.Location = new System.Drawing.Point(664, 549);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(90, 21);
            this.txtIgv.TabIndex = 171;
            this.txtIgv.Text = "0.00";
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(760, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 166;
            this.label5.Text = "Mora";
            // 
            // txtMontoSoles
            // 
            this.txtMontoSoles.BackColor = System.Drawing.Color.White;
            this.txtMontoSoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoSoles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoSoles.ForeColor = System.Drawing.Color.Maroon;
            this.txtMontoSoles.Location = new System.Drawing.Point(1012, 549);
            this.txtMontoSoles.Name = "txtMontoSoles";
            this.txtMontoSoles.ReadOnly = true;
            this.txtMontoSoles.Size = new System.Drawing.Size(129, 21);
            this.txtMontoSoles.TabIndex = 172;
            this.txtMontoSoles.Text = "0.00";
            this.txtMontoSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRenta
            // 
            this.txtRenta.BackColor = System.Drawing.Color.White;
            this.txtRenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenta.ForeColor = System.Drawing.Color.Maroon;
            this.txtRenta.Location = new System.Drawing.Point(507, 549);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.ReadOnly = true;
            this.txtRenta.Size = new System.Drawing.Size(118, 21);
            this.txtRenta.TabIndex = 173;
            this.txtRenta.Text = "0.00";
            this.txtRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(898, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 167;
            this.label6.Text = "Monto Soles Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(631, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 168;
            this.label4.Text = "IGV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(465, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Renta";
            // 
            // frmReporteIngresosInmobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 591);
            this.Controls.Add(this.txtMora);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoSoles);
            this.Controls.Add(this.txtRenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporteIngresosInmobiliaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Reporte de Ingresos INMOBILIARIA:::...";
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmobiliaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnSalirC;
        internal System.Windows.Forms.GroupBox GBPago;
        internal System.Windows.Forms.Button btnReporteIngresos;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvInmobiliaria;
        internal System.Windows.Forms.TextBox txtMora;
        internal System.Windows.Forms.TextBox txtIgv;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtMontoSoles;
        internal System.Windows.Forms.TextBox txtRenta;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
    }
}