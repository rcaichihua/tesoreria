namespace GUI_Tesoreria
{
    partial class frmReporte
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
            this.crvReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReportes
            // 
            this.crvReportes.ActiveViewIndex = -1;
            this.crvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReportes.Location = new System.Drawing.Point(0, 0);
            this.crvReportes.Margin = new System.Windows.Forms.Padding(2);
            this.crvReportes.Name = "crvReportes";
            this.crvReportes.Size = new System.Drawing.Size(740, 499);
            this.crvReportes.TabIndex = 0;
            this.crvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 499);
            this.Controls.Add(this.crvReportes);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Reportes:::...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportes;



    }
}