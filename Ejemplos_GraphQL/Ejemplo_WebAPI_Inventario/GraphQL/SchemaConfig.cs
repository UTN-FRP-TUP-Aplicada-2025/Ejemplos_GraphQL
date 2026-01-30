using Ejemplo_WebAPI_Inventario.GraphQL.Mutations;
using Ejemplo_WebAPI_Inventario.GraphQL.Queries;
using Ejemplo_WebAPI_Inventario.GraphQL.Subscriptions;
using Ejemplo_WebAPI_Inventario.GraphQL.Types;
using HotChocolate.Execution.Configuration;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public static class SchemaConfig
{
    public static IRequestExecutorBuilder AddGraphQLSchema(
        this IServiceCollection services)
    {
        return services
            .AddGraphQLServer()
            .AddQueryType(d => d.Name("Query"))
                .AddType<PersonasQuery>()
            .AddMutationType(d => d.Name("Mutation"))
                .AddType<PersonasMutation>()
                .AddType<InventariosMutation>()
            .AddSubscriptionType(d => d.Name("Subscription"))
                .AddType<PersonaSubscription>()
            .AddType<PersonaType>()
            .AddType<InventarioType>();
    }
}
