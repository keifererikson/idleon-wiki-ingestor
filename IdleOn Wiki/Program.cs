using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using IdleOn_Wiki.Models;

namespace IdleOn_Wiki
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("User-Agent", "PersonalIdleOnWikiTest/0.1 (https://github.com/keifererikson) .NET/10.0");

            HttpResponseMessage response = await client.GetAsync("https://idleon.wiki/api.php?action=parse&page=Green_Mushroom&format=json");

            string jsonResponse = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            WikiParseResponse myData = JsonSerializer.Deserialize<WikiParseResponse>(jsonResponse, options);

            Console.WriteLine(myData);
            Console.WriteLine(myData.Parse);

            Console.WriteLine($"Monster Name: {myData.Parse.Title}");
            Console.WriteLine($"Wiki Page ID: {myData.Parse.PageId}");
            Console.WriteLine($"Length of HTML: {myData.Parse.Text.HtmlContent.Length}");

        }
    }
}
