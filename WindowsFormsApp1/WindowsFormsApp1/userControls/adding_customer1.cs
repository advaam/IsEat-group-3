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
namespace WindowsFormsApp1.userControls
{
    public partial class adding_customer1 : Form
    {
        public adding_customer1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amora\source\repos\WindowsFormsApp1\WindowsFormsApp1\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO customers (id,first_name,last_name,phone) VALUES('" + IDCUSTOMERBOX.Text + "','" + FIRSTNAMECUSTOMERBOX.Text + "','" + LASTNAMECUSTOMERBOX + "','" + PHONENUMBERCUSTOMERBOX + "')", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("add");
            this.Dispose();
        }
    }
}
