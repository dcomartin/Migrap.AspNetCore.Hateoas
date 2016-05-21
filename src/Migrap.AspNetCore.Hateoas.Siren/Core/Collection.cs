#if MGP_LATER // Have to work to get this to compile with Orleans
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public abstract class Collection<T>(IEnumerable<T> collection = null) : IEnumerable<T> {
        private List<T> _collection = new List<T>(collection ?? Enumerable.Empty<T>());

        public Collection<T> Add(params T[] collection) {
            _collection.AddRange(collection);
            return this;
        }

        public IEnumerator<T> GetEnumerator() {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
#endif