namespace GUI_Tesoreria.Deposito
{
    partial class frmMigraDiario
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblCantidadProcesos = new System.Windows.Forms.Label();
            this.progressbar = new MetroFramework.Controls.MetroProgressBar();
            this.gbDiario = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.gbDiario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentaje.Location = new System.Drawing.Point(74, 249);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(114, 13);
            this.lblPorcentaje.TabIndex = 14;
            this.lblPorcentaje.Text = "Transfiriendo... 0%";
            // 
            // lblCantidadProcesos
            // 
            this.lblCantidadProcesos.AutoSize = true;
            this.lblCantidadProcesos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProcesos.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidadProcesos.Location = new System.Drawing.Point(12, 249);
            this.lblCantidadProcesos.Name = "lblCantidadProcesos";
            this.lblCantidadProcesos.Size = new System.Drawing.Size(12, 13);
            this.lblCantidadProcesos.TabIndex = 13;
            this.lblCantidadProcesos.Text = "-";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(12, 223);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(238, 23);
            this.progressbar.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressbar.TabIndex = 12;
            // 
            // gbDiario
            // 
            this.gbDiario.Controls.Add(this.btnCancelar);
            this.gbDiario.Controls.Add(this.btnAceptar);
            this.gbDiario.Controls.Add(this.groupBox2);
            this.gbDiario.Location = new System.Drawing.Point(12, 12);
            this.gbDiario.Name = "gbDiario";
            this.gbDiario.Size = new System.Drawing.Size(238, 205);
            this.gbDiario.TabIndex = 11;
            this.gbDiario.TabStop = false;
            this.gbDiario.Text = "DIARIO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(121, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 47);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(31, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 47);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAnio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(19, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.Color.White;
            this.txtAnio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.Color.Maroon;
            this.txtAnio.Location = new System.Drawing.Point(79, 47);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(87, 22);
            this.txtAnio.TabIndex = 1;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnio_KeyDown);
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Año";
            // 
            // txtMes
            // 
            this.txtMes.BackColor = System.Drawing.Color.White;
            this.txtMes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.ForeColor = System.Drawing.Color.Maroon;
            this.txtMes.Location = new System.Drawing.Point(79, 19);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(87, 22);
            this.txtMes.TabIndex = 0;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMes_KeyDown);
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(43, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mes";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmMigraDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 273);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblCantidadProcesos);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.gbDiario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMigraDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Migración de Diario:::...";
            this.gbDiario.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPorcentaje;
        internal System.Windows.Forms.Label lblCantidadProcesos;
        private MetroFramework.Controls.MetroProgressBar progressbar;
        public System.Windows.Forms.GroupBox gbDiario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtAnio;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtMes;
        internal System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}