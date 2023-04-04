using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum QualityUpdateClassification {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "security")]
        Security,
        [EnumMember(Value = "nonSecurity")]
        NonSecurity,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
