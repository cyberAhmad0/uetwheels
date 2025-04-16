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
    public partial class cars : Form
    {

        static string conn = "Data Source=DESKTOP-3BTGOGP\\SQLEXPRESS;Initial Catalog=rental;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conn);
        public cars()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cars_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string regno = guna2TextBox1.Text;
            string brand = guna2TextBox2.Text;
            int model = int.Parse(guna2TextBox3.Text);
            int price = int.Parse(guna2TextBox4.Text);
            string available = guna2ComboBox1.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into cars (regno, brand, model, price, available) values (@regno, @brand, @model, @price, @available)", con);
            cmd.Parameters.AddWithValue("@RegNo", regno);
            cmd.Parameters.AddWithValue("@Brand", brand);
            cmd.Parameters.AddWithValue("@Model", model);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Available", available);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Car added successfully!");
        }
    

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string regno = guna2TextBox1.Text;
            string brand = guna2TextBox2.Text;     
            int model = int.Parse(guna2TextBox3.Text);    
            int newPrice = int.Parse(guna2TextBox4.Text); 
            string newAvailability = guna2ComboBox1.Text;  

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE cars SET brand = @Brand, model = @Model, price = @Price, available = @Available WHERE regno = @RegNo", con);

            cmd.Parameters.AddWithValue("@Brand", brand);
            cmd.Parameters.AddWithValue("@Model", model);
            cmd.Parameters.AddWithValue("@Price", newPrice);
            cmd.Parameters.AddWithValue("@Available", newAvailability);
            cmd.Parameters.AddWithValue("@RegNo", regno);
            cmd.ExecuteNonQuery();  
            con.Close();

            MessageBox.Show("Car price updated successfully");

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            string regno = guna2TextBox1.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM cars WHERE regno = @RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", regno);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Car deleted successfully!");

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            Adminform adminForm = new Adminform(); 
            adminForm.Show();  
            this.Hide();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void g2b_add_Click(object sender, EventArgs e)
        {

        }
    }
}
