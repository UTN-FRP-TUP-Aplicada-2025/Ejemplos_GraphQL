namespace Ejemplo_WebAPI_Inventario.GraphQL.Inputs;

public class ActualizarStockInput
{
    public int InventarioId { get; set; }
    public int Stock { get; set; }

}
