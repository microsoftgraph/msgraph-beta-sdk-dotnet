using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CoachmarkLocationType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "fromEmail")]
        FromEmail,
        [EnumMember(Value = "subject")]
        Subject,
        [EnumMember(Value = "externalTag")]
        ExternalTag,
        [EnumMember(Value = "displayName")]
        DisplayName,
        [EnumMember(Value = "messageBody")]
        MessageBody,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
