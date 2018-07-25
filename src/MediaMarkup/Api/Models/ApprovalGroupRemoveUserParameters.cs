
using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// ApprovalGroupRemoveUserParameters for removing approval group users
    /// </summary>
    public class ApprovalGroupRemoveUserParameters
    {
        /// <summary>
        /// ApprovalGroupRemoveUserParameters
        /// </summary>
        public ApprovalGroupRemoveUserParameters()
        {
            Id = "";
            Version = 0;
            UserId = "";
            ApprovalGroupId = "";
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
        /// User Id
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Approval Group Id specifies the approval group Id to add the user to.<br />
        /// If approvalGroupId is empty or null and the appproval version only has 1 group, then the user will be added to that group
        /// </summary>
        [JsonProperty("approvalGroupId")]
        public string ApprovalGroupId { get; set; }
    }
}
