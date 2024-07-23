using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tugas_akhir_pbo
{
    internal class personal_data
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("address")]
        public string address { get; set; }

        [JsonPropertyName("job")]
        public string job { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime createdAt { get; set; }
    }
}
