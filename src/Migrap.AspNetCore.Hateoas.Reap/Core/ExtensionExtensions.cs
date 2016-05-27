using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Migrap.AspNetCore.Hateoas.Reap.Core {
    public static partial class ExtensionExtensions {
        private static bool _initialized = false;
        private static object _lock = new object();
        private static ConditionalWeakTable<object, object> _extensions;

        private static ConditionalWeakTable<object, object> Extensions {
            get { return LazyInitializer.EnsureInitialized(ref _extensions, ref _initialized, ref _lock, () => new ConditionalWeakTable<object, object>()); }
        }

        public static TResult Extension<TSource, TResult>(this TSource source, ExtensionSelector<TSource, TResult> selector, Action<TResult> callback = null) where TSource : IExtensible<TSource> where TResult : IExtension<TSource> {
            var extensions = (ExtensionCollection<TSource>)Extensions.GetValue(source, (x) => new ExtensionCollection<TSource>());
            var extension = (IExtension<TSource>)null;

            if(false == extensions.TryGetValue(typeof(TResult), out extension)) {
                extension = (TResult)Activator.CreateInstance(typeof(TResult), source);
                extensions[typeof(TResult)] = extension;
            }

            callback?.Invoke((TResult)extension);

            return (TResult)extension;
        }
    }
}