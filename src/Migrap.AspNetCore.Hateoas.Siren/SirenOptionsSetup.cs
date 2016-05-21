using Microsoft.Extensions.Options;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenOptionsSetup : ConfigureOptions<SirenOptions> {
        public SirenOptionsSetup()
            : base(ConfigureSiren) {
        }

        public static void ConfigureSiren(SirenOptions options) {
        }
    }
}