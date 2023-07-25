using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum EmailEntityIdentifier {
        [EnumMember(Value = "networkMessageId")]
        NetworkMessageId,
        [EnumMember(Value = "recipientEmailAddress")]
        RecipientEmailAddress,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
