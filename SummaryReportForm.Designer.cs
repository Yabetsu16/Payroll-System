namespace Payroll
{
    partial class SummaryReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.monthlyPayrollReportBtn = new System.Windows.Forms.Button();
            this.anuallyPayrollReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1059, 580);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // monthlyPayrollReportBtn
            // 
            this.monthlyPayrollReportBtn.Location = new System.Drawing.Point(12, 37);
            this.monthlyPayrollReportBtn.Name = "monthlyPayrollReportBtn";
            this.monthlyPayrollReportBtn.Size = new System.Drawing.Size(179, 28);
            this.monthlyPayrollReportBtn.TabIndex = 1;
            this.monthlyPayrollReportBtn.Text = "Monthly Payroll Report";
            this.monthlyPayrollReportBtn.UseVisualStyleBackColor = true;
            this.monthlyPayrollReportBtn.Click += new System.EventHandler(this.monthlyPayrollReportBtn_Click);
            // 
            // anuallyPayrollReportBtn
            // 
            this.anuallyPayrollReportBtn.Location = new System.Drawing.Point(12, 71);
            this.anuallyPayrollReportBtn.Name = "anuallyPayrollReportBtn";
            this.anuallyPayrollReportBtn.Size = new System.Drawing.Size(179, 28);
            this.anuallyPayrollReportBtn.TabIndex = 2;
            this.anuallyPayrollReportBtn.Text = "Annuallly Payroll Report";
            this.anuallyPayrollReportBtn.UseVisualStyleBackColor = true;
            this.anuallyPayrollReportBtn.Click += new System.EventHandler(this.anuallyPayrollReportBtn_Click);
            // 
            // SummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 580);
            this.Controls.Add(this.anuallyPayrollReportBtn);
            this.Controls.Add(this.monthlyPayrollReportBtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "SummaryReportForm";
            this.Text = "SummaryReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button monthlyPayrollReportBtn;
        private System.Windows.Forms.Button anuallyPayrollReportBtn;
    }
}