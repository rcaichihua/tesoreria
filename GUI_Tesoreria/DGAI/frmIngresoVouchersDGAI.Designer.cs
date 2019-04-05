namespace GUI_Tesoreria.DGAI
{
    partial class frmIngresoVouchersDGAI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.txtImporteEfectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFechaCobro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDeposito = new System.Windows.Forms.DateTimePicker();
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
            this.txtCantidadDocumentos = new System.Windows.Forms.TextBox();
            this.txtObservacionesPago = new System.Windows.Forms.TextBox();
            this.txtTotalCambio = new System.Windows.Forms.TextBox();
            this.txtImportePago = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.idIngresosEfectivoDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_mod_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_voucher_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento_Voucher_cheque_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecibo_ReciboCabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDocumentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteEfectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaDepoFiltroDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dtpFechaDepoFiltroHasta = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GBPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.txtImporteEfectivo);
            this.GBPago.Controls.Add(this.label3);
            this.GBPago.Controls.Add(this.btnEliminar);
            this.GBPago.Controls.Add(this.btnGuardar);
            this.GBPago.Controls.Add(this.dtpFechaCobro);
            this.GBPago.Controls.Add(this.dtpFechaDeposito);
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
            this.GBPago.Controls.Add(this.txtCantidadDocumentos);
            this.GBPago.Controls.Add(this.txtObservacionesPago);
            this.GBPago.Controls.Add(this.txtTotalCambio);
            this.GBPago.Controls.Add(this.txtImportePago);
            this.GBPago.Controls.Add(this.label29);
            this.GBPago.Controls.Add(this.label2);
            this.GBPago.Controls.Add(this.label1);
            this.GBPago.Controls.Add(this.label32);
            this.GBPago.Controls.Add(this.label12);
            this.GBPago.Controls.Add(this.lblTipoMoneda);
            this.GBPago.Controls.Add(this.label30);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(8, 12);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(656, 187);
            this.GBPago.TabIndex = 0;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Registro de VOUCHERS";
            // 
            // txtImporteEfectivo
            // 
            this.txtImporteEfectivo.BackColor = System.Drawing.Color.White;
            this.txtImporteEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImporteEfectivo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteEfectivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImporteEfectivo.Location = new System.Drawing.Point(187, 160);
            this.txtImporteEfectivo.Name = "txtImporteEfectivo";
            this.txtImporteEfectivo.ReadOnly = true;
            this.txtImporteEfectivo.Size = new System.Drawing.Size(119, 21);
            this.txtImporteEfectivo.TabIndex = 12;
            this.txtImporteEfectivo.Text = "0.00";
            this.txtImporteEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(73, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "Importe Efectivo :";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Navy;
            this.btnEliminar.Image = global::GUI_Tesoreria.Properties.Resources.eliminarV;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(559, 138);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 39);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFechaCobro
            // 
            this.dtpFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCobro.Location = new System.Drawing.Point(187, 133);
            this.dtpFechaCobro.Name = "dtpFechaCobro";
            this.dtpFechaCobro.Size = new System.Drawing.Size(119, 21);
            this.dtpFechaCobro.TabIndex = 10;
            // 
            // dtpFechaDeposito
            // 
            this.dtpFechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeposito.Location = new System.Drawing.Point(367, 34);
            this.dtpFechaDeposito.Name = "dtpFechaDeposito";
            this.dtpFechaDeposito.Size = new System.Drawing.Size(115, 21);
            this.dtpFechaDeposito.TabIndex = 2;
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
            this.cboEntidadFinanciera.Size = new System.Drawing.Size(161, 21);
            this.cboEntidadFinanciera.TabIndex = 3;
            this.cboEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.cboEntidadFinanciera_SelectedIndexChanged);
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
            this.cboCuenta.Size = new System.Drawing.Size(130, 21);
            this.cboCuenta.TabIndex = 4;
            this.cboCuenta.SelectedIndexChanged += new System.EventHandler(this.cboCuenta_SelectedIndexChanged);
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
            this.cboModalidadPago.SelectedIndexChanged += new System.EventHandler(this.cboModalidadPago_SelectedIndexChanged);
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
            this.txtNumDocumento.Size = new System.Drawing.Size(179, 21);
            this.txtNumDocumento.TabIndex = 8;
            this.txtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.White;
            this.txtTipoCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCambio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCambio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipoCambio.Location = new System.Drawing.Point(290, 74);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(72, 21);
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
            this.label31.Location = new System.Drawing.Point(467, 58);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(123, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Número de Voucher :";
            // 
            // txtCantidadDocumentos
            // 
            this.txtCantidadDocumentos.BackColor = System.Drawing.Color.White;
            this.txtCantidadDocumentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadDocumentos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDocumentos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCantidadDocumentos.Location = new System.Drawing.Point(387, 135);
            this.txtCantidadDocumentos.Name = "txtCantidadDocumentos";
            this.txtCantidadDocumentos.ReadOnly = true;
            this.txtCantidadDocumentos.Size = new System.Drawing.Size(65, 21);
            this.txtCantidadDocumentos.TabIndex = 11;
            this.txtCantidadDocumentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadDocumentos.TextChanged += new System.EventHandler(this.txtCantidadDocumentos_TextChanged);
            // 
            // txtObservacionesPago
            // 
            this.txtObservacionesPago.BackColor = System.Drawing.Color.White;
            this.txtObservacionesPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacionesPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObservacionesPago.Location = new System.Drawing.Point(187, 106);
            this.txtObservacionesPago.Name = "txtObservacionesPago";
            this.txtObservacionesPago.Size = new System.Drawing.Size(462, 21);
            this.txtObservacionesPago.TabIndex = 9;
            // 
            // txtTotalCambio
            // 
            this.txtTotalCambio.BackColor = System.Drawing.Color.White;
            this.txtTotalCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCambio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCambio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalCambio.Location = new System.Drawing.Point(368, 74);
            this.txtTotalCambio.Name = "txtTotalCambio";
            this.txtTotalCambio.Size = new System.Drawing.Size(96, 21);
            this.txtTotalCambio.TabIndex = 7;
            this.txtTotalCambio.Text = "0.000";
            this.txtTotalCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalCambioDolar_KeyPress);
            // 
            // txtImportePago
            // 
            this.txtImportePago.BackColor = System.Drawing.Color.White;
            this.txtImportePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImportePago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportePago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImportePago.Location = new System.Drawing.Point(188, 74);
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(96, 21);
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
            this.label29.Location = new System.Drawing.Point(287, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "T.C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(312, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cant Docs :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(90, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Caja :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Navy;
            this.label32.Location = new System.Drawing.Point(85, 109);
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
            this.label12.Location = new System.Drawing.Point(365, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total Cambio";
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
            this.label30.Location = new System.Drawing.Point(187, 58);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Importe :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.guardarDoc;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(459, 138);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 39);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(532, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Cancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.AllowUserToDeleteRows = false;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIngresosEfectivoDeposito,
            this.FechaDeposito,
            this.desc_mod_Pago,
            this.nombre_entidad,
            this.numero_cuenta,
            this.moneda,
            this.importe_voucher_pago,
            this.TipoCambio,
            this.importe_cambio,
            this.NumeroDocumento_Voucher_cheque_pago,
            this.FechaRecibo_ReciboCabecera,
            this.CantDocumentos,
            this.ImporteEfectivo,
            this.asignado});
            this.dgvDepositos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepositos.Location = new System.Drawing.Point(3, 17);
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.ReadOnly = true;
            this.dgvDepositos.RowHeadersWidth = 24;
            this.dgvDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDepositos.Size = new System.Drawing.Size(650, 268);
            this.dgvDepositos.TabIndex = 1;
            this.dgvDepositos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDepositos_CellFormatting);
            // 
            // idIngresosEfectivoDeposito
            // 
            this.idIngresosEfectivoDeposito.DataPropertyName = "idIngresosEfectivoDeposito";
            this.idIngresosEfectivoDeposito.HeaderText = "ID";
            this.idIngresosEfectivoDeposito.Name = "idIngresosEfectivoDeposito";
            this.idIngresosEfectivoDeposito.ReadOnly = true;
            this.idIngresosEfectivoDeposito.Visible = false;
            // 
            // FechaDeposito
            // 
            this.FechaDeposito.DataPropertyName = "FechaDeposito";
            this.FechaDeposito.HeaderText = "Fecha Deposito";
            this.FechaDeposito.Name = "FechaDeposito";
            this.FechaDeposito.ReadOnly = true;
            this.FechaDeposito.Width = 80;
            // 
            // desc_mod_Pago
            // 
            this.desc_mod_Pago.DataPropertyName = "desc_mod_Pago";
            this.desc_mod_Pago.HeaderText = "Mod Pago";
            this.desc_mod_Pago.Name = "desc_mod_Pago";
            this.desc_mod_Pago.ReadOnly = true;
            this.desc_mod_Pago.Visible = false;
            // 
            // nombre_entidad
            // 
            this.nombre_entidad.DataPropertyName = "nombre_entidad";
            this.nombre_entidad.HeaderText = "Banco";
            this.nombre_entidad.Name = "nombre_entidad";
            this.nombre_entidad.ReadOnly = true;
            this.nombre_entidad.Width = 90;
            // 
            // numero_cuenta
            // 
            this.numero_cuenta.DataPropertyName = "numero_cuenta";
            this.numero_cuenta.HeaderText = "Nro Cuenta";
            this.numero_cuenta.Name = "numero_cuenta";
            this.numero_cuenta.ReadOnly = true;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "Mon";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 40;
            // 
            // importe_voucher_pago
            // 
            this.importe_voucher_pago.DataPropertyName = "importe_voucher_pago";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle41.Format = "N2";
            this.importe_voucher_pago.DefaultCellStyle = dataGridViewCellStyle41;
            this.importe_voucher_pago.HeaderText = "Imp. Vouch. Dep.";
            this.importe_voucher_pago.Name = "importe_voucher_pago";
            this.importe_voucher_pago.ReadOnly = true;
            this.importe_voucher_pago.Width = 70;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle42.Format = "N2";
            this.TipoCambio.DefaultCellStyle = dataGridViewCellStyle42;
            this.TipoCambio.HeaderText = "T. Cambio";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            this.TipoCambio.Width = 60;
            // 
            // importe_cambio
            // 
            this.importe_cambio.DataPropertyName = "importe_cambio";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle43.Format = "N2";
            this.importe_cambio.DefaultCellStyle = dataGridViewCellStyle43;
            this.importe_cambio.HeaderText = "Total Cambio";
            this.importe_cambio.Name = "importe_cambio";
            this.importe_cambio.ReadOnly = true;
            this.importe_cambio.Width = 70;
            // 
            // NumeroDocumento_Voucher_cheque_pago
            // 
            this.NumeroDocumento_Voucher_cheque_pago.DataPropertyName = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.HeaderText = "Nro Voucher / Cheque";
            this.NumeroDocumento_Voucher_cheque_pago.Name = "NumeroDocumento_Voucher_cheque_pago";
            this.NumeroDocumento_Voucher_cheque_pago.ReadOnly = true;
            // 
            // FechaRecibo_ReciboCabecera
            // 
            this.FechaRecibo_ReciboCabecera.DataPropertyName = "FechaRecibo_ReciboCabecera";
            this.FechaRecibo_ReciboCabecera.HeaderText = "Fecha Documento";
            this.FechaRecibo_ReciboCabecera.Name = "FechaRecibo_ReciboCabecera";
            this.FechaRecibo_ReciboCabecera.ReadOnly = true;
            this.FechaRecibo_ReciboCabecera.Width = 80;
            // 
            // CantDocumentos
            // 
            this.CantDocumentos.DataPropertyName = "CantDocumentos";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CantDocumentos.DefaultCellStyle = dataGridViewCellStyle44;
            this.CantDocumentos.HeaderText = "Cant. Doc.";
            this.CantDocumentos.Name = "CantDocumentos";
            this.CantDocumentos.ReadOnly = true;
            this.CantDocumentos.Width = 40;
            // 
            // ImporteEfectivo
            // 
            this.ImporteEfectivo.DataPropertyName = "ImporteEfectivo";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle45.Format = "N2";
            this.ImporteEfectivo.DefaultCellStyle = dataGridViewCellStyle45;
            this.ImporteEfectivo.HeaderText = "Monto Cobrado";
            this.ImporteEfectivo.Name = "ImporteEfectivo";
            this.ImporteEfectivo.ReadOnly = true;
            this.ImporteEfectivo.Width = 70;
            // 
            // asignado
            // 
            this.asignado.DataPropertyName = "asignado";
            this.asignado.HeaderText = "asignado";
            this.asignado.Name = "asignado";
            this.asignado.ReadOnly = true;
            // 
            // dtpFechaDepoFiltroDesde
            // 
            this.dtpFechaDepoFiltroDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDepoFiltroDesde.Location = new System.Drawing.Point(56, 23);
            this.dtpFechaDepoFiltroDesde.Name = "dtpFechaDepoFiltroDesde";
            this.dtpFechaDepoFiltroDesde.Size = new System.Drawing.Size(108, 21);
            this.dtpFechaDepoFiltroDesde.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Image = global::GUI_Tesoreria.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(338, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.Navy;
            this.btnAsignar.Location = new System.Drawing.Point(420, 16);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(61, 39);
            this.btnAsignar.TabIndex = 13;
            this.btnAsignar.Text = "&Asignar Vouchers por recibo";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dtpFechaDepoFiltroHasta
            // 
            this.dtpFechaDepoFiltroHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDepoFiltroHasta.Location = new System.Drawing.Point(216, 23);
            this.dtpFechaDepoFiltroHasta.Name = "dtpFechaDepoFiltroHasta";
            this.dtpFechaDepoFiltroHasta.Size = new System.Drawing.Size(115, 21);
            this.dtpFechaDepoFiltroHasta.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(170, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 122;
            this.label14.Text = "Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvDepositos);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(8, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 288);
            this.groupBox3.TabIndex = 147;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de modalidades de pago";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFechaDepoFiltroHasta);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnAsignar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dtpFechaDepoFiltroDesde);
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(25, 499);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(639, 60);
            this.groupBox4.TabIndex = 149;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtro de vouchers por fecha de Documentos origen";
            // 
            // frmIngresoVouchersDGAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIngresoVouchersDGAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Ingresos vouchers - Ingreso Efectivo::...";
            this.Load += new System.EventHandler(this.frmIngresoVouchers_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBPago;
        private System.Windows.Forms.DateTimePicker dtpFechaDeposito;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.ComboBox cboEntidadFinanciera;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.ComboBox cboCuenta;
        internal System.Windows.Forms.ComboBox cboModalidadPago;
        internal System.Windows.Forms.TextBox txtNumDocumento;
        internal System.Windows.Forms.TextBox txtTipoCambio;
        internal System.Windows.Forms.Label label31;
        internal System.Windows.Forms.TextBox txtObservacionesPago;
        internal System.Windows.Forms.TextBox txtTotalCambio;
        internal System.Windows.Forms.TextBox txtImportePago;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label32;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblTipoMoneda;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpFechaCobro;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtImporteEfectivo;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCantidadDocumentos;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.DateTimePicker dtpFechaDepoFiltroDesde;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.ComboBox cboConcepto;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIngresosEfectivoDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_mod_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_voucher_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento_Voucher_cheque_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecibo_ReciboCabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignado;
        private System.Windows.Forms.DateTimePicker dtpFechaDepoFiltroHasta;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}