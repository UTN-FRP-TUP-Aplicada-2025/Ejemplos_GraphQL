using Ejemplo_WebAPI_Inventario.Domain;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Types;

public class InventarioType : ObjectType<Inventario>
{
    protected override void Configure(IObjectTypeDescriptor<Inventario> descriptor)
    {
        descriptor.Name("Inventario");
        descriptor.Field(i => i.Numero).Type<NonNullType<IntType>>();
        descriptor.Field(i => i.Descripcion).Type<NonNullType<StringType>>();
    }
}

