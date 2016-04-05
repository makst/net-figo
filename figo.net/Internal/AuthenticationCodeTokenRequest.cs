using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figo.Internal
{
    [JsonObject]
    internal class AuthenticationCodeTokenRequest
    {
        [JsonProperty("grant_type")]
        public string GrantType { get { return "authorization_code"; } }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }
    }
}
