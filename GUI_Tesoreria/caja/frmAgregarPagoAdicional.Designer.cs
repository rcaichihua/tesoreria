namespace GUI_Tesoreria.caja
{
    partial class frmAgregarPagoAdicional
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtObservacionesPago = new System.Windows.Forms.TextBox();
            this.txtTotalCambioDolar = new System.Windows.Forms.TextBox();
            this.txtImportePago = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvIngresosInmobiliaria = new System.Windows.Forms.DataGridView();
            this.dgvModalidadIngreso = new System.Windows.Forms.DataGridView();
            this.Depositos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codModpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModalidadPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoMas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_depo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBPago.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosInmobiliaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
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
            this.GBPago.Controls.Add(this.txtObservacionesPago);
            this.GBPago.Controls.Add(this.txtTotalCambioDolar);
            this.GBPago.Controls.Add(this.txtImportePago);
            this.GBPago.Controls.Add(this.label29);
            this.GBPago.Controls.Add(this.label32);
            this.GBPago.Controls.Add(this.label12);
            this.GBPago.Controls.Add(this.lblTipoMoneda);
            this.GBPago.Controls.Add(this.label30);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 224);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(656, 135);
            this.GBPago.TabIndex = 150;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Acerca del pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(388, 34);
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
            this.cboConcepto.Location = new System.Drawing.Point(201, 33);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(160, 21);
            this.cboConcepto.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Navy;
            this.label26.Location = new System.Drawing.Point(386, 16);
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
            this.label24.Location = new System.Drawing.Point(198, 16);
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
            this.cboEntidadFinanciera.Location = new System.Drawing.Point(488, 33);
            this.cboEntidadFinanciera.Name = "cboEntidadFinanciera";
            this.cboEntidadFinanciera.Size = new System.Drawing.Size(151, 21);
            this.cboEntidadFinanciera.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Navy;
            this.label27.Location = new System.Drawing.Point(485, 16);
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
            this.label25.Location = new System.Drawing.Point(14, 58);
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
            this.cboCuenta.Location = new System.Drawing.Point(17, 74);
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
            this.cboModalidadPago.Location = new System.Drawing.Point(17, 33);
            this.cboModalidadPago.Name = "cboModalidadPago";
            this.cboModalidadPago.Size = new System.Drawing.Size(164, 21);
            this.cboModalidadPago.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(14, 17);
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
            this.txtNumDocumento.Location = new System.Drawing.Point(470, 74);
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
            this.txtTipoCambio.Location = new System.Drawing.Point(279, 74);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(83, 21);
            this.txtTipoCambio.TabIndex = 6;
            this.txtTipoCambio.Text = "1.000";
            this.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Navy;
            this.label31.Location = new System.Drawing.Point(467, 58);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(142, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Número de Documento :";
            // 
            // txtObservacionesPago
            // 
            this.txtObservacionesPago.BackColor = System.Drawing.Color.White;
            this.txtObservacionesPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObservacionesPago.Location = new System.Drawing.Point(116, 106);
            this.txtObservacionesPago.Name = "txtObservacionesPago";
            this.txtObservacionesPago.Size = new System.Drawing.Size(522, 21);
            this.txtObservacionesPago.TabIndex = 9;
            // 
            // txtTotalCambioDolar
            // 
            this.txtTotalCambioDolar.BackColor = System.Drawing.Color.White;
            this.txtTotalCambioDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCambioDolar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCambioDolar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalCambioDolar.Location = new System.Drawing.Point(387, 74);
            this.txtTotalCambioDolar.Name = "txtTotalCambioDolar";
            this.txtTotalCambioDolar.ReadOnly = true;
            this.txtTotalCambioDolar.Size = new System.Drawing.Size(77, 21);
            this.txtTotalCambioDolar.TabIndex = 7;
            this.txtTotalCambioDolar.Text = "0.00";
            this.txtTotalCambioDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImportePago
            // 
            this.txtImportePago.BackColor = System.Drawing.Color.White;
            this.txtImportePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImportePago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportePago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImportePago.Location = new System.Drawing.Point(187, 74);
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(77, 21);
            this.txtImportePago.TabIndex = 5;
            this.txtImportePago.Text = "0.00";
            this.txtImportePago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(276, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Tipo de cambio :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Navy;
            this.label32.Location = new System.Drawing.Point(14, 109);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Observaciones :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(384, 58);
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
            this.lblTipoMoneda.Location = new System.Drawing.Point(153, 75);
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
            this.label30.Location = new System.Drawing.Point(184, 58);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Importe :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvIngresosInmobiliaria);
            this.groupBox4.Controls.Add(this.dgvModalidadIngreso);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 205);
            this.groupBox4.TabIndex = 153;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listado de modalidades de pago";
            // 
            // dgvIngresosInmobiliaria
            // 
            this.dgvIngresosInmobiliaria.AllowUserToAddRows = false;
            this.dgvIngresosInmobiliaria.AllowUserToDeleteRows = false;
            this.dgvIngresosInmobiliaria.AllowUserToResizeColumns = false;
            this.dgvIngresosInmobiliaria.AllowUserToResizeRows = false;
            this.dgvIngresosInmobiliaria.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngresosInmobiliaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosInmobiliaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidad,
            this.concepto,
            this.Fecha,
            this.Banco,
            this.cuenta,
            this.importe,
            this.tc,
            this.ImporteCambio,
            this.NroDocumento});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresosInmobiliaria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngresosInmobiliaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresosInmobiliaria.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvIngresosInmobiliaria.Location = new System.Drawing.Point(3, 17);
            this.dgvIngresosInmobiliaria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvIngresosInmobiliaria.Name = "dgvIngresosInmobiliaria";
            this.dgvIngresosInmobiliaria.ReadOnly = true;
            this.dgvIngresosInmobiliaria.RowHeadersVisible = false;
            this.dgvIngresosInmobiliaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresosInmobiliaria.Size = new System.Drawing.Size(650, 185);
            this.dgvIngresosInmobiliaria.TabIndex = 151;
            // 
            // dgvModalidadIngreso
            // 
            this.dgvModalidadIngreso.AllowUserToAddRows = false;
            this.dgvModalidadIngreso.AllowUserToDeleteRows = false;
            this.dgvModalidadIngreso.AllowUserToResizeColumns = false;
            this.dgvModalidadIngreso.AllowUserToResizeRows = false;
            this.dgvModalidadIngreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvModalidadIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidadIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depositos,
            this.orden,
            this.codModpago,
            this.ModalidadPago,
            this.descripTipo,
            this.montos,
            this.depoMas,
            this.total_depo,
            this.deposito,
            this.tabla});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModalidadIngreso.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvModalidadIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModalidadIngreso.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvModalidadIngreso.Location = new System.Drawing.Point(3, 17);
            this.dgvModalidadIngreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvModalidadIngreso.Name = "dgvModalidadIngreso";
            this.dgvModalidadIngreso.ReadOnly = true;
            this.dgvModalidadIngreso.RowHeadersVisible = false;
            this.dgvModalidadIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidadIngreso.Size = new System.Drawing.Size(650, 185);
            this.dgvModalidadIngreso.TabIndex = 0;
            // 
            // Depositos
            // 
            this.Depositos.Frozen = true;
            this.Depositos.HeaderText = "Ver Depósitos";
            this.Depositos.Name = "Depositos";
            this.Depositos.ReadOnly = true;
            this.Depositos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Depositos.Width = 80;
            // 
            // orden
            // 
            this.orden.DataPropertyName = "orden";
            this.orden.Frozen = true;
            this.orden.HeaderText = "orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.orden.Visible = false;
            // 
            // codModpago
            // 
            this.codModpago.DataPropertyName = "cod_mod_pago";
            this.codModpago.Frozen = true;
            this.codModpago.HeaderText = "CodModPago";
            this.codModpago.Name = "codModpago";
            this.codModpago.ReadOnly = true;
            this.codModpago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codModpago.Visible = false;
            // 
            // ModalidadPago
            // 
            this.ModalidadPago.DataPropertyName = "desc_mod_pago";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ModalidadPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModalidadPago.Frozen = true;
            this.ModalidadPago.HeaderText = "Modalidad de Pago";
            this.ModalidadPago.Name = "ModalidadPago";
            this.ModalidadPago.ReadOnly = true;
            this.ModalidadPago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModalidadPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ModalidadPago.Width = 150;
            // 
            // descripTipo
            // 
            this.descripTipo.DataPropertyName = "descripTipo";
            this.descripTipo.Frozen = true;
            this.descripTipo.HeaderText = "descripTipo";
            this.descripTipo.Name = "descripTipo";
            this.descripTipo.ReadOnly = true;
            this.descripTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripTipo.Visible = false;
            // 
            // montos
            // 
            this.montos.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "n2";
            this.montos.DefaultCellStyle = dataGridViewCellStyle3;
            this.montos.Frozen = true;
            this.montos.HeaderText = "Monto";
            this.montos.Name = "montos";
            this.montos.ReadOnly = true;
            this.montos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.montos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.montos.Width = 90;
            // 
            // depoMas
            // 
            this.depoMas.DataPropertyName = "depoMas";
            this.depoMas.Frozen = true;
            this.depoMas.HeaderText = "depoMas";
            this.depoMas.Name = "depoMas";
            this.depoMas.ReadOnly = true;
            this.depoMas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.depoMas.Visible = false;
            // 
            // total_depo
            // 
            this.total_depo.DataPropertyName = "total_depo";
            this.total_depo.Frozen = true;
            this.total_depo.HeaderText = "total_depo";
            this.total_depo.Name = "total_depo";
            this.total_depo.ReadOnly = true;
            this.total_depo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total_depo.Visible = false;
            // 
            // deposito
            // 
            this.deposito.DataPropertyName = "depo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.deposito.DefaultCellStyle = dataGridViewCellStyle4;
            this.deposito.Frozen = true;
            this.deposito.HeaderText = "Estado";
            this.deposito.Name = "deposito";
            this.deposito.ReadOnly = true;
            this.deposito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deposito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deposito.Width = 50;
            // 
            // tabla
            // 
            this.tabla.DataPropertyName = "tabla";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabla.Frozen = true;
            this.tabla.HeaderText = "Doc";
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tabla.Width = 45;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(344, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 52);
            this.btnSalir.TabIndex = 152;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.agregarModalidad;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(252, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 52);
            this.btnGuardar.TabIndex = 151;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // modalidad
            // 
            this.modalidad.HeaderText = "Modalidad";
            this.modalidad.Name = "modalidad";
            this.modalidad.ReadOnly = true;
            // 
            // concepto
            // 
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "cuenta";
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // tc
            // 
            this.tc.HeaderText = "T.C.";
            this.tc.Name = "tc";
            this.tc.ReadOnly = true;
            // 
            // ImporteCambio
            // 
            this.ImporteCambio.HeaderText = "Importe Cambio";
            this.ImporteCambio.Name = "ImporteCambio";
            this.ImporteCambio.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            // 
            // frmAgregarPagoAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 421);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.Name = "frmAgregarPagoAdicional";
            this.Text = "frmAgregarPagoAdicional";
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosInmobiliaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidadIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnGuardar;
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
        internal System.Windows.Forms.TextBox txtObservacionesPago;
        internal System.Windows.Forms.TextBox txtTotalCambioDolar;
        internal System.Windows.Forms.TextBox txtImportePago;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label32;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblTipoMoneda;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.DataGridView dgvIngresosInmobiliaria;
        internal System.Windows.Forms.DataGridView dgvModalidadIngreso;
        private System.Windows.Forms.DataGridViewButtonColumn Depositos;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn codModpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModalidadPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn montos;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoMas;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_depo;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
    }
}