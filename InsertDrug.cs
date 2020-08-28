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
    public partial class InsertDrug : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public InsertDrug(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void BADD_Click(object sender, EventArgs e)
        {
            if (TBName.Text == ""|| TBQuantity.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.InsertDrug(TBName.Text.ToString(),int.Parse(TBQuantity.Text));
                if (r > 0)
                {
                    MessageBox.Show("inserted successfully");
                    DataTable dt = controllerObj.GetDrugs();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    TBName.Clear();
                    TBQuantity.Clear();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void BInsert_Click(object sender, EventArgs e)
        {
            TBName.Visible = true;
            TBQuantity.Visible = true;
            BADD.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            BDelete.Visible = false;
            TBDNAME.Visible = false;
            label3.Visible = false;
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            BDelete.Visible = true;
            TBDNAME.Visible = true;
            label3.Visible = true;
            TBName.Visible = false;
            TBQuantity.Visible = false;
            BADD.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (TBDNAME.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.DeleteDrug(TBDNAME.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("inserted successfully");
                    DataTable dt = controllerObj.GetDrugs();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    TBDNAME.Clear();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void TBName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            PharmacyOption PO = new PharmacyOption((Privileges)_privilege);
            PO.Show();
            this.Close();
        }

        private void InsertDrug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.hospitalDataSet.Pharmacy);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
