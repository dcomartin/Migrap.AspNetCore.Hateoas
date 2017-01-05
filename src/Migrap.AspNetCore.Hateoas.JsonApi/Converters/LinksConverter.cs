using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Migrap.AspNetCore.Hateoas.JsonApi.Core;
using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Converters {
    internal class LinksConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return typeof(IEnumerable<Link>).GetTypeInfo().IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            WriteJson(writer, value as IEnumerable<Link>, serializer);
        }

        private void WriteJson(JsonWriter writer, IEnumerable<Link> value, JsonSerializer serializer) {
            // serialize to dictionary<string,object>... if meta == null then just a string will be added vs the expanded representation.
            // great thing... Newtonsoft does the rest
            var links = value.ToDictionary(x => x.Rel, x => (x.Meta == null) ? (object)x.Href : (object)new { x.Href, x.Meta });
            serializer.Serialize(writer, links);
        }
    }
}