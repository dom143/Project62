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
    public partial class showscore : Form
    {
        public showscore()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;
            con.Close();
           // MessageBox.Show("สำเร็จ!!!!");
        }

        private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ดึงข้อมูลมาแสดงที่ตาราง
            string sql = "SELECT * FROM student WHERE stu_id='"+ text_addd.Text +"'";

            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
