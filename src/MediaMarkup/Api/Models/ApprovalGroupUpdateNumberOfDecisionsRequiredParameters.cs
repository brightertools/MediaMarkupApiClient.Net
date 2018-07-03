using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class ApprovalGroupUpdateNumberOfDecisionsRequiredParameters
    {
        /// <summary>
        /// ApprovalGroupUpdateNumberOfDecisionsRequiredParameters
        /// </summary>
        public ApprovalGroupUpdateNumberOfDecisionsRequiredParameters()
        {
            NumberOfDecisionsRequired = 0;
        }

        /// <summary>
        /// Approval Id
        /// </summary>
        public string ApprovalId { get; set; }

        /// <summary>
        /// Approval Group Id
        /// </summary>
        public string ApprovalGroupId { get; set; }

        /// <summary>
        /// Number of decisions required, 0 = all users in initial approval group
        /// </summary>
        [JsonProperty("numberOfDecisionsRequired")]
        public int? NumberOfDecisionsRequired { get; set; }
    }
}
