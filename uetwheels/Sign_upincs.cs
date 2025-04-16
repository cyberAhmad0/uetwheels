using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uetwheels
{
    public partial class Sign_upincs : Form
    {
        static string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conn);
        public Sign_upincs()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            string username = g2tb_4.Text;
            string password = g2tb_5.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from users"),con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string uname = reader.GetString(1);
                string upass = reader.GetString(2);
                if(username == uname && password == upass)
                {
                    MessageBox.Show("Userform are under maintainance");
                }
            }

            if (username == "a" && password == "a")
            {
                Adminform form = new Adminform();
                //form.TopLevel = false;
                //form.BringToFront();
                MessageBox.Show("Login Successfull");
                form.Show();
                //this.Close();
                this.Hide();
            } 
           
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            g2tb_4.Clear();
            g2tb_5.Clear();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
