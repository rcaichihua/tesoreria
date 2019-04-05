namespace GUI_Tesoreria
{
    partial class frmMuestraDatatable
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
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMuestra.Location = new System.Drawing.Point(0, 0);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.Size = new System.Drawing.Size(939, 563);
            this.dgvMuestra.TabIndex = 0;
            // 
            // frmMuestraDatatable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.Controls.Add(this.dgvMuestra);
            this.Name = "frmMuestraDatatable";
            this.Text = "frmMuestraDatatable";
            this.Load += new System.EventHandler(this.frmMuestraDatatable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestra;
    }
}