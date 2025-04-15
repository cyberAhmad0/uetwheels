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
    public partial class userscs : Form
    {
        static string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conn);
        public userscs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userscs_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string name = g2tb_1.Text;
            string pass = g2tb_2.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand(("insert into users values(@uname,@upass)"), con);
            cmd.Parameters.AddWithValue("@uname",name);
            cmd.Parameters.AddWithValue("@upass",pass);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User added Sucessfully");
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            g2tb_1.Clear();
            g2tb_2.Clear();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string email = g2tb_1.Text;
            string pass = g2tb_2.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand(("Update users Set pass = @pass where email = @email"),con);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully");
            
        }
    }
}
