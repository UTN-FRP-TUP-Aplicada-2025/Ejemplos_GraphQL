
using System.Net.Http.Json;

using HttpClient client = new HttpClient();

client.BaseAddress = new Uri("https://localhost:7244/graphql/");

var query = new
{
    query = @"
    query {
      personas {
        personas {
          dni
          nombre
        }
      }
    }"
};

var response = await client.PostAsJsonAsync("", query);   
response.EnsureSuccessStatusCode();

string responseBody = await response.Content.ReadAsStringAsync();

Console.WriteLine(responseBody);