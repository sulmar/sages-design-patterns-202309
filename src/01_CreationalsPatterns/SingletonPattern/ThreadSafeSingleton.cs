namespace SingletonPattern
{
    public class ThreadSafeSingleton<T>
    where T : class, new()
{
    private static object _syncLock = new object();

    private static T _instance;
    public static T Instance
    {
        get
        {
            lock (_syncLock)                // Monitor.Enter(_syncLock);
            {
                if (_instance == null)
                {
                    _instance = new T();
                }                           // Monitor.Exit(_syncLock);
            }

            return _instance;
        }
    }

}
