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
        int PanelHightLeft, PanelHightRight;
        bool isCollapsed1, isCollapsed2;

        public UC_customers()
        {
            InitializeComponent();
            PanelHightLeft = panelCCup.Height;
            PanelHightRight = panelCCre.Height;
            isCollapsed1 = false;
            isCollapsed2 = false;
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

        private void UC_customers_Load(object sender, EventArgs e)
        {

        }

        private void timereport_Tick(object sender, EventArgs e)
        {

            if (isCollapsed2)
            {
                panelCCre.Height = panelCCre.Height + 10;
                if (panelCCre.Height >= PanelHightRight)
                {
                    
                    timereport.Stop();
                    isCollapsed2 = false;
                    this.Refresh();

                }
            }
            else
            {
                panelCCre.Height = panelCCre.Height - 10;
                if (panelCCre.Height <= 97)
                {
                    timereport.Stop();
                    isCollapsed2 = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timereport.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timerCostomer.Start();
        }

        private void timerCostomer_Tick(object sender, EventArgs e)
        {

            if (isCollapsed1)
            {
                panelCCup.Height = panelCCup.Height + 10;
                if (panelCCup.Height >= PanelHightLeft)
                {
                    timerCostomer.Stop();
                    isCollapsed1 = false;
                    this.Refresh();

                }
            }
            else
            {
                panelCCup.Height = panelCCup.Height - 10;
                if (panelCCup.Height <= 97)
                {
                    timerCostomer.Stop();
                    isCollapsed1 = true;
                    this.Refresh();
                }
            }
        }

    }
}

