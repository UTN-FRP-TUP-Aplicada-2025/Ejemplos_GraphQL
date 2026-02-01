using Ejemplo_GraphQL_Personas.Domain;

namespace Ejemplo_GraphQL_Personas.Data;

public class BancoDeDatos
{
    public static List<Persona> Personas = new()
    {
        new (){DNI=30234323, Nombre="Ana" },
        new (){DNI=45623323, Nombre="Leonor" },
        new (){DNI=5623323, Nombre="Juan" }
    };

    
}
