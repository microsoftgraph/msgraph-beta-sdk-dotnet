using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RestrictionTrigger {
        [EnumMember(Value = "copyPaste")]
        CopyPaste,
        [EnumMember(Value = "copyToNetworkShare")]
        CopyToNetworkShare,
        [EnumMember(Value = "copyToRemovableMedia")]
        CopyToRemovableMedia,
        [EnumMember(Value = "screenCapture")]
        ScreenCapture,
        [EnumMember(Value = "print")]
        Print,
        [EnumMember(Value = "cloudEgress")]
        CloudEgress,
        [EnumMember(Value = "unallowedApps")]
        UnallowedApps,
    }
}
