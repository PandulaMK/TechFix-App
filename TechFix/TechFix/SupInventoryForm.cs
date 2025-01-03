using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TechFix.Model;

namespace TechFix
{
    public partial class SupInventoryForm : Form
    {
        public SupInventoryForm()
        {
            InitializeComponent();
        }

        private void LoadSupplierInventory1()
        {
            string url = "https://localhost:7136/api/Product";
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                var items = read.Result;
                dgv1.DataSource = null;
                dgv1.DataSource = (new JavaScriptSerializer()).Deserialize<List<Inventory>>(items);
            }
        }

        private void LoadSupplierInventory2()
        {
            string url = "https://localhost:7188/api/Product";
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                read.Wait();
                var items = read.Result;
                dgv2.DataSource = null;
                dgv2.DataSource = (new JavaScriptSerializer()).Deserialize<List<Inventory>>(items);
            }
        }

        private void SupInventoryForm_Load(object sender, EventArgs e)
        {
            LoadSupplierInventory1();
            LoadSupplierInventory2();
        }

        private void btnBacktoMnu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
