using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DanielPrototype
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            profile1.Visible = true;
            attendance1.Visible = false;
            Profilebutton.ForeColor = Color.FromArgb(111,104,102);
            AttendanceButton.ForeColor = Color.FromArgb(255, 255, 255);
            DashboardButton.ForeColor = Color.FromArgb(255, 255, 255);
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void Profile1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            profile1.Visible = false;
            attendance1.Visible = true;
            AttendanceButton.ForeColor = Color.FromArgb(111, 104, 102);
            Profilebutton.ForeColor = Color.FromArgb(255, 255, 255);
            DashboardButton.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Profile1_Load_1(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            profile1.Visible = false;
            attendance1.Visible = false;
            AttendanceButton.ForeColor = Color.FromArgb(255, 255, 255);
            Profilebutton.ForeColor = Color.FromArgb(255, 255, 255);
            DashboardButton.ForeColor = Color.FromArgb(111, 104, 102);
        }

        private void Attendance1_Load(object sender, EventArgs e)
        {

        }

        private void Attendance1_Load_1(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            profile1.Visible = false;
            attendance1.Visible = false;

            AttendanceButton.ForeColor = Color.FromArgb(255, 255, 255);
            Profilebutton.ForeColor = Color.FromArgb(255, 255, 255);
            DashboardButton.ForeColor = Color.FromArgb(111, 104, 102);

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            profile1.Visible = true;
            attendance1.Visible = false;

            Profilebutton.ForeColor = Color.FromArgb(111, 104, 102);
            AttendanceButton.ForeColor = Color.FromArgb(255, 255, 255);
            DashboardButton.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            profile1.Visible = false;
            attendance1.Visible = true;

            AttendanceButton.ForeColor = Color.FromArgb(111, 104, 102);
            Profilebutton.ForeColor = Color.FromArgb(255, 255, 255);
            DashboardButton.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}

