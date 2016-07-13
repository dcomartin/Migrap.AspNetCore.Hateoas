using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Migrap.AspNetCore.Hateoas.Siren.Converters;
using Migrap.AspNetCore.Hateoas.Siren.Internal;
using Newtonsoft.Json;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenOutputFormatter : JsonOutputFormatter {
        private JsonSerializerSettings _serializerSettings;
        private JsonSerializer _serializer;

        public SirenOutputFormatter(ArrayPool<char> charPool)
            : this(SirenSerializerSettingsProvider.CreateSerializerSettings(), charPool) {
        }

        public SirenOutputFormatter(JsonSerializerSettings serializerSettings, ArrayPool<char> charPool)
            : base(serializerSettings, charPool) {

            if(serializerSettings == null) {
                throw new ArgumentNullException(nameof(serializerSettings));
            }

            SupportedMediaTypes.Clear();            
            SupportedMediaTypes.Add(MediaTypeHeaderValues.ApplicationSiren);

            SupportedEncodings.Add(Encoding.UTF8);

            _serializerSettings.Converters.Add(new HrefJsonConverter());
            _serializerSettings.ContractResolver = new SirenCamelCasePropertyNamesContractResolver();
        }

        public IList<IStateConverterProvider> Converters { get; } = new List<IStateConverterProvider>();

        protected override JsonSerializer CreateJsonSerializer() {
            if(_serializer == null) {
                _serializer = JsonSerializer.Create(_serializerSettings);
            }

            return _serializer;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding) {
            var response = context.HttpContext.Response;
            var converters = GetDefaultConverters(context);

            var converterProviderContext = new StateConverterProviderContext {
                ObjectType = context.ObjectType
            };

            var selectedConverter = SelectConverter(converterProviderContext, converters);

            if(selectedConverter == null) {
                context.HttpContext.Response.StatusCode = StatusCodes.Status406NotAcceptable;
                return;
            }

            var converterContext = new StateConverterContext {
                HttpContext = context.HttpContext,
                Object = context.Object,
                ObjectType = context.ObjectType,
            };

            var document = await selectedConverter.ConvertAsync(converterContext);

            using(var writer = context.WriterFactory(response.Body, selectedEncoding)) {
                WriteObject(writer, document);

                await writer.FlushAsync();
            }
        }

        private IEnumerable<IStateConverterProvider> GetDefaultConverters(OutputFormatterWriteContext context) {
            var converters = default(IEnumerable<IStateConverterProvider>);

            if(Converters == null || Converters.Count == 0) {
                var options = context
                    .HttpContext
                    .RequestServices
                    .GetRequiredService<IOptions<SirenOptions>>()
                    .Value;
                converters = options.Converters;
            }

            return converters;
        }

        public virtual IStateConverter SelectConverter(StateConverterProviderContext context, IEnumerable<IStateConverterProvider> converters) {
            return converters.Select(x => x.CreateConverter(context)).FirstOrDefault(x => x != null);
        }
    }
}