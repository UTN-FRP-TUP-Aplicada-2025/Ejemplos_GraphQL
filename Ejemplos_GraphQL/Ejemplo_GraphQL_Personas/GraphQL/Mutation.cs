using Ejemplo_GraphQL_Personas.GraphQL.Mutations;
using HotChocolate.Subscriptions;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public class Mutation
{
    public PersonasMutation Personas( [Service] PersonasMutation mutation) => mutation;
}