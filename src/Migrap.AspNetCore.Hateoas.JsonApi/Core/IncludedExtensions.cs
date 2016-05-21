using System;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public static class IncludedExtensions {
        public static void Add(this Included extension, Action<Resource> action) {
            var item = new Resource();
            action(item);
            extension.Add(item);
        }
    }
}