namespace GUI_Tesoreria.Deposito
{
    partial class frmReporteRegularizacion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLiqEnElMesDepoMesAnt = new System.Windows.Forms.RadioButton();
            this.rbLiqEnElMesDepoMesSigu = new System.Windows.Forms.RadioButton();
            this.rbDepoSinProgRegu = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaLiquidación = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(213, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 172;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLiqEnElMesDepoMesAnt);
            this.groupBox1.Controls.Add(this.rbLiqEnElMesDepoMesSigu);
            this.groupBox1.Controls.Add(this.rbDepoSinProgRegu);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 97);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            // 
            // rbLiqEnElMesDepoMesAnt
            // 
            this.rbLiqEnElMesDepoMesAnt.AutoSize = true;
            this.rbLiqEnElMesDepoMesAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLiqEnElMesDepoMesAnt.Location = new System.Drawing.Point(31, 65);
            this.rbLiqEnElMesDepoMesAnt.Name = "rbLiqEnElMesDepoMesAnt";
            this.rbLiqEnElMesDepoMesAnt.Size = new System.Drawing.Size(331, 17);
            this.rbLiqEnElMesDepoMesAnt.TabIndex = 0;
            this.rbLiqEnElMesDepoMesAnt.Text = "&Liquidados en el mes y depositados en el mes anterior";
            this.rbLiqEnElMesDepoMesAnt.UseVisualStyleBackColor = true;
            // 
            // rbLiqEnElMesDepoMesSigu
            // 
            this.rbLiqEnElMesDepoMesSigu.AutoSize = true;
            this.rbLiqEnElMesDepoMesSigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLiqEnElMesDepoMesSigu.Location = new System.Drawing.Point(31, 42);
            this.rbLiqEnElMesDepoMesSigu.Name = "rbLiqEnElMesDepoMesSigu";
            this.rbLiqEnElMesDepoMesSigu.Size = new System.Drawing.Size(339, 17);
            this.rbLiqEnElMesDepoMesSigu.TabIndex = 0;
            this.rbLiqEnElMesDepoMesSigu.Text = "&Liquidados en el mes y depositados en el mes siguiente";
            this.rbLiqEnElMesDepoMesSigu.UseVisualStyleBackColor = true;
            // 
            // rbDepoSinProgRegu
            // 
            this.rbDepoSinProgRegu.AutoSize = true;
            this.rbDepoSinProgRegu.Checked = true;
            this.rbDepoSinProgRegu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepoSinProgRegu.Location = new System.Drawing.Point(31, 19);
            this.rbDepoSinProgRegu.Name = "rbDepoSinProgRegu";
            this.rbDepoSinProgRegu.Size = new System.Drawing.Size(250, 17);
            this.rbDepoSinProgRegu.TabIndex = 0;
            this.rbDepoSinProgRegu.TabStop = true;
            this.rbDepoSinProgRegu.Text = "&Depositos sin programa - por regularizar";
            this.rbDepoSinProgRegu.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 170;
            this.Label2.Text = "Fecha";
            // 
            // dtpFechaLiquidación
            // 
            this.dtpFechaLiquidación.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidación.Location = new System.Drawing.Point(58, 9);
            this.dtpFechaLiquidación.Name = "dtpFechaLiquidación";
            this.dtpFechaLiquidación.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaLiquidación.TabIndex = 169;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Navy;
            this.btnAceptar.Image = global::GUI_Tesoreria.Properties.Resources.asignar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(115, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 36);
            this.btnAceptar.TabIndex = 168;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmReporteRegularizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 185);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaLiquidación);
            this.Controls.Add(this.btnAceptar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteRegularizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Reporte de Bancos (Regularizaciones):::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLiqEnElMesDepoMesAnt;
        private System.Windows.Forms.RadioButton rbLiqEnElMesDepoMesSigu;
        private System.Windows.Forms.RadioButton rbDepoSinProgRegu;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidación;
        internal System.Windows.Forms.Button btnAceptar;
    }
}