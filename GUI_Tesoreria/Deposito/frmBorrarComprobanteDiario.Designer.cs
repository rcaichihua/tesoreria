namespace GUI_Tesoreria.Deposito
{
    partial class frmBorrarComprobanteDiario
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
            this.rbRegularizacion = new System.Windows.Forms.RadioButton();
            this.rbInteres = new System.Windows.Forms.RadioButton();
            this.rbDepositoBanco = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaLiquidación = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRegularizacion);
            this.groupBox1.Controls.Add(this.rbInteres);
            this.groupBox1.Controls.Add(this.rbDepositoBanco);
            this.groupBox1.Location = new System.Drawing.Point(18, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 107);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            // 
            // rbRegularizacion
            // 
            this.rbRegularizacion.AutoSize = true;
            this.rbRegularizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegularizacion.Location = new System.Drawing.Point(31, 65);
            this.rbRegularizacion.Name = "rbRegularizacion";
            this.rbRegularizacion.Size = new System.Drawing.Size(109, 17);
            this.rbRegularizacion.TabIndex = 0;
            this.rbRegularizacion.Text = "Regularización";
            this.rbRegularizacion.UseVisualStyleBackColor = true;
            // 
            // rbInteres
            // 
            this.rbInteres.AutoSize = true;
            this.rbInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInteres.Location = new System.Drawing.Point(31, 42);
            this.rbInteres.Name = "rbInteres";
            this.rbInteres.Size = new System.Drawing.Size(77, 17);
            this.rbInteres.TabIndex = 0;
            this.rbInteres.Text = "Intereses";
            this.rbInteres.UseVisualStyleBackColor = true;
            // 
            // rbDepositoBanco
            // 
            this.rbDepositoBanco.AutoSize = true;
            this.rbDepositoBanco.Checked = true;
            this.rbDepositoBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositoBanco.Location = new System.Drawing.Point(31, 19);
            this.rbDepositoBanco.Name = "rbDepositoBanco";
            this.rbDepositoBanco.Size = new System.Drawing.Size(132, 17);
            this.rbDepositoBanco.TabIndex = 0;
            this.rbDepositoBanco.TabStop = true;
            this.rbDepositoBanco.Text = "Depósitos a Banco";
            this.rbDepositoBanco.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(15, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 165;
            this.Label2.Text = "Fecha";
            // 
            // dtpFechaLiquidación
            // 
            this.dtpFechaLiquidación.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidación.Location = new System.Drawing.Point(61, 9);
            this.dtpFechaLiquidación.Name = "dtpFechaLiquidación";
            this.dtpFechaLiquidación.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaLiquidación.TabIndex = 164;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(148, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 167;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Navy;
            this.btnBorrar.Image = global::GUI_Tesoreria.Properties.Resources.asignar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(50, 149);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(92, 36);
            this.btnBorrar.TabIndex = 163;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmBorrarComprobanteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 197);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaLiquidación);
            this.Controls.Add(this.btnBorrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrarComprobanteDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Borrar comprobante de Diario:::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRegularizacion;
        private System.Windows.Forms.RadioButton rbInteres;
        private System.Windows.Forms.RadioButton rbDepositoBanco;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidación;
        internal System.Windows.Forms.Button btnBorrar;
    }
}