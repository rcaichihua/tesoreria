namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantMAC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantMAC));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMac = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mtbMaC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.txtNroSerie = new System.Windows.Forms.TextBox();
            this.cboDocumentos = new System.Windows.Forms.ComboBox();
            this.lbldoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtDescripcionCompuC = new System.Windows.Forms.TextBox();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.mtbMacC = new System.Windows.Forms.MaskedTextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.detalleMacId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_TipoDocVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_TipoDocVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_serie_ult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_comprobante_ult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMac)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(16, 11);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(699, 44);
            this.LblTitulo.TabIndex = 106;
            this.LblTitulo.Text = "MANTENIMIENTO - MAC";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvMac);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(699, 238);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            // 
            // dgvMac
            // 
            this.dgvMac.AllowUserToAddRows = false;
            this.dgvMac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleMacId,
            this.Cod_TipoDocVenta,
            this.Desc_TipoDocVenta,
            this.nro_serie_ult,
            this.nro_comprobante_ult});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMac.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMac.EnableHeadersVisualStyles = false;
            this.dgvMac.Location = new System.Drawing.Point(4, 19);
            this.dgvMac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMac.Name = "dgvMac";
            this.dgvMac.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMac.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMac.RowHeadersWidth = 25;
            this.dgvMac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMac.Size = new System.Drawing.Size(691, 215);
            this.dgvMac.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cboSucursal);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.btnDelete);
            this.GroupBox1.Controls.Add(this.btnAgregar);
            this.GroupBox1.Controls.Add(this.mtbMaC);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtNroComprobante);
            this.GroupBox1.Controls.Add(this.txtNroSerie);
            this.GroupBox1.Controls.Add(this.cboDocumentos);
            this.GroupBox1.Controls.Add(this.lbldoc);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtDescripcionCompuC);
            this.GroupBox1.Controls.Add(this.txtIdC);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(16, 106);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(699, 149);
            this.GroupBox1.TabIndex = 104;
            this.GroupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(629, 86);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 41);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(577, 86);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(51, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mtbMaC
            // 
            this.mtbMaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMaC.Location = new System.Drawing.Point(109, 43);
            this.mtbMaC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbMaC.Mask = "AA-AA-AA-AA-AA-AA";
            this.mtbMaC.Name = "mtbMaC";
            this.mtbMaC.Size = new System.Drawing.Size(168, 24);
            this.mtbMaC.TabIndex = 9;
            this.mtbMaC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbMac_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(510, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(455, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serie";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroComprobante.Location = new System.Drawing.Point(510, 101);
            this.txtNroComprobante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(61, 24);
            this.txtNroComprobante.TabIndex = 8;
            this.txtNroComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroComprobante_KeyPress);
            // 
            // txtNroSerie
            // 
            this.txtNroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroSerie.Location = new System.Drawing.Point(455, 101);
            this.txtNroSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNroSerie.Name = "txtNroSerie";
            this.txtNroSerie.Size = new System.Drawing.Size(47, 24);
            this.txtNroSerie.TabIndex = 5;
            this.txtNroSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroSerie_KeyPress);
            // 
            // cboDocumentos
            // 
            this.cboDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDocumentos.FormattingEnabled = true;
            this.cboDocumentos.Location = new System.Drawing.Point(251, 101);
            this.cboDocumentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDocumentos.Name = "cboDocumentos";
            this.cboDocumentos.Size = new System.Drawing.Size(196, 26);
            this.cboDocumentos.TabIndex = 4;
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbldoc.Location = new System.Drawing.Point(247, 78);
            this.lbldoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(95, 18);
            this.lbldoc.TabIndex = 3;
            this.lbldoc.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(285, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción PC";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(109, 21);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "MAC";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(8, 21);
            this.lbl12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(62, 18);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "Codigo";
            // 
            // txtDescripcionCompuC
            // 
            this.txtDescripcionCompuC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCompuC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCompuC.Location = new System.Drawing.Point(285, 43);
            this.txtDescripcionCompuC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionCompuC.Name = "txtDescripcionCompuC";
            this.txtDescripcionCompuC.Size = new System.Drawing.Size(396, 24);
            this.txtDescripcionCompuC.TabIndex = 1;
            // 
            // txtIdC
            // 
            this.txtIdC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdC.Location = new System.Drawing.Point(8, 43);
            this.txtIdC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.ReadOnly = true;
            this.txtIdC.Size = new System.Drawing.Size(92, 24);
            this.txtIdC.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBuscarC);
            this.groupBox3.Controls.Add(this.mtbMacC);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(16, 58);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(699, 48);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(57, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "MAC";
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(284, 12);
            this.btnBuscarC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 30);
            this.btnBuscarC.TabIndex = 11;
            this.btnBuscarC.Text = "&Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // mtbMacC
            // 
            this.mtbMacC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMacC.Location = new System.Drawing.Point(109, 16);
            this.mtbMacC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbMacC.Mask = "AA-AA-AA-AA-AA-AA";
            this.mtbMacC.Name = "mtbMacC";
            this.mtbMacC.Size = new System.Drawing.Size(168, 24);
            this.mtbMacC.TabIndex = 10;
            this.mtbMacC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbMacC_KeyPress);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(163, 508);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 90);
            this.btnNuevo.TabIndex = 108;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(371, 508);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 90);
            this.btnGuardar.TabIndex = 111;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(267, 508);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 90);
            this.btnEliminar.TabIndex = 110;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(475, 508);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 90);
            this.btnSalir.TabIndex = 109;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(8, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 112;
            this.label6.Text = "Sucursal";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(8, 101);
            this.cboSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(235, 26);
            this.cboSucursal.TabIndex = 113;
            // 
            // detalleMacId
            // 
            this.detalleMacId.DataPropertyName = "detalleMacId";
            this.detalleMacId.HeaderText = "detalleMacId";
            this.detalleMacId.Name = "detalleMacId";
            this.detalleMacId.ReadOnly = true;
            this.detalleMacId.Visible = false;
            // 
            // Cod_TipoDocVenta
            // 
            this.Cod_TipoDocVenta.DataPropertyName = "Cod_TipoDocVenta";
            this.Cod_TipoDocVenta.HeaderText = "Cod_TipoDocVenta";
            this.Cod_TipoDocVenta.Name = "Cod_TipoDocVenta";
            this.Cod_TipoDocVenta.ReadOnly = true;
            this.Cod_TipoDocVenta.Visible = false;
            // 
            // Desc_TipoDocVenta
            // 
            this.Desc_TipoDocVenta.DataPropertyName = "Desc_TipoDocVenta";
            this.Desc_TipoDocVenta.HeaderText = "Desc_TipoDocVenta";
            this.Desc_TipoDocVenta.Name = "Desc_TipoDocVenta";
            this.Desc_TipoDocVenta.ReadOnly = true;
            this.Desc_TipoDocVenta.Width = 200;
            // 
            // nro_serie_ult
            // 
            this.nro_serie_ult.DataPropertyName = "nro_serie_ult";
            this.nro_serie_ult.HeaderText = "Serie";
            this.nro_serie_ult.Name = "nro_serie_ult";
            this.nro_serie_ult.ReadOnly = true;
            // 
            // nro_comprobante_ult
            // 
            this.nro_comprobante_ult.DataPropertyName = "nro_comprobante_ult";
            this.nro_comprobante_ult.HeaderText = "Nro Comprobante";
            this.nro_comprobante_ult.Name = "nro_comprobante_ult";
            this.nro_comprobante_ult.ReadOnly = true;
            this.nro_comprobante_ult.Width = 150;
            // 
            // frmMantMAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 612);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmMantMAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Mantenimiento MAC:::...";
            this.Load += new System.EventHandler(this.frmMantMAC_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMac)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMac;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtIdC;
        internal System.Windows.Forms.ComboBox cboDocumentos;
        internal System.Windows.Forms.Label lbldoc;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNroComprobante;
        internal System.Windows.Forms.TextBox txtNroSerie;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtDescripcionCompuC;
        private System.Windows.Forms.MaskedTextBox mtbMaC;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.MaskedTextBox mtbMacC;
        protected System.Windows.Forms.Button btnNuevo;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnEliminar;
        protected System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.ComboBox cboSucursal;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleMacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_TipoDocVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_TipoDocVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_serie_ult;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_comprobante_ult;
    }
}