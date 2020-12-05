namespace Payroll
{
    partial class PayrollForm
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
            this.editWorkPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paySlipNum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.thirtiethRb = new System.Windows.Forms.RadioButton();
            this.fifteenthRb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalDeductionLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loanNum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.deductionRemarksTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.otherDeductionNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.philhealthNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pagibigNum = new System.Windows.Forms.NumericUpDown();
            this.sssNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.taxNum = new System.Windows.Forms.NumericUpDown();
            this.dayNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.allAbsencesNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.netNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grossNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.closeEditPayrollPanel = new System.Windows.Forms.Button();
            this.editPayrollBtn = new System.Windows.Forms.Button();
            this.editEmployeeLbl = new System.Windows.Forms.Label();
            this.workDgv = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editWorkPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paySlipNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherDeductionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.philhealthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagibigNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sssNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAbsencesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // editWorkPanel
            // 
            this.editWorkPanel.AutoScroll = true;
            this.editWorkPanel.Controls.Add(this.panel4);
            this.editWorkPanel.Controls.Add(this.groupBox1);
            this.editWorkPanel.Controls.Add(this.panel1);
            this.editWorkPanel.Controls.Add(this.editEmployeeLbl);
            this.editWorkPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.editWorkPanel.Location = new System.Drawing.Point(981, 0);
            this.editWorkPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editWorkPanel.Name = "editWorkPanel";
            this.editWorkPanel.Size = new System.Drawing.Size(308, 636);
            this.editWorkPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.paySlipNum);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.thirtiethRb);
            this.panel1.Controls.Add(this.fifteenthRb);
            this.panel1.Controls.Add(this.dayNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.allAbsencesNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.netNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.grossNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 232);
            this.panel1.TabIndex = 1;
            // 
            // paySlipNum
            // 
            this.paySlipNum.DecimalPlaces = 2;
            this.paySlipNum.Enabled = false;
            this.paySlipNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.paySlipNum.Location = new System.Drawing.Point(136, 196);
            this.paySlipNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.paySlipNum.Name = "paySlipNum";
            this.paySlipNum.ReadOnly = true;
            this.paySlipNum.Size = new System.Drawing.Size(143, 26);
            this.paySlipNum.TabIndex = 24;
            this.paySlipNum.ThousandsSeparator = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Pay Slip";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Cut-of Period";
            // 
            // thirtiethRb
            // 
            this.thirtiethRb.AutoSize = true;
            this.thirtiethRb.Location = new System.Drawing.Point(163, 166);
            this.thirtiethRb.Name = "thirtiethRb";
            this.thirtiethRb.Size = new System.Drawing.Size(59, 24);
            this.thirtiethRb.TabIndex = 16;
            this.thirtiethRb.TabStop = true;
            this.thirtiethRb.Text = "30th";
            this.thirtiethRb.UseVisualStyleBackColor = true;
            this.thirtiethRb.CheckedChanged += new System.EventHandler(this.thirtiethMonthRb_CheckedChanged);
            // 
            // fifteenthRb
            // 
            this.fifteenthRb.AutoSize = true;
            this.fifteenthRb.Checked = true;
            this.fifteenthRb.Location = new System.Drawing.Point(163, 136);
            this.fifteenthRb.Name = "fifteenthRb";
            this.fifteenthRb.Size = new System.Drawing.Size(59, 24);
            this.fifteenthRb.TabIndex = 15;
            this.fifteenthRb.TabStop = true;
            this.fifteenthRb.Text = "15th";
            this.fifteenthRb.UseVisualStyleBackColor = true;
            this.fifteenthRb.CheckedChanged += new System.EventHandler(this.fifteenthMonthRb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalDeductionLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loanNum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.deductionRemarksTb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.otherDeductionNum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.philhealthNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pagibigNum);
            this.groupBox1.Controls.Add(this.sssNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.taxNum);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 377);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deductions";
            // 
            // totalDeductionLbl
            // 
            this.totalDeductionLbl.AutoSize = true;
            this.totalDeductionLbl.Location = new System.Drawing.Point(159, 32);
            this.totalDeductionLbl.Name = "totalDeductionLbl";
            this.totalDeductionLbl.Size = new System.Drawing.Size(40, 20);
            this.totalDeductionLbl.TabIndex = 26;
            this.totalDeductionLbl.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Deduction:";
            // 
            // loanNum
            // 
            this.loanNum.DecimalPlaces = 2;
            this.loanNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.loanNum.Location = new System.Drawing.Point(163, 183);
            this.loanNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.loanNum.Name = "loanNum";
            this.loanNum.Size = new System.Drawing.Size(116, 26);
            this.loanNum.TabIndex = 21;
            this.loanNum.ThousandsSeparator = true;
            this.loanNum.ValueChanged += new System.EventHandler(this.loanNum_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Loan";
            // 
            // deductionRemarksTb
            // 
            this.deductionRemarksTb.Location = new System.Drawing.Point(14, 279);
            this.deductionRemarksTb.Multiline = true;
            this.deductionRemarksTb.Name = "deductionRemarksTb";
            this.deductionRemarksTb.Size = new System.Drawing.Size(265, 90);
            this.deductionRemarksTb.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Remarks";
            // 
            // otherDeductionNum
            // 
            this.otherDeductionNum.DecimalPlaces = 2;
            this.otherDeductionNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.otherDeductionNum.Location = new System.Drawing.Point(163, 215);
            this.otherDeductionNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.otherDeductionNum.Name = "otherDeductionNum";
            this.otherDeductionNum.Size = new System.Drawing.Size(116, 26);
            this.otherDeductionNum.TabIndex = 17;
            this.otherDeductionNum.ThousandsSeparator = true;
            this.otherDeductionNum.ValueChanged += new System.EventHandler(this.otherDeductionNum_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Other Deduction";
            // 
            // philhealthNum
            // 
            this.philhealthNum.DecimalPlaces = 2;
            this.philhealthNum.Enabled = false;
            this.philhealthNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.philhealthNum.Location = new System.Drawing.Point(163, 151);
            this.philhealthNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.philhealthNum.Name = "philhealthNum";
            this.philhealthNum.ReadOnly = true;
            this.philhealthNum.Size = new System.Drawing.Size(116, 26);
            this.philhealthNum.TabIndex = 15;
            this.philhealthNum.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pagibig";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Philhealth";
            // 
            // pagibigNum
            // 
            this.pagibigNum.DecimalPlaces = 2;
            this.pagibigNum.Enabled = false;
            this.pagibigNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pagibigNum.Location = new System.Drawing.Point(163, 119);
            this.pagibigNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.pagibigNum.Name = "pagibigNum";
            this.pagibigNum.ReadOnly = true;
            this.pagibigNum.Size = new System.Drawing.Size(116, 26);
            this.pagibigNum.TabIndex = 13;
            this.pagibigNum.ThousandsSeparator = true;
            // 
            // sssNum
            // 
            this.sssNum.DecimalPlaces = 2;
            this.sssNum.Enabled = false;
            this.sssNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sssNum.Location = new System.Drawing.Point(163, 87);
            this.sssNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.sssNum.Name = "sssNum";
            this.sssNum.ReadOnly = true;
            this.sssNum.Size = new System.Drawing.Size(116, 26);
            this.sssNum.TabIndex = 11;
            this.sssNum.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "SSS";
            // 
            // taxNum
            // 
            this.taxNum.DecimalPlaces = 2;
            this.taxNum.Enabled = false;
            this.taxNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.taxNum.Location = new System.Drawing.Point(163, 55);
            this.taxNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.taxNum.Name = "taxNum";
            this.taxNum.ReadOnly = true;
            this.taxNum.Size = new System.Drawing.Size(116, 26);
            this.taxNum.TabIndex = 9;
            this.taxNum.ThousandsSeparator = true;
            // 
            // dayNum
            // 
            this.dayNum.Location = new System.Drawing.Point(163, 72);
            this.dayNum.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.dayNum.Name = "dayNum";
            this.dayNum.Size = new System.Drawing.Size(116, 26);
            this.dayNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Days";
            // 
            // allAbsencesNum
            // 
            this.allAbsencesNum.Location = new System.Drawing.Point(163, 40);
            this.allAbsencesNum.Name = "allAbsencesNum";
            this.allAbsencesNum.Size = new System.Drawing.Size(116, 26);
            this.allAbsencesNum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "All. Absences";
            // 
            // netNum
            // 
            this.netNum.DecimalPlaces = 2;
            this.netNum.Enabled = false;
            this.netNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.netNum.Location = new System.Drawing.Point(163, 104);
            this.netNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.netNum.Name = "netNum";
            this.netNum.ReadOnly = true;
            this.netNum.Size = new System.Drawing.Size(116, 26);
            this.netNum.TabIndex = 3;
            this.netNum.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Net";
            // 
            // grossNum
            // 
            this.grossNum.DecimalPlaces = 2;
            this.grossNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.grossNum.Location = new System.Drawing.Point(163, 8);
            this.grossNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.grossNum.Name = "grossNum";
            this.grossNum.Size = new System.Drawing.Size(116, 26);
            this.grossNum.TabIndex = 1;
            this.grossNum.ThousandsSeparator = true;
            this.grossNum.ValueChanged += new System.EventHandler(this.grossNum_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gross";
            // 
            // closeEditPayrollPanel
            // 
            this.closeEditPayrollPanel.Location = new System.Drawing.Point(73, 22);
            this.closeEditPayrollPanel.Name = "closeEditPayrollPanel";
            this.closeEditPayrollPanel.Size = new System.Drawing.Size(75, 35);
            this.closeEditPayrollPanel.TabIndex = 5;
            this.closeEditPayrollPanel.Text = "Close";
            this.closeEditPayrollPanel.UseVisualStyleBackColor = true;
            this.closeEditPayrollPanel.Click += new System.EventHandler(this.closeEditPayrollPanel_Click);
            // 
            // editPayrollBtn
            // 
            this.editPayrollBtn.Location = new System.Drawing.Point(160, 22);
            this.editPayrollBtn.Name = "editPayrollBtn";
            this.editPayrollBtn.Size = new System.Drawing.Size(75, 35);
            this.editPayrollBtn.TabIndex = 3;
            this.editPayrollBtn.Text = "Edit";
            this.editPayrollBtn.UseVisualStyleBackColor = true;
            this.editPayrollBtn.Click += new System.EventHandler(this.editPayrollBtn_Click);
            // 
            // editEmployeeLbl
            // 
            this.editEmployeeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.editEmployeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeLbl.Location = new System.Drawing.Point(0, 0);
            this.editEmployeeLbl.Name = "editEmployeeLbl";
            this.editEmployeeLbl.Size = new System.Drawing.Size(291, 54);
            this.editEmployeeLbl.TabIndex = 0;
            this.editEmployeeLbl.Text = "Edit Employee Payroll";
            this.editEmployeeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workDgv
            // 
            this.workDgv.AllowUserToAddRows = false;
            this.workDgv.AllowUserToDeleteRows = false;
            this.workDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workDgv.Location = new System.Drawing.Point(0, 0);
            this.workDgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workDgv.Name = "workDgv";
            this.workDgv.ReadOnly = true;
            this.workDgv.Size = new System.Drawing.Size(981, 636);
            this.workDgv.TabIndex = 2;
            this.workDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workDgv_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Search Employee";
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(151, 8);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(467, 26);
            this.searchTb.TabIndex = 21;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchTb);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 46);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.workDgv);
            this.panel3.Controls.Add(this.editWorkPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1289, 636);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.editPayrollBtn);
            this.panel4.Controls.Add(this.closeEditPayrollPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 78);
            this.panel4.TabIndex = 6;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1289, 682);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PayrollForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayrollForm_FormClosed);
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            this.editWorkPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paySlipNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherDeductionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.philhealthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagibigNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sssNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAbsencesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editWorkPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox deductionRemarksTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown otherDeductionNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown philhealthNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown pagibigNum;
        private System.Windows.Forms.NumericUpDown sssNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown taxNum;
        private System.Windows.Forms.NumericUpDown dayNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown allAbsencesNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown netNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown grossNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeEditPayrollPanel;
        private System.Windows.Forms.Button editPayrollBtn;
        private System.Windows.Forms.Label editEmployeeLbl;
        private System.Windows.Forms.DataGridView workDgv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.NumericUpDown loanNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton thirtiethRb;
        private System.Windows.Forms.RadioButton fifteenthRb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown paySlipNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label totalDeductionLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}