using Ejemplo_WebAPI_Inventario.Domain;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Mutations;

public class PersonasMutation
{
    private readonly IPersonaService _personaService;

    public PersonasMutation(IPersonaService personaService)
    {
        _personaService = personaService;
    }

    public Persona CrearPersona(CrearPersonaInput input)
    {
        var persona = new Persona
        {
            DNI = input.DNI,
            Nombre = input.Nombre
        };

        return _personaService.Create(persona);
    }

    public Persona ActualizarPersona(ActualizarPersonaInput input)
    {
        return _personaService.Update(
            input.DNI,
            input.Nombre
        );
    }

    public bool EliminarPersona(int dni)
    {
        return _personaService.Delete(dni);
    }

}
