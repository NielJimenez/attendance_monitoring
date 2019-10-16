using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DanielPrototype
{
    public partial class Attendance : UserControl
    {
        private static int EmpID;
        private static int EmpRate;
        private static int TimeID;
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
        public Attendance()
        {
            InitializeComponent();
            EmpID = Form2.EmpID;
            EmpRate = Form2.Emprate;
        }

        private void RealTime_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RealTime.Text = DateTime.Now.ToString("HH:mm");
            RealtimeSecond.Text = DateTime.Now.ToString("ss");
            RealDay.Text = DateTime.Now.ToString("dddd");
            RealDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void RealtimeSecond_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void RealTime_Click_1(object sender, EventArgs e)
        {

        }

        private void RealDate_Click(object sender, EventArgs e)
        {

        }

        private void Btn_timein_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("sp_time_insert", Conn);
            Comm1.Parameters.AddWithValue("@timein", DateTime.Now);
            Comm1.Parameters.AddWithValue("@EmpID", EmpID);
            Comm1.CommandType = CommandType.StoredProcedure;
            Comm1.ExecuteNonQuery();
            Conn.Close();

            Conn.Open();
            SqlCommand Comm2 = new SqlCommand("sp_Timeid", Conn);
            Comm2.Parameters.AddWithValue("@EmpID", EmpID);
            Comm2.CommandType = CommandType.StoredProcedure;
            SqlDataReader DR = Comm2.ExecuteReader();

            if (DR.Read())
            {
                TimeID = Convert.ToInt32(DR[0]);
            }
            Conn.Close();
            MessageBox.Show("Time In Sucessfully");
            //Comm1.Parameters.AddWithValue("@FirstName", Fname_label.Text);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Comm2 = new SqlCommand("sp_time_update", Conn);
            Comm2.Parameters.AddWithValue("@timeout", DateTime.Now);
            Comm2.Parameters.AddWithValue("@TimeID", TimeID);
            Comm2.Parameters.AddWithValue("@EmpRate", EmpRate);
            Comm2.CommandType = CommandType.StoredProcedure;
            Comm2.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Time Out   Sucessfully");
        }

        private void Gradientpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
