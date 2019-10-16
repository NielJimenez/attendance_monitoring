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
    public partial class Profile : UserControl
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
        public Profile()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
           
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            gettersetter setter_profile = new gettersetter();
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("Sp_Select_EmpInfo", Conn);
            Comm1.Parameters.AddWithValue("@p_EmpID", setter_profile.getEmp_ID());
            Comm1.CommandType = CommandType.StoredProcedure;
            SqlDataReader DR1 = Comm1.ExecuteReader();

            while (DR1.Read())
            {
                text_ID.Text = DR1["Emp_ID"].ToString();
                text_Fname.Text = DR1["FirstName"].ToString();
                text_Lname.Text = DR1["LastName"].ToString();
                text_Age.Text = DR1["Age"].ToString();
                text_Bdate.Text = DR1["Birthdate"].ToString();
                text_Address.Text = DR1["Emp_Address"].ToString();
                sampleAge.Text = DR1["Age"].ToString();
            }
        }
    }
}
