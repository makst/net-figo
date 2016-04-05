using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figo.Internal
{
    [JsonObject]
    internal class RefreshTokenTokenRequest
    {
        [JsonProperty("grant_type")]
        public string GrantType { get { return "refresh_token"; } }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
