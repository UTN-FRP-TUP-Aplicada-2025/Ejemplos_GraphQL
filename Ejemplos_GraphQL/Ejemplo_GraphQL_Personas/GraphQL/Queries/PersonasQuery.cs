using Ejemplo_GraphQL_Personas.Domain;
using Ejemplo_GraphQL_Personas.Services;

namespace Ejemplo_GraphQL_Personas.GraphQL.Queries;

//[ExtendObjectType("Query")], HotChocolate los fusionará en un único Querytipo
//[ExtendObjectType("Query")] // This tells HC to put these fields in the root 'Query'
public class PersonasQuery
{
    PersonasService _personasService=default!;

    public PersonasQuery(PersonasService personasService)
    {
        _personasService = personasService;
    }

    public Persona GetPersonaByDNI(int dni)
    {
        return _personasService.GetByDNI(dni);
    }

    public IEnumerable<Persona> GetPersonas()
    {
        return _personasService.GetByAll();
    }
}

