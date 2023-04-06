using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MediaSourceContentCategory {
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "liveStream")]
        LiveStream,
        [EnumMember(Value = "presentation")]
        Presentation,
        [EnumMember(Value = "screenRecording")]
        ScreenRecording,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
