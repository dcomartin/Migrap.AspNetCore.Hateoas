using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Migrap.AspNetCore.Hateoas.Siren.Internal;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public static class MvcCoreBuilderExtensions {
        public static IMvcCoreBuilder AddSirenOptions(this IMvcCoreBuilder builder, Action<SirenOptions> setupAction) {
            if(builder == null) {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Services.Configure(setupAction);
            return builder;
        }

        internal static void AddSirenFormatterServices(IServiceCollection services) {
            services.TryAddEnumerable(ServiceDescriptor.Transient<IConfigureOptions<SirenOptions>, SirenOptionsSetup>());
        }
    }
}