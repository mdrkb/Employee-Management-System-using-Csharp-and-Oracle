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
    public partial class Account : Form
    {
        OracleConnection con;

        int aeid = 0;
        int apid = 0;
        int asalary = 0;
        int abonus = 0;
        int flag = 0;
        int Value;

        public Account()
        {
            InitializeComponent();
            timer.Start();
            Data_Load();
            accountsToolStripMenuItem.Enabled = false;
        }

        public Account(int value)
        {
            Value = value;
            if (value == 1)
            {
                InitializeComponent();
                timer.Start();
                Data_Load();
                accountsToolStripMenuItem.Enabled = false;
                label8.Text = "Super Admin";
            }
            else if (value == 4)
            {
                InitializeComponent();
                timer.Start();
                Data_Load();
                accountsToolStripMenuItem.Enabled = false;
                projectManageToolStripMenuItem.Visible = false;
                employeeManageToolStripMenuItem.Visible = false;
                label8.Text = "Accounts Admin";
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

        private void Data_Load()
        {
            openconnection();
            string strquerry = "Select * From Salary";

            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(strquerry, con);
            OracleCommandBuilder sqlCommandBuilder = new OracleCommandBuilder(sqlDataAdapter);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            accountmanage_dataGridView.DataSource = bindingSource;
            closeconnection();
        }

        public void search()
        {
            if (account_employee_id.Text == "" || account_project_id.Text == "")
            {
                MessageBox.Show("Fill Both ID fields");
            }

            else
            {
                openconnection();

                string strquerry = "Select * from salary where EmployeeId='" + Convert.ToInt32(account_employee_id.Text) + "' And ProjectId='" + Convert.ToInt32(account_project_id.Text) + "' ";
                OracleCommand cmd = new OracleCommand(strquerry, con);

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aeid = Convert.ToInt32(reader.GetValue(0));
                    apid = Convert.ToInt32(reader.GetValue(1));
                    asalary = Convert.ToInt32(reader.GetValue(2));
                    abonus = Convert.ToInt32(reader.GetValue(3));
                }

                reader.Close();

                closeconnection();
            }

            if (asalary > 0 && abonus > 0)
                flag = 1;
            else
                flag = 0;
        }


        private void AccountManage_Pay_Click(object sender, EventArgs e)
        {

            if (account_employee_id.Text == "" || account_project_id.Text == "")
            {
                MessageBox.Show("Fill all ID fields");
            }
            else
            {
                if (flag == 0)
                {
                    if (salary.Text == "" || bonus.Text == "")
                    {
                        MessageBox.Show("Fill Bonus or Salary Field");
                    }
                    else
                    {
                        openconnection();

                        string strquerry = "Insert into Salary(EmployeeId,ProjectId,Salary,Bonus) values('" + Convert.ToInt32(account_employee_id.Text) + "','" + Convert.ToInt32(account_project_id.Text) + "','" + Convert.ToInt32(salary.Text) + "','" + Convert.ToInt32(bonus.Text) + "') ";
                        OracleCommand cmd = new OracleCommand(strquerry, con);
                        cmd.ExecuteNonQuery();

                        closeconnection();
                        MessageBox.Show("Added successfully");

                        Data_Load();
                        ProjectManage_Clear_Click(sender, e);
                    }
                }
                else
                    MessageBox.Show("This Employee Has already Been Paid Something for this Project. Try Update if Necessary");

            }
        }

        private void ProjectManage_Clear_Click(object sender, EventArgs e)
        {
            account_employee_id.Text = "";
            account_project_id.Text = "";
            salary.Text = "";
            bonus.Text = "";
        }

        private void AccountManage_Find_Click(object sender, EventArgs e)
        {
            if (account_employee_id.Text == "" || account_project_id.Text == "")
            {
                MessageBox.Show("Fill Both ID fields");
            }

            else
            {
                openconnection();

                string strquerry = "Select * from salary where EmployeeId='" + Convert.ToInt32(account_employee_id.Text) + "' And ProjectId='" + Convert.ToInt32(account_project_id.Text) + "' ";
                OracleCommand cmd = new OracleCommand(strquerry, con);

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aeid = Convert.ToInt32(reader.GetValue(0));
                    apid = Convert.ToInt32(reader.GetValue(1));
                    asalary = Convert.ToInt32(reader.GetValue(2));
                    abonus = Convert.ToInt32(reader.GetValue(3));
                }

                reader.Close();

                closeconnection();
            }

            if (asalary > 0 && abonus > 0)
                flag = 1;
            else
                flag = 0;  
        }

        private void AccountManage_Update_Click(object sender, EventArgs e)
        {
            if (account_employee_id.Text == "" || account_project_id.Text == "")
            {
                MessageBox.Show("Fill all ID fields");
            }
            else
            {
                if (salary.Text == "" && bonus.Text == "")
                {
                    MessageBox.Show("Fill Bonus or Salary Field");
                }
                else
                {
                    openconnection();

                    string strquerry = "Update Salary Set Salary='" + Convert.ToInt32(salary.Text) + "',Bonus='" + Convert.ToInt32(bonus.Text) + "' Where EmployeeId ='" + Convert.ToInt32(account_employee_id.Text) + "' And ProjectId ='" + Convert.ToInt32(account_project_id.Text) + "' ";
                    OracleCommand cmd = new OracleCommand(strquerry, con);
                    cmd.ExecuteNonQuery();

                    closeconnection();

                    MessageBox.Show("Updated successfully");
                    ProjectManage_Clear_Click(sender, e);
                    Data_Load();
                }
            }
        }

        private void AccountManage_Delete_Click(object sender, EventArgs e)
        {
            if (account_employee_id.Text == "" && account_project_id.Text == "")
            {
                MessageBox.Show("Fill all ID fields");
            }
            else
            {
                openconnection();

                string strquerry = "begin ps_delsal(" + account_employee_id.Text + ", " + account_project_id.Text + "); end;";
                //MessageBox.Show(strquerry);
                OracleCommand cmd = new OracleCommand(strquerry, con);
                cmd.ExecuteNonQuery();

                closeconnection();

                MessageBox.Show("Deleted successfully");
                ProjectManage_Clear_Click(sender, e);
                Data_Load();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = "System Time : " + datetime.ToString();
        }

        private void accountmanage_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void accountmanage_dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.accountmanage_dataGridView.Rows[e.RowIndex];
                //MessageBox.Show(row.ToString());

                account_employee_id.Text = row.Cells[0].Value.ToString();
                account_project_id.Text = row.Cells[1].Value.ToString();
                salary.Text = row.Cells[2].Value.ToString();
                bonus.Text = row.Cells[3].Value.ToString();
            }
        }

        private void employeeManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employe ob = new Employe(Value);
            ob.Show();
            this.Hide();
        }

        private void projectManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project ob = new Project(Value);
            ob.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ob = new About();
            ob.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Hide();
        }

        private void totalsalary_Click(object sender, EventArgs e)
        {
            int sal = 0, bon = 0, totalsal = 0;
            if (account_employee_id.Text == "")
            {
                MessageBox.Show("Employee id is empty.");
            }
            else
            {
                openconnection();

                string strquerry1 = "select fn_salarycount(" + account_employee_id.Text + ") from dual";
                OracleCommand cmd = new OracleCommand(strquerry1, con);

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sal = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();

                string strquerry2 = "select fn_bonuscount(" + account_employee_id.Text + ") from dual";
                cmd = new OracleCommand(strquerry2, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bon = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();

                totalsal = sal + bon;
                MessageBox.Show("Total salary is " + totalsal);

                closeconnection();
            }
        }
    }
}
