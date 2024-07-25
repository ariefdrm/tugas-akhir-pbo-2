using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tugas_akhir_pbo
{
    internal class Contact
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("job")]
        public string job { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("address")]
        public string address { get; set; }

        [JsonPropertyName("company")]
        public string company { get; set; }
    }
}
