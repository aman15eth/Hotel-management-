using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_mangement_system
{
    public partial class hotel : Form
    {
        public hotel()
        {
            InitializeComponent();
            userControl11.Visible = false;
            userControl21.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void guna2Button1_customerreg_Click(object sender, EventArgs e)
        {
             userControl21.
            userControl21.Visible = true;
        }

        private void guna2Button2_addroom_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            userControl11.Visible = true;
        }

        private void guna2Button3_customerdetails_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_checkout_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_employee_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_2(object sender, EventArgs e)
        {

        }

        private void userControl13_Load(object sender, EventArgs e)
        {



        }

        private void hotel_Load(object sender, EventArgs e)
        {
            guna2Button2_addroom.Visible = true;
            guna2Button2_addroom.PerformClick();
        }
    }
}
