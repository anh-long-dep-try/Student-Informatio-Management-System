namespace SIMS_Project.Singleton
{
    public class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());

        public static T Instance => _instance.Value;

        // Protected constructor to prevent external instantiation
        protected Singleton() { }
    }
}