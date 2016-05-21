using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Links : List<Link> {
        public void Add(Rel rel, string href) {
            Add(new Link(rel, href));
        }

        public void Add(Rel rel, string href, dynamic meta) {
            Add(new Link(rel, href, meta));
        }

        public static Links operator +(Links collection, Link link) {
            collection.Add(link);
            return collection;
        }
    }
}