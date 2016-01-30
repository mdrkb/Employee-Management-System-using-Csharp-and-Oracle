using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Employee_Management_System
{
    public partial class Project : Form
    {
        int checktable = 0;
        int projectmanagesearchcount = 0;
        //
        OracleConnection con;
        //
        int checkworktime;
        int checkemployeestatus = 0;
        string nxtpid;
        //
        int assigndbeid = 0;
        int projectdbpid = 0;
        int projectdbbgt = 0;
        int dbwt = 0;
        string assignedeid = "";
        string givenpid = "";
        string pnm = "";
        string dl = "";
        string bgt = "";
        string currency = "";
        string status = "";
        string wt = "";
        string ad = "";
        int Value;

        public Project()
        {
            InitializeComponent();
            NextProjectId();
            ProjectData_Load();
            timer.Start();
            projectManageToolStripMenuItem.Enabled = false;
        }

        public Project(int value)
        {
            Value = value;
            if(value==1){
                InitializeComponent();
                NextProjectId();
                ProjectData_Load();
                timer.Start();
                projectManageToolStripMenuItem.Enabled = false;
                label8.Text = "Super Admin";
            }
            else if(value==3){
                InitializeComponent();
                NextProjectId();
                ProjectData_Load();
                timer.Start();
                projectManageToolStripMenuItem.Enabled = false;
                employeeManageToolStripMenuItem.Visible = false;
                accountsToolStripMenuItem.Visible = false;
                label8.Text = "Project Admin";
            }
            
        }

        public void openconnection()
        {
            String strconnection = "Data Source=Rakib-PC;User Id=ems;Password=ems;";
            con = new OracleConnection(strconnection);
            con.Open();
        }

        public void closeconnection()
        {
            con.Close();
        }

        public void runquerry(string querry)
        {
            openconnection();
            string strquerry = querry;
            OracleCommand cmd = new OracleCommand(strquerry, con);
            cmd.ExecuteNonQuery();
            closeconnection();
        }

        private void NextProjectId()
        {
            int dbpid = 0;
            openconnection();
            string pidquerry = "SELECT * FROM (SELECT id FROM project ORDER BY id desc) WHERE ROWNUM = 1";
            OracleCommand pidcmd = new OracleCommand(pidquerry, con);
            OracleDataReader reader = pidcmd.ExecuteReader();
            while (reader.Read())
            {
                dbpid = Convert.ToInt32(reader.GetValue(0));
            }
            reader.Close();
            closeconnection();

            nxtpid = Convert.ToString(dbpid + 1);
            project_id.Text = nxtpid;
        }

        private void worktimecheck(string ceid)
        {
            int check = 0;
            openconnection();
            string employeeassignedquerry = "Select EmployeeId From AssignOfProject";
            OracleCommand eacmd = new OracleCommand(employeeassignedquerry, con);
            OracleDataReader eareader = eacmd.ExecuteReader();
            while (eareader.Read())
            {
                int ea = Convert.ToInt32(eareader.GetValue(0));
                if (ea == Convert.ToInt32(ceid))
                {
                    check = 1;
                }
            }
            eareader.Close();
            closeconnection();

            if (check == 1)
            {
                openconnection();
                string worktimecheckquerry = "Select Sum(WorkTime) from AssignOfProject where EmployeeId='" + Convert.ToInt32(ceid) + "' And WorkStatus=1 ";
                OracleCommand wtcmd = new OracleCommand(worktimecheckquerry, con);
                OracleDataReader reader = wtcmd.ExecuteReader();
                while (reader.Read())
                {
                    checkworktime = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
                closeconnection();
            }
            else
            {
                checkworktime = 0;
            }
        }

        private void employeestatuscheck(string employeeid)
        {
            int check = 0;
            openconnection();
            string querry = "SELECT * FROM (SELECT id FROM employee ORDER BY id desc) WHERE ROWNUM = 1";
            OracleCommand esccmd = new OracleCommand(querry, con);
            OracleDataReader escreader = esccmd.ExecuteReader();
            while (escreader.Read())
            {
                int ea = Convert.ToInt32(escreader.GetValue(0));
                if (ea >= Convert.ToInt32(employeeid))
                {
                    check = 1;
                }
            }
            escreader.Close();
            closeconnection();

            if (check == 1)
            {
                openconnection();
                string querry1 = "Select active From Employee Where Id = '" + Convert.ToInt32(employeeid) + "'";
                OracleCommand esc1cmd = new OracleCommand(querry1, con);
                OracleDataReader esc1reader = esc1cmd.ExecuteReader();
                while (esc1reader.Read())
                {
                    checkemployeestatus = esc1reader.GetInt32(0);
                }
                esc1reader.Close();
                closeconnection();
            }
        }

        private void projectmanageshow()
        {
            project_id.Text = givenpid;
            project_name.Text = pnm;
            project_deadline.Text = dl;
            project_budget.Text = bgt;
            project_currency.SelectedItem = currency;
            project_status.SelectedItem = status;
            assign_eid.Text = assignedeid;
            assign_pid.Text = givenpid;
            assign_worktime.Text = wt;
            assign_date.Text = ad;
            /*givenpid = "";
            pnm = "";
            dl = "";
            bgt = "";
            currency = "";
            status = "";
            assignedeid = "";
            wt = "";
            ad = "";*/
        }

        private void projectassignsearch(string cid)
        {
            //considering a project is assigned to only one employee
            openconnection();
            string strquerry = "Select * from Project where Id='" + Convert.ToInt32(cid) + "'";
            string strquerry1 = "Select * from AssignOfProject where ProjectId='" + Convert.ToInt32(cid) + "'";
            OracleCommand cmd = new OracleCommand(strquerry, con);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                projectdbpid = Convert.ToInt32(reader.GetValue(0));
                pnm = reader.GetString(1);
                dl = reader.GetString(2);
                projectdbbgt = Convert.ToInt32(reader.GetString(3));
                currency = reader.GetString(4);
                status = reader.GetString(5);
            }
            reader.Close();
            OracleCommand cmd1 = new OracleCommand(strquerry1, con);
            OracleDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                assigndbeid = Convert.ToInt32(reader1.GetValue(0));
                //dbpid = reader1.GetInt32(1);
                dbwt = Convert.ToInt32(reader1.GetValue(2));
                ad = reader1.GetString(3);
            }
            reader1.Close();
            closeconnection();

            assignedeid = Convert.ToString(assigndbeid);
            givenpid = Convert.ToString(projectdbpid);
            bgt = Convert.ToString(projectdbbgt);
            wt = Convert.ToString(dbwt);
            projectmanagesearchcount = 1;
        }

        private void projectmanageassign()
        {
            openconnection();
            string strquerry1 = "Insert into AssignOfProject(EmployeeId,ProjectId,WorkTime,AssignDate,WorkStatus) values('" + Convert.ToInt32(assign_eid.Text) + "','" + Convert.ToInt32(assign_pid.Text) + "','" + Convert.ToInt32(assign_worktime.Text) + "','" + assign_date.Text + "',1)";
            string strquerry2 = "Update Project Set Status='" + "Running" + "' Where Id ='" + Convert.ToInt32(assign_pid.Text) + "' ";
            OracleCommand cmd1 = new OracleCommand(strquerry1, con);
            OracleCommand cmd2 = new OracleCommand(strquerry2, con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            closeconnection();
        }

        private void ProjectData_Load()
        {
            checktable = 1; //for project table
            openconnection();
            string strquerry = "Select * From Project";
            //string strquerry = "Select * From Project Status = 1";

            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(strquerry, con);
            OracleCommandBuilder sqlCommandBuilder = new OracleCommandBuilder(sqlDataAdapter);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            projectmanageassign_dataGridView.DataSource = bindingSource;
            closeconnection();
        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        private void employeeManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employe ob = new Employe(Value);
            ob.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Hide();
        }

        private void ProjectManage_Add_Click(object sender, EventArgs e)
        {
            if (assign_pid.Text == "" && assign_eid.Text == "" && assign_worktime.Text == "" && assign_date.Text == "")
            {
                string givenstatus = "";

                givenstatus = Convert.ToString(project_status.SelectedItem);

                if (project_name.Text == "" || project_id.Text == "" || givenstatus == "" || project_budget.Text == "" || Convert.ToString(project_currency.SelectedItem) == "" || project_deadline.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
                    if (Convert.ToInt32(project_id.Text) >= Convert.ToInt32(nxtpid))
                    {
                        if (givenstatus != "Pending")
                        {
                            MessageBox.Show(" Newly Started Project Can Only Have the Status Pending ");
                        }
                        else
                        {
                            openconnection();
                            string strquerry = "Insert into Project(Id,Name,Deadline,Budget,Currency,Status) values('" + Convert.ToInt32(project_id.Text) + "','" + project_name.Text + "','" + project_deadline.Text + "','" + project_budget.Text + "', '" + Convert.ToString(project_currency.Text) + "', '" + Convert.ToString(project_status.SelectedItem) + "') ";
                            OracleCommand cmd = new OracleCommand(strquerry, con);
                            cmd.ExecuteNonQuery();
                            closeconnection();
                            MessageBox.Show(" Project Created Successfully ");
                            if (checktable == 1)
                                ProjectData_Load();
                            ProjectManage_Clear_Click(sender, e);
                            NextProjectId();

                        }
                    }
                    else
                        MessageBox.Show(" Project Id Is Already Given ");
                }
            }

            else if (project_id.Text == "" && project_name.Text == "" && project_deadline.Text == "" && project_budget.Text == "")
            {
                if (assign_eid.Text == "" || assign_pid.Text == "" || assign_worktime.Text == "" || assign_date.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
                    employeestatuscheck(assign_eid.Text);
                    if (checkemployeestatus == 1)
                    {
                        worktimecheck(assign_eid.Text);
                        int cwt = Convert.ToInt32(assign_worktime.Text);
                        checkworktime = checkworktime + cwt;

                        if (checkworktime <= 8)
                        {
                            projectmanageassign();
                            MessageBox.Show(" Project Assigned Successfully ");
                            if (checktable == 2)
                                Assign_Click(sender, e);
                            ProjectManage_Clear_Click(sender, e);
                        }
                        else
                            MessageBox.Show(" The Employee Cannot Give The Desired Time On This Project ");
                    }
                    else
                        MessageBox.Show(" Employee UNAVAILABLE ");
                }
            }

            else if (project_id.Text == assign_pid.Text)
            {
                if (assign_eid.Text == "" || assign_pid.Text == "" || assign_worktime.Text == "" || assign_date.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
                    employeestatuscheck(assign_eid.Text);
                    if (checkemployeestatus == 1)
                    {
                        worktimecheck(assign_eid.Text);
                        int cwt = Convert.ToInt32(assign_worktime.Text);
                        checkworktime = checkworktime + cwt;

                        if (checkworktime <= 8)
                        {
                            projectmanageassign();
                            MessageBox.Show(" Project Assigned Successfully ");
                            if (checktable == 2)
                                Assign_Click(sender, e);
                            ProjectManage_Clear_Click(sender, e);
                        }
                        else
                            MessageBox.Show(" The Employee Cannot Give The Desired Time On This Project ");
                    }
                    else
                        MessageBox.Show(" Employee UNAVAILABLE");
                }
            }

            else
                MessageBox.Show("Check The Information Boxes Carefully");
        }

        private void ProjectManage_Search_Click(object sender, EventArgs e)
        {
            if (project_id.Text != "" && assign_pid.Text == "" && assign_eid.Text == "")
            {
                projectassignsearch(project_id.Text);
                if (project_id.Text == givenpid)
                {
                    projectmanageshow();
                    if (status == "Pending")
                    {
                        assign_eid.Text = "";
                        assign_pid.Text = "";
                        assign_worktime.Text = "";
                        MessageBox.Show(" Project Hasn't Been Started Yet ");
                    }
                    else if (status == "Stalled")
                    {
                        if (assigndbeid == 0)
                        {
                            assign_eid.Text = "";
                            assign_pid.Text = "";
                            assign_worktime.Text = "";
                            MessageBox.Show(" Project was Never Started And Is Currently Stopped ");
                        }
                        else
                            MessageBox.Show(" Project Is Stopped Currently ");
                    }
                    else if (status == "Aborted")
                    {
                        if (assigndbeid == 0)
                        {
                            assign_eid.Text = "";
                            assign_pid.Text = "";
                            assign_worktime.Text = "";
                            MessageBox.Show(" Project was Never Started And Is Stopped For Good ");
                        }
                        else
                            MessageBox.Show(" Project Has Been Stopped For Good ");
                    }
                    else if (status == "Finished")
                        MessageBox.Show(" Project Is Successfully Completed ");
                }
                else
                {
                    MessageBox.Show(" Invalid Project Id ");
                    ProjectManage_Clear_Click(sender, e);
                }
            }

            else if (assign_pid.Text != "" && project_id.Text == "" && assign_eid.Text == "")
            {
                projectassignsearch(assign_pid.Text);
                project_id.Text = "";
                if (assign_pid.Text == givenpid)
                {
                    projectmanageshow();
                    if (status == "Pending")
                    {
                        assign_eid.Text = "";
                        assign_pid.Text = "";
                        assign_worktime.Text = "";
                        MessageBox.Show(" Project Hasn't Been Started Yet ");
                    }
                    else if (status == "Stalled")
                    {
                        if (assigndbeid == 0)
                        {
                            assign_eid.Text = "";
                            assign_pid.Text = "";
                            assign_worktime.Text = "";
                            MessageBox.Show(" Project was Never Started And I Currently Stopped ");
                        }
                        else
                            MessageBox.Show(" Project Is Stopped Currently ");
                    }
                    else if (status == "Aborted")
                    {
                        if (assigndbeid == 0)
                        {
                            assign_eid.Text = "";
                            assign_pid.Text = "";
                            assign_worktime.Text = "";
                            MessageBox.Show(" Project was Never Started And Is Stopped For Good ");
                        }
                        else
                            MessageBox.Show(" Project Has Been Stopped For Good ");
                    }
                    else if (status == "Finished")
                        MessageBox.Show(" Project Is Successfully Completed ");
                }
                else
                {
                    MessageBox.Show(" Invalid Project Id ");
                    ProjectManage_Clear_Click(sender, e);
                }
            }

            else if (assign_pid.Text == "" && project_id.Text == "" && assign_eid.Text != "")
            {
                employeestatuscheck(assign_eid.Text);
                if (checkemployeestatus == 1)
                {
                    worktimecheck(assign_eid.Text);
                    checkworktime = 8 - checkworktime;
                    if (checkworktime > 0 && checkworktime <= 8)
                    {
                        assign_worktime.Text = Convert.ToString(checkworktime);
                        MessageBox.Show(" Employee's Free Time is Calculated ");
                    }
                    else
                    {
                        assign_worktime.Text = Convert.ToString(checkworktime);
                        MessageBox.Show(" Employee's Has Never Been Assigned Any Project Before ");
                    }
                }
                else
                    MessageBox.Show(" Employee UNAVAILABLE");
            }

            else
            {
                MessageBox.Show(" Give Proper ID In Any Individual One ");
                ProjectManage_Clear_Click(sender, e);
            }
        }

        private void ProjectManage_Delete_Click(object sender, EventArgs e)
        {
            int pid = 0;
            if (project_id.Text != "" && assign_pid.Text == "")
            {
                pid = Convert.ToInt32(project_id.Text);
                openconnection();
                string strquerry = "Update Project Set Status='" + "Aborted" + "' Where  ProjectId='" + pid + "' ";
                OracleCommand cmd = new OracleCommand(strquerry, con);
                cmd.ExecuteNonQuery();

                projectassignsearch(project_id.Text);

                if (status != "Pending" && assigndbeid != 0)
                {
                    openconnection();
                    string strquerry1 = "Update AssignOfProject Set WorkStatus=0 Where  ProjectId='" + pid + "' ";
                    OracleCommand cmd1 = new OracleCommand(strquerry1, con);
                    cmd1.ExecuteNonQuery();
                    closeconnection();
                }

                MessageBox.Show(" Project Aborted Successfully ");
                if (checktable == 1)
                    ProjectData_Load();
                ProjectManage_Clear_Click(sender, e);
            }

            else if (assign_pid.Text != "" && project_id.Text == "")
            {
                pid = Convert.ToInt32(assign_pid.Text);
                openconnection();
                string strquerry2 = "Update Project Set Status='" + "Aborted" + "' Where  Id='" + pid + "' ";
                OracleCommand cmd2 = new OracleCommand(strquerry2, con);
                cmd2.ExecuteNonQuery();

                projectassignsearch(assign_pid.Text);

                if (status != "Pending" && assigndbeid != 0)
                {
                    openconnection();
                    string strquerry3 = "Update AssignOfProject Set WorkStatus=0 Where  ProjectId='" + pid + "'";
                    OracleCommand cmd3 = new OracleCommand(strquerry3, con);
                    cmd3.ExecuteNonQuery();
                    closeconnection();
                }

                MessageBox.Show(" Project Aborted Successfully ");
                if (checktable == 1)
                    ProjectData_Load();
                ProjectManage_Clear_Click(sender, e);
            }

            else if (project_id.Text != "" && assign_pid.Text != "" && project_id.Text == assign_pid.Text)
            {
                pid = Convert.ToInt32(assign_pid.Text);
                openconnection();
                string strquerry4 = "Update Project Set Status='" + "Aborted" + "' Where  ProjectId='" + pid + "' ";
                string strquerry3 = "Update AssignOfProject Set WorkStatus=0 Where  ProjectId='" + pid + "' ";
                OracleCommand cmd4 = new OracleCommand(strquerry4, con);
                cmd4.ExecuteNonQuery();
                OracleCommand cmd3 = new OracleCommand(strquerry3, con);
                cmd3.ExecuteNonQuery();
                closeconnection();

                MessageBox.Show(" Project Aborted Successfully ");
                if (checktable == 1)
                    ProjectData_Load();
                ProjectManage_Clear_Click(sender, e);
            }
            else
                MessageBox.Show("ERROR\nGive Any Individual Project Id");
        }

        private void ProjectManage_Clear_Click(object sender, EventArgs e)
        {
            project_id.Text = "";
            project_name.Text = "";
            project_deadline.Text = "";
            project_budget.Text = "";
            project_currency.ResetText();
            project_status.ResetText();
            assign_eid.Text = "";
            assign_pid.Text = "";
            assign_worktime.Text = "";
            assign_date.Text = "";
            projectmanagesearchcount = 0;
            NextProjectId();
            if (checktable == 1)
                ProjectData_Load();
            else if (checktable == 2)
                Assign_Click(sender, e);
        }

        private void ProjectManage_Update_Click(object sender, EventArgs e)
        {
            int updatecount = 0;
            if (project_id.Text != "" && assign_pid.Text == "" && assign_eid.Text == "")
            {
                if (Convert.ToInt32(project_id.Text) < Convert.ToInt32(nxtpid))
                {
                    if (projectmanagesearchcount == 0)
                        projectassignsearch(project_id.Text); ;

                    if (status == "Finished")
                        MessageBox.Show(" ERROR\n Project Is Already Finished. No Need To Update Any Info.\n If Necessary Create A New Project ");
                    else if (status == "Aborted")
                        MessageBox.Show("ERROR\nAborted Project's Information Cannot Be Updated.\nIf Necesaary First Change The Status Into Pending (if never started) Or Stalled");
                    else if (status == "Pending")
                    {
                        if (pnm != project_name.Text)
                        {
                            string updatequerry = "Update Project Set Name='" + project_name.Text + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry);
                            updatecount++;
                        }
                        if (project_deadline.Text != dl)
                        {
                            string updatequerry1 = "Update Project Set Deadline='" + project_deadline.Text + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry1);
                            updatecount++;
                        }
                        if (project_budget.Text != bgt)
                        {
                            string updatequerry2 = "Update Project Set Budget='" + Convert.ToInt32(project_budget.Text) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry2);
                            updatecount++;
                        }
                        if (Convert.ToString(project_currency.SelectedItem) != currency)
                        {
                            string updatequerry3 = "Update Project Set Currency='" + Convert.ToString(project_currency.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry3);
                            updatecount++;
                        }
                        if (Convert.ToString(project_status.SelectedItem) != status)
                        {
                            if (Convert.ToString(project_status.SelectedItem) == "Finished")
                                MessageBox.Show(" ERROR\n Pending Projects Cannot Be Finished ");
                            else if (Convert.ToString(project_status.SelectedItem) == "Running")
                                MessageBox.Show(" ERROR\n Assign An Employee To The Project To Make It Ruunning ");
                            else if (Convert.ToString(project_status.SelectedItem) == "Aborted")
                                MessageBox.Show(" ERROR\n Delete The Project To Do So ");
                            else
                            {
                                string updatequerry4 = "Update Project Set Status='" + Convert.ToString(project_status.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                                runquerry(updatequerry4);
                                updatecount++;
                            }
                        }
                    }
                    else if (status == "Running")
                    {
                        if (pnm != project_name.Text)
                        {
                            string updatequerry5 = "Update Project Set Name='" + project_name.Text + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry5);
                            updatecount++;
                        }
                        if (project_deadline.Text != dl)
                        {
                            string updatequerry6 = "Update Project Set Deadline='" + project_deadline.Text + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry6);
                            updatecount++;
                        }
                        if (project_budget.Text != bgt)
                        {
                            string updatequerry7 = "Update Project Set Budget='" + Convert.ToInt32(project_budget.Text) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry7);
                            updatecount++;
                        }
                        if (Convert.ToString(project_currency.SelectedItem) != currency)
                        {
                            string updatequerry8 = "Update Project Set Currency='" + Convert.ToString(project_currency.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry8);
                            updatecount++;
                        }
                        if (Convert.ToString(project_status.SelectedItem) != status)
                        {
                            if (Convert.ToString(project_status.SelectedItem) == "Pending")
                                MessageBox.Show(" ERROR\n Running Projects Cannot Be Pending. It May Be Stalled ");
                            else if (Convert.ToString(project_status.SelectedItem) == "Aborted")
                                MessageBox.Show(" ERROR\n Delete The Project To Do So ");
                            else
                            {
                                string updatequerry9 = "Update Project Set Status='" + Convert.ToString(project_status.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                                string updatequerry10 = "Update AssignOfProject Set WorkStatus=0 Where ProjectId ='" + Convert.ToInt32(project_id.Text) + "' ";
                                runquerry(updatequerry9);
                                runquerry(updatequerry10);
                                updatecount++;
                            }
                        }
                    }
                    else if (status == "Stalled")
                    {
                        if (pnm != project_name.Text)
                        {
                            string updatequerry16 = "Update Project Set Name='" + project_name.Text + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry16);
                            updatecount++;
                        }
                        if (project_deadline.Text != dl)
                        {
                            string updatequerry17 = "Update Project Set Deadline='" + project_deadline.Text + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry17);
                            updatecount++;
                        }
                        if (project_budget.Text != bgt)
                        {
                            string updatequerry18 = "Update Project Set Budget='" + Convert.ToInt32(project_budget.Text) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry18);
                            updatecount++;
                        }
                        if (Convert.ToString(project_currency.SelectedItem) != currency)
                        {
                            string updatequerry19 = "Update Project Set Currency='" + Convert.ToString(project_currency.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                            runquerry(updatequerry19);
                            updatecount++;
                        }
                        if (Convert.ToString(project_status.SelectedItem) != status)
                        {
                            if (Convert.ToString(project_status.SelectedItem) == "Finished")
                                MessageBox.Show(" ERROR\n Stalled Projects Cannot Be Finished ");
                            else if (Convert.ToString(project_status.SelectedItem) == "Aborted")
                                MessageBox.Show(" ERROR\n Delete The Project To Do So");
                            else
                            {
                                if (assignedeid == "")
                                {
                                    if (Convert.ToString(project_status.SelectedItem) == "Running")
                                        MessageBox.Show(" ERROR\n First Assign An Employee ");
                                    else
                                    {
                                        string updatequerry22 = "Update Project Set Status='" + Convert.ToString(project_status.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                                        runquerry(updatequerry22);
                                        updatecount++;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToString(project_status.SelectedItem) == "Pending")
                                        MessageBox.Show("ERROR\nA Project Stalled While Running Cannot Be Pending");
                                    else
                                    {
                                        string updatequerry20 = "Update Project Set Status='" + Convert.ToString(project_status.SelectedItem) + "' Where Id ='" + Convert.ToInt32(project_id.Text) + "' ";
                                        string updatequerry21 = "Update AssignOfProject Set WorkStatus=1 Where ProjectId ='" + Convert.ToInt32(project_id.Text) + "' ";
                                        runquerry(updatequerry20);
                                        runquerry(updatequerry21);
                                        updatecount++;
                                    }
                                }
                            }
                        }
                    }
                    if (checktable == 1)
                        ProjectData_Load();
                    else if (checktable == 2)
                        Assign_Click(sender, e);
                }
                else
                    MessageBox.Show(" Invalid Project ID ");
            }

            else if (project_id.Text == "" && assign_eid.Text != "" && assign_pid.Text != "")  //considering assign gridview will only show the running projects
            {                                                                                  //and one project is assigned to only one employee
                if (projectmanagesearchcount == 0)
                    projectassignsearch(assign_pid.Text);
                if (assign_eid.Text != assignedeid)
                {
                    employeestatuscheck(assign_eid.Text);
                    if (checkemployeestatus == 1)
                    {
                        worktimecheck(assign_eid.Text);
                        int cwt = Convert.ToInt32(assign_worktime.Text);
                        checkworktime = checkworktime + cwt;
                        if (checkworktime <= 8)
                        {
                            string updatequerry11 = "Update AssignOfProject Set EmployeeId='" + Convert.ToInt32(assign_eid.Text) + "' Where ProjectId ='" + Convert.ToInt32(assign_pid.Text) + "' And EmployeeId='" + Convert.ToInt32(assignedeid) + "' ";
                            runquerry(updatequerry11);
                            updatecount++;
                        }
                        else
                            MessageBox.Show("The Employee Cannot Give Desired Time In This Project");
                    }
                    else
                        MessageBox.Show(" Employee UNAVAILABLE ");
                }
                if (assign_pid.Text != givenpid && assign_eid.Text == assignedeid)
                {
                    int checkelsedoing = 0;
                    openconnection();
                    string strquerry123 = "Select Count(EmployeeId) from AssignOfProject Where ProjectId='" + Convert.ToInt32(givenpid) + "' AND WorkStatus=1";
                    OracleCommand cmd123 = new OracleCommand(strquerry123, con);

                    OracleDataReader reader123 = cmd123.ExecuteReader();
                    while (reader123.Read())
                    {
                        checkelsedoing = reader123.GetInt32(0);
                    }
                    reader123.Close();
                    closeconnection();
                    //assign_worktime.Text = Convert.ToString(checkelsedoing);
                    if (checkelsedoing == 1)
                    {
                        string updatequerry23 = "Update Project Set Status='" + "Stalled" + "' Where Id ='" + Convert.ToInt32(givenpid) + "' ";
                        string updatequerry24 = "Update AssignOfProject Set ProjectId ='" + Convert.ToInt32(assign_pid.Text) + "' Where EmployeeId='" + Convert.ToInt32(assignedeid) + "' And ProjectId ='" + Convert.ToInt32(givenpid) + "' ";
                        runquerry(updatequerry23);
                        runquerry(updatequerry24);
                        updatecount++;
                    }
                    else if (checkelsedoing > 1)
                    {
                        string updatequerry25 = "Update AssignOfProject Set ProjectId ='" + Convert.ToInt32(assign_pid.Text) + "' Where EmployeeId='" + Convert.ToInt32(assignedeid) + "' And ProjectId ='" + Convert.ToInt32(givenpid) + "' ";
                        runquerry(updatequerry25);
                        updatecount++;
                    }
                    else
                        MessageBox.Show("ERROR.\nA New And Pending Project Cannot Be Assigned To An Employee Through Update.\nAssign The Project Afresh To The Employee.\nIf Necessary Stall Any His/Her Current Project");
                }
                if (assign_worktime.Text != wt)
                {
                    worktimecheck(assign_eid.Text);
                    int cwt = Convert.ToInt32(assign_worktime.Text);
                    checkworktime = checkworktime + cwt;
                    if (checkworktime <= 8)
                    {
                        string updatequerry14 = "Update AssignOfProject Set WorkTime='" + Convert.ToInt32(assign_worktime.Text) + "' Where ProjectId ='" + Convert.ToInt32(assign_pid.Text) + "' And EmployeeId='" + Convert.ToInt32(assign_eid.Text) + "' ";
                        runquerry(updatequerry14);
                        updatecount++;
                    }
                    else
                        MessageBox.Show("The Employee Cannot Give Desired Time In This Project");
                }
                if (assign_date.Text != ad)
                {
                    string updatequerry15 = "Update AssignOfProject Set AssignDate='" + Convert.ToString(assign_date.Text) + "' Where ProjectId ='" + Convert.ToInt32(assign_pid.Text) + "' And EmployeeId='" + Convert.ToInt32(assign_eid.Text) + "' ";
                    runquerry(updatequerry15);
                    updatecount++;
                }
                if (checktable == 1)
                    ProjectData_Load();
                else if (checktable == 2)
                    Assign_Click(sender, e);
            }

            else
            {
                MessageBox.Show("System Is Confused");
                ProjectManage_Clear_Click(sender, e);
            }

            if (updatecount > 0)
            {
                MessageBox.Show(updatecount + " Update Done Successfully");
                updatecount = 0;
            }
            projectmanagesearchcount = 0;
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            ProjectData_Load();
        }

        private void Assign_Click(object sender, EventArgs e)
        {
            //ProjectManage_Clear_Click(sender, e);
            checktable = 2; //for assign table
            openconnection();
            string strquerry = "Select EmployeeId,ProjectId,WorkTime,AssignDate From AssignOfProject Where WorkStatus=1"; //Order By Employee_Id ASC korte hobe
            //string strquerry = "Select * From Project Where Status = 1";

            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(strquerry, con);
            OracleCommandBuilder sqlCommandBuilder = new OracleCommandBuilder(sqlDataAdapter);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            projectmanageassign_dataGridView.DataSource = bindingSource;
            closeconnection();
        }

        private void projectmanageassign_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checktable == 1)
            {
                /*ProjectManage_Clear_Click(sender, e);
                project_id.Text = "";*/
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.projectmanageassign_dataGridView.Rows[e.RowIndex];

                    project_id.Text = row.Cells[0].Value.ToString();
                    project_name.Text = row.Cells[1].Value.ToString();
                    project_deadline.Text = row.Cells[2].Value.ToString();
                    project_budget.Text = row.Cells[3].Value.ToString();
                    project_currency.SelectedItem = row.Cells[4].Value.ToString();
                    project_status.SelectedItem = row.Cells[5].Value.ToString();
                    //
                    pnm = row.Cells[1].Value.ToString();
                    dl = row.Cells[2].Value.ToString();
                    bgt = row.Cells[3].Value.ToString();
                    currency = row.Cells[4].Value.ToString();
                    status = row.Cells[5].Value.ToString();
                    projectmanagesearchcount = 1;
                }
            }
            else if (checktable == 2)
            {
                //ProjectManage_Clear_Click(sender, e);
                project_id.Text = "";
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.projectmanageassign_dataGridView.Rows[e.RowIndex];

                    assign_eid.Text = row.Cells[0].Value.ToString();
                    assign_pid.Text = row.Cells[1].Value.ToString();
                    assign_worktime.Text = row.Cells[2].Value.ToString();
                    assign_date.Text = row.Cells[3].Value.ToString();
                    //
                    assignedeid = row.Cells[0].Value.ToString();
                    givenpid = row.Cells[1].Value.ToString();
                    wt = row.Cells[2].Value.ToString();
                    ad = row.Cells[3].Value.ToString();
                    projectmanagesearchcount = 1;
                }
            }
            else
                MessageBox.Show("CONFUSED");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = "System Time : " + datetime.ToString();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ob = new Account(Value);
            this.Hide();
            ob.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ob = new About();
            ob.Show();
        }
    }
}
