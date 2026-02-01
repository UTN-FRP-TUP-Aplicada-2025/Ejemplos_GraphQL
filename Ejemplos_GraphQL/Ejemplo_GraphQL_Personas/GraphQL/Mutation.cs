using Ejemplo_GraphQL_Personas.GraphQL.Mutations;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public class Mutation
{
    public PersonasMutation Personas( [Service] PersonasMutation mutation) => mutation;
}
