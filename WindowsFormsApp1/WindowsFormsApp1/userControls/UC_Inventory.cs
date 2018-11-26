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
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            Inventory_NewProduct product = new Inventory_NewProduct();
            product.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateProduct change = new UpdateProduct();
            change.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update_Cost costnew = new Update_Cost();
            costnew.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Product newdelete = new Delete_Product();
            newdelete.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Report viwnew = new View_Report();
            viwnew.Show();
        }
    }
}
