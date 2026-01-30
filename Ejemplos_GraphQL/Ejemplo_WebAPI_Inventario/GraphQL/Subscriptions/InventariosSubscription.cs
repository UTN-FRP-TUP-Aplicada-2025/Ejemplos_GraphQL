using Ejemplo_WebAPI_Inventario.GraphQL.Events;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Subscriptions;

public class InventariosSubscription
{
    [Subscribe]
    [Topic("InventarioActualizado")]
    public InventarioActualizadoEvent OnInventarioActualizado( InventarioActualizadoEvent evento)
    {
        return evento;
    }

}
