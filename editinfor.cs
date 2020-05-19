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
    public partial class editinfor : Form
    {
        public editinfor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                text1.Text = da.GetValue(2).ToString();
                text2.Text = da.GetValue(3).ToString();
                text3.Text = da.GetValue(4).ToString();
                text4.Text = da.GetValue(5).ToString();
                text5.Text = da.GetValue(6).ToString();
                text6.Text = da.GetValue(7).ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student";
            sql = "DELETE FROM student WHERE stu_id='" + textdel.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Done!!");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student";
            sql = "DELETE FROM student WHERE stu_id='" + textdel.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Done!!");
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //"UPDATE student * SET column1 = value1, column2 = value2, ... WHERE condition;
            string sql = "SELECT * FROM student";
            sql = "UPDATE student SET stu_id='" + text1.Text + "',stu_name='" + text2.Text + "',stu_surname='" + text3.Text + "',stu_nickname='" + text4.Text + "',stu_level='" + text5.Text + "',stu_study='" + text6.Text + "' WHERE stu_id='" + text_add.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Update Done!!");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student WHERE stu_id='" + text_add.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                text1.Text = da.GetValue(2).ToString();
                text2.Text = da.GetValue(3).ToString();
                text3.Text = da.GetValue(4).ToString();
                text4.Text = da.GetValue(5).ToString();
                text5.Text = da.GetValue(6).ToString();
                text6.Text = da.GetValue(7).ToString();
            }
            con.Close();
        }

        private void editinfor_Load(object sender, EventArgs e)
        {

        }
    }
}
