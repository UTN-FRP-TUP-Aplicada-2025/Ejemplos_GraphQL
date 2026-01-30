using Ejemplo_WebAPI_Inventario.Domain;
using Ejemplo_WebAPI_Inventario.GraphQL.Inputs;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Mutations;

public class InventariosMutation
{
    private readonly IInventarioService _inventarioService;

    public InventariosMutation(IInventarioService inventarioService)
    {
        _inventarioService = inventarioService;
    }

    public Inventario CrearInventario(CrearInventarioInput input)
    {
        var inventario = new Inventario
        {
            PersonaDni = input.PersonaDni,
            Descripcion = input.Descripcion,
            Stock = input.Stock
        };

        return _inventarioService.Create(inventario);
    }

    public Inventario ActualizarStock(ActualizarStockInput input)
    {
        return _inventarioService.UpdateStock(
            input.InventarioId,
            input.Stock
        );
    }

    public bool EliminarInventario(int id)
    {
        return _inventarioService.Delete(id);
    }

}
