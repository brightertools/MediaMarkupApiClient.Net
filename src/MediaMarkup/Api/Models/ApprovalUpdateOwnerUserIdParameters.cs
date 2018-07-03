using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class ApprovalUpdateOwnerUserIdParameters
    {
        /// <summary>
        /// Approval Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Approval Owner User Id
        /// </summary>
        [JsonProperty("ownerUserId")]
        public string OwnerUserId { get; set; }
    }
}
