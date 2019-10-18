namespace DanielPrototype
{
    partial class Attendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeIn = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label_EmpID = new System.Windows.Forms.Label();
            this.label_Timeout = new System.Windows.Forms.Label();
            this.label_Timein = new System.Windows.Forms.Label();
            this.RealTime = new System.Windows.Forms.Label();
            this.btn_timein = new System.Windows.Forms.Button();
            this.bttn_timeout = new System.Windows.Forms.Button();
            this.RealtimeSecond = new System.Windows.Forms.Label();
            this.RealDate = new System.Windows.Forms.Label();
            this.RealDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.panel1.Location = new System.Drawing.Point(9, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(611, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Timeout";
            // 
            // TimeIn
            // 
            this.TimeIn.AutoSize = true;
            this.TimeIn.BackColor = System.Drawing.Color.Transparent;
            this.TimeIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.ForeColor = System.Drawing.Color.White;
            this.TimeIn.Location = new System.Drawing.Point(357, 15);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(67, 22);
            this.TimeIn.TabIndex = 18;
            this.TimeIn.Text = "Timein";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InfoText;
            this.monthCalendar1.Location = new System.Drawing.Point(6, 53);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.TodayDate = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label_EmpID);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label_Timeout);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label_Timein);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(499, 100);
            this.dataRepeater1.Location = new System.Drawing.Point(281, 40);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(507, 405);
            this.dataRepeater1.TabIndex = 16;
            this.dataRepeater1.Text = "dataRepeater1";
            this.dataRepeater1.CurrentItemIndexChanged += new System.EventHandler(this.DataRepeater1_CurrentItemIndexChanged_1);
            // 
            // label_EmpID
            // 
            this.label_EmpID.AutoSize = true;
            this.label_EmpID.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmpID.Location = new System.Drawing.Point(3, 37);
            this.label_EmpID.Name = "label_EmpID";
            this.label_EmpID.Size = new System.Drawing.Size(41, 14);
            this.label_EmpID.TabIndex = 2;
            this.label_EmpID.Text = "EmpID";
            // 
            // label_Timeout
            // 
            this.label_Timeout.AutoSize = true;
            this.label_Timeout.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timeout.Location = new System.Drawing.Point(312, 37);
            this.label_Timeout.Name = "label_Timeout";
            this.label_Timeout.Size = new System.Drawing.Size(47, 14);
            this.label_Timeout.TabIndex = 1;
            this.label_Timeout.Text = "Timeout";
            // 
            // label_Timein
            // 
            this.label_Timein.AutoSize = true;
            this.label_Timein.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timein.Location = new System.Drawing.Point(58, 37);
            this.label_Timein.Name = "label_Timein";
            this.label_Timein.Size = new System.Drawing.Size(41, 14);
            this.label_Timein.TabIndex = 0;
            this.label_Timein.Text = "Timein";
            // 
            // RealTime
            // 
            this.RealTime.AutoSize = true;
            this.RealTime.BackColor = System.Drawing.Color.White;
            this.RealTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.RealTime.Font = new System.Drawing.Font("Digital-7", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.RealTime.Location = new System.Drawing.Point(4, 7);
            this.RealTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealTime.Name = "RealTime";
            this.RealTime.Size = new System.Drawing.Size(72, 34);
            this.RealTime.TabIndex = 4;
            this.RealTime.Text = "Time";
            this.RealTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RealTime.Click += new System.EventHandler(this.RealTime_Click_1);
            // 
            // btn_timein
            // 
            this.btn_timein.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timein.Location = new System.Drawing.Point(10, 311);
            this.btn_timein.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_timein.Name = "btn_timein";
            this.btn_timein.Size = new System.Drawing.Size(256, 64);
            this.btn_timein.TabIndex = 15;
            this.btn_timein.Text = "Time In";
            this.btn_timein.UseVisualStyleBackColor = true;
            this.btn_timein.Click += new System.EventHandler(this.Btn_timein_Click);
            // 
            // bttn_timeout
            // 
            this.bttn_timeout.Enabled = false;
            this.bttn_timeout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_timeout.Location = new System.Drawing.Point(10, 381);
            this.bttn_timeout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bttn_timeout.Name = "bttn_timeout";
            this.bttn_timeout.Size = new System.Drawing.Size(256, 64);
            this.bttn_timeout.TabIndex = 14;
            this.bttn_timeout.Text = "Time Out";
            this.bttn_timeout.UseVisualStyleBackColor = true;
            this.bttn_timeout.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // RealtimeSecond
            // 
            this.RealtimeSecond.AutoSize = true;
            this.RealtimeSecond.BackColor = System.Drawing.Color.White;
            this.RealtimeSecond.Font = new System.Drawing.Font("Digital-7", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealtimeSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.RealtimeSecond.Location = new System.Drawing.Point(63, 7);
            this.RealtimeSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealtimeSecond.Name = "RealtimeSecond";
            this.RealtimeSecond.Size = new System.Drawing.Size(115, 34);
            this.RealtimeSecond.TabIndex = 5;
            this.RealtimeSecond.Text = "second";
            this.RealtimeSecond.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RealDate
            // 
            this.RealDate.AutoSize = true;
            this.RealDate.BackColor = System.Drawing.Color.Transparent;
            this.RealDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealDate.ForeColor = System.Drawing.Color.White;
            this.RealDate.Location = new System.Drawing.Point(131, 7);
            this.RealDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealDate.Name = "RealDate";
            this.RealDate.Size = new System.Drawing.Size(57, 26);
            this.RealDate.TabIndex = 12;
            this.RealDate.Text = "Date";
            this.RealDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealDate.Click += new System.EventHandler(this.RealDate_Click);
            // 
            // RealDay
            // 
            this.RealDay.AutoSize = true;
            this.RealDay.BackColor = System.Drawing.Color.Transparent;
            this.RealDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealDay.ForeColor = System.Drawing.Color.White;
            this.RealDay.Location = new System.Drawing.Point(132, 20);
            this.RealDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealDay.Name = "RealDay";
            this.RealDay.Size = new System.Drawing.Size(36, 19);
            this.RealDay.TabIndex = 11;
            this.RealDay.Text = "Day";
            this.RealDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RealTime);
            this.panel2.Controls.Add(this.TimeIn);
            this.panel2.Controls.Add(this.RealtimeSecond);
            this.panel2.Controls.Add(this.dataRepeater1);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.bttn_timeout);
            this.panel2.Controls.Add(this.btn_timein);
            this.panel2.Controls.Add(this.RealDate);
            this.panel2.Controls.Add(this.RealDay);
            this.panel2.Location = new System.Drawing.Point(9, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 449);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(9, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 20);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attendance";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Digital-7", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(820, 514);
            this.MinimumSize = new System.Drawing.Size(820, 514);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(820, 514);
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            this.dataRepeater1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RealTime;
        private System.Windows.Forms.Label RealtimeSecond;
        private System.Windows.Forms.Button btn_timein;
        private System.Windows.Forms.Button bttn_timeout;
        private System.Windows.Forms.Label RealDate;
        private System.Windows.Forms.Label RealDay;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label TimeIn;
        private System.Windows.Forms.Label label_Timeout;
        private System.Windows.Forms.Label label_Timein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_EmpID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}
