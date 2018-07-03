using System.Collections.Generic;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Approval Create Result
    /// </summary>
    public class ApprovalCreateVersionResult
    {
        /// <summary>
        /// Approval Id, this confirms the Approval Id that has been updated
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The version number created
        /// </summary>
        public int Version { get; set; }

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
