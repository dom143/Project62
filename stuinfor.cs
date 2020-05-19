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
    public partial class stuinfor : Form
    {


        public string m;
        
        public stuinfor()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formm1 = new Form1();
            formm1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stuinfor_Load(object sender, EventArgs e)
        {
            stuuse.Text = m;
            string sql = "SELECT * FROM student WHERE stu_card='" + stuuse.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                //textBox1.Text = da.GetValue(1).ToString();
                textBox2.Text = da.GetValue(2).ToString();
                textBox3.Text = da.GetValue(3).ToString();
                textBox4.Text = da.GetValue(4).ToString();
                textBox5.Text = da.GetValue(5).ToString();
                textBox6.Text = da.GetValue(6).ToString();
                textBox7.Text = da.GetValue(7).ToString();
                textBox8.Text = da.GetValue(8).ToString();
                textBox9.Text = da.GetValue(9).ToString();
            }
            con.Close();
        }
    }
}
