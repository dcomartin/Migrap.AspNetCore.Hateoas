using System;
using Microsoft.Extensions.DependencyInjection;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public static partial class MvcBuilderExtensions {
        public static IMvcBuilder AddSiren(this IMvcBuilder builder, Action<SirenOptions> setupAction) {
            builder.Services.Configure(setupAction);
            return builder;
        }
    }
}