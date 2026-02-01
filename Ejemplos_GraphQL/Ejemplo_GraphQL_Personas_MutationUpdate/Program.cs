
using System.Net.Http.Json;

using HttpClient client = new HttpClient();

client.BaseAddress = new Uri("https://localhost:7244/graphql/");

int dni = 31029300;
string nombre = "Julio";

var query = new
{
    query = $@"
    mutation {{
      personas {{
        crearPersona(input: {{ dni: {dni}, nombre: ""{nombre}"" }}) {{
          dni
          nombre
        }}
      }}
    }}"
};

var response = await client.PostAsJsonAsync("", query);
response.EnsureSuccessStatusCode();

string responseBody = await response.Content.ReadAsStringAsync();

Console.WriteLine(responseBody);