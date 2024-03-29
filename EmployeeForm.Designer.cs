﻿namespace Payroll
{
    partial class EmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeKeepingPanel = new System.Windows.Forms.Panel();
            this.nameTimeKeepingLbl = new System.Windows.Forms.Label();
            this.timeKeepingDgv = new System.Windows.Forms.DataGridView();
            this.closeTimeKeepingBtn = new System.Windows.Forms.Button();
            this.editEmployeePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.closeUpdatePanelBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.editJob = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editPasswordTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editUsernameTb = new System.Windows.Forms.TextBox();
            this.editFirstnameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.editLastnameTb = new System.Windows.Forms.TextBox();
            this.editTypeComB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addEmployeePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeAddPanelBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.jobTb = new System.Windows.Forms.TextBox();
            this.firstnameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnameTb = new System.Windows.Forms.TextBox();
            this.typeComB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.showAddPanelBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.timeKeepingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDgv)).BeginInit();
            this.editEmployeePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.addEmployeePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.timeKeepingPanel);
            this.panel1.Controls.Add(this.editEmployeePanel);
            this.panel1.Controls.Add(this.addEmployeePanel);
            this.panel1.Controls.Add(this.employeeDgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 576);
            this.panel1.TabIndex = 2;
            // 
            // timeKeepingPanel
            // 
            this.timeKeepingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeKeepingPanel.Controls.Add(this.nameTimeKeepingLbl);
            this.timeKeepingPanel.Controls.Add(this.timeKeepingDgv);
            this.timeKeepingPanel.Controls.Add(this.closeTimeKeepingBtn);
            this.timeKeepingPanel.Location = new System.Drawing.Point(362, 91);
            this.timeKeepingPanel.Name = "timeKeepingPanel";
            this.timeKeepingPanel.Size = new System.Drawing.Size(558, 395);
            this.timeKeepingPanel.TabIndex = 0;
            this.timeKeepingPanel.VisibleChanged += new System.EventHandler(this.timeKeepingPanel_VisibleChanged);
            // 
            // nameTimeKeepingLbl
            // 
            this.nameTimeKeepingLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameTimeKeepingLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTimeKeepingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTimeKeepingLbl.Location = new System.Drawing.Point(0, 0);
            this.nameTimeKeepingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameTimeKeepingLbl.Name = "nameTimeKeepingLbl";
            this.nameTimeKeepingLbl.Size = new System.Drawing.Size(558, 48);
            this.nameTimeKeepingLbl.TabIndex = 20;
            this.nameTimeKeepingLbl.Text = "<name>";
            this.nameTimeKeepingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeKeepingDgv
            // 
            this.timeKeepingDgv.AllowUserToAddRows = false;
            this.timeKeepingDgv.AllowUserToDeleteRows = false;
            this.timeKeepingDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.timeKeepingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeKeepingDgv.Location = new System.Drawing.Point(0, 51);
            this.timeKeepingDgv.MultiSelect = false;
            this.timeKeepingDgv.Name = "timeKeepingDgv";
            this.timeKeepingDgv.ReadOnly = true;
            this.timeKeepingDgv.Size = new System.Drawing.Size(555, 300);
            this.timeKeepingDgv.TabIndex = 19;
            // 
            // closeTimeKeepingBtn
            // 
            this.closeTimeKeepingBtn.BackColor = System.Drawing.Color.Brown;
            this.closeTimeKeepingBtn.Location = new System.Drawing.Point(479, 356);
            this.closeTimeKeepingBtn.Name = "closeTimeKeepingBtn";
            this.closeTimeKeepingBtn.Size = new System.Drawing.Size(75, 35);
            this.closeTimeKeepingBtn.TabIndex = 18;
            this.closeTimeKeepingBtn.Text = "Close";
            this.closeTimeKeepingBtn.UseVisualStyleBackColor = false;
            this.closeTimeKeepingBtn.Click += new System.EventHandler(this.closeTimeKeepingBtn_Click);
            // 
            // editEmployeePanel
            // 
            this.editEmployeePanel.BackColor = System.Drawing.Color.Transparent;
            this.editEmployeePanel.Controls.Add(this.panel4);
            this.editEmployeePanel.Controls.Add(this.label9);
            this.editEmployeePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.editEmployeePanel.Location = new System.Drawing.Point(653, 0);
            this.editEmployeePanel.Name = "editEmployeePanel";
            this.editEmployeePanel.Size = new System.Drawing.Size(315, 576);
            this.editEmployeePanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.editJob);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.editPasswordTb);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.editUsernameTb);
            this.panel4.Controls.Add(this.editFirstnameTb);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.editLastnameTb);
            this.panel4.Controls.Add(this.editTypeComB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 525);
            this.panel4.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.editEmployeeBtn);
            this.panel7.Controls.Add(this.closeUpdatePanelBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 456);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(315, 69);
            this.panel7.TabIndex = 19;
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.editEmployeeBtn.Location = new System.Drawing.Point(201, 15);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(75, 35);
            this.editEmployeeBtn.TabIndex = 0;
            this.editEmployeeBtn.Text = "Edit";
            this.editEmployeeBtn.UseVisualStyleBackColor = false;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // closeUpdatePanelBtn
            // 
            this.closeUpdatePanelBtn.BackColor = System.Drawing.Color.Brown;
            this.closeUpdatePanelBtn.Location = new System.Drawing.Point(39, 15);
            this.closeUpdatePanelBtn.Name = "closeUpdatePanelBtn";
            this.closeUpdatePanelBtn.Size = new System.Drawing.Size(75, 35);
            this.closeUpdatePanelBtn.TabIndex = 1;
            this.closeUpdatePanelBtn.Text = "Close";
            this.closeUpdatePanelBtn.UseVisualStyleBackColor = false;
            this.closeUpdatePanelBtn.Click += new System.EventHandler(this.closeUpdatePanelBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Job";
            // 
            // editJob
            // 
            this.editJob.Location = new System.Drawing.Point(96, 148);
            this.editJob.Name = "editJob";
            this.editJob.Size = new System.Drawing.Size(202, 26);
            this.editJob.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Password";
            // 
            // editPasswordTb
            // 
            this.editPasswordTb.Location = new System.Drawing.Point(95, 116);
            this.editPasswordTb.Name = "editPasswordTb";
            this.editPasswordTb.Size = new System.Drawing.Size(202, 26);
            this.editPasswordTb.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Username";
            // 
            // editUsernameTb
            // 
            this.editUsernameTb.Location = new System.Drawing.Point(95, 83);
            this.editUsernameTb.Name = "editUsernameTb";
            this.editUsernameTb.Size = new System.Drawing.Size(202, 26);
            this.editUsernameTb.TabIndex = 2;
            // 
            // editFirstnameTb
            // 
            this.editFirstnameTb.Location = new System.Drawing.Point(96, 19);
            this.editFirstnameTb.Name = "editFirstnameTb";
            this.editFirstnameTb.Size = new System.Drawing.Size(202, 26);
            this.editFirstnameTb.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Firstname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lastname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Type";
            // 
            // editLastnameTb
            // 
            this.editLastnameTb.Location = new System.Drawing.Point(96, 51);
            this.editLastnameTb.Name = "editLastnameTb";
            this.editLastnameTb.Size = new System.Drawing.Size(202, 26);
            this.editLastnameTb.TabIndex = 1;
            // 
            // editTypeComB
            // 
            this.editTypeComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editTypeComB.FormattingEnabled = true;
            this.editTypeComB.Items.AddRange(new object[] {
            "",
            "Regular",
            "Contractual",
            "Part-Time",
            "Consultant"});
            this.editTypeComB.Location = new System.Drawing.Point(95, 180);
            this.editTypeComB.Name = "editTypeComB";
            this.editTypeComB.Size = new System.Drawing.Size(202, 28);
            this.editTypeComB.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 51);
            this.label9.TabIndex = 16;
            this.label9.Text = "Edit Employee";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEmployeePanel
            // 
            this.addEmployeePanel.BackColor = System.Drawing.Color.Transparent;
            this.addEmployeePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmployeePanel.Controls.Add(this.panel2);
            this.addEmployeePanel.Controls.Add(this.label5);
            this.addEmployeePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addEmployeePanel.Location = new System.Drawing.Point(968, 0);
            this.addEmployeePanel.Name = "addEmployeePanel";
            this.addEmployeePanel.Size = new System.Drawing.Size(315, 576);
            this.addEmployeePanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.jobTb);
            this.panel2.Controls.Add(this.firstnameTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lastnameTb);
            this.panel2.Controls.Add(this.typeComB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 525);
            this.panel2.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addEmployeeBtn);
            this.panel6.Controls.Add(this.clearBtn);
            this.panel6.Controls.Add(this.closeAddPanelBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 456);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 69);
            this.panel6.TabIndex = 13;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.Green;
            this.addEmployeeBtn.Location = new System.Drawing.Point(201, 15);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(75, 35);
            this.addEmployeeBtn.TabIndex = 0;
            this.addEmployeeBtn.Text = "Add";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(39, 15);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 35);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeAddPanelBtn
            // 
            this.closeAddPanelBtn.BackColor = System.Drawing.Color.Brown;
            this.closeAddPanelBtn.Location = new System.Drawing.Point(120, 15);
            this.closeAddPanelBtn.Name = "closeAddPanelBtn";
            this.closeAddPanelBtn.Size = new System.Drawing.Size(75, 35);
            this.closeAddPanelBtn.TabIndex = 2;
            this.closeAddPanelBtn.Text = "Close";
            this.closeAddPanelBtn.UseVisualStyleBackColor = false;
            this.closeAddPanelBtn.Click += new System.EventHandler(this.closeAddPanelBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Job";
            // 
            // jobTb
            // 
            this.jobTb.Location = new System.Drawing.Point(96, 83);
            this.jobTb.Name = "jobTb";
            this.jobTb.Size = new System.Drawing.Size(202, 26);
            this.jobTb.TabIndex = 2;
            // 
            // firstnameTb
            // 
            this.firstnameTb.Location = new System.Drawing.Point(96, 19);
            this.firstnameTb.Name = "firstnameTb";
            this.firstnameTb.Size = new System.Drawing.Size(202, 26);
            this.firstnameTb.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // lastnameTb
            // 
            this.lastnameTb.Location = new System.Drawing.Point(96, 51);
            this.lastnameTb.Name = "lastnameTb";
            this.lastnameTb.Size = new System.Drawing.Size(202, 26);
            this.lastnameTb.TabIndex = 1;
            // 
            // typeComB
            // 
            this.typeComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComB.FormattingEnabled = true;
            this.typeComB.Items.AddRange(new object[] {
            "",
            "Regular",
            "Contractual",
            "Part-Time",
            "Consultant"});
            this.typeComB.Location = new System.Drawing.Point(96, 115);
            this.typeComB.Name = "typeComB";
            this.typeComB.Size = new System.Drawing.Size(202, 28);
            this.typeComB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 51);
            this.label5.TabIndex = 16;
            this.label5.Text = "Add Employee";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeDgv
            // 
            this.employeeDgv.AllowUserToAddRows = false;
            this.employeeDgv.AllowUserToDeleteRows = false;
            this.employeeDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeeDgv.BackgroundColor = System.Drawing.Color.White;
            this.employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDgv.Location = new System.Drawing.Point(0, 0);
            this.employeeDgv.Name = "employeeDgv";
            this.employeeDgv.ReadOnly = true;
            this.employeeDgv.Size = new System.Drawing.Size(1283, 576);
            this.employeeDgv.TabIndex = 0;
            this.employeeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Employee";
            // 
            // showAddPanelBtn
            // 
            this.showAddPanelBtn.BackColor = System.Drawing.Color.Green;
            this.showAddPanelBtn.Location = new System.Drawing.Point(70, 6);
            this.showAddPanelBtn.Name = "showAddPanelBtn";
            this.showAddPanelBtn.Size = new System.Drawing.Size(75, 36);
            this.showAddPanelBtn.TabIndex = 2;
            this.showAddPanelBtn.Text = "Add";
            this.showAddPanelBtn.UseVisualStyleBackColor = false;
            this.showAddPanelBtn.Click += new System.EventHandler(this.showAddPanelBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(152, 9);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(448, 26);
            this.searchTb.TabIndex = 0;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.searchTb);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 48);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.showAddPanelBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1126, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 48);
            this.panel5.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Payroll.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.SizeChanged += new System.EventHandler(this.EmployeeForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.timeKeepingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDgv)).EndInit();
            this.editEmployeePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.addEmployeePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAddPanelBtn;
        public System.Windows.Forms.DataGridView employeeDgv;
        private System.Windows.Forms.Panel addEmployeePanel;
        private System.Windows.Forms.ComboBox typeComB;
        private System.Windows.Forms.TextBox lastnameTb;
        private System.Windows.Forms.TextBox firstnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeAddPanelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel editEmployeePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox editFirstnameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox editLastnameTb;
        private System.Windows.Forms.ComboBox editTypeComB;
        private System.Windows.Forms.Button closeUpdatePanelBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button editEmployeeBtn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Panel timeKeepingPanel;
        private System.Windows.Forms.Button closeTimeKeepingBtn;
        private System.Windows.Forms.DataGridView timeKeepingDgv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox editPasswordTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editUsernameTb;
        private System.Windows.Forms.Label nameTimeKeepingLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox jobTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox editJob;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}