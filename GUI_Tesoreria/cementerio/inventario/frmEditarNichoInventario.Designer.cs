namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmEditarNichoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarNichoInventario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkReja = new System.Windows.Forms.CheckBox();
            this.chkLapida = new System.Windows.Forms.CheckBox();
            this.chkTapa = new System.Windows.Forms.CheckBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cboEstadoFisico = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboCementerio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdNicho = new System.Windows.Forms.TextBox();
            this.txtCodigoCuartel = new System.Windows.Forms.TextBox();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRuta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboMaterial);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkReja);
            this.groupBox1.Controls.Add(this.chkLapida);
            this.groupBox1.Controls.Add(this.chkTapa);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.cboEstadoFisico);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.cboCementerio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIdNicho);
            this.groupBox1.Controls.Add(this.txtCodigoCuartel);
            this.groupBox1.Controls.Add(this.txtColumna);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFila);
            this.groupBox1.Controls.Add(this.lblLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(262, 322);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 48;
            this.lblRuta.Text = "label1";
            this.lblRuta.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(121, 134);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(101, 23);
            this.cboMaterial.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "MATERIAL";
            // 
            // chkReja
            // 
            this.chkReja.AutoSize = true;
            this.chkReja.Location = new System.Drawing.Point(191, 163);
            this.chkReja.Name = "chkReja";
            this.chkReja.Size = new System.Drawing.Size(53, 17);
            this.chkReja.TabIndex = 10;
            this.chkReja.Text = "REJA";
            this.chkReja.UseVisualStyleBackColor = true;
            // 
            // chkLapida
            // 
            this.chkLapida.AutoSize = true;
            this.chkLapida.Location = new System.Drawing.Point(121, 163);
            this.chkLapida.Name = "chkLapida";
            this.chkLapida.Size = new System.Drawing.Size(64, 17);
            this.chkLapida.TabIndex = 9;
            this.chkLapida.Text = "LAPIDA";
            this.chkLapida.UseVisualStyleBackColor = true;
            // 
            // chkTapa
            // 
            this.chkTapa.AutoSize = true;
            this.chkTapa.Location = new System.Drawing.Point(121, 82);
            this.chkTapa.Name = "chkTapa";
            this.chkTapa.Size = new System.Drawing.Size(54, 17);
            this.chkTapa.TabIndex = 4;
            this.chkTapa.Text = "TAPA";
            this.chkTapa.UseVisualStyleBackColor = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(121, 186);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(260, 68);
            this.txtObservacion.TabIndex = 11;
            // 
            // cboEstadoFisico
            // 
            this.cboEstadoFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoFisico.FormattingEnabled = true;
            this.cboEstadoFisico.Location = new System.Drawing.Point(121, 105);
            this.cboEstadoFisico.Name = "cboEstadoFisico";
            this.cboEstadoFisico.Size = new System.Drawing.Size(100, 23);
            this.cboEstadoFisico.TabIndex = 5;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(121, 50);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(201, 23);
            this.cboEstado.TabIndex = 1;
            // 
            // cboCementerio
            // 
            this.cboCementerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCementerio.Enabled = false;
            this.cboCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCementerio.FormattingEnabled = true;
            this.cboCementerio.Location = new System.Drawing.Point(121, 21);
            this.cboCementerio.Name = "cboCementerio";
            this.cboCementerio.Size = new System.Drawing.Size(201, 23);
            this.cboCementerio.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ESTADO FISICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "OBSERVACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ESTADO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "CEMENTERIO";
            // 
            // txtIdNicho
            // 
            this.txtIdNicho.Location = new System.Drawing.Point(328, 50);
            this.txtIdNicho.Name = "txtIdNicho";
            this.txtIdNicho.ReadOnly = true;
            this.txtIdNicho.Size = new System.Drawing.Size(78, 20);
            this.txtIdNicho.TabIndex = 3;
            this.txtIdNicho.Visible = false;
            // 
            // txtCodigoCuartel
            // 
            this.txtCodigoCuartel.Location = new System.Drawing.Point(328, 24);
            this.txtCodigoCuartel.Name = "txtCodigoCuartel";
            this.txtCodigoCuartel.ReadOnly = true;
            this.txtCodigoCuartel.Size = new System.Drawing.Size(78, 20);
            this.txtCodigoCuartel.TabIndex = 2;
            // 
            // txtColumna
            // 
            this.txtColumna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColumna.Location = new System.Drawing.Point(265, 105);
            this.txtColumna.Multiline = true;
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.ReadOnly = true;
            this.txtColumna.Size = new System.Drawing.Size(57, 23);
            this.txtColumna.TabIndex = 7;
            this.txtColumna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumna_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "COLUMNA";
            // 
            // txtFila
            // 
            this.txtFila.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFila.Location = new System.Drawing.Point(227, 105);
            this.txtFila.MaxLength = 1;
            this.txtFila.Multiline = true;
            this.txtFila.Name = "txtFila";
            this.txtFila.ReadOnly = true;
            this.txtFila.Size = new System.Drawing.Size(32, 23);
            this.txtFila.TabIndex = 6;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(224, 86);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(29, 13);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "FILA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(228, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEditarNichoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 441);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarNichoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarNichoInventario";
            this.Load += new System.EventHandler(this.frmEditarNichoInventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkReja;
        private System.Windows.Forms.CheckBox chkLapida;
        private System.Windows.Forms.CheckBox chkTapa;
        internal System.Windows.Forms.TextBox txtObservacion;
        internal System.Windows.Forms.ComboBox cboEstadoFisico;
        internal System.Windows.Forms.ComboBox cboEstado;
        internal System.Windows.Forms.ComboBox cboCementerio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoCuartel;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdNicho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
    }
}