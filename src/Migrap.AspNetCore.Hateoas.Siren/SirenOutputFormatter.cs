using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Migrap.AspNetCore.Hateoas.Siren.Internal;

namespace Migrap.AspNetCore.Hateoas.Siren {
    public class SirenOutputFormatter : JsonOutputFormatter {
        public SirenOutputFormatter(SirenSerializerSettings serializerSettings, IList<IStateConverterProvider> stateConverters, ArrayPool<char> charPool)
            : base(serializerSettings, charPool) {

            StateConverters = stateConverters ?? throw new ArgumentNullException(nameof(StateConverters));

            SupportedEncodings.Clear();
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedMediaTypes.Clear();
            SupportedMediaTypes.Add(MediaTypeHeaderValues.ApplicationSiren);
        }

        public override bool CanWriteResult(OutputFormatterCanWriteContext context) {
            var result= base.CanWriteResult(context);
            return result;
        }

        protected override bool CanWriteType(Type type) {
            var result =  base.CanWriteType(type);
            return result;
        }

        public IList<IStateConverterProvider> StateConverters { get; } = new List<IStateConverterProvider>();

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding) {
            var response = context.HttpContext.Response;
            var converters = StateConverters;

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
        
        public virtual IStateConverter SelectConverter(StateConverterProviderContext context, IEnumerable<IStateConverterProvider> converters) {
            return converters.Select(x => x.CreateConverter(context)).FirstOrDefault(x => x != null);
        }
    }
}