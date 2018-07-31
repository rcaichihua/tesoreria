namespace GUI_Tesoreria.caja
{
    partial class frmExtornarRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtornarRecibo));
            this.GbOpciones = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GBRecibo = new System.Windows.Forms.GroupBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.TxtNumeroRecibo = new System.Windows.Forms.TextBox();
            this.LblNRecibo = new System.Windows.Forms.Label();
            this.GbDetalleRecibo = new System.Windows.Forms.GroupBox();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.LblObservacion = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.GbOpciones.SuspendLayout();
            this.GBRecibo.SuspendLayout();
            this.GbDetalleRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbOpciones
            // 
            this.GbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GbOpciones.Controls.Add(this.BtnSalir);
            this.GbOpciones.Controls.Add(this.BtnEliminar);
            this.GbOpciones.Location = new System.Drawing.Point(479, 12);
            this.GbOpciones.Name = "GbOpciones";
            this.GbOpciones.Size = new System.Drawing.Size(73, 238);
            this.GbOpciones.TabIndex = 86;
            this.GbOpciones.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(6, 195);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(61, 39);
            this.BtnSalir.TabIndex = 82;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(5, 13);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(61, 39);
            this.BtnEliminar.TabIndex = 81;
            this.BtnEliminar.Text = "&Extornar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GBRecibo
            // 
            this.GBRecibo.BackColor = System.Drawing.Color.Transparent;
            this.GBRecibo.Controls.Add(this.TxtSerie);
            this.GBRecibo.Controls.Add(this.TxtNumeroRecibo);
            this.GBRecibo.Controls.Add(this.LblNRecibo);
            this.GBRecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBRecibo.ForeColor = System.Drawing.Color.Maroon;
            this.GBRecibo.Location = new System.Drawing.Point(12, 12);
            this.GBRecibo.Name = "GBRecibo";
            this.GBRecibo.Size = new System.Drawing.Size(461, 57);
            this.GBRecibo.TabIndex = 85;
            this.GBRecibo.TabStop = false;
            this.GBRecibo.Text = "Número Documento a Anular";
            // 
            // TxtSerie
            // 
            this.TxtSerie.BackColor = System.Drawing.Color.White;
            this.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSerie.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerie.ForeColor = System.Drawing.Color.Maroon;
            this.TxtSerie.Location = new System.Drawing.Point(156, 22);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(42, 21);
            this.TxtSerie.TabIndex = 13;
            this.TxtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNumeroRecibo
            // 
            this.TxtNumeroRecibo.BackColor = System.Drawing.Color.White;
            this.TxtNumeroRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumeroRecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroRecibo.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNumeroRecibo.Location = new System.Drawing.Point(204, 22);
            this.TxtNumeroRecibo.Name = "TxtNumeroRecibo";
            this.TxtNumeroRecibo.Size = new System.Drawing.Size(126, 21);
            this.TxtNumeroRecibo.TabIndex = 12;
            this.TxtNumeroRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNRecibo
            // 
            this.LblNRecibo.AutoSize = true;
            this.LblNRecibo.BackColor = System.Drawing.Color.Transparent;
            this.LblNRecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNRecibo.ForeColor = System.Drawing.Color.Navy;
            this.LblNRecibo.Location = new System.Drawing.Point(15, 22);
            this.LblNRecibo.Name = "LblNRecibo";
            this.LblNRecibo.Size = new System.Drawing.Size(125, 13);
            this.LblNRecibo.TabIndex = 1;
            this.LblNRecibo.Text = "Número Documento :";
            this.LblNRecibo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GbDetalleRecibo
            // 
            this.GbDetalleRecibo.BackColor = System.Drawing.Color.Transparent;
            this.GbDetalleRecibo.Controls.Add(this.TxtObservacion);
            this.GbDetalleRecibo.Controls.Add(this.LblObservacion);
            this.GbDetalleRecibo.Controls.Add(this.TxtMonto);
            this.GbDetalleRecibo.Controls.Add(this.LblNombre);
            this.GbDetalleRecibo.Controls.Add(this.LblTotal);
            this.GbDetalleRecibo.Controls.Add(this.TxtNombre);
            this.GbDetalleRecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDetalleRecibo.ForeColor = System.Drawing.Color.Maroon;
            this.GbDetalleRecibo.Location = new System.Drawing.Point(12, 70);
            this.GbDetalleRecibo.Name = "GbDetalleRecibo";
            this.GbDetalleRecibo.Size = new System.Drawing.Size(461, 180);
            this.GbDetalleRecibo.TabIndex = 84;
            this.GbDetalleRecibo.TabStop = false;
            this.GbDetalleRecibo.Text = "Detalle Documento";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtObservacion.ForeColor = System.Drawing.Color.Maroon;
            this.TxtObservacion.Location = new System.Drawing.Point(156, 77);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtObservacion.Size = new System.Drawing.Size(290, 85);
            this.TxtObservacion.TabIndex = 7;
            // 
            // LblObservacion
            // 
            this.LblObservacion.AutoSize = true;
            this.LblObservacion.BackColor = System.Drawing.Color.Transparent;
            this.LblObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservacion.ForeColor = System.Drawing.Color.Navy;
            this.LblObservacion.Location = new System.Drawing.Point(67, 80);
            this.LblObservacion.Name = "LblObservacion";
            this.LblObservacion.Size = new System.Drawing.Size(83, 13);
            this.LblObservacion.TabIndex = 6;
            this.LblObservacion.Text = "Observación :";
            // 
            // TxtMonto
            // 
            this.TxtMonto.BackColor = System.Drawing.Color.White;
            this.TxtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMonto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.ForeColor = System.Drawing.Color.Maroon;
            this.TxtMonto.Location = new System.Drawing.Point(156, 50);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(116, 21);
            this.TxtMonto.TabIndex = 11;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Navy;
            this.LblNombre.Location = new System.Drawing.Point(11, 26);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(140, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombres/Razón Social :";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Navy;
            this.LblTotal.Location = new System.Drawing.Point(108, 53);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(42, 13);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total :";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNombre.Location = new System.Drawing.Point(156, 23);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(290, 21);
            this.TxtNombre.TabIndex = 8;
            // 
            // frmExtornarRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.GbOpciones);
            this.Controls.Add(this.GBRecibo);
            this.Controls.Add(this.GbDetalleRecibo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmExtornarRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Extornar documento:::...";
            this.Load += new System.EventHandler(this.frmExtornarRecibo_Load);
            this.GbOpciones.ResumeLayout(false);
            this.GBRecibo.ResumeLayout(false);
            this.GBRecibo.PerformLayout();
            this.GbDetalleRecibo.ResumeLayout(false);
            this.GbDetalleRecibo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GbOpciones;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnEliminar;
        internal System.Windows.Forms.GroupBox GBRecibo;
        internal System.Windows.Forms.TextBox TxtSerie;
        internal System.Windows.Forms.TextBox TxtNumeroRecibo;
        internal System.Windows.Forms.Label LblNRecibo;
        internal System.Windows.Forms.GroupBox GbDetalleRecibo;
        internal System.Windows.Forms.TextBox TxtObservacion;
        internal System.Windows.Forms.Label LblObservacion;
        internal System.Windows.Forms.TextBox TxtMonto;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.TextBox TxtNombre;
    }
}