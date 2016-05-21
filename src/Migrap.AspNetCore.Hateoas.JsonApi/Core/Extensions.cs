using System;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    internal static partial class Extensions {
        internal static void Foreach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach(var item in source) {
                action(item);
            }
        }
    }
}