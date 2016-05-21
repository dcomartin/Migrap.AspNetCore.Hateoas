using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Siren.Core {
    /// <see cref="http://www.iana.org/assignments/link-relations/link-relations.xml"/>
    public partial class Rel : List<string> {
        public static implicit operator Rel(string value) {
            return new Rel { value };
        }

        public static readonly Rel About = new Rel { "about" };
        public static readonly Rel Alternate = new Rel { "alternate" };
        public static readonly Rel Appendix = new Rel { "appendix" };
        public static readonly Rel Archives = new Rel { "archives" };
        public static readonly Rel Author = new Rel { "author" };
        public static readonly Rel Bookmark = new Rel { "bookmark" };
        public static readonly Rel Canonical = new Rel { "canonical" };
        public static readonly Rel Chapter = new Rel { "chapter" };
        public static readonly Rel Collection = new Rel { "collection" };
        public static readonly Rel Contents = new Rel { "contents" };
        public static readonly Rel Copyright = new Rel { "copyright" };
        public static readonly Rel CreateForm = new Rel { "create-form" };
        public static readonly Rel Current = new Rel { "current" };
        public static readonly Rel Describedby = new Rel { "describedby" };
        public static readonly Rel Describes = new Rel { "describes" };
        public static readonly Rel Disclosure = new Rel { "disclosure" };
        public static readonly Rel Duplicate = new Rel { "duplicate" };
        public static readonly Rel Edit = new Rel { "edit" };
        public static readonly Rel EditForm = new Rel { "edit-form" };
        public static readonly Rel EditMedia = new Rel { "edit-media" };
        public static readonly Rel Enclosure = new Rel { "encloser" };
        public static readonly Rel First = new Rel { "first" };
        public static readonly Rel Glossary = new Rel { "glossary" };
        public static readonly Rel Help = new Rel { "help" };
        public static readonly Rel Hosts = new Rel { "hosts" };
        public static readonly Rel Hub = new Rel { "hub" };
        public static readonly Rel Icon = new Rel { "icon" };
        public static readonly Rel Index = new Rel { "index" };
        public static readonly Rel Item = new Rel { "item" };
        public static readonly Rel Last = new Rel { "last" };
        public static readonly Rel LatestVersion = new Rel { "latest=version" };
        public static readonly Rel License = new Rel { "license" };
        public static readonly Rel Lrdd = new Rel { "lrdd" };
        public static readonly Rel Monitor = new Rel { "monitor" };
        public static readonly Rel MonitorGroup = new Rel { "monitor-group" };
        public static readonly Rel Next = new Rel { "next" };
        public static readonly Rel NextArchive = new Rel { "next-archive" };
        public static readonly Rel Nofollow = new Rel { "nofollow" };
        public static readonly Rel Noreferrer = new Rel { "noreferrer" };
        public static readonly Rel Payment = new Rel { "payment" };
        public static readonly Rel PredecessorVersion = new Rel { "predecessor-version" };
        public static readonly Rel Prefetch = new Rel { "prefetch" };
        public static readonly Rel Prev = new Rel { "prev" };
        public static readonly Rel Preview = new Rel { "preview" };
        public static readonly Rel Previous = new Rel { "previous" };
        public static readonly Rel PrevArchive = new Rel { "prev-archive" };
        public static readonly Rel PrivacyPolicy = new Rel { "privacy-policy" };
        public static readonly Rel Profile = new Rel { "profile" };
        public static readonly Rel Related = new Rel { "related" };
        public static readonly Rel Replies = new Rel { "replies" };
        public static readonly Rel Search = new Rel { "search" };
        public static readonly Rel Section = new Rel { "section" };
        public static readonly Rel Self = new Rel { "self" };
        public static readonly Rel Service = new Rel { "service" };
        public static readonly Rel Start = new Rel { "start" };
        public static readonly Rel Stylesheet = new Rel { "stylesheet" };
        public static readonly Rel Subsection = new Rel { "subsection" };
        public static readonly Rel SuccessorVersion = new Rel { "successor-version" };
        public static readonly Rel Tag = new Rel { "tag" };
        public static readonly Rel TermsOfService = new Rel { "terms-of-service" };
        public static readonly Rel Type = new Rel { "type" };
        public static readonly Rel Up = new Rel { "up" };
        public static readonly Rel VersionHistory = new Rel { "version-history" };
        public static readonly Rel Via = new Rel { "via" };
        public static readonly Rel WorkingCopy = new Rel { "working-copy" };
        public static readonly Rel WorkingCopyOf = new Rel { "working-copy-of" };
    }
}