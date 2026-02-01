using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            //Address of sql server and database
            String ConnectionString = "Data Source=ANG_SOKSOURSDEY\\MSSQLSERVER1;Initial Catalog=dbSchoolManagement;Integrated Security=True;";
            
            //2. establish connection 
            SqlConnection con = new SqlConnection(ConnectionString);
            
            //3.open connection
            con.Open();
            
            //4.prepare query
            String student_name = txtStudentName.Text;
            String gender = txtGender.Text;
            String dob = txtDob.Text;
            String pob = txtPob.Text;
            String phone_number = txtPhoneNumber.Text;
            int age = int.Parse(txtAge.Text);
            
            String query = "INSERT INTO tblStudent(Name, Gender, DateOfBirth, PlaceOfBirth, PhoneNumber, Age) " +
               "VALUES (@Name, @Gender, @Dob, @Pob, @Phone, @Age)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", student_name);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Dob", dob);  
            cmd.Parameters.AddWithValue("@Pob", pob);
            cmd.Parameters.AddWithValue("@Phone", phone_number);
            cmd.Parameters.AddWithValue("@Age", age);

            cmd.ExecuteNonQuery();

            //5.execute query
            con.Close();
    
            //6. close connection
            
            MessageBox.Show("This information has been save");
            LoadStudentData();


            txtStudentName.Clear();
            txtGender.Clear();
            txtDob.Clear();
            txtPob.Clear();
            txtPhoneNumber.Clear();
            txtAge.Clear();

        }
        private void LoadStudentData()
        {
            String ConnectionString = "Data Source=ANG_SOKSOURSDEY\\MSSQLSERVER1;Initial Catalog=dbSchoolManagement;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                String query = "SELECT id, Name, Gender, DateOfBirth, PlaceOfBirth, PhoneNumber, Age FROM tblStudent";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font= new Font("Microsoft Sans Serif",14,FontStyle.Bold);
            }
        }


        private void Student_Form_Load(object sender, EventArgs e)
        {
            
                LoadStudentData();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = dataGridView1.Rows[e.RowIndex];
                txtStudentName.Text = selectedrow.Cells[1].Value.ToString();
                txtGender.Text = selectedrow.Cells[2].Value.ToString();
                txtDob.Text = selectedrow.Cells[3].Value.ToString();
                txtPob.Text = selectedrow.Cells[4].Value.ToString();
                txtPhoneNumber.Text = selectedrow.Cells[5].Value.ToString();
                txtAge.Text = selectedrow.Cells[6].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get id of the selected student
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                // Get updated values from textboxes
                String student_name = txtStudentName.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                string pob = txtPob.Text;
                String phone = txtPhoneNumber.Text;
                String age = txtAge.Text;

                string ConnectionString = "Data Source=ANG_SOKSOURSDEY\\MSSQLSERVER1;Initial Catalog=dbSchoolManagement;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "UPDATE tblStudent SET Name=@Name, Gender=@Gender, DateOfBirth=@Dob, PlaceOfBirth=@Pob, PhoneNumber=@Phone, Age=@Age WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", student_name);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Pob", pob);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.ExecuteNonQuery();

                }
                LoadStudentData();

                MessageBox.Show("Record updated successfully!");

            }
            else
            {
                               MessageBox.Show("Please select a row to update.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get id of the selected student
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                // Confirm before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete from database
                    String ConnectionString = "Data Source=ANG_SOKSOURSDEY\\MSSQLSERVER1;Initial Catalog=dbSchoolManagement;Integrated Security=True;";
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM tblStudent WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.ExecuteNonQuery();
                    }

                    // Refresh DataGridView
                    LoadStudentData();

                    MessageBox.Show("Record deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
