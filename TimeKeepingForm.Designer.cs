namespace Payroll
{
    partial class TimeKeepingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.currentDateTimeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeInBtn = new System.Windows.Forms.Button();
            this.timeOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date / Time:";
            // 
            // currentDateTimeLbl
            // 
            this.currentDateTimeLbl.AutoSize = true;
            this.currentDateTimeLbl.Location = new System.Drawing.Point(208, 9);
            this.currentDateTimeLbl.Name = "currentDateTimeLbl";
            this.currentDateTimeLbl.Size = new System.Drawing.Size(139, 20);
            this.currentDateTimeLbl.TabIndex = 1;
            this.currentDateTimeLbl.Text = "<currentdatetime>";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeInBtn
            // 
            this.timeInBtn.Location = new System.Drawing.Point(146, 67);
            this.timeInBtn.Name = "timeInBtn";
            this.timeInBtn.Size = new System.Drawing.Size(163, 55);
            this.timeInBtn.TabIndex = 2;
            this.timeInBtn.Text = "Time In";
            this.timeInBtn.UseVisualStyleBackColor = true;
            this.timeInBtn.Click += new System.EventHandler(this.timeInBtn_Click);
            // 
            // timeOutBtn
            // 
            this.timeOutBtn.Location = new System.Drawing.Point(146, 67);
            this.timeOutBtn.Name = "timeOutBtn";
            this.timeOutBtn.Size = new System.Drawing.Size(163, 55);
            this.timeOutBtn.TabIndex = 3;
            this.timeOutBtn.Text = "Time Out";
            this.timeOutBtn.UseVisualStyleBackColor = true;
            this.timeOutBtn.Click += new System.EventHandler(this.timeOutBtn_Click);
            // 
            // TimeKeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 188);
            this.Controls.Add(this.timeOutBtn);
            this.Controls.Add(this.timeInBtn);
            this.Controls.Add(this.currentDateTimeLbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeKeepingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Keeping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeKeepingForm_FormClosed);
            this.Load += new System.EventHandler(this.TimeKeepingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentDateTimeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button timeInBtn;
        private System.Windows.Forms.Button timeOutBtn;
    }
}