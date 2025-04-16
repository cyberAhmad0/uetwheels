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
using uetwheels.models;

namespace uetwheels
{
    public partial class rental : Form
    {
        public rental()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rental_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int car_reg = 0;
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string name = guna2ComboBox2.Text;
            string query = "Select car_reg from carinfo where Brand = @name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name",name);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                car_reg = Convert.ToInt32(reader["car_reg"]);
            }
            else
            {
                MessageBox.Show("Car not found!");
            }
            con.Close();    
            string cust_name = guna2ComboBox1.Text;
            DateTime date1 = guna2DateTimePicker1.Value;
            string rntdate = date1.ToString("yyyy-MM-dd");
            DateTime date2 = guna2DateTimePicker2.Value;
            string rtn_date = date2.ToString("yyyy-MM-dd");
            int fee = Convert.ToInt32(guna2TextBox5.Text);
            con.Open();
            SqlCommand cmd1 = new SqlCommand(("INSERT INTO rental (Car_reg, cust_name,rent_date,return_date,rentfee) VALUES (@car_reg, @cust_name, @rentdate, @returndate, @rentfee)"), con);
            cmd1.Parameters.AddWithValue("@car_reg", car_reg);
            cmd1.Parameters.AddWithValue("@cust_name", cust_name);
            cmd1.Parameters.AddWithValue("@rentdate",rntdate);
            cmd1.Parameters.AddWithValue("@returndate",rtn_date);
            cmd1.Parameters.AddWithValue("@rentfee",fee);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rented Successfully");


        }
    }
}
