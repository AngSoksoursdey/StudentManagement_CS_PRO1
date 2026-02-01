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

namespace Student_Management.Forms
{
    public partial class Examination : Form
    {
        public Examination()
        {
            InitializeComponent();
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadExamination();
            dataGridView1.RowTemplate.Height = 40;
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
        private void LoadExamination()
        {
            try
            {
                string sql = @"
                SELECT 
                st.studentName,
                s.Month,

                s.Oracle,
                s.Animation,
                s.MIS,
                s.SA,
                s.SMI,
                s.WEB,
                s.Network,
                s.Java,

                (s.Oracle + s.Animation + s.MIS + s.SA +
                 s.SMI + s.WEB + s.Network + s.Java) AS Total,

                (s.Oracle + s.Animation + s.MIS + s.SA +
                s.SMI + s.WEB + s.Network + s.Java) / 8.0 AS Average,

                CASE
                WHEN (s.Oracle + s.Animation + s.MIS + s.SA +
                      s.SMI + s.WEB + s.Network + s.Java) / 8.0 >= 50
                THEN 'PASS'
                ELSE 'FAIL'
                END AS Result
                FROM tblScore s
                INNER JOIN tblStudentt st ON s.studentID = st.id
                ORDER BY s.Month, st.studentName";

                SqlDataAdapter da = new SqlDataAdapter(sql, connection.DataCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("Average"))
                {
                    dataGridView1.Columns["Average"].DefaultCellStyle.Format = "0.00";
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Result"].Value.ToString() == "FAIL")
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                    else
                        row.DefaultCellStyle.BackColor = Color.Honeydew;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
