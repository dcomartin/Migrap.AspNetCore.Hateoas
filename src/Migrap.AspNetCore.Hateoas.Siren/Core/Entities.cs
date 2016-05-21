using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public class Entities : IEnumerable<Entity> {
        private List<Entity> _collection;

        public Entities(IEnumerable<Entity> collection = null) {
            _collection = new List<Entity>(collection ?? Enumerable.Empty<Entity>());
        }

        public Entities Add(IEnumerable<Entity> collection) {
            _collection.AddRange(collection);
            return this;
        }

        public Entities Add(Entity item) {
            _collection.Add(item);
            return this;
        }

        public IEnumerator<Entity> GetEnumerator() {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }    
}