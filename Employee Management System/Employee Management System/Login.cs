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

    public partial class Login : Form
    {
        OracleConnection con;

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

        public Login()
        {
            InitializeComponent();
        }

        
        private void login_button_Click(object sender, EventArgs e)
        {
            string unm = "";
            string upw = "";
            string utype = "";
            string givenusertype = "";
            int value = 0;

            givenusertype = Convert.ToString(logintype.SelectedItem);

            if (username.Text == "" && password.Text == "" && givenusertype == "")
            {
                MessageBox.Show("Please Enter Username, Password and Select User Type");
            }

            else if (username.Text == "")
            {
                MessageBox.Show("Enter Username");
            }

            else if (password.Text == "")
            {
                MessageBox.Show("Enter Password");
            }

            else if (givenusertype == "")
            {
                MessageBox.Show("Select User Type");
            }

            else
            {
                openconnection();

                string strquerry = "Select * from login where username='" + username.Text.Trim() + "' and password='" + password.Text + "' and authority='" + givenusertype + "'";
                OracleCommand cmd = new OracleCommand(strquerry, con);

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    unm = reader.GetString(1).Trim();
                    upw = reader.GetString(2);
                    utype = reader.GetString(3);
                }

                reader.Close();

                closeconnection();

                if (username.Text.Trim() == unm && password.Text == upw && givenusertype == utype)
                {
                    switch (givenusertype)
                    {
                        case "Super admin": value = 1;
                            break;
                        case "Management admin": value = 2;
                            break;
                        case "Project admin": value = 3;
                            break;
                        case "Accounts admin": value = 4;
                            break;
                    }

                    if(value==1){
                        Employe ob = new Employe(1);
                        ob.Show();
                        this.Hide();
                    }else if(value==2){
                        Employe ob = new Employe(2);
                        ob.Show();
                        this.Hide();
                    }else if(value==3){
                        Project ob = new Project(3);
                        ob.Show();
                        this.Hide();
                    }else{
                        Account ob = new Account(4);
                        ob.Show();
                        this.Hide();
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Invalid Name, Password or User Type");
                    username.Text = "";
                    password.Text = "";
                    logintype.ResetText();
                }
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void logintype_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
