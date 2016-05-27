using System.Text;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using Migrap.AspNetCore.Hateoas.Siren.Converters;
using Migrap.AspNetCore.Hateoas.Siren.Internal;
using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenInputFormatter : JsonInputFormatter {
        public SirenInputFormatter(ILogger logger)
            : this(logger, SirenSerializerSettingsProvider.CreateSerializerSettings()) {
        }

        public SirenInputFormatter(ILogger logger, JsonSerializerSettings serializerSettings)
            : base(logger, serializerSettings) {
            SupportedMediaTypes.Clear();

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedMediaTypes.Add(MediaTypeHeaderValues.ApplicationSiren);

            SerializerSettings = serializerSettings;
            SerializerSettings.Converters.Add(new HrefJsonConverter());
            SerializerSettings.ContractResolver = new SirenCamelCasePropertyNamesContractResolver();
        }        
    }
}