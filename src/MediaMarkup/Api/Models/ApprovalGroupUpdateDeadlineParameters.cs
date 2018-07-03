using System;
using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class ApprovalGroupUpdateDeadlineParameters
    {
        /// <summary>
        /// Approval Id
        /// </summary>
        public string ApprovalId { get; set; }

        /// <summary>
        /// Approval Group Id
        /// </summary>
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// Deadline date
        /// </summary>
        [JsonProperty("deadline")]
        public DateTime? Deadline { get; set; }
    }
}