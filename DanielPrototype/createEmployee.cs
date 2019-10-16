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
    public partial class createEmployee : UserControl
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
        public createEmployee()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
       
        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
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
            Comm1.Parameters.AddWithValue("Birthdate", Bdate_picker.Value.ToShortTimeString());
            Comm1.Parameters.AddWithValue("@username", Uname_label.Text);
            Comm1.Parameters.AddWithValue("@userpass", Upass_label.Text);
            Comm1.CommandType = CommandType.StoredProcedure;
            Comm1.ExecuteNonQuery();

            Type_combox.SelectedIndex = -1;
            Fname_label.Text = "";
            L_label.Text = "";
            Age_label.Text = "";
            Address_label.Text = "";
            Bdate_picker.Text = "";
            Uname_label.Text = "";
            Upass_label.Text = "";
        }
    }
}
