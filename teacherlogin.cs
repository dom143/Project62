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
    public partial class teacherlogin : Form
    {
        public teacherlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passtea_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teamenu teamen = new teamenu();
            teamen.te = usertea.Text;
            string sql = "SELECT * FROM teacher WHERE tea_user='" + usertea.Text + "'AND tea_pass='" + passtea.Text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project62");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show("LOGIN SUCCESS");
                this.Close();
                teamen.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            registertea regis = new registertea();
            regis.Show();
        }
    }
}
