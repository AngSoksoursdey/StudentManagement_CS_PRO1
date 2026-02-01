namespace Student_Management
{
    partial class DashBoard
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
            this.btn_Studentform = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelTile = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExamination = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.panelTile.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Studentform
            // 
            this.btn_Studentform.BackColor = System.Drawing.Color.Silver;
            this.btn_Studentform.FlatAppearance.BorderSize = 0;
            this.btn_Studentform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Studentform.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Studentform.Location = new System.Drawing.Point(-6, 480);
            this.btn_Studentform.Name = "btn_Studentform";
            this.btn_Studentform.Size = new System.Drawing.Size(428, 102);
            this.btn_Studentform.TabIndex = 11;
            this.btn_Studentform.Text = "Student ";
            this.btn_Studentform.UseVisualStyleBackColor = false;
            this.btn_Studentform.Click += new System.EventHandler(this.btn_Studentform_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Silver;
            this.panelmenu.Controls.Add(this.btnExamination);
            this.panelmenu.Controls.Add(this.btnLogout);
            this.panelmenu.Controls.Add(this.btnClose);
            this.panelmenu.Controls.Add(this.btnScore);
            this.panelmenu.Controls.Add(this.btnTeacher);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Controls.Add(this.btn_Studentform);
            this.panelmenu.Location = new System.Drawing.Point(1, 1);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(420, 2000);
            this.panelmenu.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(-2, 1640);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(419, 79);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(0, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(420, 111);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(-6, 587);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(428, 102);
            this.btnScore.TabIndex = 15;
            this.btnScore.Text = "Score ";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.Silver;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Location = new System.Drawing.Point(-3, 372);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(428, 102);
            this.btnTeacher.TabIndex = 14;
            this.btnTeacher.Text = "Teacher ";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.DarkGray;
            this.panellogo.BackgroundImage = global::Student_Management.Properties.Resources.images__2_;
            this.panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(420, 254);
            this.panellogo.TabIndex = 13;
            // 
            // panelTile
            // 
            this.panelTile.BackColor = System.Drawing.Color.DarkGray;
            this.panelTile.Controls.Add(this.labelTitle);
            this.panelTile.Location = new System.Drawing.Point(420, 1);
            this.panelTile.Name = "panelTile";
            this.panelTile.Size = new System.Drawing.Size(3007, 254);
            this.panelTile.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(859, 106);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(816, 46);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Welcome To Student Management System";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Location = new System.Drawing.Point(456, 256);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(2178, 1295);
            this.panelDesktop.TabIndex = 14;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management.Properties.Resources._360_degreee_school_management_systems_1024x628;
            this.pictureBox1.Location = new System.Drawing.Point(659, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1005, 666);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExamination
            // 
            this.btnExamination.BackColor = System.Drawing.Color.Silver;
            this.btnExamination.FlatAppearance.BorderSize = 0;
            this.btnExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamination.Location = new System.Drawing.Point(-6, 695);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(428, 102);
            this.btnExamination.TabIndex = 18;
            this.btnExamination.Text = "Examination";
            this.btnExamination.UseVisualStyleBackColor = false;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2884, 1770);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTile);
            this.Controls.Add(this.panelmenu);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelmenu.ResumeLayout(false);
            this.panelTile.ResumeLayout(false);
            this.panelTile.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Studentform;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Panel panelTile;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExamination;
    }
}