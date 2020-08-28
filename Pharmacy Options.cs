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
    public partial class PharmacyOption : Form
    {
        private Privileges _privilege;

        public PharmacyOption(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.Admin)
            {
                this.BADD.Enabled = false;
                this.BUpdate.Enabled = false;
            }
        }

        private void TBView_Click(object sender, EventArgs e)
        {
            ViewDrugs VD = new ViewDrugs((Privileges)_privilege);
            VD.Show();
            this.Close();
        }

        private void B_Load(object sender, EventArgs e)
        {

        }

        private void BADD_Click(object sender, EventArgs e)
        {
            InsertDrug ID = new InsertDrug((Privileges)_privilege);
            ID.Show();
            this.Close();
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            UpdateDrug UD = new UpdateDrug((Privileges)_privilege);
            UD.Show();
            this.Close();
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            Hospital_Entities_Funcionalties HEF = new Hospital_Entities_Funcionalties((Privileges)_privilege);
            HEF.Show();
            this.Hide();
        }
    }
}
