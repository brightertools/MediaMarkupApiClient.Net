using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Parameters for creating an approval version
    /// </summary>
    public class ApprovalCreateVersionParameters
    {
        /// <summary>
        /// ApprovalsCreateVersionParameters
        /// </summary>
        public ApprovalCreateVersionParameters()
        {
            LockPreviousVersion = false;
            CopyApprovalGroups = false;
        }

        /// <summary>
        /// Approval Id
        /// </summary>
        [JsonProperty("approvalId")]
        public string ApprovalId { get; set; }

        /// <summary>
        /// Lock previous version (current latest version)
        /// </summary>
        /// <example>true</example>
        [JsonProperty("lockPreviousVersion")]
        public bool LockPreviousVersion { get; set; }

        /// <summary>
        /// Copy all approval groups and users to the new version
        /// </summary>
        /// <example>true</example>
        [JsonProperty("copyApprovalGroups")]
        public bool CopyApprovalGroups { get; set; }
    }
}
