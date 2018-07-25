using System.Collections.Generic;
using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// ApprovalGroupUserParameters for adding and updating approval group users
    /// </summary>
    public class ApprovalGroupUsersParameters
    {
        /// <summary>
        /// Approval Group Reviewer
        /// </summary>
        public ApprovalGroupUsersParameters()
        {
            Id = "";
            Version = 0;
            Users = new List<ApprovalGroupUser>();
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
        /// Approval Group Id specifies the approval group Id to add the users to.<br />
        /// If approvalGroupId is empty or null and the appproval version only has 1 group, then the users will be added to that group
        /// </summary>
        [JsonProperty("approvalGroupId")]
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// Users of ApprovalGroupUser objects representing users to add to the approval version
        /// </summary>
        [JsonProperty("users")]
        public List<ApprovalGroupUser> Users { get; set; }
    }
}
