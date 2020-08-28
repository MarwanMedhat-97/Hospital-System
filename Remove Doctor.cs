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
    public partial class Remove_Doctor : Form
    {
        Controller controllerObj;
        public Remove_Doctor()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Bshow_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDoctor();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            if (TBFname.Text == "" || TBLname.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.deleteDoctor(TBFname.Text.ToString(), TBLname.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("Employee Deleted successfully");
                    DataTable dt = controllerObj.GetDoctor();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Deletion Failed");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
