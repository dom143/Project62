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
    public partial class addscore : Form
    {
        public addscore()
        {
            InitializeComponent();
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student WHERE stu_id='" + text_add.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox1.Text = da.GetValue(2).ToString();
                textBox2.Text = da.GetValue(3).ToString() + "  " + da.GetValue(4).ToString();
                textBox3.Text = da.GetValue(6).ToString();
                textBox4.Text = da.GetValue(7).ToString();
                addpoint.Text = da.GetValue(8).ToString();
            }

            con.Close();
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student";
            sql = "UPDATE student SET stu_point='" + addpoint.Text + "' WHERE stu_id='" + text_add.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Update Done!!");
            con.Close();
        }
    }
}
