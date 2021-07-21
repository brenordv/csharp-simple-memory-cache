using System;
using System.Runtime.Caching;

namespace SimpleMemoryCache
{
    public static class SimpleCache
    {
        private const string UserCodeKey = "usercode";
        private const int TimeToLive = 10;
        private static readonly MemoryCache MemCache = MemoryCache.Default; 
        public static string UserCode
        {
            get => MemCache.Get(UserCodeKey)?.ToString();
            set => MemCache.Add(UserCodeKey, value, DateTime.Now.AddSeconds(TimeToLive));
        }
    }
}