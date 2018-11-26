using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amora\Documents\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter aqd = new SqlDataAdapter("select * from login where password ='" + textBox1.Text + "'", con);
            DataTable dt=new DataTable();
            aqd.Fill(dt);
            if(dt.Rows.Count==1)
            {
                main main = new main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong password");
            }
            
        }
    }
}
