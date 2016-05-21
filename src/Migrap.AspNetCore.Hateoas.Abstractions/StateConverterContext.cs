using System;
using Microsoft.AspNetCore.Http;

namespace Migrap.AspNetCore.Hateoas {
    public class StateConverterContext {        
        public HttpContext HttpContext { get; set; }        
        public object Object { get; set; }
        public Type ObjectType { get; set; }
    }
}