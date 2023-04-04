using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum BookingStaffMembershipStatus {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "pendingAcceptance")]
        PendingAcceptance,
        [EnumMember(Value = "rejectedByStaff")]
        RejectedByStaff,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
