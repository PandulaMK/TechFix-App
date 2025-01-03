using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechFix.Model;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace TechFix
{
    public partial class PlaceOrderForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public PlaceOrderForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnReq_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int quantity = int.Parse(txtQuantity.Text);

            await GetSupplierQuotations(productName, quantity);
        }

        private async Task GetSupplierQuotations(string productName, int quantity)
        {
            try
            {
                string supplier1Url = $"https://localhost:7136/api/Supplier/quotation/{productName}/{quantity}";
                string supplier2Url = $"https://localhost:7188/api/Supplier/quotation/{productName}/{quantity}";

                var supplier1List = new List<Response>();
                var supplier2List = new List<Response>();

                // Fetch from Supplier 1
                var supplier1Response = await client.GetAsync(supplier1Url);
                if (supplier1Response.IsSuccessStatusCode)
                {
                    var supplier1Quotation = JsonConvert.DeserializeObject<Response>(await supplier1Response.Content.ReadAsStringAsync());
                    supplier1List.Add(supplier1Quotation);
                }

                // Fetch from Supplier 2
                var supplier2Response = await client.GetAsync(supplier2Url);
                if (supplier2Response.IsSuccessStatusCode)
                {
                    var supplier2Quotation = JsonConvert.DeserializeObject<Response>(await supplier2Response.Content.ReadAsStringAsync());
                    supplier2List.Add(supplier2Quotation);
                }

                dataGridViewSupplier1.DataSource = supplier1List;
                dataGridViewSupplier2.DataSource = supplier2List;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching quotations: {ex.Message}");
            }
        }

        private async Task PlaceOrder(string productName, int quantity, string supplier)
        {
            var orderRequest = new
            {
                ProductName = productName,
                Quantity = quantity
            };


            string orderUrl = supplier == "Supplier1" ? "https://localhost:7136/api/Supplier/order" : "https://localhost:7188/api/Supplier/order";


            var response = await client.PostAsJsonAsync(orderUrl, orderRequest);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Order placed successfully with {supplier}!");
                SaveOrderHistory(productName, quantity, supplier);
                RefreshOrderHistory();

            }
            else
            {
                MessageBox.Show($"Failed to place order with {supplier}.");
            }
        }

        private async void btnorder_Click(object sender, EventArgs e)
        {
            string productName;
            int quantity = int.Parse(txtQuantity.Text);

            // Check which DataGridView has a selected row
            if (dataGridViewSupplier1.SelectedRows.Count > 0)
            {
                // Order from Supplier 1
                var selectedRow = dataGridViewSupplier1.SelectedRows[0];
                productName = selectedRow.Cells["ProductName"].Value.ToString();

                await PlaceOrder(productName, quantity, "Supplier1");
            }
            else if (dataGridViewSupplier2.SelectedRows.Count > 0)
            {
                // Order from Supplier 2
                var selectedRow = dataGridViewSupplier2.SelectedRows[0];
                productName = selectedRow.Cells["ProductName"].Value.ToString();

                await PlaceOrder(productName, quantity, "Supplier2");
            }
            else
            {
                MessageBox.Show("Please select a quotation from either Supplier 1 or Supplier 2 DataGridView.");
                return;
            }

            // Refresh quotations after placing the order
            await GetSupplierQuotations(productName, quantity);

        }

        private void SaveOrderHistory(string productName, int quantity, string supplier)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TechFixdatabase"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO orders (ProductName, Quantity, Supplier, OrderDate) VALUES (@ProductName, @Quantity, @Supplier, @OrderDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Supplier", supplier);
                command.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void RefreshOrderHistory()
        {
            OrderHistoryForm orderHistoryForm = Application.OpenForms.OfType<OrderHistoryForm>().FirstOrDefault();
            if (orderHistoryForm != null)
            {
                orderHistoryForm.LoadOrderHistory();
            }
        }

        private void btnBacktoMnu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
