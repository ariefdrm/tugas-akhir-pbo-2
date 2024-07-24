using Newtonsoft.Json;

namespace tugas_akhir_pbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btb delete = new btb();
            delete.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update update = new update();
            update.ShowDialog();
        }
        public async void GetData()
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";
            List<personal_data> personal_Datas = [];

            using (HttpClient client = new HttpClient())
            {
                var request = await client.GetAsync(url);
                var ResponBody = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<personal_data>>(ResponBody);
                dataGridView1.DataSource = JsonData;
            }
        }

    }
}
