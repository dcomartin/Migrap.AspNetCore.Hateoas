using System;
using System.Collections.Generic;
using Migrap.AspNetCore.Hateoas.Siren.Core.Builders;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public static partial class Extensions {
        public static Actions Add(this Actions self, string name, string title, string method, Href href, string type = "application/x-www-form-urlencoded", IEnumerable<Field> fields = null) {
            var item = new Action {
                Name = name,
                Title = title,
                Method = method,
                Href = href,
                Type = type,
                Fields = (null == fields) ? null : new Fields(fields)
            };
            self.Add(item);
            return self;
        }

        public static Actions Add(this Actions self, Action<IActionBuilder> build) {
            var builder = new ActionBuilder();
            build(builder);
            var action = builder.Build();
            self.Add(action);
            return self;
        }

        public static Links Add(this Links self, Rel rel, Href href) {
            var item = new Link {
                Rel = rel,
                Href = href
            };
            self.Add(item);
            return self;
        }

        public static Links Add(this Links self, Action<ILinkBuilder> build) {
            var builder = new LinkBuilder();
            build(builder);
            var link = builder.Build();
            self.Add(link);
            return self;
        }

        public static Queries Add(this Queries self, Action<IQueryBuilder> build) {
            var builder = new QueryBuilder();
            build(builder);
            var query = builder.Build();
            self.Add(query);
            return self;
        }

        public static Fields Add(this Fields self, Action<IFieldBuilder> build) {
            var builder = new FieldBuilder();
            build(builder);
            var field = builder.Build();
            self.Add(field);
            return self;
        }

        public static Fields Add(this Fields self, object value) {
            return self;
        }

        //public static void Type(this IFieldBuilder self, HttpField field) {
        //    self.Type(field.Field);
        //}

        /// <summary>
        /// Activates the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static object Activate(this Type type) {
            return Activator.CreateInstance(type);
        }

        public static void Method(this IActionBuilder self, string value) {
            self.Method(value);
        }

        internal static Fields AsFields(this IEnumerable<Field> self) {
            return (self == null) ? new Fields() : new Fields(self);
        }

        public static Entity Add(this Entities self) {
            var entity = new Entity();
            self.Add(entity);
            return entity;
        }
    }
}