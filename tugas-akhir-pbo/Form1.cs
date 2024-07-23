using Newtonsoft.Json;

namespace tugas_akhir_pbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";
            List<personal_data> personal_Datas = [];

            using (HttpClient client = new HttpClient())
            {
                var ResponString = client.GetAsync(url).GetAwaiter().GetResult();
                var ResponBody = ResponString.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<personal_data>>(ResponBody);
                dataGridView1.DataSource = JsonData;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btb delete = new btb();
            delete.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";
            List<personal_data> personal_Datas = [];

            using (HttpClient client = new HttpClient())
            {
                var ResponString = client.GetAsync(url).GetAwaiter().GetResult();
                var ResponBody = ResponString.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<personal_data>>(ResponBody);
                dataGridView1.DataSource = JsonData;

            }
        }
    }
}
