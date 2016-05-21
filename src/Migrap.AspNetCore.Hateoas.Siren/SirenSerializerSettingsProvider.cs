using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenSerializerSettingsProvider {
        private const int DefaultMaxDepth = 32;

        public static JsonSerializerSettings CreateSerializerSettings() {
            return new JsonSerializerSettings {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                MaxDepth = DefaultMaxDepth,
                TypeNameHandling = TypeNameHandling.None,
                Formatting = Formatting.Indented //TODO: may make this Indented if HostingEnvironment is Debug
            };
        }
    }
}