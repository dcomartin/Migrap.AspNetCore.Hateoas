using System;
using System.Reflection;

namespace Migrap.AspNetCore.Hateoas.Reap {
    public static partial class Extensions {
        internal static bool IsInstanceOfType(this Type type, object obj) {
            return type.GetTypeInfo().IsInstanceOfType(obj);
        }

        internal static bool IsInstanceOfType(this TypeInfo typeinfo, object obj) {
            return obj != null && typeinfo.IsAssignableFrom(obj.GetType().GetTypeInfo());
        }
    }
}