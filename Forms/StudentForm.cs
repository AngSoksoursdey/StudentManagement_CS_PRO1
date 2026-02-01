using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadStudent();
            dataGridView1.RowTemplate.Height = 80;
           

            DataGridViewImageColumn imgCol =
                (DataGridViewImageColumn)dataGridView1.Columns["Image"];

            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
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
        string imageFileName = "";   // save ONLY name.ext
        string imageFolder = Path.Combine(Application.StartupPath, "studentImage");


        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(ofd.FileName).ToLower();
                if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
                {
                    MessageBox.Show("Only JPG, JPEG, PNG allowed");
                    return;
                }

                // make sure folder exists
                Directory.CreateDirectory(imageFolder);

                // generate unique filename
                imageFileName = Guid.NewGuid().ToString() + ext;

                string savePath = Path.Combine(imageFolder, imageFileName);

                // copy image to folder
                File.Copy(ofd.FileName, savePath, true);

                // show in PictureBox
                if (picture.Image != null)
                {
                    picture.Image.Dispose();
                    picture.Image = null;
                }

                // ✅ Use Image.FromFile here, NOT DataGridViewImageColumn
                picture.Image = Image.FromFile(savePath);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void LoadStudent()
        {
          
        
           try
            {
                string query = "SELECT id, studentName, gender, dob, pob, [group], image FROM tblStudentt";
                SqlDataAdapter da = new SqlDataAdapter(query, connection.DataCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataTable dtGrid = new DataTable();
                dtGrid.Columns.Add("id", typeof(int));
                dtGrid.Columns.Add("studentName", typeof(string));
                dtGrid.Columns.Add("gender", typeof(string));
                dtGrid.Columns.Add("dob", typeof(string)); // keep as string to avoid DBNull errors
                dtGrid.Columns.Add("pob", typeof(string));
                dtGrid.Columns.Add("group", typeof(string));
                dtGrid.Columns.Add("Image", typeof(Image));

                foreach (DataRow row in dt.Rows)
                {
                    // Handle nullable fields
                    string name = row["studentName"] == DBNull.Value ? "" : row["studentName"].ToString();
                    string gender = row["gender"] == DBNull.Value ? "" : row["gender"].ToString();
                    string dob = row["dob"] == DBNull.Value ? "" : Convert.ToDateTime(row["dob"]).ToString("dd-MMM-yyyy");
                    string pob = row["pob"] == DBNull.Value ? "" : row["pob"].ToString();
                    string group = row["group"] == DBNull.Value ? "" : row["group"].ToString();
                    string imgName = row["image"] == DBNull.Value ? "" : row["image"].ToString();

                    Image img = null;
                    if (!string.IsNullOrEmpty(imgName))
                    {
                        string imgPath = Path.Combine(imageFolder, imgName);
                        if (File.Exists(imgPath))
                        {
                            img = Image.FromFile(imgPath);
                        }
                    }

                    dtGrid.Rows.Add(row["id"], name, gender, dob, pob, group, img);
                    
                }

                dataGridView1.DataSource = dtGrid;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                string query = @"INSERT INTO tblStudentt
                        (studentName, gender, dob, pob, [group], image)
                        VALUES (@name, @gender, @dob, @pob, @group, @image)";

                SqlCommand cmd = new SqlCommand(query, connection.DataCon);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", radiomale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@dob", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@pob", txtPOB.Text.Trim());
                cmd.Parameters.AddWithValue("@group", txtgroup.Text.Trim());
                cmd.Parameters.AddWithValue("@image", imageFileName);  // only filename

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Insert successful");

                ClearForm();    // clear inputs and picture
                LoadStudent();  // reload DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(row.Cells["id"].Value);

            txtName.Text = row.Cells["studentName"].Value.ToString();

            if (row.Cells["gender"].Value.ToString() == "Male")
                radiomale.Checked = true;
            else
                radioFemale.Checked = true;

            dateTimePicker.Value = Convert.ToDateTime(row.Cells["dob"].Value);
            txtPOB.Text = row.Cells["pob"].Value.ToString();
            txtgroup.Text = row.Cells["group"].Value.ToString();

            // get image filename from database (NOT Image column)
            string query = "SELECT image FROM tblStudentt WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connection.DataCon);
            cmd.Parameters.AddWithValue("@id", selectedStudentId);

            object result = cmd.ExecuteScalar();
            oldImageFileName = result == DBNull.Value ? "" : result.ToString();
            imageFileName = oldImageFileName;

            string imgPath = Path.Combine(imageFolder, imageFileName);

            if (File.Exists(imgPath))
            {
                if (picture.Image != null)
                    picture.Image.Dispose();

                using (var temp = new Bitmap(imgPath))
                {
                    picture.Image = new Bitmap(temp);
                }

                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picture.Image = null;
            }
        }


        private void ClearForm()
        {
            txtName.Clear();
            txtPOB.Clear();
            txtgroup.Clear();
            radiomale.Checked = true;
            dateTimePicker.Value = DateTime.Today;


            if (picture.Image != null)
                picture.Image.Dispose();

            picture.Image = null;
            imageFileName = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int selectedStudentId = 0;
        string oldImageFileName = "";
        string currentImageName = "";
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student to update");
                return;
            }

            try
            {
                string query = @"UPDATE tblStudentt 
                         SET studentName=@name,
                             gender=@gender,
                             dob=@dob,
                             pob=@pob,
                             [group]=@group,
                             image=@image
                         WHERE id=@id";

                SqlCommand cmd = new SqlCommand(query, connection.DataCon);

                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", radiomale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@dob", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@pob", txtPOB.Text.Trim());
                cmd.Parameters.AddWithValue("@group", txtgroup.Text.Trim());
                cmd.Parameters.AddWithValue("@image", imageFileName); // new OR old
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Update successful");

                ClearForm();
                LoadStudent();

                selectedStudentId = 0;
                oldImageFileName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReleaseImageLocks()
        {
            // release PictureBox image
            //if (picture.Image != null)
            //{
            //    picture.Image.Dispose();
            //    picture.Image = null;
            //}

            // release DataGridView image locks
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Image"].Value is Image img)
                {
                    img.Dispose();
                    row.Cells["Image"].Value = null;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student first");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                // 1️⃣ Get image filename from database
                string imgName = "";
                string getImgQuery = "SELECT image FROM tblStudentt WHERE id=@id";
                SqlCommand getImgCmd = new SqlCommand(getImgQuery, connection.DataCon);
                getImgCmd.Parameters.AddWithValue("@id", selectedStudentId);

                object result = getImgCmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    imgName = result.ToString();

                // 2️⃣ Delete record from database
                string deleteQuery = "DELETE FROM tblStudentt WHERE id=@id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection.DataCon);
                deleteCmd.Parameters.AddWithValue("@id", selectedStudentId);
                deleteCmd.ExecuteNonQuery();

                // 3️⃣ Delete image file from folder
                if (!string.IsNullOrEmpty(imgName))
                {
                    string imgPath = Path.Combine(imageFolder, imgName);
                    ReleaseImageLocks();
                    if (File.Exists(imgPath))
                        File.Delete(imgPath);
                }

                MessageBox.Show("Delete successful");

                LoadStudent();
                ClearForm();

                selectedStudentId = 0;
                currentImageName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
