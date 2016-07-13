using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenSerializerSettingsProvider {
        private const int DefaultMaxDepth = 32;

        public static SirenSerializerSettings CreateSerializerSettings() {
            return new SirenSerializerSettings {
                ContractResolver = new DefaultContractResolver {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                MissingMemberHandling = MissingMemberHandling.Ignore,
                MaxDepth = DefaultMaxDepth,
                TypeNameHandling = TypeNameHandling.None,                
            };
        }
    }
}