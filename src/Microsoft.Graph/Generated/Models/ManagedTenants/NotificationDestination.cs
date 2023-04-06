using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum NotificationDestination {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "api")]
        Api,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
