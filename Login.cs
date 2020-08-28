using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DBLAB_EXAM
{
    
    public enum Privileges
    {
        Admin = 1,
        Head = 2,
        Doctors=3,
        Nurses=4,
        Recp=5,
        pharm=6
    }
    
    public partial class Login : Form
    {
        private bool _loggedin = false;
        private Controller controllerObj;
        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private bool CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed == "w+0fHMgNFl7jSDJ7WpvRfIQLzfflSi9pPNdiQg+v4/E=";    //The Hash should be stored in the DB
                                                                                //Hashes needs a lot of time to be reversed (Brute Force, Dictionary Attacks, Rainbow Tables, etc.)
                                                                                //So even if they are stolen from the database, 
                                                                                //you should have enough time to notify users to change it
                                                                                //before the attacker can use them.
        }   

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Blog_Click(object sender, EventArgs e)
        {
            int privlg = controllerObj.CheckPassword_Basic(TxtBx_username.Text, TxtBx_pass.Text);
            if (privlg > 0) // Successful Login
            {
                _loggedin = true;
                // Create an Object of "Provided_Functionalities" Form and Show it
                Provided_Functionalities func = new Provided_Functionalities((Privileges)privlg);
                func.Show(this);
                TxtBx_username.Clear();
                TxtBx_pass.Clear();
                // Hide the Login Form 
                // Don't close it because it's the startup form and the application will exit
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void TxtBx_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TxtBx_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtBx_username_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtBx_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
