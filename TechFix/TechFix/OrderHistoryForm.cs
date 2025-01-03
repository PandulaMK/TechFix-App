using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechFix.Model;

namespace TechFix
{
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        public void LoadOrderHistory()
        {
            using (var connection = new SqlConnection("Data Source=PANDULA_ASUS;Initial Catalog=TF;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM orders", connection);
                var reader = command.ExecuteReader();
                var orders = new List<OrdersHistory>();

                while (reader.Read())
                {
                    var order = new OrdersHistory
                    {
                        Id = Convert.ToInt32(reader["Id"]), // Use Convert to handle potential nulls
                        ProductName = reader["ProductName"] != DBNull.Value ? reader["ProductName"].ToString() : string.Empty,
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        OrderDate = reader["OrderDate"] != DBNull.Value ? Convert.ToDateTime(reader["OrderDate"]) : DateTime.MinValue,
                        Supplier = reader["Supplier"] != DBNull.Value ? reader["Supplier"].ToString() : string.Empty,
                    };
                    orders.Add(order);
                }

                dgvorders.DataSource = null;
                dgvorders.DataSource = orders;
            }
        }
      

        private void dgvorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void btnBacktoMnu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
