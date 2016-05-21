
namespace Migrap.AspNetCore.Hateoas.Siren.Core.Builders {
    internal class ItemBuilder : IItemBuilder {
        private Item _item = new Item();        

        public IItemBuilder Name(string value) {
            _item.Name = value;
            return this;
        }

        public IItemBuilder Prompt(string value) {
            _item.Prompt = value;
            return this;
        }

        public IItemBuilder Value(string value) {
            _item.Value = value;
            return this;
        }

        public Item Build() {
            return _item;
        }
    }
}