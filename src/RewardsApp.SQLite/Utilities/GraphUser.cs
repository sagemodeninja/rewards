using System;
using System.Text.Json.Serialization;

namespace RewardsApp.SQLite.Utilities
{
    public class GraphUser
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
    }
}
