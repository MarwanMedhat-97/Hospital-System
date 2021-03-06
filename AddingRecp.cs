﻿using System;
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
    public partial class AddingRecp : Form
    {
        Controller controllerObj;
        public AddingRecp()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void BinsertRecp_Click(object sender, EventArgs e)
        {
            if (TBID.Text == "" || TBFname.Text == "" || TBMinit.Text == "" || TBLname.Text == "" || TBSdate.Text == "" || TBcontactinfo.Text == "" || TBGender.Text == "" || TBSalary.Text == "" || TBWhours.Text == "" || TBPreformance.Text == "" || TBHolidays.Text == "" || TBTypeC.Text == "" || TBDID.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.insertRecp(int.Parse(TBID.Text), TBFname.Text.ToString(), TBMinit.Text.ToString(), TBLname.Text.ToString(), TBSdate.Text.ToString(), int.Parse(TBcontactinfo.Text), TBGender.Text.ToString(),int.Parse(TBSuper.Text), int.Parse(TBSalary.Text), int.Parse(TBWhours.Text), TBPreformance.Text.ToString(), TBHolidays.Text.ToString(), int.Parse(TBTypeC.Text), int.Parse(TBDID.Text));
                if (r > 0)
                {
                    MessageBox.Show("Employee inserted successfully");
                    DataTable dt = controllerObj.GetRecp();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }

                else
                    MessageBox.Show("Insertion Failed");
            }
        }

        private void BshowRecp_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetRecp();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void AddingRecp_Load(object sender, EventArgs e)
        {

        }

        private void AddingRecp_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
