namespace GUI_Tesoreria.canevaro
{
    partial class frmGenerarCtaCte
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
            this.rdbSegSeme = new System.Windows.Forms.RadioButton();
            this.rdbPriSeme = new System.Windows.Forms.RadioButton();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSegSeme);
            this.groupBox1.Controls.Add(this.rdbPriSeme);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboAnio);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(237, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdbSegSeme
            // 
            this.rdbSegSeme.AutoSize = true;
            this.rdbSegSeme.Location = new System.Drawing.Point(13, 84);
            this.rdbSegSeme.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSegSeme.Name = "rdbSegSeme";
            this.rdbSegSeme.Size = new System.Drawing.Size(115, 17);
            this.rdbSegSeme.TabIndex = 8;
            this.rdbSegSeme.Text = "Segundo Semestre";
            this.rdbSegSeme.UseVisualStyleBackColor = true;
            // 
            // rdbPriSeme
            // 
            this.rdbPriSeme.AutoSize = true;
            this.rdbPriSeme.Checked = true;
            this.rdbPriSeme.Location = new System.Drawing.Point(13, 62);
            this.rdbPriSeme.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPriSeme.Name = "rdbPriSeme";
            this.rdbPriSeme.Size = new System.Drawing.Size(101, 17);
            this.rdbPriSeme.TabIndex = 8;
            this.rdbPriSeme.TabStop = true;
            this.rdbPriSeme.Text = "Primer Semestre";
            this.rdbPriSeme.UseVisualStyleBackColor = true;
            // 
            // txtImporte
            // 
            this.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(109, 37);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(109, 21);
            this.txtImporte.TabIndex = 7;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPabellon_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(106, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Año";
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(13, 37);
            this.cboAnio.Margin = new System.Windows.Forms.Padding(2);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(92, 21);
            this.cboAnio.TabIndex = 0;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(86, 130);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(72, 39);
            this.BtnGenerar.TabIndex = 1;
            this.BtnGenerar.Text = "&Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // frmGenerarCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 175);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmGenerarCtaCte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Generar:::...";
            this.Load += new System.EventHandler(this.frmGenerarCtaCte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAnio;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtImporte;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.RadioButton rdbSegSeme;
        private System.Windows.Forms.RadioButton rdbPriSeme;
    }
}