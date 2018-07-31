namespace GUI_Tesoreria.cementerio
{
    partial class frmReporteIngresosInventarios
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.crvReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.crvReportes);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1021, 674);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // crvReportes
            // 
            this.crvReportes.ActiveViewIndex = -1;
            this.crvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReportes.Location = new System.Drawing.Point(3, 16);
            this.crvReportes.Name = "crvReportes";
            this.crvReportes.Size = new System.Drawing.Size(1015, 655);
            this.crvReportes.TabIndex = 0;
            this.crvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteIngresosInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 698);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Name = "frmReporteIngresosInventarios";
            this.Text = "frmReporteIngresosInventarios";
            this.Load += new System.EventHandler(this.frmReporteIngresosInventarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportes;
    }
}