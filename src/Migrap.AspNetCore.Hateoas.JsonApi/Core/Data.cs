namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Data : Resource {
        public Data() {
        }

        public Data(string type, string id)
            : base(type, id) {
        }
    }
}