using System;

namespace Migrap.AspNetCore.Hateoas.Reap.Core {
    public delegate Func<TResult> ExtensionSelector<TSource, TResult>(TSource value) where TSource : IExtensible<TSource> where TResult : IExtension<TSource>;
}
