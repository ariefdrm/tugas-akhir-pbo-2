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
    public partial class DeleteForm3 : Form
    {
        public DeleteForm3()
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
        private void DeleteForm3_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var url = "https://retoolapi.dev/bqPQIh/Contact/" + id;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Delete request
                    var requestDelete = await client.DeleteAsync(url);

                    if (requestDelete.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Object with ID {id} deleted successfully");
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete with ID {id}. status code : {requestDelete.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
