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
    public partial class New_Patient : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public New_Patient(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void New_Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet2.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet2.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet1.Patient);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBLNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCONTACTINFO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBRECORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBVISIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BADD_Click(object sender, EventArgs e)
        {
            if (TBSSN.Text == "" || TBFNAME.Text == "" || TBMINIT.Text == "" || TBLNAME.Text == "" || TBRECORD.Text == "" || TBCONTACTINFO.Text == "" || TBAGE.Text == ""||TBVISIT.Text=="")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.insertPatient(int.Parse(TBSSN.Text),TBFNAME.Text.ToString(),TBMINIT.Text.ToString(),TBLNAME.Text.ToString(),CBBLOOD.Text.ToString(),int.Parse(TBCONTACTINFO.Text),CBGender.Text.ToString(),int.Parse(TBAGE.Text),TBRECORD.Text.ToString(),TBVISIT.Text.ToString(),int.Parse(CBDOCID.Text));
                if (r > 0)
                {
                    MessageBox.Show("inserted successfully");
                    DataTable dt = controllerObj.GetPatient();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Patients P = new Patients((Privileges)_privilege);
            P.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
