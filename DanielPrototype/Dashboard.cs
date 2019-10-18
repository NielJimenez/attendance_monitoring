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
    public partial class Dashboard : UserControl
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
        private static int empID;
        public Dashboard()
        {
            InitializeComponent();
            empID = Form2.EmpID;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TotalEmployee();
            attendancetotal();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        public void TotalEmployee()
        {
            
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("sp_List_Emp", Conn);
            SqlDataReader DR1 = Comm1.ExecuteReader();

            while (DR1.Read())
            {
                Emp_Total.Text = DR1[0].ToString();
            }
            Conn.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void attendancetotal()
        {
            Conn.Open();
            string sql = "Sp_totattend";
            SqlCommand Comm2 = new SqlCommand(sql, Conn);
            Comm2.Parameters.AddWithValue("@id", empID);
            Comm2.CommandType = CommandType.StoredProcedure;
            SqlDataReader DR1 = Comm2.ExecuteReader();
            
 
            while (DR1.Read())
            { 
               label_attend.Text = DR1[0].ToString();
            }
            
            
            Conn.Close();
        }

    }
}
