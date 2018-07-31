namespace GUI_Tesoreria.Contabilidad
{
    partial class frmMantenimientoDepositos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDepositos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBPrimerDetalle = new System.Windows.Forms.GroupBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.dtpFechaLiq = new System.Windows.Forms.DateTimePicker();
            this.chkOtros = new System.Windows.Forms.CheckBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.FEC_DEPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varProDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE_ME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMBIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHEQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLOSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEP_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEC_LIQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROG_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODAL_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEP_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_REG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBPrimerDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPrimerDetalle
            // 
            this.GBPrimerDetalle.BackColor = System.Drawing.Color.Transparent;
            this.GBPrimerDetalle.Controls.Add(this.btnVer);
            this.GBPrimerDetalle.Controls.Add(this.chkOtros);
            this.GBPrimerDetalle.Controls.Add(this.dtpFechaLiq);
            this.GBPrimerDetalle.Controls.Add(this.LblCodigo);
            this.GBPrimerDetalle.Location = new System.Drawing.Point(12, 12);
            this.GBPrimerDetalle.Name = "GBPrimerDetalle";
            this.GBPrimerDetalle.Size = new System.Drawing.Size(843, 73);
            this.GBPrimerDetalle.TabIndex = 46;
            this.GBPrimerDetalle.TabStop = false;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Navy;
            this.LblCodigo.Location = new System.Drawing.Point(6, 27);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(123, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Fecha de Liquidación";
            // 
            // dtpFechaLiq
            // 
            this.dtpFechaLiq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiq.Location = new System.Drawing.Point(135, 21);
            this.dtpFechaLiq.Name = "dtpFechaLiq";
            this.dtpFechaLiq.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaLiq.TabIndex = 1;
            // 
            // chkOtros
            // 
            this.chkOtros.AutoSize = true;
            this.chkOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOtros.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkOtros.Location = new System.Drawing.Point(260, 24);
            this.chkOtros.Name = "chkOtros";
            this.chkOtros.Size = new System.Drawing.Size(60, 19);
            this.chkOtros.TabIndex = 5;
            this.chkOtros.Text = "Otros";
            this.chkOtros.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Navy;
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(478, 19);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(85, 36);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDepositos);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 292);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.AllowUserToDeleteRows = false;
            this.dgvDepositos.AllowUserToResizeColumns = false;
            this.dgvDepositos.AllowUserToResizeRows = false;
            this.dgvDepositos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepositos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FEC_DEPO,
            this.varProDescripcion,
            this.nombre_entidad,
            this.CUENTA_NUM,
            this.desc_mod_Pago,
            this.IMPORTE,
            this.IMPORTE_ME,
            this.CAMBIO,
            this.VOUCHER,
            this.CHEQUE,
            this.GLOSA,
            this.CONCEP_DESC,
            this.DEPOID,
            this.FEC_LIQ,
            this.PROG_COD,
            this.BANCO_COD,
            this.MODAL_COD,
            this.CONCEP_COD,
            this.TIPO_REG});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepositos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDepositos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepositos.Location = new System.Drawing.Point(3, 16);
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepositos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDepositos.RowHeadersVisible = false;
            this.dgvDepositos.RowHeadersWidth = 10;
            this.dgvDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepositos.Size = new System.Drawing.Size(837, 273);
            this.dgvDepositos.TabIndex = 5;
            // 
            // FEC_DEPO
            // 
            this.FEC_DEPO.DataPropertyName = "FEC_DEPO";
            this.FEC_DEPO.HeaderText = "FECHA";
            this.FEC_DEPO.Name = "FEC_DEPO";
            this.FEC_DEPO.ReadOnly = true;
            // 
            // varProDescripcion
            // 
            this.varProDescripcion.DataPropertyName = "varProDescripcion";
            this.varProDescripcion.HeaderText = "PROGRAMA";
            this.varProDescripcion.Name = "varProDescripcion";
            this.varProDescripcion.ReadOnly = true;
            // 
            // nombre_entidad
            // 
            this.nombre_entidad.DataPropertyName = "nombre_entidad";
            this.nombre_entidad.HeaderText = "BANCO";
            this.nombre_entidad.Name = "nombre_entidad";
            this.nombre_entidad.ReadOnly = true;
            // 
            // CUENTA_NUM
            // 
            this.CUENTA_NUM.DataPropertyName = "CUENTA_NUM";
            this.CUENTA_NUM.HeaderText = "CUENTA";
            this.CUENTA_NUM.Name = "CUENTA_NUM";
            this.CUENTA_NUM.ReadOnly = true;
            // 
            // desc_mod_Pago
            // 
            this.desc_mod_Pago.DataPropertyName = "desc_mod_Pago";
            this.desc_mod_Pago.HeaderText = "MODALIDAD";
            this.desc_mod_Pago.Name = "desc_mod_Pago";
            this.desc_mod_Pago.ReadOnly = true;
            // 
            // IMPORTE
            // 
            this.IMPORTE.DataPropertyName = "IMPORTE";
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // IMPORTE_ME
            // 
            this.IMPORTE_ME.DataPropertyName = "IMPORTE_ME";
            this.IMPORTE_ME.HeaderText = "IMPORTE_EXT";
            this.IMPORTE_ME.Name = "IMPORTE_ME";
            this.IMPORTE_ME.ReadOnly = true;
            // 
            // CAMBIO
            // 
            this.CAMBIO.DataPropertyName = "CAMBIO";
            this.CAMBIO.HeaderText = "T/CAMBIO";
            this.CAMBIO.Name = "CAMBIO";
            this.CAMBIO.ReadOnly = true;
            // 
            // VOUCHER
            // 
            this.VOUCHER.DataPropertyName = "VOUCHER";
            this.VOUCHER.HeaderText = "VOUCHER";
            this.VOUCHER.Name = "VOUCHER";
            this.VOUCHER.ReadOnly = true;
            // 
            // CHEQUE
            // 
            this.CHEQUE.DataPropertyName = "CHEQUE";
            this.CHEQUE.HeaderText = "CHEQUE";
            this.CHEQUE.Name = "CHEQUE";
            this.CHEQUE.ReadOnly = true;
            // 
            // GLOSA
            // 
            this.GLOSA.DataPropertyName = "GLOSA";
            this.GLOSA.HeaderText = "GLOSA";
            this.GLOSA.Name = "GLOSA";
            this.GLOSA.ReadOnly = true;
            // 
            // CONCEP_DESC
            // 
            this.CONCEP_DESC.DataPropertyName = "CONCEP_DESC";
            this.CONCEP_DESC.HeaderText = "CONCEP_DESC";
            this.CONCEP_DESC.Name = "CONCEP_DESC";
            this.CONCEP_DESC.ReadOnly = true;
            // 
            // DEPOID
            // 
            this.DEPOID.DataPropertyName = "DEPOID";
            this.DEPOID.HeaderText = "DEPOID";
            this.DEPOID.Name = "DEPOID";
            this.DEPOID.ReadOnly = true;
            // 
            // FEC_LIQ
            // 
            this.FEC_LIQ.DataPropertyName = "FEC_LIQ";
            this.FEC_LIQ.HeaderText = "FEC_LIQ";
            this.FEC_LIQ.Name = "FEC_LIQ";
            this.FEC_LIQ.ReadOnly = true;
            // 
            // PROG_COD
            // 
            this.PROG_COD.DataPropertyName = "PROG_COD";
            this.PROG_COD.HeaderText = "PROG_COD";
            this.PROG_COD.Name = "PROG_COD";
            this.PROG_COD.ReadOnly = true;
            // 
            // BANCO_COD
            // 
            this.BANCO_COD.DataPropertyName = "BANCO_COD";
            this.BANCO_COD.HeaderText = "BANCO_COD";
            this.BANCO_COD.Name = "BANCO_COD";
            this.BANCO_COD.ReadOnly = true;
            // 
            // MODAL_COD
            // 
            this.MODAL_COD.DataPropertyName = "MODAL_COD";
            this.MODAL_COD.HeaderText = "MODAL_COD";
            this.MODAL_COD.Name = "MODAL_COD";
            this.MODAL_COD.ReadOnly = true;
            // 
            // CONCEP_COD
            // 
            this.CONCEP_COD.DataPropertyName = "CONCEP_COD";
            this.CONCEP_COD.HeaderText = "CONCEP_COD";
            this.CONCEP_COD.Name = "CONCEP_COD";
            this.CONCEP_COD.ReadOnly = true;
            // 
            // TIPO_REG
            // 
            this.TIPO_REG.DataPropertyName = "TIPO_REG";
            this.TIPO_REG.HeaderText = "TIPO_REG";
            this.TIPO_REG.Name = "TIPO_REG";
            this.TIPO_REG.ReadOnly = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.Navy;
            this.BtnNuevo.Location = new System.Drawing.Point(21, 19);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(74, 39);
            this.BtnNuevo.TabIndex = 49;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Navy;
            this.btnEliminar.Location = new System.Drawing.Point(188, 19);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 39);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Navy;
            this.btnModificar.Location = new System.Drawing.Point(104, 19);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 39);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Navy;
            this.btnImprimir.Location = new System.Drawing.Point(272, 19);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(74, 39);
            this.btnImprimir.TabIndex = 48;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Location = new System.Drawing.Point(356, 19);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 39);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNuevo);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Location = new System.Drawing.Point(12, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 69);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // frmMantenimientoDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBPrimerDetalle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoDepositos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Depósitos Bancarios:::...";
            this.Load += new System.EventHandler(this.frmMantenimientoDepositos_Load);
            this.GBPrimerDetalle.ResumeLayout(false);
            this.GBPrimerDetalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBPrimerDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaLiq;
        internal System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.CheckBox chkOtros;
        internal System.Windows.Forms.Button btnVer;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_DEPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn varProDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE_ME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMBIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHEQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLOSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEP_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_LIQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROG_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODAL_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEP_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_REG;
        internal System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}