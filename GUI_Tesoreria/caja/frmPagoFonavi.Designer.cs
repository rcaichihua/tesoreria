namespace GUI_Tesoreria.caja
{
    partial class frmPagoFonavi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFonavi = new System.Windows.Forms.DataGridView();
            this.facturaOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amortizaOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interesOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguroOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silatOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morafonaOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moraconc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igvOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuministro = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCopiaOriginal = new System.Windows.Forms.DataGridView();
            this.id_cuenta_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dscto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varCeNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFonavi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopiaOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFonavi
            // 
            this.dgvFonavi.AllowUserToAddRows = false;
            this.dgvFonavi.AllowUserToDeleteRows = false;
            this.dgvFonavi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFonavi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaOrb,
            this.fechpago,
            this.cuota,
            this.importeOrb,
            this.amortizaOrb,
            this.interesOrb,
            this.seguroOrb,
            this.silatOrb,
            this.morafonaOrb,
            this.moraconc,
            this.comision,
            this.igvOrb,
            this.totalOrb});
            this.dgvFonavi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFonavi.Location = new System.Drawing.Point(3, 16);
            this.dgvFonavi.Name = "dgvFonavi";
            this.dgvFonavi.ReadOnly = true;
            this.dgvFonavi.RowHeadersWidth = 25;
            this.dgvFonavi.Size = new System.Drawing.Size(943, 320);
            this.dgvFonavi.TabIndex = 0;
            // 
            // facturaOrb
            // 
            this.facturaOrb.DataPropertyName = "factura";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.facturaOrb.DefaultCellStyle = dataGridViewCellStyle27;
            this.facturaOrb.HeaderText = "Nº FACTURA";
            this.facturaOrb.Name = "facturaOrb";
            this.facturaOrb.ReadOnly = true;
            this.facturaOrb.Width = 70;
            // 
            // fechpago
            // 
            this.fechpago.DataPropertyName = "fechpago";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle28.Format = "d";
            dataGridViewCellStyle28.NullValue = null;
            this.fechpago.DefaultCellStyle = dataGridViewCellStyle28;
            this.fechpago.HeaderText = "FECHA DOC";
            this.fechpago.Name = "fechpago";
            this.fechpago.ReadOnly = true;
            this.fechpago.Width = 70;
            // 
            // cuota
            // 
            this.cuota.DataPropertyName = "cuota";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.cuota.DefaultCellStyle = dataGridViewCellStyle29;
            this.cuota.HeaderText = "CUOTA";
            this.cuota.Name = "cuota";
            this.cuota.ReadOnly = true;
            this.cuota.Width = 60;
            // 
            // importeOrb
            // 
            this.importeOrb.DataPropertyName = "importe";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle30.Format = "N2";
            this.importeOrb.DefaultCellStyle = dataGridViewCellStyle30;
            this.importeOrb.HeaderText = "IMPORTE";
            this.importeOrb.Name = "importeOrb";
            this.importeOrb.ReadOnly = true;
            this.importeOrb.Width = 70;
            // 
            // amortizaOrb
            // 
            this.amortizaOrb.DataPropertyName = "amortiza";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle31.Format = "N2";
            this.amortizaOrb.DefaultCellStyle = dataGridViewCellStyle31;
            this.amortizaOrb.HeaderText = "AMORTIZA";
            this.amortizaOrb.Name = "amortizaOrb";
            this.amortizaOrb.ReadOnly = true;
            this.amortizaOrb.Width = 70;
            // 
            // interesOrb
            // 
            this.interesOrb.DataPropertyName = "interes";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle32.Format = "N2";
            this.interesOrb.DefaultCellStyle = dataGridViewCellStyle32;
            this.interesOrb.HeaderText = "INTERES";
            this.interesOrb.Name = "interesOrb";
            this.interesOrb.ReadOnly = true;
            this.interesOrb.Width = 70;
            // 
            // seguroOrb
            // 
            this.seguroOrb.DataPropertyName = "seguro";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle33.Format = "N2";
            this.seguroOrb.DefaultCellStyle = dataGridViewCellStyle33;
            this.seguroOrb.HeaderText = "SEGURO";
            this.seguroOrb.Name = "seguroOrb";
            this.seguroOrb.ReadOnly = true;
            this.seguroOrb.Width = 70;
            // 
            // silatOrb
            // 
            this.silatOrb.DataPropertyName = "silat";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle34.Format = "N2";
            this.silatOrb.DefaultCellStyle = dataGridViewCellStyle34;
            this.silatOrb.HeaderText = "SILAT";
            this.silatOrb.Name = "silatOrb";
            this.silatOrb.ReadOnly = true;
            this.silatOrb.Width = 70;
            // 
            // morafonaOrb
            // 
            this.morafonaOrb.DataPropertyName = "morafona";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle35.Format = "N2";
            this.morafonaOrb.DefaultCellStyle = dataGridViewCellStyle35;
            this.morafonaOrb.HeaderText = "MORA F.";
            this.morafonaOrb.Name = "morafonaOrb";
            this.morafonaOrb.ReadOnly = true;
            this.morafonaOrb.Width = 70;
            // 
            // moraconc
            // 
            this.moraconc.DataPropertyName = "moraconc";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle36.Format = "N2";
            this.moraconc.DefaultCellStyle = dataGridViewCellStyle36;
            this.moraconc.HeaderText = "MORA C.";
            this.moraconc.Name = "moraconc";
            this.moraconc.ReadOnly = true;
            this.moraconc.Width = 70;
            // 
            // comision
            // 
            this.comision.DataPropertyName = "comision";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle37.Format = "N2";
            this.comision.DefaultCellStyle = dataGridViewCellStyle37;
            this.comision.HeaderText = "COMISION";
            this.comision.Name = "comision";
            this.comision.ReadOnly = true;
            this.comision.Width = 70;
            // 
            // igvOrb
            // 
            this.igvOrb.DataPropertyName = "igv";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle38.Format = "N2";
            this.igvOrb.DefaultCellStyle = dataGridViewCellStyle38;
            this.igvOrb.HeaderText = "IGV";
            this.igvOrb.Name = "igvOrb";
            this.igvOrb.ReadOnly = true;
            this.igvOrb.Width = 70;
            // 
            // totalOrb
            // 
            this.totalOrb.DataPropertyName = "total";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle39.Format = "N2";
            this.totalOrb.DefaultCellStyle = dataGridViewCellStyle39;
            this.totalOrb.HeaderText = "TOTAL";
            this.totalOrb.Name = "totalOrb";
            this.totalOrb.ReadOnly = true;
            this.totalOrb.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suministro";
            // 
            // txtSuministro
            // 
            this.txtSuministro.Location = new System.Drawing.Point(73, 26);
            this.txtSuministro.Name = "txtSuministro";
            this.txtSuministro.Size = new System.Drawing.Size(100, 20);
            this.txtSuministro.TabIndex = 2;
            this.txtSuministro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuministro_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(179, 26);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(390, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFonavi);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 339);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Navy;
            this.btnProcesar.Location = new System.Drawing.Point(631, 12);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(74, 34);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "&Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Location = new System.Drawing.Point(714, 12);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCopiaOriginal
            // 
            this.dgvCopiaOriginal.AllowUserToAddRows = false;
            this.dgvCopiaOriginal.AllowUserToDeleteRows = false;
            this.dgvCopiaOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopiaOriginal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cuenta_contable,
            this.idTarifa,
            this.CodigoRubro,
            this.Descripcion,
            this.Precio,
            this.Dscto,
            this.Igv,
            this.Cantidad,
            this.Importe,
            this.varCeNombre});
            this.dgvCopiaOriginal.Location = new System.Drawing.Point(885, 12);
            this.dgvCopiaOriginal.Name = "dgvCopiaOriginal";
            this.dgvCopiaOriginal.ReadOnly = true;
            this.dgvCopiaOriginal.Size = new System.Drawing.Size(59, 34);
            this.dgvCopiaOriginal.TabIndex = 7;
            this.dgvCopiaOriginal.Visible = false;
            // 
            // id_cuenta_contable
            // 
            this.id_cuenta_contable.DataPropertyName = "id_cuenta_contable";
            this.id_cuenta_contable.HeaderText = "id_cuenta_contable";
            this.id_cuenta_contable.Name = "id_cuenta_contable";
            this.id_cuenta_contable.ReadOnly = true;
            // 
            // idTarifa
            // 
            this.idTarifa.DataPropertyName = "idTarifa";
            this.idTarifa.HeaderText = "idTarifa";
            this.idTarifa.Name = "idTarifa";
            this.idTarifa.ReadOnly = true;
            // 
            // CodigoRubro
            // 
            this.CodigoRubro.DataPropertyName = "CodigoRubro";
            this.CodigoRubro.HeaderText = "CodigoRubro";
            this.CodigoRubro.Name = "CodigoRubro";
            this.CodigoRubro.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Dscto
            // 
            this.Dscto.DataPropertyName = "Dscto";
            this.Dscto.HeaderText = "Dscto";
            this.Dscto.Name = "Dscto";
            this.Dscto.ReadOnly = true;
            // 
            // Igv
            // 
            this.Igv.DataPropertyName = "Igv";
            this.Igv.HeaderText = "Igv";
            this.Igv.Name = "Igv";
            this.Igv.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // varCeNombre
            // 
            this.varCeNombre.DataPropertyName = "varCeNombre";
            this.varCeNombre.HeaderText = "varCeNombre";
            this.varCeNombre.Name = "varCeNombre";
            this.varCeNombre.ReadOnly = true;
            // 
            // frmPagoFonavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 405);
            this.Controls.Add(this.dgvCopiaOriginal);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtSuministro);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPagoFonavi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagoFonavi";
            this.Load += new System.EventHandler(this.frmPagoFonavi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFonavi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopiaOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFonavi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuministro;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnProcesar;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn amortizaOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn interesOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguroOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn silatOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn morafonaOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn moraconc;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn igvOrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrb;
        private System.Windows.Forms.DataGridView dgvCopiaOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cuenta_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dscto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn varCeNombre;
    }
}