namespace GUI_Tesoreria.canevaro
{
    partial class frmBusquedaCtaResidente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnCta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit_32px;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(519, 19);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(61, 61);
            this.BtnSalir.TabIndex = 115;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCta
            // 
            this.BtnCta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCta.Image = global::GUI_Tesoreria.Properties.Resources.west_direction_32px;
            this.BtnCta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCta.Location = new System.Drawing.Point(450, 19);
            this.BtnCta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCta.Name = "BtnCta";
            this.BtnCta.Size = new System.Drawing.Size(61, 61);
            this.BtnCta.TabIndex = 114;
            this.BtnCta.Text = "&Ver Cta";
            this.BtnCta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCta.UseVisualStyleBackColor = false;
            this.BtnCta.Click += new System.EventHandler(this.BtnCta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(25, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(59, 21);
            this.txtCodigo.TabIndex = 112;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(98, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(345, 21);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(98, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de Residente";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombres});
            this.dgvResultado.Location = new System.Drawing.Point(108, 78);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(345, 88);
            this.dgvResultado.TabIndex = 2;
            this.dgvResultado.Visible = false;
            this.dgvResultado.DoubleClick += new System.EventHandler(this.dgvResultado_DoubleClick);
            this.dgvResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResultado_KeyDown);
            this.dgvResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvResultado_KeyPress);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 300;
            // 
            // frmBusquedaCtaResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 174);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBusquedaCtaResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Cuenta Residente:::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnCta;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
    }
}