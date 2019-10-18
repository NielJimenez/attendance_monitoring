using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielPrototype
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Panel2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
           

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Emp_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void Admin_Attendance_Click(object sender, EventArgs e)
        {

            attendanceTbl1.Visible = true;
            adminEmp2.Visible = false;



             Admin_Emp.ForeColor = Color.FromArgb(255, 255, 255);
             Admin_Attendance.ForeColor = Color.FromArgb(111, 104, 102);
             Admin_notif.ForeColor = Color.FromArgb(255, 255, 255);
             Admin_worksched.ForeColor = Color.FromArgb(255, 255, 255); 

        }

        private void Admin_Attendance_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void Label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Label3_MouseHover(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Admin_Emp_Click(object sender, EventArgs e)
        {

            adminEmp2.Visible = true;
            attendanceTbl1.Visible = false;
            Admin_Emp.ForeColor = Color.FromArgb(111, 104, 102);
            Admin_Attendance.ForeColor = Color.FromArgb(255, 255, 255);
            Admin_notif.ForeColor = Color.FromArgb(255, 255, 255);
            Admin_worksched.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void AttendanceTbl1_Load(object sender, EventArgs e)
        {

        }
    }
}
