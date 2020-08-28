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
    public partial class View_Patients : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public View_Patients(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
            if (privilege == Privileges.Doctors||privilege==Privileges.Head||privilege==Privileges.Nurses)
            {
                RSSN.Enabled = false;
            }
        }

        private void View_Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet5.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet5.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet1.Patient);

        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            if (TBDATA.Text=="")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else if(RSSN.Checked==true)
            {
                DataTable dt = controllerObj.GetPatientSSN(int.Parse(TBDATA.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                TBDATA.Clear();
            }
            else if(RDOCID.Checked==true)
            {
                DataTable dt = controllerObj.GetPatientDOCID(int.Parse(TBDATA.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                TBDATA.Clear();
            }
            else
            {
                MessageBox.Show("Please insert a Valid Doctor ID or Patient SSN");
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Patients P = new Patients((Privileges)_privilege);
            P.Show();
            this.Hide();
        }

        private void TBDATA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBDATA.Visible = true;
            RDOCID.Visible = true;
            RSSN.Visible = true;
            BSearch.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            BSearchA.Visible = false;
        }

        private void BSearchDoctor_Click(object sender, EventArgs e)
        {
            TBDATA.Visible = true;
            RDOCID.Visible = false;
            RSSN.Visible = false;
            BSearch.Visible = false;
            BSearchA.Visible = true;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
        }

        private void BSearchA_Click(object sender, EventArgs e)
        {
            if (TBDATA.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                DataTable dt = controllerObj.GetAttendingDoctor(int.Parse(TBDATA.Text));
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
                TBDATA.Clear();
            }
        }
    }
}
