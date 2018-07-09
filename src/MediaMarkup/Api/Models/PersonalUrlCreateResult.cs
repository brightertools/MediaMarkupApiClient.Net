using System.Collections.Generic;

namespace MediaMarkup.Api.Models
{
    /// <summary>
    /// Personal Url Create Result
    /// </summary>
    public class PersonalUrlCreateResult
    {
        /// <summary>
        /// Secure Personal Url
        /// </summary>
        public string Url { get; set; }

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
