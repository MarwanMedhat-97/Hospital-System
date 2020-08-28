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
    public partial class Hospital_Entities_Funcionalties : Form
    {
        private Privileges _privilege;

        public Hospital_Entities_Funcionalties(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.pharm || privilege == Privileges.Admin)
            {
                this.BPharmacy.Enabled = true;
            }
            else
            {
                this.BPharmacy.Enabled = false;
            }
            if(privilege==Privileges.pharm)
            {
                this.BDEPOPETION.Enabled = false;
            }
            else { this.BDEPOPETION.Enabled = true; }
        }

        private void BPharmacy_Click(object sender, EventArgs e)
        { 
            PharmacyOption PO = new PharmacyOption((Privileges)_privilege);
            PO.Show();
            this.Close();
        }

        private void Hospital_Entities_Funcionalties_Load(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Provided_Functionalities PF = new Provided_Functionalities((Privileges)_privilege);
            PF.Show();
            this.Close();
        }

        private void BDEPOPETION_Click(object sender, EventArgs e)
        {
            Department_Options DO = new Department_Options((Privileges)_privilege);
            DO.Show();
            this.Hide();
        }
    }
}
