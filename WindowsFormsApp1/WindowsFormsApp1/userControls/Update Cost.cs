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
    public partial class Update_Cost : Form
    {
        public Update_Cost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amora\Documents\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("UPDATE stock SET cost='" + costupdatebox.Text + "' WHERE productNumber='" +productnumbercostupdatebox.Text + "'", con);
            sqa.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated");
            this.Hide();
        }

        private void Update_Cost_Load(object sender, EventArgs e)
        {

        }
    }
}
