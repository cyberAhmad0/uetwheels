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
using System.Xml.Linq;

namespace uetwheels
{
    public partial class customer : Form
    {
        internal int cust_id;
        internal string Address;
        static string conn = "Data Source=DESKTOP-3BTGOGP\\SQLEXPRESS;Initial Catalog=rental;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conn);

        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
       
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO customer (Name, Address, Phone) VALUES (@Name, @Address, @Phone)", con);
            cmd.Parameters.AddWithValue("@Name", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@Address", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", guna2TextBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer added successfully!");

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE customer SET Name = @Name, Address = @Address, Phone = @Phone WHERE cust_id = @CustId", con);
            cmd.Parameters.AddWithValue("@Name", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@Address", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@Phone", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@CustId", cust_id); // This should be set earlier (like from DataGridView selection)
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer updated successfully!");

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE cust_id = @CustId", con);
            cmd.Parameters.AddWithValue("@CustId", cust_id); // again, taken from selected row
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer deleted successfully!");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Adminform adminForm = new Adminform();
            adminForm.Show();
            this.Hide();
        }
    }
}
