namespace GUI_Tesoreria.DGAI
{
    partial class frmPosibleResumen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosibleResumen));
            this.dgvAsigna = new System.Windows.Forms.DataGridView();
            this.DNI_RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsigna
            // 
            this.dgvAsigna.AllowUserToAddRows = false;
            this.dgvAsigna.AllowUserToDeleteRows = false;
            this.dgvAsigna.AllowUserToResizeColumns = false;
            this.dgvAsigna.AllowUserToResizeRows = false;
            this.dgvAsigna.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsigna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsigna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI_RUC,
            this.RAZON_SOCIAL,
            this.MONTO});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsigna.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAsigna.Location = new System.Drawing.Point(12, 12);
            this.dgvAsigna.Name = "dgvAsigna";
            this.dgvAsigna.RowHeadersVisible = false;
            this.dgvAsigna.RowHeadersWidth = 10;
            this.dgvAsigna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAsigna.Size = new System.Drawing.Size(601, 359);
            this.dgvAsigna.TabIndex = 5;
            // 
            // DNI_RUC
            // 
            this.DNI_RUC.DataPropertyName = "DNI_RUC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.DNI_RUC.DefaultCellStyle = dataGridViewCellStyle2;
            this.DNI_RUC.HeaderText = "DNI_RUC";
            this.DNI_RUC.Name = "DNI_RUC";
            this.DNI_RUC.Width = 150;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.RAZON_SOCIAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.RAZON_SOCIAL.HeaderText = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.Width = 250;
            // 
            // MONTO
            // 
            this.MONTO.DataPropertyName = "MONTO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle4;
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(541, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 58);
            this.button1.TabIndex = 123;
            this.button1.Text = "&Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPosibleResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAsigna);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPosibleResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPosibleResumen";
            this.Load += new System.EventHandler(this.frmPosibleResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvAsigna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        protected System.Windows.Forms.Button button1;
    }
}