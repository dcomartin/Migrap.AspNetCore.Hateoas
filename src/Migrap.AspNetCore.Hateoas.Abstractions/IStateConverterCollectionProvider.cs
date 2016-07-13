using System;
using System.Collections.Generic;
using Migrap.AspNetCore.Hateoas.Infrastructure;

namespace Migrap.AspNetCore.Hateoas {
    public interface IStateConverterCollectionProvider {
        StateConverterCollection StateConverters { get; }
    }
}

namespace Migrap.AspNetCore.Hateoas.Infrastructure {
    public class StateConverterCollection {
        public StateConverterCollection(IReadOnlyList<IStateConverter> items, int version) {
            if(items == null) {
                throw new ArgumentNullException(nameof(items));
            }

            Items = items;
            Version = version;
        }

        public IReadOnlyList<IStateConverter> Items { get; }

        public int Version { get; }
    }
}