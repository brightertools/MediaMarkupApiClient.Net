using System.Collections.Generic;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Approval Create Result
    /// </summary>
    public class ApprovalCreateResult
    {
        /// <summary>
        /// Approval Id, this is empty if the approval could not be created
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Indicates if the creation has errors
        /// </summary>
        public bool HasErrors { get; set; }

        /// <summary>
        /// Error or other messages
        /// </summary>
        public List<string> Messages { get; set; }
    }
}
