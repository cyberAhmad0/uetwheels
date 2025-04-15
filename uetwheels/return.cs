using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                guna2ComboBox1.Items.Add(car.Brand);
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

       public void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
