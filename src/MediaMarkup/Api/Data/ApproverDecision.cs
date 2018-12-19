using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MediaMarkup.Api.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApproverDecision
    {   
        None = 0,
        NotApproved = 1,
        Approved = 2,
        ApprovedConditionally = 3
    }
}