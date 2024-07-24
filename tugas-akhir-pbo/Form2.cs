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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateForm2 createForm2 = new CreateForm2();
            createForm2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditForm2 editForm2 = new EditForm2();
            editForm2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm2 deleteForm2 = new DeleteForm2();
            deleteForm2.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
                var response = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<Products>>(response);
                dgv1.DataSource = JsonData;
            }
        }
    }
}
