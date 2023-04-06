using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum DriveItemSourceApplication {
        [EnumMember(Value = "teams")]
        Teams,
        [EnumMember(Value = "yammer")]
        Yammer,
        [EnumMember(Value = "sharePoint")]
        SharePoint,
        [EnumMember(Value = "oneDrive")]
        OneDrive,
        [EnumMember(Value = "stream")]
        Stream,
        [EnumMember(Value = "powerPoint")]
        PowerPoint,
        [EnumMember(Value = "office")]
        Office,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
