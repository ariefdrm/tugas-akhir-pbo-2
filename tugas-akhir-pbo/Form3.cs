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
    public partial class Form3 : Form
    {
        public Form3()
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
                dgv1.DataSource = JsonData;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Load_Data();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            Fcreate3 fcreate3 = new Fcreate3();
            fcreate3.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FEdit3 fedit3 = new FEdit3();
            fedit3.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm3 fdelete = new DeleteForm3();
            fdelete.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
