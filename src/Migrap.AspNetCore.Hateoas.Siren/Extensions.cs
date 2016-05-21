using System.Collections.Generic;
using System.Linq;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public static partial class Extensions {
        internal static bool Any<TSource>(this IEnumerable<TSource> source) {
            return null != source && Enumerable.Any(source);
        }
    }
}
