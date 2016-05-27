using System;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Reap.Core {
    public interface IExtensionCollection<T> : IDisposable, IDictionary<Type, IExtension<T>> where T : IExtensible<T> {
        int Revision { get; }
    }
}
