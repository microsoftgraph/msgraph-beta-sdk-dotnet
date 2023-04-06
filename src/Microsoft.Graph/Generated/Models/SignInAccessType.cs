using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum SignInAccessType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "b2bCollaboration")]
        B2bCollaboration,
        [EnumMember(Value = "b2bDirectConnect")]
        B2bDirectConnect,
        [EnumMember(Value = "microsoftSupport")]
        MicrosoftSupport,
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
