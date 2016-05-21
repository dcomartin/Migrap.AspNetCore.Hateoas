namespace Migrap.AspNetCore.Hateoas {
    public interface IStateConverterProvider {
        IStateConverter CreateConverter(StateConverterProviderContext context);
    }
}