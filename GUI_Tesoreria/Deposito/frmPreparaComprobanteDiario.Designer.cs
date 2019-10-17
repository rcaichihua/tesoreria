namespace GUI_Tesoreria.Deposito
{
    partial class frmPreparaComprobanteDiario
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
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaLiquidación = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLiqMesAnt = new System.Windows.Forms.RadioButton();
            this.rbSinProgRegula = new System.Windows.Forms.RadioButton();
            this.rbDepositoBanco = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(45, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 160;
            this.Label2.Text = "Fecha";
            // 
            // dtpFechaLiquidación
            // 
            this.dtpFechaLiquidación.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidación.Location = new System.Drawing.Point(91, 12);
            this.dtpFechaLiquidación.Name = "dtpFechaLiquidación";
            this.dtpFechaLiquidación.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaLiquidación.TabIndex = 159;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLiqMesAnt);
            this.groupBox1.Controls.Add(this.rbSinProgRegula);
            this.groupBox1.Controls.Add(this.rbDepositoBanco);
            this.groupBox1.Location = new System.Drawing.Point(48, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 107);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            // 
            // rbLiqMesAnt
            // 
            this.rbLiqMesAnt.AutoSize = true;
            this.rbLiqMesAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLiqMesAnt.Location = new System.Drawing.Point(15, 65);
            this.rbLiqMesAnt.Name = "rbLiqMesAnt";
            this.rbLiqMesAnt.Size = new System.Drawing.Size(251, 17);
            this.rbLiqMesAnt.TabIndex = 0;
            this.rbLiqMesAnt.Text = "&Liquidados mes depositos mes siguiente";
            this.rbLiqMesAnt.UseVisualStyleBackColor = true;
            // 
            // rbSinProgRegula
            // 
            this.rbSinProgRegula.AutoSize = true;
            this.rbSinProgRegula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSinProgRegula.Location = new System.Drawing.Point(15, 42);
            this.rbSinProgRegula.Name = "rbSinProgRegula";
            this.rbSinProgRegula.Size = new System.Drawing.Size(229, 17);
            this.rbSinProgRegula.TabIndex = 0;
            this.rbSinProgRegula.Text = "&Sin Programa para su regularización";
            this.rbSinProgRegula.UseVisualStyleBackColor = true;
            // 
            // rbDepositoBanco
            // 
            this.rbDepositoBanco.AutoSize = true;
            this.rbDepositoBanco.Checked = true;
            this.rbDepositoBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositoBanco.Location = new System.Drawing.Point(15, 19);
            this.rbDepositoBanco.Name = "rbDepositoBanco";
            this.rbDepositoBanco.Size = new System.Drawing.Size(132, 17);
            this.rbDepositoBanco.TabIndex = 0;
            this.rbDepositoBanco.TabStop = true;
            this.rbDepositoBanco.Text = "&Depósitos a Banco";
            this.rbDepositoBanco.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Navy;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(201, 1);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(136, 34);
            this.btnBorrar.TabIndex = 163;
            this.btnBorrar.Text = "&Borrar Comp. Diario";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(189, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 162;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Navy;
            this.btnVer.Image = global::GUI_Tesoreria.Properties.Resources.asignar;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(91, 151);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(92, 36);
            this.btnVer.TabIndex = 158;
            this.btnVer.Text = "&Procesar";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmPreparaComprobanteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 200);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaLiquidación);
            this.Controls.Add(this.btnVer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreparaComprobanteDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Preparación de comprobante de Diario:::...";
            this.Load += new System.EventHandler(this.frmPreparaComprobanteDiario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidación;
        internal System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLiqMesAnt;
        private System.Windows.Forms.RadioButton rbSinProgRegula;
        private System.Windows.Forms.RadioButton rbDepositoBanco;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnBorrar;
    }
}