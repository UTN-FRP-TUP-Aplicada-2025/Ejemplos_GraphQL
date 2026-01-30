using Ejemplo_WebAPI_Inventario.GraphQL.Queries;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public class Query
{
    public PersonasQuery Personas([Service] PersonasQuery query) => query;
    public InventariosQuery Inventarios([Service] InventariosQuery query) => query;
}

