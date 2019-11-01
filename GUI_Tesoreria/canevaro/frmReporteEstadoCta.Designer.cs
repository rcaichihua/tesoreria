namespace GUI_Tesoreria.canevaro
{
    partial class frmReporteEstadoCta
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
            this.rdbFallecidoEgresado = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFallecidoEgresado);
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 50);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte";
            // 
            // rdbFallecidoEgresado
            // 
            this.rdbFallecidoEgresado.AutoSize = true;
            this.rdbFallecidoEgresado.Enabled = false;
            this.rdbFallecidoEgresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFallecidoEgresado.Location = new System.Drawing.Point(70, 19);
            this.rdbFallecidoEgresado.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFallecidoEgresado.Name = "rdbFallecidoEgresado";
            this.rdbFallecidoEgresado.Size = new System.Drawing.Size(155, 17);
            this.rdbFallecidoEgresado.TabIndex = 16;
            this.rdbFallecidoEgresado.Text = "Fallecidos y Egresados";
            this.rdbFallecidoEgresado.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Enabled = false;
            this.rdbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActivo.Location = new System.Drawing.Point(5, 19);
            this.rdbActivo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(61, 17);
            this.rdbActivo.TabIndex = 17;
            this.rdbActivo.Text = "&Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // frmReporteEstadoCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 80);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporteEstadoCta";
            this.Text = "...:::Reporte Deudas:::...";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFallecidoEgresado;
        private System.Windows.Forms.RadioButton rdbActivo;
    }
}