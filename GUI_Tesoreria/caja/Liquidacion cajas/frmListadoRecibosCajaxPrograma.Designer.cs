namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmListadoRecibosCajaxPrograma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListadoRecibos = new System.Windows.Forms.DataGridView();
            this.IdReciboCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nrorecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeCambioIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNroLiquidaciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalIngresoCaja = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRecibos)).BeginInit();
            this.GBOpciones.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvListadoRecibos);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 278);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de recibos de caja";
            // 
            // dgvListadoRecibos
            // 
            this.dgvListadoRecibos.AllowUserToAddRows = false;
            this.dgvListadoRecibos.AllowUserToDeleteRows = false;
            this.dgvListadoRecibos.AllowUserToResizeColumns = false;
            this.dgvListadoRecibos.AllowUserToResizeRows = false;
            this.dgvListadoRecibos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReciboCaja,
            this.Nrorecibo,
            this.receptorNombre,
            this.descripcionModalidad,
            this.moneda,
            this.importeIngreso,
            this.tipoCambio,
            this.importeCambioIngreso,
            this.totalDocumento,
            this.glosa,
            this.ESTADO});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoRecibos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListadoRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoRecibos.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListadoRecibos.Location = new System.Drawing.Point(3, 17);
            this.dgvListadoRecibos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoRecibos.Name = "dgvListadoRecibos";
            this.dgvListadoRecibos.ReadOnly = true;
            this.dgvListadoRecibos.RowHeadersVisible = false;
            this.dgvListadoRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoRecibos.Size = new System.Drawing.Size(917, 258);
            this.dgvListadoRecibos.TabIndex = 0;
            this.dgvListadoRecibos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListadoRecibos_CellFormatting);
            // 
            // IdReciboCaja
            // 
            this.IdReciboCaja.DataPropertyName = "IdReciboCaja";
            this.IdReciboCaja.HeaderText = "IdReciboCaja";
            this.IdReciboCaja.Name = "IdReciboCaja";
            this.IdReciboCaja.ReadOnly = true;
            this.IdReciboCaja.Visible = false;
            // 
            // Nrorecibo
            // 
            this.Nrorecibo.DataPropertyName = "Nrorecibo";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nrorecibo.DefaultCellStyle = dataGridViewCellStyle13;
            this.Nrorecibo.HeaderText = "Nº RECIBO";
            this.Nrorecibo.Name = "Nrorecibo";
            this.Nrorecibo.ReadOnly = true;
            this.Nrorecibo.Width = 80;
            // 
            // receptorNombre
            // 
            this.receptorNombre.DataPropertyName = "receptorNombre";
            this.receptorNombre.HeaderText = "NOMBRE";
            this.receptorNombre.Name = "receptorNombre";
            this.receptorNombre.ReadOnly = true;
            this.receptorNombre.Width = 180;
            // 
            // descripcionModalidad
            // 
            this.descripcionModalidad.DataPropertyName = "descripcionModalidad";
            this.descripcionModalidad.HeaderText = "MODALIDAD";
            this.descripcionModalidad.Name = "descripcionModalidad";
            this.descripcionModalidad.ReadOnly = true;
            this.descripcionModalidad.Width = 80;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "MONEDA";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 60;
            // 
            // importeIngreso
            // 
            this.importeIngreso.DataPropertyName = "importeIngreso";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            this.importeIngreso.DefaultCellStyle = dataGridViewCellStyle14;
            this.importeIngreso.HeaderText = "INGRESO REAL";
            this.importeIngreso.Name = "importeIngreso";
            this.importeIngreso.ReadOnly = true;
            this.importeIngreso.Width = 80;
            // 
            // tipoCambio
            // 
            this.tipoCambio.DataPropertyName = "tipoCambio";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N3";
            this.tipoCambio.DefaultCellStyle = dataGridViewCellStyle15;
            this.tipoCambio.HeaderText = "T.C.";
            this.tipoCambio.Name = "tipoCambio";
            this.tipoCambio.ReadOnly = true;
            this.tipoCambio.Width = 50;
            // 
            // importeCambioIngreso
            // 
            this.importeCambioIngreso.DataPropertyName = "importeCambioIngreso";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            this.importeCambioIngreso.DefaultCellStyle = dataGridViewCellStyle16;
            this.importeCambioIngreso.HeaderText = "TOTAL CAMBIO";
            this.importeCambioIngreso.Name = "importeCambioIngreso";
            this.importeCambioIngreso.ReadOnly = true;
            this.importeCambioIngreso.Width = 80;
            // 
            // totalDocumento
            // 
            this.totalDocumento.DataPropertyName = "totalDocumento";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            this.totalDocumento.DefaultCellStyle = dataGridViewCellStyle17;
            this.totalDocumento.HeaderText = "TOTAL";
            this.totalDocumento.Name = "totalDocumento";
            this.totalDocumento.ReadOnly = true;
            this.totalDocumento.Width = 80;
            // 
            // glosa
            // 
            this.glosa.DataPropertyName = "glosa";
            this.glosa.HeaderText = "GLOSA";
            this.glosa.Name = "glosa";
            this.glosa.ReadOnly = true;
            this.glosa.Width = 200;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btnImprimir);
            this.GBOpciones.Controls.Add(this.btnEditar);
            this.GBOpciones.Controls.Add(this.btnCancelar);
            this.GBOpciones.Controls.Add(this.btnAnular);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(941, 12);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(107, 329);
            this.GBOpciones.TabIndex = 148;
            this.GBOpciones.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Navy;
            this.btnImprimir.Image = global::GUI_Tesoreria.Properties.Resources.imprimirD;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(8, 75);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 57);
            this.btnImprimir.TabIndex = 148;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Navy;
            this.btnEditar.Image = global::GUI_Tesoreria.Properties.Resources.editarD;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(8, 138);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 57);
            this.btnEditar.TabIndex = 148;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(8, 266);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 57);
            this.btnCancelar.TabIndex = 148;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.Navy;
            this.btnAnular.Image = global::GUI_Tesoreria.Properties.Resources.eliminarV;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular.Location = new System.Drawing.Point(8, 17);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(90, 52);
            this.btnAnular.TabIndex = 148;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.lblNroLiquidaciones);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.txtTotalIngresoCaja);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox3.Location = new System.Drawing.Point(12, 296);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(923, 45);
            this.GroupBox3.TabIndex = 149;
            this.GroupBox3.TabStop = false;
            // 
            // lblNroLiquidaciones
            // 
            this.lblNroLiquidaciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLiquidaciones.ForeColor = System.Drawing.Color.Navy;
            this.lblNroLiquidaciones.Location = new System.Drawing.Point(162, 12);
            this.lblNroLiquidaciones.Name = "lblNroLiquidaciones";
            this.lblNroLiquidaciones.Size = new System.Drawing.Size(67, 15);
            this.lblNroLiquidaciones.TabIndex = 120;
            this.lblNroLiquidaciones.Text = "0";
            this.lblNroLiquidaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Cantidad de documentos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(533, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalIngresoCaja
            // 
            this.txtTotalIngresoCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalIngresoCaja.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalIngresoCaja.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalIngresoCaja.Location = new System.Drawing.Point(575, 10);
            this.txtTotalIngresoCaja.MaxLength = 4000;
            this.txtTotalIngresoCaja.Name = "txtTotalIngresoCaja";
            this.txtTotalIngresoCaja.ReadOnly = true;
            this.txtTotalIngresoCaja.Size = new System.Drawing.Size(132, 21);
            this.txtTotalIngresoCaja.TabIndex = 89;
            this.txtTotalIngresoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmListadoRecibosCajaxPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 350);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoRecibosCajaxPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listados de Recibos emitidos por Programa:::...";
            this.Load += new System.EventHandler(this.frmListadoRecibosCajaxPrograma_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRecibos)).EndInit();
            this.GBOpciones.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvListadoRecibos;
        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReciboCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrorecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeCambioIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn glosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblNroLiquidaciones;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTotalIngresoCaja;
    }
}