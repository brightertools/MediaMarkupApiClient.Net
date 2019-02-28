using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Approval Group Set Enabled Parameters
    /// </summary>
    public class ApprovalGroupSetEnabledParameters
    {
        /// <summary>
        /// ApprovalGroupSetEnabledParameters
        /// </summary>
        public ApprovalGroupSetEnabledParameters()
        {
            Id = "";
            Version = 0;
            ApprovalGroupId = "";
            Enabled = false;
        }

        /// <summary>
        /// The Approval Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The Approval Version
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// Approval Group Id specifies the approval group Id.<br />
        /// If approvalGroupId is empty or null and the appproval version only has 1 group, then enabled property will be set for that group
        /// </summary>
        [JsonProperty("approvalGroupId")]
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}