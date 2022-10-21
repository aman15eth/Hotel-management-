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
using System.Data.SqlClient;

namespace hospital_mangement_system.add_user_control
{
    public partial class UserControl2 : UserControl
    {
        fun fn = new fun();
        string query;
        private ComboBox guna2TextBox1_roonnumber;

        public UserControl2()
        {
            InitializeComponent();
        }
        public void setcombobox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getforcombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void txt_roomtyoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TextBox1_roonnumber.Items.Clear();
            query = "select roomno from room where bed='" + txt_bed.Text + " 'and roomtype='" + txt_roomtyoe + " 'and booked='no' ";
            setcombobox(query, gunaroomnum);


        }

        private void txt_bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            gunaroomnum.SelectedIndex = -1;
            gunaroomnum.Items.Clear ();
        }

        private void gunaroomnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
