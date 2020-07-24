namespace GUI_Tesoreria.control
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBFoto
            // 
            this.PBFoto.Image = global::GUI_Tesoreria.Properties.Resources.FONDOFORM;
            this.PBFoto.Location = new System.Drawing.Point(12, 12);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(154, 60);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFoto.TabIndex = 24;
            this.PBFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 60);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bienvenido(a)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 118);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(141, 273);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(140, 20);
            this.txtPwd1.TabIndex = 27;
            this.txtPwd1.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(62, 275);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 15);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "Contraseña";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(428, 335);
            this.Controls.Add(this.txtPwd1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBFoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Inicio Sesión:::...";
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPwd1;
        internal System.Windows.Forms.Label Label2;
    }
}