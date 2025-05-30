﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

     
    

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string regNo = guna2TextBox1.Text; 
            string brand = guna2TextBox2.Text;
            string model = guna2TextBox3.Text;
            string price = guna2TextBox4.Text;
            string available = guna2ComboBox1.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE carinfo SET Brand = @Brand, Model = @Model, Price = @Price, Available = @Available WHERE car_reg = @car_reg", con);
            cmd.Parameters.AddWithValue("@car_reg", regNo);
            cmd.Parameters.AddWithValue("@Brand", brand);
            cmd.Parameters.AddWithValue("@Model", model);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Available", available);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Car updated successfully!");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            string regNo = guna2TextBox1.Text; 

            DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM carinfo WHERE car_reg = @car_reg", con);
                cmd.Parameters.AddWithValue("@car_reg", regNo);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Car deleted successfully!");
            }
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
            string regNo = guna2TextBox1.Text;
            string brand = guna2TextBox2.Text;
                string model = guna2TextBox3.Text;
                string price = guna2TextBox4.Text;
                string available = guna2ComboBox1.Text;
                con.Open();
            SqlCommand cmd = new SqlCommand("insert into carinfo (car_reg, Brand, Model, Available, Price) values (@car_reg, @Brand, @Model, @Available, @Price)", con);
            cmd.Parameters.AddWithValue("@car_reg", regNo);
            cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Available", available);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Car added successfully!");

        }
    }
}
