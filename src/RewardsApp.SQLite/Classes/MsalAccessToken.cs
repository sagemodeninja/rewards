using AgilityFramework.Http.Authorization;
using System;

namespace RewardsApp.SQLite.Classes
{
    /// <summary>
    /// An implementation of <see cref="IAccessToken"/> based of <see cref="Microsoft.Identity.Client.AuthenticationResult">AuthenticationResult</see>.
    /// </summary>
    public class MsalAccessToken : IAccessToken
    {
        public MsalAccessToken(string accessToken, DateTimeOffset expiresOn)
        {
            AccessToken = accessToken;
            ExpiresOn = expiresOn;
        }

        /// <inheritdoc />
        public string AccessToken { get; }

        /// <inheritdoc />
        public string Bearer => $"Bearer {AccessToken}";

        /// <summary>
        /// Gets the point in time in which the Access Token returned in the AccessToken property ceases to be valid.
        /// </summary>
        public DateTimeOffset ExpiresOn { get; }

        /// <inheritdoc />
        public bool HasExpired()
        {
            return DateTime.UtcNow >= ExpiresOn.UtcDateTime;
        }
    }
}
