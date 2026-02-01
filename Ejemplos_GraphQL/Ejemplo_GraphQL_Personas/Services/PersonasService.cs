using Ejemplo_GraphQL_Personas.Data;
using Ejemplo_GraphQL_Personas.Domain;

namespace Ejemplo_GraphQL_Personas.Services;

public class PersonasService
{
    public List<Persona> GetByAll()
    {
        return BancoDeDatos.Personas;
    }

    public Persona GetByDNI(int dni)
    {
        return (from p in BancoDeDatos.Personas where p.DNI == dni select p).FirstOrDefault();
    }

    public Persona Create(Persona persona)
    {
        BancoDeDatos.Personas.Add(persona);
        return persona;
    }

    public Persona Update(Persona persona)
    {
        Persona p = GetByDNI( persona.DNI );
        if (p != null)
        {
            p.Nombre = persona.Nombre;
            return persona;
        }
        return null;
    }

    public bool Delete(int dni)
    {
        Persona p = GetByDNI(dni);
        BancoDeDatos.Personas.Remove(p);
        return true;
    }
}