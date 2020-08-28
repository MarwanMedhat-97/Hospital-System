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
    public partial class Employees_Funcionalties : Form
    {
        private Privileges _privilege;
        public Employees_Funcionalties(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.Head)
            {
                this.BRemove.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddingEmployees AE = new AddingEmployees();
            AE.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove_Doctor RD = new Remove_Doctor();
            RD.Show();
            Close();
        }

        private void Employees_Funcionalties_Load(object sender, EventArgs e)
        {

        }

        private void Employees_Funcionalties_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Provided_Functionalities PF = new Provided_Functionalities((Privileges)_privilege);
            PF.Show();
            this.Hide();
        }
    }
}
