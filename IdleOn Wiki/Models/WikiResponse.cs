using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace IdleOn_Wiki.Models
{
    public class WikiResponse
    {
        [JsonPropertyName("parse")]
        public ParseData Parse { get; set; }
    }

    public class ParseData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        public int PageId { get; set; }
        public TextData Text { get; set; }
    }

    public class TextData
    {
        [JsonPropertyName("*")]
        public string HtmlContent { get; set; }
    }

}
