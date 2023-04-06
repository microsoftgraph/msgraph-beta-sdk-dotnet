using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public enum DeploymentStateReasonValue {
        [EnumMember(Value = "scheduledByOfferWindow")]
        ScheduledByOfferWindow,
        [EnumMember(Value = "offeringByRequest")]
        OfferingByRequest,
        [EnumMember(Value = "pausedByRequest")]
        PausedByRequest,
        [EnumMember(Value = "pausedByMonitoring")]
        PausedByMonitoring,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "faultedByContentOutdated")]
        FaultedByContentOutdated,
    }
}
