using Ejemplo_WebAPI_Inventario.GraphQL.Events;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;


namespace Ejemplo_GraphQL_Personas.GraphQL.Subscriptions;

public class PersonasSubscription
{
    [Topic]
    [Subscribe]
    public PersonaActualizadoEvent OnPersonaActualizado([EventMessage] PersonaActualizadoEvent input) => input;
}