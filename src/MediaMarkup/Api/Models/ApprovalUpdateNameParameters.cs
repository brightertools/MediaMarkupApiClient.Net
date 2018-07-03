using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class ApprovalUpdateNameParameters
    {
        /// <summary>
        /// Approval Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name / Description of the approval
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}