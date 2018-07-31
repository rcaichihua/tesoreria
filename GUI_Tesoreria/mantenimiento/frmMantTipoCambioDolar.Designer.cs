namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantTipoCambioDolar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IGBSistema = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtUsuarioC = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.BtnGrabarC = new System.Windows.Forms.Button();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.DGVCambioDolar = new System.Windows.Forms.DataGridView();
            this.FechaCambioDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCambioDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGBSistema.SuspendLayout();
            this.GBDatosRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCambioDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // IGBSistema
            // 
            this.IGBSistema.BackColor = System.Drawing.Color.Transparent;
            this.IGBSistema.Controls.Add(this.lblValor);
            this.IGBSistema.Controls.Add(this.label11);
            this.IGBSistema.Controls.Add(this.label10);
            this.IGBSistema.Controls.Add(this.txtValor);
            this.IGBSistema.Controls.Add(this.txtFecha);
            this.IGBSistema.Controls.Add(this.txtUsuarioC);
            this.IGBSistema.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGBSistema.ForeColor = System.Drawing.Color.Maroon;
            this.IGBSistema.Location = new System.Drawing.Point(12, 12);
            this.IGBSistema.Name = "IGBSistema";
            this.IGBSistema.Size = new System.Drawing.Size(208, 103);
            this.IGBSistema.TabIndex = 81;
            this.IGBSistema.TabStop = false;
            this.IGBSistema.Text = "Tipo de cambio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(16, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Fecha :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Usuario :";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFecha.Location = new System.Drawing.Point(68, 42);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(117, 21);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuarioC
            // 
            this.txtUsuarioC.BackColor = System.Drawing.Color.White;
            this.txtUsuarioC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuarioC.Location = new System.Drawing.Point(68, 19);
            this.txtUsuarioC.Name = "txtUsuarioC";
            this.txtUsuarioC.ReadOnly = true;
            this.txtUsuarioC.Size = new System.Drawing.Size(117, 21);
            this.txtUsuarioC.TabIndex = 0;
            this.txtUsuarioC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValor.Location = new System.Drawing.Point(68, 69);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(117, 21);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "1.000";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Navy;
            this.lblValor.Location = new System.Drawing.Point(16, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 13);
            this.lblValor.TabIndex = 25;
            this.lblValor.Text = "Valor :";
            // 
            // BtnGrabarC
            // 
            this.BtnGrabarC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGrabarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrabarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabarC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabarC.ForeColor = System.Drawing.Color.Navy;
            this.BtnGrabarC.Location = new System.Drawing.Point(80, 120);
            this.BtnGrabarC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabarC.Name = "BtnGrabarC";
            this.BtnGrabarC.Size = new System.Drawing.Size(74, 39);
            this.BtnGrabarC.TabIndex = 82;
            this.BtnGrabarC.Text = "&Grabar";
            this.BtnGrabarC.UseVisualStyleBackColor = false;
            this.BtnGrabarC.Click += new System.EventHandler(this.BtnGrabarC_Click);
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.DGVCambioDolar);
            this.GBDatosRubros.Location = new System.Drawing.Point(226, 12);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(225, 147);
            this.GBDatosRubros.TabIndex = 83;
            this.GBDatosRubros.TabStop = false;
            // 
            // DGVCambioDolar
            // 
            this.DGVCambioDolar.AllowUserToAddRows = false;
            this.DGVCambioDolar.AllowUserToDeleteRows = false;
            this.DGVCambioDolar.AllowUserToResizeColumns = false;
            this.DGVCambioDolar.AllowUserToResizeRows = false;
            this.DGVCambioDolar.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCambioDolar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCambioDolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCambioDolar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaCambioDolar,
            this.ValorCambioDolar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCambioDolar.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCambioDolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCambioDolar.Location = new System.Drawing.Point(3, 16);
            this.DGVCambioDolar.Name = "DGVCambioDolar";
            this.DGVCambioDolar.RowHeadersVisible = false;
            this.DGVCambioDolar.RowHeadersWidth = 10;
            this.DGVCambioDolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCambioDolar.Size = new System.Drawing.Size(219, 128);
            this.DGVCambioDolar.TabIndex = 3;
            // 
            // FechaCambioDolar
            // 
            this.FechaCambioDolar.DataPropertyName = "fecha_CambioDolar";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.FechaCambioDolar.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaCambioDolar.HeaderText = "Fecha";
            this.FechaCambioDolar.Name = "FechaCambioDolar";
            // 
            // ValorCambioDolar
            // 
            this.ValorCambioDolar.DataPropertyName = "valor_CambioDolar";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.ValorCambioDolar.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorCambioDolar.HeaderText = "Valor";
            this.ValorCambioDolar.Name = "ValorCambioDolar";
            // 
            // frmMantTipoCambioDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 172);
            this.Controls.Add(this.GBDatosRubros);
            this.Controls.Add(this.BtnGrabarC);
            this.Controls.Add(this.IGBSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantTipoCambioDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Tipo de cambio:::...";
            this.Load += new System.EventHandler(this.frmMantTipoCambioDolar_Load);
            this.IGBSistema.ResumeLayout(false);
            this.IGBSistema.PerformLayout();
            this.GBDatosRubros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCambioDolar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox IGBSistema;
        internal System.Windows.Forms.Label lblValor;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.TextBox txtUsuarioC;
        internal System.Windows.Forms.Button BtnGrabarC;
        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.DataGridView DGVCambioDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCambioDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCambioDolar;
    }
}