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
        int panelHigh;
        int panelHigh1;
        bool isCollapsed1;
        bool isCollapsed;

        public UC_Inventory()
        {
            InitializeComponent();
            panelHigh = panelINup.Height;
            panelHigh1 = panelINrep.Height;
            isCollapsed1 = false;
            isCollapsed = false;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelINup.Height = panelINup.Height + 10;
                if (panelINup.Height >= panelHigh)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }

            }
            else
            {
                panelINup.Height = panelINup.Height - 10;
                if (panelINup.Height <= 46)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }

        }

        private void picInupleft_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (isCollapsed1)
            {
                panelINrep.Height = panelINrep.Height + 10;
                if (panelINrep.Height >= panelHigh1)
                {
                    timer2.Stop();
                    isCollapsed1 = false;
                    this.Refresh();

                }

            }
            else
            {
                panelINrep.Height = panelINrep.Height - 10;
                if (panelINrep.Height <= 46)
                {
                    timer2.Stop();
                    isCollapsed1 = true;
                    this.Refresh();
                }
            }

        }

        private void picInrepritht_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
