namespace GUI_Tesoreria.Gerencia
{
    partial class frmIngresosPorCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresosPorCajero));
            this.GBSolicitante = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.GBSolicitante.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSolicitante
            // 
            this.GBSolicitante.BackColor = System.Drawing.Color.Transparent;
            this.GBSolicitante.Controls.Add(this.dtpHasta);
            this.GBSolicitante.Controls.Add(this.dtpFechaDesde);
            this.GBSolicitante.Controls.Add(this.label1);
            this.GBSolicitante.Controls.Add(this.BtnSalir);
            this.GBSolicitante.Controls.Add(this.Label2);
            this.GBSolicitante.Controls.Add(this.BtnBuscar);
            this.GBSolicitante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSolicitante.ForeColor = System.Drawing.Color.Maroon;
            this.GBSolicitante.Location = new System.Drawing.Point(10, 11);
            this.GBSolicitante.Name = "GBSolicitante";
            this.GBSolicitante.Size = new System.Drawing.Size(335, 95);
            this.GBSolicitante.TabIndex = 1;
            this.GBSolicitante.TabStop = false;
            this.GBSolicitante.Text = "Filtro por fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(218, 31);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(102, 21);
            this.dtpHasta.TabIndex = 0;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(63, 31);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(102, 21);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hasta :";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalir.Location = new System.Drawing.Point(170, 57);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(62, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(10, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Desde :";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(102, 57);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(62, 23);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.White;
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtDireccion.Location = new System.Drawing.Point(12, 112);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(333, 37);
            this.TxtDireccion.TabIndex = 3;
            this.TxtDireccion.Text = "PERMITE INGRESAR LA FECHA DE COBRANZA, DONDE MOSTRARA LOS INGRESOS POR CAJERO.";
            // 
            // frmIngresosPorCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 154);
            this.Controls.Add(this.GBSolicitante);
            this.Controls.Add(this.TxtDireccion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmIngresosPorCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Caja Total Ingresos:::...";
            this.GBSolicitante.ResumeLayout(false);
            this.GBSolicitante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBSolicitante;
        internal System.Windows.Forms.TextBox TxtDireccion;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        internal System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        internal System.Windows.Forms.Label label1;
    }
}