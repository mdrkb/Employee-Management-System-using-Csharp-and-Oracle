namespace Employee_Management_System
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.assign_date = new System.Windows.Forms.TextBox();
            this.assign_eid = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.assign_worktime = new System.Windows.Forms.TextBox();
            this.assign_pid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.project_currency = new System.Windows.Forms.ComboBox();
            this.project_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.project_id = new System.Windows.Forms.TextBox();
            this.project_budget = new System.Windows.Forms.TextBox();
            this.project_deadline = new System.Windows.Forms.TextBox();
            this.project_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.projectmanageassign_dataGridView = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Assign = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.Button();
            this.ProjectManage_Clear = new System.Windows.Forms.Button();
            this.ProjectManage_Delete = new System.Windows.Forms.Button();
            this.ProjectManage_Update = new System.Windows.Forms.Button();
            this.ProjectManage_Add = new System.Windows.Forms.Button();
            this.ProjectManage_Search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectmanageassign_dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
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
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.accountsToolStripMenuItem.Text = "Accounts Manage";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
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
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.SkyBlue;
            this.time.Location = new System.Drawing.Point(582, 37);
            this.time.Name = "time";
            this.time.Padding = new System.Windows.Forms.Padding(5);
            this.time.Size = new System.Drawing.Size(118, 30);
            this.time.TabIndex = 14;
            this.time.Text = "System time : ";
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
            this.label8.TabIndex = 17;
            this.label8.Text = "Super Admin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.assign_date);
            this.groupBox3.Controls.Add(this.assign_eid);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.assign_worktime);
            this.groupBox3.Controls.Add(this.assign_pid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(149, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 223);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assignment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "EmployeeID ";
            // 
            // assign_date
            // 
            this.assign_date.Location = new System.Drawing.Point(124, 176);
            this.assign_date.Name = "assign_date";
            this.assign_date.Size = new System.Drawing.Size(185, 26);
            this.assign_date.TabIndex = 39;
            // 
            // assign_eid
            // 
            this.assign_eid.Location = new System.Drawing.Point(125, 29);
            this.assign_eid.Name = "assign_eid";
            this.assign_eid.Size = new System.Drawing.Size(182, 26);
            this.assign_eid.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Assign Date";
            // 
            // assign_worktime
            // 
            this.assign_worktime.Location = new System.Drawing.Point(125, 130);
            this.assign_worktime.Name = "assign_worktime";
            this.assign_worktime.Size = new System.Drawing.Size(184, 26);
            this.assign_worktime.TabIndex = 7;
            // 
            // assign_pid
            // 
            this.assign_pid.Location = new System.Drawing.Point(125, 81);
            this.assign_pid.Name = "assign_pid";
            this.assign_pid.Size = new System.Drawing.Size(184, 26);
            this.assign_pid.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Work time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "ProjectID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.project_currency);
            this.groupBox2.Controls.Add(this.project_status);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.project_id);
            this.groupBox2.Controls.Add(this.project_budget);
            this.groupBox2.Controls.Add(this.project_deadline);
            this.groupBox2.Controls.Add(this.project_name);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(149, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 275);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // project_currency
            // 
            this.project_currency.FormattingEnabled = true;
            this.project_currency.Items.AddRange(new object[] {
            "Tk",
            "USD",
            "EURO"});
            this.project_currency.Location = new System.Drawing.Point(235, 180);
            this.project_currency.Name = "project_currency";
            this.project_currency.Size = new System.Drawing.Size(70, 28);
            this.project_currency.TabIndex = 23;
            // 
            // project_status
            // 
            this.project_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_status.FormattingEnabled = true;
            this.project_status.Items.AddRange(new object[] {
            "Pending",
            "Running",
            "Stalled",
            "Aborted",
            "Finished"});
            this.project_status.Location = new System.Drawing.Point(121, 228);
            this.project_status.Name = "project_status";
            this.project_status.Size = new System.Drawing.Size(183, 28);
            this.project_status.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID ";
            // 
            // project_id
            // 
            this.project_id.Location = new System.Drawing.Point(121, 29);
            this.project_id.Name = "project_id";
            this.project_id.Size = new System.Drawing.Size(182, 26);
            this.project_id.TabIndex = 19;
            // 
            // project_budget
            // 
            this.project_budget.Location = new System.Drawing.Point(121, 180);
            this.project_budget.Name = "project_budget";
            this.project_budget.Size = new System.Drawing.Size(108, 26);
            this.project_budget.TabIndex = 8;
            // 
            // project_deadline
            // 
            this.project_deadline.Location = new System.Drawing.Point(121, 130);
            this.project_deadline.Name = "project_deadline";
            this.project_deadline.Size = new System.Drawing.Size(184, 26);
            this.project_deadline.TabIndex = 7;
            // 
            // project_name
            // 
            this.project_name.Location = new System.Drawing.Point(121, 81);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(184, 26);
            this.project_name.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Budget";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Deadline";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name";
            // 
            // projectmanageassign_dataGridView
            // 
            this.projectmanageassign_dataGridView.AllowUserToAddRows = false;
            this.projectmanageassign_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectmanageassign_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.projectmanageassign_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.projectmanageassign_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectmanageassign_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectmanageassign_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.projectmanageassign_dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.projectmanageassign_dataGridView.Location = new System.Drawing.Point(492, 71);
            this.projectmanageassign_dataGridView.Name = "projectmanageassign_dataGridView";
            this.projectmanageassign_dataGridView.Size = new System.Drawing.Size(580, 480);
            this.projectmanageassign_dataGridView.TabIndex = 40;
            this.projectmanageassign_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectmanageassign_dataGridView_CellClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Assign
            // 
            this.Assign.ForeColor = System.Drawing.Color.Black;
            this.Assign.Image = global::Employee_Management_System.Properties.Resources.assign;
            this.Assign.Location = new System.Drawing.Point(12, 447);
            this.Assign.Name = "Assign";
            this.Assign.Size = new System.Drawing.Size(118, 47);
            this.Assign.TabIndex = 37;
            this.Assign.Text = "Assign";
            this.Assign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Assign.UseVisualStyleBackColor = true;
            this.Assign.Click += new System.EventHandler(this.Assign_Click);
            // 
            // Projects
            // 
            this.Projects.ForeColor = System.Drawing.Color.Black;
            this.Projects.Image = global::Employee_Management_System.Properties.Resources.project;
            this.Projects.Location = new System.Drawing.Point(12, 393);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(118, 48);
            this.Projects.TabIndex = 36;
            this.Projects.Text = "Projects";
            this.Projects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Projects.UseVisualStyleBackColor = true;
            this.Projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // ProjectManage_Clear
            // 
            this.ProjectManage_Clear.ForeColor = System.Drawing.Color.Black;
            this.ProjectManage_Clear.Image = global::Employee_Management_System.Properties.Resources.clear;
            this.ProjectManage_Clear.Location = new System.Drawing.Point(12, 306);
            this.ProjectManage_Clear.Name = "ProjectManage_Clear";
            this.ProjectManage_Clear.Size = new System.Drawing.Size(118, 48);
            this.ProjectManage_Clear.TabIndex = 33;
            this.ProjectManage_Clear.Text = "Clear";
            this.ProjectManage_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectManage_Clear.UseVisualStyleBackColor = true;
            this.ProjectManage_Clear.Click += new System.EventHandler(this.ProjectManage_Clear_Click);
            // 
            // ProjectManage_Delete
            // 
            this.ProjectManage_Delete.ForeColor = System.Drawing.Color.Black;
            this.ProjectManage_Delete.Image = global::Employee_Management_System.Properties.Resources.delete;
            this.ProjectManage_Delete.Location = new System.Drawing.Point(12, 252);
            this.ProjectManage_Delete.Name = "ProjectManage_Delete";
            this.ProjectManage_Delete.Size = new System.Drawing.Size(118, 48);
            this.ProjectManage_Delete.TabIndex = 32;
            this.ProjectManage_Delete.Text = "Delete";
            this.ProjectManage_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectManage_Delete.UseVisualStyleBackColor = true;
            this.ProjectManage_Delete.Click += new System.EventHandler(this.ProjectManage_Delete_Click);
            // 
            // ProjectManage_Update
            // 
            this.ProjectManage_Update.ForeColor = System.Drawing.Color.Black;
            this.ProjectManage_Update.Image = global::Employee_Management_System.Properties.Resources.update;
            this.ProjectManage_Update.Location = new System.Drawing.Point(12, 200);
            this.ProjectManage_Update.Name = "ProjectManage_Update";
            this.ProjectManage_Update.Size = new System.Drawing.Size(118, 46);
            this.ProjectManage_Update.TabIndex = 31;
            this.ProjectManage_Update.Text = "Update";
            this.ProjectManage_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectManage_Update.UseVisualStyleBackColor = true;
            this.ProjectManage_Update.Click += new System.EventHandler(this.ProjectManage_Update_Click);
            // 
            // ProjectManage_Add
            // 
            this.ProjectManage_Add.ForeColor = System.Drawing.Color.Black;
            this.ProjectManage_Add.Image = global::Employee_Management_System.Properties.Resources.add;
            this.ProjectManage_Add.Location = new System.Drawing.Point(12, 147);
            this.ProjectManage_Add.Name = "ProjectManage_Add";
            this.ProjectManage_Add.Size = new System.Drawing.Size(118, 47);
            this.ProjectManage_Add.TabIndex = 30;
            this.ProjectManage_Add.Text = "Add";
            this.ProjectManage_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectManage_Add.UseVisualStyleBackColor = true;
            this.ProjectManage_Add.Click += new System.EventHandler(this.ProjectManage_Add_Click);
            // 
            // ProjectManage_Search
            // 
            this.ProjectManage_Search.ForeColor = System.Drawing.Color.Black;
            this.ProjectManage_Search.Image = global::Employee_Management_System.Properties.Resources.search;
            this.ProjectManage_Search.Location = new System.Drawing.Point(12, 94);
            this.ProjectManage_Search.Name = "ProjectManage_Search";
            this.ProjectManage_Search.Size = new System.Drawing.Size(118, 47);
            this.ProjectManage_Search.TabIndex = 29;
            this.ProjectManage_Search.Text = "Search";
            this.ProjectManage_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProjectManage_Search.UseVisualStyleBackColor = true;
            this.ProjectManage_Search.Click += new System.EventHandler(this.ProjectManage_Search_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1084, 563);
            this.Controls.Add(this.projectmanageassign_dataGridView);
            this.Controls.Add(this.Assign);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProjectManage_Clear);
            this.Controls.Add(this.ProjectManage_Delete);
            this.Controls.Add(this.ProjectManage_Update);
            this.Controls.Add(this.ProjectManage_Add);
            this.Controls.Add(this.ProjectManage_Search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.time);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Project";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS - Project Management";
            this.Load += new System.EventHandler(this.Project_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectmanageassign_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button Assign;
        private System.Windows.Forms.Button Projects;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox assign_eid;
        private System.Windows.Forms.TextBox assign_worktime;
        private System.Windows.Forms.TextBox assign_pid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox project_currency;
        private System.Windows.Forms.ComboBox project_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox project_id;
        private System.Windows.Forms.TextBox project_budget;
        private System.Windows.Forms.TextBox project_deadline;
        private System.Windows.Forms.TextBox project_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ProjectManage_Clear;
        private System.Windows.Forms.Button ProjectManage_Delete;
        private System.Windows.Forms.Button ProjectManage_Update;
        private System.Windows.Forms.Button ProjectManage_Add;
        private System.Windows.Forms.Button ProjectManage_Search;
        private System.Windows.Forms.TextBox assign_date;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView projectmanageassign_dataGridView;
        private System.Windows.Forms.Timer timer;


    }
}