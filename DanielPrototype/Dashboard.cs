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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            TotalEmployee();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }
        public void TotalEmployee()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("sp_List_Emp", Conn);
            SqlDataReader DR1 = Comm1.ExecuteReader();

            while (DR1.Read())
            {
                Emp_Total.Text = DR1[0].ToString();
            }
        }
    }
}
