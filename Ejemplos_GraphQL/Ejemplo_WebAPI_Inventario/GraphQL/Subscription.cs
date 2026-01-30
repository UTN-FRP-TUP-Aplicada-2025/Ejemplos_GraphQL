using Ejemplo_WebAPI_Inventario.GraphQL.Subscriptions;

namespace Ejemplo_WebAPI_Inventario.GraphQL;

public class Subscription
{
    public InventariosSubscription Inventarios(
    [Service] InventariosSubscription subscription)
    => subscription;

}
