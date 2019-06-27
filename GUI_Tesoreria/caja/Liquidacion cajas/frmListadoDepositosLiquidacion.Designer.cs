namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmListadoDepositosLiquidacion
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
            this.dgvListadoVouchers = new System.Windows.Forms.DataGridView();
            this.Depositos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idIngresosEfectivoDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concep_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalVouchers = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVouchers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.observaciones});
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
            this.dgvListadoVouchers.Size = new System.Drawing.Size(950, 444);
            this.dgvListadoVouchers.TabIndex = 16;
            this.dgvListadoVouchers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVouchers_CellClick);
            this.dgvListadoVouchers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoVouchers_CellPainting);
            this.dgvListadoVouchers.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgvListadoVouchers_CellToolTipTextNeeded);
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
            // desc_mod_Pago
            // 
            this.desc_mod_Pago.DataPropertyName = "desc_mod_Pago";
            this.desc_mod_Pago.Frozen = true;
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
            this.FechaDeposito.Frozen = true;
            this.FechaDeposito.HeaderText = "Fecha Depósito";
            this.FechaDeposito.Name = "FechaDeposito";
            this.FechaDeposito.ReadOnly = true;
            this.FechaDeposito.Width = 80;
            // 
            // cod_entidad_financ
            // 
            this.cod_entidad_financ.DataPropertyName = "cod_entidad_financ";
            this.cod_entidad_financ.Frozen = true;
            this.cod_entidad_financ.HeaderText = "cod_entidad_financ";
            this.cod_entidad_financ.Name = "cod_entidad_financ";
            this.cod_entidad_financ.ReadOnly = true;
            this.cod_entidad_financ.Visible = false;
            // 
            // nombre_entidad
            // 
            this.nombre_entidad.DataPropertyName = "nombre_entidad";
            this.nombre_entidad.Frozen = true;
            this.nombre_entidad.HeaderText = "Nombre Entidad";
            this.nombre_entidad.Name = "nombre_entidad";
            this.nombre_entidad.ReadOnly = true;
            this.nombre_entidad.Width = 150;
            // 
            // cuenta_bancaria_id
            // 
            this.cuenta_bancaria_id.DataPropertyName = "cuenta_bancaria_id";
            this.cuenta_bancaria_id.Frozen = true;
            this.cuenta_bancaria_id.HeaderText = "cuenta_bancaria_id";
            this.cuenta_bancaria_id.Name = "cuenta_bancaria_id";
            this.cuenta_bancaria_id.ReadOnly = true;
            this.cuenta_bancaria_id.Visible = false;
            // 
            // numero_cuenta
            // 
            this.numero_cuenta.DataPropertyName = "numero_cuenta";
            this.numero_cuenta.Frozen = true;
            this.numero_cuenta.HeaderText = "Número Cuenta";
            this.numero_cuenta.Name = "numero_cuenta";
            this.numero_cuenta.ReadOnly = true;
            this.numero_cuenta.Width = 120;
            // 
            // NumeroDocumento_Voucher_cheque_pago
            // 
            this.NumeroDocumento_Voucher_cheque_pago.DataPropertyName = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.Frozen = true;
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
            this.importe_voucher_pago.Frozen = true;
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
            this.TipoCambio.Frozen = true;
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
            this.importe_cambio.Frozen = true;
            this.importe_cambio.HeaderText = "Total";
            this.importe_cambio.Name = "importe_cambio";
            this.importe_cambio.ReadOnly = true;
            // 
            // tabla
            // 
            this.tabla.DataPropertyName = "tabla";
            this.tabla.Frozen = true;
            this.tabla.HeaderText = "tabla";
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Visible = false;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.Frozen = true;
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvListadoVouchers);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(956, 464);
            this.groupBox3.TabIndex = 146;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Vouchers";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(882, 479);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 148;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(708, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 149;
            this.label6.Text = "Total";
            // 
            // txtTotalVouchers
            // 
            this.txtTotalVouchers.BackColor = System.Drawing.Color.White;
            this.txtTotalVouchers.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalVouchers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVouchers.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalVouchers.Location = new System.Drawing.Point(750, 479);
            this.txtTotalVouchers.MaxLength = 11;
            this.txtTotalVouchers.Name = "txtTotalVouchers";
            this.txtTotalVouchers.ReadOnly = true;
            this.txtTotalVouchers.Size = new System.Drawing.Size(126, 21);
            this.txtTotalVouchers.TabIndex = 150;
            this.txtTotalVouchers.Text = "0.00";
            this.txtTotalVouchers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Navy;
            this.btnImprimir.Image = global::GUI_Tesoreria.Properties.Resources.imprimirD;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(12, 482);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(69, 57);
            this.btnImprimir.TabIndex = 151;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Navy;
            this.btnExportar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(91, 482);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(109, 57);
            this.btnExportar.TabIndex = 151;
            this.btnExportar.Text = "&Exportar Vouchers";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmListadoDepositosLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 565);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalVouchers);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListadoDepositosLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listado de Vouchers:::...";
            this.Load += new System.EventHandler(this.frmListadoDepositosLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVouchers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvListadoVouchers;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTotalVouchers;
        internal System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewButtonColumn Depositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIngresosEfectivoDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn concep_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_mod_Pago;
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
        internal System.Windows.Forms.Button btnExportar;
    }
}