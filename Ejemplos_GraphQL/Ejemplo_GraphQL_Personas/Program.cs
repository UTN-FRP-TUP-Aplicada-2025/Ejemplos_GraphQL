using Ejemplo_GraphQL_Personas.Services;
using Ejemplo_WebAPI_Inventario.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<PersonasService>()
    .AddGraphQLSchema();

var app = builder.Build();

app.UseWebSockets();

//app.MapGraphQL(); //caso sencillo

app.UseRouting();
app.UseWebSockets();   // para los subscriptions
app.MapGraphQL("/graphql");

await app.RunAsync();