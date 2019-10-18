namespace DanielPrototype
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Admin_Logout = new System.Windows.Forms.Label();
            this.Admin_worksched = new System.Windows.Forms.Label();
            this.Admin_notif = new System.Windows.Forms.Label();
            this.Admin_Attendance = new System.Windows.Forms.Label();
            this.Admin_Emp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminEmp2 = new DanielPrototype.AdminEmp();
            this.attendanceTbl1 = new DanielPrototype.AttendanceTbl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_Logout
            // 
            this.Admin_Logout.AutoSize = true;
            this.Admin_Logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Logout.ForeColor = System.Drawing.Color.White;
            this.Admin_Logout.Location = new System.Drawing.Point(1351, 32);
            this.Admin_Logout.Name = "Admin_Logout";
            this.Admin_Logout.Size = new System.Drawing.Size(76, 23);
            this.Admin_Logout.TabIndex = 19;
            this.Admin_Logout.Text = "LogOut";
            this.Admin_Logout.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Admin_worksched
            // 
            this.Admin_worksched.AutoSize = true;
            this.Admin_worksched.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_worksched.ForeColor = System.Drawing.Color.White;
            this.Admin_worksched.Location = new System.Drawing.Point(1015, 73);
            this.Admin_worksched.Name = "Admin_worksched";
            this.Admin_worksched.Size = new System.Drawing.Size(137, 23);
            this.Admin_worksched.TabIndex = 18;
            this.Admin_worksched.Text = "Work Schedule";
            this.Admin_worksched.Click += new System.EventHandler(this.Label3_Click);
            this.Admin_worksched.MouseHover += new System.EventHandler(this.Label3_MouseHover);
            // 
            // Admin_notif
            // 
            this.Admin_notif.AutoSize = true;
            this.Admin_notif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_notif.ForeColor = System.Drawing.Color.White;
            this.Admin_notif.Location = new System.Drawing.Point(838, 73);
            this.Admin_notif.Name = "Admin_notif";
            this.Admin_notif.Size = new System.Drawing.Size(117, 23);
            this.Admin_notif.TabIndex = 17;
            this.Admin_notif.Text = "Notifications";
            this.Admin_notif.MouseHover += new System.EventHandler(this.Label2_MouseHover);
            // 
            // Admin_Attendance
            // 
            this.Admin_Attendance.AutoSize = true;
            this.Admin_Attendance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Attendance.ForeColor = System.Drawing.Color.White;
            this.Admin_Attendance.Location = new System.Drawing.Point(1147, 32);
            this.Admin_Attendance.Name = "Admin_Attendance";
            this.Admin_Attendance.Size = new System.Drawing.Size(107, 23);
            this.Admin_Attendance.TabIndex = 16;
            this.Admin_Attendance.Text = "Attendance";
            this.Admin_Attendance.Click += new System.EventHandler(this.Admin_Attendance_Click);
            this.Admin_Attendance.MouseHover += new System.EventHandler(this.Admin_Attendance_MouseHover);
            // 
            // Admin_Emp
            // 
            this.Admin_Emp.AutoSize = true;
            this.Admin_Emp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Emp.ForeColor = System.Drawing.Color.White;
            this.Admin_Emp.Location = new System.Drawing.Point(955, 32);
            this.Admin_Emp.Name = "Admin_Emp";
            this.Admin_Emp.Size = new System.Drawing.Size(93, 23);
            this.Admin_Emp.TabIndex = 15;
            this.Admin_Emp.Text = "Employee";
            this.Admin_Emp.Click += new System.EventHandler(this.Admin_Emp_Click);
            this.Admin_Emp.MouseHover += new System.EventHandler(this.Admin_Emp_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Administrator";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DanielPrototype.Properties.Resources.logout__1_;
            this.pictureBox6.Location = new System.Drawing.Point(1313, 23);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DanielPrototype.Properties.Resources.work_agenda;
            this.pictureBox5.Location = new System.Drawing.Point(977, 64);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DanielPrototype.Properties.Resources.notification;
            this.pictureBox4.Location = new System.Drawing.Point(800, 64);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DanielPrototype.Properties.Resources.png;
            this.pictureBox3.Location = new System.Drawing.Point(1109, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DanielPrototype.Properties.Resources.avatar__3_;
            this.pictureBox2.Location = new System.Drawing.Point(906, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            // 
            // adminEmp2
            // 
            this.adminEmp2.Location = new System.Drawing.Point(25, 64);
            this.adminEmp2.Margin = new System.Windows.Forms.Padding(5);
            this.adminEmp2.Name = "adminEmp2";
            this.adminEmp2.Size = new System.Drawing.Size(1402, 605);
            this.adminEmp2.TabIndex = 22;
            // 
            // attendanceTbl1
            // 
            this.attendanceTbl1.Location = new System.Drawing.Point(25, 64);
            this.attendanceTbl1.Margin = new System.Windows.Forms.Padding(5);
            this.attendanceTbl1.Name = "attendanceTbl1";
            this.attendanceTbl1.Size = new System.Drawing.Size(1402, 605);
            this.attendanceTbl1.TabIndex = 28;
            this.attendanceTbl1.Visible = false;
            this.attendanceTbl1.Load += new System.EventHandler(this.AttendanceTbl1_Load);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1445, 683);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Admin_Logout);
            this.Controls.Add(this.Admin_Attendance);
            this.Controls.Add(this.Admin_Emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminEmp2);
            this.Controls.Add(this.attendanceTbl1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Admin_notif);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Admin_worksched);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Admin_Logout;
        private System.Windows.Forms.Label Admin_worksched;
        private System.Windows.Forms.Label Admin_notif;
        private System.Windows.Forms.Label Admin_Attendance;
        private System.Windows.Forms.Label Admin_Emp;
        private System.Windows.Forms.Label label1;
        private AdminEmp adminEmp2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private AttendanceTbl attendanceTbl1;
    }
}