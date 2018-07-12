
namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Approval Group User
    /// </summary>
    public class ApprovalGroupUser
    {
        /// <summary>
        /// Approval Group User
        /// </summary>
        public ApprovalGroupUser()
        {
            UserId = "";
            CommentsEnabled = false;
            AllowDecision = false;
            AllowDownload = false;
        }

        /// <summary>
        /// User Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Allow the user to mkae comments
        /// </summary>
        public bool CommentsEnabled { get; set; }

        /// <summary>
        /// Allow the user to submit a decision
        /// </summary>
        public bool AllowDecision { get; set; }

        /// <summary>
        /// Allow the user to download the file
        /// </summary>
        public bool AllowDownload { get; set; }

        /// <summary>
        /// Allows version selection, otherwise only the latest version will be displayed for the user
        /// </summary>
        public bool AllowVersionSelection { get; set; }
    }
}
