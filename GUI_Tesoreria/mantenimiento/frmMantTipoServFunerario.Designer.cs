﻿namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMantTipoServFunerario
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
            this.dgvTipoServFun = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServFun)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(223, 375);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(431, 375);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(15, 375);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(327, 375);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(119, 375);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(535, 375);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvTipoServFun);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(16, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(616, 175);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            // 
            // dgvTipoServFun
            // 
            this.dgvTipoServFun.AllowUserToAddRows = false;
            this.dgvTipoServFun.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoServFun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoServFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServFun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoServFun.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipoServFun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoServFun.EnableHeadersVisualStyles = false;
            this.dgvTipoServFun.Location = new System.Drawing.Point(4, 19);
            this.dgvTipoServFun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTipoServFun.Name = "dgvTipoServFun";
            this.dgvTipoServFun.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoServFun.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipoServFun.RowHeadersWidth = 25;
            this.dgvTipoServFun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoServFun.Size = new System.Drawing.Size(608, 152);
            this.dgvTipoServFun.TabIndex = 0;
            this.dgvTipoServFun.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoServFun_CellEnter);
            this.dgvTipoServFun.Click += new System.EventHandler(this.dgvTipoServFun_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "intServFunId";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "VarServFunDescripcion";
            this.Column1.HeaderText = "Nombres";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.txtNombre);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox1.Location = new System.Drawing.Point(16, 71);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(616, 114);
            this.GroupBox1.TabIndex = 94;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(17, 60);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(170, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Nombre Tipo servicio";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(139, 28);
            this.lbl12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(62, 18);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "Codigo";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(216, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(363, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(216, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(92, 24);
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
            this.LblTitulo.Location = new System.Drawing.Point(15, 11);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(617, 44);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "MANTENIMIENTO - SERVICIOS FUNERARIOS";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMantTipoServFunerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 476);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMantTipoServFunerario";
            this.Text = "...:::Mantenimiento de Tipo de servicios Funerarios:::...";
            this.Load += new System.EventHandler(this.frmMantTipoServFunerario_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServFun)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTipoServFun;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Label LblTitulo;
    }
}