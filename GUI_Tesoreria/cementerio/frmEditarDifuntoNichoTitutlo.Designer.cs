namespace GUI_Tesoreria.cementerio
{
    partial class frmEditarDifuntoNichoTitutlo
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
            this.mtbFechaInhumacion = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboTipoResto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbFechaInhumacion
            // 
            this.mtbFechaInhumacion.Location = new System.Drawing.Point(164, 27);
            this.mtbFechaInhumacion.Mask = "00/00/0000";
            this.mtbFechaInhumacion.Name = "mtbFechaInhumacion";
            this.mtbFechaInhumacion.Size = new System.Drawing.Size(100, 20);
            this.mtbFechaInhumacion.TabIndex = 124;
            this.mtbFechaInhumacion.ValidatingType = typeof(System.DateTime);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(279, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 42);
            this.btnGuardar.TabIndex = 125;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboTipoResto
            // 
            this.cboTipoResto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoResto.FormattingEnabled = true;
            this.cboTipoResto.Items.AddRange(new object[] {
            "[SELECCIONE]",
            "INHUMADO",
            "RESERVADO EN VIDA",
            "ANULADO"});
            this.cboTipoResto.Location = new System.Drawing.Point(15, 25);
            this.cboTipoResto.Name = "cboTipoResto";
            this.cboTipoResto.Size = new System.Drawing.Size(143, 23);
            this.cboTipoResto.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "TIPO DE RESTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "F. INHUMACION";
            // 
            // frmEditarDifuntoNichoTitutlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 66);
            this.Controls.Add(this.cboTipoResto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtbFechaInhumacion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarDifuntoNichoTitutlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarDifuntoNichoTitutlo";
            this.Load += new System.EventHandler(this.frmEditarDifuntoNichoTitutlo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbFechaInhumacion;
        private System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.ComboBox cboTipoResto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}