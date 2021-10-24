using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFAssignment2.Models;

namespace EFAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            TrainingContext db = new TrainingContext();
            string username = "admin";
            string password = "123";
            Userdatum user = db.Userdata.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                lblMsg.Text = "Valid User";
            }
            else
            {
                lblMsg.Text = "Invalid User";
            }
        }
    }
}
