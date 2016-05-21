
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
	public interface IItemBuilder : IFluent {
        IItemBuilder Name(string value);
        IItemBuilder Value(string value);
        IItemBuilder Prompt(string value);
	}
}

