using Ejemplo_GraphQL_Personas.Domain;

namespace Ejemplo_GraphQL_Personas.GraphQL.Types;

public class PersonaType : ObjectType<Persona>
{
    protected override void Configure(IObjectTypeDescriptor<Persona> descriptor)
    {
        descriptor.Name("Persona");

        descriptor.Field(p => p.DNI)
                  .Type<NonNullType<IntType>>();

        descriptor.Field(p => p.Nombre)
                  .Type<NonNullType<StringType>>();
    }
}
