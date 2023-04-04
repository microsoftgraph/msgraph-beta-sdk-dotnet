using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public enum LifecycleWorkflowCategory {
        [EnumMember(Value = "joiner")]
        Joiner,
        [EnumMember(Value = "leaver")]
        Leaver,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
