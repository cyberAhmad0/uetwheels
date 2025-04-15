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
            foreach(carinfo car in Datafile.carlist)
            {
                guna2ComboBox1.Items.Add(car.Brand);
            }
        }
    }
}
