using Ejemplo_WebAPI_Inventario.GraphQL.Events;

namespace Ejemplo_GraphQL_Personas.GraphQL.Subscriptions;

public class PersonasSubscription
{
    [Subscribe]
    [Topic("PersonaActualizado")]
    //[Subscribe(Topic = "PersonaActualizado")]
    public PersonaActualizadoEvent onPersonaActualizado([EventMessage] PersonaActualizadoEvent evento)//[EventMessage] es para indicar que es el mensaje del evento
    {
        return evento;
    }

}