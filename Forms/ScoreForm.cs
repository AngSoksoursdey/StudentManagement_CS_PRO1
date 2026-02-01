using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.Forms
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadScore();
            dataGridView1.RowTemplate.Height = 50;

        }

        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentName = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Please enter a student name.");
                return;
            }

            try
            {
                string sql = @"SELECT TOP 1 id, studentName 
                       FROM tblStudentt
                       WHERE studentName LIKE @name";

                using (SqlCommand cmd = new SqlCommand(sql, connection.DataCon))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + studentName + "%");

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            txtStudentName.Text = rd["studentName"].ToString();

                            // ⭐ STORE PRIMARY KEY (id)
                            txtStudentName.Tag = rd["id"];
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                            txtStudentName.Clear();
                            txtStudentName.Tag = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadScore()
        {
            try
            {
                string sql = @"
                SELECT s.studentID, st.studentName, s.Month,
                    s.Oracle, s.Animation, s.MIS, s.SA,
                     s.SMI, s.WEB, s.Network, s.Java
                FROM tblScore s
                INNER JOIN tblStudentt st ON s.studentID = st.id";

                SqlDataAdapter da = new SqlDataAdapter(sql, connection.DataCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // 1️⃣ Bind data first
                dataGridView1.DataSource = dt;

                // 2️⃣ THEN hide studentID column
                if (dataGridView1.Columns.Contains("studentID"))
                {
                    dataGridView1.Columns["studentID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtStudentName.Tag == null)
            {
                MessageBox.Show("Please search student first.");
                return;
            }

            try
            {
                string sql = @"INSERT INTO tblScore
                (studentID, Month, Oracle, Animation, MIS, SA, SMI, WEB, Network, Java)
                VALUES
                (@studentID, @Month, @Oracle, @Animation, @MIS, @SA, @SMI, @WEB, @Network, @Java)";

                using (SqlCommand cmd = new SqlCommand(sql, connection.DataCon))
                {
                    cmd.Parameters.AddWithValue("@studentID", txtStudentName.Tag);
                    cmd.Parameters.AddWithValue("@Month", MonthCombo.Text);

                    cmd.Parameters.AddWithValue("@Oracle", txtOracle.Text);
                    cmd.Parameters.AddWithValue("@Animation", txt2D.Text);
                    cmd.Parameters.AddWithValue("@MIS", txtMIS.Text);
                    cmd.Parameters.AddWithValue("@SA", txtSA.Text);
                    cmd.Parameters.AddWithValue("@SMI", txtSMI.Text);
                    cmd.Parameters.AddWithValue("@WEB", txtWEB.Text);
                    cmd.Parameters.AddWithValue("@Network", txtNetwork.Text);
                    cmd.Parameters.AddWithValue("@Java", txtJava.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Score saved successfully ");
                LoadScore();
                ClearScoreInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearScoreInput()
        {
            txtOracle.Clear();
            txt2D.Clear();
            txtMIS.Clear();
            txtSA.Clear();
            txtSMI.Clear();
            txtWEB.Clear();
            txtNetwork.Clear();
            txtJava.Clear();
        }
        private string originalMonth;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // store studentID (int) in Tag
                txtStudentName.Tag = Convert.ToInt32(row.Cells["studentID"].Value);

                // display student name
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();


                originalMonth = row.Cells["Month"].Value.ToString();
                MonthCombo.Text = originalMonth;

                //MonthCombo.Text = row.Cells["Month"].Value.ToString();
                txtOracle.Text = row.Cells["Oracle"].Value.ToString();
                txt2D.Text = row.Cells["Animation"].Value.ToString();
                txtMIS.Text = row.Cells["MIS"].Value.ToString();
                txtSA.Text = row.Cells["SA"].Value.ToString();
                txtSMI.Text = row.Cells["SMI"].Value.ToString();
                txtWEB.Text = row.Cells["WEB"].Value.ToString();
                txtNetwork.Text = row.Cells["Network"].Value.ToString();
                txtJava.Text = row.Cells["Java"].Value.ToString();
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Tag == null || string.IsNullOrEmpty(originalMonth))
            {
                MessageBox.Show("Please select a score record first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this score?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                string sql = @"
                DELETE FROM tblScore
                WHERE studentID = @studentID AND Month = @Month";

                using (SqlCommand cmd = new SqlCommand(sql, connection.DataCon))
                {
                    cmd.Parameters.AddWithValue("@studentID", Convert.ToInt32(txtStudentName.Tag));
                    cmd.Parameters.AddWithValue("@Month", originalMonth);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Score deleted successfully 🗑️");
                    else
                        MessageBox.Show("No record found to delete ❌");
                }

                LoadScore();
                ClearScoreInput();
                txtStudentName.Clear();
                txtStudentName.Tag = null;
                originalMonth = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // make sure a student is selected
            if (txtStudentName.Tag == null)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            try
            {
                string sql = @"
                UPDATE tblScore
                SET Month=@NewMonth,
                    Oracle=@Oracle,
                    Animation=@Animation,
                    MIS=@MIS,
                    SA=@SA,
                    SMI=@SMI,
                    WEB=@WEB,
                    Network=@Network,
                    Java=@Java
                WHERE studentID=@studentID AND Month=@OldMonth";



                using (SqlCommand cmd = new SqlCommand(sql, connection.DataCon))
                {
                    cmd.Parameters.AddWithValue("@studentID", Convert.ToInt32(txtStudentName.Tag));
                    //cmd.Parameters.AddWithValue("@Month", MonthCombo.Text);
                    cmd.Parameters.AddWithValue("@OldMonth", originalMonth);
                    cmd.Parameters.AddWithValue("@NewMonth", MonthCombo.Text);
                    cmd.Parameters.AddWithValue("@Oracle", txtOracle.Text);
                    cmd.Parameters.AddWithValue("@Animation", txt2D.Text);
                    cmd.Parameters.AddWithValue("@MIS", txtMIS.Text);
                    cmd.Parameters.AddWithValue("@SA", txtSA.Text);
                    cmd.Parameters.AddWithValue("@SMI", txtSMI.Text);
                    cmd.Parameters.AddWithValue("@WEB", txtWEB.Text);
                    cmd.Parameters.AddWithValue("@Network", txtNetwork.Text);
                    cmd.Parameters.AddWithValue("@Java", txtJava.Text);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Score updated successfully ");
                    else
                        MessageBox.Show("No record found to update ");
                }

                // reload DataGridView and clear form
                LoadScore();
                ClearScoreInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

