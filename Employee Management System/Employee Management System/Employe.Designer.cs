namespace Employee_Management_System
{
    partial class Employe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.ComboBox();
            this.experience = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.employeeid = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.national_id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.jobcount = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataGridView)).BeginInit();
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
            this.menuStrip1.TabIndex = 1;
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
            this.label8.TabIndex = 19;
            this.label8.Text = "Super Admin";
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
            this.time.TabIndex = 18;
            this.time.Text = "System time : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.designation);
            this.groupBox1.Controls.Add(this.experience);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.employeeid);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.national_id);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(154, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 458);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID ";
            // 
            // designation
            // 
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.FormattingEnabled = true;
            this.designation.Items.AddRange(new object[] {
            "Senior Engineer",
            "Junior Engineer"});
            this.designation.Location = new System.Drawing.Point(131, 232);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(183, 28);
            this.designation.TabIndex = 11;
            // 
            // experience
            // 
            this.experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experience.Location = new System.Drawing.Point(130, 333);
            this.experience.Multiline = true;
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(183, 109);
            this.experience.TabIndex = 10;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(130, 281);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(184, 26);
            this.address.TabIndex = 9;
            // 
            // employeeid
            // 
            this.employeeid.Location = new System.Drawing.Point(129, 29);
            this.employeeid.Name = "employeeid";
            this.employeeid.Size = new System.Drawing.Size(182, 26);
            this.employeeid.TabIndex = 19;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(129, 180);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(184, 26);
            this.contact.TabIndex = 8;
            // 
            // national_id
            // 
            this.national_id.Location = new System.Drawing.Point(129, 130);
            this.national_id.Name = "national_id";
            this.national_id.Size = new System.Drawing.Size(184, 26);
            this.national_id.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(184, 26);
            this.name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Experience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "National ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // employee_dataGridView
            // 
            this.employee_dataGridView.AllowUserToAddRows = false;
            this.employee_dataGridView.AllowUserToDeleteRows = false;
            this.employee_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employee_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.employee_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.employee_dataGridView.GridColor = System.Drawing.Color.White;
            this.employee_dataGridView.Location = new System.Drawing.Point(534, 83);
            this.employee_dataGridView.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.employee_dataGridView.Name = "employee_dataGridView";
            this.employee_dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employee_dataGridView.Size = new System.Drawing.Size(539, 444);
            this.employee_dataGridView.TabIndex = 26;
            this.employee_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_dataGridView_CellClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // clear
            // 
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Image = global::Employee_Management_System.Properties.Resources.clear;
            this.clear.Location = new System.Drawing.Point(12, 310);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(114, 48);
            this.clear.TabIndex = 24;
            this.clear.Text = "Clear";
            this.clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Image = global::Employee_Management_System.Properties.Resources.delete;
            this.delete.Location = new System.Drawing.Point(12, 256);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 48);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Image = global::Employee_Management_System.Properties.Resources.update;
            this.update.Location = new System.Drawing.Point(12, 204);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 46);
            this.update.TabIndex = 22;
            this.update.Text = "Update";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Image = global::Employee_Management_System.Properties.Resources.add;
            this.add.Location = new System.Drawing.Point(12, 155);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 43);
            this.add.TabIndex = 21;
            this.add.Text = "Add";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Image = global::Employee_Management_System.Properties.Resources.search;
            this.search.Location = new System.Drawing.Point(12, 104);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(114, 45);
            this.search.TabIndex = 20;
            this.search.Text = "Search";
            this.search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // jobcount
            // 
            this.jobcount.ForeColor = System.Drawing.Color.Black;
            this.jobcount.Image = global::Employee_Management_System.Properties.Resources.project;
            this.jobcount.Location = new System.Drawing.Point(12, 402);
            this.jobcount.Name = "jobcount";
            this.jobcount.Size = new System.Drawing.Size(114, 48);
            this.jobcount.TabIndex = 27;
            this.jobcount.Text = "Job Count";
            this.jobcount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jobcount.UseVisualStyleBackColor = true;
            this.jobcount.Click += new System.EventHandler(this.jobcount_Click);
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1084, 563);
            this.Controls.Add(this.jobcount);
            this.Controls.Add(this.employee_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.time);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Employe";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS - Employee Management";
            this.Load += new System.EventHandler(this.Employe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox designation;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox employeeid;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox national_id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView employee_dataGridView;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button jobcount;
    }
}