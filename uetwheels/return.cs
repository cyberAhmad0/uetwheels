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
using uetwheels.models;


namespace uetwheels
{
    public partial class rename : Form
    {
        public rename()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            foreach (carinfo car in Datafile.carlist)
            {
                g2cb_return.Items.Add(car.Brand);
            }
            foreach (customerinfo cobj in Datafile.customerlist)
            {
                g2cb_cust_return.Items.Add(cobj.Name);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

     

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string carname = g2cb_return.Text.ToString();
            string cust_name = g2cb_cust_return.Text.ToString();
            DateTime dateTime = g2dtp1.Value;
            string date = dateTime.ToString("yyyy-MM-dd");
            int delay = Convert.ToInt32(g2tb_delay.Text);
            int fine = Convert.ToInt32(g2tb_fine.Text);
            int amount = Convert.ToInt32(g2tb_amount.Text);
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Insert into carreturn(car_name,cust_name,carreturn,Delay,Fine,Total_amount) values(@car_name,@cust_name,@carreturn,@Delay,@Fine,@TotalAmount)"), con);
            cmd.Parameters.AddWithValue("@car_name",carname);
            cmd.Parameters.AddWithValue("@cust_name",cust_name);
            cmd.Parameters.AddWithValue("@carreturn", date);
            cmd.Parameters.AddWithValue("@Delay", delay);
            cmd.Parameters.AddWithValue("@Fine", fine);
            cmd.Parameters.AddWithValue("@TotalAmount",amount);
            cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Car Returned Successfully");
        }

        private void g2dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void g2tb_fine_TextChanged(object sender, EventArgs e)
        {
            int car_reg = 0;
            string carname = g2cb_return.Text;
            string conne = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con1 = new SqlConnection(conne);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand(("Select Car_reg from carinfo where Brand = @car"), con1);
            cmd1.Parameters.AddWithValue("@car", carname);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                car_reg = Convert.ToInt32(reader1["car_reg"]);
            }
            else
            {
                MessageBox.Show("Car not found!");
            }
            //MessageBox.Show(car_reg.ToString());
            int fee = 0;
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select rentfee from rental where Car_reg = @car"), con);
            cmd.Parameters.AddWithValue("@car", car_reg);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fee = Convert.ToInt32(reader["rentfee"]);
            }

        private void g2tb_amount_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
