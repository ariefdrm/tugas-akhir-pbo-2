using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace tugas_akhir_pbo
{
    public partial class CreateForm2 : Form
    {
        public CreateForm2()
        {
            InitializeComponent();
        }

        private void CreateForm2_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            var products = new Products()
            {
                name = txtName.Text,
                price = txtPrice.Text,
                stocks = int.Parse(txtStocks.Text),
                description = txtDescription.Text,
                createdAt = DateTime.Now,
            };

            // URL endpoint API
            var url = $"https://669f34ddb132e2c136fd0224.mockapi.io/products";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, products);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data berhasil ditambahkan.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Gagal menambahkan data. Status code : {response.StatusCode}");
                }
            }
        }

        private async void LoadData()
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/products";
            List<Products> products = [];

            using (HttpClient client = new HttpClient())
            {
                var request = await client.GetAsync(url);
                var ResponeBody = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<Products>>(ResponeBody);
                Dgv1.DataSource = JsonData;
            }
        }
    }
}
