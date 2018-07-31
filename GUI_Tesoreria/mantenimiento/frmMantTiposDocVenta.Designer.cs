namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantTiposDocVenta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTipDocVentas = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoImpre = new System.Windows.Forms.CheckBox();
            this.chkReqIgv = new System.Windows.Forms.CheckBox();
            this.chkReqRuc = new System.Windows.Forms.CheckBox();
            this.chkComprobante = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipDocVentas)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(739, 65);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(895, 65);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(583, 65);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(817, 65);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(661, 65);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(973, 65);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvTipDocVentas);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 214);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            // 
            // dgvTipDocVentas
            // 
            this.dgvTipDocVentas.AllowUserToAddRows = false;
            this.dgvTipDocVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipDocVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipDocVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipDocVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipDocVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipDocVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipDocVentas.EnableHeadersVisualStyles = false;
            this.dgvTipDocVentas.Location = new System.Drawing.Point(3, 16);
            this.dgvTipDocVentas.Name = "dgvTipDocVentas";
            this.dgvTipDocVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipDocVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipDocVentas.RowHeadersWidth = 25;
            this.dgvTipDocVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipDocVentas.Size = new System.Drawing.Size(1046, 195);
            this.dgvTipDocVentas.TabIndex = 0;
            this.dgvTipDocVentas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipDocVentas_CellEnter);
            this.dgvTipDocVentas.Click += new System.EventHandler(this.dgvTipDocVentas_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Cod_TipoDocVenta";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Desc_TipoDocVenta";
            this.Column1.HeaderText = "Nombres";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Flag_Comprob";
            this.Column3.FalseValue = "0";
            this.Column3.HeaderText = "Comprobante";
            this.Column3.IndeterminateValue = "0";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.TrueValue = "1";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Flag_Ruc";
            this.Column4.FalseValue = "0";
            this.Column4.HeaderText = "Requiere RUC";
            this.Column4.IndeterminateValue = "0";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.TrueValue = "1";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "flag_impuesto";
            this.Column5.FalseValue = "0";
            this.Column5.HeaderText = "Requiere IGV";
            this.Column5.IndeterminateValue = "0";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.TrueValue = "1";
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "flag_autoimpresion";
            this.Column6.FalseValue = "0";
            this.Column6.HeaderText = "Auto Impresion";
            this.Column6.IndeterminateValue = "0";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.TrueValue = "1";
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nro_serie_ult";
            this.Column7.HeaderText = "Breviatura";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "nro_comprobante_ult";
            this.Column9.HeaderText = "Nro Comprobante";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.chkAutoImpre);
            this.GroupBox1.Controls.Add(this.chkReqIgv);
            this.GroupBox1.Controls.Add(this.chkReqRuc);
            this.GroupBox1.Controls.Add(this.chkComprobante);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtNroComprobante);
            this.GroupBox1.Controls.Add(this.txtAbreviatura);
            this.GroupBox1.Controls.Add(this.txtNombre);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(561, 90);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // chkAutoImpre
            // 
            this.chkAutoImpre.AutoSize = true;
            this.chkAutoImpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoImpre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkAutoImpre.Location = new System.Drawing.Point(375, 62);
            this.chkAutoImpre.Name = "chkAutoImpre";
            this.chkAutoImpre.Size = new System.Drawing.Size(122, 19);
            this.chkAutoImpre.TabIndex = 7;
            this.chkAutoImpre.Text = "Auto Impresion";
            this.chkAutoImpre.UseVisualStyleBackColor = true;
            // 
            // chkReqIgv
            // 
            this.chkReqIgv.AutoSize = true;
            this.chkReqIgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReqIgv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkReqIgv.Location = new System.Drawing.Point(258, 62);
            this.chkReqIgv.Name = "chkReqIgv";
            this.chkReqIgv.Size = new System.Drawing.Size(111, 19);
            this.chkReqIgv.TabIndex = 6;
            this.chkReqIgv.Text = "Requiere IGV";
            this.chkReqIgv.UseVisualStyleBackColor = true;
            // 
            // chkReqRuc
            // 
            this.chkReqRuc.AutoSize = true;
            this.chkReqRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReqRuc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkReqRuc.Location = new System.Drawing.Point(134, 62);
            this.chkReqRuc.Name = "chkReqRuc";
            this.chkReqRuc.Size = new System.Drawing.Size(118, 19);
            this.chkReqRuc.TabIndex = 5;
            this.chkReqRuc.Text = "Requiere RUC";
            this.chkReqRuc.UseVisualStyleBackColor = true;
            // 
            // chkComprobante
            // 
            this.chkComprobante.AutoSize = true;
            this.chkComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComprobante.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkComprobante.Location = new System.Drawing.Point(16, 62);
            this.chkComprobante.Name = "chkComprobante";
            this.chkComprobante.Size = new System.Drawing.Size(112, 19);
            this.chkComprobante.TabIndex = 4;
            this.chkComprobante.Text = "Comprobante";
            this.chkComprobante.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(431, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro Comprobante";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(343, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abreviatura";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(13, 17);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(52, 15);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "Codigo";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroComprobante.Location = new System.Drawing.Point(434, 35);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(117, 21);
            this.txtNroComprobante.TabIndex = 3;
            this.txtNroComprobante.Text = "0000000";
            this.txtNroComprobante.Visible = false;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbreviatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviatura.Location = new System.Drawing.Point(345, 35);
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(84, 21);
            this.txtAbreviatura.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(92, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(16, 35);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 21);
            this.txtId.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(270, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(558, 36);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "MANTENIMIENTO - DOCUMENTOS DE INGRESO";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMantTiposDocVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 367);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMantTiposDocVenta";
            this.Text = "...:::Mantenimiento Tipo de Documento de Venta:::...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMantTiposDocVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmMantTiposDocVenta_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.LblTitulo, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipDocVentas)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTipDocVentas;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkAutoImpre;
        private System.Windows.Forms.CheckBox chkReqIgv;
        private System.Windows.Forms.CheckBox chkReqRuc;
        private System.Windows.Forms.CheckBox chkComprobante;
        internal System.Windows.Forms.TextBox txtAbreviatura;
        internal System.Windows.Forms.TextBox txtNroComprobante;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}