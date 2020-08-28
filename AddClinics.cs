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
    public partial class AddClinics : Form
    {
        Controller controllerObj;
        public AddClinics()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBADDCLINIC_Click(object sender, EventArgs e)
        {
            if (TBTYP.Text == "" || TBTYPEC.Text == "" || TBPRICE.Text == "" || TBCAPACITY.Text == "" || TBWHOURS.Text == "" || TBHDOCID.Text == "" || TBHNURSEID.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.insertClinic(int.Parse(TBTYP.Text), TBTYPEC.Text.ToString(), int.Parse(TBPRICE.Text), int.Parse(TBCAPACITY.Text), int.Parse(TBWHOURS.Text), int.Parse(TBHDOCID.Text), int.Parse(TBHNURSEID.Text));
                if (r > 0)
                {
                    MessageBox.Show("Clinic inserted successfully");
                    DataTable dt = controllerObj.GetClinic();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void TBSHOWCLINIC_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetClinic();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void AddClinics_Load(object sender, EventArgs e)
        {

        }
    }
}
