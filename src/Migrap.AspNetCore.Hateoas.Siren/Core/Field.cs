
namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public delegate Field FieldDelegate(string name, string title = null, object value = null);

    public class Field {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }

        public static readonly FieldDelegate Hidden = (name, title, value) => new Field { Name = name, Title = title, Type = "hidden", Value = value };
        public static readonly FieldDelegate Text = (name, title, value) => new Field { Name = name, Title = title, Type = "text", Value = value };
        public static readonly FieldDelegate Search = (name, title, value) => new Field { Name = name, Title = title, Type = "search", Value = value };
        public static readonly FieldDelegate Tel = (name, title, value) => new Field { Name = name, Title = title, Type = "tel", Value = value };
        public static readonly FieldDelegate Url = (name, title, value) => new Field { Name = name, Title = title, Type = "url", Value = value };
        public static readonly FieldDelegate Email = (name, title, value) => new Field { Name = name, Title = title, Type = "email", Value = value };
        public static readonly FieldDelegate Password = (name, title, value) => new Field { Name = name, Title = title, Type = "password", Value = value };
        public static readonly FieldDelegate DateTime = (name, title, value) => new Field { Name = name, Title = title, Type = "dateTime", Value = value };
        public static readonly FieldDelegate Date = (name, title, value) => new Field { Name = name, Title = title, Type = "date", Value = value };
        public static readonly FieldDelegate Month = (name, title, value) => new Field { Name = name, Title = title, Type = "month", Value = value };
        public static readonly FieldDelegate Week = (name, title, value) => new Field { Name = name, Title = title, Type = "week", Value = value };
        public static readonly FieldDelegate Time = (name, title, value) => new Field { Name = name, Title = title, Type = "time", Value = value };
        public static readonly FieldDelegate Number = (name, title, value) => new Field { Name = name, Title = title, Type = "number", Value = value };
        public static readonly FieldDelegate Range = (name, title, value) => new Field { Name = name, Title = title, Type = "range", Value = value };
        public static readonly FieldDelegate Color = (name, title, value) => new Field { Name = name, Title = title, Type = "color", Value = value };
        public static readonly FieldDelegate Checkbox = (name, title, value) => new Field { Name = name, Title = title, Type = "checkbox", Value = value };
        public static readonly FieldDelegate Radio = (name, title, value) => new Field { Name = name, Title = title, Type = "radio", Value = value };
        public static readonly FieldDelegate File = (name, title, value) => new Field { Name = name, Title = title, Type = "file", Value = value };
        public static readonly FieldDelegate Submit = (name, title, value) => new Field { Name = name, Title = title, Type = "submit", Value = value };
        public static readonly FieldDelegate Image = (name, title, value) => new Field { Name = name, Title = title, Type = "image", Value = value };
        public static readonly FieldDelegate Reset = (name, title, value) => new Field { Name = name, Title = title, Type = "reset", Value = value };
        public static readonly FieldDelegate Button = (name, title, value) => new Field { Name = name, Title = title, Type = "button", Value = value };
    }
}