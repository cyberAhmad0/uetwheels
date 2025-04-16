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
    public partial class dashboard : Form
    {
        static string conn = "Data Source=DESKTOP-3BTGOGP\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conn);
        public dashboard()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select username from users");
            //cmd.
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
