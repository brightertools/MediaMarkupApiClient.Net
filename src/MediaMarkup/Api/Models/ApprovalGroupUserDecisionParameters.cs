using MediaMarkup.Api.Data;
using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// ApprovalGroupUserDecisionParameters, for setting an approval user decision for an approval version approval group
    /// </summary>
    public class ApprovalGroupUserDecisionParameters
    {
        /// <summary>
        /// Approval Group Reviewer Decision Parameters
        /// </summary>
        public ApprovalGroupUserDecisionParameters()
        {
            Id = "";
            ApprovalGroupId = "";
            Version = 0;
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
        /// Approval Group Id specifies the approval group Id where all user decisions will be reset.<br />
        /// If approvalGroupId is empty or null and the approval version only has 1 group, then the users decisions for that single group will be reset.
        /// </summary>
        [JsonProperty("approvalGroupId")]
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// UserId to update
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// User Decision
        /// </summary>
        [JsonProperty(PropertyName = "decision")]
        public ApproverDecision Decision { get; set; }
    }
}
