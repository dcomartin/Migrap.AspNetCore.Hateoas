using System;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Infrastructure {
    public class StateConverterCollection {
        public StateConverterCollection(IReadOnlyList<IStateConverter> items, int version) {
            Items = items ?? throw new ArgumentNullException(nameof(items));
            Version = version;
        }

        public IReadOnlyList<IStateConverter> Items { get; }

        public int Version { get; }
    }
}