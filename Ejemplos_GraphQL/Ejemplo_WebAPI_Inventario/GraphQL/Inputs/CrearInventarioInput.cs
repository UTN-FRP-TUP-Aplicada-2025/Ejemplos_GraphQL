namespace Ejemplo_WebAPI_Inventario.GraphQL.Inputs;

public class CrearInventarioInput
{
    public int PersonaDni { get; set; }
    public string Descripcion { get; set; }
    public int Stock { get; set; }

}
