using AgilityFramework.Http.Tokens;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RewardsApp.SQLite.Utilities
{
    public class AuthorizationCodeCredentials : ICredentials
    {
        private readonly List<string> _scopes;

        public AuthorizationCodeCredentials(string clientId, string clientSecret, string code, string redirectUri)
        {
            _scopes = new();

            ClientId = clientId;
            ClientSecret = clientSecret;
            Code = code;
            RedirectURI = redirectUri;
        }

        /// <summary>
        /// Gets the grant_type of this credentials.
        /// </summary>
        [JsonPropertyName("grant_type")]
        public string GrantType => "authorization_code";

        /// <summary>
        /// Gets the client_id of this credentials.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; private set; }

        /// <summary>
        /// Gets the code of this credentials.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the redirect_uri of this credentials.
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectURI { get; private set; }

        /// <summary>
        /// Gets the client_secret of this credentials.
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; private set; }

        /// <summary>
        /// Gets the scope of this credentials.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope => string.Join(" ", _scopes);

        /// <summary>
        /// Adds a scope to this credentials.
        /// </summary>
        /// <param name="scopes"></param>
        /// <returns>This credentials.</returns>
        public AuthorizationCodeCredentials AddScopes(params string[] scopes)
        {
            _scopes.AddRange(scopes);
            return this;
        }
    }
}
