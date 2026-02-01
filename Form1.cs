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
            try
            {

                string id = server_name_txt.Text;
                string db = "dbSchoolManagement";
                string usernanme = txtUsername.Text;
                string password = txtPassword.Text;
                int index = authentication_combo.SelectedIndex;
                if (index == 0) // Windows Authentication
                {
                    connection.ConnectDB(id, db);

                }
                else
                {
                    connection.ConnectDB(id, db, usernanme, password);
                }
                new DashBoard().Show();
                this.Hide();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void authentication_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index =  authentication_combo.SelectedIndex;

            if (index == 0) // Windows Authentication
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else if (index == 1) // SQL Server Authentication
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
