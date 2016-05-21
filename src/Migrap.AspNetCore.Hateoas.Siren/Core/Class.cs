using System.Collections;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public class Class : List<string> {
        public static implicit operator Class(string value) {
            return new Class { value };
        }
    }
}
