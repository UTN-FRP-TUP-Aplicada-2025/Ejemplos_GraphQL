using Ejemplo_WebAPI_Inventario.Domain;

namespace Ejemplo_WebAPI_Inventario.GraphQL.Types;

public class PersonaType : ObjectType<Persona>
{
    protected override void Configure(IObjectTypeDescriptor<Persona> descriptor)
    {
        descriptor.Name("Persona");

        descriptor.Field(p => p.DNI)
                  .Type<NonNullType<IntType>>();

        descriptor.Field(p => p.Nombre)
                  .Type<NonNullType<StringType>>();

        descriptor.Field(p => p.Items)
                  .Type<NonNullType<ListType<NonNullType<InventarioType>>>>();
    }
}
