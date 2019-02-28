using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Approval Group Set Readonly Parameters
    /// </summary>
    public class ApprovalGroupSetReadOnlyParameters
    {
        /// <summary>
        /// ApprovalGroupSetEnabledParameters
        /// </summary>
        public ApprovalGroupSetReadOnlyParameters()
        {
            Id = "";
            Version = 0;
            ApprovalGroupId = "";
            Readonly = false;
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
        /// If approvalGroupId is empty or null and the appproval version only has 1 group, then Readonly property will be set for that group
        /// </summary>
        [JsonProperty("approvalGroupId")]
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// Readonly
        /// </summary>
        [JsonProperty("readonly")]
        public bool Readonly { get; set; }
    }
}