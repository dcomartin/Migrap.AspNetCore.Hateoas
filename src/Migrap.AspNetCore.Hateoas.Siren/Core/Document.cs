using System;
using System.Reflection;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public partial class Document {
        public virtual Class Class { get; set; } = new Class();

        public Object Properties { get; set; }

        public Entities Entities { get; set; } = new Entities();

        public Links Links { get; set; } = new Links();

        public Actions Actions { get; set; } = new Actions();

        public Rel Rel { get; set; }

        public Href Href { get; set; }
    }

    public partial class Document<T> : Document {
        public override Class Class { get; set; } = typeof(T).GetTypeInfo().Name;
    }
}