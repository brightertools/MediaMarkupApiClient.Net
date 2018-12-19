using System.Collections.Generic;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Approval Create Result
    /// </summary>
    public class ApprovalGroupCreateResult
    {
        /// <summary>
        /// Approval Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Approval Version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Approval Group Id
        /// </summary>
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// Indicates if the creation has errors
        /// </summary>
        public bool HasErrors { get; set; }

        /// <summary>
        /// Messages
        /// </summary>
        public List<string> Messages { get; set; }
    }
}
