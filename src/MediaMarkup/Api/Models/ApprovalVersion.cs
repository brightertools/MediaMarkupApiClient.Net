using System;
using System.Collections.Generic;
using MediaMarkup.Core;
using Newtonsoft.Json;

namespace MediaMarkup.Api.Models
{
    public class ApprovalVersion
    {
        public ApprovalVersion()
        {
            Enabled = false;
            Locked = false;
            ApprovalGroups = new List<ApprovalGroup>();
        }

        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }

        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        [JsonProperty(PropertyName = "width")]
        public decimal Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public decimal Height { get; set; }

        [JsonProperty(PropertyName = "pageCount")]
        public int PageCount { get; set; }

        [JsonConverter(typeof(LongDataTypeConverter)), JsonProperty(PropertyName = "bytes")]
        public long Bytes { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "locked")]
        public bool Locked { get; set; }

        [JsonProperty(PropertyName = "userGroups")]
        public List<ApprovalGroup> ApprovalGroups { get; set; }
    }
}
