using Microsoft.Identity.Client;
using RewardsApp.SQLite.Utilities;
using System.IO;
using System.Security.Cryptography;

namespace RewardsApp.SQLite.Classes
{
    public static class TokenCacheHelper
    {
        /// <summary>
        /// Path to the token cache
        /// </summary>
        private static readonly object FileLock = new();

        public static void BeforeAccessNotification(TokenCacheNotificationArgs args)
        {
            var cacheFilePath = Helper.InitializeWebViewCacheFile("msal_cache");
            lock (FileLock)
            {
                args.TokenCache.DeserializeMsalV3(File.Exists(cacheFilePath)
                    ? ProtectedData.Unprotect(File.ReadAllBytes(cacheFilePath),
                        null,
                        DataProtectionScope.CurrentUser)
                    : null);
            }
        }

        public static void AfterAccessNotification(TokenCacheNotificationArgs args)
        {
            // If the access operation resulted in a cache update
            if (!args.HasStateChanged) 
                return;
        
            lock (FileLock)
            {
                var cacheFilePath = Helper.InitializeWebViewCacheFile("msal_cache");
                // Reflect changes in the persistent store
                File.WriteAllBytes(cacheFilePath,
                    ProtectedData.Protect(args.TokenCache.SerializeMsalV3(),
                        null,
                        DataProtectionScope.CurrentUser)
                );
            }
        }

        internal static void EnableSerialization(ITokenCache tokenCache)
        {
            tokenCache.SetBeforeAccess(BeforeAccessNotification);
            tokenCache.SetAfterAccess(AfterAccessNotification);
        }
    }
}
