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
    public partial class teamenu : Form
    {
        public string te;
        public teamenu()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formm1 = new Form1();
            formm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            addscore addpoint = new addscore();
            addpoint.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            registertea regis = new registertea();
            regis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            editinfor editin = new editinfor();
            editin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            showscore showsco = new showscore();
            showsco.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            addstuinfor addstu = new addstuinfor();
            addstu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void teamenu_Load(object sender, EventArgs e)
        {
            textBox5.Text = te;
            string sql = "SELECT * FROM teacher WHERE tea_user='" + textBox5.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox1.Text = da.GetValue(3).ToString();
                textBox2.Text = da.GetValue(4).ToString();
                textBox3.Text = da.GetValue(6).ToString();
                textBox4.Text = da.GetValue(5).ToString();
            }
            con.Close();
        }
    }
}
