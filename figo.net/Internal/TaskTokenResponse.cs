using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figo.Internal
{
    [JsonObject]
    class TaskTokenResponse
    {
        /// <summary>
        /// Task token
        /// </summary>
        [JsonProperty("task_token")]
        public String TaskToken { get; set; }
    }
}
