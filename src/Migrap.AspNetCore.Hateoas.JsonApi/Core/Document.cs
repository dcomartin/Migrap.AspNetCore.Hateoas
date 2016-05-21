namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public class Document {
        public Links Links { get; set; } = new Links();
        public dynamic Data { get; set; }
        public Meta Meta { get; set; }
        public Included Included { get; set; } = new Included();
        public Errors Errors { get; set; } = new Errors();
    }
}