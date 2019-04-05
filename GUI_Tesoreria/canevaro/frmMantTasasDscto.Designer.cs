namespace GUI_Tesoreria.canevaro
{
    partial class frmMantTasasDscto
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
            this.GBSolicitante = new System.Windows.Forms.GroupBox();
            this.cboTipoTasa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GBSolicitante.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSolicitante
            // 
            this.GBSolicitante.BackColor = System.Drawing.Color.Transparent;
            this.GBSolicitante.Controls.Add(this.cboTipoTasa);
            this.GBSolicitante.Controls.Add(this.label7);
            this.GBSolicitante.Controls.Add(this.label6);
            this.GBSolicitante.Controls.Add(this.txtTasa);
            this.GBSolicitante.Controls.Add(this.txtAnio);
            this.GBSolicitante.Controls.Add(this.label5);
            this.GBSolicitante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSolicitante.ForeColor = System.Drawing.Color.Maroon;
            this.GBSolicitante.Location = new System.Drawing.Point(12, 12);
            this.GBSolicitante.Name = "GBSolicitante";
            this.GBSolicitante.Size = new System.Drawing.Size(426, 85);
            this.GBSolicitante.TabIndex = 3;
            this.GBSolicitante.TabStop = false;
            this.GBSolicitante.Text = "Mantenimiento de Tasas";
            // 
            // cboTipoTasa
            // 
            this.cboTipoTasa.BackColor = System.Drawing.Color.White;
            this.cboTipoTasa.DropDownHeight = 200;
            this.cboTipoTasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTasa.DropDownWidth = 400;
            this.cboTipoTasa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoTasa.ForeColor = System.Drawing.Color.Black;
            this.cboTipoTasa.FormattingEnabled = true;
            this.cboTipoTasa.IntegralHeight = false;
            this.cboTipoTasa.Items.AddRange(new object[] {
            "[seleccione]",
            "Mora",
            "Descuento",
            "Dias Descuento"});
            this.cboTipoTasa.Location = new System.Drawing.Point(101, 23);
            this.cboTipoTasa.Name = "cboTipoTasa";
            this.cboTipoTasa.Size = new System.Drawing.Size(180, 21);
            this.cboTipoTasa.TabIndex = 0;
            this.cboTipoTasa.SelectedIndexChanged += new System.EventHandler(this.cboTipoTasa_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(20, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Tipo de Tasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(289, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Año";
            // 
            // txtTasa
            // 
            this.txtTasa.BackColor = System.Drawing.Color.White;
            this.txtTasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTasa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTasa.Location = new System.Drawing.Point(101, 50);
            this.txtTasa.MaxLength = 11;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(77, 21);
            this.txtTasa.TabIndex = 2;
            this.txtTasa.Text = "0.00";
            this.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasa_KeyPress);
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.Color.White;
            this.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAnio.Location = new System.Drawing.Point(324, 23);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.ReadOnly = true;
            this.txtAnio.Size = new System.Drawing.Size(74, 21);
            this.txtAnio.TabIndex = 0;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(61, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tasa";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit_32px;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(232, 104);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(61, 42);
            this.BtnSalir.TabIndex = 117;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.save_32px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(164, 104);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(61, 42);
            this.btnGuardar.TabIndex = 116;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmMantTasasDscto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 155);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GBSolicitante);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantTasasDscto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Mantenimiento datos:::...";
            this.Load += new System.EventHandler(this.frmMantTasasDscto_Load);
            this.GBSolicitante.ResumeLayout(false);
            this.GBSolicitante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBSolicitante;
        internal System.Windows.Forms.ComboBox cboTipoTasa;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTasa;
        internal System.Windows.Forms.TextBox txtAnio;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button btnGuardar;
    }
}