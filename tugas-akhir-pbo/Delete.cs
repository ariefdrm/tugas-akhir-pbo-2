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
using Newtonsoft.Json.Linq;

namespace tugas_akhir_pbo
{
    public partial class btb : Form
    {
        public btb()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            getData();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data/" + id;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Delete request
                    var requestDelete = await client.DeleteAsync(url);

                    if (requestDelete.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Object with ID {id} deleted successfully");
                        getData();
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

        private async void getData()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
