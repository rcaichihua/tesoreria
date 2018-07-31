namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantZona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEspaciosxZona = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkConstruido = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNiveles = new System.Windows.Forms.TextBox();
            this.txtNroColumnas = new System.Windows.Forms.TextBox();
            this.txtNroFilas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCementerio = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTipoZona = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvZonas = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenEspacios = new System.Windows.Forms.Button();
            this.btnGenLotes = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspaciosxZona)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(191, 176);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(347, 176);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(35, 176);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 176);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(113, 176);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(425, 176);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvEspaciosxZona);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 251);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            // 
            // dgvEspaciosxZona
            // 
            this.dgvEspaciosxZona.AllowUserToAddRows = false;
            this.dgvEspaciosxZona.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspaciosxZona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspaciosxZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspaciosxZona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspaciosxZona.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspaciosxZona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspaciosxZona.EnableHeadersVisualStyles = false;
            this.dgvEspaciosxZona.Location = new System.Drawing.Point(3, 16);
            this.dgvEspaciosxZona.Name = "dgvEspaciosxZona";
            this.dgvEspaciosxZona.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspaciosxZona.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEspaciosxZona.RowHeadersWidth = 25;
            this.dgvEspaciosxZona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspaciosxZona.Size = new System.Drawing.Size(491, 232);
            this.dgvEspaciosxZona.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fila";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nro";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nivel";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo Sepultura";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Observaciones";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.chkConstruido);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtNiveles);
            this.GroupBox1.Controls.Add(this.txtNroColumnas);
            this.GroupBox1.Controls.Add(this.txtNroFilas);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.cboCementerio);
            this.GroupBox1.Controls.Add(this.chkActivo);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.cboTipoZona);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtNombre);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(497, 158);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // chkConstruido
            // 
            this.chkConstruido.AutoSize = true;
            this.chkConstruido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConstruido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkConstruido.Location = new System.Drawing.Point(390, 78);
            this.chkConstruido.Name = "chkConstruido";
            this.chkConstruido.Size = new System.Drawing.Size(95, 19);
            this.chkConstruido.TabIndex = 5;
            this.chkConstruido.Text = "Construido";
            this.chkConstruido.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nro de Niveles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(193, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nro de Columnas / Sepultura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nro de Filas";
            // 
            // txtNiveles
            // 
            this.txtNiveles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNiveles.Location = new System.Drawing.Point(114, 132);
            this.txtNiveles.Name = "txtNiveles";
            this.txtNiveles.Size = new System.Drawing.Size(70, 21);
            this.txtNiveles.TabIndex = 8;
            this.txtNiveles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNiveles_KeyPress);
            // 
            // txtNroColumnas
            // 
            this.txtNroColumnas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroColumnas.Location = new System.Drawing.Point(391, 105);
            this.txtNroColumnas.Name = "txtNroColumnas";
            this.txtNroColumnas.Size = new System.Drawing.Size(70, 21);
            this.txtNroColumnas.TabIndex = 7;
            this.txtNroColumnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNiveles_KeyPress);
            // 
            // txtNroFilas
            // 
            this.txtNroFilas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFilas.Location = new System.Drawing.Point(114, 105);
            this.txtNroFilas.Name = "txtNroFilas";
            this.txtNroFilas.Size = new System.Drawing.Size(70, 21);
            this.txtNroFilas.TabIndex = 6;
            this.txtNroFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroFilas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(27, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cementerio";
            // 
            // cboCementerio
            // 
            this.cboCementerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCementerio.FormattingEnabled = true;
            this.cboCementerio.Location = new System.Drawing.Point(114, 76);
            this.cboCementerio.Name = "cboCementerio";
            this.cboCementerio.Size = new System.Drawing.Size(202, 23);
            this.cboCementerio.TabIndex = 3;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkActivo.Location = new System.Drawing.Point(322, 78);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(63, 19);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(197, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tipo Zona";
            // 
            // cboTipoZona
            // 
            this.cboTipoZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoZona.FormattingEnabled = true;
            this.cboTipoZona.Location = new System.Drawing.Point(274, 20);
            this.cboTipoZona.Name = "cboTipoZona";
            this.cboTipoZona.Size = new System.Drawing.Size(212, 23);
            this.cboTipoZona.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(14, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Nombre Zona";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(20, 23);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(88, 15);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "Codigo Zona";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(114, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(114, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 21);
            this.txtId.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvZonas);
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(518, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 523);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            // 
            // dgvZonas
            // 
            this.dgvZonas.AllowUserToAddRows = false;
            this.dgvZonas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZonas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvZonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZonas.EnableHeadersVisualStyles = false;
            this.dgvZonas.Location = new System.Drawing.Point(3, 16);
            this.dgvZonas.Name = "dgvZonas";
            this.dgvZonas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvZonas.RowHeadersWidth = 25;
            this.dgvZonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZonas.Size = new System.Drawing.Size(493, 504);
            this.dgvZonas.TabIndex = 0;
            this.dgvZonas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dgvZonas.Click += new System.EventHandler(this.dgvZonas_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "intZId";
            this.Column7.HeaderText = "Codigo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "varTzDescripcion";
            this.Column8.HeaderText = "Tipo Zona";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "varZDescripcion";
            this.Column9.HeaderText = "Nombre";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 180;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "varCeNombre";
            this.Column10.HeaderText = "Cementerio";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "bitZConstruido";
            this.Column11.FalseValue = "0";
            this.Column11.HeaderText = "Construido";
            this.Column11.IndeterminateValue = "0";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.TrueValue = "1";
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "bitZEstado";
            this.Column12.FalseValue = "0";
            this.Column12.HeaderText = "Activo";
            this.Column12.IndeterminateValue = "0";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.TrueValue = "1";
            this.Column12.Width = 60;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "intZnroFilas";
            this.Column13.HeaderText = "Filas";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 55;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "intZNivel";
            this.Column14.HeaderText = "Niveles";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "intZnroSepulturas";
            this.Column15.HeaderText = "Column / sepult";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 60;
            // 
            // btnGenEspacios
            // 
            this.btnGenEspacios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenEspacios.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenEspacios.Location = new System.Drawing.Point(15, 255);
            this.btnGenEspacios.Name = "btnGenEspacios";
            this.btnGenEspacios.Size = new System.Drawing.Size(245, 23);
            this.btnGenEspacios.TabIndex = 94;
            this.btnGenEspacios.Text = "Generar espacios y sepulturas";
            this.btnGenEspacios.UseVisualStyleBackColor = true;
            // 
            // btnGenLotes
            // 
            this.btnGenLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenLotes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenLotes.Location = new System.Drawing.Point(266, 255);
            this.btnGenLotes.Name = "btnGenLotes";
            this.btnGenLotes.Size = new System.Drawing.Size(245, 23);
            this.btnGenLotes.TabIndex = 94;
            this.btnGenLotes.Text = "Generar lotes para Mausoleo";
            this.btnGenLotes.UseVisualStyleBackColor = true;
            // 
            // frmMantZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 547);
            this.Controls.Add(this.btnGenLotes);
            this.Controls.Add(this.btnGenEspacios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMantZona";
            this.Text = "...:::Mantenimiento de Zonas:::...";
            this.Load += new System.EventHandler(this.frmServicioSepultura_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnGenEspacios, 0);
            this.Controls.SetChildIndex(this.btnGenLotes, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspaciosxZona)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEspaciosxZona;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.ComboBox cboTipoZona;
        private System.Windows.Forms.CheckBox chkActivo;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cboCementerio;
        private System.Windows.Forms.CheckBox chkConstruido;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNiveles;
        internal System.Windows.Forms.TextBox txtNroColumnas;
        internal System.Windows.Forms.TextBox txtNroFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvZonas;
        private System.Windows.Forms.Button btnGenEspacios;
        private System.Windows.Forms.Button btnGenLotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}