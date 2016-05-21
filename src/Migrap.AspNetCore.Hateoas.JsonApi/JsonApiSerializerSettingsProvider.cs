using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.JsonApi {
    internal static class JsonApiSerializerSettingsProvider {
        private const int DefaultMaxDepth = 32;

        public static JsonSerializerSettings Create() {
            return new JsonSerializerSettings {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                MaxDepth = DefaultMaxDepth,
                TypeNameHandling = TypeNameHandling.None,
                Formatting = Formatting.Indented
            };
        }
    }
}