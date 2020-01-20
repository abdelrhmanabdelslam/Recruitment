namespace Recruitment.Common.Helper
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="CacheStore" />
    /// </summary>
    public static class CacheStore
    {
        /// <summary>
        /// Defines the _cache
        /// </summary>
        private static Dictionary<string, object> _cache;

        /// <summary>
        /// Defines the _sync
        /// </summary>
        private static object _sync;

        /// <summary>
        /// Initializes static members of the <see cref="CacheStore"/> class.
        /// </summary>
        static CacheStore()
        {

            _cache = new Dictionary<string, object>();

            _sync = new object();
        }

        /// <summary>
        /// The Exists check if key exists in type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool Exists<T>(string key) where T : class
        {

            Type type = typeof(T);

            lock (_sync)

            {

                return _cache.ContainsKey(type.Name + key);

            }
        }

        /// <summary>
        /// The Exists  check if type T is  exists 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The <see cref="bool"/></returns>
        public static bool Exists<T>() where T : class
        {

            Type type = typeof(T);

            lock (_sync)
            {

                return _cache.ContainsKey(type.Name);

            }
        }

        /// <summary>
        /// The Get all cation type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The <see cref="T"/></returns>
        public static T Get<T>() where T : class
        {

            Type type = typeof(T);

            lock (_sync)

            {

                if (_cache.ContainsKey(type.Name) == false)

                    throw new ApplicationException("An object of the desired type does not exist: " + type.Name);



                lock (_sync)

                {

                    return (T)_cache[type.Name];

                }

            }
        }

        /// <summary>
        /// The Get cached key of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        public static T Get<T>(string key) where T : class
        {

            Type type = typeof(T);

            lock (_sync)

            {

                if (_cache.ContainsKey(key + type.Name) == false)

                    throw new ApplicationException(String.Format("An object with key '{0}' does not exists", key));

                lock (_sync)

                {

                    return (T)_cache[key + type.Name];

                }

            }
        }

        /// <summary>
        /// The Create 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        /// <param name="constructorParameters">The constructorParameters<see cref="object[]"/></param>
        /// <returns>The <see cref="T"/></returns>
        public static T Create<T>(string key, params object[] constructorParameters) where T : class
        {

            Type type = typeof(T);

            T value = (T)Activator.CreateInstance(type, constructorParameters);

            lock (_sync)

            {

                if (_cache.ContainsKey(key + type.Name))

                    throw new ApplicationException(String.Format("An object with key '{0}' already exists", key));

                lock (_sync)

                {

                    _cache.Add(key + type.Name, value);

                }

            }

            return value;
        }

        /// <summary>
        /// The Create
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="constructorParameters">The constructorParameters<see cref="object[]"/></param>
        /// <returns>The <see cref="T"/></returns>
        public static T Create<T>(params object[] constructorParameters) where T : class
        {

            Type type = typeof(T);

            T value = (T)Activator.CreateInstance(type, constructorParameters);



            lock (_sync)

            {

                if (_cache.ContainsKey(type.Name))

                    throw new ApplicationException(String.Format("An object of type '{0}' already exists", type.Name));

                lock (_sync)

                {

                    _cache.Add(type.Name, value);

                }

            }



            return value;
        }

        /// <summary>
        /// The Add
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        /// <param name="value">The value<see cref="T"/></param>
        public static void Add<T>(string key, T value)
        {

            Type type = typeof(T);



            if (value.GetType() != type)

                throw new ApplicationException(String.Format("The type of value passed to cache {0} does not match the cache type {1} for key {2}", value.GetType().FullName, type.FullName, key));

            lock (_sync)

            {

                if (_cache.ContainsKey(key + type.Name))

                    throw new ApplicationException(String.Format("An object with key '{0}' already exists", key));

                lock (_sync)

                {

                    _cache.Add(key + type.Name, value);

                }

            }
        }

        /// <summary>
        /// The Remove
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void Remove<T>()
        {

            Type type = typeof(T);



            lock (_sync)

            {

                if (_cache.ContainsKey(type.Name) == false)

                    throw new ApplicationException(String.Format("An object of type '{0}' does not exists in cache", type.Name));

                lock (_sync)

                {

                    _cache.Remove(type.Name);

                }

            }
        }

        /// <summary>
        /// The Remove
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        public static void Remove<T>(string key)
        {

            Type type = typeof(T);



            lock (_sync)

            {

                if (_cache.ContainsKey(key + type.Name) == false)

                    throw new ApplicationException(String.Format("An object with key '{0}' does not exists in cache", key));

                lock (_sync)

                {

                    _cache.Remove(key + type.Name);

                }

            }
        }
    }
}
