using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcRemoteActionName {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "restart")]
        Restart,
        [EnumMember(Value = "rename")]
        Rename,
        [EnumMember(Value = "resize")]
        Resize,
        [EnumMember(Value = "restore")]
        Restore,
        [EnumMember(Value = "reprovision")]
        Reprovision,
        [EnumMember(Value = "changeUserAccountType")]
        ChangeUserAccountType,
        [EnumMember(Value = "troubleshoot")]
        Troubleshoot,
        [EnumMember(Value = "placeUnderReview")]
        PlaceUnderReview,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
