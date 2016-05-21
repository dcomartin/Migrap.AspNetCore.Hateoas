using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.JsonApi {
    public class JsonApiOptions {
        public IList<IStateConverterProvider> Converters { get; } = new List<IStateConverterProvider>();
    }
}