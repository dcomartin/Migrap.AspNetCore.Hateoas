using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public class Fields : IEnumerable<Field> {
        private List<Field> _collection;

        public Fields(IEnumerable<Field> collection = null) {
            _collection = new List<Field>(collection ?? Enumerable.Empty<Field>());
        }

        public Fields Add(params Field[] collection) {
            _collection.AddRange(collection);
            return this;
        }

        public IEnumerator<Field> GetEnumerator() {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}