using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDemo
{
    public partial class lblMsg : Form
    {
        public lblMsg()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double result = double.Parse(txtFirst.Text) + double.Parse(txtSecond.Text);
            lblMssg.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = double.Parse(txtFirst.Text) - double.Parse(txtSecond.Text);
            lblMssg.Text = result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double result = double.Parse(txtFirst.Text) * double.Parse(txtSecond.Text);
            lblMssg.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtSecond.Text) > 1)
            {
                double result = double.Parse(txtFirst.Text) / double.Parse(txtSecond.Text);
                lblMssg.Text = result.ToString();
            }
            else
            {
                lblMssg.Text = "cannot divide by 0";
            }


        }
    }
}
