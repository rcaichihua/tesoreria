namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmEditarMausoleoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarMausoleoInventario));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPuerta = new System.Windows.Forms.ComboBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCementerio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoMausoleo = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBobedas = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJardin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSubSector = new System.Windows.Forms.ComboBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoMausoleo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPuerta);
            this.groupBox2.Controls.Add(this.txtFamilia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboCementerio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboEstado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodigoMausoleo);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBobedas);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtJardin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboSubSector);
            this.groupBox2.Controls.Add(this.cboSector);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboTipoMausoleo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 376);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // cboPuerta
            // 
            this.cboPuerta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuerta.FormattingEnabled = true;
            this.cboPuerta.Items.AddRange(new object[] {
            "NINGUNA",
            "1RA PUERTA",
            "2DA PUERTA",
            "3RA PUERTA",
            "4TA PUERTA",
            "5TA PUERTA",
            "6TA PUERTA"});
            this.cboPuerta.Location = new System.Drawing.Point(108, 210);
            this.cboPuerta.Name = "cboPuerta";
            this.cboPuerta.Size = new System.Drawing.Size(118, 23);
            this.cboPuerta.TabIndex = 8;
            // 
            // txtFamilia
            // 
            this.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFamilia.Location = new System.Drawing.Point(108, 75);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(243, 20);
            this.txtFamilia.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "FAMILIA";
            // 
            // cboCementerio
            // 
            this.cboCementerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCementerio.FormattingEnabled = true;
            this.cboCementerio.Location = new System.Drawing.Point(108, 18);
            this.cboCementerio.Name = "cboCementerio";
            this.cboCementerio.Size = new System.Drawing.Size(201, 23);
            this.cboCementerio.TabIndex = 0;
            this.cboCementerio.SelectedIndexChanged += new System.EventHandler(this.cboCementerio_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CEMENTERIO";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(108, 263);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(158, 23);
            this.cboEstado.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ESTADO";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(108, 292);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(195, 72);
            this.txtObservacion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "OBSERVACION";
            // 
            // txtCodigoMausoleo
            // 
            this.txtCodigoMausoleo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMausoleo.Location = new System.Drawing.Point(287, 48);
            this.txtCodigoMausoleo.Name = "txtCodigoMausoleo";
            this.txtCodigoMausoleo.ReadOnly = true;
            this.txtCodigoMausoleo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoMausoleo.TabIndex = 6;
            // 
            // txtLote
            // 
            this.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.Location = new System.Drawing.Point(235, 159);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(64, 20);
            this.txtLote.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "LOTE";
            // 
            // txtBobedas
            // 
            this.txtBobedas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBobedas.Location = new System.Drawing.Point(108, 185);
            this.txtBobedas.Name = "txtBobedas";
            this.txtBobedas.Size = new System.Drawing.Size(83, 20);
            this.txtBobedas.TabIndex = 7;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Location = new System.Drawing.Point(108, 237);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(243, 20);
            this.txtReferencia.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "PUERTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "BOBEDAS";
            // 
            // txtJardin
            // 
            this.txtJardin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJardin.Location = new System.Drawing.Point(108, 159);
            this.txtJardin.Name = "txtJardin";
            this.txtJardin.Size = new System.Drawing.Size(64, 20);
            this.txtJardin.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "REFERENCIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CODIGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "JARDIN ";
            // 
            // cboSubSector
            // 
            this.cboSubSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubSector.FormattingEnabled = true;
            this.cboSubSector.Location = new System.Drawing.Point(108, 130);
            this.cboSubSector.Name = "cboSubSector";
            this.cboSubSector.Size = new System.Drawing.Size(149, 23);
            this.cboSubSector.TabIndex = 4;
            // 
            // cboSector
            // 
            this.cboSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Items.AddRange(new object[] {
            "NINGUNA",
            "1RA PUERTA",
            "2DA PUERTA",
            "3RA PUERTA",
            "4TA PUERTA",
            "5TA PUERTA",
            "6TA PUERTA"});
            this.cboSector.Location = new System.Drawing.Point(108, 101);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(149, 23);
            this.cboSector.TabIndex = 3;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.cboSector_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "SUB SECTOR";
            // 
            // cboTipoMausoleo
            // 
            this.cboTipoMausoleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMausoleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMausoleo.FormattingEnabled = true;
            this.cboTipoMausoleo.Location = new System.Drawing.Point(108, 47);
            this.cboTipoMausoleo.Name = "cboTipoMausoleo";
            this.cboTipoMausoleo.Size = new System.Drawing.Size(118, 23);
            this.cboTipoMausoleo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECTOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "TIPO MAUSOLEO";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(124, 446);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 50;
            this.lblRuta.Text = "label1";
            this.lblRuta.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEditarMausoleoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 508);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarMausoleoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarMausoleoInventario";
            this.Load += new System.EventHandler(this.frmEditarMausoleoInventario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox cboPuerta;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cboCementerio;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoMausoleo;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBobedas;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtJardin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboSubSector;
        internal System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cboTipoMausoleo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}