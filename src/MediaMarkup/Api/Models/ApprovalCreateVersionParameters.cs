using System;
using System.Collections.Generic;
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
        /// Copy all approval groups and users to the new version (if users have been specified in Reviewers this is ignored)
        /// </summary>
        /// <example>true</example>
        [JsonProperty("copyApprovalGroups")]
        public bool CopyApprovalGroups { get; set; }

        /// <summary>
        /// Adds Reviewers to the approval version to an initial approval group (this overrides CopyApprovalGroups, which will not be copied across to the new version)
        /// </summary>
        [JsonProperty("reviewers")]
        public List<ApprovalGroupUser> Reviewers { get; set; }

        /// <summary>
        /// Number of decisions required, 0 = all users in initial approval group (if CopyApprovalGroups = false or or Reviewers have been specified)
        /// </summary>
        [JsonProperty("numberOfDecisionsRequired")]
        public int? NumberOfDecisionsRequired { get; set; }

        /// <summary>
        /// Deadline date for the initial approval group (if CopyApprovalGroups = false or or Reviewers have been specified)
        /// </summary>
        [JsonProperty("deadline")]
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Set to true to add the OwnerId user to the initial approval group added to the new version (only applied when CopyApprovalGroups = false or Reviewers have been specified)
        /// </summary>
        [JsonProperty("addOwnerToInitialApprovalGroup")]
        public bool? AddOwnerToInitialApprovalGroup { get; set; }


    }
}
