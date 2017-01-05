using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Migrap.AspNetCore.Hateoas.Reap.Core {
    //internal static class xActivator {
    //    private static readonly ConcurrentDictionary<Type, ObjectActivator> activators = new ConcurrentDictionary<Type, ObjectActivator>();

    //    public delegate object ObjectActivator(params object[] args);

    //    static ObjectActivator GetActivator(ConstructorInfo ctor) {
    //        var paramsInfo = ctor.GetParameters();
    //        var param = Expression.Parameter(typeof(object[]), "args");
    //        var argsExp = new Expression[paramsInfo.Length];

    //        for(var i = 0; i < paramsInfo.Length; i++) {
    //            var index = Expression.Constant(i);
    //            var paramType = paramsInfo[i].ParameterType;
    //            var paramAccessorExp = Expression.ArrayIndex(param, index);
    //            var paramCastExp = Expression.Convert(paramAccessorExp, paramType);
    //            argsExp[i] = paramCastExp;
    //        }

    //        var newexp = Expression.New(ctor, argsExp);
    //        var lambda = Expression.Lambda(typeof(ObjectActivator), newexp, param);

    //        return (ObjectActivator)lambda.Compile();
    //    }

    //    public static void WarmInstanceConstructor(Type type) {
    //        if(!activators.ContainsKey(type)) {
    //            var constructors = type.GetTypeInfo().GetConstructors();
    //            if(constructors.Length == 1) {
    //                var ctor = constructors.First();
    //                activators.TryAdd(type, GetActivator(ctor));
    //            }
    //        }
    //    }

    //    public static object CreateInstance(Type type, params object[] args) {
    //        var activator = (ObjectActivator)null;

    //        if(!activators.TryGetValue(type, out activator)) {
    //            var constructors = type.GetConstructors();
    //            if(constructors.Length == 1) {
    //                var ctor = constructors.First();
    //                activator = GetActivator(ctor);
    //                activators.TryAdd(type, activator);
    //            }
    //            else {
    //                activator = (a) => Activator.CreateInstance(type, a);
    //            }

    //        }

    //        return activator(args);
    //    }

    //    public static object CreateInstance(Type type, bool @private, params object[] args) {
    //        var activator = (ObjectActivator)null;

    //        if(!activators.TryGetValue(type, out activator)) {
    //            var constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
    //            if(constructors.Length == 1) {
    //                var ctor = constructors.First();
    //                activator = GetActivator(ctor);
    //                activators.TryAdd(type, activator);
    //            }
    //            else {
    //                activator = (a) => Activator.CreateInstance(type, a);
    //            }

    //        }

    //        return activator(args);
    //    }
    //}
}