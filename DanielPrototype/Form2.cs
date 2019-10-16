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
    public partial class Form2 : Form
    {
        public static int EmpID;
        public static int Emprate;
   
        public Form2()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AQUQBDR\SQLEXPRESS;Initial Catalog=AttendanceProtDb;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Sp_Login", conn);
            sda.SelectCommand.Parameters.AddWithValue("@username", txt_username.Text);
            sda.SelectCommand.Parameters.AddWithValue("@userpass", txt_password.Text);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new System.Data.DataTable();
            gettersetter set_ID = new gettersetter();
            sda.Fill(dt);


            
            if (dt.Rows.Count == 1)

            {
                set_ID.setEmp_ID(Convert.ToInt32(dt.Rows[0][1].ToString()));
                switch (dt.Rows[0][0].ToString())
                {
                    case "1":
                        {
                            this.Hide();
                            Form4 f4 = new Form4();
                            f4.Show();
                            break;
                        }

                    case "2":
                        {
                            conn.Open();
                            SqlCommand Comm2 = new SqlCommand("sp_timecon", conn);
                            Comm2.Parameters.AddWithValue("@username", txt_username.Text);
                            Comm2.CommandType = CommandType.StoredProcedure;
                            SqlDataReader DR1 = Comm2.ExecuteReader();
                            if (DR1.Read())
                            {
                                EmpID = Convert.ToInt32(DR1[0]);
                                Emprate = Convert.ToInt32(DR1[1]);
                            }
                            this.Hide();
                            Form3 f3 = new Form3();
                            f3.Show();
                            conn.Close();
                            break;
                        }

                    default:
                        {
                            // ... handle unexpected roles here...
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }




        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
  }

