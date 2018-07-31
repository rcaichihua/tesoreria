namespace GUI_Tesoreria.DGAI
{
    partial class frmListadoDocumentosIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.dgvCabecera = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtTotalIngreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.IdIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_liqui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_cuenta_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip_cuenta_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charuCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_cuenta_contable1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip_cuenta_contable1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDatosRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabecera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.dgvCabecera);
            this.GBDatosRubros.Location = new System.Drawing.Point(12, 12);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(753, 184);
            this.GBDatosRubros.TabIndex = 124;
            this.GBDatosRubros.TabStop = false;
            this.GBDatosRubros.Text = "Cabecera de Documentos de Ingreso";
            // 
            // dgvCabecera
            // 
            this.dgvCabecera.AllowUserToAddRows = false;
            this.dgvCabecera.AllowUserToDeleteRows = false;
            this.dgvCabecera.AllowUserToResizeColumns = false;
            this.dgvCabecera.AllowUserToResizeRows = false;
            this.dgvCabecera.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCabecera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabecera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIngreso,
            this.nro_liqui,
            this.razon,
            this.fechaIngreso,
            this.desc_mod_Pago,
            this.codigo_cuenta_contable,
            this.descrip_cuenta_contable,
            this.totalDocumento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCabecera.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCabecera.Location = new System.Drawing.Point(3, 16);
            this.dgvCabecera.Name = "dgvCabecera";
            this.dgvCabecera.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCabecera.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCabecera.RowHeadersVisible = false;
            this.dgvCabecera.RowHeadersWidth = 10;
            this.dgvCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCabecera.Size = new System.Drawing.Size(747, 165);
            this.dgvCabecera.TabIndex = 3;
            this.dgvCabecera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCabecera_CellContentClick);
            this.dgvCabecera.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCabecera_CellEnter);
            this.dgvCabecera.Click += new System.EventHandler(this.dgvCabecera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDetalle);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 184);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Documentos de Ingreso";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charuCodigo,
            this.descripcion,
            this.codigo_cuenta_contable1,
            this.descrip_cuenta_contable1,
            this.precioUnitario,
            this.cantidad,
            this.importe});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 10;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(747, 165);
            this.dgvDetalle.TabIndex = 3;
            // 
            // txtTotalIngreso
            // 
            this.txtTotalIngreso.BackColor = System.Drawing.Color.White;
            this.txtTotalIngreso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngreso.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalIngreso.Location = new System.Drawing.Point(521, 392);
            this.txtTotalIngreso.Name = "txtTotalIngreso";
            this.txtTotalIngreso.ReadOnly = true;
            this.txtTotalIngreso.Size = new System.Drawing.Size(142, 22);
            this.txtTotalIngreso.TabIndex = 128;
            this.txtTotalIngreso.Text = "0.00";
            this.txtTotalIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(426, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Total Ingreso :";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(669, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 29);
            this.btnSalir.TabIndex = 126;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Navy;
            this.btnReporte.Image = global::GUI_Tesoreria.Properties.Resources.reporte;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(114, 392);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(167, 29);
            this.btnReporte.TabIndex = 125;
            this.btnReporte.Text = "&Reporte de Doc. de Ingreso";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.White;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.Navy;
            this.btnAnular.Image = global::GUI_Tesoreria.Properties.Resources.anular;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(15, 392);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(93, 29);
            this.btnAnular.TabIndex = 125;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // IdIngreso
            // 
            this.IdIngreso.DataPropertyName = "IdIngreso";
            this.IdIngreso.HeaderText = "IdIngreso";
            this.IdIngreso.Name = "IdIngreso";
            this.IdIngreso.ReadOnly = true;
            this.IdIngreso.Visible = false;
            // 
            // nro_liqui
            // 
            this.nro_liqui.DataPropertyName = "nro_liqui";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.nro_liqui.DefaultCellStyle = dataGridViewCellStyle2;
            this.nro_liqui.HeaderText = "Nro Liquidación";
            this.nro_liqui.Name = "nro_liqui";
            this.nro_liqui.ReadOnly = true;
            // 
            // razon
            // 
            this.razon.DataPropertyName = "razon";
            this.razon.HeaderText = "Razon";
            this.razon.Name = "razon";
            this.razon.ReadOnly = true;
            this.razon.Width = 70;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.fechaIngreso.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaIngreso.HeaderText = "Fecha de Ingreso";
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            // 
            // desc_mod_Pago
            // 
            this.desc_mod_Pago.DataPropertyName = "desc_mod_Pago";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.desc_mod_Pago.DefaultCellStyle = dataGridViewCellStyle4;
            this.desc_mod_Pago.HeaderText = "Modalidad de pago";
            this.desc_mod_Pago.Name = "desc_mod_Pago";
            this.desc_mod_Pago.ReadOnly = true;
            this.desc_mod_Pago.Width = 120;
            // 
            // codigo_cuenta_contable
            // 
            this.codigo_cuenta_contable.DataPropertyName = "codigocuenta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.codigo_cuenta_contable.DefaultCellStyle = dataGridViewCellStyle5;
            this.codigo_cuenta_contable.HeaderText = "Cuenta Contable";
            this.codigo_cuenta_contable.Name = "codigo_cuenta_contable";
            this.codigo_cuenta_contable.ReadOnly = true;
            // 
            // descrip_cuenta_contable
            // 
            this.descrip_cuenta_contable.DataPropertyName = "descripcioncuenta";
            this.descrip_cuenta_contable.HeaderText = "Cuenta";
            this.descrip_cuenta_contable.Name = "descrip_cuenta_contable";
            this.descrip_cuenta_contable.ReadOnly = true;
            this.descrip_cuenta_contable.Width = 120;
            // 
            // totalDocumento
            // 
            this.totalDocumento.DataPropertyName = "totalDocumento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.totalDocumento.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalDocumento.HeaderText = "Total Documento";
            this.totalDocumento.Name = "totalDocumento";
            this.totalDocumento.ReadOnly = true;
            // 
            // charuCodigo
            // 
            this.charuCodigo.DataPropertyName = "charuCodigo";
            this.charuCodigo.HeaderText = "Rubro";
            this.charuCodigo.Name = "charuCodigo";
            this.charuCodigo.ReadOnly = true;
            this.charuCodigo.Width = 70;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion Rubro";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // codigo_cuenta_contable1
            // 
            this.codigo_cuenta_contable1.DataPropertyName = "codigoCuenta";
            this.codigo_cuenta_contable1.HeaderText = "Cuenta Contable";
            this.codigo_cuenta_contable1.Name = "codigo_cuenta_contable1";
            this.codigo_cuenta_contable1.ReadOnly = true;
            // 
            // descrip_cuenta_contable1
            // 
            this.descrip_cuenta_contable1.DataPropertyName = "descripcionCuenta";
            this.descrip_cuenta_contable1.HeaderText = "Nombre cuenta";
            this.descrip_cuenta_contable1.Name = "descrip_cuenta_contable1";
            this.descrip_cuenta_contable1.ReadOnly = true;
            this.descrip_cuenta_contable1.Width = 130;
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "precioUnitario";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.precioUnitario.DefaultCellStyle = dataGridViewCellStyle10;
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle11.Format = "n0";
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle11;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 80;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.importe.DefaultCellStyle = dataGridViewCellStyle12;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // frmListadoDocumentosIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 428);
            this.Controls.Add(this.txtTotalIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBDatosRubros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListadoDocumentosIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoDocumentosIngreso";
            this.Load += new System.EventHandler(this.frmListadoDocumentosIngreso_Load);
            this.GBDatosRubros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabecera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.DataGridView dgvCabecera;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvDetalle;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnAnular;
        internal System.Windows.Forms.TextBox txtTotalIngreso;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_liqui;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cuenta_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip_cuenta_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn charuCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cuenta_contable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip_cuenta_contable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}