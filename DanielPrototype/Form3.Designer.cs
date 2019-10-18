namespace DanielPrototype
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Profilebutton = new System.Windows.Forms.Label();
            this.AttendanceButton = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DashboardButton = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dashIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Attendanceicon = new System.Windows.Forms.PictureBox();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.attendance1 = new DanielPrototype.Attendance();
            this.dashboard1 = new DanielPrototype.Dashboard();
            this.profile1 = new DanielPrototype.Profile();
            ((System.ComponentModel.ISupportInitialize)(this.dashIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendanceicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Profilebutton
            // 
            this.Profilebutton.AutoSize = true;
            this.Profilebutton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profilebutton.ForeColor = System.Drawing.Color.White;
            this.Profilebutton.Location = new System.Drawing.Point(48, 240);
            this.Profilebutton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Profilebutton.Name = "Profilebutton";
            this.Profilebutton.Size = new System.Drawing.Size(61, 20);
            this.Profilebutton.TabIndex = 3;
            this.Profilebutton.Text = "Profile";
            this.Profilebutton.Click += new System.EventHandler(this.Label9_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.AutoSize = true;
            this.AttendanceButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.Location = new System.Drawing.Point(50, 296);
            this.AttendanceButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(97, 20);
            this.AttendanceButton.TabIndex = 4;
            this.AttendanceButton.Text = "Attendance";
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 342);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Attendance History";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(50, 463);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Logout";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.AutoSize = true;
            this.DashboardButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Location = new System.Drawing.Point(48, 190);
            this.DashboardButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(94, 20);
            this.DashboardButton.TabIndex = 14;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // dashIcon
            // 
            this.dashIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashIcon.Image")));
            this.dashIcon.Location = new System.Drawing.Point(20, 178);
            this.dashIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashIcon.Name = "dashIcon";
            this.dashIcon.Size = new System.Drawing.Size(32, 32);
            this.dashIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dashIcon.TabIndex = 17;
            this.dashIcon.TabStop = false;
            this.dashIcon.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 335);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // Attendanceicon
            // 
            this.Attendanceicon.Image = ((System.Drawing.Image)(resources.GetObject("Attendanceicon.Image")));
            this.Attendanceicon.Location = new System.Drawing.Point(20, 284);
            this.Attendanceicon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Attendanceicon.Name = "Attendanceicon";
            this.Attendanceicon.Size = new System.Drawing.Size(32, 32);
            this.Attendanceicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Attendanceicon.TabIndex = 8;
            this.Attendanceicon.TabStop = false;
            this.Attendanceicon.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // profileIcon
            // 
            this.profileIcon.Image = ((System.Drawing.Image)(resources.GetObject("profileIcon.Image")));
            this.profileIcon.Location = new System.Drawing.Point(20, 228);
            this.profileIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(32, 32);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profileIcon.TabIndex = 7;
            this.profileIcon.TabStop = false;
            this.profileIcon.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(22, 458);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // attendance1
            // 
            this.attendance1.AutoSize = true;
            this.attendance1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.attendance1.BackColor = System.Drawing.Color.White;
            this.attendance1.Font = new System.Drawing.Font("Digital-7", 10.15625F);
            this.attendance1.Location = new System.Drawing.Point(193, 9);
            this.attendance1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attendance1.MaximumSize = new System.Drawing.Size(820, 514);
            this.attendance1.MinimumSize = new System.Drawing.Size(820, 514);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(820, 514);
            this.attendance1.TabIndex = 29;
            this.attendance1.Load += new System.EventHandler(this.Attendance1_Load_2);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboard1.Location = new System.Drawing.Point(193, 11);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(820, 514);
            this.dashboard1.TabIndex = 12;
            this.dashboard1.Visible = false;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.White;
            this.profile1.Location = new System.Drawing.Point(193, 11);
            this.profile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile1.MaximumSize = new System.Drawing.Size(820, 514);
            this.profile1.MinimumSize = new System.Drawing.Size(820, 514);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(820, 514);
            this.profile1.TabIndex = 11;
            this.profile1.UseWaitCursor = true;
            this.profile1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1028, 544);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dashIcon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Attendanceicon);
            this.Controls.Add(this.profileIcon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AttendanceButton);
            this.Controls.Add(this.Profilebutton);
            this.Controls.Add(this.attendance1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.profile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attendanceicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Profilebutton;
        private System.Windows.Forms.Label AttendanceButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.PictureBox Attendanceicon;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Profile profile1;
        private Dashboard dashboard1;
        private System.Windows.Forms.Label DashboardButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dashIcon;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Attendance attendance1;
    }
}