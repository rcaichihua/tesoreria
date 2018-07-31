namespace GUI_Tesoreria.DGAI
{
    partial class frmIngresoRubrosPorLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoRubrosPorLiquidacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBAgregarQuitar = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFechaC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNumeroRecibo = new System.Windows.Forms.TextBox();
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtTotalCambioDolar = new System.Windows.Forms.TextBox();
            this.txtImportePago = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cboModalidadPago = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombreC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuarioC = new System.Windows.Forms.TextBox();
            this.txtGlosa = new System.Windows.Forms.TextBox();
            this.BtnNuevoC = new System.Windows.Forms.Button();
            this.BtnCancelarC = new System.Windows.Forms.Button();
            this.BtnGrabarC = new System.Windows.Forms.Button();
            this.dgvDGAI = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.BtnSalirC = new System.Windows.Forms.Button();
            this.IGBTotales = new System.Windows.Forms.GroupBox();
            this.txtTotalLiquidacionC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldoC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalDocumentoC = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GBAgregarQuitar.SuspendLayout();
            this.GBPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGAI)).BeginInit();
            this.GBDatosRubros.SuspendLayout();
            this.IGBTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAgregarQuitar
            // 
            this.GBAgregarQuitar.BackColor = System.Drawing.Color.Transparent;
            this.GBAgregarQuitar.Controls.Add(this.btnDelete);
            this.GBAgregarQuitar.Controls.Add(this.btnAdd);
            this.GBAgregarQuitar.Location = new System.Drawing.Point(546, 176);
            this.GBAgregarQuitar.Name = "GBAgregarQuitar";
            this.GBAgregarQuitar.Size = new System.Drawing.Size(122, 61);
            this.GBAgregarQuitar.TabIndex = 121;
            this.GBAgregarQuitar.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(76, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(26, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFechaC
            // 
            this.txtFechaC.BackColor = System.Drawing.Color.White;
            this.txtFechaC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFechaC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaC.ForeColor = System.Drawing.Color.Maroon;
            this.txtFechaC.Location = new System.Drawing.Point(155, 7);
            this.txtFechaC.MaxLength = 11;
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.ReadOnly = true;
            this.txtFechaC.Size = new System.Drawing.Size(84, 21);
            this.txtFechaC.TabIndex = 129;
            this.txtFechaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(249, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Numero :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(106, 11);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 128;
            this.Label2.Text = "Fecha :";
            // 
            // txtNumeroRecibo
            // 
            this.txtNumeroRecibo.BackColor = System.Drawing.Color.White;
            this.txtNumeroRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroRecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRecibo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumeroRecibo.Location = new System.Drawing.Point(312, 7);
            this.txtNumeroRecibo.Name = "txtNumeroRecibo";
            this.txtNumeroRecibo.ReadOnly = true;
            this.txtNumeroRecibo.Size = new System.Drawing.Size(95, 21);
            this.txtNumeroRecibo.TabIndex = 123;
            this.txtNumeroRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.txtTipoCambio);
            this.GBPago.Controls.Add(this.txtTotalCambioDolar);
            this.GBPago.Controls.Add(this.txtImportePago);
            this.GBPago.Controls.Add(this.label29);
            this.GBPago.Controls.Add(this.label12);
            this.GBPago.Controls.Add(this.lblTipoMoneda);
            this.GBPago.Controls.Add(this.label30);
            this.GBPago.Controls.Add(this.cboModalidadPago);
            this.GBPago.Controls.Add(this.label23);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 97);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(656, 73);
            this.GBPago.TabIndex = 124;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Acerca del pago";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.White;
            this.txtTipoCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCambio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCambio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipoCambio.Location = new System.Drawing.Point(407, 33);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(83, 21);
            this.txtTipoCambio.TabIndex = 126;
            this.txtTipoCambio.Text = "1.000";
            this.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoCambio_KeyPress);
            // 
            // txtTotalCambioDolar
            // 
            this.txtTotalCambioDolar.BackColor = System.Drawing.Color.White;
            this.txtTotalCambioDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCambioDolar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCambioDolar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalCambioDolar.Location = new System.Drawing.Point(515, 33);
            this.txtTotalCambioDolar.Name = "txtTotalCambioDolar";
            this.txtTotalCambioDolar.ReadOnly = true;
            this.txtTotalCambioDolar.Size = new System.Drawing.Size(77, 21);
            this.txtTotalCambioDolar.TabIndex = 127;
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
            this.txtImportePago.Location = new System.Drawing.Point(315, 33);
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(77, 21);
            this.txtImportePago.TabIndex = 125;
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
            this.label29.Location = new System.Drawing.Point(404, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 13);
            this.label29.TabIndex = 124;
            this.label29.Text = "Tipo de cambio :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(512, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "TotalCambio";
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMoneda.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoMoneda.Location = new System.Drawing.Point(281, 34);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(28, 16);
            this.lblTipoMoneda.TabIndex = 123;
            this.lblTipoMoneda.Text = "S/.";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Location = new System.Drawing.Point(312, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 13);
            this.label30.TabIndex = 121;
            this.label30.Text = "Importe :";
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
            this.cboModalidadPago.Size = new System.Drawing.Size(214, 21);
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
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Navy;
            this.LblNombre.Location = new System.Drawing.Point(9, 37);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(140, 13);
            this.LblNombre.TabIndex = 125;
            this.LblNombre.Text = "Nombre / Razon Social :";
            // 
            // TxtNombreC
            // 
            this.TxtNombreC.BackColor = System.Drawing.Color.White;
            this.TxtNombreC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNombreC.Location = new System.Drawing.Point(155, 34);
            this.TxtNombreC.Name = "TxtNombreC";
            this.TxtNombreC.ReadOnly = true;
            this.TxtNombreC.Size = new System.Drawing.Size(252, 21);
            this.TxtNombreC.TabIndex = 126;
            this.TxtNombreC.Text = "D.G.A.I";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNro);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUsuarioC);
            this.groupBox1.Controls.Add(this.TxtNombreC);
            this.groupBox1.Controls.Add(this.txtFechaC);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumeroRecibo);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 79);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.ForeColor = System.Drawing.Color.Navy;
            this.lblNro.Location = new System.Drawing.Point(560, 43);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(87, 24);
            this.lblNro.TabIndex = 135;
            this.lblNro.Text = "0000000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(522, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 24);
            this.label15.TabIndex = 134;
            this.label15.Text = "N°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(468, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 133;
            this.label10.Text = "Usuario :";
            // 
            // txtUsuarioC
            // 
            this.txtUsuarioC.BackColor = System.Drawing.Color.White;
            this.txtUsuarioC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuarioC.Location = new System.Drawing.Point(530, 11);
            this.txtUsuarioC.Name = "txtUsuarioC";
            this.txtUsuarioC.ReadOnly = true;
            this.txtUsuarioC.Size = new System.Drawing.Size(117, 21);
            this.txtUsuarioC.TabIndex = 131;
            this.txtUsuarioC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGlosa
            // 
            this.txtGlosa.BackColor = System.Drawing.Color.White;
            this.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGlosa.Location = new System.Drawing.Point(106, 181);
            this.txtGlosa.Multiline = true;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGlosa.Size = new System.Drawing.Size(433, 51);
            this.txtGlosa.TabIndex = 0;
            // 
            // BtnNuevoC
            // 
            this.BtnNuevoC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevoC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoC.ForeColor = System.Drawing.Color.Navy;
            this.BtnNuevoC.Location = new System.Drawing.Point(14, 378);
            this.BtnNuevoC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNuevoC.Name = "BtnNuevoC";
            this.BtnNuevoC.Size = new System.Drawing.Size(74, 39);
            this.BtnNuevoC.TabIndex = 135;
            this.BtnNuevoC.Text = "&Nuevo";
            this.BtnNuevoC.UseVisualStyleBackColor = false;
            this.BtnNuevoC.Click += new System.EventHandler(this.BtnNuevoC_Click);
            // 
            // BtnCancelarC
            // 
            this.BtnCancelarC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarC.ForeColor = System.Drawing.Color.Navy;
            this.BtnCancelarC.Location = new System.Drawing.Point(97, 378);
            this.BtnCancelarC.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnCancelarC.Name = "BtnCancelarC";
            this.BtnCancelarC.Size = new System.Drawing.Size(74, 39);
            this.BtnCancelarC.TabIndex = 134;
            this.BtnCancelarC.Text = "&Cancelar";
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
            this.BtnGrabarC.Location = new System.Drawing.Point(180, 378);
            this.BtnGrabarC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabarC.Name = "BtnGrabarC";
            this.BtnGrabarC.Size = new System.Drawing.Size(74, 39);
            this.BtnGrabarC.TabIndex = 133;
            this.BtnGrabarC.Text = "&Grabar";
            this.BtnGrabarC.UseVisualStyleBackColor = false;
            this.BtnGrabarC.Click += new System.EventHandler(this.BtnGrabarC_Click);
            // 
            // dgvDGAI
            // 
            this.dgvDGAI.AllowUserToAddRows = false;
            this.dgvDGAI.AllowUserToDeleteRows = false;
            this.dgvDGAI.AllowUserToResizeColumns = false;
            this.dgvDGAI.AllowUserToResizeRows = false;
            this.dgvDGAI.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDGAI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDGAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDGAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDGAI.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDGAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDGAI.Location = new System.Drawing.Point(3, 16);
            this.dgvDGAI.Name = "dgvDGAI";
            this.dgvDGAI.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDGAI.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDGAI.RowHeadersVisible = false;
            this.dgvDGAI.RowHeadersWidth = 10;
            this.dgvDGAI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDGAI.Size = new System.Drawing.Size(650, 115);
            this.dgvDGAI.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "intRuId";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descripcion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 280;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precioUnitario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cantidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn9.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Importe";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn10.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.dgvDGAI);
            this.GBDatosRubros.Location = new System.Drawing.Point(12, 238);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(656, 134);
            this.GBDatosRubros.TabIndex = 122;
            this.GBDatosRubros.TabStop = false;
            // 
            // BtnSalirC
            // 
            this.BtnSalirC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalirC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirC.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalirC.Location = new System.Drawing.Point(262, 378);
            this.BtnSalirC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalirC.Name = "BtnSalirC";
            this.BtnSalirC.Size = new System.Drawing.Size(74, 39);
            this.BtnSalirC.TabIndex = 136;
            this.BtnSalirC.Text = "&Salir";
            this.BtnSalirC.UseVisualStyleBackColor = false;
            this.BtnSalirC.Click += new System.EventHandler(this.BtnSalirC_Click);
            // 
            // IGBTotales
            // 
            this.IGBTotales.BackColor = System.Drawing.Color.Transparent;
            this.IGBTotales.Controls.Add(this.txtTotalLiquidacionC);
            this.IGBTotales.Controls.Add(this.label4);
            this.IGBTotales.Controls.Add(this.txtSaldoC);
            this.IGBTotales.Controls.Add(this.label3);
            this.IGBTotales.Controls.Add(this.txtTotalDocumentoC);
            this.IGBTotales.Controls.Add(this.LblTotal);
            this.IGBTotales.Location = new System.Drawing.Point(411, 378);
            this.IGBTotales.Name = "IGBTotales";
            this.IGBTotales.Size = new System.Drawing.Size(257, 89);
            this.IGBTotales.TabIndex = 137;
            this.IGBTotales.TabStop = false;
            // 
            // txtTotalLiquidacionC
            // 
            this.txtTotalLiquidacionC.BackColor = System.Drawing.Color.White;
            this.txtTotalLiquidacionC.Enabled = false;
            this.txtTotalLiquidacionC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLiquidacionC.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalLiquidacionC.Location = new System.Drawing.Point(153, 57);
            this.txtTotalLiquidacionC.Name = "txtTotalLiquidacionC";
            this.txtTotalLiquidacionC.ReadOnly = true;
            this.txtTotalLiquidacionC.Size = new System.Drawing.Size(104, 22);
            this.txtTotalLiquidacionC.TabIndex = 4;
            this.txtTotalLiquidacionC.Text = "0.00";
            this.txtTotalLiquidacionC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(39, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Liquidación :";
            // 
            // txtSaldoC
            // 
            this.txtSaldoC.BackColor = System.Drawing.Color.White;
            this.txtSaldoC.Enabled = false;
            this.txtSaldoC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoC.ForeColor = System.Drawing.Color.Maroon;
            this.txtSaldoC.Location = new System.Drawing.Point(153, 34);
            this.txtSaldoC.Name = "txtSaldoC";
            this.txtSaldoC.ReadOnly = true;
            this.txtSaldoC.Size = new System.Drawing.Size(104, 22);
            this.txtSaldoC.TabIndex = 4;
            this.txtSaldoC.Text = "0.00";
            this.txtSaldoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(97, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SALDO :";
            // 
            // txtTotalDocumentoC
            // 
            this.txtTotalDocumentoC.BackColor = System.Drawing.Color.White;
            this.txtTotalDocumentoC.Enabled = false;
            this.txtTotalDocumentoC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDocumentoC.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalDocumentoC.Location = new System.Drawing.Point(153, 11);
            this.txtTotalDocumentoC.Name = "txtTotalDocumentoC";
            this.txtTotalDocumentoC.ReadOnly = true;
            this.txtTotalDocumentoC.Size = new System.Drawing.Size(104, 22);
            this.txtTotalDocumentoC.TabIndex = 4;
            this.txtTotalDocumentoC.Text = "0.00";
            this.txtTotalDocumentoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Navy;
            this.LblTotal.Location = new System.Drawing.Point(38, 15);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(109, 13);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "Total documento :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(56, 184);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Glosa :";
            // 
            // frmIngresoRubrosPorLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtGlosa);
            this.Controls.Add(this.IGBTotales);
            this.Controls.Add(this.BtnSalirC);
            this.Controls.Add(this.BtnNuevoC);
            this.Controls.Add(this.BtnCancelarC);
            this.Controls.Add(this.BtnGrabarC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBPago);
            this.Controls.Add(this.GBDatosRubros);
            this.Controls.Add(this.GBAgregarQuitar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIngresoRubrosPorLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresoRubrosPorLiquidacion";
            this.Load += new System.EventHandler(this.frmIngresoRubrosPorLiquidacion_Load);
            this.GBAgregarQuitar.ResumeLayout(false);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGAI)).EndInit();
            this.GBDatosRubros.ResumeLayout(false);
            this.IGBTotales.ResumeLayout(false);
            this.IGBTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBAgregarQuitar;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.TextBox txtFechaC;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNumeroRecibo;
        internal System.Windows.Forms.GroupBox GBPago;
        internal System.Windows.Forms.ComboBox cboModalidadPago;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.TextBox TxtNombreC;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtGlosa;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtUsuarioC;
        internal System.Windows.Forms.Button BtnNuevoC;
        internal System.Windows.Forms.Button BtnCancelarC;
        internal System.Windows.Forms.Button BtnGrabarC;
        internal System.Windows.Forms.DataGridView dgvDGAI;
        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.Button BtnSalirC;
        internal System.Windows.Forms.GroupBox IGBTotales;
        internal System.Windows.Forms.TextBox txtTotalLiquidacionC;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtSaldoC;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtTotalDocumentoC;
        internal System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTipoCambio;
        internal System.Windows.Forms.TextBox txtTotalCambioDolar;
        internal System.Windows.Forms.TextBox txtImportePago;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblTipoMoneda;
        internal System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}