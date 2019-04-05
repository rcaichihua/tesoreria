namespace GUI_Tesoreria.caja
{
    partial class frmAgregarModalidadPago
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
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.cboConcepto = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cboEntidadFinanciera = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.cboModalidadPago = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtTotalCambioDolar = new System.Windows.Forms.TextBox();
            this.txtImportePago = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvModalidadesPago = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacionesPago = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cod_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concep_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_entidad_financ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta_bancaria_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_voucher_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento_Voucher_cheque_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoDocumento = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.GBPago.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadesPago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.txtObservacionesPago);
            this.GBPago.Controls.Add(this.label32);
            this.GBPago.Controls.Add(this.dtpFechaPago);
            this.GBPago.Controls.Add(this.cboConcepto);
            this.GBPago.Controls.Add(this.label26);
            this.GBPago.Controls.Add(this.label24);
            this.GBPago.Controls.Add(this.cboEntidadFinanciera);
            this.GBPago.Controls.Add(this.label27);
            this.GBPago.Controls.Add(this.label25);
            this.GBPago.Controls.Add(this.cboCuenta);
            this.GBPago.Controls.Add(this.cboModalidadPago);
            this.GBPago.Controls.Add(this.label23);
            this.GBPago.Controls.Add(this.txtNumDocumento);
            this.GBPago.Controls.Add(this.txtTipoCambio);
            this.GBPago.Controls.Add(this.label31);
            this.GBPago.Controls.Add(this.txtTotalCambioDolar);
            this.GBPago.Controls.Add(this.txtImportePago);
            this.GBPago.Controls.Add(this.label29);
            this.GBPago.Controls.Add(this.label12);
            this.GBPago.Controls.Add(this.lblTipoMoneda);
            this.GBPago.Controls.Add(this.label30);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 199);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(656, 139);
            this.GBPago.TabIndex = 150;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Acerca del pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(388, 37);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(94, 21);
            this.dtpFechaPago.TabIndex = 2;
            // 
            // cboConcepto
            // 
            this.cboConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboConcepto.BackColor = System.Drawing.Color.White;
            this.cboConcepto.DropDownHeight = 200;
            this.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConcepto.DropDownWidth = 400;
            this.cboConcepto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConcepto.ForeColor = System.Drawing.Color.Black;
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.IntegralHeight = false;
            this.cboConcepto.Location = new System.Drawing.Point(201, 36);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(160, 21);
            this.cboConcepto.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Navy;
            this.label26.Location = new System.Drawing.Point(386, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 13);
            this.label26.TabIndex = 120;
            this.label26.Text = "Fecha Deposito :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(198, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 120;
            this.label24.Text = "Concepto :";
            // 
            // cboEntidadFinanciera
            // 
            this.cboEntidadFinanciera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEntidadFinanciera.BackColor = System.Drawing.Color.White;
            this.cboEntidadFinanciera.DropDownHeight = 200;
            this.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidadFinanciera.DropDownWidth = 400;
            this.cboEntidadFinanciera.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntidadFinanciera.ForeColor = System.Drawing.Color.Black;
            this.cboEntidadFinanciera.FormattingEnabled = true;
            this.cboEntidadFinanciera.IntegralHeight = false;
            this.cboEntidadFinanciera.Location = new System.Drawing.Point(488, 36);
            this.cboEntidadFinanciera.Name = "cboEntidadFinanciera";
            this.cboEntidadFinanciera.Size = new System.Drawing.Size(151, 21);
            this.cboEntidadFinanciera.TabIndex = 3;
            this.cboEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboEntidadFinanciera_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Navy;
            this.label27.Location = new System.Drawing.Point(485, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 13);
            this.label27.TabIndex = 120;
            this.label27.Text = "Entidad Financiera :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(14, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 120;
            this.label25.Text = "Cuenta :";
            // 
            // cboCuenta
            // 
            this.cboCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCuenta.BackColor = System.Drawing.Color.White;
            this.cboCuenta.DropDownHeight = 200;
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.DropDownWidth = 400;
            this.cboCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuenta.ForeColor = System.Drawing.Color.Black;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.IntegralHeight = false;
            this.cboCuenta.Items.AddRange(new object[] {
            "[seleccione]"});
            this.cboCuenta.Location = new System.Drawing.Point(17, 77);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(116, 21);
            this.cboCuenta.TabIndex = 4;
            // 
            // cboModalidadPago
            // 
            this.cboModalidadPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModalidadPago.BackColor = System.Drawing.Color.White;
            this.cboModalidadPago.DropDownHeight = 200;
            this.cboModalidadPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModalidadPago.DropDownWidth = 400;
            this.cboModalidadPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModalidadPago.ForeColor = System.Drawing.Color.Black;
            this.cboModalidadPago.FormattingEnabled = true;
            this.cboModalidadPago.IntegralHeight = false;
            this.cboModalidadPago.Location = new System.Drawing.Point(17, 36);
            this.cboModalidadPago.Name = "cboModalidadPago";
            this.cboModalidadPago.Size = new System.Drawing.Size(164, 21);
            this.cboModalidadPago.TabIndex = 0;
            this.cboModalidadPago.SelectedIndexChanged += new System.EventHandler(this.cboModalidadPago_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(14, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 13);
            this.label23.TabIndex = 120;
            this.label23.Text = "Modalidad de pago :";
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumDocumento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumDocumento.Location = new System.Drawing.Point(470, 77);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(169, 21);
            this.txtNumDocumento.TabIndex = 8;
            this.txtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.White;
            this.txtTipoCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCambio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCambio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipoCambio.Location = new System.Drawing.Point(279, 77);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(83, 21);
            this.txtTipoCambio.TabIndex = 6;
            this.txtTipoCambio.Text = "1.000";
            this.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoCambio.TextChanged += new System.EventHandler(this.txtTipoCambio_TextChanged);
            this.txtTipoCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoCambio_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Navy;
            this.label31.Location = new System.Drawing.Point(467, 61);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(142, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Número de Documento :";
            // 
            // txtTotalCambioDolar
            // 
            this.txtTotalCambioDolar.BackColor = System.Drawing.Color.White;
            this.txtTotalCambioDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCambioDolar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCambioDolar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalCambioDolar.Location = new System.Drawing.Point(387, 77);
            this.txtTotalCambioDolar.Name = "txtTotalCambioDolar";
            this.txtTotalCambioDolar.ReadOnly = true;
            this.txtTotalCambioDolar.Size = new System.Drawing.Size(77, 21);
            this.txtTotalCambioDolar.TabIndex = 7;
            this.txtTotalCambioDolar.Text = "0.00";
            this.txtTotalCambioDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCambioDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalCambioDolar_KeyPress);
            // 
            // txtImportePago
            // 
            this.txtImportePago.BackColor = System.Drawing.Color.White;
            this.txtImportePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImportePago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportePago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImportePago.Location = new System.Drawing.Point(187, 77);
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(77, 21);
            this.txtImportePago.TabIndex = 5;
            this.txtImportePago.Text = "0.00";
            this.txtImportePago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImportePago.TextChanged += new System.EventHandler(this.txtImportePago_TextChanged);
            this.txtImportePago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImportePago_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(276, 61);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Tipo de cambio :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(384, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Importe :";
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMoneda.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoMoneda.Location = new System.Drawing.Point(153, 78);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(28, 16);
            this.lblTipoMoneda.TabIndex = 2;
            this.lblTipoMoneda.Text = "S/.";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Location = new System.Drawing.Point(184, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Importe :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvModalidadesPago);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(997, 181);
            this.groupBox3.TabIndex = 153;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de modalidades de pago";
            // 
            // dgvModalidadesPago
            // 
            this.dgvModalidadesPago.AllowUserToAddRows = false;
            this.dgvModalidadesPago.AllowUserToDeleteRows = false;
            this.dgvModalidadesPago.AllowUserToResizeColumns = false;
            this.dgvModalidadesPago.AllowUserToResizeRows = false;
            this.dgvModalidadesPago.BackgroundColor = System.Drawing.Color.White;
            this.dgvModalidadesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidadesPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_mod_Pago,
            this.desc_mod_Pago,
            this.concep_cod,
            this.FechaDeposito,
            this.cod_entidad_financ,
            this.nombre_entidad,
            this.cuenta_bancaria_id,
            this.numero_cuenta,
            this.importe_voucher_pago,
            this.TipoCambio,
            this.importe_cambio,
            this.NumeroDocumento_Voucher_cheque_pago,
            this.ObservacionPago});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModalidadesPago.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvModalidadesPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModalidadesPago.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvModalidadesPago.Location = new System.Drawing.Point(3, 17);
            this.dgvModalidadesPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvModalidadesPago.Name = "dgvModalidadesPago";
            this.dgvModalidadesPago.ReadOnly = true;
            this.dgvModalidadesPago.RowHeadersVisible = false;
            this.dgvModalidadesPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidadesPago.Size = new System.Drawing.Size(991, 161);
            this.dgvModalidadesPago.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(671, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 139);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Location = new System.Drawing.Point(123, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(97, 22);
            this.txtTotal.TabIndex = 158;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "Total modalidades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtObservacionesPago
            // 
            this.txtObservacionesPago.BackColor = System.Drawing.Color.White;
            this.txtObservacionesPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObservacionesPago.Location = new System.Drawing.Point(117, 104);
            this.txtObservacionesPago.Name = "txtObservacionesPago";
            this.txtObservacionesPago.Size = new System.Drawing.Size(522, 21);
            this.txtObservacionesPago.TabIndex = 122;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Navy;
            this.label32.Location = new System.Drawing.Point(15, 107);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 13);
            this.label32.TabIndex = 121;
            this.label32.Text = "Observaciones :";
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
            // concep_cod
            // 
            this.concep_cod.DataPropertyName = "concep_cod";
            this.concep_cod.Frozen = true;
            this.concep_cod.HeaderText = "concep_cod";
            this.concep_cod.Name = "concep_cod";
            this.concep_cod.ReadOnly = true;
            this.concep_cod.Visible = false;
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
            // NumeroDocumento_Voucher_cheque_pago
            // 
            this.NumeroDocumento_Voucher_cheque_pago.DataPropertyName = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.Frozen = true;
            this.NumeroDocumento_Voucher_cheque_pago.HeaderText = "Nro Voucher";
            this.NumeroDocumento_Voucher_cheque_pago.Name = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.ReadOnly = true;
            // 
            // ObservacionPago
            // 
            this.ObservacionPago.DataPropertyName = "ObservacionPago";
            this.ObservacionPago.HeaderText = "Observacion";
            this.ObservacionPago.Name = "ObservacionPago";
            this.ObservacionPago.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 157;
            this.label2.Text = "Total Documento";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotalDocumento
            // 
            this.txtTotalDocumento.BackColor = System.Drawing.Color.White;
            this.txtTotalDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalDocumento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalDocumento.Location = new System.Drawing.Point(123, 47);
            this.txtTotalDocumento.Name = "txtTotalDocumento";
            this.txtTotalDocumento.Size = new System.Drawing.Size(97, 22);
            this.txtTotalDocumento.TabIndex = 158;
            this.txtTotalDocumento.Text = "0.00";
            this.txtTotalDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Saldo Documento";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSaldoDocumento
            // 
            this.txtSaldoDocumento.BackColor = System.Drawing.Color.White;
            this.txtSaldoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoDocumento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSaldoDocumento.Location = new System.Drawing.Point(123, 74);
            this.txtSaldoDocumento.Name = "txtSaldoDocumento";
            this.txtSaldoDocumento.Size = new System.Drawing.Size(97, 22);
            this.txtSaldoDocumento.TabIndex = 158;
            this.txtSaldoDocumento.Text = "0.00";
            this.txtSaldoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSaldoDocumento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTotalDocumento);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(781, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 139);
            this.groupBox2.TabIndex = 159;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(7, 94);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 32);
            this.btnSalir.TabIndex = 152;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Image = global::GUI_Tesoreria.Properties.Resources.eliminarV;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(7, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 32);
            this.btnDelete.TabIndex = 156;
            this.btnDelete.Text = "&Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregar.Image = global::GUI_Tesoreria.Properties.Resources.agregarpago;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(7, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 32);
            this.btnAgregar.TabIndex = 151;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAgregarModalidadPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 345);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarModalidadPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Agregar Modalidad de Pago:::...";
            this.Load += new System.EventHandler(this.frmAgregarModalidadPago_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadesPago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.GroupBox GBPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        internal System.Windows.Forms.ComboBox cboConcepto;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.ComboBox cboEntidadFinanciera;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.ComboBox cboCuenta;
        internal System.Windows.Forms.ComboBox cboModalidadPago;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.TextBox txtNumDocumento;
        internal System.Windows.Forms.TextBox txtTipoCambio;
        internal System.Windows.Forms.Label label31;
        internal System.Windows.Forms.TextBox txtTotalCambioDolar;
        internal System.Windows.Forms.TextBox txtImportePago;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblTipoMoneda;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvModalidadesPago;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtObservacionesPago;
        internal System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn concep_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_entidad_financ;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta_bancaria_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_voucher_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento_Voucher_cheque_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionPago;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTotalDocumento;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtSaldoDocumento;
        internal System.Windows.Forms.GroupBox groupBox2;
    }
}