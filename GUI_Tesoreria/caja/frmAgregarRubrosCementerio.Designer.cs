namespace GUI_Tesoreria.caja
{
    partial class frmAgregarRubrosCementerio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarRubrosCementerio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBSolicitante = new System.Windows.Forms.GroupBox();
            this.rdbSepultura = new System.Windows.Forms.RadioButton();
            this.rdbServicios = new System.Windows.Forms.RadioButton();
            this.rdbMausoleo = new System.Windows.Forms.RadioButton();
            this.rdbNicho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTarifario = new System.Windows.Forms.DataGridView();
            this.id_cuenta_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perpe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.varCeNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnSalirC = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGlosaPorRubro = new System.Windows.Forms.TextBox();
            this.GBSolicitante.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSolicitante
            // 
            this.GBSolicitante.BackColor = System.Drawing.Color.Transparent;
            this.GBSolicitante.Controls.Add(this.rdbSepultura);
            this.GBSolicitante.Controls.Add(this.rdbServicios);
            this.GBSolicitante.Controls.Add(this.rdbMausoleo);
            this.GBSolicitante.Controls.Add(this.rdbNicho);
            this.GBSolicitante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSolicitante.ForeColor = System.Drawing.Color.Maroon;
            this.GBSolicitante.Location = new System.Drawing.Point(12, 12);
            this.GBSolicitante.MaximumSize = new System.Drawing.Size(800, 96);
            this.GBSolicitante.Name = "GBSolicitante";
            this.GBSolicitante.Size = new System.Drawing.Size(473, 56);
            this.GBSolicitante.TabIndex = 9;
            this.GBSolicitante.TabStop = false;
            this.GBSolicitante.Text = "Tipo de tarifa";
            // 
            // rdbSepultura
            // 
            this.rdbSepultura.AutoSize = true;
            this.rdbSepultura.ForeColor = System.Drawing.Color.Navy;
            this.rdbSepultura.Location = new System.Drawing.Point(76, 25);
            this.rdbSepultura.Name = "rdbSepultura";
            this.rdbSepultura.Size = new System.Drawing.Size(80, 17);
            this.rdbSepultura.TabIndex = 2;
            this.rdbSepultura.Text = "Sepultura";
            this.rdbSepultura.UseVisualStyleBackColor = true;
            this.rdbSepultura.CheckedChanged += new System.EventHandler(this.rdbSepultura_CheckedChanged);
            // 
            // rdbServicios
            // 
            this.rdbServicios.AutoSize = true;
            this.rdbServicios.ForeColor = System.Drawing.Color.Navy;
            this.rdbServicios.Location = new System.Drawing.Point(247, 25);
            this.rdbServicios.Name = "rdbServicios";
            this.rdbServicios.Size = new System.Drawing.Size(114, 17);
            this.rdbServicios.TabIndex = 2;
            this.rdbServicios.Text = "Servicios Varios";
            this.rdbServicios.UseVisualStyleBackColor = true;
            this.rdbServicios.CheckedChanged += new System.EventHandler(this.rdbServicios_CheckedChanged);
            // 
            // rdbMausoleo
            // 
            this.rdbMausoleo.AutoSize = true;
            this.rdbMausoleo.ForeColor = System.Drawing.Color.Navy;
            this.rdbMausoleo.Location = new System.Drawing.Point(162, 25);
            this.rdbMausoleo.Name = "rdbMausoleo";
            this.rdbMausoleo.Size = new System.Drawing.Size(79, 17);
            this.rdbMausoleo.TabIndex = 2;
            this.rdbMausoleo.Text = "Mausoleo";
            this.rdbMausoleo.UseVisualStyleBackColor = true;
            this.rdbMausoleo.CheckedChanged += new System.EventHandler(this.rdbMausoleo_CheckedChanged);
            // 
            // rdbNicho
            // 
            this.rdbNicho.AutoSize = true;
            this.rdbNicho.Checked = true;
            this.rdbNicho.ForeColor = System.Drawing.Color.Navy;
            this.rdbNicho.Location = new System.Drawing.Point(15, 25);
            this.rdbNicho.Name = "rdbNicho";
            this.rdbNicho.Size = new System.Drawing.Size(55, 17);
            this.rdbNicho.TabIndex = 2;
            this.rdbNicho.TabStop = true;
            this.rdbNicho.Text = "Nicho";
            this.rdbNicho.UseVisualStyleBackColor = true;
            this.rdbNicho.CheckedChanged += new System.EventHandler(this.rdbNicho_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 53);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(6, 20);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(517, 21);
            this.txtBusqueda.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(530, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTarifario);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 312);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgvTarifario
            // 
            this.dgvTarifario.AllowUserToAddRows = false;
            this.dgvTarifario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTarifario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cuenta_contable,
            this.CodRubro,
            this.intTaId,
            this.descripcion,
            this.abrev,
            this.Precio,
            this.anios,
            this.perpe,
            this.varCeNombre});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifario.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTarifario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarifario.EnableHeadersVisualStyles = false;
            this.dgvTarifario.Location = new System.Drawing.Point(3, 16);
            this.dgvTarifario.Name = "dgvTarifario";
            this.dgvTarifario.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifario.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTarifario.RowHeadersWidth = 25;
            this.dgvTarifario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifario.Size = new System.Drawing.Size(727, 293);
            this.dgvTarifario.TabIndex = 1;
            this.dgvTarifario.CurrentCellChanged += new System.EventHandler(this.dgvTarifario_CurrentCellChanged);
            // 
            // id_cuenta_contable
            // 
            this.id_cuenta_contable.DataPropertyName = "id_cuenta_contable";
            this.id_cuenta_contable.HeaderText = "id_cuenta_contable";
            this.id_cuenta_contable.Name = "id_cuenta_contable";
            this.id_cuenta_contable.ReadOnly = true;
            this.id_cuenta_contable.Visible = false;
            // 
            // CodRubro
            // 
            this.CodRubro.DataPropertyName = "CodRubro";
            this.CodRubro.HeaderText = "CodRubro";
            this.CodRubro.Name = "CodRubro";
            this.CodRubro.ReadOnly = true;
            this.CodRubro.Visible = false;
            // 
            // intTaId
            // 
            this.intTaId.DataPropertyName = "intTaId";
            this.intTaId.HeaderText = "ID";
            this.intTaId.Name = "intTaId";
            this.intTaId.ReadOnly = true;
            this.intTaId.Visible = false;
            this.intTaId.Width = 60;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Nombres";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 330;
            // 
            // abrev
            // 
            this.abrev.DataPropertyName = "abrev";
            this.abrev.HeaderText = "";
            this.abrev.Name = "abrev";
            this.abrev.ReadOnly = true;
            this.abrev.Width = 35;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle7;
            this.Precio.HeaderText = "Costo";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // anios
            // 
            this.anios.DataPropertyName = "anios";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.anios.DefaultCellStyle = dataGridViewCellStyle8;
            this.anios.HeaderText = "Años";
            this.anios.Name = "anios";
            this.anios.ReadOnly = true;
            this.anios.Width = 60;
            // 
            // perpe
            // 
            this.perpe.DataPropertyName = "perpe";
            this.perpe.FalseValue = "0";
            this.perpe.HeaderText = "Perpetuo";
            this.perpe.IndeterminateValue = "0";
            this.perpe.Name = "perpe";
            this.perpe.ReadOnly = true;
            this.perpe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.perpe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.perpe.TrueValue = "1";
            this.perpe.Width = 70;
            // 
            // varCeNombre
            // 
            this.varCeNombre.DataPropertyName = "varCeNombre";
            this.varCeNombre.HeaderText = "Cementerio";
            this.varCeNombre.Name = "varCeNombre";
            this.varCeNombre.ReadOnly = true;
            this.varCeNombre.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtRubro);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(491, 12);
            this.groupBox3.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 56);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rubro";
            // 
            // txtRubro
            // 
            this.txtRubro.BackColor = System.Drawing.SystemColors.Window;
            this.txtRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRubro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubro.Location = new System.Drawing.Point(6, 20);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(97, 21);
            this.txtRubro.TabIndex = 1;
            this.txtRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRubro_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.BtnSalirC);
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Controls.Add(this.txtPrecio);
            this.groupBox4.Controls.Add(this.BtnGrabar);
            this.groupBox4.Controls.Add(this.Label5);
            this.groupBox4.Controls.Add(this.Label6);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(12, 451);
            this.groupBox4.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(733, 53);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // BtnSalirC
            // 
            this.BtnSalirC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalirC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirC.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalirC.Location = new System.Drawing.Point(652, 14);
            this.BtnSalirC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalirC.Name = "BtnSalirC";
            this.BtnSalirC.Size = new System.Drawing.Size(74, 33);
            this.BtnSalirC.TabIndex = 34;
            this.BtnSalirC.Text = "&Salir";
            this.BtnSalirC.UseVisualStyleBackColor = false;
            this.BtnSalirC.Click += new System.EventHandler(this.BtnSalirC_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.txtCantidad.Location = new System.Drawing.Point(455, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 21);
            this.txtCantidad.TabIndex = 31;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Location = new System.Drawing.Point(280, 20);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 21);
            this.txtPrecio.TabIndex = 30;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrabar.Image")));
            this.BtnGrabar.Location = new System.Drawing.Point(564, 14);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(38, 33);
            this.BtnGrabar.TabIndex = 2;
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Navy;
            this.Label5.Location = new System.Drawing.Point(215, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 13);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Precio :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Navy;
            this.Label6.Location = new System.Drawing.Point(386, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 13);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "Cantidad :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtGlosaPorRubro);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox5.Location = new System.Drawing.Point(633, 25);
            this.groupBox5.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(109, 96);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Glosa";
            // 
            // txtGlosaPorRubro
            // 
            this.txtGlosaPorRubro.BackColor = System.Drawing.SystemColors.Window;
            this.txtGlosaPorRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosaPorRubro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlosaPorRubro.Location = new System.Drawing.Point(6, 20);
            this.txtGlosaPorRubro.Multiline = true;
            this.txtGlosaPorRubro.Name = "txtGlosaPorRubro";
            this.txtGlosaPorRubro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGlosaPorRubro.Size = new System.Drawing.Size(97, 70);
            this.txtGlosaPorRubro.TabIndex = 1;
            // 
            // frmAgregarRubrosCementerio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 517);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBSolicitante);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarRubrosCementerio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Rubros Cementerio:::...";
            this.Load += new System.EventHandler(this.frmAgregarRubrosCementerio_Load);
            this.GBSolicitante.ResumeLayout(false);
            this.GBSolicitante.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBSolicitante;
        private System.Windows.Forms.RadioButton rdbNicho;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rdbSepultura;
        private System.Windows.Forms.RadioButton rdbServicios;
        private System.Windows.Forms.RadioButton rdbMausoleo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTarifario;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtRubro;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Button BtnGrabar;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button BtnSalirC;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cuenta_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn anios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn varCeNombre;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.TextBox txtGlosaPorRubro;

    }
}