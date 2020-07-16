namespace GUI_Tesoreria.caja
{
    partial class frmCtaCteResidente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.dgvCta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDesde = new System.Windows.Forms.ComboBox();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSalirC = new System.Windows.Forms.Button();
            this.grbSeleccionar = new System.Windows.Forms.GroupBox();
            this.rdbNinguno = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnImprimie = new System.Windows.Forms.Button();
            this.idCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDatosRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbSeleccionar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.dgvCta);
            this.GBDatosRubros.Location = new System.Drawing.Point(8, 42);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(830, 275);
            this.GBDatosRubros.TabIndex = 4;
            this.GBDatosRubros.TabStop = false;
            // 
            // dgvCta
            // 
            this.dgvCta.AllowUserToAddRows = false;
            this.dgvCta.AllowUserToDeleteRows = false;
            this.dgvCta.AllowUserToResizeColumns = false;
            this.dgvCta.AllowUserToResizeRows = false;
            this.dgvCta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCta,
            this.aFiscal,
            this.mesDeuda,
            this.nombreDeuda,
            this.importeDeuda,
            this.mora,
            this.dscto,
            this.TotalDeuda,
            this.Acuenta,
            this.TipoPago,
            this.seleccion,
            this.fechaVencimiento});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCta.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCta.Location = new System.Drawing.Point(3, 16);
            this.dgvCta.Name = "dgvCta";
            this.dgvCta.RowHeadersVisible = false;
            this.dgvCta.RowHeadersWidth = 10;
            this.dgvCta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCta.Size = new System.Drawing.Size(824, 256);
            this.dgvCta.TabIndex = 3;
            this.dgvCta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCta_CellValueChanged);
            this.dgvCta.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCta_CurrentCellDirtyStateChanged);
            this.dgvCta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCta_EditingControlShowing);
            this.dgvCta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCta_KeyPress);
            this.dgvCta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCta_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboDesde);
            this.groupBox1.Controls.Add(this.cboHasta);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(8, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(238, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(126, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // cboDesde
            // 
            this.cboDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesde.FormattingEnabled = true;
            this.cboDesde.Items.AddRange(new object[] {
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboDesde.Location = new System.Drawing.Point(57, 18);
            this.cboDesde.Margin = new System.Windows.Forms.Padding(2);
            this.cboDesde.Name = "cboDesde";
            this.cboDesde.Size = new System.Drawing.Size(62, 21);
            this.cboDesde.TabIndex = 0;
            // 
            // cboHasta
            // 
            this.cboHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboHasta.Location = new System.Drawing.Point(170, 18);
            this.cboHasta.Margin = new System.Windows.Forms.Padding(2);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(62, 21);
            this.cboHasta.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(724, 328);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(53, 39);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(116, 15);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(87, 22);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total a cancelar";
            // 
            // BtnSalirC
            // 
            this.BtnSalirC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalirC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirC.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalirC.Location = new System.Drawing.Point(785, 328);
            this.BtnSalirC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalirC.Name = "BtnSalirC";
            this.BtnSalirC.Size = new System.Drawing.Size(53, 39);
            this.BtnSalirC.TabIndex = 9;
            this.BtnSalirC.Text = "&Salir";
            this.BtnSalirC.UseVisualStyleBackColor = false;
            this.BtnSalirC.Click += new System.EventHandler(this.BtnSalirC_Click);
            // 
            // grbSeleccionar
            // 
            this.grbSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.grbSeleccionar.Controls.Add(this.rdbNinguno);
            this.grbSeleccionar.Controls.Add(this.rdbTodos);
            this.grbSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeleccionar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grbSeleccionar.Location = new System.Drawing.Point(549, 323);
            this.grbSeleccionar.Name = "grbSeleccionar";
            this.grbSeleccionar.Size = new System.Drawing.Size(169, 45);
            this.grbSeleccionar.TabIndex = 64;
            this.grbSeleccionar.TabStop = false;
            this.grbSeleccionar.Text = "Cancelar";
            // 
            // rdbNinguno
            // 
            this.rdbNinguno.AutoSize = true;
            this.rdbNinguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNinguno.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbNinguno.Location = new System.Drawing.Point(95, 16);
            this.rdbNinguno.Name = "rdbNinguno";
            this.rdbNinguno.Size = new System.Drawing.Size(79, 19);
            this.rdbNinguno.TabIndex = 1;
            this.rdbNinguno.TabStop = true;
            this.rdbNinguno.Text = "&Ninguno";
            this.rdbNinguno.UseVisualStyleBackColor = true;
            this.rdbNinguno.CheckedChanged += new System.EventHandler(this.rdbNinguno_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbTodos.Location = new System.Drawing.Point(25, 16);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(64, 19);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "&Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(846, 42);
            this.label2.TabIndex = 65;
            this.label2.Text = "ESTADO DE CUENTA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(334, 323);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(210, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Navy;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(253, 328);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 39);
            this.btnCalcular.TabIndex = 66;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnImprimie
            // 
            this.btnImprimie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimie.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimie.ForeColor = System.Drawing.Color.Navy;
            this.btnImprimie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimie.Location = new System.Drawing.Point(8, 373);
            this.btnImprimie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImprimie.Name = "btnImprimie";
            this.btnImprimie.Size = new System.Drawing.Size(75, 23);
            this.btnImprimie.TabIndex = 67;
            this.btnImprimie.Text = "&Imprimir";
            this.btnImprimie.UseVisualStyleBackColor = false;
            this.btnImprimie.Click += new System.EventHandler(this.btnImprimie_Click);
            // 
            // idCta
            // 
            this.idCta.DataPropertyName = "ctacteResidenteId";
            this.idCta.HeaderText = "idCta";
            this.idCta.Name = "idCta";
            this.idCta.ReadOnly = true;
            this.idCta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCta.Visible = false;
            // 
            // aFiscal
            // 
            this.aFiscal.DataPropertyName = "afiscaldeuda";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.aFiscal.DefaultCellStyle = dataGridViewCellStyle2;
            this.aFiscal.HeaderText = "Año";
            this.aFiscal.Name = "aFiscal";
            this.aFiscal.ReadOnly = true;
            this.aFiscal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aFiscal.Width = 65;
            // 
            // mesDeuda
            // 
            this.mesDeuda.DataPropertyName = "mesdeuda";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.mesDeuda.DefaultCellStyle = dataGridViewCellStyle3;
            this.mesDeuda.HeaderText = "Mes";
            this.mesDeuda.Name = "mesDeuda";
            this.mesDeuda.ReadOnly = true;
            this.mesDeuda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mesDeuda.Width = 80;
            // 
            // nombreDeuda
            // 
            this.nombreDeuda.DataPropertyName = "nombredeuda";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.nombreDeuda.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreDeuda.HeaderText = "Tipo";
            this.nombreDeuda.Name = "nombreDeuda";
            this.nombreDeuda.ReadOnly = true;
            this.nombreDeuda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreDeuda.Width = 120;
            // 
            // importeDeuda
            // 
            this.importeDeuda.DataPropertyName = "importeDeuda";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.importeDeuda.DefaultCellStyle = dataGridViewCellStyle5;
            this.importeDeuda.HeaderText = "Deuda Parcial";
            this.importeDeuda.Name = "importeDeuda";
            this.importeDeuda.ReadOnly = true;
            this.importeDeuda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.importeDeuda.Width = 80;
            // 
            // mora
            // 
            this.mora.DataPropertyName = "mora";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.mora.DefaultCellStyle = dataGridViewCellStyle6;
            this.mora.HeaderText = "Mora";
            this.mora.Name = "mora";
            this.mora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mora.Width = 65;
            // 
            // dscto
            // 
            this.dscto.DataPropertyName = "dscto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Format = "N2";
            this.dscto.DefaultCellStyle = dataGridViewCellStyle7;
            this.dscto.HeaderText = "Dscto";
            this.dscto.Name = "dscto";
            this.dscto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dscto.Width = 65;
            // 
            // TotalDeuda
            // 
            this.TotalDeuda.DataPropertyName = "totalDeuda";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "N2";
            this.TotalDeuda.DefaultCellStyle = dataGridViewCellStyle8;
            this.TotalDeuda.HeaderText = "Deuda Total";
            this.TotalDeuda.Name = "TotalDeuda";
            this.TotalDeuda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalDeuda.Width = 90;
            // 
            // Acuenta
            // 
            this.Acuenta.DataPropertyName = "acuenta";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Format = "n2";
            this.Acuenta.DefaultCellStyle = dataGridViewCellStyle9;
            this.Acuenta.HeaderText = "Acuenta";
            this.Acuenta.Name = "Acuenta";
            this.Acuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Acuenta.Width = 65;
            // 
            // TipoPago
            // 
            this.TipoPago.DataPropertyName = "tipoPago";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.TipoPago.DefaultCellStyle = dataGridViewCellStyle10;
            this.TipoPago.HeaderText = "Tipo Pago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TipoPago.Width = 90;
            // 
            // seleccion
            // 
            this.seleccion.DataPropertyName = "selecciona";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.NullValue = false;
            this.seleccion.DefaultCellStyle = dataGridViewCellStyle11;
            this.seleccion.FalseValue = "0";
            this.seleccion.HeaderText = "Select";
            this.seleccion.IndeterminateValue = "0";
            this.seleccion.Name = "seleccion";
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seleccion.TrueValue = "1";
            this.seleccion.Width = 60;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.DataPropertyName = "fechaVencimiento";
            this.fechaVencimiento.HeaderText = "fechaVencimiento";
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.Visible = false;
            // 
            // frmCtaCteResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 405);
            this.Controls.Add(this.btnImprimie);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbSeleccionar);
            this.Controls.Add(this.BtnSalirC);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBDatosRubros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCtaCteResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Estado de cuenta:::...";
            this.Load += new System.EventHandler(this.frmCtaCteResidente_Load);
            this.GBDatosRubros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSeleccionar.ResumeLayout(false);
            this.grbSeleccionar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.DataGridView dgvCta;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHasta;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button BtnSalirC;
        internal System.Windows.Forms.GroupBox grbSeleccionar;
        internal System.Windows.Forms.RadioButton rdbNinguno;
        internal System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDesde;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnCalcular;
        internal System.Windows.Forms.Button btnImprimie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn mora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
    }
}