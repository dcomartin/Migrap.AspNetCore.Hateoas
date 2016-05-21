using System;
using System.Reflection;
using Migrap.AspNetCore.Hateoas.Siren.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Migrap.AspNetCore.Hateoas.Siren.Internal {
    public class SirenCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver {
        private const string Properties = "Properties";

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
            var property = base.CreateProperty(member, memberSerialization);

            if(property.DeclaringType == typeof(Document)) {
                if(property.PropertyType == typeof(Actions)) {
                    property.ShouldSerialize = instance => (instance as Document).Actions.Any();
                }
                else if(property.PropertyType == typeof(Links)) {
                    property.ShouldSerialize = instance => (instance as Document).Links.Any();
                }
                else if(property.PropertyType == typeof(Links)) {
                    property.ShouldSerialize = instance => (instance as Document).Links.Any();
                }
                else if(property.PropertyType == typeof(Entities)) {
                    property.ShouldSerialize = instance => (instance as Document).Entities.Any();
                }
                else if(property.PropertyType == typeof(Class)) {
                    property.ShouldSerialize = instance => (instance as Document).Class.Any();
                }
                else if(property.PropertyType == typeof(Rel)) {
                    property.ShouldSerialize = instance => (instance as Document).Rel.Any();
                }
                else if(property.PropertyName.Equals(Properties, StringComparison.OrdinalIgnoreCase)) {
                    property.ShouldSerialize = instance => (instance as Document).Properties != null && (instance as Document).Properties.GetType().GetProperties().Any();
                }
            }
            else if(property.DeclaringType == typeof(Entity)) {
                if(property.PropertyType == typeof(Actions)) {
                    property.ShouldSerialize = instance => (instance as Entity).Actions.Any();
                }
                else if(property.PropertyType == typeof(Links)) {
                    property.ShouldSerialize = instance => (instance as Entity).Links.Any();
                }
                else if(property.PropertyType == typeof(Entities)) {
                    property.ShouldSerialize = instance => (instance as Entity).Entities.Any();
                }
                else if(property.PropertyType == typeof(Class)) {
                    property.ShouldSerialize = instance => (instance as Entity).Class.Any();
                }
                else if(property.PropertyType == typeof(Rel)) {
                    property.ShouldSerialize = instance => (instance as Entity).Rel.Any();
                }
                else if(property.PropertyName.Equals(Properties, StringComparison.OrdinalIgnoreCase)) {
                    property.ShouldSerialize = instance => (instance as Entity).Properties != null && (instance as Entity).Properties.GetType().GetProperties().Any();
                }
            }

            return property;
        }
    }
}