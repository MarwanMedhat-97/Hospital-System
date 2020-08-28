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
    public partial class AddingEmployees : Form
    {
        public AddingEmployees()
        {
            InitializeComponent();
        }

        private void BADDDOCTOR_Click(object sender, EventArgs e)
        {
            Form1 AddD = new Form1();
            AddD.Show();
            Close();
        }

        private void BADDNURSE_Click(object sender, EventArgs e)
        {
            AddingNurses AddN = new AddingNurses();
            AddN.Show();
            Close();
        }

        private void BADDPHARM_Click(object sender, EventArgs e)
        {
            AddingPharmacist AddF = new AddingPharmacist();
            AddF.Show();
            Close();
        }

        private void BRECP_Click(object sender, EventArgs e)
        {
            AddingRecp AddR = new AddingRecp();
            AddR.Show();
            Close();
        }

        private void AddingEmployees_Load(object sender, EventArgs e)
        {
            
        }

        private void AddingEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
