namespace GUI_Tesoreria.DGAI
{
    partial class frmAgregarRubrosDGAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarRubrosDGAI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTarifario = new System.Windows.Forms.DataGridView();
            this.id_cuenta_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.txtCantidad.Location = new System.Drawing.Point(540, 387);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(40, 21);
            this.txtCantidad.TabIndex = 37;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Location = new System.Drawing.Point(396, 387);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(69, 21);
            this.txtPrecio.TabIndex = 36;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrabar.Image")));
            this.BtnGrabar.Location = new System.Drawing.Point(589, 381);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(38, 33);
            this.BtnGrabar.TabIndex = 38;
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtBusqueda);
            this.groupBox3.Controls.Add(this.txtRubro);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 56);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rubro";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(109, 20);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(493, 21);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // txtRubro
            // 
            this.txtRubro.BackColor = System.Drawing.SystemColors.Window;
            this.txtRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRubro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubro.Location = new System.Drawing.Point(6, 20);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(97, 21);
            this.txtRubro.TabIndex = 0;
            this.txtRubro.TextChanged += new System.EventHandler(this.txtRubro_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Navy;
            this.Label5.Location = new System.Drawing.Point(323, 391);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 13);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Precio Unit :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Navy;
            this.Label6.Location = new System.Drawing.Point(471, 391);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 13);
            this.Label6.TabIndex = 39;
            this.Label6.Text = "Cantidad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTarifario);
            this.groupBox2.Location = new System.Drawing.Point(11, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 301);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // dgvTarifario
            // 
            this.dgvTarifario.AllowUserToAddRows = false;
            this.dgvTarifario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarifario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cuenta_contable,
            this.intRuId,
            this.CodRubro,
            this.descripcion,
            this.abrev,
            this.Precio});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTarifario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarifario.EnableHeadersVisualStyles = false;
            this.dgvTarifario.Location = new System.Drawing.Point(3, 16);
            this.dgvTarifario.Name = "dgvTarifario";
            this.dgvTarifario.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTarifario.RowHeadersWidth = 25;
            this.dgvTarifario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifario.Size = new System.Drawing.Size(609, 282);
            this.dgvTarifario.TabIndex = 0;
            // 
            // id_cuenta_contable
            // 
            this.id_cuenta_contable.DataPropertyName = "id_cuenta_contable";
            this.id_cuenta_contable.HeaderText = "id_cuenta_contable";
            this.id_cuenta_contable.Name = "id_cuenta_contable";
            this.id_cuenta_contable.ReadOnly = true;
            this.id_cuenta_contable.Visible = false;
            // 
            // intRuId
            // 
            this.intRuId.DataPropertyName = "intRuId";
            this.intRuId.HeaderText = "intRuId";
            this.intRuId.Name = "intRuId";
            this.intRuId.ReadOnly = true;
            this.intRuId.Visible = false;
            // 
            // CodRubro
            // 
            this.CodRubro.DataPropertyName = "CodRubro";
            this.CodRubro.HeaderText = "CodRubro";
            this.CodRubro.Name = "CodRubro";
            this.CodRubro.ReadOnly = true;
            this.CodRubro.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Nombres";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 450;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "Costo";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // frmAgregarRubrosDGAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarRubrosDGAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarRubrosDGAI";
            this.Load += new System.EventHandler(this.frmAgregarRubrosDGAI_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Button BtnGrabar;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtBusqueda;
        internal System.Windows.Forms.TextBox txtRubro;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTarifario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cuenta_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;

    }
}