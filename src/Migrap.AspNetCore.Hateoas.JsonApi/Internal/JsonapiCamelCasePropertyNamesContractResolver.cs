using System.Collections;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Internal {
    internal class JsonapiCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver {
        private static readonly BindingFlags BindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase;

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
            var property = base.CreateProperty(member, memberSerialization);


            if(property.PropertyType.GetTypeInfo().GetInterface(typeof(IEnumerable).Name) != null && property.PropertyType != typeof(string)) {
                property.ShouldSerialize = instance => {
                    var enumerable = property.DeclaringType.GetProperty(property.PropertyName, BindingFlags).GetValue(instance) as IEnumerable;
                    return enumerable?.GetEnumerator().MoveNext() ?? false;
                };
            }

            return property;
        }
    }
}