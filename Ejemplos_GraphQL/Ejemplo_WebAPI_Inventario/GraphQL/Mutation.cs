using Ejemplo_WebAPI_Inventario.GraphQL.Mutations;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public class Mutation
{
    public PersonasMutation Personas(
       [Service] PersonasMutation mutation) => mutation;

    public InventariosMutation Inventarios(
        [Service] InventariosMutation mutation) => mutation;

}
