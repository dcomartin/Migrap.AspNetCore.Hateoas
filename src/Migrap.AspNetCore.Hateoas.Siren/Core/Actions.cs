using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public class Actions : IEnumerable<Action> {
        private List<Action> _collection;

        public Actions(IEnumerable<Action> collection = null) {
            _collection = new List<Action>(collection ?? Enumerable.Empty<Action>());
        }

        public Actions Add(params Action[] collection) {
            _collection.AddRange(collection);
            return this;
        }

        public IEnumerator<Action> GetEnumerator() {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}