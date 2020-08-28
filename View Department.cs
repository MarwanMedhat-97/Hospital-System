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
    public partial class View_Department : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public View_Department(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
            if(privilege==Privileges.Nurses)
            {
                BsearchDocID.Enabled = false;
                BsearchDEP.Enabled = false;
                BHNURSEDID.Enabled = true;
                CBHDOCDID.Enabled = true;
            }
            else if(privilege==Privileges.Doctors)
            {
                BsearchDocID.Enabled = true;
                BsearchDEP.Enabled = false;
                BHNURSEDID.Enabled = false;
                CBHDOCDID.Enabled = true;
            }
            else if(privilege==Privileges.Admin||privilege==Privileges.Recp)
            {
                BsearchDocID.Enabled = true;
                BsearchDEP.Enabled = true;
            }
            else if(privilege==Privileges.Doctors||privilege==Privileges.Nurses)
            {
                BSearchEMP.Enabled = false;
            }
        }

        private void View_Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet6.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hospitalDataSet6.Department);

        }

        private void BsearchDEP_Click(object sender, EventArgs e)
        {
            CBDEPID.Visible = true;
            CBDTYPE.Visible = true;
            BsearchID.Visible = true;
            Bsearchname.Visible = true;
            BsearchDocID.Visible = false;
            CBHDOCDID.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            BHNURSEDID.Visible = false;
            BSearchEmployees.Visible = false;
        }

        private void BHeadDoc_Click(object sender, EventArgs e)
        {
            CBDEPID.Visible = false;
            CBDTYPE.Visible = false;
            BsearchID.Visible = false;
            Bsearchname.Visible = false;
            BsearchDocID.Visible = true;
            CBHDOCDID.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            BHNURSEDID.Visible = true;
            BSearchEmployees.Visible = false;
        }

        private void BsearchID_Click(object sender, EventArgs e)
        {
            if(CBDEPID.Text=="")
            {
                MessageBox.Show("Please Insert All The Department ID");
            }
            else
            {
                DataTable dt = controllerObj.GetDepID(int.Parse(CBDEPID.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void Bsearchname_Click(object sender, EventArgs e)
        {
            if (CBDTYPE.Text == "")
            {
                MessageBox.Show("Please Insert All The Department ID");
            }
            else
            {
                DataTable dt = controllerObj.GetDepName(CBDTYPE.Text.ToString());
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

        private void BsearchDocID_Click(object sender, EventArgs e)
        {
            if (CBHDOCDID.Text == "")
            {
                MessageBox.Show("Please Insert All The Department ID");
            }
            else
            {
                DataTable dt = controllerObj.GetDEPHDOCName(int.Parse(CBHDOCDID.Text));
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }

        private void BHNURSEDID_Click(object sender, EventArgs e)
        {
            if (CBHDOCDID.Text == "")
            {
                MessageBox.Show("Please Insert All The Department ID");
            }
            else
            {
                DataTable dt = controllerObj.GetDEPHNurseName(int.Parse(CBHDOCDID.Text));
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }

        private void BSearchEMP_Click(object sender, EventArgs e)
        {
            CBDEPID.Visible = false;
            CBDTYPE.Visible = false;
            BsearchID.Visible = false;
            Bsearchname.Visible = false;
            BsearchDocID.Visible = false;
            CBHDOCDID.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            BHNURSEDID.Visible = false;
            BSearchEmployees.Visible = true;

        }

        private void BSearchEmployees_Click(object sender, EventArgs e)
        {
            if (CBHDOCDID.Text == "")
            {
                MessageBox.Show("Please Insert All The Department ID");
            }
            else
            {
                DataTable dt = controllerObj.GetDEPEmployees(int.Parse(CBHDOCDID.Text));
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }
    }
}
