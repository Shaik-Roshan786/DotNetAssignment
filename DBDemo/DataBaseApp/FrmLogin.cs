using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DataBaseApp
{
    public partial class FrmLogin : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=Training;Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            // string sql = "select count(*) from userdata where username='" + txtUserName.Text + "' and password='" + txtPassword.Text +"'";

            //parameterized query
            string sql = "select count(*) from userdata where username=@name and password=@pwd";
            SqlCommand command = new SqlCommand(sql, connection);
            //pass value for the parameter
            command.Parameters.AddWithValue("name", txtUsername.Text);
            command.Parameters.AddWithValue("pwd", txtPassword.Text);
            //open connection
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();

            if (count ==1)
            {
                lblMessage.Text = "Valid User";
                lblMessage.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblMessage.Text = "Invalid Username or Password";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
