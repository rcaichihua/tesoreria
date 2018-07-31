namespace GUI_Tesoreria.cementerio
{
    partial class frmEditarNicho
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoCuartel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipoCuartel = new System.Windows.Forms.TextBox();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(90, 58);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(29, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "FILA";
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(125, 55);
            this.txtFila.Name = "txtFila";
            this.txtFila.ReadOnly = true;
            this.txtFila.Size = new System.Drawing.Size(100, 20);
            this.txtFila.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO CUARTEL";
            // 
            // txtCodigoCuartel
            // 
            this.txtCodigoCuartel.Location = new System.Drawing.Point(125, 29);
            this.txtCodigoCuartel.Name = "txtCodigoCuartel";
            this.txtCodigoCuartel.ReadOnly = true;
            this.txtCodigoCuartel.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCuartel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.cboMaterial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoCuartel);
            this.groupBox1.Controls.Add(this.txtTipoCuartel);
            this.groupBox1.Controls.Add(this.txtColumna);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFila);
            this.groupBox1.Controls.Add(this.lblLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(124, 191);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(201, 68);
            this.txtObservacion.TabIndex = 6;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(125, 162);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(201, 23);
            this.cboEstado.TabIndex = 5;
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(125, 107);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(201, 23);
            this.cboMaterial.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "OBSERVACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ESTADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TIPO CUARTEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MATERIAL";
            // 
            // txtTipoCuartel
            // 
            this.txtTipoCuartel.Location = new System.Drawing.Point(125, 136);
            this.txtTipoCuartel.Name = "txtTipoCuartel";
            this.txtTipoCuartel.ReadOnly = true;
            this.txtTipoCuartel.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCuartel.TabIndex = 4;
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(125, 81);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.ReadOnly = true;
            this.txtColumna.Size = new System.Drawing.Size(100, 20);
            this.txtColumna.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "COLUMNA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(194, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 32);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(82, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 32);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEditarNicho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 336);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmEditarNicho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarNicho";
            this.Load += new System.EventHandler(this.frmEditarNicho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoCuartel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cboEstado;
        internal System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTipoCuartel;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtObservacion;
    }
}