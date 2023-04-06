using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EligibilityFilteringEnabledEntities {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "swapRequest")]
        SwapRequest,
        [EnumMember(Value = "offerShiftRequest")]
        OfferShiftRequest,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "timeOffReason")]
        TimeOffReason,
    }
}
