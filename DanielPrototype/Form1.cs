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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // declare
            Form2 form2 = new Form2();
            do
            {
                loadvalue.Width +=1;
                loadvalue.Visible = true;
            } while (loadvalue.Width != fullload.Width);
            timer1.Stop();
            form2.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fullload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loadvalue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gradientpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
