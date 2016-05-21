using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public class Queries: IEnumerable<Query> {
        private List<Query> _collection;

        public Queries(IEnumerable<Query> collection = null) {
            _collection = new List<Query>(collection ?? Enumerable.Empty<Query>());
        }

        public Queries Add(params Query[] collection) {
            _collection.AddRange(collection);
            return this;
        }

        public IEnumerator<Query> GetEnumerator() {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}