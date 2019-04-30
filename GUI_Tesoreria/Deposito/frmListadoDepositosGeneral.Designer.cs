namespace GUI_Tesoreria.Deposito
{
    partial class frmListadoDepositosGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalVouchers = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListadoVouchers = new System.Windows.Forms.DataGridView();
            this.dtpFechaLiquidación = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Depositos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idIngresosEfectivoDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concep_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_entidad_financ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta_bancaria_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento_Voucher_cheque_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_voucher_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROG_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(634, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 153;
            this.label6.Text = "Total";
            // 
            // txtTotalVouchers
            // 
            this.txtTotalVouchers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalVouchers.BackColor = System.Drawing.Color.White;
            this.txtTotalVouchers.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalVouchers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVouchers.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalVouchers.Location = new System.Drawing.Point(676, 451);
            this.txtTotalVouchers.MaxLength = 11;
            this.txtTotalVouchers.Name = "txtTotalVouchers";
            this.txtTotalVouchers.ReadOnly = true;
            this.txtTotalVouchers.Size = new System.Drawing.Size(158, 21);
            this.txtTotalVouchers.TabIndex = 154;
            this.txtTotalVouchers.Text = "0.00";
            this.txtTotalVouchers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvListadoVouchers);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 374);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Vouchers";
            // 
            // dgvListadoVouchers
            // 
            this.dgvListadoVouchers.AllowUserToAddRows = false;
            this.dgvListadoVouchers.AllowUserToDeleteRows = false;
            this.dgvListadoVouchers.AllowUserToResizeColumns = false;
            this.dgvListadoVouchers.AllowUserToResizeRows = false;
            this.dgvListadoVouchers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depositos,
            this.idIngresosEfectivoDeposito,
            this.concep_cod,
            this.cod_mod_Pago,
            this.programa,
            this.desc_mod_Pago,
            this.FechaDeposito,
            this.cod_entidad_financ,
            this.nombre_entidad,
            this.cuenta_bancaria_id,
            this.numero_cuenta,
            this.NumeroDocumento_Voucher_cheque_pago,
            this.importe_voucher_pago,
            this.TipoCambio,
            this.importe_cambio,
            this.tabla,
            this.observaciones,
            this.PROG_COD});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoVouchers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListadoVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoVouchers.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListadoVouchers.Location = new System.Drawing.Point(3, 17);
            this.dgvListadoVouchers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoVouchers.Name = "dgvListadoVouchers";
            this.dgvListadoVouchers.ReadOnly = true;
            this.dgvListadoVouchers.RowHeadersVisible = false;
            this.dgvListadoVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoVouchers.Size = new System.Drawing.Size(1049, 354);
            this.dgvListadoVouchers.TabIndex = 16;
            this.dgvListadoVouchers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVouchers_CellClick);
            this.dgvListadoVouchers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoVouchers_CellPainting);
            // 
            // dtpFechaLiquidación
            // 
            this.dtpFechaLiquidación.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidación.Location = new System.Drawing.Point(15, 37);
            this.dtpFechaLiquidación.Name = "dtpFechaLiquidación";
            this.dtpFechaLiquidación.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaLiquidación.TabIndex = 156;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(12, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 157;
            this.Label2.Text = "Fecha liquidación";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(64, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "Total registros:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Location = new System.Drawing.Point(165, 454);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(14, 13);
            this.lblCantidad.TabIndex = 159;
            this.lblCantidad.Text = "0";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Navy;
            this.btnVer.Image = global::GUI_Tesoreria.Properties.Resources.asignar;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(133, 31);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(65, 36);
            this.btnVer.TabIndex = 155;
            this.btnVer.Text = "&Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(978, 448);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 152;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Depositos
            // 
            this.Depositos.Frozen = true;
            this.Depositos.HeaderText = "";
            this.Depositos.Name = "Depositos";
            this.Depositos.ReadOnly = true;
            this.Depositos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Depositos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Depositos.Width = 60;
            // 
            // idIngresosEfectivoDeposito
            // 
            this.idIngresosEfectivoDeposito.DataPropertyName = "idIngresosEfectivoDeposito";
            this.idIngresosEfectivoDeposito.Frozen = true;
            this.idIngresosEfectivoDeposito.HeaderText = "idIngresosEfectivoDeposito";
            this.idIngresosEfectivoDeposito.Name = "idIngresosEfectivoDeposito";
            this.idIngresosEfectivoDeposito.ReadOnly = true;
            this.idIngresosEfectivoDeposito.Visible = false;
            // 
            // concep_cod
            // 
            this.concep_cod.DataPropertyName = "concep_cod";
            this.concep_cod.Frozen = true;
            this.concep_cod.HeaderText = "concep_cod";
            this.concep_cod.Name = "concep_cod";
            this.concep_cod.ReadOnly = true;
            this.concep_cod.Visible = false;
            // 
            // cod_mod_Pago
            // 
            this.cod_mod_Pago.DataPropertyName = "cod_mod_Pago";
            this.cod_mod_Pago.Frozen = true;
            this.cod_mod_Pago.HeaderText = "cod_mod_Pago";
            this.cod_mod_Pago.Name = "cod_mod_Pago";
            this.cod_mod_Pago.ReadOnly = true;
            this.cod_mod_Pago.Visible = false;
            // 
            // programa
            // 
            this.programa.DataPropertyName = "programa";
            this.programa.HeaderText = "Programa";
            this.programa.Name = "programa";
            this.programa.ReadOnly = true;
            // 
            // desc_mod_Pago
            // 
            this.desc_mod_Pago.DataPropertyName = "desc_mod_Pago";
            this.desc_mod_Pago.HeaderText = "Modalidad de Pago";
            this.desc_mod_Pago.Name = "desc_mod_Pago";
            this.desc_mod_Pago.ReadOnly = true;
            this.desc_mod_Pago.Width = 150;
            // 
            // FechaDeposito
            // 
            this.FechaDeposito.DataPropertyName = "FechaDeposito";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaDeposito.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaDeposito.HeaderText = "Fecha Depósito";
            this.FechaDeposito.Name = "FechaDeposito";
            this.FechaDeposito.ReadOnly = true;
            this.FechaDeposito.Width = 80;
            // 
            // cod_entidad_financ
            // 
            this.cod_entidad_financ.DataPropertyName = "cod_entidad_financ";
            this.cod_entidad_financ.HeaderText = "cod_entidad_financ";
            this.cod_entidad_financ.Name = "cod_entidad_financ";
            this.cod_entidad_financ.ReadOnly = true;
            this.cod_entidad_financ.Visible = false;
            // 
            // nombre_entidad
            // 
            this.nombre_entidad.DataPropertyName = "nombre_entidad";
            this.nombre_entidad.HeaderText = "Nombre Entidad";
            this.nombre_entidad.Name = "nombre_entidad";
            this.nombre_entidad.ReadOnly = true;
            this.nombre_entidad.Width = 150;
            // 
            // cuenta_bancaria_id
            // 
            this.cuenta_bancaria_id.DataPropertyName = "cuenta_bancaria_id";
            this.cuenta_bancaria_id.HeaderText = "cuenta_bancaria_id";
            this.cuenta_bancaria_id.Name = "cuenta_bancaria_id";
            this.cuenta_bancaria_id.ReadOnly = true;
            this.cuenta_bancaria_id.Visible = false;
            // 
            // numero_cuenta
            // 
            this.numero_cuenta.DataPropertyName = "numero_cuenta";
            this.numero_cuenta.HeaderText = "Número Cuenta";
            this.numero_cuenta.Name = "numero_cuenta";
            this.numero_cuenta.ReadOnly = true;
            this.numero_cuenta.Width = 120;
            // 
            // NumeroDocumento_Voucher_cheque_pago
            // 
            this.NumeroDocumento_Voucher_cheque_pago.DataPropertyName = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.HeaderText = "Nro Voucher";
            this.NumeroDocumento_Voucher_cheque_pago.Name = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.ReadOnly = true;
            // 
            // importe_voucher_pago
            // 
            this.importe_voucher_pago.DataPropertyName = "importe_voucher_pago";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n2";
            this.importe_voucher_pago.DefaultCellStyle = dataGridViewCellStyle2;
            this.importe_voucher_pago.HeaderText = "Importe Voucher";
            this.importe_voucher_pago.Name = "importe_voucher_pago";
            this.importe_voucher_pago.ReadOnly = true;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n3";
            this.TipoCambio.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipoCambio.HeaderText = "T.C.";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            this.TipoCambio.Width = 60;
            // 
            // importe_cambio
            // 
            this.importe_cambio.DataPropertyName = "importe_cambio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.importe_cambio.DefaultCellStyle = dataGridViewCellStyle4;
            this.importe_cambio.HeaderText = "Total";
            this.importe_cambio.Name = "importe_cambio";
            this.importe_cambio.ReadOnly = true;
            // 
            // tabla
            // 
            this.tabla.DataPropertyName = "tabla";
            this.tabla.HeaderText = "tabla";
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // PROG_COD
            // 
            this.PROG_COD.DataPropertyName = "PROG_COD";
            this.PROG_COD.HeaderText = "PROG_COD";
            this.PROG_COD.Name = "PROG_COD";
            this.PROG_COD.ReadOnly = true;
            this.PROG_COD.Visible = false;
            // 
            // frmListadoDepositosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 523);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaLiquidación);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalVouchers);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoDepositosGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listado de depositos:::...";
            this.Load += new System.EventHandler(this.frmListadoDepositosGeneral_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVouchers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTotalVouchers;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvListadoVouchers;
        internal System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidación;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Depositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIngresosEfectivoDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn concep_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_entidad_financ;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta_bancaria_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento_Voucher_cheque_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_voucher_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROG_COD;
    }
}