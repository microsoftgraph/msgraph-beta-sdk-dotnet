using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WorkforceIntegrationSupportedEntities {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "shift")]
        Shift,
        [EnumMember(Value = "swapRequest")]
        SwapRequest,
        [EnumMember(Value = "userShiftPreferences")]
        UserShiftPreferences,
        [EnumMember(Value = "openShift")]
        OpenShift,
        [EnumMember(Value = "openShiftRequest")]
        OpenShiftRequest,
        [EnumMember(Value = "offerShiftRequest")]
        OfferShiftRequest,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "timeCard")]
        TimeCard,
        [EnumMember(Value = "timeOffReason")]
        TimeOffReason,
        [EnumMember(Value = "timeOff")]
        TimeOff,
        [EnumMember(Value = "timeOffRequest")]
        TimeOffRequest,
    }
}
