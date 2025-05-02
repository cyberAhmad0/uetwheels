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
using Guna.UI2.WinForms;

namespace uetwheels
{
    public partial class Sign_upincs : Form
    {
        
        static string conn = "Data Source=DESKTOP-3BTGOGP\\SQLEXPRESS;Initial Catalog=rental;Integrated Security=True;"
;
        SqlConnection con = new SqlConnection(conn);
        public Sign_upincs()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
           // guna2Panel2.Controls.Clear();
            string username = guna2TextBox2.Text;
            string password = guna2TextBox3.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from users"), con);
            SqlDataReader reader = cmd.ExecuteReader();
            MessageBox.Show("Login Successful!!!"); 
            if (reader.Read())
            {
                Adminform form = new Adminform();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Info");
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
        }
    }
}
