using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenOptions {
        public SirenSerializerSettings SerializerSettings { get; } = SirenSerializerSettingsProvider.CreateSerializerSettings();
        public IList<IStateConverterProvider> StateConverters { get; } = new List<IStateConverterProvider>();
    }
}