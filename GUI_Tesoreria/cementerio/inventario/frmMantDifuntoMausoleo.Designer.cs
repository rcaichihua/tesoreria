namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmMantDifuntoMausoleo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMasculino = new System.Windows.Forms.RadioButton();
            this.chkFemenino = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(215, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(108, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFemenino);
            this.groupBox1.Controls.Add(this.chkMasculino);
            this.groupBox1.Controls.Add(this.chkFecha);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtFamilia);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(253, 136);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(82, 17);
            this.chkFecha.TabIndex = 14;
            this.chkFecha.Text = "SIN FECHA";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(148, 133);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(148, 159);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(224, 68);
            this.txtObservacion.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "FECHA FALLECIMIENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "OBSERVACION";
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Location = new System.Drawing.Point(148, 81);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(224, 23);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtFamilia
            // 
            this.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFamilia.Location = new System.Drawing.Point(148, 26);
            this.txtFamilia.Multiline = true;
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.ReadOnly = true;
            this.txtFamilia.Size = new System.Drawing.Size(224, 23);
            this.txtFamilia.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(148, 55);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(224, 23);
            this.txtNombres.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FAMILIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "APELLIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRES";
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Checked = true;
            this.chkMasculino.Location = new System.Drawing.Point(148, 110);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(88, 17);
            this.chkMasculino.TabIndex = 15;
            this.chkMasculino.TabStop = true;
            this.chkMasculino.Text = "MASCULINO";
            this.chkMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFemenino
            // 
            this.chkFemenino.AutoSize = true;
            this.chkFemenino.Location = new System.Drawing.Point(242, 110);
            this.chkFemenino.Name = "chkFemenino";
            this.chkFemenino.Size = new System.Drawing.Size(81, 17);
            this.chkFemenino.TabIndex = 15;
            this.chkFemenino.TabStop = true;
            this.chkFemenino.Text = "FEMENINO";
            this.chkFemenino.UseVisualStyleBackColor = true;
            // 
            // frmMantDifuntoMausoleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 314);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMantDifuntoMausoleo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantDifuntoMausoleo";
            this.Load += new System.EventHandler(this.frmMantDifuntoMausoleo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.RadioButton chkFemenino;
        private System.Windows.Forms.RadioButton chkMasculino;
    }
}