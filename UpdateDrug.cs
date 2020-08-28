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
    public partial class UpdateDrug : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public UpdateDrug(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void UpdateDrug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.hospitalDataSet.Pharmacy);

        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (TBQuantity.Text == "" || TBDrugName.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.UpdateDrug(int.Parse(TBQuantity.Text), TBDrugName.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("Upated successfully");
                    DataTable dt = controllerObj.GetDrugs();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void TBQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDrugName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
    }
}
