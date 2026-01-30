namespace Ejemplo_WebAPI_Inventario.GraphQL.Subscriptions;

public class PersonaSubscription
{
    public InventariosSubscription Inventarios(
       [Service] InventariosSubscription subscription)
       => subscription;

}
