using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public enum NotificationChannelType {
        [EnumMember(Value = "portal")]
        Portal,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "phoneCall")]
        PhoneCall,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
