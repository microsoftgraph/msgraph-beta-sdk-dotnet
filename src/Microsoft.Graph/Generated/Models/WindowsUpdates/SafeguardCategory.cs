using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum SafeguardCategory {
        [EnumMember(Value = "likelyIssues")]
        LikelyIssues,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
