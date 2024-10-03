using System.Collections.Concurrent;
using System.Reflection;

namespace MyOTTService.Json
{
    public abstract class AbstractClassLog
    {
        protected virtual Dictionary<string, Type> TMapping { get; }
        protected static ConcurrentDictionary<Type, ConstructorInfo> Cache { get; } = new ConcurrentDictionary<Type, ConstructorInfo>();

        protected static ConcurrentDictionary<Type, Func<object>> CtorCache { get; } = new ConcurrentDictionary<Type, Func<object>>();

        protected AbstractClassLog(IDictionary<string, Type> tm)
        {
            TMapping = new Dictionary<string, Type>(tm);
        }

        public Type FT(string name)
        {
            _ = name ?? throw new ArgumentNullException(nameof(name));
            if (!TMapping.TryGetValue(name, out Type result))
            {
                throw new SystemException();
            }

            return result;
        }
    }
}

