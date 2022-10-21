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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

            if (username.Text == "admin" && password.Text == "admin")
            {
                incorrect.Visible = false;
                hotel h = new hotel();
                h.Show();
                Visible = false;
            }
            else
            {
                incorrect.Visible = true;
                password.Clear();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
     
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
