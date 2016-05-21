
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    internal class LinkBuilder : ILinkBuilder {
        private Link _link = new Link();

        public ILinkBuilder Rel(Rel value) {
            _link.Rel = value;
            return this;
        }
        public ILinkBuilder Href(Href value) {
            _link.Href = value;
            return this;
        }

        public Link Build() {
            return _link;
        }
    }
}