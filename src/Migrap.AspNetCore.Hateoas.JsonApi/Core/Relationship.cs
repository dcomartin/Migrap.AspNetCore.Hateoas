using System;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Relationship {
        public Links Links { get; } = new Links();
        public object Data { get; set; }
        public Meta Meta { get; set; }                
    }

    public static partial class RelationshipExtensions {
        public static void Links(this Relationship relationship, Func<Relationship, Func<Rel>> rel, string href, dynamic meta = null) {
            relationship.Links.Add(rel(relationship)(), href, meta);
        }

        public static Rel Self(this Relationship relationship) {
            return Rel.Self;
        }

        public static Rel Related(this Relationship relationship) {
            return Rel.Related;
        }
    }
}