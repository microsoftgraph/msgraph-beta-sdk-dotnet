using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum DeviceIdEntityIdentifier {
        [EnumMember(Value = "deviceId")]
        DeviceId,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
