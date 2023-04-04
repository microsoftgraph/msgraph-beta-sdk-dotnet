using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum LifecycleEventType {
        [EnumMember(Value = "missed")]
        Missed,
        [EnumMember(Value = "subscriptionRemoved")]
        SubscriptionRemoved,
        [EnumMember(Value = "reauthorizationRequired")]
        ReauthorizationRequired,
    }
}
