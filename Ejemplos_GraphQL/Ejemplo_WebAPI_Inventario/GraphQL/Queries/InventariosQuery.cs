using Ejemplo_WebAPI_Inventario.Domain;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Queries;

public class InventariosQuery
{
    private readonly IInventarioService _inventarioService;

    public InventariosQuery(IInventarioService inventarioService)
    {
        _inventarioService = inventarioService;
    }

    public Inventario GetInventarioById(int id)
    {
        return _inventarioService.GetById(id);
    }

    public IEnumerable<Inventario> GetInventarios()
    {
        return _inventarioService.GetAll();
    }
}

