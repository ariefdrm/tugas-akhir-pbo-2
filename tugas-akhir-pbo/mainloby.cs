﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace tugas_akhir_pbo
{
    public partial class mainloby : Form
    {
        public mainloby()
        {
            InitializeComponent();
        }

        private async void LoadForm1()
        {
            string url = "https://669f34ddb132e2c136fd0224.mockapi.io/personal-data";
            List<personal_data> personal_Datas = [];

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage request = await client.GetAsync(url);
                var ResponBody = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<personal_data>>(ResponBody);
                dataGridView1.DataSource = JsonData;
            }
        }

        private async void LoadForm2()
        {
            string url = "https://669f34ddb132e2c136fd0224.mockapi.io/products";
            List<Products> products = [];

            using (HttpClient client = new HttpClient())
            {
                var response = (await client.GetAsync(url)).Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<Products>>(response);
                dataGridView2.DataSource = JsonData;
            }
        }

        private async void LoadForm3()
        {
            string url = "https://retoolapi.dev/bqPQIh/Contact";
            List<Contact> contacts = [];

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage request = await client.GetAsync(url);
                string response = request.Content.ReadAsStringAsync().Result;

                var JsonData = JsonConvert.DeserializeObject<List<Contact>>(response);
                dataGridView3.DataSource = JsonData;
            }
        }

        private void mainloby_Load(object sender, EventArgs e)
        {
            tmr_tick(sender, e);
        }

        private void tmr_tick(object sender, EventArgs e)
        {
            tmr1.Start();
            LoadForm1();
            LoadForm2();
            LoadForm3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
