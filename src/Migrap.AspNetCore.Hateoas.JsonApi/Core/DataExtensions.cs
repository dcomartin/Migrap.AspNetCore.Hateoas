using System;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public static partial class DataExtensions {
        public static void Attributes(this Data data, Action<dynamic> attributes) {
            var value = new Attributes();
            attributes(value as dynamic);
            data.Attributes = value;
        }
    }
}