using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace tugas_akhir_pbo
{
    public partial class EditForm2 : Form
    {
        public EditForm2()
        {
            InitializeComponent();
        }

        private void EditForm2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/products";
            List<Products> products = [];

            using (HttpClient client = new HttpClient())
            {
                var request = await client.GetAsync(url);
                var Response = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<Products>>(Response);
                dataGridView1.DataSource = JsonData;
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            var products = new Products()
            {
                id = txtId.Text,
                name = txtName.Text,
                price = txtPrice.Text,
                stocks = int.Parse(txtStocks.Text),
                description = txtDescription.Text,
                createdAt = DateTime.Now,
            };

            var url = $"https://669f34ddb132e2c136fd0224.mockapi.io/products/{products.id}";

            string json = JsonConvert.SerializeObject(products);

            // Httpclient
            using (HttpClient client = new HttpClient())
            {
                // HttpContent
                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                // Http Put request
                var response = await client.PutAsync(url, content);

                // cek apa request berhasil
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update Succeed");
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Failed to update with id: {txtId}. Status Code: {response.StatusCode}");
                }
            }
        }
    }
}
