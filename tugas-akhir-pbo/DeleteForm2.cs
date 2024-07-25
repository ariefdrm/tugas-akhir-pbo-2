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
    public partial class DeleteForm2 : Form
    {
        public DeleteForm2()
        {
            InitializeComponent();
        }



        private void DeleteForm2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var products = new Products()
            {
                id = txtId.Text,
            };

            var url = $"https://669f34ddb132e2c136fd0224.mockapi.io/products/{products.id}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Delete request
                    var requestDelete = await client.DeleteAsync(url);

                    if (requestDelete.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Object with ID {products.id} deleted successfully");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete with ID {products.id}. status code : {requestDelete.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                dataGridView1.DataSource = JsonData;
            }
        }
    }
}
