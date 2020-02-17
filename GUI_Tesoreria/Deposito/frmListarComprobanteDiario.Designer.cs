namespace GUI_Tesoreria.Deposito
{
    partial class frmListarComprobanteDiario
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
            this.rbSinProgParaRegul = new System.Windows.Forms.RadioButton();
            this.rbLiqmesAnterior = new System.Windows.Forms.RadioButton();
            this.rbDepositoBanco = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaLiquidación = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.chkcuentas = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSinProgParaRegul);
            this.groupBox1.Controls.Add(this.rbLiqmesAnterior);
            this.groupBox1.Controls.Add(this.rbDepositoBanco);
            this.groupBox1.Location = new System.Drawing.Point(18, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 111);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            // 
            // rbSinProgParaRegul
            // 
            this.rbSinProgParaRegul.AutoSize = true;
            this.rbSinProgParaRegul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSinProgParaRegul.Location = new System.Drawing.Point(15, 78);
            this.rbSinProgParaRegul.Name = "rbSinProgParaRegul";
            this.rbSinProgParaRegul.Size = new System.Drawing.Size(191, 17);
            this.rbSinProgParaRegul.TabIndex = 0;
            this.rbSinProgParaRegul.Text = "&Sin programa para regularizar";
            this.rbSinProgParaRegul.UseVisualStyleBackColor = true;
            // 
            // rbLiqmesAnterior
            // 
            this.rbLiqmesAnterior.AutoSize = true;
            this.rbLiqmesAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLiqmesAnterior.Location = new System.Drawing.Point(15, 42);
            this.rbLiqmesAnterior.Name = "rbLiqmesAnterior";
            this.rbLiqmesAnterior.Size = new System.Drawing.Size(258, 30);
            this.rbLiqmesAnterior.TabIndex = 0;
            this.rbLiqmesAnterior.Text = "&Liquidados mes anterior y contabilizados \r\nmes actual";
            this.rbLiqmesAnterior.UseVisualStyleBackColor = true;
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
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(15, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 166;
            this.Label2.Text = "Fecha";
            // 
            // dtpFechaLiquidación
            // 
            this.dtpFechaLiquidación.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidación.Location = new System.Drawing.Point(61, 23);
            this.dtpFechaLiquidación.Name = "dtpFechaLiquidación";
            this.dtpFechaLiquidación.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaLiquidación.TabIndex = 165;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(159, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 168;
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
            this.btnVer.Location = new System.Drawing.Point(61, 166);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(92, 36);
            this.btnVer.TabIndex = 164;
            this.btnVer.Text = "&Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // chkcuentas
            // 
            this.chkcuentas.AutoSize = true;
            this.chkcuentas.Location = new System.Drawing.Point(18, 208);
            this.chkcuentas.Name = "chkcuentas";
            this.chkcuentas.Size = new System.Drawing.Size(285, 17);
            this.chkcuentas.TabIndex = 171;
            this.chkcuentas.Text = "Códigos Contable - PLAN CONTABLE EMPRESARIAL";
            this.chkcuentas.UseVisualStyleBackColor = true;
            // 
            // frmListarComprobanteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 237);
            this.Controls.Add(this.chkcuentas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaLiquidación);
            this.Controls.Add(this.btnVer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListarComprobanteDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listar Comprobante Diario:::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSinProgParaRegul;
        private System.Windows.Forms.RadioButton rbLiqmesAnterior;
        private System.Windows.Forms.RadioButton rbDepositoBanco;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidación;
        internal System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.CheckBox chkcuentas;
    }
}