namespace GUI_Tesoreria.caja
{
    partial class frmAgregarRubro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarRubro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvGlosa = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGlosaPorRubro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.Descuento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTarifario = new System.Windows.Forms.DataGridView();
            this.id_cuenta_contable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.dgvGlosa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvGlosa);
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Controls.Add(this.txtPrecio);
            this.groupBox4.Controls.Add(this.BtnGrabar);
            this.groupBox4.Controls.Add(this.Label5);
            this.groupBox4.Controls.Add(this.Label6);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(12, 381);
            this.groupBox4.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(615, 96);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // dgvGlosa
            // 
            this.dgvGlosa.BackColor = System.Drawing.Color.Transparent;
            this.dgvGlosa.Controls.Add(this.label2);
            this.dgvGlosa.Controls.Add(this.txtGlosaPorRubro);
            this.dgvGlosa.Controls.Add(this.label1);
            this.dgvGlosa.Controls.Add(this.txtDel);
            this.dgvGlosa.Controls.Add(this.txtAl);
            this.dgvGlosa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGlosa.ForeColor = System.Drawing.Color.Maroon;
            this.dgvGlosa.Location = new System.Drawing.Point(6, 14);
            this.dgvGlosa.MaximumSize = new System.Drawing.Size(800, 96);
            this.dgvGlosa.Name = "dgvGlosa";
            this.dgvGlosa.Size = new System.Drawing.Size(286, 82);
            this.dgvGlosa.TabIndex = 0;
            this.dgvGlosa.TabStop = false;
            this.dgvGlosa.Text = "Glosa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(186, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Al :";
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
            this.txtGlosaPorRubro.Size = new System.Drawing.Size(162, 56);
            this.txtGlosaPorRubro.TabIndex = 0;
            this.txtGlosaPorRubro.Text = "DEL NRO ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(180, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Del :";
            // 
            // txtDel
            // 
            this.txtDel.BackColor = System.Drawing.SystemColors.Window;
            this.txtDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDel.ForeColor = System.Drawing.Color.Maroon;
            this.txtDel.Location = new System.Drawing.Point(216, 20);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(54, 21);
            this.txtDel.TabIndex = 1;
            this.txtDel.Text = "0";
            this.txtDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtAl
            // 
            this.txtAl.BackColor = System.Drawing.SystemColors.Window;
            this.txtAl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAl.ForeColor = System.Drawing.Color.Maroon;
            this.txtAl.Location = new System.Drawing.Point(216, 47);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(54, 21);
            this.txtAl.TabIndex = 2;
            this.txtAl.Text = "0";
            this.txtAl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.txtCantidad.Location = new System.Drawing.Point(515, 43);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(40, 21);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecio.Location = new System.Drawing.Point(371, 43);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(69, 21);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGrabar.Image")));
            this.BtnGrabar.Location = new System.Drawing.Point(564, 37);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(38, 33);
            this.BtnGrabar.TabIndex = 3;
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Navy;
            this.Label5.Location = new System.Drawing.Point(298, 47);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 13);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Precio Unit :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Navy;
            this.Label6.Location = new System.Drawing.Point(446, 47);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 13);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "Cantidad :";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescuento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescuento.Location = new System.Drawing.Point(389, -7);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 21);
            this.txtDescuento.TabIndex = 30;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Visible = false;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // Descuento
            // 
            this.Descuento.AutoSize = true;
            this.Descuento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuento.ForeColor = System.Drawing.Color.Navy;
            this.Descuento.Location = new System.Drawing.Point(333, -4);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(50, 13);
            this.Descuento.TabIndex = 33;
            this.Descuento.Text = "DSCTO :";
            this.Descuento.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtBusqueda);
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.txtRubro);
            this.groupBox3.Controls.Add(this.Descuento);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.MaximumSize = new System.Drawing.Size(800, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 56);
            this.groupBox3.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTarifario);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvTarifario
            // 
            this.dgvTarifario.AllowUserToAddRows = false;
            this.dgvTarifario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTarifario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cuenta_contable,
            this.intRuId,
            this.CodRubro,
            this.descripcion,
            this.abrev,
            this.Precio});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifario.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTarifario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarifario.EnableHeadersVisualStyles = false;
            this.dgvTarifario.Location = new System.Drawing.Point(3, 16);
            this.dgvTarifario.Name = "dgvTarifario";
            this.dgvTarifario.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTarifario.RowHeadersWidth = 25;
            this.dgvTarifario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarifario.Size = new System.Drawing.Size(609, 282);
            this.dgvTarifario.TabIndex = 0;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle6;
            this.Precio.HeaderText = "Costo";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // frmAgregarRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 487);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarRubro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Rubros:::...";
            this.Load += new System.EventHandler(this.frmAgregarRubro_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.dgvGlosa.ResumeLayout(false);
            this.dgvGlosa.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Button BtnGrabar;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTarifario;
        internal System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cuenta_contable;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        internal System.Windows.Forms.TextBox txtDescuento;
        internal System.Windows.Forms.Label Descuento;
        internal System.Windows.Forms.GroupBox dgvGlosa;
        internal System.Windows.Forms.TextBox txtGlosaPorRubro;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtAl;
        internal System.Windows.Forms.TextBox txtDel;
    }
}