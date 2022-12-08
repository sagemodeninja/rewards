using Microsoft.Graph;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;

namespace RewardsApp.SQLite.Classes
{
    public class CustomGraphAuthenticationProvider : IAuthenticationProvider
    {
        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            var accessToken = await Program.GraphAuthorizationProvider.RequestAccessTokenAsync();
            request.Headers.Authorization = new AuthenticationHeaderValue("bearer", accessToken.AccessToken);
        }
    }
}
