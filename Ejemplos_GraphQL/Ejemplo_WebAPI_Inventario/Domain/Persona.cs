namespace Ejemplo_WebAPI_Inventario.Domain;

public class Persona
{
    public int DNI { get; set; }
    public string Nombre { get; set; }

    public List<Inventario> Items { get; set; }
}
