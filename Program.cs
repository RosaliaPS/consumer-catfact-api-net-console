using System.Text.Json;
using ConsumerCatFactApi;

string url = "https://catfact.ninja/fact";

using HttpClient client = new HttpClient();

string json = await client.GetStringAsync(url);

Gatinho? gatinho = JsonSerializer.Deserialize<Gatinho>(json);

Console.WriteLine("Fato sobre Gatos:");
Console.WriteLine(gatinho?.Fact);
