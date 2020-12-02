namespace Payroll
{
    partial class MainMenuForm
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
            this.employeesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.payrollBtn = new System.Windows.Forms.Button();
            this.summaryReportBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesBtn
            // 
            this.employeesBtn.Location = new System.Drawing.Point(170, 97);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(171, 43);
            this.employeesBtn.TabIndex = 0;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(114, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payroll System";
            // 
            // payrollBtn
            // 
            this.payrollBtn.Location = new System.Drawing.Point(170, 146);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.Size = new System.Drawing.Size(171, 43);
            this.payrollBtn.TabIndex = 2;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.UseVisualStyleBackColor = true;
            // 
            // summaryReportBtn
            // 
            this.summaryReportBtn.Location = new System.Drawing.Point(170, 195);
            this.summaryReportBtn.Name = "summaryReportBtn";
            this.summaryReportBtn.Size = new System.Drawing.Size(171, 43);
            this.summaryReportBtn.TabIndex = 3;
            this.summaryReportBtn.Text = "Summary Report";
            this.summaryReportBtn.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(170, 244);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(171, 43);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Logout";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AcceptButton = this.employeesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Payroll.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.logOutBtn;
            this.ClientSize = new System.Drawing.Size(508, 337);
            this.ControlBox = false;
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.summaryReportBtn);
            this.Controls.Add(this.payrollBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button payrollBtn;
        private System.Windows.Forms.Button summaryReportBtn;
        private System.Windows.Forms.Button logOutBtn;
    }
}