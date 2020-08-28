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
    public partial class Provided_Functionalities : Form
    {
        private Privileges _privilege;

        public Provided_Functionalities(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.Head)
            {
                this.Bentities.Enabled = true;
            }
            if(privilege==Privileges.pharm)
            {
                this.BPatients.Enabled = false;
            }
        }

        private void Provided_Functionalities_Load(object sender, EventArgs e)
        {
            
        }

        private void Bentities_Click(object sender, EventArgs e)
        {
            Hospital_Entities_Funcionalties HEF = new Hospital_Entities_Funcionalties((Privileges)_privilege);
            HEF.Show();
            this.Hide();
        }

        private void BEmployees_Click(object sender, EventArgs e)
        {
            Employees_Funcionalties EF = new Employees_Funcionalties((Privileges)_privilege);
            EF.Show();
            this.Hide();
        }

        private void Blogout_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void Provided_Functionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void BPatients_Click(object sender, EventArgs e)
        {
            Patients P = new Patients((Privileges)_privilege);
            P.Show();
            this.Hide();
        }
    }
}
