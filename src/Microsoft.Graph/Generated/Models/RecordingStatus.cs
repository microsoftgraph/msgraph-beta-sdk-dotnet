using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RecordingStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "notRecording")]
        NotRecording,
        [EnumMember(Value = "recording")]
        Recording,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
