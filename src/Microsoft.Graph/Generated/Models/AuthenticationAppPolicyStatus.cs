using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum AuthenticationAppPolicyStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "appLockOutOfDate")]
        AppLockOutOfDate,
        [EnumMember(Value = "appLockEnabled")]
        AppLockEnabled,
        [EnumMember(Value = "appLockDisabled")]
        AppLockDisabled,
        [EnumMember(Value = "appContextOutOfDate")]
        AppContextOutOfDate,
        [EnumMember(Value = "appContextShown")]
        AppContextShown,
        [EnumMember(Value = "appContextNotShown")]
        AppContextNotShown,
        [EnumMember(Value = "locationContextOutOfDate")]
        LocationContextOutOfDate,
        [EnumMember(Value = "locationContextShown")]
        LocationContextShown,
        [EnumMember(Value = "locationContextNotShown")]
        LocationContextNotShown,
        [EnumMember(Value = "numberMatchOutOfDate")]
        NumberMatchOutOfDate,
        [EnumMember(Value = "numberMatchCorrectNumberEntered")]
        NumberMatchCorrectNumberEntered,
        [EnumMember(Value = "numberMatchIncorrectNumberEntered")]
        NumberMatchIncorrectNumberEntered,
        [EnumMember(Value = "numberMatchDeny")]
        NumberMatchDeny,
        [EnumMember(Value = "tamperResistantHardwareOutOfDate")]
        TamperResistantHardwareOutOfDate,
        [EnumMember(Value = "tamperResistantHardwareUsed")]
        TamperResistantHardwareUsed,
        [EnumMember(Value = "tamperResistantHardwareNotUsed")]
        TamperResistantHardwareNotUsed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
