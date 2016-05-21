
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    internal class QueryBuilder : IQueryBuilder {
        private Query _query = new Query();

        public IQueryBuilder Href(Href value) {
            _query.Href = value;
            return this;
        }

        public IQueryBuilder Rel(Rel value) {
            _query.Rel = value;
            return this;
        }

        public IQueryBuilder Prompt(string value) {
            _query.Prompt = value;
            return this;
        }

        public Query Build() {
            return _query;
        }
    }
}