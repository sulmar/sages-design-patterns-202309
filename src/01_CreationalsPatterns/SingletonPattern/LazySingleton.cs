using System;

namespace SingletonPattern
{
    public class LazySingleton<T>
        where T : class, new()
    {
        private static Lazy<T> _instance = new Lazy<T>(() => new T());
        public static T Instance => _instance.Value;
    }
}
