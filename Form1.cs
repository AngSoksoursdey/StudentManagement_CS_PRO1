using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successful!");
                Student_Form asd = new Student_Form();
                asd.ShowDialog(this);

                // Proceed to the next form or main application window
            }
            else if (username == "admin")
            {
                MessageBox.Show("Please enter the correct password.");
            }
            else if (password == "admin")
            {
                MessageBox.Show("Please enter the correct username.");
            }

            else if (username == "admin")
            {
                MessageBox.Show("Please enter the username.");
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter the password.");
            }
            else
            {
                MessageBox.Show("Please enter username and password.");
            }
        }
    }
}
