using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum RetentionTrigger {
        [EnumMember(Value = "dateLabeled")]
        DateLabeled,
        [EnumMember(Value = "dateCreated")]
        DateCreated,
        [EnumMember(Value = "dateModified")]
        DateModified,
        [EnumMember(Value = "dateOfEvent")]
        DateOfEvent,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
