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
    public partial class Fcreate3 : Form
    {
        public Fcreate3()
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
                Dgv1.DataSource = JsonData;
            }
        }
        private void Fcreate3_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                name = TxtName.Text,
                job = TxtJob.Text,
                company = TxtCompany.Text,
                address = TxtAddress.Text,
            };

            var url = "https://retoolapi.dev/bqPQIh/Contact";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, contact);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data berhasil ditambahkan.");
                    Load_Data();
                }
                else
                {
                    MessageBox.Show($"Gagal menambahkan data. Status code : {response.StatusCode}");
                }
            }
        }
    }
}
