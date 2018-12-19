using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// ApprovalVersionLockParameters, for locking or unlocking an approval version
    /// </summary>
    public class ApprovalVersionLockParameters
    {
        /// <summary>
        /// Approval Group Reviewer Decision Parameters
        /// </summary>
        public ApprovalVersionLockParameters()
        {
            Id = "";
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
        /// Locked = true to lock version, else false
        /// </summary>
        [JsonProperty("locked")]
        public bool Locked { get; set; }
    }
}
