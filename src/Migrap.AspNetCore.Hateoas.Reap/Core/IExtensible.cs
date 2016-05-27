namespace Migrap.AspNetCore.Hateoas.Reap.Core {
    public interface IExtensible {
    }

    public interface IExtensible<T> : IExtensible where T : IExtensible<T> {
    }
}