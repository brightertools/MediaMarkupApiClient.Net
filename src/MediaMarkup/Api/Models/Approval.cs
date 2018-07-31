using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class Approval
    {
        public Approval()
        {
            Active = false;
            Versions = new List<ApprovalVersion>();
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ownerUserId")]
        public string OwnerUserId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTime LastUpdatedDate { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "versions")]
        public List<ApprovalVersion> Versions { get; set; }
    }
}
