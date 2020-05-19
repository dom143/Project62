using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            stuinfor stuin = new stuinfor();
            stuin.m = userstu.Text;
            //stuin.Show();
            string sql = "SELECT * FROM student WHERE stu_card='"+ userstu.Text + "'AND stu_id='"+passstu.Text+"'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                MessageBox.Show("LOGIN SUCCESS");
                this.Close();
                //stuinfor stuin = new stuinfor();
                //stuin.m = userstu.Text;
                stuin.Show();
            }

            
        }
    }
}
