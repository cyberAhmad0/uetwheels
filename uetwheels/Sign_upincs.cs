using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uetwheels
{
    public partial class Sign_upincs : Form
    {
        public Sign_upincs()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel2.Controls.Clear();
            string username = guna2TextBox4.Text;
            string password = guna2TextBox5.Text;
            if (username == "abcd@gmail.com" && password == "123aa")
            {
                Adminform form = new Adminform();
                //form.TopLevel = false;
                //form.BringToFront();
                MessageBox.Show("Login Successfull");
                form.Show();
                this.Close();
                this.Hide();
            } 
            else 
            {
                MessageBox.Show("Invalid info");
                Sign_upincs sign = new Sign_upincs();
                sign.Show();
                this.Hide();

            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
