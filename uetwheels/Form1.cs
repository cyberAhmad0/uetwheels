using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace uetwheels
{
    public partial class Form1 : Form
    {
        static string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=project;Integrated Security=True;Trust Server Certificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ProgressBar1.Value <  100)
            {
                ProgressBar1.Value += 5;
                label2.Text = ProgressBar1.Value.ToString() + "%";
            }

            else
            {
                timer1.Stop();
                Sign_upincs sign = new Sign_upincs();          
                sign.Show();
                this.Hide();
                
               
            }
        }

        private void ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
