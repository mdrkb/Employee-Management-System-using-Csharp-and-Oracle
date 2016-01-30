namespace Employee_Management_System
{
    partial class Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.account_project_id = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.bonus = new System.Windows.Forms.TextBox();
            this.account_employee_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountmanage_dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.AccountManage_Pay = new System.Windows.Forms.Button();
            this.AccountManage_Find = new System.Windows.Forms.Button();
            this.ProjectManage_Clear = new System.Windows.Forms.Button();
            this.AccountManage_Delete = new System.Windows.Forms.Button();
            this.AccountManage_Update = new System.Windows.Forms.Button();
            this.totalsalary = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountmanage_dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Project Id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Salary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Bonus";
            // 
            // account_project_id
            // 
            this.account_project_id.Location = new System.Drawing.Point(138, 99);
            this.account_project_id.Name = "account_project_id";
            this.account_project_id.Size = new System.Drawing.Size(184, 26);
            this.account_project_id.TabIndex = 6;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(139, 148);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(140, 26);
            this.salary.TabIndex = 7;
            // 
            // bonus
            // 
            this.bonus.Location = new System.Drawing.Point(139, 198);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(141, 26);
            this.bonus.TabIndex = 8;
            // 
            // account_employee_id
            // 
            this.account_employee_id.Location = new System.Drawing.Point(139, 50);
            this.account_employee_id.Name = "account_employee_id";
            this.account_employee_id.Size = new System.Drawing.Size(182, 26);
            this.account_employee_id.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Employee ID ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.account_employee_id);
            this.groupBox2.Controls.Add(this.bonus);
            this.groupBox2.Controls.Add(this.salary);
            this.groupBox2.Controls.Add(this.account_project_id);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(150, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 291);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tk";
            // 
            // accountmanage_dataGridView
            // 
            this.accountmanage_dataGridView.AllowUserToAddRows = false;
            this.accountmanage_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.accountmanage_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.accountmanage_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.accountmanage_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountmanage_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountmanage_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.accountmanage_dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.accountmanage_dataGridView.Location = new System.Drawing.Point(576, 111);
            this.accountmanage_dataGridView.Name = "accountmanage_dataGridView";
            this.accountmanage_dataGridView.Size = new System.Drawing.Size(404, 439);
            this.accountmanage_dataGridView.TabIndex = 44;
            this.accountmanage_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountmanage_dataGridView_CellClick_1);
            this.accountmanage_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountmanage_dataGridView_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SkyBlue;
            this.label8.Location = new System.Drawing.Point(881, 37);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 46;
            this.label8.Text = "Super Admin";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.SkyBlue;
            this.time.Location = new System.Drawing.Point(577, 37);
            this.time.Name = "time";
            this.time.Padding = new System.Windows.Forms.Padding(5);
            this.time.Size = new System.Drawing.Size(118, 30);
            this.time.TabIndex = 45;
            this.time.Text = "System time : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManageToolStripMenuItem,
            this.projectManageToolStripMenuItem,
            this.accountsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.editToolStripMenuItem.Text = "View";
            // 
            // employeeManageToolStripMenuItem
            // 
            this.employeeManageToolStripMenuItem.Name = "employeeManageToolStripMenuItem";
            this.employeeManageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.employeeManageToolStripMenuItem.Text = "Employee Manage";
            this.employeeManageToolStripMenuItem.Click += new System.EventHandler(this.employeeManageToolStripMenuItem_Click);
            // 
            // projectManageToolStripMenuItem
            // 
            this.projectManageToolStripMenuItem.Name = "projectManageToolStripMenuItem";
            this.projectManageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.projectManageToolStripMenuItem.Text = "Project Manage";
            this.projectManageToolStripMenuItem.Click += new System.EventHandler(this.projectManageToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.accountsToolStripMenuItem.Text = "Accounts Manage";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AccountManage_Pay
            // 
            this.AccountManage_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountManage_Pay.ForeColor = System.Drawing.Color.Black;
            this.AccountManage_Pay.Image = global::Employee_Management_System.Properties.Resources.pay;
            this.AccountManage_Pay.Location = new System.Drawing.Point(29, 154);
            this.AccountManage_Pay.Name = "AccountManage_Pay";
            this.AccountManage_Pay.Size = new System.Drawing.Size(102, 53);
            this.AccountManage_Pay.TabIndex = 42;
            this.AccountManage_Pay.Text = "Pay";
            this.AccountManage_Pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountManage_Pay.UseVisualStyleBackColor = true;
            this.AccountManage_Pay.Click += new System.EventHandler(this.AccountManage_Pay_Click);
            // 
            // AccountManage_Find
            // 
            this.AccountManage_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountManage_Find.ForeColor = System.Drawing.Color.Black;
            this.AccountManage_Find.Image = global::Employee_Management_System.Properties.Resources.search;
            this.AccountManage_Find.Location = new System.Drawing.Point(29, 213);
            this.AccountManage_Find.Name = "AccountManage_Find";
            this.AccountManage_Find.Size = new System.Drawing.Size(102, 48);
            this.AccountManage_Find.TabIndex = 41;
            this.AccountManage_Find.Text = "Find";
            this.AccountManage_Find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountManage_Find.UseVisualStyleBackColor = true;
            this.AccountManage_Find.Click += new System.EventHandler(this.AccountManage_Find_Click);
            // 
            // ProjectManage_Clear
            // 
            this.ProjectManage_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProjectManage_Clear.ForeColor = System.Drawing.Color.Black;
            this.ProjectManage_Clear.Image = global::Employee_Management_System.Properties.Resources.clear;
            this.ProjectManage_Clear.Location = new System.Drawing.Point(29, 383);
            this.ProjectManage_Clear.Name = "ProjectManage_Clear";
            this.ProjectManage_Clear.Size = new System.Drawing.Size(102, 47);
            this.ProjectManage_Clear.TabIndex = 39;
            this.ProjectManage_Clear.Text = "Clear";
            this.ProjectManage_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectManage_Clear.UseVisualStyleBackColor = true;
            this.ProjectManage_Clear.Click += new System.EventHandler(this.ProjectManage_Clear_Click);
            // 
            // AccountManage_Delete
            // 
            this.AccountManage_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountManage_Delete.ForeColor = System.Drawing.Color.Black;
            this.AccountManage_Delete.Image = global::Employee_Management_System.Properties.Resources.delete;
            this.AccountManage_Delete.Location = new System.Drawing.Point(29, 327);
            this.AccountManage_Delete.Name = "AccountManage_Delete";
            this.AccountManage_Delete.Size = new System.Drawing.Size(102, 50);
            this.AccountManage_Delete.TabIndex = 38;
            this.AccountManage_Delete.Text = "Delete";
            this.AccountManage_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountManage_Delete.UseVisualStyleBackColor = true;
            this.AccountManage_Delete.Click += new System.EventHandler(this.AccountManage_Delete_Click);
            // 
            // AccountManage_Update
            // 
            this.AccountManage_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountManage_Update.ForeColor = System.Drawing.Color.Black;
            this.AccountManage_Update.Image = global::Employee_Management_System.Properties.Resources.update;
            this.AccountManage_Update.Location = new System.Drawing.Point(29, 270);
            this.AccountManage_Update.Name = "AccountManage_Update";
            this.AccountManage_Update.Size = new System.Drawing.Size(102, 51);
            this.AccountManage_Update.TabIndex = 37;
            this.AccountManage_Update.Text = "Update";
            this.AccountManage_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountManage_Update.UseVisualStyleBackColor = true;
            this.AccountManage_Update.Click += new System.EventHandler(this.AccountManage_Update_Click);
            // 
            // totalsalary
            // 
            this.totalsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalsalary.ForeColor = System.Drawing.Color.Black;
            this.totalsalary.Image = global::Employee_Management_System.Properties.Resources.pay;
            this.totalsalary.Location = new System.Drawing.Point(150, 461);
            this.totalsalary.Name = "totalsalary";
            this.totalsalary.Size = new System.Drawing.Size(149, 47);
            this.totalsalary.TabIndex = 48;
            this.totalsalary.Text = "Total Salary";
            this.totalsalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.totalsalary.UseVisualStyleBackColor = true;
            this.totalsalary.Click += new System.EventHandler(this.totalsalary_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1084, 563);
            this.Controls.Add(this.totalsalary);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.time);
            this.Controls.Add(this.accountmanage_dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AccountManage_Pay);
            this.Controls.Add(this.AccountManage_Find);
            this.Controls.Add(this.ProjectManage_Clear);
            this.Controls.Add(this.AccountManage_Delete);
            this.Controls.Add(this.AccountManage_Update);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS - Account Management";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountmanage_dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProjectManage_Clear;
        private System.Windows.Forms.Button AccountManage_Delete;
        private System.Windows.Forms.Button AccountManage_Update;
        private System.Windows.Forms.Button AccountManage_Pay;
        private System.Windows.Forms.Button AccountManage_Find;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox account_project_id;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox bonus;
        private System.Windows.Forms.TextBox account_employee_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView accountmanage_dataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button totalsalary;

    }
}