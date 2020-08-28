using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLAB_EXAM
{
    public partial class Remove_Department : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public Remove_Department(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void Remove_Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet6.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hospitalDataSet6.Department);

        }

        private void BFind_Click(object sender, EventArgs e)
        {
            if(CBDEPID.Text=="")
            {
                MessageBox.Show("Please Insert The Department ID");
            }
            else
            {
                DataTable dt = controllerObj.GetDepID(int.Parse(CBDEPID.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void BShow_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDepartment();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            if (CBDEPID.Text == "")
            {
                MessageBox.Show("Please Insert The Department ID");
            }
            else
            {
                MessageBox.Show("Removed Successfully");
                DataTable dt = controllerObj.DeleteDepartment(int.Parse(CBDEPID.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh(); 
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Department_Options DO = new Department_Options((Privileges)_privilege);
            DO.Show();
            this.Hide();
        }
    }
}
