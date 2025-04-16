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
         
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            userindb();
            customerindb();
            carsindb();
        }

        private void userindb()
        {
            //int users;
            int users = 0;
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from users"), con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //users = Convert.ToInt32(reader.GetString(1));  no read of writing it bcz reader read each row 
                users++;
            }
            con.Close();
            label5.Text = users.ToString();
        }
        private void customerindb()
        {
            int customers = 0;
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from customer"), con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                customers++;
            }
            con.Close();
            label3.Text = customers.ToString();
        }
        private void carsindb()
        {
            int cars = 0;
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from carinfo"), con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cars++;
            }
            con.Close();
            label2.Text = cars.ToString();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
