using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Resource : ResourceIndentifier {
        public Resource() {
        }

        public Resource(string type, string id)
            : base(type, id) {
        }

        [JsonProperty(Order = 10)]
        public object Attributes { get; set; }

        [JsonProperty(Order = 11)]
        public Links Links { get; set; } = new Links();

        [JsonProperty(Order = 12)]
        public Relationships Relationships { get; set; } = new Relationships();
    }
}