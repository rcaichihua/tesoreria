namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantCementerio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantCementerio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCementerio = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Distrito = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDireccionCementerio = new System.Windows.Forms.TextBox();
            this.txtDepartamentoCementerio = new System.Windows.Forms.TextBox();
            this.txtProvinciaCementerio = new System.Windows.Forms.TextBox();
            this.txtDistritoCementerio = new System.Windows.Forms.TextBox();
            this.txtDescripcionCementerio = new System.Windows.Forms.TextBox();
            this.txtCodigoCementerio = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCementerio)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(236, 459);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 73);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(392, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 73);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(80, 459);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 73);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(314, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 73);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(158, 459);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 73);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(470, 459);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 73);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvCementerio);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 192);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            // 
            // dgvCementerio
            // 
            this.dgvCementerio.AllowUserToAddRows = false;
            this.dgvCementerio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCementerio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCementerio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCementerio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCementerio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCementerio.EnableHeadersVisualStyles = false;
            this.dgvCementerio.Location = new System.Drawing.Point(3, 16);
            this.dgvCementerio.Name = "dgvCementerio";
            this.dgvCementerio.ReadOnly = true;
            this.dgvCementerio.RowHeadersWidth = 25;
            this.dgvCementerio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCementerio.Size = new System.Drawing.Size(594, 173);
            this.dgvCementerio.TabIndex = 0;
            this.dgvCementerio.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCementerio_CellEnter);
            this.dgvCementerio.Click += new System.EventHandler(this.dgvCementerio_Click_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "intCeId";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "varCeNombre";
            this.Column2.HeaderText = "nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "varCeDistrito";
            this.Column3.HeaderText = "distrito";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "varCeProvincia";
            this.Column4.HeaderText = "provincia";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "varCeDepartamento";
            this.Column5.HeaderText = "departamento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "varCeDireccion";
            this.Column6.HeaderText = "direccion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Distrito);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtDireccionCementerio);
            this.GroupBox1.Controls.Add(this.txtDepartamentoCementerio);
            this.GroupBox1.Controls.Add(this.txtProvinciaCementerio);
            this.GroupBox1.Controls.Add(this.txtDistritoCementerio);
            this.GroupBox1.Controls.Add(this.txtDescripcionCementerio);
            this.GroupBox1.Controls.Add(this.txtCodigoCementerio);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(600, 207);
            this.GroupBox1.TabIndex = 90;
            this.GroupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(88, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(58, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Departamento";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label4.Location = new System.Drawing.Point(90, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 15);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Provincia";
            // 
            // Distrito
            // 
            this.Distrito.AutoSize = true;
            this.Distrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distrito.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Distrito.Location = new System.Drawing.Point(103, 79);
            this.Distrito.Name = "Distrito";
            this.Distrito.Size = new System.Drawing.Size(53, 15);
            this.Distrito.TabIndex = 2;
            this.Distrito.Text = "Distrito";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(22, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Nombre cementerio";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label1.Location = new System.Drawing.Point(104, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Codigo";
            // 
            // txtDireccionCementerio
            // 
            this.txtDireccionCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCementerio.Location = new System.Drawing.Point(162, 157);
            this.txtDireccionCementerio.Multiline = true;
            this.txtDireccionCementerio.Name = "txtDireccionCementerio";
            this.txtDireccionCementerio.Size = new System.Drawing.Size(426, 44);
            this.txtDireccionCementerio.TabIndex = 5;
            // 
            // txtDepartamentoCementerio
            // 
            this.txtDepartamentoCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamentoCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamentoCementerio.Location = new System.Drawing.Point(162, 130);
            this.txtDepartamentoCementerio.Name = "txtDepartamentoCementerio";
            this.txtDepartamentoCementerio.Size = new System.Drawing.Size(151, 21);
            this.txtDepartamentoCementerio.TabIndex = 4;
            // 
            // txtProvinciaCementerio
            // 
            this.txtProvinciaCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProvinciaCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvinciaCementerio.Location = new System.Drawing.Point(162, 103);
            this.txtProvinciaCementerio.Name = "txtProvinciaCementerio";
            this.txtProvinciaCementerio.Size = new System.Drawing.Size(151, 21);
            this.txtProvinciaCementerio.TabIndex = 3;
            // 
            // txtDistritoCementerio
            // 
            this.txtDistritoCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistritoCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistritoCementerio.Location = new System.Drawing.Point(162, 76);
            this.txtDistritoCementerio.Name = "txtDistritoCementerio";
            this.txtDistritoCementerio.Size = new System.Drawing.Size(151, 21);
            this.txtDistritoCementerio.TabIndex = 2;
            // 
            // txtDescripcionCementerio
            // 
            this.txtDescripcionCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCementerio.Location = new System.Drawing.Point(162, 49);
            this.txtDescripcionCementerio.Name = "txtDescripcionCementerio";
            this.txtDescripcionCementerio.Size = new System.Drawing.Size(426, 21);
            this.txtDescripcionCementerio.TabIndex = 1;
            // 
            // txtCodigoCementerio
            // 
            this.txtCodigoCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCementerio.Location = new System.Drawing.Point(162, 23);
            this.txtCodigoCementerio.MaxLength = 4;
            this.txtCodigoCementerio.Name = "txtCodigoCementerio";
            this.txtCodigoCementerio.ReadOnly = true;
            this.txtCodigoCementerio.Size = new System.Drawing.Size(47, 21);
            this.txtCodigoCementerio.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(0, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(622, 36);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "MANTENIMIENTO - CEMENTERIO";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMantCementerio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 540);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantCementerio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Mantenimiento cementerios:::...";
            this.Load += new System.EventHandler(this.frmMantCementerio_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCementerio)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCementerio;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Distrito;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtProvinciaCementerio;
        internal System.Windows.Forms.TextBox txtDistritoCementerio;
        internal System.Windows.Forms.TextBox txtDescripcionCementerio;
        internal System.Windows.Forms.TextBox txtCodigoCementerio;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtDireccionCementerio;
        internal System.Windows.Forms.TextBox txtDepartamentoCementerio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.Label LblTitulo;
    }
}