using Ejemplo_WebAPI_Inventario.GraphQL.Events;

namespace Ejemplo_GraphQL_Personas.GraphQL.Subscriptions;

//[ExtendObjectType("PersonasSubscription")]
public class PersonasSubscription
{
    [Subscribe]
    [Topic]
    public PersonaActualizadoEvent OnPersonaActualizado([EventMessage] PersonaActualizadoEvent input) => input;
}