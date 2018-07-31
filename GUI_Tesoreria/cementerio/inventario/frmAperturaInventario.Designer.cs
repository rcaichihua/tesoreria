namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmAperturaInventario
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
            this.cboDocumentos = new System.Windows.Forms.ComboBox();
            this.lbldoc = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAperturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDocumentos
            // 
            this.cboDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDocumentos.FormattingEnabled = true;
            this.cboDocumentos.Location = new System.Drawing.Point(24, 34);
            this.cboDocumentos.Name = "cboDocumentos";
            this.cboDocumentos.Size = new System.Drawing.Size(109, 23);
            this.cboDocumentos.TabIndex = 6;
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbldoc.Location = new System.Drawing.Point(24, 16);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(109, 15);
            this.lbldoc.TabIndex = 5;
            this.lbldoc.Text = "Año de Apertura";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Silver;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmpresa.Location = new System.Drawing.Point(1, 9);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(345, 28);
            this.lblEmpresa.TabIndex = 26;
            this.lblEmpresa.Text = "APERTURA DEL INVENTARIO - CEMENTERIO";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.txtObservacion);
            this.GroupBox2.Controls.Add(this.cboDocumentos);
            this.GroupBox2.Controls.Add(this.lbldoc);
            this.GroupBox2.Location = new System.Drawing.Point(12, 53);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(325, 178);
            this.GroupBox2.TabIndex = 33;
            this.GroupBox2.TabStop = false;
            // 
            // btnAperturar
            // 
            this.btnAperturar.BackColor = System.Drawing.Color.White;
            this.btnAperturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperturar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAperturar.Location = new System.Drawing.Point(69, 19);
            this.btnAperturar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Size = new System.Drawing.Size(89, 25);
            this.btnAperturar.TabIndex = 2;
            this.btnAperturar.Text = "&Aperturar";
            this.btnAperturar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Location = new System.Drawing.Point(166, 19);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 25);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(6, 63);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(313, 103);
            this.txtObservacion.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAperturar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 66);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // frmAperturaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lblEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAperturaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAperturaInventario";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboDocumentos;
        internal System.Windows.Forms.Label lbldoc;
        internal System.Windows.Forms.Label lblEmpresa;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnAperturar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.TextBox txtObservacion;
        internal System.Windows.Forms.GroupBox groupBox1;
    }
}