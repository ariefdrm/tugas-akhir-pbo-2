using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace tugas_akhir_pbo
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            // Object JSon yang akan diperbarui
            personal_data update = new personal_data()
            {
                id = txtId.Text,
                name = txtName.Text,
                address = txtAddress.Text,
                email = txtEmail.Text,
                job = txtJob.Text,
                createdAt = DateTime.Now,
            };

            // URL API Endpoint
            var url = $"https://669f34ddb132e2c136fd0224.mockapi.io/personal-data/{update.id}";

            // Konversi object ke JSon string
            string json = JsonConvert.SerializeObject(update);

            // Httpclient
            using (HttpClient client = new HttpClient())
            {
                // HttpContent
                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Http Put request
                var response = await client.PutAsync(url, content);

                // cek apa request berhasil
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Update Succeed");
                    loadData();
                }
                else
                {
                    MessageBox.Show($"Failed to update with id: {txtId}. Status Code: {response.StatusCode}");
                }
            }

        }

        private async void update_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private async void loadData()
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";
            List<personal_data> personal_Datas = [];

            // Get request JSon
            using (HttpClient client = new HttpClient())
            {
                var request = await client.GetAsync(url);
                var ResponBody = request.Content.ReadAsStringAsync().Result;

                // Deserialize Array JSon
                var JsonData = JsonConvert.DeserializeObject<List<personal_data>>(ResponBody);
                dataGridView1.DataSource = JsonData;
            }
        }
    }
}
