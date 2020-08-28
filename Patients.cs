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
    public partial class Patients : Form
    {
        private Privileges _privilege;
        public Patients(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if(privilege==Privileges.Nurses||privilege==Privileges.Recp)
            {
                this.BNEW.Enabled = false;
            }
            if(privilege==Privileges.Recp||privilege==Privileges.Nurses)
            {
                this.BUpdate.Enabled = false;
            }
        }

        private void BVIEW_Click(object sender, EventArgs e)
        {
            View_Patients VP = new View_Patients((Privileges)_privilege);
            VP.Show();
            this.Close();
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Provided_Functionalities PF = new Provided_Functionalities((Privileges)_privilege);
            PF.Show();
            this.Hide();
        }

        private void BNEW_Click(object sender, EventArgs e)
        {
            New_Patient NP = new New_Patient((Privileges)_privilege);
            NP.Show();
            this.Hide();
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            Update_Patient UP = new Update_Patient((Privileges)_privilege);
            UP.Show();
            this.Hide();
        }
    }
}
