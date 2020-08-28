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
    public partial class Update_Patient : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public Update_Patient(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void Update_Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet2.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet2.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet4.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter1.Fill(this.hospitalDataSet4.Patient);
            // TODO: This line of code loads data into the 'hospitalDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet1.Patient);

        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
            if (TBAGE.Text == "" || TBCONTACT.Text == ""||TBVISIT.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.UpdatePatient(int.Parse(TBCONTACT.Text), int.Parse(TBAGE.Text), TBVISIT.Text.ToString(), int.Parse(CBDOCID.Text), int.Parse(CBSSN.Text));
                if (r > 0)
                {
                    MessageBox.Show("Upated successfully");
                    DataTable dt = controllerObj.GetPatient();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Update Failed");
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Patients P = new Patients((Privileges)_privilege);
            P.Show();
            this.Close();
        }

        private void TBCONTACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBAGE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBVISIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBVISIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
