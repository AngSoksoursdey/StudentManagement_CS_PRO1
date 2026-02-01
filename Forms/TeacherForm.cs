using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Management.Forms
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadTeachers();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a teacher to delete");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this teacher?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["id"].Value
                );

                string query = "DELETE FROM tbtTeacher WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, connection.DataCon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                // ✅ Remove row from DataGridView (NO reload)
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtGender.Clear();
            txtPOB.Clear();
            txtPhoneNumber.Clear();
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a teacher");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            string query = @"UPDATE tbtTeacher SET
                        name = @name,
                        gender = @gender,
                        dob = @dob,
                        pob = @pob,
                        phoneNumber = @phone,
                        lecture = @lecture
                     WHERE id = @id";

            SqlCommand cmd = new SqlCommand(query, connection.DataCon);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker.Value);
            cmd.Parameters.AddWithValue("@pob", txtPOB.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@lecture", lectureCombo.Text);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            // update grid row manually
            DataGridViewRow row = dataGridView1.CurrentRow;
            row.Cells["name"].Value = txtName.Text;
            row.Cells["gender"].Value = txtGender.Text;
            row.Cells["dob"].Value = dateTimePicker.Value;
            row.Cells["pob"].Value = txtPOB.Text;
            row.Cells["phoneNumber"].Value = txtPhoneNumber.Text;
            row.Cells["lecture"].Value = lectureCombo.Text;

            MessageBox.Show("Update Successfully");

        

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO tbtTeacher 
                         (name, gender, dob, pob, phoneNumber, lecture) 
                         VALUES 
                         (@name, @gender, @dob, @pob, @phoneNumber, @lecture)";

                SqlCommand cmd = new SqlCommand(query, connection.DataCon);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker.Value); // important
                cmd.Parameters.AddWithValue("@pob", txtPOB.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@lecture", lectureCombo.Text);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Insert Successfully");
                LoadTeachers();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void LoadTeachers()
        {
            try
            {
                string query = "SELECT id, name, gender, dob, pob, phoneNumber, lecture FROM tbtTeacher";

                SqlDataAdapter da = new SqlDataAdapter(query, connection.DataCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private int selectedTeacherId = 0;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtName.Text = row.Cells["name"].Value.ToString();
            txtGender.Text = row.Cells["gender"].Value.ToString();
            txtPOB.Text = row.Cells["pob"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["phoneNumber"].Value.ToString();
            lectureCombo.Text = row.Cells["lecture"].Value.ToString();
            dateTimePicker.Value = Convert.ToDateTime(row.Cells["dob"].Value);

        }
    }
}
