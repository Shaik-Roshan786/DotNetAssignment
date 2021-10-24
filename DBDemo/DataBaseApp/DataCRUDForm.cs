using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace DataBaseApp
{
    public partial class DataCRUDForm : Form
    {
        EmpDataStore dataStore = new EmpDataStore(@"server = (localdb)\MSSQLLocalDB;database = Training;Integrated Security = True");
        public DataCRUDForm()
        {
            InitializeComponent();
        }
        private void DataCRUDForm_Load(object sender, EventArgs e)
        {
            dgData.DataSource = dataStore.GetEmps();
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

