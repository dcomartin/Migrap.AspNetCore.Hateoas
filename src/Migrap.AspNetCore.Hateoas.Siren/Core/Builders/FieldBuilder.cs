
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    internal class FieldBuilder : IFieldBuilder {
        private Field _field = new Field();        

        public IFieldBuilder Name(string value) {
            _field.Name = value;
            return this;
        }

        public IFieldBuilder Type(string value) {
            _field.Type = value;
            return this;
        }

        public IFieldBuilder Value(object value) {
            _field.Value = value;
            return this;
        }

        public Field Build() {
            return _field;
        }
    }
}