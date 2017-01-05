using Migrap.AspNetCore.Hateoas.Infrastructure;

namespace Migrap.AspNetCore.Hateoas {
    public interface IStateConverterCollectionProvider {
        StateConverterCollection StateConverters { get; }
    }
}