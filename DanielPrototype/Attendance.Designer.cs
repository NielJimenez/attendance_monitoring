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
            this.label1 = new System.Windows.Forms.Label();
            this.RealTime = new System.Windows.Forms.Label();
            this.RealtimeSecond = new System.Windows.Forms.Label();
            this.gradientpanel1 = new DanielPrototype.gradientpanel();
            this.btn_timein = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RealDate = new System.Windows.Forms.Label();
            this.RealDay = new System.Windows.Forms.Label();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.gradientpanel1.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 24);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attendance";
            // 
            // RealTime
            // 
            this.RealTime.AutoSize = true;
            this.RealTime.BackColor = System.Drawing.Color.White;
            this.RealTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.RealTime.Font = new System.Drawing.Font("Digital-7", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.RealTime.Location = new System.Drawing.Point(18, 4);
            this.RealTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealTime.Name = "RealTime";
            this.RealTime.Size = new System.Drawing.Size(91, 44);
            this.RealTime.TabIndex = 4;
            this.RealTime.Text = "Time";
            this.RealTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RealTime.Click += new System.EventHandler(this.RealTime_Click_1);
            // 
            // RealtimeSecond
            // 
            this.RealtimeSecond.AutoSize = true;
            this.RealtimeSecond.BackColor = System.Drawing.Color.White;
            this.RealtimeSecond.Font = new System.Drawing.Font("Digital-7", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealtimeSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.RealtimeSecond.Location = new System.Drawing.Point(92, 4);
            this.RealtimeSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealtimeSecond.Name = "RealtimeSecond";
            this.RealtimeSecond.Size = new System.Drawing.Size(144, 44);
            this.RealtimeSecond.TabIndex = 5;
            this.RealtimeSecond.Text = "second";
            this.RealtimeSecond.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gradientpanel1
            // 
            this.gradientpanel1.Angle = 270F;
            this.gradientpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.gradientpanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.gradientpanel1.Controls.Add(this.monthCalendar1);
            this.gradientpanel1.Controls.Add(this.dataRepeater1);
            this.gradientpanel1.Controls.Add(this.RealTime);
            this.gradientpanel1.Controls.Add(this.btn_timein);
            this.gradientpanel1.Controls.Add(this.button1);
            this.gradientpanel1.Controls.Add(this.RealtimeSecond);
            this.gradientpanel1.Controls.Add(this.RealDate);
            this.gradientpanel1.Controls.Add(this.RealDay);
            this.gradientpanel1.Location = new System.Drawing.Point(3, 33);
            this.gradientpanel1.Name = "gradientpanel1";
            this.gradientpanel1.Size = new System.Drawing.Size(1167, 621);
            this.gradientpanel1.TabIndex = 11;
            this.gradientpanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.gradientpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Gradientpanel1_Paint);
            // 
            // btn_timein
            // 
            this.btn_timein.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timein.Location = new System.Drawing.Point(6, 276);
            this.btn_timein.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_timein.Name = "btn_timein";
            this.btn_timein.Size = new System.Drawing.Size(256, 64);
            this.btn_timein.TabIndex = 15;
            this.btn_timein.Text = "Time In";
            this.btn_timein.UseVisualStyleBackColor = true;
            this.btn_timein.Click += new System.EventHandler(this.Btn_timein_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "Time Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // RealDate
            // 
            this.RealDate.AutoSize = true;
            this.RealDate.BackColor = System.Drawing.Color.Transparent;
            this.RealDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealDate.ForeColor = System.Drawing.Color.White;
            this.RealDate.Location = new System.Drawing.Point(148, 4);
            this.RealDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealDate.Name = "RealDate";
            this.RealDate.Size = new System.Drawing.Size(71, 31);
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
            this.RealDay.Location = new System.Drawing.Point(150, 21);
            this.RealDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealDay.Name = "RealDay";
            this.RealDay.Size = new System.Drawing.Size(43, 24);
            this.RealDay.TabIndex = 11;
            this.RealDay.Text = "Day";
            this.RealDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataRepeater1
            // 
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(889, 100);
            this.dataRepeater1.Location = new System.Drawing.Point(267, 265);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(897, 353);
            this.dataRepeater1.TabIndex = 16;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InfoText;
            this.monthCalendar1.Location = new System.Drawing.Point(2, 57);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.TodayDate = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientpanel1);
            this.Font = new System.Drawing.Font("Digital-7", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(1173, 657);
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gradientpanel1.ResumeLayout(false);
            this.gradientpanel1.PerformLayout();
            this.dataRepeater1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private gradientpanel gradientpanel1;
        private System.Windows.Forms.Label RealTime;
        private System.Windows.Forms.Label RealtimeSecond;
        private System.Windows.Forms.Button btn_timein;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RealDate;
        private System.Windows.Forms.Label RealDay;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
