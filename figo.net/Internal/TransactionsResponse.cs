using Figo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figo.Internal
{
    /// <summary>
    /// Helper type to represent the actual answer from the figo API
    /// </summary>
    [JsonObject]
    internal class TransactionsResponse
    {
        /// <summary>
        /// List of transactions asked for
        /// </summary>
        [JsonProperty("transactions")]
        public List<FigoTransaction> Transactions { get; set; }

        /// <summary>
        /// Synchronization status between figo and bank servers
        /// </summary>
        [JsonProperty("status")]
        public FigoSynchronizationStatus Status { get; set; }
    }
}
