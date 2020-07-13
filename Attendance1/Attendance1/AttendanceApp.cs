using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Attendance1
{
    public partial class Attendance_Login : Form
    {
        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        string role;

        public Attendance_Login()
        {
            InitializeComponent();
        }

        private void Attendance_Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTDataSet.login' table. You can move, or remove it, as needed.   
            try
            {
                SqlConn = new SqlConnection("Data Source=DESKTOP-2078AJ7\\CREET_SERVER;Initial Catalog=AttendanceApp;Integrated Security=True");
                // SqlConn = new SqlConnection("Data Source=.;Initial Catalog=Personal_Assistant;Persist Security Info=True;User ID=sa;Password=123456");
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);
            }
            SqlConn.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string str = "SELECT * from Login WHERE Username = +'" + txtuser.Text + "'" + " and Password = +'" + txtpass.Text + "' " + "and Role =+ '" + cmbrole.SelectedItem + "'";
            SqlComm = new SqlCommand(str, SqlConn);
            try
            {

                SqlConn.Open();
                SqlReader = SqlComm.ExecuteReader();
             if (SqlReader.HasRows)
                {
                    SqlReader.Read();

                    role = SqlReader.GetString(3);

                    if (role.ToLower() == "admin")
                    {
                        MessageBox.Show("Welcome \t" + txtuser.Text, "Admin_Login");
                       Admin_Dashboard gn = new Admin_Dashboard();
                        gn.Show();
                        this.Hide();
                    }
                    else if (role.ToLower() == "user")
                    {
                        MessageBox.Show("Welcome \t" + txtuser.Text, "User_Login");
                      
                    }
                    else
                    {
                        MessageBox.Show("Invalid Authentication");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Authentication", "Error Message");
                }
                if (txtuser.Text.Length == 0 && txtpass.Text.Length == 0 && cmbrole.Text.Length == 0)
                {
                    MessageBox.Show("No Filled Can be Left Empty");
                }
                else { }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());

            }
            SqlReader.Close();
            SqlConn.Close();
        }
    }
}
