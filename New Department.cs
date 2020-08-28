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
    public partial class New_Department : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public New_Department(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void New_Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet7.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.hospitalDataSet7.Nurse);
            // TODO: This line of code loads data into the 'hospitalDataSet5.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter1.Fill(this.hospitalDataSet5.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet2.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet2.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet6.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hospitalDataSet6.Department);

        }

        private void BADD_Click(object sender, EventArgs e)
        {

            if (TBCAPACITY.Text==""||TBID.Text==""||TBLOCATION.Text==""||TBTYPE.Text==""||CBHDOCTOR.Text==""||CBHNURSE.Text=="")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.insertDepartment(int.Parse(TBID.Text),TBLOCATION.Text.ToString(),int.Parse(TBCAPACITY.Text),TBTYPE.Text.ToString(),int.Parse(CBHDOCTOR.Text),int.Parse(CBHNURSE.Text));
                if (r > 0)
                {
                    MessageBox.Show("inserted successfully");
                    DataTable dt = controllerObj.GetDepartment();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Department_Options DO = new Department_Options((Privileges)_privilege);
            DO.Show();
            this.Hide();
        }

        private void TBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBLOCATION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCAPACITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTYPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
