using System.Threading.Tasks;

namespace Migrap.AspNetCore.Hateoas {
    public interface IStateConverter {
        Task<object> ConvertAsync(StateConverterContext context);
    }
}