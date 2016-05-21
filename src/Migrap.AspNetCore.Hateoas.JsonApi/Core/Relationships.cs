using System;
using System.Collections;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Relationships : IDictionary<string, Relationship> {
        private IDictionary<string, Relationship> _collection = new Dictionary<string, Relationship>(StringComparer.OrdinalIgnoreCase);

        public Relationship this[string key] {
            get { return _collection[key]; }
            set { _collection[key] = value; }
        }

        public int Count =>_collection.Count;

        public bool IsReadOnly =>false;

        public ICollection<string> Keys =>_collection.Keys;

        public ICollection<Relationship> Values =>_collection.Values;

        public void Add(KeyValuePair<string, Relationship> item) => _collection.Add(item);

        public void Add(string key, Relationship value) => _collection.Add(key, value);

        public void Clear() => _collection.Clear();

        public bool Contains(KeyValuePair<string, Relationship> item) => _collection.Contains(item);

        public bool ContainsKey(string key) => _collection.ContainsKey(key);

        public void CopyTo(KeyValuePair<string, Relationship>[] array, int arrayIndex) => _collection.CopyTo(array, arrayIndex);

        public IEnumerator<KeyValuePair<string, Relationship>> GetEnumerator() => _collection.GetEnumerator();

        public bool Remove(KeyValuePair<string, Relationship> item) => _collection.Remove(item);

        public bool Remove(string key) => _collection.Remove(key);

        public bool TryGetValue(string key, out Relationship value) => _collection.TryGetValue(key, out value);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}