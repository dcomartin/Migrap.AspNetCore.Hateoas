using System.Buffers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Migrap.AspNetCore.Hateoas.Siren.Internal {
    public class MvcOptionsSetup : ConfigureOptions<MvcOptions> {
        public MvcOptionsSetup(IOptions<SirenOptions> sirenOptions, ArrayPool<char> charPool)
            : base((options) => ConfigureMvc(options, sirenOptions.Value.SerializerSettings, sirenOptions.Value.StateConverters, charPool)) {
        }

        private static void ConfigureMvc(MvcOptions options, SirenSerializerSettings serializerSettings, IList<IStateConverterProvider> stateConverters, ArrayPool<char> charPool) {
            options.OutputFormatters.Add(new SirenOutputFormatter(serializerSettings, stateConverters, charPool));
            options.FormatterMappings.SetMediaTypeMappingForFormat("siren", MediaTypeHeaderValues.ApplicationSiren);
        }
    }
}