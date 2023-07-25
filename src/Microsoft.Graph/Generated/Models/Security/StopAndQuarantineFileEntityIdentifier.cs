using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum StopAndQuarantineFileEntityIdentifier {
        [EnumMember(Value = "deviceId")]
        DeviceId,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "initiatingProcessSHA1")]
        InitiatingProcessSHA1,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
