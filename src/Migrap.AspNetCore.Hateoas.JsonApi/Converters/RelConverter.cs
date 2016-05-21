using System;
using Migrap.AspNetCore.Hateoas.JsonApi.Core;
using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Converters {
    internal class RelConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return objectType.Equals(typeof(Rel));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            if(value != null && value is Rel) {
                writer.WriteValue(((Rel)value).ToString());
            }
            return;
        }
    }
}