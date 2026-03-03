using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace IdleOn_Wiki.Models
{
    public class CargoResponse
    {
        [JsonPropertyName("cargoquery")]
        public List<CargoItemWrapper> Items { get; set; }
    }

    public class CargoItemWrapper
    {
        [JsonPropertyName("title")]
        public MonsterDto Data { get; set; }
    }

}
