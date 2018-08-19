namespace BeHerktSolutions.ReportsViews
{
    partial class ReportView
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
            this.CrReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrReportViewer
            // 
            this.CrReportViewer.ActiveViewIndex = -1;
            this.CrReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CrReportViewer.Name = "CrReportViewer";
            this.CrReportViewer.Size = new System.Drawing.Size(800, 450);
            this.CrReportViewer.TabIndex = 0;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrReportViewer);
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrReportViewer;
    }
}