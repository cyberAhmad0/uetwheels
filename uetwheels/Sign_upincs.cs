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
            //guna2Panel2.Controls.Clear();
            Adminform form = new Adminform();
            //form.TopLevel = false;
            //form.BringToFront();
            form.Show();
            this.Hide();
        }
    }
}
