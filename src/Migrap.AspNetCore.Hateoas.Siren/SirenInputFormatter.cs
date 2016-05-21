//using System;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc.Formatters;
//using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.Extensions.Logging;
//using Migrap.AspNetCore.Hypermedia.Formatters.Siren.Core;
//using Migrap.AspNetCore.Hypermedia.Formatters.Siren.Internal;
//using Newtonsoft.Json;

//namespace Migrap.AspNetCore.Hateoas.Siren {
//    public class SirenInputFormatter : JsonInputFormatter {
//        private readonly ILogger _logger;        

//        public SirenInputFormatter(ILogger logger)
//            : this(logger, SirenSerializerSettingsProvider.CreateSerializerSettings()) {
//        }

//        public SirenInputFormatter(ILogger logger, JsonSerializerSettings serializerSettings)
//            : base(logger, serializerSettings) {
//            SupportedEncodings.Add(Encoding.UTF8);
//            SupportedMediaTypes.Clear();

//            SupportedMediaTypes.Add(MediaTypeHeaderValues.ApplicationSiren);
                        
//            SerializerSettings = serializerSettings;
//            SerializerSettings.Formatting = Formatting.None;
//            SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
//            SerializerSettings.ContractResolver = new SirenCamelCasePropertyNamesContractResolver();
//        }

//        public override bool CanRead(InputFormatterContext context) {
//            return CanRead(context.ModelType, context);
//        }

//        private bool CanRead(Type type, InputFormatterContext context) {
//            return CanReadType(type) && base.CanRead(context);
//        }

//        protected override bool CanReadType(Type type) {
//            return typeof(Document).IsAssignableFrom(type);
//        }

//        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding) {
//            var result = await base.ReadRequestBodyAsync(context, encoding);

//            if(!result.HasError) {
//                context.ModelState.SetModelValue(nameof(Document), result.Model, null);
//            }

//            return result;
//        }
//    }
//}