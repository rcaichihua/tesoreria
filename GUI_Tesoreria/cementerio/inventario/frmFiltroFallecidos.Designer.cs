namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmFiltroFallecidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvFiltro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDORG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAFALLECIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSDIFUNTOINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LETRAFILANICHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROCOLNICHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(526, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 39);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(419, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 39);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "&BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(85, 19);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(328, 20);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOMBRES";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFiltro);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 286);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.AllowUserToResizeColumns = false;
            this.dgvFiltro.AllowUserToResizeRows = false;
            this.dgvFiltro.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDORG,
            this.NOMBRES,
            this.FECHAFALLECIMIENTO,
            this.OBSDIFUNTOINV,
            this.TIPO,
            this.LETRAFILANICHO,
            this.NUMEROCOLNICHO});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFiltro.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiltro.Location = new System.Drawing.Point(3, 16);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltro.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFiltro.RowHeadersVisible = false;
            this.dgvFiltro.RowHeadersWidth = 10;
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(777, 267);
            this.dgvFiltro.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 80;
            // 
            // IDORG
            // 
            this.IDORG.DataPropertyName = "IDORG";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDORG.DefaultCellStyle = dataGridViewCellStyle3;
            this.IDORG.HeaderText = "CODIGO BUSQUEDA";
            this.IDORG.Name = "IDORG";
            this.IDORG.ReadOnly = true;
            this.IDORG.Width = 80;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "APELLIDOS Y NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 200;
            // 
            // FECHAFALLECIMIENTO
            // 
            this.FECHAFALLECIMIENTO.DataPropertyName = "FECHAFALLECIMIENTO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.FECHAFALLECIMIENTO.DefaultCellStyle = dataGridViewCellStyle4;
            this.FECHAFALLECIMIENTO.HeaderText = "FECHA FALLECIMIENTO";
            this.FECHAFALLECIMIENTO.Name = "FECHAFALLECIMIENTO";
            this.FECHAFALLECIMIENTO.ReadOnly = true;
            this.FECHAFALLECIMIENTO.Width = 90;
            // 
            // OBSDIFUNTOINV
            // 
            this.OBSDIFUNTOINV.DataPropertyName = "DATOS";
            this.OBSDIFUNTOINV.HeaderText = "CUARTEL / FAMILIA";
            this.OBSDIFUNTOINV.Name = "OBSDIFUNTOINV";
            this.OBSDIFUNTOINV.ReadOnly = true;
            this.OBSDIFUNTOINV.Width = 150;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle5;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // LETRAFILANICHO
            // 
            this.LETRAFILANICHO.DataPropertyName = "LETRAFILANICHO";
            this.LETRAFILANICHO.HeaderText = "FILA NICHO";
            this.LETRAFILANICHO.Name = "LETRAFILANICHO";
            this.LETRAFILANICHO.ReadOnly = true;
            this.LETRAFILANICHO.Width = 70;
            // 
            // NUMEROCOLNICHO
            // 
            this.NUMEROCOLNICHO.DataPropertyName = "NUMEROCOLNICHO";
            this.NUMEROCOLNICHO.HeaderText = "COLUMNA NICHO";
            this.NUMEROCOLNICHO.Name = "NUMEROCOLNICHO";
            this.NUMEROCOLNICHO.ReadOnly = true;
            this.NUMEROCOLNICHO.Width = 70;
            // 
            // frmFiltroFallecidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 375);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFiltroFallecidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiltroFallecidos";
            this.Load += new System.EventHandler(this.frmFiltroFallecidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDORG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAFALLECIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSDIFUNTOINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LETRAFILANICHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROCOLNICHO;
    }
}