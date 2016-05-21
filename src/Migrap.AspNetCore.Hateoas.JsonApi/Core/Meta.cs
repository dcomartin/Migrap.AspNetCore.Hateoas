using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Meta : DynamicObject {
        private ConcurrentDictionary<string, object> _collection = new ConcurrentDictionary<string, object>(StringComparer.OrdinalIgnoreCase);

        public override bool TryGetMember(GetMemberBinder binder, out object result) {
            return _collection.TryGetValue(binder.Name, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value) {
            _collection.AddOrUpdate(binder.Name, value, (x, y) => value);
            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames() {
            return _collection.Keys;
        }
    }
}