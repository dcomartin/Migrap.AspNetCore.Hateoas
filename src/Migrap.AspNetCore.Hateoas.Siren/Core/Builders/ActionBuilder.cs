
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    internal class ActionBuilder : IActionBuilder {
        private Action _action = new Action();        

        public IActionBuilder Fields(params Field[] collection) {
            _action.Fields.Add(collection);
            return this;
        }

        public IActionBuilder Href(Href value) {
            _action.Href = value;
            return this;
        }

        public IActionBuilder Method(string value) {
            _action.Method = value;
            return this;
        }

        public IActionBuilder Name(string value) {
            _action.Name = value;
            return this;
        }

        public IActionBuilder Title(string value) {
            _action.Title = value;
            return this;
        }

        public IActionBuilder Type(string value) {
            _action.Type = value;
            return this;
        }

        public Action Build() {
            return _action;
        }
    }
}
