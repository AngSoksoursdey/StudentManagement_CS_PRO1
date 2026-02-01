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
    public partial class DashBoard : Form
    {

        //field
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        //constructor
        public DashBoard()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
        }

        //methods
        private Color SelectThemeColor()
        {
                int index = random.Next(ThemeColor.colorlist.Count);
                while (tempIndex == index)
                {
                    index=random.Next(ThemeColor.colorlist.Count);
                }   
                tempIndex = index;
                string color = ThemeColor.colorlist[index];
                return ColorTranslator.FromHtml(color);
        }

        private  void activateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    
                    disableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    //currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTile.BackColor = color;
                    panellogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                    btnLogout.BackColor = Color.Maroon;
                    btnLogout.ForeColor = Color.White;





                }
            }
        }

        private void disableButton()
        {
            foreach (Control previous in panelmenu.Controls)
            {
                if (previous.GetType() == typeof(Button))
                {
                    previous.BackColor = Color.Silver;
                    previous.ForeColor = Color.Black;
                    previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void OpenchildForm (Form childForm , object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            
        }





        private void btn_Studentform_Click(object sender, EventArgs e)
        {
           // activateButton(sender);
           OpenchildForm (new Forms.StudentForm(), sender);


        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            OpenchildForm (new Forms.TeacherForm(), sender);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            OpenchildForm (new Forms.ScoreForm(), sender);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void Reset()
        {
            disableButton();
            labelTitle.Text = "Home";
            panelTile.BackColor = Color.DarkGray;
            currentButton = null;
            btnClose.Visible = false;
            btnLogout.BackColor = Color.Maroon;
            btnLogout.ForeColor = Color.White;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            Reset();
        }

       

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Examination(), sender);
        }
    }
}
