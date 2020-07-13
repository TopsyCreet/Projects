using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
 
namespace Attendance_App1
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
                    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance_Login al = new Attendance_Login();
            al.Show();
            this.Hide();
        }

        private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Lecturer al = new Add_Lecturer();
           al.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
        }

        private void btn_Lecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer al = new Add_Lecturer();
            al.Show();
        }
    }
}
