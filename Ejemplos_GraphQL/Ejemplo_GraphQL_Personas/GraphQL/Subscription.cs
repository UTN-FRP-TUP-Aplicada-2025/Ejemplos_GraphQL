using Ejemplo_GraphQL_Personas.GraphQL.Subscriptions;

namespace Ejemplo_GraphQL_Personas.GraphQL;

public class Subscription
{
    public PersonasSubscription Personas( [Service] PersonasSubscription subscription)  => subscription;

}
