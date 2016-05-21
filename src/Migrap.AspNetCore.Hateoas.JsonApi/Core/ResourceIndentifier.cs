using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class ResourceIndentifier {
        public ResourceIndentifier() {
        }

        public ResourceIndentifier(string type, string id) {
            Type = type;
            Id = id;
        }

        [JsonProperty(Order = 1)]
        public virtual string Type { get; set; }

        [JsonProperty(Order = 2)]
        public virtual string Id { get; set; }

        [JsonProperty(Order = 100)]
        public virtual Meta Meta { get; set; }
    }
}