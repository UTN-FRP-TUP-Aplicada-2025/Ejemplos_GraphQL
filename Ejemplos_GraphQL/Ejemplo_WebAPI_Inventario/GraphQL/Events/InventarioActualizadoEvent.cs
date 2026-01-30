namespace Ejemplo_WebAPI_Inventario.GraphQL.Events;

public class InventarioActualizadoEvent
{
    public int InventarioId { get; set; }
    public int PersonaDni { get; set; }
    public int Stock { get; set; }

}
