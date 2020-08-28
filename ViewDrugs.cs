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
    public partial class ViewDrugs : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
        public ViewDrugs(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            controllerObj = new Controller();
        }

        private void BView_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDrugs();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            BSeacrhN.Visible = true;
            TBDrugname.Visible = true;
            label1.Visible = true;
        }

        private void BSeacrhN_Click(object sender, EventArgs e)
        {

            if (TBDrugname.Text=="")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                DataTable dt = controllerObj.GetDrugname(TBDrugname.Text.ToString());
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                TBDrugname.Clear();
            }
        }

        private void TBDrugname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ViewDrugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet3.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.hospitalDataSet3.Pharmacy);

        }
    }
}
