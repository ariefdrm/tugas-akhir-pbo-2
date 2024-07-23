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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            // URL endpoint API
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";

            // membuat objek personal data
            var dataPersonal = new personal_data()
            {
                name = txtName.Text,
                address = txtAddress.Text,
                job = txtJob.Text,
                email = txtEmail.Text,
                createdAt = DateTime.Now,
            };

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, dataPersonal);

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

        private void LoadData()
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";
            List<personal_data> personal_Datas = [];

            using (HttpClient client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                var ResponBody = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<personal_data>>(ResponBody);
                dataGridView1.DataSource = JsonData;
            }
        }
    }
}
