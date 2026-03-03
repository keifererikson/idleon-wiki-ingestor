using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace IdleOn_Wiki.Models
{
    public class MonsterDto
    {
        [JsonPropertyName("MonsterName")]
        public string? Name { get; set; }

        [JsonPropertyName("Attack")]
        public string? Attack { get; set; }
        [JsonPropertyName("Health")]
        public string? Health { get; set; }
        [JsonPropertyName("Accuracy5")]
        public string? Accuracy5 { get; set; }
        [JsonPropertyName("Accuracy100")]
        public string? Accuracy100 { get; set; }
        [JsonPropertyName("EXP")]
        public string? Experience { get; set; }
        [JsonPropertyName("Defence0")]
        public string? DefenceForZero { get; set; }
        [JsonPropertyName("RespawnTime")]
        public string? RespawnTime { get; set; }

        [JsonPropertyName("Image")]
        public string? Image { get; set; }
        [JsonPropertyName("Speed")]
        public string? Speed { get; set; }
        [JsonPropertyName("World")]
        public string? World { get; set; }
        [JsonPropertyName("Areas")]
        public string? Areas { get; set; }
        [JsonPropertyName("SpecialAreas")]
        public string? SpecialAreas { get; set; }

    }
}
