namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantContable
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboMovimiento = new System.Windows.Forms.ComboBox();
            this.cboElemento = new System.Windows.Forms.ComboBox();
            this.cboEstructura = new System.Windows.Forms.ComboBox();
            this.cboCtaContable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.cboMovimiento);
            this.groupBox1.Controls.Add(this.cboElemento);
            this.groupBox1.Controls.Add(this.cboEstructura);
            this.groupBox1.Controls.Add(this.cboCtaContable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescripCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo2);
            this.groupBox1.Controls.Add(this.txtCodigo1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 246);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(370, 214);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(112, 21);
            this.txtBuscar.TabIndex = 172;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // cboMovimiento
            // 
            this.cboMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovimiento.FormattingEnabled = true;
            this.cboMovimiento.Location = new System.Drawing.Point(135, 78);
            this.cboMovimiento.Name = "cboMovimiento";
            this.cboMovimiento.Size = new System.Drawing.Size(347, 23);
            this.cboMovimiento.TabIndex = 170;
            this.cboMovimiento.SelectedIndexChanged += new System.EventHandler(this.cboMovimiento_SelectedIndexChanged);
            // 
            // cboElemento
            // 
            this.cboElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboElemento.FormattingEnabled = true;
            this.cboElemento.Location = new System.Drawing.Point(135, 49);
            this.cboElemento.Name = "cboElemento";
            this.cboElemento.Size = new System.Drawing.Size(347, 23);
            this.cboElemento.TabIndex = 170;
            this.cboElemento.SelectedIndexChanged += new System.EventHandler(this.cboElemento_SelectedIndexChanged);
            // 
            // cboEstructura
            // 
            this.cboEstructura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstructura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstructura.FormattingEnabled = true;
            this.cboEstructura.Location = new System.Drawing.Point(135, 20);
            this.cboEstructura.Name = "cboEstructura";
            this.cboEstructura.Size = new System.Drawing.Size(347, 23);
            this.cboEstructura.TabIndex = 170;
            this.cboEstructura.SelectedIndexChanged += new System.EventHandler(this.cboEstructura_SelectedIndexChanged);
            // 
            // cboCtaContable
            // 
            this.cboCtaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCtaContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCtaContable.FormattingEnabled = true;
            this.cboCtaContable.Location = new System.Drawing.Point(135, 211);
            this.cboCtaContable.Name = "cboCtaContable";
            this.cboCtaContable.Size = new System.Drawing.Size(229, 23);
            this.cboCtaContable.TabIndex = 170;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(48, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 171;
            this.label5.Text = "Movimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(49, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 171;
            this.label8.Text = "Estrucutura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(61, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 171;
            this.label6.Text = "Elemento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 171;
            this.label2.Text = "Descrip Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(73, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 171;
            this.label1.Text = "Gestión";
            // 
            // txtDescripCodigo
            // 
            this.txtDescripCodigo.BackColor = System.Drawing.Color.White;
            this.txtDescripCodigo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripCodigo.ForeColor = System.Drawing.Color.Maroon;
            this.txtDescripCodigo.Location = new System.Drawing.Point(135, 107);
            this.txtDescripCodigo.Multiline = true;
            this.txtDescripCodigo.Name = "txtDescripCodigo";
            this.txtDescripCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripCodigo.Size = new System.Drawing.Size(347, 70);
            this.txtDescripCodigo.TabIndex = 171;
            this.txtDescripCodigo.TextChanged += new System.EventHandler(this.txtdebe_TextChanged);
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.BackColor = System.Drawing.Color.White;
            this.txtCodigo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo2.ForeColor = System.Drawing.Color.Maroon;
            this.txtCodigo2.Location = new System.Drawing.Point(243, 183);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(239, 22);
            this.txtCodigo2.TabIndex = 171;
            this.txtCodigo2.TextChanged += new System.EventHandler(this.txtdebe_TextChanged);
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.BackColor = System.Drawing.Color.White;
            this.txtCodigo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo1.ForeColor = System.Drawing.Color.Maroon;
            this.txtCodigo1.Location = new System.Drawing.Point(135, 183);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.ReadOnly = true;
            this.txtCodigo1.Size = new System.Drawing.Size(86, 22);
            this.txtCodigo1.TabIndex = 171;
            this.txtCodigo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo1.TextChanged += new System.EventHandler(this.txtdebe_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(227, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 169;
            this.label9.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(31, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 169;
            this.label3.Text = "Codigo Contable";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(269, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 171;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.guardarDoc;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(171, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 36);
            this.btnGuardar.TabIndex = 170;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmMantContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 310);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Mantenimiento Cuenta:::...";
            this.Load += new System.EventHandler(this.frmMantContable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.ComboBox cboCtaContable;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtCodigo1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cboMovimiento;
        internal System.Windows.Forms.ComboBox cboElemento;
        internal System.Windows.Forms.ComboBox cboEstructura;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtCodigo2;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtDescripCodigo;
    }
}