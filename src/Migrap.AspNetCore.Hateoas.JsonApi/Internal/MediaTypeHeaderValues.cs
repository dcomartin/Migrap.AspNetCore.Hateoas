using Microsoft.Net.Http.Headers;

namespace Migrap.AspNetCore.Hateoas.JsonApi.Internal {
    internal class MediaTypeHeaderValues {
        public static readonly MediaTypeHeaderValue ApplicationSiren = MediaTypeHeaderValue.Parse("application/vnd.api+json").CopyAsReadOnly();
    }
}