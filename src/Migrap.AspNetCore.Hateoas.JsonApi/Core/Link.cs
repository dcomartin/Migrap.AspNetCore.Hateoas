namespace Migrap.AspNetCore.Hateoas.JsonApi.Core {
    public partial class Link {
        public Link(Rel rel, string href)
            : this(rel, href, null) {
        }

        public Link(Rel rel, string href, dynamic meta) {
            Rel = rel;
            Href = href;
            Meta = meta;
        }

        public Rel Rel { get; }

        public string Href { get; }

        public dynamic Meta { get; }
    }

    public partial class Link {
        public delegate Link CreateDelegate(string href, dynamic meta = null);
        public static readonly CreateDelegate About = (href, meta) => new Link(Rel.About, href, meta);
        public static readonly CreateDelegate Alternate = (href, meta) => new Link(Rel.Alternate, href, meta);
        public static readonly CreateDelegate Appendix = (href, meta) => new Link(Rel.Appendix, href, meta);
        public static readonly CreateDelegate Archives = (href, meta) => new Link(Rel.Archives, href, meta);
        public static readonly CreateDelegate Author = (href, meta) => new Link(Rel.Author, href, meta);
        public static readonly CreateDelegate Bookmark = (href, meta) => new Link(Rel.Bookmark, href, meta);
        public static readonly CreateDelegate Canonical = (href, meta) => new Link(Rel.Canonical, href, meta);
        public static readonly CreateDelegate Chapter = (href, meta) => new Link(Rel.Chapter, href, meta);
        public static readonly CreateDelegate Collection = (href, meta) => new Link(Rel.Collection, href, meta);
        public static readonly CreateDelegate Contents = (href, meta) => new Link(Rel.Contents, href, meta);
        public static readonly CreateDelegate Copyright = (href, meta) => new Link(Rel.Copyright, href, meta);
        public static readonly CreateDelegate CreateForm = (href, meta) => new Link(Rel.CreateForm, href, meta);
        public static readonly CreateDelegate Current = (href, meta) => new Link(Rel.Current, href, meta);
        public static readonly CreateDelegate Describedby = (href, meta) => new Link(Rel.Describedby, href, meta);
        public static readonly CreateDelegate Describes = (href, meta) => new Link(Rel.Describes, href, meta);
        public static readonly CreateDelegate Disclosure = (href, meta) => new Link(Rel.Disclosure, href, meta);
        public static readonly CreateDelegate Duplicate = (href, meta) => new Link(Rel.Duplicate, href, meta);
        public static readonly CreateDelegate Edit = (href, meta) => new Link(Rel.Edit, href, meta);
        public static readonly CreateDelegate EditForm = (href, meta) => new Link(Rel.EditForm, href, meta);
        public static readonly CreateDelegate EditMedia = (href, meta) => new Link(Rel.EditMedia, href, meta);
        public static readonly CreateDelegate Enclosure = (href, meta) => new Link(Rel.Enclosure, href, meta);
        public static readonly CreateDelegate First = (href, meta) => new Link(Rel.First, href, meta);
        public static readonly CreateDelegate Glossary = (href, meta) => new Link(Rel.Glossary, href, meta);
        public static readonly CreateDelegate Help = (href, meta) => new Link(Rel.Help, href, meta);
        public static readonly CreateDelegate Hosts = (href, meta) => new Link(Rel.Hosts, href, meta);
        public static readonly CreateDelegate Hub = (href, meta) => new Link(Rel.Hub, href, meta);
        public static readonly CreateDelegate Icon = (href, meta) => new Link(Rel.Icon, href, meta);
        public static readonly CreateDelegate Index = (href, meta) => new Link(Rel.Index, href, meta);
        public static readonly CreateDelegate Item = (href, meta) => new Link(Rel.Item, href, meta);
        public static readonly CreateDelegate Last = (href, meta) => new Link(Rel.Last, href, meta);
        public static readonly CreateDelegate LatestVersion = (href, meta) => new Link(Rel.LatestVersion, href, meta);
        public static readonly CreateDelegate License = (href, meta) => new Link(Rel.License, href, meta);
        public static readonly CreateDelegate Lrdd = (href, meta) => new Link(Rel.Lrdd, href, meta);
        public static readonly CreateDelegate Monitor = (href, meta) => new Link(Rel.Monitor, href, meta);
        public static readonly CreateDelegate MonitorGroup = (href, meta) => new Link(Rel.MonitorGroup, href, meta);
        public static readonly CreateDelegate Next = (href, meta) => new Link(Rel.Next, href, meta);
        public static readonly CreateDelegate NextArchive = (href, meta) => new Link(Rel.NextArchive, href, meta);
        public static readonly CreateDelegate Nofollow = (href, meta) => new Link(Rel.Nofollow, href, meta);
        public static readonly CreateDelegate Noreferrer = (href, meta) => new Link(Rel.Noreferrer, href, meta);
        public static readonly CreateDelegate Payment = (href, meta) => new Link(Rel.Payment, href, meta);
        public static readonly CreateDelegate PredecessorVersion = (href, meta) => new Link(Rel.PredecessorVersion, href, meta);
        public static readonly CreateDelegate Prefetch = (href, meta) => new Link(Rel.Prefetch, href, meta);
        public static readonly CreateDelegate Prev = (href, meta) => new Link(Rel.Prev, href, meta);
        public static readonly CreateDelegate Preview = (href, meta) => new Link(Rel.Preview, href, meta);
        public static readonly CreateDelegate Previous = (href, meta) => new Link(Rel.Previous, href, meta);
        public static readonly CreateDelegate PrevArchive = (href, meta) => new Link(Rel.PrevArchive, href, meta);
        public static readonly CreateDelegate PrivacyPolicy = (href, meta) => new Link(Rel.PrivacyPolicy, href, meta);
        public static readonly CreateDelegate Profile = (href, meta) => new Link(Rel.Profile, href, meta);
        public static readonly CreateDelegate Related = (href, meta) => new Link(Rel.Related, href, meta);
        public static readonly CreateDelegate Replies = (href, meta) => new Link(Rel.Replies, href, meta);
        public static readonly CreateDelegate Search = (href, meta) => new Link(Rel.Search, href, meta);
        public static readonly CreateDelegate Section = (href, meta) => new Link(Rel.Section, href, meta);
        public static readonly CreateDelegate Self = (href, meta) => new Link(Rel.Self, href, meta);
        public static readonly CreateDelegate Service = (href, meta) => new Link(Rel.Service, href, meta);
        public static readonly CreateDelegate Start = (href, meta) => new Link(Rel.Start, href, meta);
        public static readonly CreateDelegate Stylesheet = (href, meta) => new Link(Rel.Stylesheet, href, meta);
        public static readonly CreateDelegate Subsection = (href, meta) => new Link(Rel.Subsection, href, meta);
        public static readonly CreateDelegate SuccessorVersion = (href, meta) => new Link(Rel.SuccessorVersion, href, meta);
        public static readonly CreateDelegate Tag = (href, meta) => new Link(Rel.Tag, href, meta);
        public static readonly CreateDelegate TermsOfService = (href, meta) => new Link(Rel.TermsOfService, href, meta);
        public static readonly CreateDelegate Type = (href, meta) => new Link(Rel.Type, href, meta);
        public static readonly CreateDelegate Up = (href, meta) => new Link(Rel.Up, href, meta);
        public static readonly CreateDelegate VersionHistory = (href, meta) => new Link(Rel.VersionHistory, href, meta);
        public static readonly CreateDelegate Via = (href, meta) => new Link(Rel.Via, href, meta);
        public static readonly CreateDelegate WorkingCopy = (href, meta) => new Link(Rel.WorkingCopy, href, meta);
        public static readonly CreateDelegate WorkingCopyOf = (href, meta) => new Link(Rel.WorkingCopyOf, href, meta);

    }
}