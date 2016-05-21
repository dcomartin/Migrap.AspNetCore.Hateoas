
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    internal class EntityBuilder : IEntityBuilder {
        private Entity _entity = new Entity();        

        public IEntityBuilder Actions(Actions value) {
            _entity.Actions = value;
            return this;
        }

        public IEntityBuilder Class(Class value) {
            _entity.Class = value;
            return this;
        }

        public IEntityBuilder Entities(Entities value) {
            _entity.Entities = value;
            return this;
        }        

        public IEntityBuilder Href(Href value) {
            _entity.Href = value;
            return this;
        }

        public IEntityBuilder Links(Links value) {
            _entity.Links = value;
            return this;
        }

        public IEntityBuilder Properties(object value) {
            _entity.Properties = value;
            return this;
        }

        public IEntityBuilder Rel(Rel value) {
            _entity.Rel = value;
            return this;
        }

        public Entity Build() {
            return _entity;
        }
    }
}