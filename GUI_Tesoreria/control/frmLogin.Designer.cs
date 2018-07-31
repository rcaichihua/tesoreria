namespace GUI_Tesoreria.control
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.GroupBox1.SuspendLayout();
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
            this.GroupBox2.Location = new System.Drawing.Point(183, 62);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(303, 154);
            this.GroupBox2.TabIndex = 32;
            this.GroupBox2.TabStop = false;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(128, 87);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(140, 20);
            this.txtPwd1.TabIndex = 1;
            this.txtPwd1.UseSystemPasswordChar = true;
            this.txtPwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd1_KeyPress_1);
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
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
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
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox4.Controls.Add(this.PBFoto);
            this.GroupBox4.Location = new System.Drawing.Point(15, 62);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(162, 154);
            this.GroupBox4.TabIndex = 34;
            this.GroupBox4.TabStop = false;
            // 
            // PBFoto
            // 
            this.PBFoto.Image = ((System.Drawing.Image)(resources.GetObject("PBFoto.Image")));
            this.PBFoto.Location = new System.Drawing.Point(6, 11);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(150, 137);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFoto.TabIndex = 23;
            this.PBFoto.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.lblEmpresa);
            this.GroupBox1.Location = new System.Drawing.Point(15, 10);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(471, 46);
            this.GroupBox1.TabIndex = 36;
            this.GroupBox1.TabStop = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmpresa.Location = new System.Drawing.Point(6, 12);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(458, 28);
            this.lblEmpresa.TabIndex = 25;
            this.lblEmpresa.Text = "SOCIEDAD DE BENEFICENCIA DE LIMA METROPOLITANA";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 227);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Ingreso al Sistema:::...";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BtnAceptar;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.PictureBox PBFoto;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtPwd1;
    }
}