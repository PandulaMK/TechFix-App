using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrderForm placeOrderForm = new PlaceOrderForm();
            placeOrderForm.Show(); 
            this.Hide();
        }

        private void btnSupInventory_Click(object sender, EventArgs e)
        {
            SupInventoryForm supInventoryForm = new SupInventoryForm();
            supInventoryForm.Show();
            this.Hide();

        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
            orderHistoryForm.Show();
            this.Hide();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
