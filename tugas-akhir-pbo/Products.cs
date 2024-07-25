using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tugas_akhir_pbo
{
    internal class Products
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("price")]
        public string price { get; set; }

        [JsonPropertyName("stocks")]
        public int stocks { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime createdAt { get; set; }

    }
}
