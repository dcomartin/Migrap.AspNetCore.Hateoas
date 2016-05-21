using Microsoft.Net.Http.Headers;

namespace Migrap.AspNetCore.Hateoas.Siren.Internal {
    internal class MediaTypeHeaderValues {
        public static readonly MediaTypeHeaderValue ApplicationSiren = MediaTypeHeaderValue.Parse("application/vnd.siren+json").CopyAsReadOnly();
    }
}