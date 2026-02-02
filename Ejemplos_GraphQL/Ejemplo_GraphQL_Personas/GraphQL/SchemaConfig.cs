using Ejemplo_GraphQL_Personas.GraphQL;
using Ejemplo_GraphQL_Personas.GraphQL.Mutations;
using Ejemplo_GraphQL_Personas.GraphQL.Queries;
using Ejemplo_GraphQL_Personas.GraphQL.Subscriptions;
using Ejemplo_GraphQL_Personas.GraphQL.Types;
using HotChocolate.Execution.Configuration;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public static class SchemaConfig
{
    public static IRequestExecutorBuilder AddGraphQLSchema( this IServiceCollection services)
    {
        return services
            //
            .AddScoped<PersonasQuery>() //Registra el servicio en el contenedor DI
            .AddScoped<PersonasMutation>() //Registra el servicio en el contenedor DI
            //.AddScoped<PersonasSubscription>() //Registra el servicio en el contenedor DI
            
            //                                       
            .AddGraphQLServer()
            
            //queries
            .AddQueryType<Query>() //
                .AddType<PersonasQuery>() // Expone los métodos de PersonasQuery como campos GraphQL

            //mutations
            .AddMutationType<Mutation>()//(d => d.Name("Mutation"))

            //subscriptions
            //.AddSubscriptionType<PersonasSubscription>()
            //    .AddSubscriptionType<Subscription>() // (d => d.Name("Subscription"))

            .AddSubscriptionType<Subscription>()

            //.AddSubscriptionType<Subscription>() // Registra la raíz
            //   .AddTypeExtension<PersonasSubscription>() // Extiende el tipo, no lo añade como objeto simple
            //    .AddType<PersonasSubscription>()

            .AddInMemorySubscriptions() //y canal de eventos

            //types
            .AddType<PersonaType>();
    }
}
