using System;
using Microsoft.Extensions.DependencyInjection;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public static class MvcCoreBuilderExtensions {
        public static IMvcCoreBuilder AddSiren(this IMvcCoreBuilder builder, Action<SirenOptions> setupAction) {
            builder.Services.Configure(setupAction);
            return builder;
        }
    }
}