using System;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    public class Link {
        public Rel Rel { get; set; } = new Rel();
        public Href Href { get; set; }
        
        public static readonly Func<Href, Link> About = (href) => new Link { Rel = Rel.About, Href = href };
        public static readonly Func<Href, Link> Alternate = (href) => new Link { Rel = Rel.Alternate, Href = href };
        public static readonly Func<Href, Link> Appendix = (href) => new Link { Rel = Rel.Appendix, Href = href };
        public static readonly Func<Href, Link> Archives = (href) => new Link { Rel = Rel.Archives, Href = href };
        public static readonly Func<Href, Link> Author = (href) => new Link { Rel = Rel.Author, Href = href };
        public static readonly Func<Href, Link> Bookmark = (href) => new Link { Rel = Rel.Bookmark, Href = href };
        public static readonly Func<Href, Link> Canonical = (href) => new Link { Rel = Rel.Canonical, Href = href };
        public static readonly Func<Href, Link> Chapter = (href) => new Link { Rel = Rel.Chapter, Href = href };
        public static readonly Func<Href, Link> Collection = (href) => new Link { Rel = Rel.Collection, Href = href };
        public static readonly Func<Href, Link> Contents = (href) => new Link { Rel = Rel.Contents, Href = href };
        public static readonly Func<Href, Link> Copyright = (href) => new Link { Rel = Rel.Copyright, Href = href };
        public static readonly Func<Href, Link> CreateForm = (href) => new Link { Rel = Rel.CreateForm, Href = href };
        public static readonly Func<Href, Link> Current = (href) => new Link { Rel = Rel.Current, Href = href };
        public static readonly Func<Href, Link> Describedby = (href) => new Link { Rel = Rel.Describedby, Href = href };
        public static readonly Func<Href, Link> Describes = (href) => new Link { Rel = Rel.Describes, Href = href };
        public static readonly Func<Href, Link> Disclosure = (href) => new Link { Rel = Rel.Disclosure, Href = href };
        public static readonly Func<Href, Link> Duplicate = (href) => new Link { Rel = Rel.Duplicate, Href = href };
        public static readonly Func<Href, Link> Edit = (href) => new Link { Rel = Rel.Edit, Href = href };
        public static readonly Func<Href, Link> EditForm = (href) => new Link { Rel = Rel.EditForm, Href = href };
        public static readonly Func<Href, Link> EditMedia = (href) => new Link { Rel = Rel.EditMedia, Href = href };
        public static readonly Func<Href, Link> Enclosure = (href) => new Link { Rel = Rel.Enclosure, Href = href };
        public static readonly Func<Href, Link> First = (href) => new Link { Rel = Rel.First, Href = href };
        public static readonly Func<Href, Link> Glossary = (href) => new Link { Rel = Rel.Glossary, Href = href };
        public static readonly Func<Href, Link> Help = (href) => new Link { Rel = Rel.Help, Href = href };
        public static readonly Func<Href, Link> Hosts = (href) => new Link { Rel = Rel.Hosts, Href = href };
        public static readonly Func<Href, Link> Hub = (href) => new Link { Rel = Rel.Hub, Href = href };
        public static readonly Func<Href, Link> Icon = (href) => new Link { Rel = Rel.Icon, Href = href };
        public static readonly Func<Href, Link> Index = (href) => new Link { Rel = Rel.Index, Href = href };
        public static readonly Func<Href, Link> Item = (href) => new Link { Rel = Rel.Item, Href = href };
        public static readonly Func<Href, Link> Last = (href) => new Link { Rel = Rel.Last, Href = href };
        public static readonly Func<Href, Link> LatestVersion = (href) => new Link { Rel = Rel.LatestVersion, Href = href };
        public static readonly Func<Href, Link> License = (href) => new Link { Rel = Rel.License, Href = href };
        public static readonly Func<Href, Link> Lrdd = (href) => new Link { Rel = Rel.Lrdd, Href = href };
        public static readonly Func<Href, Link> Monitor = (href) => new Link { Rel = Rel.Monitor, Href = href };
        public static readonly Func<Href, Link> MonitorGroup = (href) => new Link { Rel = Rel.MonitorGroup, Href = href };
        public static readonly Func<Href, Link> Next = (href) => new Link { Rel = Rel.Next, Href = href };
        public static readonly Func<Href, Link> NextArchive = (href) => new Link { Rel = Rel.NextArchive, Href = href };
        public static readonly Func<Href, Link> Nofollow = (href) => new Link { Rel = Rel.Nofollow, Href = href };
        public static readonly Func<Href, Link> Noreferrer = (href) => new Link { Rel = Rel.Noreferrer, Href = href };
        public static readonly Func<Href, Link> Payment = (href) => new Link { Rel = Rel.Payment, Href = href };
        public static readonly Func<Href, Link> PredecessorVersion = (href) => new Link { Rel = Rel.PredecessorVersion, Href = href };
        public static readonly Func<Href, Link> Prefetch = (href) => new Link { Rel = Rel.Prefetch, Href = href };
        public static readonly Func<Href, Link> Prev = (href) => new Link { Rel = Rel.Prev, Href = href };
        public static readonly Func<Href, Link> Preview = (href) => new Link { Rel = Rel.Preview, Href = href };
        public static readonly Func<Href, Link> Previous = (href) => new Link { Rel = Rel.Previous, Href = href };
        public static readonly Func<Href, Link> PrevArchive = (href) => new Link { Rel = Rel.PrevArchive, Href = href };
        public static readonly Func<Href, Link> PrivacyPolicy = (href) => new Link { Rel = Rel.PrivacyPolicy, Href = href };
        public static readonly Func<Href, Link> Profile = (href) => new Link { Rel = Rel.Profile, Href = href };
        public static readonly Func<Href, Link> Related = (href) => new Link { Rel = Rel.Related, Href = href };
        public static readonly Func<Href, Link> Replies = (href) => new Link { Rel = Rel.Replies, Href = href };
        public static readonly Func<Href, Link> Search = (href) => new Link { Rel = Rel.Search, Href = href };
        public static readonly Func<Href, Link> Section = (href) => new Link { Rel = Rel.Section, Href = href };
        public static readonly Func<Href, Link> Self = (href) => new Link { Rel = Rel.Self, Href = href };
        public static readonly Func<Href, Link> Service = (href) => new Link { Rel = Rel.Service, Href = href };
        public static readonly Func<Href, Link> Start = (href) => new Link { Rel = Rel.Start, Href = href };
        public static readonly Func<Href, Link> Stylesheet = (href) => new Link { Rel = Rel.Stylesheet, Href = href };
        public static readonly Func<Href, Link> Subsection = (href) => new Link { Rel = Rel.Subsection, Href = href };
        public static readonly Func<Href, Link> SuccessorVersion = (href) => new Link { Rel = Rel.SuccessorVersion, Href = href };
        public static readonly Func<Href, Link> Tag = (href) => new Link { Rel = Rel.Tag, Href = href };
        public static readonly Func<Href, Link> TermsOfService = (href) => new Link { Rel = Rel.TermsOfService, Href = href };
        public static readonly Func<Href, Link> Type = (href) => new Link { Rel = Rel.Type, Href = href };
        public static readonly Func<Href, Link> Up = (href) => new Link { Rel = Rel.Up, Href = href };
        public static readonly Func<Href, Link> VersionHistory = (href) => new Link { Rel = Rel.VersionHistory, Href = href };
        public static readonly Func<Href, Link> Via = (href) => new Link { Rel = Rel.Via, Href = href };
        public static readonly Func<Href, Link> WorkingCopy = (href) => new Link { Rel = Rel.WorkingCopy, Href = href };
        public static readonly Func<Href, Link> WorkingCopyOf = (href) => new Link { Rel = Rel.WorkingCopyOf, Href = href };
    }
}