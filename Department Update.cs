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
    public partial class Department_Update : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public Department_Update(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void Department_Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet7.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.hospitalDataSet7.Nurse);
            // TODO: This line of code loads data into the 'hospitalDataSet2.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet2.Doctor);
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

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (CBDEPID.Text == ""||CBHDOCID.Text==""||CBHNURSEID.Text==""||TBCAPACITY.Text=="")
            {
                MessageBox.Show("Please Insert All Data");
            }
            else
            {
                MessageBox.Show("Successfully Updated");
                DataTable dt = controllerObj.UpdateDepartment(int.Parse(CBDEPID.Text),int.Parse(TBCAPACITY.Text),int.Parse(CBHDOCID.Text),int.Parse(CBHNURSEID.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                TBCAPACITY.Clear();
            }
        }

        private void TBCAPACITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
