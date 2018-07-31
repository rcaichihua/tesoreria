namespace GUI_Tesoreria.caja
{
    partial class frmAutorizaExtorno
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.txtPwd1);
            this.GroupBox2.Controls.Add(this.txtUser);
            this.GroupBox2.Controls.Add(this.BtnAceptar);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.BtnSalir);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(303, 154);
            this.GroupBox2.TabIndex = 33;
            this.GroupBox2.TabStop = false;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(128, 87);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(140, 20);
            this.txtPwd1.TabIndex = 1;
            this.txtPwd1.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Navy;
            this.txtUser.Location = new System.Drawing.Point(128, 61);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(140, 20);
            this.txtUser.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.White;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAceptar.Location = new System.Drawing.Point(82, 123);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(89, 25);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label7.Location = new System.Drawing.Point(2, 11);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(288, 35);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "Escriba su Nombre de Usuario y su Contraseña";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnSalir.Location = new System.Drawing.Point(179, 123);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(89, 25);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "&Cancelar";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(45, 93);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Contraseña";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label1.Location = new System.Drawing.Point(45, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Usuario";
            // 
            // frmAutorizaExtorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 179);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutorizaExtorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...::Extorno:::...";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox txtPwd1;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.Button BtnAceptar;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}