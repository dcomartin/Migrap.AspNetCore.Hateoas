using System;
using System.Linq;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    // Rel
    public static partial class DocumentExtensions {
        public static void Links(this Document document, Func<Document, Func<Rel>> rel, string href, dynamic meta = null) {
            document.Links.Add(rel(document)(), href, meta);
        }

        public static void Links(this Document document, Func<Document, Func<Rel>> rel, string format, params object[] args) {
            document.Links.Add(rel(document)(), string.Format(format, args));
        }

        public static Rel Self(this Document document) {
            return Rel.Self;
        }

        public static Rel Related(this Document document) {
            return Rel.Related;
        }

        public static Rel First(this Document document) {
            return Rel.First;
        }

        public static Rel Last(this Document document) {
            return Rel.Last;
        }

        public static Rel Prev(this Document document) {
            return Rel.Prev;
        }

        public static Rel Next(this Document document) {
            return Rel.Next;
        }
    }

    // Errors
    public static partial class DocumentExtensions {
        public static void Errors(this Document document, Action<Error> action) {
            document.Errors.Add(action);
        }

        public static void Errors(this Document document, Func<Errors, int> index, Action<Error> action) {
            action(document.Errors[index(document.Errors)]);
        }

        public static void Errors(this Document document, Func<Errors, Error> selector, Action<Error> action) {
            action(selector(document.Errors));
        }

        public static void Errors(this Document document, Func<Errors, IEnumerable<Error>> index, Action<Error> action) {
            index(document.Errors).Foreach(action);
        }

        public static void Errors(this Document document, Func<Document, Func<Error>> selector) {
            document.Errors.Add(selector(document)());
        }
    }

    // Included
    public static partial class DocumentExtensions {
        public static void Included(this Document document, Action<Resource> action) {
            document.Included.Add(action);
        }

        public static void Included(this Document document, Func<Included,Resource> selector, Action<Resource> action) {
            action(selector(document.Included));
        }

        public static void Included(this Document document, Func<Document, Func<Resource>> selector) {
            document.Included.Add(selector(document)());
        }
    }
}