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
    public partial class FEdit3 : Form
    {
        public FEdit3()
        {
            InitializeComponent();
        }

        private async void Load_Data()
        {
            var url = "https://retoolapi.dev/bqPQIh/Contact";
            List<Contact> contacts = [];

            using (HttpClient client = new HttpClient())
            {
                var request = await client.GetAsync(url);
                var response = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<Contact>>(response);
                dataGridView1.DataSource = JsonData;
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                id = int.Parse(txtId.Text),
                name = txtName.Text,
                job = txtJob.Text,
                company = txtCompany.Text,
                address = txtAddress.Text,
            };

            string url = $"https://retoolapi.dev/bqPQIh/Contact/{contact.id}";

            string json = JsonConvert.SerializeObject(contact);

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
                    Load_Data();
                }
                else
                {
                    MessageBox.Show($"Failed to update with id: {contact.id}. Status Code: {response.StatusCode}");
                }
            }
        }

        private void FEdit3_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
