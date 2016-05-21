using System;
using Microsoft.Extensions.DependencyInjection;

namespace Migrap.AspNetCore.Hateoas.JsonApi {
    public static class MvcBuilderExtensions {
        public static IMvcBuilder AddJsonApi(this IMvcBuilder builder, Action<JsonApiOptions> setupAction) {
            builder.Services.Configure(setupAction);
            return builder;
        }
    }
}