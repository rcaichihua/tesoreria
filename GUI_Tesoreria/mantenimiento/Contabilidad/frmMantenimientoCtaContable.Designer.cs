namespace GUI_Tesoreria.mantenimiento.Contabilidad
{
    partial class frmMantenimientoCtaContable
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContrasena1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboElementos = new System.Windows.Forms.ComboBox();
            this.lblNombreEstructura = new System.Windows.Forms.Label();
            this.chkAutoImpre = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.txtBuscar);
            this.GroupBox1.Controls.Add(this.chkAutoImpre);
            this.GroupBox1.Controls.Add(this.lblNombreEstructura);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.comboBox1);
            this.GroupBox1.Controls.Add(this.cboElementos);
            this.GroupBox1.Controls.Add(this.txtContrasena1);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtUsuario);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(521, 206);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cuentas";
            // 
            // txtContrasena1
            // 
            this.txtContrasena1.Location = new System.Drawing.Point(169, 166);
            this.txtContrasena1.MaxLength = 12;
            this.txtContrasena1.Name = "txtContrasena1";
            this.txtContrasena1.Size = new System.Drawing.Size(253, 21);
            this.txtContrasena1.TabIndex = 1;
            this.txtContrasena1.UseSystemPasswordChar = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label4.Location = new System.Drawing.Point(23, 169);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(140, 15);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Codigo Presupuestal";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label3.Location = new System.Drawing.Point(55, 113);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Descripción Cta";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(169, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(253, 21);
            this.txtUsuario.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(63, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tipo Elemento";
            // 
            // cboElementos
            // 
            this.cboElementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboElementos.FormattingEnabled = true;
            this.cboElementos.Location = new System.Drawing.Point(169, 33);
            this.cboElementos.Name = "cboElementos";
            this.cboElementos.Size = new System.Drawing.Size(253, 23);
            this.cboElementos.TabIndex = 5;
            // 
            // lblNombreEstructura
            // 
            this.lblNombreEstructura.Location = new System.Drawing.Point(166, 59);
            this.lblNombreEstructura.Name = "lblNombreEstructura";
            this.lblNombreEstructura.Size = new System.Drawing.Size(359, 23);
            this.lblNombreEstructura.TabIndex = 7;
            this.lblNombreEstructura.Text = "...";
            // 
            // chkAutoImpre
            // 
            this.chkAutoImpre.AutoSize = true;
            this.chkAutoImpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoImpre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkAutoImpre.Location = new System.Drawing.Point(169, 85);
            this.chkAutoImpre.Name = "chkAutoImpre";
            this.chkAutoImpre.Size = new System.Drawing.Size(169, 19);
            this.chkAutoImpre.TabIndex = 8;
            this.chkAutoImpre.Text = "Cuenta de Movimiento";
            this.chkAutoImpre.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(62, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cta de Gestión";
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(428, 140);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(79, 21);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.Text = "FILTRO ...";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // txtGuardar
            // 
            this.txtGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardar.ForeColor = System.Drawing.Color.Navy;
            this.txtGuardar.Location = new System.Drawing.Point(194, 224);
            this.txtGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(74, 39);
            this.txtGuardar.TabIndex = 55;
            this.txtGuardar.Text = "&Guardar";
            this.txtGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Location = new System.Drawing.Point(276, 224);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 39);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmMantenimientoCtaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 270);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmMantenimientoCtaContable";
            this.Text = "frmMantenimientoCtaContable";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtContrasena1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.ComboBox cboElementos;
        private System.Windows.Forms.Label lblNombreEstructura;
        private System.Windows.Forms.CheckBox chkAutoImpre;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.Button txtGuardar;
        internal System.Windows.Forms.Button btnSalir;
    }
}