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
    public partial class Employe : Form
    {
        OracleConnection con;
        int Value;

        public Employe()
        {
            InitializeComponent();
            Data_Load();
            NextEmployeeId();
            timer.Start();
            employeeManageToolStripMenuItem.Enabled = false;
        }

        public Employe(int value)
        {
            Value = value;
            if (value == 1)
            {
                InitializeComponent();
                Data_Load();
                NextEmployeeId();
                timer.Start();
                employeeManageToolStripMenuItem.Enabled = false;
                label8.Text = "Super Admin";
            }
            else if (value == 2)
            {
                InitializeComponent();
                Data_Load();
                NextEmployeeId();
                timer.Start();
                employeeManageToolStripMenuItem.Enabled = false;
                projectManageToolStripMenuItem.Visible = false;
                accountsToolStripMenuItem.Visible = false;
                label8.Text = "Management Admin";
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
            string strquerry = "Select id,name,nationalid,Designation,contact,address,experience From employee where active = 1";

            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(strquerry, con);
            OracleCommandBuilder sqlCommandBuilder = new OracleCommandBuilder(sqlDataAdapter);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            employee_dataGridView.DataSource = bindingSource;
            closeconnection();
        }

        private void NextEmployeeId()
        {
            int dbeid = 0;
            string eid = "";

            openconnection();

            string strquerry1 = "SELECT * FROM (SELECT id FROM employee ORDER BY id desc) WHERE ROWNUM = 1";
            OracleCommand cmd = new OracleCommand(strquerry1, con);

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dbeid = Convert.ToInt32(reader.GetValue(0));
            }
            reader.Close();

            closeconnection();

            eid = Convert.ToString(dbeid + 1);
            employeeid.Text = eid;
        }

        private void Employe_Load(object sender, EventArgs e)
        {

        }

        private void projectManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project ob = new Project(Value);
            ob.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string givendesignation = "";

            givendesignation = Convert.ToString(designation.SelectedItem);

            if (name.Text == "" || national_id.Text == "" || givendesignation == "" || contact.Text == "" || address.Text == "" || experience.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                openconnection();

                string strquerry = "Insert into employee(id,name,nationalid,designation,contact,address,experience,active) values('" + Convert.ToInt32(employeeid.Text) + "','" + name.Text + "','" + Convert.ToInt64(national_id.Text) + "','" + Convert.ToString(designation.SelectedItem) + "','" + contact.Text + "','" + address.Text + "','" + experience.Text + "', 1) ";
                OracleCommand cmd = new OracleCommand(strquerry, con);
                cmd.ExecuteNonQuery();

                closeconnection();
                MessageBox.Show("Added successfully");

                Data_Load();
                clear_Click(sender, e);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int dbeid = 0;
            string eid = "";
            string enm = "";
            string enid = "";
            string dgn = "";
            string econtact = "";
            string add = "";
            string exprnc = "";
            int status = 0;

            openconnection();

            string strquerry = "Select * from employee where id='" + Convert.ToInt32(employeeid.Text) + "'";
            OracleCommand cmd = new OracleCommand(strquerry, con);

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dbeid = reader.GetInt32(0);
                enm = reader.GetString(1);
                enid = reader.GetString(2);
                dgn = reader.GetString(3);
                econtact = reader.GetString(4);
                add = reader.GetString(5);
                exprnc = reader.GetString(6);
                status = reader.GetInt32(7);

            }

            reader.Close();

            closeconnection();

            eid = Convert.ToString(dbeid);
            if (employeeid.Text == eid)
            {
                name.Text = enm;
                national_id.Text = enid;
                designation.SelectedItem = dgn;
                contact.Text = econtact;
                address.Text = add;
                experience.Text = exprnc;
                if (status == 0)
                    MessageBox.Show("Employee doesn't work here anymore");
            }
            else
                MessageBox.Show("Invalid Employee Id");
        }

        private void update_Click(object sender, EventArgs e)
        {
            string givendgn = "";
            int givenid = 0;

            givendgn = Convert.ToString(designation.SelectedItem);
            givenid = Convert.ToInt32(employeeid.Text);

            if (name.Text == "" || national_id.Text == "" || givendgn == "" || contact.Text == "" || address.Text == "" || experience.Text == "")
            {
                MessageBox.Show("Give All the Informations Properly");
            }
            else
            {
                openconnection();

                string strquerry = "Update employee Set name='" + name.Text + "',nationalid='" + Convert.ToInt64(national_id.Text) + "',designation='" + givendgn + "',contact='" + contact.Text + "',address='" + address.Text + "',experience='" + experience.Text + "' Where id ='" + givenid + "' ";
                OracleCommand cmd = new OracleCommand(strquerry, con);
                cmd.ExecuteNonQuery();

                closeconnection();

                MessageBox.Show("Updated successfully");
                Data_Load();
                clear_Click(sender, e);
            } 
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int givenid = 0;

            givenid = Convert.ToInt32(employeeid.Text);

            openconnection();

            string strquerry = "begin ps_delemp("+givenid+"); end;";
            OracleCommand cmd = new OracleCommand(strquerry, con);
            cmd.ExecuteNonQuery();

            closeconnection();

            MessageBox.Show("Deleted successfully");
            clear_Click(sender, e);
            Data_Load();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            employeeid.Text = "";
            name.Text = "";
            national_id.Text = "";
            designation.ResetText();
            contact.Text = "";
            address.Text = "";
            experience.Text = "";

            NextEmployeeId();
        }

        private void employee_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.employee_dataGridView.Rows[e.RowIndex];

                employeeid.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                national_id.Text = row.Cells[2].Value.ToString();
                contact.Text = row.Cells[4].Value.ToString();
                designation.SelectedItem = row.Cells[3].Value.ToString();
                address.Text = row.Cells[5].Value.ToString();
                experience.Text = row.Cells[6].Value.ToString();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = "System Time : " + datetime.ToString();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ob = new Account(Value);
            ob.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ob = new About();
            ob.Show();
        }

        private void jobcount_Click(object sender, EventArgs e)
        {
            int jobcount = 0;
            if(employeeid.Text==""){
                MessageBox.Show("Employee id is empty.");
            }else{
                openconnection();

                string strquerry1 = "select fn_jobcount("+employeeid.Text+") from dual";
                OracleCommand cmd = new OracleCommand(strquerry1, con);

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jobcount = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();

                MessageBox.Show("Total no of jobs is "+ jobcount);

                closeconnection();
            }
        }
    }
}
