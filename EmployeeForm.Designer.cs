namespace Payroll
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
            this.employeeDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.showAddPanelBtn = new System.Windows.Forms.Button();
            this.addEmployeePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstnameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnameTb = new System.Windows.Forms.TextBox();
            this.typeComB = new System.Windows.Forms.ComboBox();
            this.closeAddPanelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editEmployeePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editFirstnameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.editLastnameTb = new System.Windows.Forms.TextBox();
            this.editTypeComB = new System.Windows.Forms.ComboBox();
            this.closeUpdatePanelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).BeginInit();
            this.addEmployeePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.editEmployeePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editEmployeePanel);
            this.panel1.Controls.Add(this.addEmployeePanel);
            this.panel1.Controls.Add(this.employeeDgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 566);
            this.panel1.TabIndex = 2;
            // 
            // employeeDgv
            // 
            this.employeeDgv.AllowUserToAddRows = false;
            this.employeeDgv.AllowUserToDeleteRows = false;
            this.employeeDgv.BackgroundColor = System.Drawing.Color.White;
            this.employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDgv.Location = new System.Drawing.Point(0, 0);
            this.employeeDgv.Name = "employeeDgv";
            this.employeeDgv.ReadOnly = true;
            this.employeeDgv.Size = new System.Drawing.Size(1283, 566);
            this.employeeDgv.TabIndex = 0;
            this.employeeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Employee";
            // 
            // showAddPanelBtn
            // 
            this.showAddPanelBtn.Location = new System.Drawing.Point(1194, 12);
            this.showAddPanelBtn.Name = "showAddPanelBtn";
            this.showAddPanelBtn.Size = new System.Drawing.Size(75, 36);
            this.showAddPanelBtn.TabIndex = 4;
            this.showAddPanelBtn.Text = "Add";
            this.showAddPanelBtn.UseVisualStyleBackColor = true;
            this.showAddPanelBtn.Click += new System.EventHandler(this.showAddPanelBtn_Click);
            // 
            // addEmployeePanel
            // 
            this.addEmployeePanel.Controls.Add(this.panel2);
            this.addEmployeePanel.Controls.Add(this.closeAddPanelBtn);
            this.addEmployeePanel.Controls.Add(this.label5);
            this.addEmployeePanel.Controls.Add(this.addEmployeeBtn);
            this.addEmployeePanel.Controls.Add(this.clearBtn);
            this.addEmployeePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addEmployeePanel.Location = new System.Drawing.Point(968, 0);
            this.addEmployeePanel.Name = "addEmployeePanel";
            this.addEmployeePanel.Size = new System.Drawing.Size(315, 566);
            this.addEmployeePanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.firstnameTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lastnameTb);
            this.panel2.Controls.Add(this.typeComB);
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 468);
            this.panel2.TabIndex = 18;
            // 
            // firstnameTb
            // 
            this.firstnameTb.Location = new System.Drawing.Point(96, 19);
            this.firstnameTb.Name = "firstnameTb";
            this.firstnameTb.Size = new System.Drawing.Size(202, 26);
            this.firstnameTb.TabIndex = 11;
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
            this.label3.Location = new System.Drawing.Point(47, 86);
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
            this.lastnameTb.TabIndex = 12;
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
            this.typeComB.Location = new System.Drawing.Point(96, 83);
            this.typeComB.Name = "typeComB";
            this.typeComB.Size = new System.Drawing.Size(202, 28);
            this.typeComB.TabIndex = 13;
            // 
            // closeAddPanelBtn
            // 
            this.closeAddPanelBtn.Location = new System.Drawing.Point(120, 522);
            this.closeAddPanelBtn.Name = "closeAddPanelBtn";
            this.closeAddPanelBtn.Size = new System.Drawing.Size(75, 35);
            this.closeAddPanelBtn.TabIndex = 17;
            this.closeAddPanelBtn.Text = "Close";
            this.closeAddPanelBtn.UseVisualStyleBackColor = true;
            this.closeAddPanelBtn.Click += new System.EventHandler(this.closeAddPanelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Add Employee";
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(201, 522);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(75, 35);
            this.addEmployeeBtn.TabIndex = 15;
            this.addEmployeeBtn.Text = "Add";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(39, 522);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 35);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // editEmployeePanel
            // 
            this.editEmployeePanel.Controls.Add(this.panel4);
            this.editEmployeePanel.Controls.Add(this.closeUpdatePanelBtn);
            this.editEmployeePanel.Controls.Add(this.label9);
            this.editEmployeePanel.Controls.Add(this.editEmployeeBtn);
            this.editEmployeePanel.Location = new System.Drawing.Point(969, 1);
            this.editEmployeePanel.Name = "editEmployeePanel";
            this.editEmployeePanel.Size = new System.Drawing.Size(315, 566);
            this.editEmployeePanel.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.editFirstnameTb);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.editLastnameTb);
            this.panel4.Controls.Add(this.editTypeComB);
            this.panel4.Location = new System.Drawing.Point(3, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 468);
            this.panel4.TabIndex = 18;
            // 
            // editFirstnameTb
            // 
            this.editFirstnameTb.Location = new System.Drawing.Point(96, 19);
            this.editFirstnameTb.Name = "editFirstnameTb";
            this.editFirstnameTb.Size = new System.Drawing.Size(202, 26);
            this.editFirstnameTb.TabIndex = 11;
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
            this.label8.Location = new System.Drawing.Point(47, 86);
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
            this.editLastnameTb.TabIndex = 12;
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
            this.editTypeComB.Location = new System.Drawing.Point(96, 83);
            this.editTypeComB.Name = "editTypeComB";
            this.editTypeComB.Size = new System.Drawing.Size(202, 28);
            this.editTypeComB.TabIndex = 13;
            // 
            // closeUpdatePanelBtn
            // 
            this.closeUpdatePanelBtn.Location = new System.Drawing.Point(39, 522);
            this.closeUpdatePanelBtn.Name = "closeUpdatePanelBtn";
            this.closeUpdatePanelBtn.Size = new System.Drawing.Size(75, 35);
            this.closeUpdatePanelBtn.TabIndex = 17;
            this.closeUpdatePanelBtn.Text = "Close";
            this.closeUpdatePanelBtn.UseVisualStyleBackColor = true;
            this.closeUpdatePanelBtn.Click += new System.EventHandler(this.closeUpdatePanelBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Edit Employee";
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Location = new System.Drawing.Point(201, 522);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(75, 35);
            this.editEmployeeBtn.TabIndex = 15;
            this.editEmployeeBtn.Text = "Edit";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(152, 17);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(448, 26);
            this.searchTb.TabIndex = 14;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(606, 15);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 31);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 624);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.showAddPanelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).EndInit();
            this.addEmployeePanel.ResumeLayout(false);
            this.addEmployeePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.editEmployeePanel.ResumeLayout(false);
            this.editEmployeePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button searchBtn;
    }
}