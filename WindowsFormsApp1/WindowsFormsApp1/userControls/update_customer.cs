using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.userControls.forms.customers_forms
{
    public partial class update_customer : Form
    {
        public update_customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            update_customer_phone1 newphone = new update_customer_phone1();
            newphone.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
