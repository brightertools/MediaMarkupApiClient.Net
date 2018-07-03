using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class ApprovalSetActiveParameters
    {
        /// <summary>
        /// Approval Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Sets the Approval Active or Inactive.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}