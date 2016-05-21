
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    public interface IActionBuilder : IFluent {
        IActionBuilder Name(string value);
        IActionBuilder Title(string value);
        IActionBuilder Method(string value);
        IActionBuilder Href(Href value);
        IActionBuilder Type(string value);
        IActionBuilder Fields(params Field[] collection);
    }
}
