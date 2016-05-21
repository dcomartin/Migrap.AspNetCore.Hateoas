
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    public interface ILinkBuilder : IFluent {
        ILinkBuilder Rel(Rel value);
        ILinkBuilder Href(Href value);
    }
}

