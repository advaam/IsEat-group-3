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
    public partial class Inventory_NewProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amora\Documents\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Inventory_NewProduct()
        {
            InitializeComponent();
        }

        private void Inventory_Update_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("INSERT INTO stock(productNumber,product,quantity,cost) VALUES('" + ProductNumberBox.Text + "','" + productNameBox.Text + "','" + quantityBox.Text + "','" + costBox.Text + "')", con);
            sqa.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("add");
            this.Hide();
        }
    }
}
