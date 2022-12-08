using AgilityFramework.Http.Authorization;
using RewardsApp.SQLite.Utilities;
using System.Threading.Tasks;

namespace RewardsApp.SQLite.Classes
{
    public class MsalAuthenticationProvider : IAuthorizationProvider
    {
        public MsalAuthenticationProvider(string[] scopes)
        {
            Scopes = scopes;
        }

        /// <inheritdoc />
        public IAccessToken AccessToken { get; private set; }

        public string[] Scopes { get; }

        /// <inheritdoc />
        public IAccessToken RequestAccessToken()
        {
            return RequestAccessTokenAsync().Result;
        }

        /// <inheritdoc />
        public async Task<IAccessToken> RequestAccessTokenAsync()
        {
            if (AccessToken is not null && !AccessToken.HasExpired())
                return AccessToken;

            var authResult = await Helper.SignInUserAndGetTokenUsingMsal(Scopes);
            AccessToken = new MsalAccessToken(authResult.AccessToken, authResult.ExpiresOn);

            return AccessToken;
        }

        /// <inheritdoc />
        public void Invalidate()
        {
            AccessToken = null;
        }
    }
}
