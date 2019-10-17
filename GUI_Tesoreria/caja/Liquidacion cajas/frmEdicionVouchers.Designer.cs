namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmEdicionVouchers
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarDoc = new System.Windows.Forms.Button();
            this.GBPago.SuspendLayout();
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
            this.GBPago.Location = new System.Drawing.Point(12, 21);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(656, 135);
            this.GBPago.TabIndex = 2;
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
            this.cboConcepto.SelectedIndexChanged += new System.EventHandler(this.cboConcepto_SelectedIndexChanged);
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
            this.txtImportePago.TextChanged += new System.EventHandler(this.txtImportePago_TextChanged);
            this.txtImportePago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImportePago_KeyPress);
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(344, 162);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 149;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(252, 162);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 71);
            this.btnGuardar.TabIndex = 149;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BackColor = System.Drawing.Color.White;
            this.txtImpuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImpuesto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImpuesto.Location = new System.Drawing.Point(12, 212);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(83, 21);
            this.txtImpuesto.TabIndex = 153;
            this.txtImpuesto.Text = "0.00";
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuesto.Visible = false;
            // 
            // txtNeto
            // 
            this.txtNeto.BackColor = System.Drawing.Color.White;
            this.txtNeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNeto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNeto.Location = new System.Drawing.Point(12, 174);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(83, 21);
            this.txtNeto.TabIndex = 152;
            this.txtNeto.Text = "0.00";
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNeto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 150;
            this.label1.Text = "IMPUESTO";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "NETO";
            this.label2.Visible = false;
            // 
            // BtnBuscarDoc
            // 
            this.BtnBuscarDoc.BackColor = System.Drawing.Color.White;
            this.BtnBuscarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarDoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarDoc.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscarDoc.Image = global::GUI_Tesoreria.Properties.Resources.buscar;
            this.BtnBuscarDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarDoc.Location = new System.Drawing.Point(128, 163);
            this.BtnBuscarDoc.Name = "BtnBuscarDoc";
            this.BtnBuscarDoc.Size = new System.Drawing.Size(121, 46);
            this.BtnBuscarDoc.TabIndex = 155;
            this.BtnBuscarDoc.Text = "&Buscar documento";
            this.BtnBuscarDoc.UseVisualStyleBackColor = false;
            this.BtnBuscarDoc.Visible = false;
            this.BtnBuscarDoc.Click += new System.EventHandler(this.BtnBuscarDoc_Click);
            // 
            // frmEdicionVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 239);
            this.Controls.Add(this.BtnBuscarDoc);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdicionVouchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Voucher:::...";
            this.Load += new System.EventHandler(this.frmEdicionVouchers_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.TextBox txtImpuesto;
        internal System.Windows.Forms.TextBox txtNeto;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button BtnBuscarDoc;
    }
}