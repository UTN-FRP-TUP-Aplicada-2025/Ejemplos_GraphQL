using Ejemplo_GraphQL_Personas.GraphQL.Queries;

namespace Ejemplo_GraphQL_Personas.GraphQL;

public class Query
{
    // Hot Chocolate inyecta la instancia desde el contenedor DI
    public PersonasQuery Personas([Service] PersonasQuery query) => query;
}
