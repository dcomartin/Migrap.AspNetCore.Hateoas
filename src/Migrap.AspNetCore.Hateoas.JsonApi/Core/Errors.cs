using System;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Errors : List<Error> {
        
        public void Add(string id = "", Links links = null, string status = "", string code = "", string title = "", string detail = "", Source source = null, dynamic meta = null) {
        }        

        public static Errors operator +(Errors collection, Error error) {
            collection.Add(error);
            return collection;
        }
    }

    public static partial class ErrorsExtension {
        public static void Add(this Errors extension, Action<Error> action) {
            var item = new Error();
            action(item);
            extension.Add(item);
        }
    }
}