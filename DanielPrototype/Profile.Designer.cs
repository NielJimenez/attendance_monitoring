namespace DanielPrototype
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_Bdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Age = new System.Windows.Forms.TextBox();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.text_Lname = new System.Windows.Forms.TextBox();
            this.text_Fname = new System.Windows.Forms.TextBox();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sampleAge = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 460);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.panel6.Controls.Add(this.sampleAge);
            this.panel6.Controls.Add(this.text_Bdate);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.text_Age);
            this.panel6.Controls.Add(this.text_Address);
            this.panel6.Controls.Add(this.text_Lname);
            this.panel6.Controls.Add(this.text_Fname);
            this.panel6.Controls.Add(this.text_ID);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(11, 63);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(596, 377);
            this.panel6.TabIndex = 4;
            // 
            // text_Bdate
            // 
            this.text_Bdate.Location = new System.Drawing.Point(5, 331);
            this.text_Bdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Bdate.Name = "text_Bdate";
            this.text_Bdate.Size = new System.Drawing.Size(324, 20);
            this.text_Bdate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // text_Age
            // 
            this.text_Age.Location = new System.Drawing.Point(5, 265);
            this.text_Age.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Age.Name = "text_Age";
            this.text_Age.Size = new System.Drawing.Size(324, 20);
            this.text_Age.TabIndex = 13;
            // 
            // text_Address
            // 
            this.text_Address.Location = new System.Drawing.Point(5, 189);
            this.text_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(324, 20);
            this.text_Address.TabIndex = 12;
            // 
            // text_Lname
            // 
            this.text_Lname.Location = new System.Drawing.Point(160, 112);
            this.text_Lname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Lname.Name = "text_Lname";
            this.text_Lname.Size = new System.Drawing.Size(169, 20);
            this.text_Lname.TabIndex = 11;
            // 
            // text_Fname
            // 
            this.text_Fname.Location = new System.Drawing.Point(6, 112);
            this.text_Fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_Fname.Name = "text_Fname";
            this.text_Fname.Size = new System.Drawing.Size(152, 20);
            this.text_Fname.TabIndex = 10;
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(5, 41);
            this.text_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(324, 20);
            this.text_ID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(11, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 8);
            this.panel2.TabIndex = 0;
            // 
            // sampleAge
            // 
            this.sampleAge.AutoSize = true;
            this.sampleAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleAge.ForeColor = System.Drawing.Color.White;
            this.sampleAge.Location = new System.Drawing.Point(467, 60);
            this.sampleAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sampleAge.Name = "sampleAge";
            this.sampleAge.Size = new System.Drawing.Size(83, 19);
            this.sampleAge.TabIndex = 16;
            this.sampleAge.Text = "sampleAge";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(617, 462);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.TextBox text_Lname;
        private System.Windows.Forms.TextBox text_Fname;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Age;
        private System.Windows.Forms.TextBox text_Bdate;
        private System.Windows.Forms.Label sampleAge;
    }
}
