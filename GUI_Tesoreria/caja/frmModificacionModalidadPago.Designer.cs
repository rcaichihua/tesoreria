namespace GUI_Tesoreria.caja
{
    partial class frmModificacionModalidadPago
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
            this.components = new System.ComponentModel.Container();
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.btnAgregarPago = new System.Windows.Forms.Button();
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
            this.BtnCancelarC = new System.Windows.Forms.Button();
            this.BtnGrabarC = new System.Windows.Forms.Button();
            this.IGBTotales = new System.Windows.Forms.GroupBox();
            this.txtPrecioVentaC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIGVC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorVentaC = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.lblCorrelativoFactura = new System.Windows.Forms.Label();
            this.lblSerieFactura = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCancalacion = new System.Windows.Forms.Label();
            this.dtpFechaCancelacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.GBPago.SuspendLayout();
            this.IGBTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.btnAgregarPago);
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
            this.GBPago.Location = new System.Drawing.Point(12, 50);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(656, 135);
            this.GBPago.TabIndex = 81;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Acerca del cobro - ";
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPago.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPago.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarPago.Image = global::GUI_Tesoreria.Properties.Resources.agregarpago;
            this.btnAgregarPago.Location = new System.Drawing.Point(606, 62);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(44, 33);
            this.btnAgregarPago.TabIndex = 121;
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
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
            this.label26.Text = "Fecha Depósito :";
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
            this.cboEntidadFinanciera.Size = new System.Drawing.Size(162, 21);
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
            this.cboCuenta.Size = new System.Drawing.Size(116, 21);
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
            this.txtNumDocumento.Location = new System.Drawing.Point(454, 74);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(147, 21);
            this.txtNumDocumento.TabIndex = 8;
            this.txtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.White;
            this.txtTipoCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCambio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCambio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipoCambio.Location = new System.Drawing.Point(263, 74);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(83, 21);
            this.txtTipoCambio.TabIndex = 6;
            this.txtTipoCambio.Text = "1.000";
            this.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoCambio.TextChanged += new System.EventHandler(this.txtTipoCambio_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Navy;
            this.label31.Location = new System.Drawing.Point(451, 58);
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
            this.txtTotalCambioDolar.Location = new System.Drawing.Point(371, 74);
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
            this.txtImportePago.Location = new System.Drawing.Point(171, 74);
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(77, 21);
            this.txtImportePago.TabIndex = 5;
            this.txtImportePago.Text = "0.00";
            this.txtImportePago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImportePago.TextChanged += new System.EventHandler(this.txtImportePago_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(260, 58);
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
            this.label12.Location = new System.Drawing.Point(368, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total Camb.";
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMoneda.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoMoneda.Location = new System.Drawing.Point(137, 75);
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
            this.label30.Location = new System.Drawing.Point(168, 58);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Importe :";
            // 
            // BtnCancelarC
            // 
            this.BtnCancelarC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarC.ForeColor = System.Drawing.Color.Navy;
            this.BtnCancelarC.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.BtnCancelarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelarC.Location = new System.Drawing.Point(95, 191);
            this.BtnCancelarC.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnCancelarC.Name = "BtnCancelarC";
            this.BtnCancelarC.Size = new System.Drawing.Size(74, 58);
            this.BtnCancelarC.TabIndex = 82;
            this.BtnCancelarC.Text = "&Cancelar";
            this.BtnCancelarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelarC.UseVisualStyleBackColor = false;
            this.BtnCancelarC.Click += new System.EventHandler(this.BtnCancelarC_Click);
            // 
            // BtnGrabarC
            // 
            this.BtnGrabarC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGrabarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrabarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabarC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabarC.ForeColor = System.Drawing.Color.Navy;
            this.BtnGrabarC.Image = global::GUI_Tesoreria.Properties.Resources.guardarDoc;
            this.BtnGrabarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGrabarC.Location = new System.Drawing.Point(12, 191);
            this.BtnGrabarC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabarC.Name = "BtnGrabarC";
            this.BtnGrabarC.Size = new System.Drawing.Size(74, 58);
            this.BtnGrabarC.TabIndex = 80;
            this.BtnGrabarC.Text = "&Grabar";
            this.BtnGrabarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGrabarC.UseVisualStyleBackColor = false;
            this.BtnGrabarC.Click += new System.EventHandler(this.BtnGrabarC_Click);
            // 
            // IGBTotales
            // 
            this.IGBTotales.BackColor = System.Drawing.Color.Transparent;
            this.IGBTotales.Controls.Add(this.txtPrecioVentaC);
            this.IGBTotales.Controls.Add(this.label4);
            this.IGBTotales.Controls.Add(this.txtIGVC);
            this.IGBTotales.Controls.Add(this.label3);
            this.IGBTotales.Controls.Add(this.txtValorVentaC);
            this.IGBTotales.Controls.Add(this.LblTotal);
            this.IGBTotales.Location = new System.Drawing.Point(411, 183);
            this.IGBTotales.Name = "IGBTotales";
            this.IGBTotales.Size = new System.Drawing.Size(257, 89);
            this.IGBTotales.TabIndex = 83;
            this.IGBTotales.TabStop = false;
            // 
            // txtPrecioVentaC
            // 
            this.txtPrecioVentaC.BackColor = System.Drawing.Color.White;
            this.txtPrecioVentaC.Enabled = false;
            this.txtPrecioVentaC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaC.ForeColor = System.Drawing.Color.Maroon;
            this.txtPrecioVentaC.Location = new System.Drawing.Point(153, 57);
            this.txtPrecioVentaC.Name = "txtPrecioVentaC";
            this.txtPrecioVentaC.ReadOnly = true;
            this.txtPrecioVentaC.Size = new System.Drawing.Size(104, 22);
            this.txtPrecioVentaC.TabIndex = 4;
            this.txtPrecioVentaC.Text = "0.00";
            this.txtPrecioVentaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(46, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Venta :";
            // 
            // txtIGVC
            // 
            this.txtIGVC.BackColor = System.Drawing.Color.White;
            this.txtIGVC.Enabled = false;
            this.txtIGVC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGVC.ForeColor = System.Drawing.Color.Maroon;
            this.txtIGVC.Location = new System.Drawing.Point(153, 34);
            this.txtIGVC.Name = "txtIGVC";
            this.txtIGVC.ReadOnly = true;
            this.txtIGVC.Size = new System.Drawing.Size(104, 22);
            this.txtIGVC.TabIndex = 4;
            this.txtIGVC.Text = "0.00";
            this.txtIGVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(117, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IGV:";
            // 
            // txtValorVentaC
            // 
            this.txtValorVentaC.BackColor = System.Drawing.Color.White;
            this.txtValorVentaC.Enabled = false;
            this.txtValorVentaC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVentaC.ForeColor = System.Drawing.Color.Maroon;
            this.txtValorVentaC.Location = new System.Drawing.Point(153, 11);
            this.txtValorVentaC.Name = "txtValorVentaC";
            this.txtValorVentaC.ReadOnly = true;
            this.txtValorVentaC.Size = new System.Drawing.Size(104, 22);
            this.txtValorVentaC.TabIndex = 4;
            this.txtValorVentaC.Text = "0.00";
            this.txtValorVentaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Navy;
            this.LblTotal.Location = new System.Drawing.Point(69, 15);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 13);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "Valor Venta :";
            // 
            // lblCorrelativoFactura
            // 
            this.lblCorrelativoFactura.BackColor = System.Drawing.Color.Navy;
            this.lblCorrelativoFactura.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativoFactura.ForeColor = System.Drawing.Color.White;
            this.lblCorrelativoFactura.Location = new System.Drawing.Point(251, 16);
            this.lblCorrelativoFactura.Name = "lblCorrelativoFactura";
            this.lblCorrelativoFactura.Size = new System.Drawing.Size(143, 31);
            this.lblCorrelativoFactura.TabIndex = 86;
            this.lblCorrelativoFactura.Text = "00000000";
            this.lblCorrelativoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerieFactura
            // 
            this.lblSerieFactura.BackColor = System.Drawing.Color.Navy;
            this.lblSerieFactura.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerieFactura.ForeColor = System.Drawing.Color.White;
            this.lblSerieFactura.Location = new System.Drawing.Point(168, 16);
            this.lblSerieFactura.Name = "lblSerieFactura";
            this.lblSerieFactura.Size = new System.Drawing.Size(77, 31);
            this.lblSerieFactura.TabIndex = 85;
            this.lblSerieFactura.Text = "F00";
            this.lblSerieFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(25, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 23);
            this.label20.TabIndex = 84;
            this.label20.Text = "DOCUMENTO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCancalacion
            // 
            this.lblCancalacion.AutoSize = true;
            this.lblCancalacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancalacion.ForeColor = System.Drawing.Color.Navy;
            this.lblCancalacion.Location = new System.Drawing.Point(498, 9);
            this.lblCancalacion.Name = "lblCancalacion";
            this.lblCancalacion.Size = new System.Drawing.Size(110, 13);
            this.lblCancalacion.TabIndex = 120;
            this.lblCancalacion.Text = "Fecha Cancelación";
            // 
            // dtpFechaCancelacion
            // 
            this.dtpFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCancelacion.Location = new System.Drawing.Point(500, 27);
            this.dtpFechaCancelacion.Name = "dtpFechaCancelacion";
            this.dtpFechaCancelacion.Size = new System.Drawing.Size(94, 20);
            this.dtpFechaCancelacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Fecha Emisión";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(400, 27);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(94, 20);
            this.dtpFechaEmision.TabIndex = 2;
            // 
            // frmModificacionModalidadPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 282);
            this.Controls.Add(this.lblCorrelativoFactura);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.dtpFechaCancelacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSerieFactura);
            this.Controls.Add(this.lblCancalacion);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.GBPago);
            this.Controls.Add(this.BtnCancelarC);
            this.Controls.Add(this.BtnGrabarC);
            this.Controls.Add(this.IGBTotales);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModificacionModalidadPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Modificacion Modalidad de Pagos:::...";
            this.Load += new System.EventHandler(this.frmModificacionModalidadPago_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.IGBTotales.ResumeLayout(false);
            this.IGBTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBPago;
        internal System.Windows.Forms.Button btnAgregarPago;
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
        internal System.Windows.Forms.Button BtnCancelarC;
        internal System.Windows.Forms.Button BtnGrabarC;
        internal System.Windows.Forms.GroupBox IGBTotales;
        internal System.Windows.Forms.TextBox txtPrecioVentaC;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtIGVC;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtValorVentaC;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.Label lblCorrelativoFactura;
        internal System.Windows.Forms.Label lblSerieFactura;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpFechaCancelacion;
        internal System.Windows.Forms.Label lblCancalacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        internal System.Windows.Forms.Label label1;
    }
}