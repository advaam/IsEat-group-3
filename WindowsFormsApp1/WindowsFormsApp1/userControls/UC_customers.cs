using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.userControls
{
    public partial class UC_customers : UserControl
    {
        
        public UC_customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adding_customer1 addcustomer = new adding_customer1();
            addcustomer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer_view1 viewcustomer = new customer_view1();
            viewcustomer.Show();
        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_customer1 customerupdate = new update_customer1();
            customerupdate.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
