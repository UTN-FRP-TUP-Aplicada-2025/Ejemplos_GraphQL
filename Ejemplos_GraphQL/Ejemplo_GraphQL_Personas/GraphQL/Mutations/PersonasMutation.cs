using Ejemplo_GraphQL_Personas.Data;
using Ejemplo_GraphQL_Personas.Domain;
using Ejemplo_GraphQL_Personas.Services;
using Ejemplo_WebAPI_Inventario.GraphQL.Events;
using Ejemplo_WebAPI_Inventario.GraphQL.Inputs;
using HotChocolate.Subscriptions;

namespace Ejemplo_GraphQL_Personas.GraphQL.Mutations;

//[ExtendObjectType("Mutation")] // This tells HC to put these fields in the root 'Mutation'
public class PersonasMutation
{
    PersonasService _personasService=default!;
    private readonly ITopicEventSender _eventSender;
    public PersonasMutation(PersonasService personasService, ITopicEventSender eventSender)
    { 
        _personasService = personasService;
        _eventSender = eventSender;
    }

    public Persona CrearPersona(CrearPersonaInput input)
    {
        var persona = new Persona
        {
            DNI = input.DNI,
            Nombre = input.Nombre
        };

        return _personasService.Create(persona);
    }

    public async Task<Persona> ActualizarPersona(ActualizarPersonaInput input)
    {
        var persona= _personasService.Update(
            new Persona { DNI = input.DNI, Nombre = input.Nombre }
        );

        await _eventSender.SendAsync("PersonaActualizado",
            new PersonaActualizadoEvent
            {
                Dni = persona.DNI,
                Nombre = persona.Nombre
            });

        return persona;
    }

    public bool EliminarPersona(int dni)
    {
        return _personasService.Delete(dni);
    }
}
