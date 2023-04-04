using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ShiftWorkCloudPcAccessState {
        [EnumMember(Value = "unassigned")]
        Unassigned,
        [EnumMember(Value = "noLicensesAvailable")]
        NoLicensesAvailable,
        [EnumMember(Value = "activationFailed")]
        ActivationFailed,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "activating")]
        Activating,
        [EnumMember(Value = "waitlisted")]
        Waitlisted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
