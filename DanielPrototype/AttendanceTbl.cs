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
    public partial class AttendanceTbl : UserControl
    {
        private int empId;

        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
        public AttendanceTbl()
        {
            InitializeComponent();
        }

        private void RefreshIcon_Click(object sender, EventArgs e)
        {

        }

        private void DataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AttendanceTbl_Load(object sender, EventArgs e)
        {
            EmpRefresh();
           
        }
        public void EmpRefresh()
        {
           
            gettersettertimecs setter_profile = new gettersettertimecs();
            Conn.Open();
            SqlDataAdapter Comm1 = new SqlDataAdapter("sp_Attend_Read", Conn);
            Comm1.SelectCommand.Parameters.AddWithValue("@TimeID", setter_profile.getTime_ID());
            
            //Comm1.SelectCommand.Parameters.AddWithValue("@TimeID", setter_profile.getTime_ID());
            Comm1.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            Comm1.Fill(dt);
            label_ID.DataBindings.Clear();
            Label_Ename.DataBindings.Clear();
            label_Timein.DataBindings.Clear();
            label_Timeout.DataBindings.Clear();
            label_Thours.DataBindings.Clear();
            label_rate.DataBindings.Clear();
            label_salary.DataBindings.Clear();
            label_EmpId.DataBindings.Clear();

            label_EmpId.DataBindings.Add("Text", dt, "Emp_Id");
            label_ID.DataBindings.Add("Text", dt, "Time_ID");
            Label_Ename.DataBindings.Add("Text", dt, "EmployeeName");
            //labelLName.DataBindings.Add("Text", dt, "LastName");
            label_Timein.DataBindings.Add("Text", dt, "Time_in");
            label_Timeout.DataBindings.Add("Text", dt, "Time_out");
            label_Thours.DataBindings.Add("Text", dt, "Total_hours");
            label_rate.DataBindings.Add("Text", dt, "rate");
            label_salary.DataBindings.Add("Text", dt, "Salary");
            dataRepeater1.DataSource = dt;
            Conn.Close();


        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_Timeout_Click(object sender, EventArgs e)
        {

        }

        private void Label_Thours_Click(object sender, EventArgs e)
        {

        }

        private void Label_rate_Click(object sender, EventArgs e)
        {

        }

        private void InsertIcon_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("sp_Emprate", Conn);
            Comm1.Parameters.AddWithValue("@Emprate", Convert.ToInt32(Rateinput.Text));
            Comm1.Parameters.AddWithValue("@EmpID", empId);
            Comm1.CommandType = CommandType.StoredProcedure;
            Comm1.ExecuteNonQuery();

            Conn.Close();
            EmpRefresh();
        }

        private void DataRepeater1_ItemTemplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                empId = Convert.ToInt32(dataRepeater1.CurrentItem.Controls["label_EmpId"].Text);

                Conn.Open();
                SqlCommand Comm2 = new SqlCommand("SP_Select_EmpInfo", Conn);
                Comm2.Parameters.AddWithValue("@p_EmpID", empId);
                Comm2.CommandType = CommandType.StoredProcedure;
                SqlDataReader DR = Comm2.ExecuteReader();

                if (DR.Read())
                {
                    Rateinput.Text = Convert.ToString(DR["Emp_Rate"]);
                }
                Conn.Close();
            }
            catch
            {

            }
        }

        private void Label_salary_Click(object sender, EventArgs e)
        {

        }
    }
}
