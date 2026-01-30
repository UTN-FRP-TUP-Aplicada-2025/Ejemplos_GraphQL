
using Ejemplo_WebAPI_Inventario.Domain;

namespace Ejemplo_WebAPI_Inventario.Data;

public static class BancoDeDatos
{
    public static List<Persona> Personas = new()
    {
        new (){DNI=30234323, Nombre="Ana",
            Items=new List<Inventario>
            {
                new (){ Numero=101, Descripcion="Laptop Dell" },
                new (){ Numero=102, Descripcion="Mouse Logitech"}
            }
        },
        new (){DNI=45623323, Nombre="Leonor",
            Items=new List<Inventario>
            {
                new (){ Numero=201, Descripcion="Monitor 24''"}
            }
        },
        new (){DNI=5623323, Nombre="Juan", 
            Items=new List<Inventario>
            {
                new (){ Numero=201, Descripcion="Monitor 27''"}
            }
        }
    };
}