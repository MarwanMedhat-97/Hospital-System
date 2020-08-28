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
    public partial class Department_Options : Form
    {
        private Privileges _privilege;
        public Department_Options(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if(privilege==Privileges.Admin)
            {
                this.BADD.Enabled = true;
            }
            else
            {
                this.BADD.Enabled = false;
            }
            if(privilege==Privileges.Admin)
            {
                BRemove.Enabled = true;
            }
            else
            {
                BRemove.Enabled = false;
            }
            if (privilege == Privileges.Admin)
            {
                BUpdate.Enabled = true;
            }
            else
            {
                BUpdate.Enabled = false;
            }
        }

        private void Department_Options_Load(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Hospital_Entities_Funcionalties HEF = new Hospital_Entities_Funcionalties((Privileges)_privilege);
            HEF.Show();
            this.Hide();
        }

        private void BADD_Click(object sender, EventArgs e)
        {
            New_Department ND = new New_Department((Privileges)_privilege);
            ND.Show();
            this.Hide();
        }

        private void BVIEW_Click(object sender, EventArgs e)
        {
            View_Department VD = new View_Department((Privileges)_privilege);
            VD.Show();
            this.Hide();
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            Remove_Department RD=new Remove_Department((Privileges)_privilege);
            RD.Show();
            this.Hide();
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            Department_Update DU = new Department_Update((Privileges)_privilege);
            DU.Show();
            this.Hide();
        }
    }
}
