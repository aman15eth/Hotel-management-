using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_mangement_system.add_user_control
{
    public partial class UserControl1 : UserControl 
    {
        fun f=new fun();
        string query;
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void guna2Button1_addroom_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1_roonnumber.Text != "" && guna2ComboBox1_roomtype.Text != "" && guna2ComboBox2_bed.Text != "" && guna2TextBox4_price.Text != "")
            {
                string roomnum = guna2TextBox1_roonnumber.Text;
                string roomtype = guna2ComboBox1_roomtype.Text;
                string bed=guna2ComboBox2_bed.Text;
                int price = int.Parse(guna2TextBox4_price.Text);
                query = "insert into room(roomno,roomtype,bed,price) values('" + roomnum + "','" + roomtype + "','" + bed + "','" + price + "')";
                f.setData(query,"Room Added sussesfully");
                guna2DataGridView1.DataSource = f;
            }
            else
            {
                MessageBox.Show("please enter full information","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            UserControl1_Load(this, null);
            clear();
        }


        private void bed_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            query = "Select * from room";
        DataSet DataSet = new DataSet();
            DataSet = f.getdata(query);

            guna2DataGridView1.DataSource= DataSet.Tables[0];    
            



        }
        private void clear() {

            guna2TextBox1_roonnumber.Clear();
            guna2ComboBox1_roomtype.SelectedIndex = -1;
            guna2ComboBox2_bed.SelectedIndex = -1;
            guna2TextBox4_price.Clear();


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_bed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void UserControl1_Enter(object sender, EventArgs e)
        {
           UserControl1_Load(this, EventArgs.Empty); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
        }
    }
}
