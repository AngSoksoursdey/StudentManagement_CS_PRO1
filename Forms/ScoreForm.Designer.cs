namespace Student_Management.Forms
{
    partial class ScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.Label();
            this.txtOracle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txt2D = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMIS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWEB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSMI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNetwork = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJava = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(4, 745);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(2054, 441);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1953, 704);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 80);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(643, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(182, 57);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1953, 542);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 80);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1953, 366);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(182, 80);
            this.btnInsert.TabIndex = 73;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(261, 39);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(376, 57);
            this.txtSearch.TabIndex = 60;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(-3, 48);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(234, 37);
            this.Search.TabIndex = 61;
            this.Search.Text = "Search Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(261, 113);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(376, 57);
            this.txtStudentName.TabIndex = 63;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(-3, 113);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(234, 37);
            this.StudentName.TabIndex = 64;
            this.StudentName.Text = "StudentName:";
            // 
            // txtOracle
            // 
            this.txtOracle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOracle.Location = new System.Drawing.Point(471, 39);
            this.txtOracle.Multiline = true;
            this.txtOracle.Name = "txtOracle";
            this.txtOracle.Size = new System.Drawing.Size(254, 57);
            this.txtOracle.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(226, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 37);
            this.label14.TabIndex = 68;
            this.label14.Text = "Oracle:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(818, 284);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(622, 46);
            this.labelTitle.TabIndex = 77;
            this.labelTitle.Text = "Please Enter The Student Score";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // txt2D
            // 
            this.txt2D.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2D.Location = new System.Drawing.Point(471, 120);
            this.txt2D.Multiline = true;
            this.txt2D.Name = "txt2D";
            this.txt2D.Size = new System.Drawing.Size(254, 57);
            this.txt2D.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 78;
            this.label1.Text = "Animation-2D:";
            // 
            // txtMIS
            // 
            this.txtMIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMIS.Location = new System.Drawing.Point(471, 207);
            this.txtMIS.Multiline = true;
            this.txtMIS.Name = "txtMIS";
            this.txtMIS.Size = new System.Drawing.Size(254, 57);
            this.txtMIS.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 80;
            this.label2.Text = "MIS:";
            // 
            // txtSA
            // 
            this.txtSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSA.Location = new System.Drawing.Point(471, 297);
            this.txtSA.Multiline = true;
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(254, 57);
            this.txtSA.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 37);
            this.label3.TabIndex = 82;
            this.label3.Text = "SA:";
            // 
            // txtWEB
            // 
            this.txtWEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWEB.Location = new System.Drawing.Point(1197, 135);
            this.txtWEB.Multiline = true;
            this.txtWEB.Name = "txtWEB";
            this.txtWEB.Size = new System.Drawing.Size(238, 57);
            this.txtWEB.TabIndex = 87;
            this.txtWEB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1041, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 37);
            this.label5.TabIndex = 86;
            this.label5.Text = "WEB:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSMI
            // 
            this.txtSMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMI.Location = new System.Drawing.Point(1197, 50);
            this.txtSMI.Multiline = true;
            this.txtSMI.Name = "txtSMI";
            this.txtSMI.Size = new System.Drawing.Size(238, 57);
            this.txtSMI.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1041, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 37);
            this.label6.TabIndex = 88;
            this.label6.Text = "SM I:";
            // 
            // txtNetwork
            // 
            this.txtNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetwork.Location = new System.Drawing.Point(1197, 222);
            this.txtNetwork.Multiline = true;
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.Size = new System.Drawing.Size(238, 57);
            this.txtNetwork.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1041, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 37);
            this.label4.TabIndex = 91;
            this.label4.Text = "Network:";
            // 
            // txtJava
            // 
            this.txtJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJava.Location = new System.Drawing.Point(1197, 308);
            this.txtJava.Multiline = true;
            this.txtJava.Name = "txtJava";
            this.txtJava.Size = new System.Drawing.Size(238, 57);
            this.txtJava.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1041, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 37);
            this.label8.TabIndex = 93;
            this.label8.Text = "JAVA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txt2D);
            this.panel1.Controls.Add(this.txtJava);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtOracle);
            this.panel1.Controls.Add(this.txtNetwork);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSMI);
            this.panel1.Controls.Add(this.txtMIS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtWEB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSA);
            this.panel1.Location = new System.Drawing.Point(282, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1640, 418);
            this.panel1.TabIndex = 95;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MonthCombo
            // 
            this.MonthCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthCombo.Location = new System.Drawing.Point(261, 200);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(376, 40);
            this.MonthCombo.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-3, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 37);
            this.label11.TabIndex = 98;
            this.label11.Text = "Month:";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2156, 1239);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MonthCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.TextBox txtOracle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txt2D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWEB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSMI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNetwork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJava;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox MonthCombo;
        private System.Windows.Forms.Label label11;
    }
}