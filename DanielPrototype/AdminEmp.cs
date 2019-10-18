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
    public partial class AdminEmp : UserControl
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
        
        public AdminEmp()
        {
            InitializeComponent();
            
        }

        private void AdminEmp_Load(object sender, EventArgs e)
        {

           EmpRefresh();


        }
        public void EmpRefresh()
        {
            gettersetter setter_profile = new gettersetter();
            Conn.Open();
            SqlDataAdapter Comm1 = new SqlDataAdapter("sp_Emp_Read", Conn);
            Comm1.SelectCommand.Parameters.AddWithValue("@Emp_ID", setter_profile.getEmp_ID());
            Comm1.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();
            Comm1.Fill(dt);
            label1ID.DataBindings.Clear();
            labelFname.DataBindings.Clear();
            labelLName.DataBindings.Clear();
            label1Age.DataBindings.Clear();
            label1Bdate.DataBindings.Clear();
            label1Address.DataBindings.Clear();
            label1username.DataBindings.Clear();
            label1userpass.DataBindings.Clear();
            label_ERate.DataBindings.Clear();

            label1ID.DataBindings.Add("Text", dt, "Emp_ID");
            labelFname.DataBindings.Add("Text", dt, "FirstName");
            labelLName.DataBindings.Add("Text", dt, "LastName");
            label1Age.DataBindings.Add("Text", dt, "Age");
            label1Bdate.DataBindings.Add("Text", dt, "Birthdate");
            label1Address.DataBindings.Add("Text", dt, "Emp_Address");
            label1username.DataBindings.Add("Text", dt, "username");
            label1userpass.DataBindings.Add("Text", dt, "userpass");
            label_ERate.DataBindings.Add("Text", dt, "Emp_Rate");
            dataRepeater1.DataSource = dt;
            Conn.Close();


        }
        public void Emp_Read()
        {
           /* gettersetter setter_profile = new gettersetter();
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("SP_Select_EmpInfo", Conn);
            Comm1.Parameters.AddWithValue("@p_EmpID", setter_profile.getEmp_ID());
            Comm1.CommandType = CommandType.StoredProcedure;
            SqlDataReader DR1 = Comm1.ExecuteReader();

            while (DR1.Read())
            {
                label1ID.Text = DR1["Emp_ID"].ToString();
                labelFname.Text = DR1["FirstName"].ToString();
                labelLName.Text = DR1["LastName"].ToString();
                label1Age.Text = DR1["Age"].ToString();
                label1Bdate.Text = DR1["Birthdate"].ToString();
                label1Address.Text = DR1["Emp_Address"].ToString();
                label1username.Text = DR1["username"].ToString();
                label1userpass.Text = DR1["userpass"].ToString();

            }*/
        }

        private void DataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string ID = dataRepeater1.CurrentItem.Controls["label1ID"].Text.ToString();
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("sp_delete_Emp", Conn);
            Comm1.Parameters.AddWithValue("@Emp_ID", ID );
            Comm1.CommandType = System.Data.CommandType.StoredProcedure;
            Comm1.ExecuteNonQuery();
            Conn.Close();
            EmpRefresh();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
         
        }

        private void RefreshIcon_Click(object sender, EventArgs e)
        {
            EmpRefresh();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void InsertIcon_Click(object sender, EventArgs e)
        {
            
            Conn.Open();
            
            SqlCommand Comm1 = new SqlCommand("sp_create_Emp", Conn);
            Comm1.Parameters.AddWithValue("@usertype", Type_combox.Text);
            Comm1.Parameters.AddWithValue("@FirstName", Fname_label.Text);
            Comm1.Parameters.AddWithValue("@LastName", L_label.Text);
            Comm1.Parameters.AddWithValue("@Age", Age_label.Text);
            Comm1.Parameters.AddWithValue("@Emp_Address", Address_label.Text);
            Comm1.Parameters.AddWithValue("@username", Uname_label.Text);
            Comm1.Parameters.AddWithValue("@userpass", Upass_label.Text);
            Comm1.Parameters.AddWithValue("@Birthdate", datepick_txt.Text );
            Comm1.Parameters.AddWithValue("@EmpRate", label_ERate.Text);
            Comm1.CommandType = CommandType.StoredProcedure;
            Comm1.ExecuteNonQuery();

            Type_combox.SelectedIndex = -1;
            Fname_label.Text = "";
            L_label.Text = "";
            Age_label.Text = "";
            Address_label.Text = "";
            datepick_txt.Text = "";
            Uname_label.Text = "";
            Upass_label.Text = "";
            label_ERate.Text = "";
            Conn.Close();
            EmpRefresh();
        }

        private void UpdateIcon_Click(object sender, EventArgs e)
        {
            string ID = dataRepeater1.CurrentItem.Controls["label1ID"].Text.ToString();
            Conn.Open();
            SqlCommand Comm1 = new SqlCommand("sp_update_empinfo", Conn);
            Comm1.Parameters.AddWithValue("@FirstName", Fname_label.Text);
            Comm1.Parameters.AddWithValue("@LastName", L_label.Text);
            Comm1.Parameters.AddWithValue("@Age", Convert.ToInt32(Age_label.Text));
            Comm1.Parameters.AddWithValue("@Emp_Address", Address_label.Text);
            Comm1.Parameters.AddWithValue("@Birthdate", datepick_txt.Text);
            Comm1.Parameters.AddWithValue("@username", Uname_label.Text);
            Comm1.Parameters.AddWithValue("@userpass", Upass_label.Text);
            Comm1.Parameters.AddWithValue("@EmpID", Convert.ToInt32(ID));
            Comm1.CommandType = System.Data.CommandType.StoredProcedure;
            Comm1.ExecuteNonQuery();


            Type_combox.SelectedIndex = -1;
            Fname_label.Text = "";
            L_label.Text = "";
            Age_label.Text = "";
            Address_label.Text = "";
            datepick_txt.Text = "";
            Uname_label.Text = "";
            Upass_label.Text = "";
            Conn.Close();
            EmpRefresh();
        }

        private void DataRepeater1_ItemTemplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void DataRepeater1_ItemTemplate_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Type_combox.SelectedIndex = -1;
                Fname_label.Text = dataRepeater1.CurrentItem.Controls["labelFname"].Text.ToString();
                L_label.Text = dataRepeater1.CurrentItem.Controls["labelLName"].Text.ToString(); 
                Age_label.Text = dataRepeater1.CurrentItem.Controls["label1Age"].Text.ToString(); 
                Address_label.Text = dataRepeater1.CurrentItem.Controls["label1Address"].Text.ToString();
                datepick_txt.Text = dataRepeater1.CurrentItem.Controls["label1Bdate"].Text.ToString(); ;
                Uname_label.Text = dataRepeater1.CurrentItem.Controls["label1username"].Text.ToString(); 
                Upass_label.Text = dataRepeater1.CurrentItem.Controls["label1userpass"].Text.ToString();
                

            }
            catch (Exception ex)
            {
               
            }
            
            
        }

        private void Date_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
            Conn.Open();
            SqlDataAdapter Comm1 = new SqlDataAdapter("sp_search_emp", Conn);
            Comm1.SelectCommand.Parameters.AddWithValue("@searchvar", search_box.Text);
            Comm1.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            Comm1.Fill(dt);

            labelFname.DataBindings.Clear();
            labelLName.DataBindings.Clear();
            /*label1Age.DataBindings.Clear();
            label1Bdate.DataBindings.Clear();
            label1Address.DataBindings.Clear();
            label1username.DataBindings.Clear();
            label1userpass.DataBindings.Clear();*/

            Conn.Close();
            if (dt.Rows.Count > 0){
                labelFname.DataBindings.Add("Text", dt, "FirstName");
                labelLName.DataBindings.Add("Text", dt, "LastName");
                /*label1Age.DataBindings.Add("Text", dt, "Age");
                label1Bdate.DataBindings.Add("Text", dt, "Birthdate");
                label1Address.DataBindings.Add("Text", dt, "Emp_Address");
                label1username.DataBindings.Add("Text", dt, "username");
                label1userpass.DataBindings.Add("Text", dt, "userpass");*/

                dataRepeater1.DataSource = dt;
            }
                   
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
