using Ejemplo_GraphQL_Personas.GraphQL.Subscriptions;
using Ejemplo_WebAPI_Inventario.GraphQL.Events;

namespace Ejemplo_GraphQL_Personas.GraphQL;

public class Subscription
{
    //public PersonasSubscription Personas() => new PersonasSubscription();

    [Subscribe]
    [Topic]
    public PersonaActualizadoEvent OnPersonaActualizado([EventMessage] PersonaActualizadoEvent input) => input;
}
