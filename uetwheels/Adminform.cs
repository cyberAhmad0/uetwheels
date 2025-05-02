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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
            Datafile.loadcars();
            Datafile.addcustomer();
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // guna2Panel3.Controls.Clear();
            //cars form = new cars();
            //form.TopLevel = false;
            //guna2Panel3.Controls.Add(form);
            //form.BringToFront();
            //form.Show();

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            //guna2Panel3.Controls.Clear();
            //rename form = new rename();
            //form.TopLevel = false;
            //guna2Panel3.Controls.Add(form);
            //form.BringToFront();
            //form.Show();

        }

        //private void guna2Button3_Click(object sender, EventArgs e)
        //{
        //    guna2Panel3.Controls.Clear();
        //    rental form = new rental();
        //    form.TopLevel = false;
        //    guna2Panel3.Controls.Add(form);
        //    form.BringToFront();
        //    form.Show();
        //}

        //private void guna2Button5_Click(object sender, EventArgs e)
        //{
        //    guna2Panel3.Controls.Clear();
        //    userscs userform = new userscs();
        //    userform.TopLevel = false;
        //    guna2Panel3.Controls.Add(userform);
        //    userform.BringToFront();
        //    userform.Show();
        //}

        //private void guna2Button6_Click(object sender, EventArgs e)
        //{
           
        //    guna2Panel3.Controls.Clear();
        //    dashboard dasform = new dashboard();
        //    dasform.TopLevel = false;
        //    guna2Panel3.Controls.Add(dasform);
        //    dasform.BringToFront();
        //    dasform.Show();
        //}

        //private void guna2Button7_Click(object sender, EventArgs e)
        //{
        //    guna2Panel3.Controls.Clear();
        //    Sign_upincs form = new Sign_upincs();
        //    form.Show();
        //    this.Hide();
        //}

       

        private void Adminform_Load(object sender, EventArgs e)
        {
            
        }

        private void Adminform_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
           
        }

       

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rental rent= new rental();
            rent.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rename r = new rename();
            r.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           cars c = new cars();
            c.Show();
            this.Hide();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
