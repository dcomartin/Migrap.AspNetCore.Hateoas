using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenOptions {
        public IList<IStateConverterProvider> Converters { get; } = new List<IStateConverterProvider>();
    }
}