using System.Collections.Generic;

namespace DotNetCoreExtensions.Collections
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Returns a default value of type TObject if the key does not exist in the dictionary        
        /// </summary>
        /// <param name="dictionary">The dictionary to search</param>
        /// <param name="key">Key to search for</param>
        public static TObject GetValueOrDefault<TKey, TObject>(this Dictionary<TKey, TObject> dictionary, TKey key)
        {
            TObject value;
            return dictionary.TryGetValue(key, out value) ? value : default(TObject);
        }
    }
}