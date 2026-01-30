using Ejemplo_WebAPI_Inventario.Domain;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Queries;

public class PersonasQuery
{
    private readonly IPersonaService _personaService;

    public PersonasQuery(IPersonaService personaService)
    {
        _personaService = personaService;
    }

    public Persona GetPersonaById(int id)
    {
        return _personaService.GetById(id);
    }

    public IEnumerable<Persona> GetPersonas()
    {
        return _personaService.GetAll();
    }
}

