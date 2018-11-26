using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.userControls
{
    public partial class update_customer1 : Form
    {
        public update_customer1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_customer_name1 updatecustomername = new update_customer_name1();
            updatecustomername.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_customer_phone1 updatecustomerphone = new update_customer_phone1();
            updatecustomerphone.Show();
        }
    }
}
